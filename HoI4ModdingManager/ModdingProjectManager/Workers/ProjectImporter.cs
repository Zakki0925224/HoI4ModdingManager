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
        /// <param name="colmn">取得したい列番号(1~)</param>
        /// <param name="cd">クラスインスタンス</param>
        private void GetData(string tableName,int colmn, CountriesData cd)
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

                }
            }
        }
    }
}
