using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Compass
{
    class Settings
    {
        public string JournalDirectory = "";
        public double Latitude = 0;
        public double Longitude = 0;
        public int WindowXPos = 0;
        public int WindowYPos = 0;

        public void Load()
        {
            JournalDirectory = Properties.Settings.Default.JournalDirectory;
            Latitude = Properties.Settings.Default.Latitude;
            Longitude = Properties.Settings.Default.Longitude;

            WindowXPos = Properties.Settings.Default.WindowXPos;
            WindowYPos = Properties.Settings.Default.WindowYPos;

            if (! JournalDirectoryExists())
            {
                this.JournalDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Saved Games\\Frontier Developments\\Elite Dangerous";
            }
        }

        public void Save()
        {
            //Standardize file pathing
            JournalDirectory.TrimEnd('\\');

            Properties.Settings.Default.JournalDirectory = JournalDirectory;
            Properties.Settings.Default.Latitude = Latitude;
            Properties.Settings.Default.Longitude = Longitude;
            Properties.Settings.Default.WindowXPos = WindowXPos;
            Properties.Settings.Default.WindowYPos = WindowYPos;

            Properties.Settings.Default.Save();
        }

        public bool JournalDirectoryExists()
        {
            if(this.JournalDirectory == "")
            {
                return false;
            }

            return System.IO.Directory.Exists(this.JournalDirectory);
        }

        
    }
}
