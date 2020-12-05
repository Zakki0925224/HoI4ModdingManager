using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoI4ModdingManager.Forms;

namespace HoI4ModdingManager.Managers.ModdingProjectManager.UserControls
{
    [Docking(DockingBehavior.Ask)]
    public partial class ProjectEditorNavigationControl : UserControl
    {
        public ProjectEditorNavigationControl()
        {
            InitializeComponent();
        }

        private void スタートSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartWindow sw = new StartWindow();
            sw.ShowDialog();
        }
    }
}
