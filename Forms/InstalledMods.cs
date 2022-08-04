using SharpCompress.Archives.Rar;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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

        private void lstMods_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropppedFile = (string[])e.Data.GetData(DataFormats.FileDrop);


            foreach (string file in dropppedFile)
            {
                string fileExten = Path.GetExtension(file);
                string filePath = Path.GetFullPath(file);
                string destPath = MultiVersusModManager.Properties.Settings.Default.modPath;

                if (fileExten == ".zip")
                {
                    ZipFile.ExtractToDirectory(filePath, destPath);

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
                        MessageBox.Show("There has been an error when attempting to fresh current modlist.", "Error Refreshing Mod List!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (fileExten == ".rar")
                {
                    using (Stream stream = File.OpenRead(filePath))
                    {
                        var reader = ReaderFactory.Open(stream);
                        while(reader.MoveToNextEntry())
                        {
                            if (!reader.Entry.IsDirectory)
                            {
                                reader.WriteEntryToDirectory(destPath, new SharpCompress.Common.ExtractionOptions() { ExtractFullPath = true, Overwrite = true });

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
                                    MessageBox.Show("There has been an error when attempting to fresh current modlist.", "Error Refreshing Mod List!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }



                }

            }


        }

        private void lstMods_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private string getFilePath(string path)
        {
            return Path.GetFullPath(path);
        }
        
        private string getFileExten(string path)
        {
            return Path.GetExtension(path);
        }

    }
}
