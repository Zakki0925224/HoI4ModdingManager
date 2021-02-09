using HoI4ModdingManager.ModdingProjectManager.ProjectExporter;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// プロジェクトのインポート / エクスポート
    /// </summary>
    class EXIM
    {
        readonly string[] TableNames = { "project_data", "country_data", "ideology_data" };

        public DataContainer ImportProject(string dbFile)
        {
            var sd = new StoreData();
            var dc = new DataContainer();

            // プロジェクトデータの取得
            dc.ProjectData = sd.GetProjectData(dbFile, TableNames[0]);

            // 国家データの取得
            dc.CountryData = sd.GetCountriesData(dbFile, TableNames[1]);

            // イデオロギーデータの取得
            dc.IdeologyData = sd.GetIdeologiesData(dbFile, TableNames[2]);

            return dc;
        }

        public void ExportProject(string dbFile, DataContainer data)
        {
            new WriteData().WriteDataToDataBase(data, dbFile, TableNames[0], TableNames[1], TableNames[2]);
        }
    }
}
