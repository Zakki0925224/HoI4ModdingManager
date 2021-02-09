using System;
using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    class DataBaseConnector : IDisposable
    {
        public SQLiteConnection sqlc = null;

        /// <summary>
        /// データベース接続
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        public void ConnectionDataBase(string dbFile)
        {
            sqlc = new SQLiteConnection($"Data Source={dbFile}");

            try
            {
                sqlc.Open();
                // debug log
                Console.WriteLine($"[SQLite][Path:\"{dbFile}\"]: Connenction successfull.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"[SQLite][Path:\"{dbFile}\"]: " + e.Message);
                throw e;
            }
        }

        /// <summary>
        /// データベース切断
        /// </summary>
        private void DisconnectionDataBase()
        {
            if (sqlc == null)
                throw new NotConnectingException();

            sqlc.Close();
        }

        /// <summary>
        /// リソース開放
        /// </summary>
        public void Dispose()
        {
            DisconnectionDataBase();
            sqlc.Dispose();
        }
    }
}
