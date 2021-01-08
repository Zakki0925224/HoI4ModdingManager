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
        public List<CountryDataHanger> CountryDataList = new List<CountryDataHanger>();

        public List<IdeologyDataHanger> IdeologyDataList = new List<IdeologyDataHanger>();

        public List<ProjectDataHanger> ProjectDataList = new List<ProjectDataHanger>();
    }
}
