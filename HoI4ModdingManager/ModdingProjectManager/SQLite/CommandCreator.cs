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

        public static string[] GetTableList(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT NAME FROM sqlite_master WHERE TYPE='table'";
                return (string[])cmd.ExecuteScalar();
            }
        }
        
        public static void CreateCountryDataTable(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                var names = NameDefinition.CountryDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.CountryDataTableName}" +
                    $"({names["Name"]} TEXT, " +
                    $"{names["CountryTag"]} TEXT, " +
                    $"{names["CapitalStateID"]} TEXT, " +
                    $"{names["Stability"]} TEXT, " +
                    $"{names["WarSupport"]} TEXT, " +
                    $"{names["PoliticalPower"]} TEXT, " +
                    $"{names["ResearchSlots"]} TEXT, " +
                    $"{names["Convoys"]} TEXT, " +
                    $"{names["UnitFileID"]} TEXT, " +
                    $"{names["Technologies"]} TEXT, " +
                    $"{names["Ideas"]} TEXT, " +
                    $"{names["RulingPartyIdeology"]} TEXT, " +
                    $"{names["LastElectionAt"]} TEXT, " +
                    $"{names["IsAllowElection"]} TEXT, " +
                    $"{names["PartySupports"]} TEXT, " +
                    $"{names["RGBCountryColor"]} TEXT, " +
                    $"{names["GraphicCulture"]} TEXT, " +
                    $"{names["CountryNames"]} TEXT, " +
                    $"{names["PartyNames"]} TEXT, " +
                    $"{names["CountryFlagPaths"]} TEXT)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateIdeologyDataTable(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                var names = NameDefinition.IdeologyDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.IdeologyDataTableName}" +
                    $"({names["Name"]} TEXT, " +
                    $"{names["SmallIdeologies"]} TEXT, " +
                    $"{names["RGBIdeologyColor"]} TEXT, " +
                    $"{names["ID"]} TEXT, " +
                    $"{names["Rule_CanForceGovernment"]} TEXT, " +
                    $"{names["Rule_CanPuppet"]} TEXT, " +
                    $"{names["Rule_CanSendVolunteers"]} TEXT, " +
                    $"{names["Rule_CanLowerTension"]} TEXT, " +
                    $"{names["Rule_CanCreateCollaborationGovernment"]} TEXT, " +
                    $"{names["Rule_CanDeclareWarOnSameIdeology"]} TEXT, " +
                    $"{names["Rule_CanOnlyJustifyWarOnThreatCountry"]} TEXT, " +
                    $"{names["Rule_CanGuaranteeOtherIdeologies"]} TEXT, " +
                    $"{names["Modifier_GenerateWarGoalTension"]} TEXT, " +
                    $"{names["Modifier_GuaranteeTension"]} TEXT, " +
                    $"{names["Modifier_CivilianIntelToOthers"]} TEXT, " +
                    $"{names["Modifier_ArmyIntelToOthers"]} TEXT, " +
                    $"{names["Modifier_NavyIntelToOthers"]} TEXT, " +
                    $"{names["Modifier_AirforceIntelToOthers"]} TEXT, " +
                    $"{names["Modifier_JustifyWarGoalWhenInMajorWarTime"]} TEXT, " +
                    $"{names["Modifier_JoinFactionTension"]} TEXT, " +
                    $"{names["Modifier_LendLeaseTension"]} TEXT, " +
                    $"{names["Modifier_AnnexCostFactor"]} TEXT, " +
                    $"{names["Modifier_SendVolunteersTension"]} TEXT, " +
                    $"{names["Modifier_TakeStatesCostFactor"]} TEXT, " +
                    $"{names["Modifier_DriftDefenceFactor"]} TEXT, " +
                    $"{names["Modifier_PuppetCostFactor"]} TEXT, " +
                    $"{names["CanAiUse"]} TEXT, " +
                    $"{names["CanBeBoosted"]} TEXT, " +
                    $"{names["WarImpactOnWorldTension"]} TEXT, " +
                    $"{names["FactionImpactOnWorldTension"]} TEXT, " +
                    $"{names["CanCollaborate"]} TEXT, " +
                    $"{names["CanHostGovernmentInExile"]} TEXT)";
                cmd.ExecuteNonQuery();
            }
        }

        public static void CreateProjectDataTable(SQLiteConnection connection)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                var names = NameDefinition.ProjectDataFieldNameList;

                cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {NameDefinition.ProjectDataTableName} " +
                    $"({names["ProjectName"]} TEXT, " +
                    $"{names["ModVersion"]} TEXT, " +
                    $"{names["SupportedGameVersion"]} TEXT, " +
                    $"{names["Tags"]} TEXT, " +
                    $"{names["ThumbnailPicturePath"]} TEXT, " +
                    $"{names["ReplacePaths"]} TEXT, " +
                    $"{names["ModPath"]} TEXT, " +
                    $"{names["UserDir"]} TEXT, " +
                    $"{names["RemoteFileID"]} TEXT, " +
                    $"{names["DepondencyMods"]} TEXT, " +
                    $"{names["DepondencyDLCs"]} TEXT)";
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

        public static void InsertValues(SQLiteConnection connection, string[] values, string tableName)
        {
            CheckNotConnectingException(connection);

            using (var cmd = connection.CreateCommand())
            {
                string valuesText = "";
                for (int cnt = 0; cnt < values.Length; cnt++)
                {
                    values[cnt].Replace("\'", "\'\'");
                    valuesText += $"\'{values[cnt]}\'";
                    if (cnt != values.Length - 1)
                        valuesText += $",";
                }

                cmd.CommandText = $"INSERT INTO {tableName} VALUES({valuesText})";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
