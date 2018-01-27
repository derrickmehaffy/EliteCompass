using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elite_Compass
{
    public partial class Destination : Form
    {
        public Destination()
        {
            InitializeComponent();
        }

        private void Latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void Latitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.')){
                e.Handled = Latitude.Text.Contains(".");
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void longitudeLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.'))
            {
                e.Handled = Longitude.Text.Contains(".");
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.appSettings.Latitude = Double.Parse(Latitude.Text);
                Program.appSettings.Longitude = Double.Parse(Longitude.Text);

                Program.appSettings.Save();

                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Latitude and Longitude must be a valid decimal in 00.00 format");
            }

            


        }

        private void latLng_TextChanged(object sender, EventArgs e)
        {
            string latlng = Regex.Replace(latLng.Text, @"\s+", "");
            double lat;
            double lng;
            bool valid = true;

            string[] data = latlng.Split(new Char[] { ',', ';', '/', '\\' });
            if (data.Length == 2)
            {
                //Have 2 pieces.. are they valid?
                if (!double.TryParse(data[0], out lat))
                {
                    valid = false;
                }

                if (!double.TryParse(data[1], out lng))
                {
                    valid = false;
                }

                if (valid)
                {
                    Latitude.Text = lat.ToString();
                    Longitude.Text = lng.ToString();
                }
            }
        }

        private void Heading_Load(object sender, EventArgs e)
        {
            Latitude.Text = Program.appSettings.Latitude.ToString();
            Longitude.Text = Program.appSettings.Longitude.ToString();
        }
    }
}
