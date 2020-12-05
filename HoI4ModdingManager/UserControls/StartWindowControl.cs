using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoI4ModdingManager.Workers;
using HoI4ModdingManager.Forms;
using HoI4ModdingManager.Managers.ModdingProjectManager.Forms;

namespace HoI4ModdingManager.UserControls
{
    public partial class StartWindowControl : UserControl
    {
        public StartWindowControl()
        {
            InitializeComponent();
            AssemblyResponder ar = new AssemblyResponder();
            AppVersionResponder avr = new AppVersionResponder();
            titleLabel.Text = ar.RespondAssemblyTitle() + " - v" + avr.RespondAliasVersion() + avr.RespondVersionType();
        }

        /// <summary>
        /// プロジェクトを開く
        /// </summary>
        private void openProject()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "プロジェクトを開く...";
                ofd.Filter = "HoI4 Modding Project (*.hmp)|*.hmp";

                DialogResult dr = ofd.ShowDialog();
            }
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            openProject();
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {

        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            createProjectSettingsPanel.Visible = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            AppSettings apps = new AppSettings();
            apps.ShowDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ProjectEditor pe = new ProjectEditor();
            pe.Show();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
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
