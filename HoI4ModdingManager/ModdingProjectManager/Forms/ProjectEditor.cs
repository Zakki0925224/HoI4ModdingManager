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

        private void ProjectEditor_Load(object sender, EventArgs e)
        {
            var ver_pi = new Verification.VER_ProjectImporter();
            ver_pi.Verification_GetCountriesData();
        }
    }
}
