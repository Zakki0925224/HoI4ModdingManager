using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System.Collections.Generic;
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
                var tn = NameDefinition.CountryDataFieldNameList;

                reader.Read();
                cd.ImportFromDataBase((string)reader[tn["Name"]],
                                      (string)reader[tn["CountryTag"]],
                                      (string)reader[tn["CapitalStateID"]],
                                      (string)reader[tn["Stability"]],
                                      (string)reader[tn["WarSupport"]],
                                      (string)reader[tn["PoliticalPower"]],
                                      (string)reader[tn["ResearchSlots"]],
                                      (string)reader[tn["Convoys"]],
                                      (string)reader[tn["UnitFileID"]],
                                      (string)reader[tn["Technologies"]],
                                      (string)reader[tn["Ideas"]],
                                      (string)reader[tn["RulingPartyIdeology"]],
                                      (string)reader[tn["LastElectionAt"]],
                                      (string)reader[tn["IsAllowElection"]],
                                      (string)reader[tn["PartySupports"]],
                                      (string)reader[tn["RGBCountryColor"]],
                                      (string)reader[tn["GraphicCulture"]],
                                      (string)reader[tn["CountryNames"]],
                                      (string)reader[tn["PartyNames"]],
                                      (string)reader[tn["CountryFlagPaths"]]);
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
                var tn = NameDefinition.ProjectDataFieldNameList;

                reader.Read();
                pd.ImportFromDataBase((string)reader[tn["ProjectName"]],
                                      (string)reader[tn["ModVersion"]],
                                      (string)reader[tn["SupportedGameVersion"]],
                                      (string)reader[tn["Tags"]],
                                      (string)reader[tn["ThumbnailPicturePath"]],
                                      (string)reader[tn["ReplacePaths"]],
                                      (string)reader[tn["ModPath"]],
                                      (string)reader[tn["UserDir"]],
                                      (string)reader[tn["RemoteFileID"]],
                                      (string)reader[tn["DepondencyMods"]],
                                      (string)reader[tn["DepondencyDLCs"]]);
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
                var tn = NameDefinition.IdeologyDataFieldNameList;

                reader.Read();
                id.ImportFromDataBase((string)reader[tn["Name"]],
                                      (string)reader[tn["SmallIdeologies"]],
                                      (string)reader[tn["RGBIdeologyColor"]],
                                      (string)reader[tn["ID"]],
                                      (string)reader[tn["Rule_CanForceGovernment"]],
                                      (string)reader[tn["Rule_CanPuppet"]],
                                      (string)reader[tn["Rule_CanSendVolunteers"]],
                                      (string)reader[tn["Rule_CanLowerTension"]],
                                      (string)reader[tn["Rule_CanCreateCollaborationGovernment"]],
                                      (string)reader[tn["Rule_CanDeclareWarOnSameIdeology"]],
                                      (string)reader[tn["Rule_CanOnlyJustifyWarOnThreatCountry"]],
                                      (string)reader[tn["Rule_CanGuaranteeOtherIdeologies"]],
                                      (string)reader[tn["Modifier_GenerateWarGoalTension"]],
                                      (string)reader[tn["Modifier_GuaranteeTension"]],
                                      (string)reader[tn["Modifier_CivilianIntelToOthers"]],
                                      (string)reader[tn["Modifier_ArmyIntelToOthers"]],
                                      (string)reader[tn["Modifier_NavyIntelToOthers"]],
                                      (string)reader[tn["Modifier_AirforceIntelToOthers"]],
                                      (string)reader[tn["Modifier_JustifyWarGoalWhenInMajorWarTime"]],
                                      (string)reader[tn["Modifier_JoinFactionTension"]],
                                      (string)reader[tn["Modifier_LendLeaseTension"]],
                                      (string)reader[tn["Modifier_AnnexCostFactor"]],
                                      (string)reader[tn["Modifier_SendVolunteersTension"]],
                                      (string)reader[tn["Modifier_TakeStatesCostFactor"]],
                                      (string)reader[tn["Modifier_DriftDefenceFactor"]],
                                      (string)reader[tn["Modifier_PuppetCostFactor"]],
                                      (string)reader[tn["CanAiUse"]],
                                      (string)reader[tn["CanBeBoosted"]],
                                      (string)reader[tn["WarImpactOnWorldTension"]],
                                      (string)reader[tn["FactionImpactOnWorldTension"]],
                                      (string)reader[tn["CanCollaborate"]],
                                      (string)reader[tn["CanHostGovernmentInExile"]]);
            }
        }

        /// <summary>
        /// データベースから国家データリストを取得し返す
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        public List<CountryDataHanger> GetCountriesData(string dbFile)
        {
            var cdList = new List<CountryDataHanger>();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);
                CommandCreator.CreateCountryDataTable(dbc.sqlc);

                int dataCnt = (int)CommandCreator.GetDataCount(dbc.sqlc, NameDefinition.CountryDataTableName);

                if (dataCnt == 0)
                {
                    // 空データをインサート
                    cdList.Add(new CountryDataHanger());
                }
                else
                {
                    for (int i = 0; i < dataCnt; i++)
                    {
                        var cd = new CountryDataHanger();
                        ReadCountryData(NameDefinition.CountryDataTableName, i, cd, dbc.sqlc);
                        cdList.Add(cd);
                    }
                }
            }

            return cdList;
        }

        /// <summary>
        /// データベースからプロジェクトデータを取得し返す
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        /// <param name="pd">クラスインスタンス</param>
        public ProjectDataHanger GetProjectData(string dbFile)
        {
            var pd = new ProjectDataHanger();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);
                CommandCreator.CreateProjectDataTable(dbc.sqlc);

                int dataCnt = (int)CommandCreator.GetDataCount(dbc.sqlc, NameDefinition.ProjectDataTableName);

                if (dataCnt != 0)
                    ReadProjectData(NameDefinition.ProjectDataTableName, pd, dbc.sqlc);
            }

            return pd;
        }

        /// <summary>
        /// データベースからイデオロギーデータリストを取得し返す
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        public List<IdeologyDataHanger> GetIdeologiesData(string dbFile)
        {
            var idList = new List<IdeologyDataHanger>();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);
                CommandCreator.CreateIdeologyDataTable(dbc.sqlc);

                int dataCnt = (int)CommandCreator.GetDataCount(dbc.sqlc, NameDefinition.IdeologyDataTableName);

                if (dataCnt == 0)
                {
                    // 空データをインサート
                    idList.Add(new IdeologyDataHanger());
                }
                else
                {
                    for (int i = 0; i < dataCnt; i++)
                    {
                        var id = new IdeologyDataHanger();
                        ReadIdeologyData(NameDefinition.IdeologyDataTableName, i, id, dbc.sqlc);
                        idList.Add(id);
                    }
                }
            }

            return idList;
        }
    }
}
