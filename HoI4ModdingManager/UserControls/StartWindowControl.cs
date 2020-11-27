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
            titleLabel.Text = ar.RespondAssemblyTitle() + " - v" + ar.RespondAssembryVersion();
        }
    }
}
