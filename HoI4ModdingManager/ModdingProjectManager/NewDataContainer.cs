using HoI4ModdingManager.ModdingProjectManager.DataHangers.WillBeReplaced;
using System.Collections.Generic;

namespace HoI4ModdingManager.ModdingProjectManager
{
    class NewDataContainer
    {
        public NewDataContainer()
        {
            Initialize();
        }

        public ProjectDataHanger ProjectData { get; set; }
        public List<CountryDataHanger> CountryData { get; set; }
        public List<IdeologyDataHanger> IdeologyData { get; set; }

        public void Initialize()
        {
            ProjectData = new ProjectDataHanger();
            CountryData = new List<CountryDataHanger>();
            IdeologyData = new List<IdeologyDataHanger>();
        }
    }
}
