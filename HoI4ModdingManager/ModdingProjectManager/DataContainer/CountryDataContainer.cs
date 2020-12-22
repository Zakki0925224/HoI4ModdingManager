using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.ModdingProjectManager.DataContainer
{
    class CountryDataContainer
    {
        private List<CountryDataHanger> countryData;

        public List<CountryDataHanger> GetCountryData()
        {
            return countryData;
        }

        public void SetCountryData(List<CountryDataHanger> data)
        {
            countryData = data;
        }
    }
}
