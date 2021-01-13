using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModManager.Forms
{
    public partial class ProjectSettings : Form
    {
        private ProjectDataHanger ProjectDataContainer {get; set;}

        public ProjectSettings(List<ProjectDataHanger> projectData)
        {
            InitializeComponent();
            ProjectDataContainer = projectData[0];
        }
    }
}
