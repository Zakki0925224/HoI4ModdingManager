using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoI4ModdingManager.Common;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectDashBoard : Form
    {
        // 引数（ファイルパス）
        private string[] filePathArgument;

        // フラグ
        private bool editingFlag;
        private bool projectOpening;

        // 変数
        private List<CountryDataHanger> countryList = new List<CountryDataHanger>();

        public ProjectDashBoard(params string[] filePathArgument)
        {
            this.filePathArgument = filePathArgument;
            this.editingFlag = false;

            InitializeComponent();
            SetWindowTitle();
            SetData();
        }

        private void SetWindowTitle()
        {
            if (filePathArgument.Length != 1)
            {
                this.Text = "HoI4ModdingManager";
                projectOpening = false;
            }
            else
            {
                this.Text = filePathArgument[0] + " - HoI4ModdingManager";
                projectOpening = true;
            }
        }

        /// <summary>
        /// データを取得
        /// </summary>
        private void SetData()
        {
            if (filePathArgument.Length != 1)
                return;

            var pi = new StoreData();
            var pData = new ProjectDataHanger();

            // リストのクリア
            countryList.Clear();

            // データ取得
            pi.ImportProjectData(filePathArgument[0], "project_data", pData);

            for (int i = 0; i < pData.number_of_countries; i++ )
            {
                var cData = new CountryDataHanger();
                pi.ImportCountryData(filePathArgument[0], "countries_data", i, cData);
                countryList.Add(cData);
            }

            // フラグ更新
            projectOpening = true;

            // UI更新
            foreach (CountryDataHanger country in countryList)
            {
                var tabPage = new TabPage()
                {
                    Text = country.country_name,
                    BackColor = Color.White
                };

                // こんな感じで追加していく
                //　Label label = new Label()
                //　{
                //　    Text = country.country_name
                //　};

                //tabPage.Controls.Add(label);

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
