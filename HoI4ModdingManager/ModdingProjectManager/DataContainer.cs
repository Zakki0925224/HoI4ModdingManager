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
        private static List<CountryDataHanger> countryDataList = new List<CountryDataHanger>();

        public List<CountryDataHanger> CountryDataList
        {
            set { countryDataList = value; }
            get { return countryDataList; }
        }

        private static List<IdeologyDataHanger> ideologyDataList = new List<IdeologyDataHanger>();

        public List<IdeologyDataHanger> IdeologyDataList
        {
            set { ideologyDataList = value; }
            get { return ideologyDataList; }
        }

        private static List<ProjectDataHanger> projectDataList = new List<ProjectDataHanger>();

        public List<ProjectDataHanger> ProjectDataList
        {
            set { projectDataList = value; }
            get { return projectDataList; }
        }
    }
}
