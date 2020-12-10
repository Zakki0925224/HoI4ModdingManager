using System;
using System.IO;
using HoI4ModdingManager.ModdingProjectManager.Data;
using HoI4ModdingManager.ModdingProjectManager.Workers;

namespace HoI4ModdingManager.ModdingProjectManager.Verification
{
    /// <summary>
    /// ProjectImporterを検証します
    /// </summary>
    class VER_ProjectImporter
    {
        /// <summary>
        /// GetCountriesData()を検証
        /// </summary>
        public void Verification_GetCountriesData()
        {
            var pi = new ProjectImporter();

            // dbファイルのパスを取得
            string dbFilePath = Path.GetFullPath(@"..\..\ModdingProjectManager\Verification\countries_data.db");
            

            // 1国家1インスタンスとして保持
            var cData = new CountriesData();
            pi.GetCountriesData(dbFilePath, "countries_data", 0, cData);

            // ログ出力
            Console.WriteLine(cData.id);
            Console.WriteLine(cData.created_at);
            Console.WriteLine(cData.updated_at);
            Console.WriteLine(cData.country_tag);
            Console.WriteLine(cData.country_name);
            Console.WriteLine(cData.country_name_neutrality);
            Console.WriteLine(cData.country_name_democratic);
            Console.WriteLine(cData.country_name_fascism);
            Console.WriteLine(cData.country_name_communism);
            Console.WriteLine(cData.party_name_neutrality);
            Console.WriteLine(cData.party_name_democratic);
            Console.WriteLine(cData.party_name_communism);
            Console.WriteLine(cData.party_name_fascism);
            Console.WriteLine(cData.capital_state_id);
            Console.WriteLine(cData.initial_teach_slot);
            Console.WriteLine(cData.initial_stability);
            Console.WriteLine(cData.initial_war_coop);
            Console.WriteLine(cData.initial_political_power);
            Console.WriteLine(cData.initial_transport);
            Console.WriteLine(cData.graphic_culture);
            Console.WriteLine(cData.initial_ideology);
            Console.WriteLine(cData.last_election_at);
            Console.WriteLine(cData.election_interval);
            Console.WriteLine(cData.is_no_election);
            Console.WriteLine(cData.color_r);
            Console.WriteLine(cData.color_g);
            Console.WriteLine(cData.color_b);
            Console.WriteLine(cData.country_flag_path_neutrality);
            Console.WriteLine(cData.country_flag_path_neutrality_medium);
            Console.WriteLine(cData.country_flag_path_neutrality_small);
            Console.WriteLine(cData.country_flag_path_democratic);
            Console.WriteLine(cData.country_flag_path_democratic_medium);
            Console.WriteLine(cData.country_flag_path_democratic_small);
            Console.WriteLine(cData.country_flag_path_fascism);
            Console.WriteLine(cData.country_flag_path_fascism_medium);
            Console.WriteLine(cData.country_flag_path_fascism_small);
            Console.WriteLine(cData.country_flag_path_communism);
            Console.WriteLine(cData.country_flag_path_communism_medium);
            Console.WriteLine(cData.country_flag_path_communism_small);
        }
    }
}
