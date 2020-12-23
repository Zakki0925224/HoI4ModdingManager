using System.Collections.Generic;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// データコンテナ
    /// ファイルから取得したデータを保持
    /// </summary>
    class DataContainer
    {
        public List<CountryDataHanger> countryDataList { get; set; }

        public List<IdeologyDataHanger> ideologyDataList { get; set; }

        public List<ProjectDataHanger> projectDataList { get; set; }
    }
}
