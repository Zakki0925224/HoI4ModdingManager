using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectImporter
{
    class StoreData
    {
        /// <summary>
        /// 国家データを取得（一列のみ）
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        /// <param name="sqlc">SQLiteConnection</param>
        private void ReadCountryData(string tableName, int colmn, CountryDataHanger cd, SQLiteConnection sqlc)
        {
            using (var reader = CommandCreator.GetDataByTable(sqlc, tableName, true, colmn).ExecuteReader())
            {
                reader.Read();

                cd.Id = reader.GetInt32(0);
                cd.Country_tag = reader.GetString(1);
                cd.Country_name = reader.GetString(2);
                cd.Country_name_neutrality = reader.GetString(3);
                cd.Country_name_neutrality_def = reader.GetString(4);
                cd.Country_name_neutrality_adj = reader.GetString(5);
                cd.Country_name_democratic = reader.GetString(6);
                cd.Country_name_democratic_def = reader.GetString(7);
                cd.Country_name_democratic_adj = reader.GetString(8);
                cd.Country_name_fascism = reader.GetString(9);
                cd.Country_name_fascism_def = reader.GetString(10);
                cd.Country_name_fascism_adj = reader.GetString(11);
                cd.Country_name_communism = reader.GetString(12);
                cd.Country_name_communism_def = reader.GetString(13);
                cd.Country_name_communism_adj = reader.GetString(14);
                cd.Party_name_neutrality = reader.GetString(15);
                cd.Party_name_neutrality_long = reader.GetString(16);
                cd.Party_name_democratic = reader.GetString(17);
                cd.Party_name_democratic_long = reader.GetString(18);
                cd.Party_name_fascism = reader.GetString(19);
                cd.Party_name_fascism_long = reader.GetString(20);
                cd.Party_name_communism = reader.GetString(21);
                cd.Party_name_communism_long = reader.GetString(22);
                cd.Capital_state_id = reader.GetInt32(23);
                cd.Initial_teach_slot = reader.GetInt32(24);
                cd.Initial_stability = reader.GetInt32(25);
                cd.Initial_war_coop = reader.GetInt32(26);
                cd.Initial_political_power = reader.GetInt32(27);
                cd.Initial_transport = reader.GetInt32(28);
                cd.Graphic_culture = reader.GetString(29);
                cd.Initial_ideology = reader.GetString(30);
                cd.Last_election_at = reader.GetDateTime(31);
                cd.Election_interval = reader.GetInt32(32);
                cd.Is_no_election = GetBool(reader.GetInt32(33));
                cd.Color_r = reader.GetInt32(34);
                cd.Color_g = reader.GetInt32(35);
                cd.Color_b = reader.GetInt32(36);
                cd.Country_flag_path_neutrality = reader.GetString(37);
                cd.Country_flag_path_neutrality_medium = reader.GetString(38);
                cd.Country_flag_path_neutrality_small = reader.GetString(39);
                cd.Country_flag_path_democratic = reader.GetString(40);
                cd.Country_flag_path_democratic_medium = reader.GetString(41);
                cd.Country_flag_path_democratic_small = reader.GetString(42);
                cd.Country_flag_path_fascism = reader.GetString(43);
                cd.Country_flag_path_fascism_medium = reader.GetString(44);
                cd.Country_flag_path_fascism_small = reader.GetString(45);
                cd.Country_flag_path_communism = reader.GetString(46);
                cd.Country_flag_path_communism_medium = reader.GetString(47);
                cd.Country_flag_path_communism_small = reader.GetString(48);
                cd.Party_support_neutrality = reader.GetInt32(49);
                cd.Party_support_democratic = reader.GetInt32(50);
                cd.Party_support_fascism = reader.GetInt32(51);
                cd.Party_support_communism = reader.GetInt32(52);
            }
        }

        /// <summary>
        /// プロジェクトデータを取得
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        /// <param name="sqlc">SQLiteConnection</param>
        private void ReadProjectData(string tableName, ProjectDataHanger pd, SQLiteConnection sqlc)
        {
            using (var reader = CommandCreator.GetDataByTable(sqlc, tableName, false).ExecuteReader())
            {
                reader.Read();

                pd.Project_name = reader.GetString(0);
                pd.Created_at = reader.GetDateTime(1);
                pd.Updated_at = reader.GetDateTime(2);
                pd.Number_of_countries = reader.GetInt32(3);
                pd.Number_of_ideologies = reader.GetInt32(4);
            }
        }

        /// <summary>
        /// イデオロギーデータを取得
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="id">クラスインスタンス</param>
        /// <param name="sqlc">SQLiteConnection</param>
        private void ReadIdeologyData(string tableName, int colmn, IdeologyDataHanger id, SQLiteConnection sqlc)
        {
            using (var reader = CommandCreator.GetDataByTable(sqlc, tableName, true, colmn).ExecuteReader())
            {
                reader.Read();

                id.Ideology_name = reader.GetString(0);
                // コンマで区切る（スペースは含めない）
                id.Small_ideologies = reader.GetString(1).Split(',');
                id.Color_r = reader.GetInt32(2);
                id.Color_g = reader.GetInt32(3);
                id.Color_b = reader.GetInt32(4);
                id.Rule_can_force_government = GetBool(reader.GetInt32(5));
                id.Rule_can_puppet = GetBool(reader.GetInt32(6));
                id.Rule_can_join_factions = GetBool(reader.GetInt32(7));
                id.Rule_can_create_factions = GetBool(reader.GetInt32(8));
                id.Rule_can_send_volunteers = GetBool(reader.GetInt32(9));
                id.Rule_can_lower_tension = GetBool(reader.GetInt32(10));
                id.Modifier_generate_wargoal_tension = reader.GetInt32(11);
                id.Modifier_guarantee_tension = reader.GetInt32(12);
                id.Modifier_civilian_intel_to_others = reader.GetInt32(13);
                id.Modifier_army_intel_to_others = reader.GetInt32(14);
                id.Modifier_navy_intel_to_others = reader.GetInt32(15);
                id.Modifier_airforce_intel_to_others = reader.GetInt32(16);
                id.Modifier_justify_war_goal_when_in_major_war_time = reader.GetInt32(17);
                id.Modifier_join_faction_tension = reader.GetInt32(18);
                id.Modifier_lend_lease_tension = reader.GetInt32(19);
                id.Modifier_annex_cost_factor = reader.GetInt32(20);
                id.Ai_uses_this_ideology = GetBool(reader.GetInt32(21));
                id.Can_be_boosted = GetBool(reader.GetInt32(22));
                id.War_impact_on_world_tension = reader.GetInt32(23);
                id.Can_collaborate = GetBool(reader.GetInt32(24));
                id.Can_host_government_in_exile = GetBool(reader.GetInt32(25));
            }
        }

        private bool GetBool(int value)
        {
            if (value == 0)
                return false;
            else
                return true;
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
            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);
                ReadCountryData(tableName, colmn, cd, dbc.sqlc);
            }
        }

        /// <summary>
        /// データベースからプロジェクトデータを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        public void ImportProjectData(string dbFile, string tableName, ProjectDataHanger pd)
        {
            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);
                ReadProjectData(tableName, pd, dbc.sqlc);
            }
        }

        /// <summary>
        /// データベースからイデオロギーデータを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="id">クラスインスタンス</param>
        public void ImportIdeologyData(string dbFile, string tableName, int colmn, IdeologyDataHanger id)
        {
            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);
                ReadIdeologyData(tableName, colmn, id, dbc.sqlc);
            }
        }
    }
}
