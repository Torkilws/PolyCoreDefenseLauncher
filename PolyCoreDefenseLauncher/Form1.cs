using Microsoft.AspNetCore.Hosting.Internal;
using RestSharp.Authenticators;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Text.RegularExpressions;

namespace PolyCoreDefenseLauncher
{
    public partial class Form : System.Windows.Forms.Form
    {

        private Dictionary<string, string> versionTable = new Dictionary<string, string>()
        {
            {"v0.1.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.1.0/v0.1.0.zip" },
            {"v0.2.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.2.0/v0.2.0.zip" },
            {"v0.3.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.3.0/v0.3.0.zip" },
            {"v0.4.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.4.0/v0.4.0.zip" },
            {"v0.5.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.5.0/v0.5.0.zip" },
            {"v0.6.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.6.0/v0.6.0.zip" },
            {"v0.7.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.8.0/v0.7.0.zip" },
            {"v0.8.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.8.0/v0.8.0.zip" },
            {"v0.9.0", "https://github.com/Torkilws/PolyCore_Defense-Builds/releases/download/0.9.0/v0.9.0.zip" },
            //{"v0.10.0", "" }
        };

        private const string CACHE_LOCATION = "C:/Temp/PolyCoreDefenseVersionCache/";


        public string SelectedVersion { get; set; }
        private string VersionDownloadUrl { get; set; }

        public Form()
        {
            InitializeComponent();

            // Populate dropdown with versions
            cmbVersions.Items.Clear();

            foreach (var item in versionTable)
            {
                var versionItem = new VersionItem(item.Key, item.Value);
                cmbVersions.Items.Add(versionItem);
            }

            cmbVersions.SelectedIndex = 0;

            SelectedVersion = GetSelectedVersionName();
            VersionDownloadUrl = GetSelectedVersionDownloadLink();

            if (GameExeFileExists())
            {
                buttonPlay.Focus();
            }
            else
            {
                buttonDownload.Focus();
            }
        }

        #region Button Events

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // Create path if it does not exist
            if (!Directory.Exists(CACHE_LOCATION))
            {
                Directory.CreateDirectory(CACHE_LOCATION);
            }

            cmbVersions.Enabled = false;
            labelStatus.Text = "Downloading version: " + GetSelectedVersionName();

            DownloadFile();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            var gameFilePath = GetGameExeFilePath();

            if (!GameExeFileExists())
            {
                labelStatus.Text = "Could not find game exe file";
                return;
            }

            Process.Start(gameFilePath);
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(CACHE_LOCATION))
            {
                labelStatus.Text = "No cache data exists";
                return;
            }

            var selectedGameDir = CACHE_LOCATION + SelectedVersion;

            if (!Directory.Exists(selectedGameDir))
            {
                labelStatus.Text = "No data exists for selected game version";
                return;
            }

            var text = "Are you sure you want to delete the selected saved game version data?\n" +
                "(path: " + selectedGameDir + ")";

            var result = MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Directory.Delete(selectedGameDir, true);
                File.Delete(selectedGameDir + ".zip");

                labelStatus.Text = "Game version deleted";
                buttonDownload.Enabled = true;
                buttonPlay.Enabled = false;
            }
        }

        private void buttonDeleteCache_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(CACHE_LOCATION))
            {
                labelStatus.Text = "No cache data exists";
                return;
            }

            var text = "Are you sure you want to delete all the saved game version data?\n" +
                "(path: " + CACHE_LOCATION + ")";
            
            var result = MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Directory.Delete(CACHE_LOCATION, true);
                labelStatus.Text = "Cache deleted";

                buttonDownload.Enabled = true;
                buttonPlay.Enabled = false;
            }
        }

        #endregion

        #region Events

        private void cmbVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedVersion = GetSelectedVersionName();
            VersionDownloadUrl = GetSelectedVersionDownloadLink();

            if (GameExeFileExists())
            {
                buttonDownload.Enabled = false;
                buttonPlay.Enabled = true;
                buttonPlay.Focus();
                labelStatus.Text = "Ready to play!";
            }
            else
            {
                buttonDownload.Enabled = true;
                buttonDownload.Focus();
                buttonPlay.Enabled = false;
                labelStatus.Text = "You need to download the selected version";
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void OnDownloadComplete(object? sender, AsyncCompletedEventArgs e)
        {            
            ExtractZipFileToCache();
        }

        private void OnExtractComplete()
        {
            labelStatus.Text = "Game version: " + SelectedVersion + " is ready to play!";
            progressBar.Value = 0;
            buttonPlay.Enabled = true;
            buttonDownload.Enabled = false;
            cmbVersions.Enabled = true;
        }

        #endregion

        #region Getters

        private string GetGameExeFilePath()
        {
            var gamePath = CACHE_LOCATION + SelectedVersion;
            if (!Directory.Exists(gamePath))
            {
                return "";
            }

            // Find game exe file
            var files = from f in Directory.EnumerateFiles(gamePath)
                    where f.Contains("UPGRADE") || f.Contains("PolyCore Defense")
                    select f;

            var gameExeFile = files.FirstOrDefault();

            if (string.IsNullOrEmpty(gameExeFile)) return "";

            var gameFilePath = Path.Combine(CACHE_LOCATION, gameExeFile);

            if (string.IsNullOrEmpty(gameFilePath)) return "";

            return gameFilePath;
        }

        private string GetSelectedVersionName()
        {
            var versionItem = (VersionItem)cmbVersions.SelectedItem;

            return versionItem.VersionName;
        }

        private string GetSelectedVersionDownloadLink()
        {
            var versionItem = (VersionItem)cmbVersions.SelectedItem;

            return versionItem.VersionDownloadUrl;
        }

        #endregion

        private bool GameExeFileExists()
        {
            var gameFilePath = GetGameExeFilePath();

            return !string.IsNullOrEmpty(gameFilePath);
        }

        private void DownloadFile()
        {
            var downloadLink = VersionDownloadUrl;
            var dowloadLocation = CACHE_LOCATION + SelectedVersion + ".zip";

            var uri = new Uri(downloadLink);

            progressBar.Value = 0;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += DownloadProgressChanged;
                wc.DownloadFileCompleted += OnDownloadComplete;
                wc.DownloadFileAsync(uri,dowloadLocation);
            }
        }

        private void ExtractZipFileToCache()
        {
            var zipFile = CACHE_LOCATION + SelectedVersion + ".zip";
            var extractPath = CACHE_LOCATION;

            labelStatus.Text = "Extracting version: " + SelectedVersion;
            ZipFile.ExtractToDirectory(zipFile, extractPath, true);
            OnExtractComplete();
        }
    }
}