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

            var cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM {tableName}";

            return (long)cmd.ExecuteScalar();
        }
    }
}
