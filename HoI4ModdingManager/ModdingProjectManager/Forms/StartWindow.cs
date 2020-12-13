using HoI4ModdingManager.Common.Forms;
using HoI4ModdingManager.Common.Workers;
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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            AssemblyResponder ar = new AssemblyResponder();
            AppVersionResponder avr = new AppVersionResponder();
            titleLabel.Text = ar.RespondAssemblyTitle() + " - v" + avr.RespondAliasVersion() + avr.RespondVersionType();
        }

        private void OpenProject()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "プロジェクトを開く...";
                ofd.Filter = "HoI4 Modding Project (*.hmp)|*.hmp";

                DialogResult dr = ofd.ShowDialog();
            }
        }

        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            OpenProject();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            createProjectSettingsPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            AppSettings apps = new AppSettings();
            apps.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ProjectEditor pe = new ProjectEditor();
            pe.Show();
            this.Close();
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
    }
}
