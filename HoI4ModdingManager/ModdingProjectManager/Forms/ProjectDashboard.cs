using CefSharp;
using CefSharp.WinForms;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.PageLayout;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.Common.Utils;
using HoI4ModdingManager.CountryManager.Forms;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModManager.Forms;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectDashBoard : Form
    {
        // 引数（ファイルパス）
        public string FilePath = "";

        // データコンテナ
        private DataContainer MainContainer = null;
        private CefSettings Settings;
        private ProjectSettings ProjectSettingsForm;
        private CountryDataEditor CountryDataEditorForm;

        // フラグ
        private bool OpeningProject = false;


        public ProjectDashBoard(params string[] filePathArguments)
        {
            InitializeComponent();
            InitializeWindowTitle();
            InitializeBrowser();
            UpdateMenuStrip();

            if (filePathArguments.Length == 0)
                return;
            
            this.FilePath = filePathArguments[0];
            OpenFile(false);
        }

        /// <summary>
        /// ウィンドウタイトルを設定
        /// </summary>
        /// <param name="windowTitle"></param>
        private void SetWindowTitle(string windowTitle)
        {
            this.Text = $"{this.FilePath} - HoI4ModdingManager";
        }

        /// <summary>
        /// ウィンドウタイトルの初期化
        /// </summary>
        private void InitializeWindowTitle()
        {
            this.Text = "HoI4ModdingManager";
        }

        /// <summary>
        /// ファイルを開く
        /// </summary>
        public void OpenFile(bool useDialog)
        {
            string path;

            if (useDialog)
                path = FileIO.OpenDataBaseFile(true);
            else
                path = FileIO.OpenDataBaseFile(false, this.FilePath);

            if (path == "")
                return;

            // 編集中のファイルをどうするか
            if (this.OpeningProject)
                CloseFile();

            this.FilePath = path;
            this.MainContainer = new EXIM().ImportProject(this.FilePath);
            this.OpeningProject = true;

            UpdateUI(this.MainContainer);
            SetWindowTitle($"{this.FilePath} - HoI4ModdingManager");
            UpdateMenuStrip();
        }

        /// <summary>
        /// ファイルを閉じる
        /// </summary>
        /// <returns>正常に閉じることができなければfalseを返す</returns>
        private bool CloseFile()
        {
            if (!this.OpeningProject || this.FilePath == "")
                return true;

            var result = MessageBoxProvider.SaveMessageBox(this.FilePath);
            if (result == DialogResult.Yes)
                SaveData();
            else if (result == DialogResult.Cancel)
                return false;

            this.OpeningProject = false;
            InitializeWindowTitle();
            UpdateMenuStrip();

            return true;
        }

        /// <summary>
        /// UI更新
        /// </summary>
        private void UpdateUI(DataContainer container)
        {
            mainTab.TabPages.Clear();

            foreach (CountryDataHanger data in container.CountryData)
            {
                var tabPage = new TabPage()
                {
                    Name = $"{data.Name}-Tab",
                    Text = data.Name
                };

                tabPage.Controls.Add(SetBrowser(data));
                mainTab.TabPages.Add(tabPage);
            }
        }

        /// <summary>
        /// データをファイルに保存
        /// </summary>
        private void SaveData()
        {
            new EXIM().ExportProject(this.FilePath, this.MainContainer);
        }

        /// <summary>
        /// ブラウザを初期化
        /// </summary>
        private void InitializeBrowser()
        {
            this.Settings = new CefSettings();
            Cef.Initialize(Settings);
        }

        /// <summary>
        /// Countrydataを指定してブラウザを設定
        /// </summary>
        /// <param name="thisBrowserCountryData"></param>
        /// <returns></returns>
        private ChromiumWebBrowser SetBrowser(CountryDataHanger thisBrowserCountryData)
        {
            ChromiumWebBrowser browser;
            string pageSource = ResourceLoader.GetStringResource("HoI4ModdingManager.Common.PageLayout.dashboard.html");

            browser = ResourceLoader.GetBrowser();
            browser.Tag = thisBrowserCountryData;
            browser.IsBrowserInitializedChanged += CefBrowser_IsBrowserInitializedChanged;
            browser.LoadingStateChanged += CefBrowser_LoadingStateChanged;
            browser.Dock = DockStyle.Fill;
            browser.LoadHtml(pageSource, "http://hmm", Encoding.UTF8);

            return browser;
        }

        private void UpdateMenuStrip()
        {
            saveToolStripMenuItem.Enabled =
            closeToolStripMenuItem.Enabled =
            chromiumDevToolToolStripMenuItem.Enabled =
            projectToolStripMenuItem.Enabled =
            this.OpeningProject;
        }

        private void CefBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!this.OpeningProject)
                return;

            var browser = (ChromiumWebBrowser)sender;
            string thisCountryData = JsonConvert.SerializeObject((CountryDataHanger)browser.Tag);
            string countryData = JsonConvert.SerializeObject(this.MainContainer.CountryData);
            string projectData = JsonConvert.SerializeObject(this.MainContainer.ProjectData);
            string ideologyData = JsonConvert.SerializeObject(this.MainContainer.IdeologyData);

            if (!e.IsLoading)
                browser.ExecuteScriptAsync($"GetCountryData({thisCountryData}, {countryData}, {projectData}, {ideologyData})");
        }

        private void CefBrowser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            if (chromiumDevToolToolStripMenuItem.Checked)
                ((ChromiumWebBrowser)sender).ShowDevTools();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sw = new StartWindow();
            sw.Owner = this;
            sw.ShowDialog();
        }

        /// <summary>
        /// タブの描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = (TabControl)sender;
            var page = tab.TabPages[e.Index];

            string title = page.Text;
            var sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,

            };
            sf.FormatFlags |= StringFormatFlags.LineLimit;

            var backBrush = new SolidBrush(page.BackColor);
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            backBrush.Dispose();

            var foreBrush = new SolidBrush(page.ForeColor);
            e.Graphics.DrawString(title, page.Font, foreBrush, e.Bounds, sf);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(true);
        }

        private void CreateProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StartWindow().ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppSettings().ShowDialog();
        }

        private void ProjectDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cef.IsInitialized)
                Cef.Shutdown();
        }

        private void ReloadDashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUI(this.MainContainer);
        }

        private void ProjectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ProjectSettingsForm == null || this.ProjectSettingsForm.IsDisposed)
            {
                this.ProjectSettingsForm = new ProjectSettings(this.MainContainer.ProjectData);
                this.ProjectSettingsForm.FormClosed += new FormClosedEventHandler(ProjectSettings_FormClosed);
                this.ProjectSettingsForm.Show();
            }
            else
                this.ProjectSettingsForm.Focus();
        }

        private void ProjectSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formSender = (ProjectSettings)sender;

            if (formSender.DialogResult == DialogResult.OK)
            {
                this.MainContainer.ProjectData = formSender.ProjectDataContainer;
                UpdateUI(this.MainContainer);
            }

            this.ProjectSettingsForm.Dispose();
        }

        private void ChromiumDevToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chromiumDevToolToolStripMenuItem.Checked)
                chromiumDevToolToolStripMenuItem.Checked = false;
            else
                chromiumDevToolToolStripMenuItem.Checked = true;
        }

        private void CountryManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.CountryDataEditorForm == null || this.CountryDataEditorForm.IsDisposed)
            {
                this.CountryDataEditorForm = new CountryDataEditor(this.MainContainer);
                this.CountryDataEditorForm.FormClosed += new FormClosedEventHandler(CountryDataEditor_FormClosed);
                this.CountryDataEditorForm.Show();
            }
            else
                this.CountryDataEditorForm.Focus();
        }

        private void CountryDataEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formSender = (CountryDataEditor)sender;

            if (formSender.DialogResult == DialogResult.OK)
            {
                this.MainContainer = formSender.DataContainer;
                UpdateUI(this.MainContainer);
            }

            this.CountryDataEditorForm.Dispose();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void ProjectDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseFile())
                e.Cancel = true;
        }
    }
}
