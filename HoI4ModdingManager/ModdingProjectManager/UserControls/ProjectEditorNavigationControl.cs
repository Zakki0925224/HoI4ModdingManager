using HoI4ModdingManager.ModdingProjectManager.Forms;
using System;
using System.Windows.Forms;
using HoI4ModdingManager.ModdingProjectManager.Workers;

namespace HoI4ModdingManager.ModdingProjectManager.UserControls
{
    [Docking(DockingBehavior.Ask)]
    public partial class ProjectEditorNavigationControl : UserControl
    {
        public ProjectEditorNavigationControl()
        {
            InitializeComponent();
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartWindow sw = new StartWindow();
            sw.ShowDialog();
        }
    }
}
