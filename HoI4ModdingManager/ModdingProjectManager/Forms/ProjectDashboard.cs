using CefSharp;
using CefSharp.WinForms;
using HoI4ModdingManager.Common;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.PageLayout;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectDashBoard : Form
    {
        // 引数（ファイルパス）
        private string[] filePathArgument;

        // データコンテナ
        private DataContainer mainContainer = new DataContainer();
        private CefSettings settings;

        // フラグ
        private bool InitializedBrowser { get; set; }


        public ProjectDashBoard(params string[] filePathArgument)
        {
            this.filePathArgument = filePathArgument;

            InitializeComponent();
            InitializeBrowser();
            SetProjectData();
        }

        private void SetWindowTitle(bool notSet)
        {
            if (notSet)
                this.Text = "HoI4ModdingManager";
            else
                this.Text = filePathArgument[0] + " - HoI4ModdingManager";
        }

        /// <summary>
        /// データを取得して反映
        /// </summary>
        private void SetProjectData()
        {
            var exim = new EXIM();

            if (filePathArgument.Length != 1)
            {
                SetWindowTitle(true);
                return;
            }

            if (!exim.ImportProject(filePathArgument[0], mainContainer))
            {
                SetWindowTitle(true);
                return;
            }

            // UI更新
            foreach (CountryDataHanger data in mainContainer.CountryDataList)
            {
                var tabPage = new TabPage()
                {
                    Name = data.country_name + "-Tab",
                    Text = data.country_name
                };

                tabPage.Controls.Add(SetBrowser(data));
                mainTab.TabPages.Add(tabPage);
            }

            SetWindowTitle(false);
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

        private ChromiumWebBrowser SetBrowser(CountryDataHanger countryData)
        {
            ChromiumWebBrowser browser;
            string pageSource = ResourceLoader.GetStringResource("HoI4ModdingManager.Common.PageLayout.dashboard.html");

            browser = ResourceLoader.GetBrowser();
            browser.Tag = countryData;
            browser.IsBrowserInitializedChanged += CefBrowser_IsBrowserInitializedChanged;
            browser.LoadingStateChanged += CefBrowser_LoadingStateChanged;
            browser.Dock = DockStyle.Fill;
            browser.LoadHtml(pageSource, "http://hmm", Encoding.UTF8);

            return browser;
        }

        private void CefBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            ChromiumWebBrowser browser = (ChromiumWebBrowser)sender;

            if (!e.IsLoading)
                browser.ExecuteScriptAsyncWhenPageLoaded("SetCountryData(\"" + ((CountryDataHanger)browser.Tag).country_name + "\", " +
                                                                               ((CountryDataHanger)browser.Tag).initial_political_power + ", " +
                                                                               ((CountryDataHanger)browser.Tag).initial_stability + ", " +
                                                                               ((CountryDataHanger)browser.Tag).initial_war_coop + ", " +
                                                                               ((CountryDataHanger)browser.Tag).initial_transport + ", " +
                                                                        "\"" + ((CountryDataHanger)browser.Tag).initial_ideology + "\", " +
                                                                               "false);");
        }

        private void CefBrowser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            if (chromiumDevToolToolStripMenuItem.Checked)
                ((ChromiumWebBrowser)sender).ShowDevTools();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sw = new StartWindow();
            sw.ShowDialog();
        }

        private void ProjectEditor_Load(object sender, EventArgs e)
        {
            // デバッグ用
            //var test = new ProjectImportTest();
            //test.ImportProject();
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
            var ods = new DialogProvider();
            string filePath = ods.ShowOpenFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

            if (filePath != null)
            {
                var pc = new ProcessCreater();
                pc.CreateNewProcess(filePath);
            }
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sw = new StartWindow();
            sw.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var apps = new AppSettings();
            apps.ShowDialog();
        }

        private void ProjectDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Cef.IsInitialized && InitializedBrowser)
                Cef.Shutdown();
        }
    }
}
