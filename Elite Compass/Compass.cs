using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elite_Compass
{
    public partial class Compass : Form
    {
        private bool dialogDestinationOpen=false;
        private bool dialogSettingsOpen=false;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);



        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hwnd, uint message, int wParam, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hwnd, uint message, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, IntPtr wParam, IntPtr lParam);


        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        Status statusFile = new Status();

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        //Used from this
        //https://stackoverflow.com/a/12869609
        //double hdgDiff(double h1, double h2)
        //{ // angle between two headings
        //    const double diff = fmod(h1 - h2 + 3600, 360);
        //    return diff <= 180 ? diff : 360 - diff;
        //}

        bool isTurnCCW(double hdg, double newHdg)
        { // should a new heading turn left ie. CCW?
            double diff = newHdg - hdg;        // CCW = counter-clockwise ie. left
            return diff > 0 ? diff > 180 : diff >= -180;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                int hotkeyId = m.WParam.ToInt32();

                if (hotkeyId == 0)
                {
                    //Have a destination?
                    if(!(Program.appSettings.Latitude == 0 && Program.appSettings.Longitude == 0))
                    {
                        //We need a destination.
                        ShowDestination();
                    }
                    
                    //Toggle visibility
                    this.Visible = !(this.Visible);

                }
                else
                {
                    ShowDestination();
                }
            }
        }
        

        public Compass()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, 0, (int)KeyModifier.Control, Keys.F9.GetHashCode());
            RegisterHotKey(this.Handle, 1, (int)KeyModifier.Shift | (int)KeyModifier.Control, Keys.F9.GetHashCode());
        }

        private void edCompassNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        //Used from this
        //https://stackoverflow.com/a/2042883
        static double DegreeBearing(double lat1, double lon1,double lat2, double lon2)
        {
            var dLon = ToRad(lon2 - lon1);
            var dPhi = Math.Log(Math.Tan(ToRad(lat2) / 2 + Math.PI / 4) / Math.Tan(ToRad(lat1) / 2 + Math.PI / 4));
            if (Math.Abs(dLon) > Math.PI)
                dLon = dLon > 0 ? -(2 * Math.PI - dLon) : (2 * Math.PI + dLon);
            return ToBearing(Math.Atan2(dLon, dPhi));
        }

        public static double ToRad(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }

        public static double ToBearing(double radians)
        {
            // convert radians to degrees (as bearing: 0...360)
            return (ToDegrees(radians) + 360) % 360;
        }

        private void Compass_Load(object sender, EventArgs e)
        {

            Program.appSettings.Load();

            if(Program.appSettings.WindowXPos != 0 || Program.appSettings.WindowYPos != 0)
            {
                this.Left = Program.appSettings.WindowXPos;
                this.Top = Program.appSettings.WindowYPos;
            }

            //Valid journal?
            if (Program.appSettings.JournalDirectoryExists() == false)
            {
                ShowSettings();
            }

            //Start reading the file (if it exists)
            compassTimer.Enabled = true;
          

        }

        private void ReadStatusFile()
        {
            double newBearing;

            try
            {
                using (StreamReader r = new StreamReader(Program.appSettings.JournalDirectory + "\\Status.json"))
                {
                    //Parse the file
                    string json = r.ReadToEnd();
                    statusFile = JsonConvert.DeserializeObject<Status>(json);

                    //Have planetary data?
                    if((statusFile.Altitude > 0) && !(Program.appSettings.Latitude == 0 && Program.appSettings.Longitude == 0))
                    {
                        this.Visible = true;
                    }
                    else
                    {
                        //Hide
                        this.Visible = false;
                    }                
                }
                //Update Bearing
                newBearing = Math.Round(DegreeBearing(statusFile.Latitude, statusFile.Longitude, Program.appSettings.Latitude, Program.appSettings.Longitude),0);
                bearingLabel.Text = newBearing.ToString();

                //Clockwise?
                if(isTurnCCW(statusFile.Heading, newBearing))
                {
                    HeadingLeft.Visible = true;
                    HeadingRight.Visible = false;
                }
                else
                {
                    HeadingLeft.Visible = false;
                    HeadingRight.Visible = true;
                }
            }
            catch(Exception readError)
            {
                bearingLabel.Text = "---";
                HeadingLeft.Visible = false;
                HeadingRight.Visible = false;

            }
            
        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        

        private void ShowDestination()
        {
            //Already open
            if (dialogDestinationOpen)
            {
                return;
            }
            
            //Open
            dialogDestinationOpen = true;
            Destination headingForm = new Destination();
            headingForm.ShowDialog();
            dialogDestinationOpen = false;
        }

        private void ShowSettings()
        {
            if (dialogSettingsOpen)
            {
                //Already open
                return;
            }
            dialogSettingsOpen = true;
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
            dialogSettingsOpen = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void Compass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }

            //Update position
            Program.appSettings.WindowXPos = this.Left;
            Program.appSettings.WindowYPos = this.Top;
            Program.appSettings.Save();
            

            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);
        }

        private void edCompassMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void setHeadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDestination();
        }

        private void compassTimer_Tick(object sender, EventArgs e)
        {
            ReadStatusFile();
        }

        private void bearingLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void MouseDrag()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void HeadingLeft_Click(object sender, EventArgs e)
        {
            
            
        }

        private void HeadingRight_Click(object sender, EventArgs e)
        {
         
        }

        private void HeadingLeft_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void bearingLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDrag();
            }
        }

        private void HeadingRight_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
