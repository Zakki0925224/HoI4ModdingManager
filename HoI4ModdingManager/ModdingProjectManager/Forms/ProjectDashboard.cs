using CefSharp;
using CefSharp.WinForms;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.PageLayout;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.Common.Utils;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModManager.Forms;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectDashBoard : Form
    {
        // 引数（ファイルパス）
        private readonly string filePath = "";

        // データコンテナ
        private FileStream fileStream = null;
        private DataContainer mainContainer = null;
        private CefSettings settings;

        // フラグ
        private bool InitializedBrowser { get; set; }
        private bool OpeningProject { get; set; }


        public ProjectDashBoard(params string[] filePathArguments)
        {
            InitializeComponent();
            InitializeWindowTitle();
            InitializeBrowser();

            if (filePathArguments.Length == 0)
            {
                this.OpeningProject = false;
                return;
            }
            
            this.filePath = filePathArguments[0];
            
            if (FileChecker.IsThisFileCanUse(this.filePath))
            {
                try
                {
                    this.fileStream = new FileStream(this.filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                }
                catch (Exception e) when (e is ArgumentNullException ||
                                          e is ArgumentException ||
                                          e is NotSupportedException ||
                                          e is FileNotFoundException ||
                                          e is IOException ||
                                          e is System.Security.SecurityException ||
                                          e is DirectoryNotFoundException ||
                                          e is UnauthorizedAccessException ||
                                          e is PathTooLongException ||
                                          e is ArgumentOutOfRangeException)
                {
                    MessageBoxProvider.ShowErrorMessageBox(e.Message);
                    return;
                }

                this.OpeningProject = true;
                mainContainer = new DataContainer();
                SetProjectData();
            }
            else
            {
                this.OpeningProject = false;
            }
        }

        /// <summary>
        /// ウィンドウタイトルを設定
        /// </summary>
        /// <param name="windowTitle"></param>
        private void SetWindowTitle(string windowTitle)
        {
            this.Text = $"{this.filePath} - HoI4ModdingManager";
        }

        /// <summary>
        /// ウィンドウタイトルの初期化
        /// </summary>
        private void InitializeWindowTitle()
        {
            this.Text = $"HoI4ModdingManager";
        }

        /// <summary>
        /// データを取得して反映
        /// </summary>
        private void SetProjectData()
        {
            if (fileStream == null && mainContainer == null)
                throw new Exception("ファイルが読み込まれていません。");

            mainContainer.Initialize();
            OpeningProject = false;
            SetWindowTitle("HoI4ModdingManager");

            if (!new EXIM().ImportProject(this.filePath, mainContainer))
                return;

            UpdateUI(mainContainer);

            OpeningProject = true;
            SetWindowTitle($"{this.filePath} - HoI4ModdingManager");
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
                    Name = $"{data.Country_name}-Tab",
                    Text = data.Country_name
                };

                tabPage.Controls.Add(SetBrowser(data));
                mainTab.TabPages.Add(tabPage);
            }
        }

        /// <summary>
        /// ブラウザを初期化
        /// </summary>
        private void InitializeBrowser()
        {
            settings = new CefSettings();
            Cef.Initialize(settings);

            InitializedBrowser = true;
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

        private void CefBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!OpeningProject)
                return;

            var browser = (ChromiumWebBrowser)sender;
            string thisCountryData = JsonConvert.SerializeObject((CountryDataHanger)browser.Tag);
            string countryData = JsonConvert.SerializeObject(mainContainer.CountryData);
            string projectData = JsonConvert.SerializeObject(mainContainer.ProjectData);
            string ideologyData = JsonConvert.SerializeObject(mainContainer.IdeologyData);

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
            new StartWindow().ShowDialog();
        }

        private void ProjectEditor_Load(object sender, EventArgs e)
        {
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
            FileIO.OpenDataBaseFile(true);
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
            if (Cef.IsInitialized && InitializedBrowser)
                Cef.Shutdown();

            if (this.fileStream != null)
                this.fileStream.Close();
        }

        private void ReloadDashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUI(mainContainer);
        }

        private void ProjectSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ps = new ProjectSettings(mainContainer.ProjectData))
            {
                ps.ShowDialog();
                mainContainer.ProjectData = ps.ProjectDataContainer;
                UpdateUI(mainContainer);
            }
            
            
        }

        private void MenuStrip_Layout(object sender, LayoutEventArgs e)
        {
            saveToolStripMenuItem.Enabled =
            closeToolStripMenuItem.Enabled =
            chromiumDevToolToolStripMenuItem.Enabled = 
            projectToolStripMenuItem.Enabled = 
            this.OpeningProject;
        }
    }
}
