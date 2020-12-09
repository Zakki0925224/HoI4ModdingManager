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
        public ProjectEditor()
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
