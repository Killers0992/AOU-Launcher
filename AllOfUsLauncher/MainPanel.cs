using Ionic.Zip;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace AllOfUsLauncher
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        public LauncherConfig config;

        private void MainPanel_Load(object sender, EventArgs e)
        {
            DownloadStatus.Text = "";
            UpdateInfo.Text = "";
            version_text.Text = "";
            InstallGame.Visible = false;
            UninstallGame.Visible = false;
            UpdateGame.Visible = false;
            CheckUpdate.Visible = false;
            if (!File.Exists("./config.json"))
                File.WriteAllText("./config.json", JsonConvert.SerializeObject(new LauncherConfig(), Formatting.Indented));
            config = JsonConvert.DeserializeObject<LauncherConfig>(File.ReadAllText("./config.json"));
            if (!Directory.Exists(config.amongus_path))
            {
                InstallGame.Visible = true;
            }
            else
            {
                if (File.Exists(Path.Combine(config.amongus_path, "winhttp.dll")))
                {
                    PlayButton.Visible = true;
                    CheckUpdate.Visible = true;
                    UninstallGame.Visible = true;
                }
                else
                {
                    InstallGame.Visible = true;
                }
            }
        }

        private void UninstallGame_Click(object sender, EventArgs e)
        {
            UninstallGame.Enabled = false;
            PlayButton.Visible = false;
            List<string> filestoremove = new List<string>();
            filestoremove.Add("winhttp.dll");
            filestoremove.Add("uninstall-mod.bat");
            filestoremove.Add("install-mod.bat");
            filestoremove.Add("doorstop_config.ini");
            filestoremove.Add("AOULobbySettings.exe");
            filestoremove.Add("mono");
            filestoremove.Add("Mod-Files");
            filestoremove.Add("Bepinex");
            DownloadStatus.Text = "Uninstalling AllOfUs mod.";
            foreach(var file in Directory.GetFiles(config.amongus_path))
                if (filestoremove.Contains(Path.GetFileName(file)))
                    File.Delete(file);
            ProgressBar.Value = 50;
            foreach (var dir in Directory.GetDirectories(config.amongus_path))
                if (filestoremove.Contains(Path.GetDirectoryName(dir)))
                    Directory.Delete(dir, true);
            ProgressBar.Value = 100;
            DownloadStatus.Text = "";
            UninstallGame.Visible = false;
            UninstallGame.Enabled = true;
            InstallGame.Visible = true;
            ProgressBar.Value = 0;
        }

        private void InstallGame_Click(object sender, EventArgs e)
        {
            InstallGame.Enabled = false;
            if (!Directory.Exists(config.amongus_path))
            {
                DialogResult t = AmongUSDirectory.ShowDialog();
                if (t == DialogResult.OK)
                {
                    if (File.Exists(Path.Combine(AmongUSDirectory.SelectedPath, "Among US.exe")))
                    {
                        config.amongus_path = AmongUSDirectory.SelectedPath;
                        File.WriteAllText("./config.json", JsonConvert.SerializeObject(config, Formatting.Indented));
                        DownloadGameFiles();
                    }
                }
                else
                {
                    InstallGame.Enabled = true;
                }
            }
            else
            {
                DownloadGameFiles();
            }
        }

        public void DownloadGameFiles()
        {
            using (WebClient client = new WebClient())
            {
                var url = "https://cdn.discordapp.com/attachments/607806161202446375/785662172247752744/AllOfUs-1.0.1_1.zip";
                client.Proxy = null;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileAsync(new Uri(url), Path.Combine(config.amongus_path, Path.GetFileName(url)));
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadStatus.Text = "Downloading " + e.ProgressPercentage + " %";
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!File.Exists(Path.Combine(config.amongus_path, "AllOfUs-1.0.1_1.zip")))
                return;
            DownloadStatus.Text = "Downloading completed.";
            UnZipFiles();
        }

        public void UnZipFiles()
        {
            ZipFile zip = ZipFile.Read(Path.Combine(config.amongus_path, "AllOfUs-1.0.1_1.zip"));
            zip.ExtractProgress += Zip_ExtractProgress;
            foreach (ZipEntry e in zip)
            {
                e.Extract(config.amongus_path, ExtractExistingFileAction.OverwriteSilently);
            }
            zip.Dispose();
            foreach (var file in Directory.GetFiles(Path.Combine(config.amongus_path, "Mod-Files")))
            {
                File.Copy(file, Path.Combine(config.amongus_path, Path.GetFileName(file)), true);
            }
            Directory.Delete(Path.Combine(config.amongus_path, "Mod-Files"), true);
            File.Delete(Path.Combine(config.amongus_path, "AllOfUs-1.0.1_1.zip"));
            InstallGame.Visible = false;
            PlayButton.Visible = true;
            UpdateGame.Visible = true;
            DownloadStatus.Text = "Installation completed.";
            ProgressBar.Value = 0;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            var currentProcess = new Process();
            currentProcess.StartInfo.WorkingDirectory = config.amongus_path;
            currentProcess.StartInfo.FileName = config.amongus_path + "\\Among Us.exe";
            currentProcess.EnableRaisingEvents = true;
            currentProcess.Start();
            Application.Exit();
        }

        private void Zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            DownloadStatus.Text = "Extracting files " + e.EntriesExtracted + "/" + e.EntriesTotal;
            if (e.TotalBytesToTransfer > 0)
            {
                ProgressBar.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }
        }
    }
}
