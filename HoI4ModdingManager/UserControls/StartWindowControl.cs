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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
