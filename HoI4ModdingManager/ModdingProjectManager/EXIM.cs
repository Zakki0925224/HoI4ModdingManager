using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// プロジェクトのインポート / エクスポート
    /// </summary>
    class EXIM
    {
        public bool ImportProject(string dbFile, DataContainer dc)
        {
            var sd = new StoreData();

            // 整合性確認
            if (!FileChecker.IsThisFileCanUse(dbFile))
            {
                MessageBoxProvider.ShowErrorMessageBox("指定されたファイルは使用できません。");
                return false;
            }

            // プロジェクトデータの取得
            var projectData = new ProjectDataHanger();
            sd.ImportProjectData(dbFile, "project_data", projectData);
            dc.ProjectData = projectData;

            // 国家データの取得
            for (int colmn = 0; colmn < projectData.Number_of_countries; colmn++)
            {
                // 取得した列ごとにリストに格納
                var countryData = new CountryDataHanger();
                sd.ImportCountryData(dbFile, "countries_data", colmn, countryData);
                dc.CountryData.Add(countryData);
            }

            // イデオロギーデータの取得
            for (int colmn = 0; colmn < projectData.Number_of_ideologies; colmn++)
            {
                var ideologyData = new IdeologyDataHanger();
                sd.ImportIdeologyData(dbFile, "ideologies_data", colmn, ideologyData);
                dc.IdeologyData.Add(ideologyData);
            }

            return true;
        }
    }
}
