using CefSharp;
using CefSharp.WinForms;
using HoI4ModdingManager.Common;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.PageLayout;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
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
        private string[] filePathArguments;

        // データコンテナ
        private DataContainer mainContainer;
        private CefSettings settings;

        // フラグ
        private bool InitializedBrowser { get; set; }
        private bool OpeningProject { get; set; }


        public ProjectDashBoard(params string[] filePathArguments)
        {
            this.filePathArguments = filePathArguments;
            OpeningProject = false;
            mainContainer = new DataContainer();

            InitializeComponent();
            InitializeBrowser();
            SetProjectData();
        }

        /// <summary>
        /// ウィンドウタイトルを設定
        /// </summary>
        /// <param name="notSet"></param>
        private void SetWindowTitle(bool notSet)
        {
            if (notSet)
                this.Text = "HoI4ModdingManager";
            else
                this.Text = $"{filePathArguments[0]} - HoI4ModdingManager";
        }

        /// <summary>
        /// データを取得して反映
        /// </summary>
        private void SetProjectData()
        {
            if (filePathArguments.Length != 1)
            {
                SetWindowTitle(true);
                return;
            }

            if (!new EXIM().ImportProject(filePathArguments[0], mainContainer))
            {
                SetWindowTitle(true);
                return;
            }

            UpdateUI(mainContainer);
            OpeningProject = true;
            SetWindowTitle(false);
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = new DialogProvider().ShowOpenFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

            if (filePath != null)
                new ProcessCreater().CreateNewProcess(filePath);
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StartWindow().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AppSettings().ShowDialog();
        }

        private void ProjectDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cef.IsInitialized && InitializedBrowser)
                Cef.Shutdown();
        }

        private void reloadDashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUI(mainContainer);
        }
    }
}
