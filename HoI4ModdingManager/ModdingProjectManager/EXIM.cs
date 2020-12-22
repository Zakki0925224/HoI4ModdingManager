using HoI4ModdingManager.ModdingProjectManager.DataContainer;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;
using System.Collections.Generic;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// プロジェクトのインポート / エクスポート
    /// </summary>
    class EXIM
    {
        public void ImportProject(string dbFile, ProjectDataContainer pdc, CountryDataContainer cdc, IdeologyDataContainer idc)
        {
            var sd = new StoreData();
            var projectData = new ProjectDataHanger();

            var projectDataList = new List<ProjectDataHanger>();
            var countryDataList = new List<CountryDataHanger>();
            var ideologyDataList = new List<IdeologyDataHanger>();

            // プロジェクトデータの取得
            sd.ImportProjectData(dbFile, "project_data", projectData);
            projectDataList.Add(projectData);
            pdc.SetProjectData(projectDataList);

            // 国家データの取得
            for (int colmn = 0; colmn < projectData.number_of_countries; colmn++)
            {
                // 取得した列ごとにリストに格納
                var countryData = new CountryDataHanger();
                sd.ImportCountryData(dbFile, "countries_data", colmn, countryData);
                countryDataList.Add(countryData);
                cdc.SetCountryData(countryDataList);
            }

            // イデオロギーデータの取得
            for (int colmn = 0; colmn < projectData.number_of_ideologies; colmn++)
            {
                var ideologyData = new IdeologyDataHanger();
                sd.ImportIdeologyData(dbFile, "ideologies_data", colmn, ideologyData);
                ideologyDataList.Add(ideologyData);
                idc.SetIdeologyData(ideologyDataList);
            }
        }
    }
}
