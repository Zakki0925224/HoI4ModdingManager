using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.ModdingProjectManager
{
    /// <summary>
    /// プロジェクトのインポート / エクスポート
    /// </summary>
    class EXIM
    {
        public void ImportProject(string dbFile)
        {
            var sd = new StoreData();

            var countryDataList = new List<CountryDataHanger>();
            var ideologyDataList = new List<IdeologyDataHanger>();

            var projectData = new ProjectDataHanger();

            // プロジェクトデータの取得
            sd.ImportProjectData(dbFile, "project_data", projectData);

            // 国家データの取得
            for (int colmn = 0; colmn < projectData.number_of_countries; colmn++)
            {
                // 取得した列ごとにリストに格納
                var countryData = new CountryDataHanger();
                sd.ImportCountryData(dbFile, "countries_data", colmn, countryData);
                countryDataList.Add(countryData);
            }

            // イデオロギーデータの取得
            for (int colmn = 0; colmn < projectData.number_of_ideologies; colmn++)
            {
                var ideologyData = new IdeologyDataHanger();
                sd.ImportIdeologyData(dbFile, "ideologies_data", colmn, ideologyData);
                ideologyDataList.Add(ideologyData);
            }
        }
    }
}
