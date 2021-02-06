using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

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
                reader.Read();

                cd.Name = reader.GetString(0);
                cd.CountryTag = reader.GetString(1);
                cd.CapitalStateID = reader.GetInt32(2);
                cd.Stability = reader.GetFloat(3);
                cd.WarSupport = reader.GetFloat(4);
                cd.PoliticalPower = reader.GetInt32(5);
                cd.ResearchSlots = reader.GetInt32(6);
                cd.Convoys = reader.GetInt32(7);
                cd.UnitFileID = reader.GetString(8);
                cd.Technologies = reader.GetString(9).Split(',');
                cd.Ideas = reader.GetString(10).Split(',');
                cd.RulingPartyIdeology = reader.GetString(11);
                cd.LastElectionAt = reader.GetDateTime(12);
                cd.IsAllowElection = GetBool(reader.GetInt32(13));
                cd.PartySupports = reader.GetString(14).Split(',').Select(x => float.Parse(x)).ToArray();
                cd.RGBCountryColor = reader.GetString(15).Split(',').Select(x => int.Parse(x)).ToArray();
                cd.GraphicCulture = reader.GetString(16);
                // 17-19は一旦保留
                cd.CountryNames = reader.GetString(20).Split(',');
                cd.PartyNames = reader.GetString(21).Split(',');
                cd.CountryFlagPaths = reader.GetString(22).Split(',');
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
                reader.Read();

                pd.ProjectName = reader.GetString(0);
                pd.ModVersion = reader.GetString(1);
                pd.SupportedGameVersion = reader.GetString(2);
                pd.Tags = reader.GetString(3).Split(',');
                pd.ThumbnailPicturePath = reader.GetString(4);
                pd.ReplacePaths = reader.GetString(5).Split(',');
                pd.ModPath = reader.GetString(6);
                pd.UserDir = reader.GetString(7);
                pd.RemoteFileID = reader.GetString(8);
                pd.DepondencyMods = reader.GetString(9).Split(',');
                pd.DepondencyDLCs = reader.GetString(10).Split(',');
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
                reader.Read();

                id.Name = reader.GetString(0);
                id.SmallIdeologies = reader.GetString(1).Split(',');
                id.RGBIdeologyColor = reader.GetString(2).Split(',').Select(x => int.Parse(x)).ToArray();
                id.ID = reader.GetInt32(3);
                id.Rule_CanForceGovernment = GetBool(reader.GetInt32(4));
                id.Rule_CanPuppet = GetBool(reader.GetInt32(5));
                id.Rule_CanSendVolunteers = GetBool(reader.GetInt32(6));
                id.Rule_CanLowerTension = GetBool(reader.GetInt32(7));
                id.Rule_CanCreateCollaborationGovernment = GetBool(reader.GetInt32(8));
                id.Rule_CanDeclareWarOnSameIdeology = GetBool(reader.GetInt32(9));
                id.Rule_CanOnlyJustifyWarOnThreatCountry = GetBool(reader.GetInt32(10));
                id.Rule_CanGuaranteeOtherIdeologies = GetBool(reader.GetInt32(10));
                id.Modifier_GenerateWargoalTension = reader.GetFloat(11);
                id.Modifier_GuaranteeTension = reader.GetFloat(12);
                id.Modifier_CivilianIntelToOthers = reader.GetInt32(13);
                id.Modifier_ArmyIntelToOthers = reader.GetInt32(14);
                id.Modifier_NavyIntelToOthers = reader.GetInt32(15);
                id.Modifier_AirforceIntelToOthers = reader.GetInt32(16);
                id.Modifier_JustifyWarGoalWhenInMajorWarTime = reader.GetFloat(17);
                id.Modifier_JoinFactionTension = reader.GetFloat(18);
                id.Modifier_LendLeaseTension = reader.GetFloat(19);
                id.Modifier_AnnexCostFactor = reader.GetFloat(20);
                id.Modifier_SendVolunteersTension = reader.GetFloat(21);
                id.Modifier_TakeStatesCostFactor = reader.GetFloat(22);
                id.Modifier_DriftDefenceFactor = reader.GetFloat(23);
                id.Modifier_PuppetCostFactor = reader.GetFloat(24);
                id.CanAIUse = GetBool(reader.GetInt32(25));
                id.CanBeBoosted = GetBool(reader.GetInt32(26));
                id.WarImpactOnWorldTension = reader.GetFloat(27);
                id.FactionImpactOnWorldTension = reader.GetFloat(28);
                id.CanCollaborate = GetBool(reader.GetInt32(29));
                id.CanHostGovernmentInExile = GetBool(reader.GetInt32(30));

            }
        }

        /// <summary>
        /// bool値を取得(0 -> false それ以外 -> true)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool GetBool(int value)
        {
            if (value == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// データベースから国家データリストを取得し返す
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        public List<CountryDataHanger> GetCountriesData(string dbFile, string tableName)
        {
            var cdList = new List<CountryDataHanger>();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);

                for (int i = 0; i < (int)CommandCreator.GetDataCount(dbc.sqlc, tableName); i++)
                {
                    var cd = new CountryDataHanger();
                    ReadCountryData(tableName, i, cd, dbc.sqlc);
                    cdList.Add(cd);
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
        public ProjectDataHanger GetProjectData(string dbFile, string tableName)
        {
            var pd = new ProjectDataHanger();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);
                ReadProjectData(tableName, pd, dbc.sqlc);
            }

            return pd;
        }

        /// <summary>
        /// データベースからイデオロギーデータリストを取得し返す
        /// </summary>
        /// <param name="dbFile">ファイルパス</param>
        /// <param name="tableName">テーブル名</param>
        public List<IdeologyDataHanger> GetIdeologiesData(string dbFile, string tableName)
        {
            var idList = new List<IdeologyDataHanger>();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile, tableName);

                for (int i = 0; i < (int)CommandCreator.GetDataCount(dbc.sqlc, tableName); i++)
                {
                    var id = new IdeologyDataHanger();
                    ReadIdeologyData(tableName, i, id, dbc.sqlc);
                    idList.Add(id);
                }
            }

            return idList;
        }
    }
}
