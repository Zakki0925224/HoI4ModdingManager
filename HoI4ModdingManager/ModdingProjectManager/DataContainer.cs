using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System.Collections.Generic;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// データコンテナ
    /// ファイルから取得したデータを保持
    /// </summary>
    class DataContainer
    {
        public List<CountryDataHanger> CountryData { get; set; }

        public List<IdeologyDataHanger> IdeologyData { get; set; }

        public ProjectDataHanger ProjectData { get; set; }

        public DataContainer()
        {
            Initialize();
        }

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialize()
        {
            CountryData = new List<CountryDataHanger>();
            IdeologyData = new List<IdeologyDataHanger>();
            ProjectData = new ProjectDataHanger();
        }
    }
}
