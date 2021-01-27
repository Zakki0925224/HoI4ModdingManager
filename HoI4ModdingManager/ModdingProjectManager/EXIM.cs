using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// プロジェクトのインポート / エクスポート
    /// </summary>
    class EXIM
    {
        public DataContainer ImportProject(string dbFile)
        {
            var sd = new StoreData();
            var dc = new DataContainer();

            // プロジェクトデータの取得
            dc.ProjectData = sd.GetProjectData(dbFile, "project_data"); ;

            // 国家データの取得
            dc.CountryData = sd.GetCountriesData(dbFile, "countries_data");

            // イデオロギーデータの取得
            dc.IdeologyData = sd.GetIdeologiesData(dbFile, "ideologies_data");

            return dc;
        }
    }
}
