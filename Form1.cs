using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BunifulInstall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnInstalledMods_Click(object sender, EventArgs e)
        {
            installedMods1.Visible = false;
            installedMods2.Visible = true;
            settings1.Visible = false;
            browseMods1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            installedMods1.Visible = false;
            installedMods2.Visible = false;
            settings1.Visible = true;
            browseMods1.Visible = false;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(MultiVersusModManager.Properties.Settings.Default.launchPath); // should start with EAC and then close the application
                Environment.Exit(0);
            }
            catch
            {
                MessageBox.Show("There has been an error finding the game path. Please make sure you have the right directory chosen.", "Error Finding Game Path!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowseMods_Click(object sender, EventArgs e)
        {
            installedMods1.Visible = false;
            installedMods2.Visible = false;
            settings1.Visible = false;
            browseMods1.Visible = true;

        }
    }
}
