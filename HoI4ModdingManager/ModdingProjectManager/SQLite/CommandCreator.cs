using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    static class CommandCreator
    {
        private static void CheckNotConnectingException(SQLiteConnection connection)
        {
            if (connection == null)
                throw new NotConnectingException();
        }

        public static SQLiteCommand GetDataByTable(SQLiteConnection connection, string tableName, bool isGetWithColmn, int colmn = 0)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM {tableName}";

                if (isGetWithColmn)
                    cmd.CommandText = $"{cmd.CommandText} LIMIT {colmn}, 1";

                return cmd;
            }
        }

        public static long GetDataCount(SQLiteConnection connection, string tableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"SELECT COUNT(*) FROM {tableName}";

                return (long)cmd.ExecuteScalar();
            }
        }
        
        public static void CreateCountryDataTable(SQLiteConnection connection, string countryDataTableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                // テーブル作成
                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {countryDataTableName}" +
                    "(name TEXT, " +
                    "country_tag TEXT, " +
                    "capital_state_id INTEGER, " +
                    "stability REAL, " +
                    "war_support REAL, " +
                    "political_power INTEGER, " +
                    "research_slots INTEGER, " +
                    "convoys INTEGER, " +
                    "technologies TEXT, " +
                    "ideas TEXT, " +
                    "ruling_party_ideology TEXT, " +
                    "last_election_at BLOB, " +
                    "is_allow_election INTEGER, " +
                    "party_supports TEXT, " +
                    "rgb_country_color TEXT, " +
                    "graphic_culture TEXT, " +
                    "country_names TEXT, " +
                    "party_names TEXT, " +
                    "country_flag_paths TEXT)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateIdeologyDataTable(SQLiteConnection connection, string ideologyDataTableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                // テーブル作成
                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {ideologyDataTableName}" +
                    "(name TEXT, " +
                    "small_ideologies TEXT, " +
                    "rgb_ideology_color TEXT, " +
                    "id INTEGER, " +
                    "rule_can_force_government INTEGER, " +
                    "rule_can_puppet INTEGER, " +
                    "rule_can_send_volunteers INTEGER, " +
                    "rule_can_lower_tension INTEGER, " +
                    "rule_can_create_collaboration_government INTEGER, " +
                    "rule_can_declare_war_on_same_ideology INTEGER, " +
                    "rule_can_only_justify_war_on_threat_country INTEGER, " +
                    "rule_can_guarantee_other_ideologies INTEGER, " +
                    "modifier_generate_war_goal_tension REAL, " +
                    "modifier_guarantee_tension REAL, " +
                    "modifier_civilian_intel_to_others INTEGER, " +
                    "modifier_army_intel_to_others INTEGER, " +
                    "modifier_navy_intel_to_others INTEGER, " +
                    "modifier_airforce_intel_to_others INTEGER, " +
                    "modifier_justify_war_goal_when_in_major_war_time REAL, " +
                    "modifier_join_faction_tension REAL, " +
                    "modifier_lend_lease_tension REAL, " +
                    "modifier_annex_cost_factor REAL, " +
                    "modifier_send_volunteers_tension REAL, " +
                    "modifier_take_states_cost_factor REAL, " +
                    "modifier_drift_defence_factor REAL, " +
                    "modifier_puppet_cost_factor REAL, " +
                    "can_ai_use INTEGER, " +
                    "can_be_boosted INTEGER, " +
                    "war_impact_on_world_tension REAL, " +
                    "faction_impact_on_world_tension REAL, " +
                    "can_collaborate INTEGER, " +
                    "can_host_government_in_exile INTEGER)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateProjectDataTable(SQLiteConnection connection, string projectDataTableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                // テーブル作成
                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {projectDataTableName} " +
                    $"(project_name TEXT, " +
                    $"mod_version TEXT, " +
                    $"supported_game_version TEXT, " +
                    $"tags TEXT, " +
                    $"thumbnail_picture_path TEXT, " +
                    $"replace_paths TEXT, " +
                    $"mod_path TEXT, " +
                    $"user_dir TEXT, " +
                    $"remote_file_id TEXT, " +
                    $"depondency_mods TEXT, " +
                    $"depondency_dlcs TEXT)";
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 指定したテーブル上の全てのデータを削除
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="tableName"></param>
        public static void DeleteAllDataOnTable(SQLiteConnection connection, string tableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = $"DELETE FROM {tableName}";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
