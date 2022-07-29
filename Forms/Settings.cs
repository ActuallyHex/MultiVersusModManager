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
using System.Net;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace BunifulInstall.Forms
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnAutoMakeFolder_Click(object sender, EventArgs e)
        {
            // MultiVersus\MultiVersus\Content\Paks
            string searchName = "MultiVersus";
            string[] files = { "" };
            string dir = "";

            try
            {
                int attempt = 1;

                switch (attempt)
                {
                    case 1:

                        dir = @"G:\";

                        if (Directory.Exists(dir))
                        {
                            if (Directory.Exists(@"G:\SteamLibrary"))
                            {
                                files = Directory.GetDirectories(@"G:\SteamLibrary", "*.*", SearchOption.AllDirectories);

                            }

                        }
                        else
                        {
                            attempt = 2;
                        }
                     break;

                   case 2:

                        dir = @"D:\";

                        if (Directory.Exists(dir))
                        {

                            if (Directory.Exists(@"D:\SteamLibrary"))
                            {
                                files = Directory.GetDirectories(@"D:\SteamLibrary", "*.*", SearchOption.AllDirectories);
                            }
                        }
                        else
                        {
                            attempt = 3;
                        }

                    break;

                    case 3:

                        dir = @"E:\";

                        if (Directory.Exists(dir))
                        {

                            if (Directory.Exists(@"E:\SteamLibrary"))
                            {
                                files = Directory.GetDirectories(@"E:\SteamLibrary", "*.*", SearchOption.AllDirectories);
                            }
                        }
                        else
                        {
                            attempt = 4;
                        }

                     break;

                    case 4:

                        dir = @"F:\";

                        if (Directory.Exists(dir))
                        {

                            if (Directory.Exists(@"F:\SteamLibrary"))
                            {
                                files = Directory.GetDirectories(@"F:\SteamLibrary", "*.*", SearchOption.AllDirectories);
                            }
                        }
                        else
                        {
                            attempt = 5;
                        }

                     break;
                }

            }
            catch
            {
                Console.WriteLine("Error! Cant Open File or other fatal error!");
            }

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                if (Path.GetFileNameWithoutExtension(info.Name).ToLower() == searchName.ToLower())
                {
                    if (info.FullName == dir + @"SteamLibrary\steamapps\common\MultiVersus\MultiVersus")
                    {
                        string fullPath = info.FullName.ToString() + @"\Content\Paks";
                        string gamePath = info.FullName.ToString() + @"\Binaries\Win64\MultiVersus-Win64-Shipping.exe";

                        if (Directory.Exists(fullPath + @"\Mods"))
                        {
                            txtDirectory.Text = fullPath + @"\Mods";
                            MultiVersusModManager.Properties.Settings.Default.modPath = fullPath + @"\Mods";
                            MultiVersusModManager.Properties.Settings.Default.launchPath = gamePath;
                            MultiVersusModManager.Properties.Settings.Default.Save();
                        }
                        else
                        {
                            try
                            {
                                System.IO.Directory.CreateDirectory(fullPath + @"\Mods");
                                txtDirectory.Text = fullPath + @"\Mods";
                                MultiVersusModManager.Properties.Settings.Default.modPath = fullPath + @"\Mods";
                                MultiVersusModManager.Properties.Settings.Default.Save();

                            }
                            catch
                            {
                                txtDirectory.Text = "Error! Something went wrong!";
                            }

                        }
                    
                    }

                }
            }


        }

        private void fileChooser_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                
                if (Directory.Exists(dialog.FileName + @"\Mods"))
                {
                    MultiVersusModManager.Properties.Settings.Default.modPath = dialog.FileName;
                    txtDirectory.Text = MultiVersusModManager.Properties.Settings.Default.modPath;
                    MultiVersusModManager.Properties.Settings.Default.Save();
                }
                else
                {
                    try
                    {
                        System.IO.Directory.CreateDirectory(dialog.FileName + @"\Mods");
                        txtDirectory.Text = dialog.FileName + @"\Mods";
                        MultiVersusModManager.Properties.Settings.Default.modPath = dialog.FileName + @"\Mods";
                        MultiVersusModManager.Properties.Settings.Default.Save();
                    }
                    catch
                    {
                        txtDirectory.Text = "Error! Something went wrong!";
                    }
                }
            
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtDirectory.Text = MultiVersusModManager.Properties.Settings.Default.modPath;
        }

        private void btnAutoLaunchPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = false;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MultiVersusModManager.Properties.Settings.Default.launchPath = dialog.FileName;
                MultiVersusModManager.Properties.Settings.Default.Save();

                // G:\SteamLibrary\steamapps\common\MultiVersus\MultiVersus\Binaries\Win64\MultiVersus-Win64-Shipping.exe -- auto launch shit

            }
        }

        //C:\Program Files\Steam\steamapps\common\MultiVersus
        //D:\SteamLibrary\steamapps\common\MultiVersus
        //G:\SteamLibrary\steamapps\common\MultiVersus
    }
}
