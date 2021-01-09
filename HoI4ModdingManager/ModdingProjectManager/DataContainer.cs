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
        public List<CountryDataHanger> CountryDataList { get; set; }

        public List<IdeologyDataHanger> IdeologyDataList { get; set; }

        public List<ProjectDataHanger> ProjectDataList { get; set; }

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialize()
        {
            CountryDataList = new List<CountryDataHanger>();
            IdeologyDataList = new List<IdeologyDataHanger>();
            ProjectDataList = new List<ProjectDataHanger>();
        }
    }
}
