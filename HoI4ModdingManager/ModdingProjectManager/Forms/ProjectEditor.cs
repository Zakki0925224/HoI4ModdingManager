using HoI4ModdingManager.Common.Workers;
using HoI4ModdingManager.Common.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class ProjectEditor : Form
    {
        // 引数（ファイルパス）
        private string[] filePathArgument;
        // フラグ
        private bool editingFlag;
        private bool projectOpening;

        public ProjectEditor(params string[] filePathArgument)
        {
            this.filePathArgument = filePathArgument;
            this.editingFlag = false;

            InitializeComponent();
            SetWindowTitle();
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

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartWindow sw = new StartWindow();
            sw.ShowDialog();
        }

        private void ProjectEditor_Load(object sender, EventArgs e)
        {
            //var ver_pi = new Verification.VER_ProjectImporter();
            //ver_pi.Verification_GetCountriesData();
        }

        /// <summary>
        /// タブの描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = (TabControl)sender;
            TabPage page = tab.TabPages[e.Index];

            string title = page.Text;
            StringFormat sf = new StringFormat()
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,

            };
            sf.FormatFlags |= StringFormatFlags.LineLimit;
            
            Brush backBrush = new SolidBrush(page.BackColor);
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            backBrush.Dispose();

            Brush foreBrush = new SolidBrush(page.ForeColor);
            e.Graphics.DrawString(title, page.Font, foreBrush, e.Bounds, sf);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ods = new DialogShower();
            string filePath = ods.OpenFile("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

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
            AppSettings apps = new AppSettings();
            apps.ShowDialog();
        }
    }
}
