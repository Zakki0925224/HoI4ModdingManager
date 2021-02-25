using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.ProjectExporter;
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
            dc.ProjectData = sd.GetProjectData(dbFile);

            // 国家データの取得
            dc.CountryData = sd.GetCountriesData(dbFile);

            // イデオロギーデータの取得
            dc.IdeologyData = sd.GetIdeologiesData(dbFile);

            // データ変更フラグをリセット
            dc.ProjectData.DataChanged = false;

            foreach (CountryDataHanger cd in dc.CountryData)
                cd.DataChanged = false;

            foreach (IdeologyDataHanger id in dc.IdeologyData)
                id.DataChanged = false;

            return dc;
        }

        public void ExportProject(string dbFile, DataContainer data)
        {
            new WriteData().WriteDataToDataBase(data, dbFile);
        }
    }
}
