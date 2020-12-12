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
        private void GetCountryData(string tableName, int colmn, CountriesData cd)
        {
            if (sqlc == null)
                return;

            SQLiteCommand cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName + " LIMIT " + colmn + ", 1";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
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
            }
        }

        /// <summary>
        /// プロジェクトデータを取得
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        private void GetProjectData(string tableName, ProjectData pd)
        {
            if (sqlc == null)
                return;

            SQLiteCommand cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName;

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();

                pd.Initialize();
                pd.project_name = reader.GetString(0);
                pd.created_at = reader.GetDateTime(1);
                pd.updated_at = reader.GetDateTime(2);
            }
        }

        /// <summary>
        /// データベースから国家データを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        public void ImportCountriesData(string dbFile, string tableName, int colmn, CountriesData cd)
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
        public void ImportProjectData(string dbFile, string tableName, ProjectData pd)
        {
            ConnectionDataBase(dbFile);
            GetProjectData(tableName, pd);
            DisconnectionDataBase();
        }
    }
}
