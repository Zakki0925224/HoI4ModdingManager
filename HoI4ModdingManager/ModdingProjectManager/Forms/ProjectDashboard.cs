﻿using HoI4ModdingManager.Common;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.Tests;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectDashBoard : Form
    {
        // 引数（ファイルパス）
        private string[] filePathArgument;

        // データコンテナ
        private DataContainer mainContainer = new DataContainer();
        private List<ProjectDataHanger> projectData;
        private List<CountryDataHanger> countryData;
        private List<IdeologyDataHanger> ideologyData;

        public ProjectDashBoard(params string[] filePathArgument)
        {
            this.filePathArgument = filePathArgument;

            InitializeComponent();
            SetWindowTitle();
            SetProjectData();
        }

        private void SetWindowTitle()
        {
            if (filePathArgument.Length != 1)
            {
                this.Text = "HoI4ModdingManager";
            }
            else
            {
                this.Text = filePathArgument[0] + " - HoI4ModdingManager";
            }
        }

        /// <summary>
        /// データを取得して反映
        /// </summary>
        private void SetProjectData()
        {
            if (filePathArgument.Length != 1)
                return;

            EXIM exim = new EXIM();
            exim.ImportProject(filePathArgument[0], mainContainer);
            projectData = mainContainer.ProjectDataList;
            countryData = mainContainer.CountryDataList;
            ideologyData = mainContainer.IdeologyDataList;

            // UI更新
            foreach (CountryDataHanger data in countryData)
            {
                var tabPage = new TabPage()
                {
                    Name = data.country_name + "-Tab",
                    Text = data.country_name
                };

                // cefsharp test
                var browser = new ChromiumWebBrowser("https://www.google.co.jp/");
                tabPage.Controls.Add(browser);
                mainTab.TabPages.Add(tabPage);
            }
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
    }
}
