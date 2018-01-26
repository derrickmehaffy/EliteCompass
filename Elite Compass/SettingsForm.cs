using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elite_Compass
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.journalPath.Text = Program.appSettings.JournalDirectory;
        }

        private void journalDirectoryBrowse_Click(object sender, EventArgs e)
        {
            folderBrowse.SelectedPath = this.journalPath.Text;
            folderBrowse.ShowDialog();
            this.journalPath.Text = folderBrowse.SelectedPath;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.appSettings.Save();
            this.Close();
        }
    }
}
