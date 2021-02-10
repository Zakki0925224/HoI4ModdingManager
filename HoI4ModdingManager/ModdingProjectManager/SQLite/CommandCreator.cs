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

            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {tableName}";

            if (isGetWithColmn)
                cmd.CommandText = $"{cmd.CommandText} LIMIT {colmn}, 1";

            return cmd;
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
        
        public static void CreateCountryDataField(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                string[] names = NameDefinition.CountryDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.CountryDataTableName}" +
                    $"({names[0]} TEXT, " +
                    $"{names[1]} TEXT, " +
                    $"{names[2]} INTEGER, " +
                    $"{names[3]} REAL, " +
                    $"{names[4]} REAL, " +
                    $"{names[5]} INTEGER, " +
                    $"{names[6]} INTEGER, " +
                    $"{names[7]} INTEGER, " +
                    $"{names[8]} TEXT, " +
                    $"{names[9]} TEXT, " +
                    $"{names[10]} TEXT, " +
                    $"{names[11]} BLOB, " +
                    $"{names[12]} INTEGER, " +
                    $"{names[13]} TEXT, " +
                    $"{names[14]} TEXT, " +
                    $"{names[15]} TEXT, " +
                    $"{names[16]} TEXT, " +
                    $"{names[17]} TEXT, " +
                    $"{names[18]} TEXT)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateIdeologyDataField(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                string[] names = NameDefinition.IdeologyDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.IdeologyDataTableName}" +
                    $"({names[0]} TEXT, " +
                    $"{names[1]} TEXT, " +
                    $"{names[2]} TEXT, " +
                    $"{names[3]} INTEGER, " +
                    $"{names[4]} INTEGER, " +
                    $"{names[5]} INTEGER, " +
                    $"{names[6]} INTEGER, " +
                    $"{names[7]} INTEGER, " +
                    $"{names[8]} INTEGER, " +
                    $"{names[9]} INTEGER, " +
                    $"{names[10]} INTEGER, " +
                    $"{names[11]} INTEGER, " +
                    $"{names[12]} REAL, " +
                    $"{names[13]} REAL, " +
                    $"{names[14]} INTEGER, " +
                    $"{names[15]} INTEGER, " +
                    $"{names[16]} INTEGER, " +
                    $"{names[17]} INTEGER, " +
                    $"{names[18]} REAL, " +
                    $"{names[19]} REAL, " +
                    $"{names[20]} REAL, " +
                    $"{names[21]} REAL, " +
                    $"{names[22]} REAL, " +
                    $"{names[23]} REAL, " +
                    $"{names[24]} REAL, " +
                    $"{names[25]} REAL, " +
                    $"{names[26]} INTEGER, " +
                    $"{names[27]} INTEGER, " +
                    $"{names[28]} REAL, " +
                    $"{names[29]} REAL, " +
                    $"{names[30]} INTEGER, " +
                    $"{names[31]} INTEGER)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateProjectDataField(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                string[] names = NameDefinition.ProjectDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.ProjectDataTableName} " +
                    $"({names[0]} TEXT, " +
                    $"{names[1]} TEXT, " +
                    $"{names[2]} TEXT, " +
                    $"{names[3]} TEXT, " +
                    $"{names[4]} TEXT, " +
                    $"{names[5]} TEXT, " +
                    $"{names[6]} TEXT, " +
                    $"{names[7]} TEXT, " +
                    $"{names[8]} TEXT, " +
                    $"{names[9]} TEXT, " +
                    $"{names[10]} TEXT)";
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
