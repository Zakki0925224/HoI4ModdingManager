using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.ModdingProjectManager.DataContainer
{
    class IdeologyDataContainer
    {
        private List<IdeologyDataHanger> ideologyData;

        public List<IdeologyDataHanger> GetIdeologyData()
        {
            return ideologyData;
        }

        public void SetIdeologyData(List<IdeologyDataHanger> data)
        {
            ideologyData = data;
        }
    }
}
