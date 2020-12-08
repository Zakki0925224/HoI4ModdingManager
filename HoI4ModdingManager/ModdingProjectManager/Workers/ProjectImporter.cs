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
            dbFile = @"D:\software\sqlite3\test.hmp";

            using (sqlc = new SQLiteConnection("Data Source=" + dbFile))
            {
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

            using (sqlc)
            {
                SQLiteCommand cmd = sqlc.CreateCommand();
                cmd.CommandText = "SELECT * FROM" + tableName + " LIMIT " + colmn + ", 1";

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    cd.DataReset();

                    // 変数に値を保存
                    cd.id = (int?)reader.GetValue(0);
                    cd.created_at = (DateTime?)reader.GetValue(1);
                    cd.updated_at = (DateTime?)reader.GetValue(2);
                    cd.country_tag = reader.GetValue(3).ToString();
                    cd.country_name = reader.GetValue(4).ToString();
                    cd.country_name_neutrality = reader.GetValue(5).ToString();
                    cd.country_name_neutrality_def = reader.GetValue(6).ToString();
                    cd.country_name_neutrality_adj = reader.GetValue(7).ToString();
                    cd.country_name_democratic = reader.GetValue(8).ToString();
                    cd.country_name_democratic_def = reader.GetValue(9).ToString();
                    cd.country_name_democratic_adj = reader.GetValue(10).ToString();
                    cd.country_name_fascism = reader.GetValue(11).ToString();
                    cd.country_name_fascism_def = reader.GetValue(12).ToString();
                    cd.country_name_fascism_adj = reader.GetValue(13).ToString();
                    cd.country_name_communism = reader.GetValue(14).ToString();
                    cd.country_name_communism_def = reader.GetValue(15).ToString();
                    cd.country_name_communism_adj = reader.GetValue(16).ToString();
                    cd.party_name_neutrality = reader.GetValue(17).ToString();
                    cd.party_name_neutrality_long = reader.GetValue(18).ToString();
                    cd.party_name_democratic = reader.GetValue(19).ToString();
                    cd.party_name_democratic_long = reader.GetValue(20).ToString();
                    cd.party_name_fascism = reader.GetValue(21).ToString();
                    cd.party_name_fascism_long = reader.GetValue(22).ToString();
                    cd.party_name_communism = reader.GetValue(23).ToString();
                    cd.party_name_communism_long = reader.GetValue(24).ToString();
                    cd.capital_state_id = (int?)reader.GetValue(25);
                    cd.initial_teach_slot = (int?)reader.GetValue(26);
                    cd.initial_stability = (int?)reader.GetValue(27);
                    cd.initial_war_coop = (int?)reader.GetValue(28);
                    cd.initial_political_power = (int?)reader.GetValue(29);
                    cd.initial_transport = (int?)reader.GetValue(30);
                    cd.graphic_culture = reader.GetValue(31).ToString();
                    cd.initial_ideology = reader.GetValue(32).ToString();
                    cd.last_election_at = (DateTime?)reader.GetValue(33);
                    cd.election_interval = (int?)reader.GetValue(34);
                    cd.is_no_election = (bool?)reader.GetValue(35);
                }
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
            // 変数をnullで初期化
            cd.DataReset();

            ConnectionDataBase(dbFile);
            GetData(tableName, colmn, cd);
            DisconnectionDataBase();
        }
    }
}
