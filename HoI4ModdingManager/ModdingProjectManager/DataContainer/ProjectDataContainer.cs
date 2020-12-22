using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.ModdingProjectManager.DataContainer
{
    class ProjectDataContainer
    {
        private List<ProjectDataHanger> projectData;

        public List<ProjectDataHanger> GetProjectData()
        {
            return projectData;
        }

        public void SetProjectData(List<ProjectDataHanger> data)
        {
            projectData = data;
        }
    }
}
