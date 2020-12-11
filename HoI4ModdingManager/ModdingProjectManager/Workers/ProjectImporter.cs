using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.Common.Workers;
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
        /// データを取得（一列のみ）
        /// </summary>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        private void GetData(string tableName, int colmn, CountriesData cd)
        {
            if (sqlc == null)
                return;

            SQLiteCommand cmd = sqlc.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tableName + " LIMIT " + colmn + ", 1";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                cd.Initialize();

                // 変数に値を保存
                cd.id = reader.GetInt32(0);
                cd.created_at = reader.GetDateTime(1);
                cd.updated_at = reader.GetDateTime(2);
                cd.country_tag = reader.GetString(3);
                cd.country_name = reader.GetString(4);
                cd.country_name_neutrality = reader.GetString(5);
                cd.country_name_neutrality_def = reader.GetString(6);
                cd.country_name_neutrality_adj = reader.GetString(7);
                cd.country_name_democratic = reader.GetString(8);
                cd.country_name_democratic_def = reader.GetString(9);
                cd.country_name_democratic_adj = reader.GetString(10);
                cd.country_name_fascism = reader.GetString(11);
                cd.country_name_fascism_def = reader.GetString(12);
                cd.country_name_fascism_adj = reader.GetString(13);
                cd.country_name_communism = reader.GetString(14);
                cd.country_name_communism_def = reader.GetString(15);
                cd.country_name_communism_adj = reader.GetString(16);
                cd.party_name_neutrality = reader.GetString(17);
                cd.party_name_neutrality_long = reader.GetString(18);
                cd.party_name_democratic = reader.GetString(19);
                cd.party_name_democratic_long = reader.GetString(20);
                cd.party_name_fascism = reader.GetString(21);
                cd.party_name_fascism_long = reader.GetString(22);
                cd.party_name_communism = reader.GetString(23);
                cd.party_name_communism_long = reader.GetString(24);
                cd.capital_state_id = reader.GetInt32(25);
                cd.initial_teach_slot = reader.GetInt32(26);
                cd.initial_stability = reader.GetInt32(27);
                cd.initial_war_coop = reader.GetInt32(28);
                cd.initial_political_power = reader.GetInt32(29);
                cd.initial_transport = reader.GetInt32(30);
                cd.graphic_culture = reader.GetString(31);
                cd.initial_ideology = reader.GetString(32);
                cd.last_election_at = reader.GetDateTime(33);
                cd.election_interval = reader.GetInt32(34);

                if (reader.GetInt32(35) == 0)
                    cd.is_no_election = false;
                else
                    cd.is_no_election = true;

                cd.color_r = reader.GetInt32(36);
                cd.color_g = reader.GetInt32(37);
                cd.color_b = reader.GetInt32(38);
                cd.country_flag_path_neutrality = reader.GetString(39);
                cd.country_flag_path_neutrality_medium = reader.GetString(40);
                cd.country_flag_path_neutrality_small = reader.GetString(41);
                cd.country_flag_path_democratic = reader.GetString(42);
                cd.country_flag_path_democratic_medium = reader.GetString(43);
                cd.country_flag_path_democratic_small = reader.GetString(44);
                cd.country_flag_path_fascism = reader.GetString(45);
                cd.country_flag_path_fascism_medium = reader.GetString(46);
                cd.country_flag_path_fascism_small = reader.GetString(47);
                cd.country_flag_path_communism = reader.GetString(48);
                cd.country_flag_path_communism_medium = reader.GetString(49);
                cd.country_flag_path_communism_small = reader.GetString(50);
            }
        }

        /// <summary>
        /// データベースから国家データを取得
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="colmn">取得したい列番号(0~)</param>
        /// <param name="cd">クラスインスタンス</param>
        public void GetCountriesData(string dbFile, string tableName, int colmn, CountriesData cd)
        {
            ConnectionDataBase(dbFile);
            GetData(tableName, colmn, cd);
            DisconnectionDataBase();
        }
    }
}
