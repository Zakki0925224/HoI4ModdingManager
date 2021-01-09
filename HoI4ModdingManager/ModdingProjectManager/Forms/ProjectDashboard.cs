﻿using CefSharp;
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
                this.Text = filePathArguments[0] + " - HoI4ModdingManager";
        }

        /// <summary>
        /// データを取得して反映
        /// </summary>
        private void SetProjectData()
        {
            var exim = new EXIM();

            if (filePathArguments.Length != 1)
            {
                SetWindowTitle(true);
                return;
            }

            if (!exim.ImportProject(filePathArguments[0], mainContainer))
            {
                SetWindowTitle(true);
                return;
            }

            UpdateUI(mainContainer.CountryData);
            OpeningProject = true;
            SetWindowTitle(false);
        }

        /// <summary>
        /// UI更新
        /// </summary>
        private void UpdateUI(List<CountryDataHanger> countryData)
        {
            foreach (CountryDataHanger data in countryData)
            {
                var tabPage = new TabPage()
                {
                    Name = data.country_name + "-Tab",
                    Text = data.country_name
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
        /// ダッシュボードを再読み込み
        /// </summary>
        private void Reload()
        {
            if (!OpeningProject)
                return;

            mainTab.TabPages.Clear();
            UpdateUI(mainContainer.CountryData);
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
            var browser = (ChromiumWebBrowser)sender;
            var sendedDatas = (CountryDataHanger)browser.Tag;

            if (!e.IsLoading)
                browser.ExecuteScriptAsyncWhenPageLoaded("SetCountryData(\"" + sendedDatas.country_name + "\", " +
                                                                               sendedDatas.initial_political_power + ", " +
                                                                               sendedDatas.initial_stability + ", " +
                                                                               sendedDatas.initial_war_coop + ", " +
                                                                               sendedDatas.initial_transport + ", " +
                                                                        "\"" + sendedDatas.initial_ideology + "\", " +
                                                                               sendedDatas.party_support_neutrality + ", " +
                                                                               sendedDatas.party_support_democratic + ", " +
                                                                               sendedDatas.party_support_fascism + ", " +
                                                                               sendedDatas.party_support_communism + ", " +
                                                                               "false);");
        }

        private void CefBrowser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            //if (chromiumDevToolToolStripMenuItem.Checked)
            //    ((ChromiumWebBrowser)sender).ShowDevTools();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sw = new StartWindow();
            sw.ShowDialog();
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

        private void reloadDashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
