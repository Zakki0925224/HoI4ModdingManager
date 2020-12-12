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
            string dbFilePath = Path.GetFullPath(@"..\..\ModdingProjectManager\Verification\test-mod.hmp");
            

            // 1国家1インスタンスとして保持
            var cData = new CountriesData();
            pi.ImportCountriesData(dbFilePath, "countries_data", 0, cData);

            var pData = new ProjectData();
            pi.ImportProjectData(dbFilePath, "project_data", pData);

            // ログ出力
            Console.WriteLine("---country data---");
            Console.WriteLine("id: " + cData.id);
            Console.WriteLine("country_tag: " + cData.country_tag);
            Console.WriteLine("country_name: " + cData.country_name);
            Console.WriteLine("country_name_neutrality: " + cData.country_name_neutrality);
            Console.WriteLine("country_name_democratic: " + cData.country_name_democratic);
            Console.WriteLine("country_name_fascism: " + cData.country_name_fascism);
            Console.WriteLine("country_name_communism: " + cData.country_name_communism);
            Console.WriteLine("party_name_neutrality: " + cData.party_name_neutrality);
            Console.WriteLine("party_name_democratic: " + cData.party_name_democratic);
            Console.WriteLine("party_name_communism: " + cData.party_name_communism);
            Console.WriteLine("party_name_fascism: " + cData.party_name_fascism);
            Console.WriteLine("capital_state_id: " + cData.capital_state_id);
            Console.WriteLine("initial_teach_slot: " + cData.initial_teach_slot);
            Console.WriteLine("initial_stability: " + cData.initial_stability);
            Console.WriteLine("initial_war_coop: " + cData.initial_war_coop);
            Console.WriteLine("initial_political_power: " + cData.initial_political_power);
            Console.WriteLine("initial_transport: " + cData.initial_transport);
            Console.WriteLine("graphic_culture: " + cData.graphic_culture);
            Console.WriteLine("initial_ideology: " + cData.initial_ideology);
            Console.WriteLine("last_election_at: " + cData.last_election_at);
            Console.WriteLine("election_interval: " + cData.election_interval);
            Console.WriteLine("is_no_election: " + cData.is_no_election);
            Console.WriteLine("color_r: " + cData.color_r);
            Console.WriteLine("color_g: " + cData.color_g);
            Console.WriteLine("color_b: " + cData.color_b);
            Console.WriteLine("country_flag_path_neutrality: " + cData.country_flag_path_neutrality);
            Console.WriteLine("country_flag_path_neutrality_medium: " + cData.country_flag_path_neutrality_medium);
            Console.WriteLine("country_flag_path_neutrality_small: " + cData.country_flag_path_neutrality_small);
            Console.WriteLine("country_flag_path_democratic: " + cData.country_flag_path_democratic);
            Console.WriteLine("country_flag_path_democratic_medium: " + cData.country_flag_path_democratic_medium);
            Console.WriteLine("country_flag_path_democratic_small: " + cData.country_flag_path_democratic_small);
            Console.WriteLine("country_flag_path_fascism: " + cData.country_flag_path_fascism);
            Console.WriteLine("country_flag_path_fascism_medium: " + cData.country_flag_path_fascism_medium);
            Console.WriteLine("country_flag_path_fascism_small: " + cData.country_flag_path_fascism_small);
            Console.WriteLine("country_flag_path_communism: " + cData.country_flag_path_communism);
            Console.WriteLine("country_flag_path_communism_medium: " + cData.country_flag_path_communism_medium);
            Console.WriteLine("country_flag_path_communism_small: " + cData.country_flag_path_communism_small);
            Console.WriteLine("party_support_neutrality: " + cData.party_support_neutrality);
            Console.WriteLine("party_support_democratic: " + cData.party_support_democratic);
            Console.WriteLine("party_support_fascism: " + cData.party_support_fascism);
            Console.WriteLine("party_support_communism: " + cData.party_support_communism);

            Console.WriteLine("---project data---");
            Console.WriteLine("project_name: " + pData.project_name);
            Console.WriteLine("created_at: " + pData.created_at);
            Console.WriteLine("updated_at: " + pData.updated_at);
        }
    }
}
