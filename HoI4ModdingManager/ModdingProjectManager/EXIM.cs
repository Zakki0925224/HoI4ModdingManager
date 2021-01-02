using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;
using HoI4ModdingManager.Common.Providers;

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
            var projectData = new ProjectDataHanger();

            // 整合性確認
            if (!FileChecker.IsThisFileCanUse(dbFile))
            {
                MessageBoxProvider.ShowErrorMessageBox("指定されたファイルは使用できません。");
                return false;
            }

            // プロジェクトデータの取得
            sd.ImportProjectData(dbFile, "project_data", projectData);
            dc.ProjectDataList.Add(projectData);

            // 国家データの取得
            for (int colmn = 0; colmn < projectData.number_of_countries; colmn++)
            {
                // 取得した列ごとにリストに格納
                var countryData = new CountryDataHanger();
                sd.ImportCountryData(dbFile, "countries_data", colmn, countryData);
                dc.CountryDataList.Add(countryData);
            }

            // イデオロギーデータの取得
            for (int colmn = 0; colmn < projectData.number_of_ideologies; colmn++)
            {
                var ideologyData = new IdeologyDataHanger();
                sd.ImportIdeologyData(dbFile, "ideologies_data", colmn, ideologyData);
                dc.IdeologyDataList.Add(ideologyData);
            }

            return true;
        }
    }
}
