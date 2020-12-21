using System;
using HoI4ModdingManager.ModdingProjectManager.Data;
using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.Workers
{
    class ProjectImporter
    {
        SQLiteConnection sqlc = null;
        
        /// <summary>
        /// データベース接続
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        private void ConnectionDataBase(string dbFile)
        {
            sqlc = new SQLiteConnection("Data Source=" + dbFile);
            
            try
            {
                sqlc.Open();
                // debug log
                Console.WriteLine("[SQLite]: Connenction successfull.");
            }
            catch (Exception e)
            {
                Console.WriteLine("[SQLite]: " + e.Message);
            }
        }

        /// <summary>
        /// データベース切断
        /// </summary>
        private void DisconnectionDataBase()
        {
            if (sqlc == null)
                return;

            sqlc.Close();
        }

        /// <summary>
        /// 国家データを取得（一列のみ）
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        private void GetCountryData(string tableName, int colmn, CountryDataHanger cd)
        {
            if (sqlc == null)
                return;

            var cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName + " LIMIT " + colmn + ", 1";

            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                cd.Initialize();

                cd.id = reader.GetInt32(0);
                cd.country_tag = reader.GetString(1);
                cd.country_name = reader.GetString(2);
                cd.country_name_neutrality = reader.GetString(3);
                cd.country_name_neutrality_def = reader.GetString(4);
                cd.country_name_neutrality_adj = reader.GetString(5);
                cd.country_name_democratic = reader.GetString(6);
                cd.country_name_democratic_def = reader.GetString(7);
                cd.country_name_democratic_adj = reader.GetString(8);
                cd.country_name_fascism = reader.GetString(9);
                cd.country_name_fascism_def = reader.GetString(10);
                cd.country_name_fascism_adj = reader.GetString(11);
                cd.country_name_communism = reader.GetString(12);
                cd.country_name_communism_def = reader.GetString(13);
                cd.country_name_communism_adj = reader.GetString(14);
                cd.party_name_neutrality = reader.GetString(15);
                cd.party_name_neutrality_long = reader.GetString(16);
                cd.party_name_democratic = reader.GetString(17);
                cd.party_name_democratic_long = reader.GetString(18);
                cd.party_name_fascism = reader.GetString(19);
                cd.party_name_fascism_long = reader.GetString(20);
                cd.party_name_communism = reader.GetString(21);
                cd.party_name_communism_long = reader.GetString(22);
                cd.capital_state_id = reader.GetInt32(23);
                cd.initial_teach_slot = reader.GetInt32(24);
                cd.initial_stability = reader.GetInt32(25);
                cd.initial_war_coop = reader.GetInt32(26);
                cd.initial_political_power = reader.GetInt32(27);
                cd.initial_transport = reader.GetInt32(28);
                cd.graphic_culture = reader.GetString(29);
                cd.initial_ideology = reader.GetString(30);
                cd.last_election_at = reader.GetDateTime(31);
                cd.election_interval = reader.GetInt32(32);

                if (reader.GetInt32(33) == 0)
                    cd.is_no_election = false;
                else
                    cd.is_no_election = true;

                cd.color_r = reader.GetInt32(34);
                cd.color_g = reader.GetInt32(35);
                cd.color_b = reader.GetInt32(36);
                cd.country_flag_path_neutrality = reader.GetString(37);
                cd.country_flag_path_neutrality_medium = reader.GetString(38);
                cd.country_flag_path_neutrality_small = reader.GetString(39);
                cd.country_flag_path_democratic = reader.GetString(40);
                cd.country_flag_path_democratic_medium = reader.GetString(41);
                cd.country_flag_path_democratic_small = reader.GetString(42);
                cd.country_flag_path_fascism = reader.GetString(43);
                cd.country_flag_path_fascism_medium = reader.GetString(44);
                cd.country_flag_path_fascism_small = reader.GetString(45);
                cd.country_flag_path_communism = reader.GetString(46);
                cd.country_flag_path_communism_medium = reader.GetString(47);
                cd.country_flag_path_communism_small = reader.GetString(48);
                cd.party_support_neutrality = reader.GetInt32(49);
                cd.party_support_democratic = reader.GetInt32(50);
                cd.party_support_fascism = reader.GetInt32(51);
                cd.party_support_communism = reader.GetInt32(52);
            }
        }

        /// <summary>
        /// プロジェクトデータを取得
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        private void GetProjectData(string tableName, ProjectDataHanger pd)
        {
            if (sqlc == null)
                return;

            var cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName;

            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();

                pd.Initialize();
                pd.project_name = reader.GetString(0);
                pd.created_at = reader.GetDateTime(1);
                pd.updated_at = reader.GetDateTime(2);
                pd.number_of_countries = reader.GetInt32(3);
                pd.number_of_ideologies = reader.GetInt32(4);
            }
        }

        /// <summary>
        /// イデオロギーデータを取得
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="id">クラスインスタンス</param>
        private void GetIdeologiesData(string tableName, IdeologyDataHanger id)
        {
            if (sqlc == null)
                return;

            var cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName;

            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();

                id.Initialize();
                id.ideology_name = reader.GetString(0);
                // コンマで区切る（スペースは含めない）
                id.small_ideologies = reader.GetString(1).Split(',');
                id.color_r = reader.GetInt32(2);
                id.color_g = reader.GetInt32(3);
                id.color_b = reader.GetInt32(4);

                if (reader.GetInt32(5) == 0)
                    id.rule_can_force_government = false;
                else
                    id.rule_can_force_government = true;

                if (reader.GetInt32(6) == 0)
                    id.rule_can_puppet = false;
                else
                    id.rule_can_puppet = true;

                if (reader.GetInt32(7) == 0)
                    id.rule_can_join_factions = false;
                else
                    id.rule_can_join_factions = true;

                if (reader.GetInt32(8) == 0)
                    id.rule_can_create_factions = false;
                else
                    id.rule_can_create_factions = true;

                if (reader.GetInt32(9) == 0)
                    id.rule_can_send_volunteers = false;
                else
                    id.rule_can_send_volunteers = true;

                if (reader.GetInt32(10) == 0)
                    id.rule_can_lower_tension = false;
                else
                    id.rule_can_lower_tension = true;

                id.modifier_generate_wargoal_tension = reader.GetInt32(11);
                id.modifier_guarantee_tension = reader.GetInt32(12);
                id.modifier_civilian_intel_to_others = reader.GetInt32(13);
                id.modifier_army_intel_to_others = reader.GetInt32(14);
                id.modifier_navy_intel_to_others = reader.GetInt32(15);
                id.modifier_airforce_intel_to_others = reader.GetInt32(16);
                id.modifier_justify_war_goal_when_in_major_war_time = reader.GetInt32(17);
                id.modifier_join_faction_tension = reader.GetInt32(18);
                id.modifier_lend_lease_tension = reader.GetInt32(19);
                id.modifier_annex_cost_factor = reader.GetInt32(20);

                if (reader.GetInt32(21) == 0)
                    id.ai_uses_this_ideology = false;
                else
                    id.ai_uses_this_ideology = true;

                if (reader.GetInt32(22) == 0)
                    id.can_be_boosted = false;
                else
                    id.can_be_boosted = true;

                id.war_impact_on_world_tension = reader.GetInt32(23);

                if (reader.GetInt32(23) == 0)
                    id.can_collaborate = false;
                else
                    id.can_collaborate = true;

                if (reader.GetInt32(24) == 0)
                    id.can_host_government_in_exile = false;
                else
                    id.can_host_government_in_exile = true;
            }
        }

        /// <summary>
        /// データベースから国家データを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        public void ImportCountryData(string dbFile, string tableName, int colmn, CountryDataHanger cd)
        {
            ConnectionDataBase(dbFile);
            GetCountryData(tableName, colmn, cd);
            DisconnectionDataBase();
        }

        /// <summary>
        /// データベースからプロジェクトデータを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        public void ImportProjectData(string dbFile, string tableName, ProjectDataHanger pd)
        {
            ConnectionDataBase(dbFile);
            GetProjectData(tableName, pd);
            DisconnectionDataBase();
        }

        /// <summary>
        /// データベースからイデオロギーデータを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="id">クラスインスタンス</param>
        public void ImportIdeologyData(string dbFile, string tableName, IdeologyDataHanger id)
        {
            ConnectionDataBase(dbFile);
            GetIdeologiesData(tableName, id);
            DisconnectionDataBase();
        }
    }
}
