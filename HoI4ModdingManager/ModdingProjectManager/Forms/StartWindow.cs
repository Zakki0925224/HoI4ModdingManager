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
            this.Close();
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
