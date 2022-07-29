using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BunifulInstall.Forms
{
    public partial class InstalledMods : UserControl
    {
        public InstalledMods()
        {
            InitializeComponent();
        }

        private void InstalledMods_Load(object sender, EventArgs e)
        {
            lstMods.Items.Clear();

            try
            {
                string[] mods = Directory.GetFiles(MultiVersusModManager.Properties.Settings.Default.modPath);

                foreach (string mod in mods)
                {

                    if (Path.GetExtension(mod) == ".pak" || Path.GetExtension(mod) == ".disabled")
                    {
                        lstMods.Items.Add(Path.GetFileName(mod));
                    }

                }
            }
            catch
            {
                // would put something of use here but I dont think i will lol.
            }

        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                lstMods.Items.Clear();
                string[] mods = Directory.GetFiles(MultiVersusModManager.Properties.Settings.Default.modPath);

                foreach (string mod in mods)
                {
                    if (Path.GetExtension(mod) == ".pak" || Path.GetExtension(mod) == ".disabled")
                    {
                        lstMods.Items.Add(Path.GetFileName(mod));
                    }
                }
            }
            catch
            {
                MessageBox.Show("There has been an error finding the game path. Please make sure you have the right directory chosen.", "Error Finding Game Path!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (lstMods.SelectedItem != null)
            {
                string selectedMod = lstMods.SelectedItem.ToString();
                string modPath = MultiVersusModManager.Properties.Settings.Default.modPath + "\\" + selectedMod;

                if (Path.GetExtension(selectedMod) == ".disabled")
                {
                    File.Move(modPath, Path.ChangeExtension(modPath, ".pak"));
                }

                lstMods.Items.Clear();
                string[] mods = Directory.GetFiles(MultiVersusModManager.Properties.Settings.Default.modPath);

                foreach (string mod in mods)
                {
                    if (Path.GetExtension(mod) == ".pak" || Path.GetExtension(mod) == ".disabled")
                    {
                        lstMods.Items.Add(Path.GetFileName(mod));
                    }
                }
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {

            if (lstMods.SelectedItem != null)
            {
                string selectedMod = lstMods.SelectedItem.ToString();
                string modPath = MultiVersusModManager.Properties.Settings.Default.modPath + "\\" + selectedMod;

                if (Path.GetExtension(selectedMod) == ".pak")
                {
                    File.Move(modPath, Path.ChangeExtension(modPath, ".disabled"));
                }

                lstMods.Items.Clear();
                string[] mods = Directory.GetFiles(MultiVersusModManager.Properties.Settings.Default.modPath);

                foreach (string mod in mods)
                {
                    if (Path.GetExtension(mod) == ".pak" || Path.GetExtension(mod) == ".disabled")
                    {
                        lstMods.Items.Add(Path.GetFileName(mod));
                    }
                }
            }
            
        }
    }
}
