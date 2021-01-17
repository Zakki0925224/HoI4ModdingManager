using HoI4ModdingManager.Common;
using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.Common.Responders;
using System;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            titleLabel.Text = $"{AssemblyResponder.RespondAssemblyTitle()} - v{AppVersionResponder.RespondAliasVersion()}{AppVersionResponder.RespondVersionType()}";
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            // 新しいプロセスで開始
            string result = new DialogProvider().ShowOpenFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

            if (result != null)
            {
                new ProcessCreater().CreateNewProcess(result);
                this.Close();
            }
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            createProjectSettingsPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new AppSettings().ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (projectNameTextBox.Text == "")
            {
                MessageBoxProvider.ShowErrorMessageBox("プロジェクト名が入力されていません。");
                return;
            }

            if (projectPlaceTextBox.Text == "")
            {
                MessageBoxProvider.ShowErrorMessageBox("プロジェクトの場所が入力されていません。");
                return;
            }
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
            projectPlaceTextBox.Text = new DialogProvider().ShowSaveFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを保存", true);
        }
    }
}
