using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.Workers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            var ar = new AssemblyResponder();
            var avr = new AppVersionResponder();
            titleLabel.Text = ar.RespondAssemblyTitle() + " - v" + avr.RespondAliasVersion() + avr.RespondVersionType();
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            // 新しいプロセスで開始
            var ds = new DialogShower();
            var pc = new ProcessCreater();
            pc.CreateNewProcess(ds.OpenFile("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true));

            this.Close();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            createProjectSettingsPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var apps = new AppSettings();
            apps.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                modDescriptionLabel.Visible = true;
                modDescriptionTextBox.Visible = true;
                modDescriptionButton.Visible = true;
            }
            else
            {
                modDescriptionLabel.Visible = false;
                modDescriptionTextBox.Visible = false;
                modDescriptionButton.Visible = false;
            }
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            var ds = new DialogShower();
            projectPlaceTextBox.Text = ds.SaveFile("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを保存", true);
        }
    }
}
