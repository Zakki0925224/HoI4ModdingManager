﻿using HoI4ModdingManager.ModdingProjectManager.DataHangers;
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
                //cd.Name = reader.GetString(0);
                //cd.CountryTag = reader.GetString(1);
                //cd.CapitalStateID = reader.GetInt32(2);
                //cd.Stability = reader.GetFloat(3);
                //cd.WarSupport = reader.GetFloat(4);
                //cd.PoliticalPower = reader.GetInt32(5);
                //cd.ResearchSlots = reader.GetInt32(6);
                //cd.Convoys = reader.GetInt32(7);
                //cd.UnitFileID = reader.GetString(8);
                //cd.Technologies = Utils.GetArray(reader.GetString(9));
                //cd.Ideas = Utils.GetArray(reader.GetString(10));
                //cd.RulingPartyIdeology = reader.GetString(11);
                //cd.LastElectionAt = reader.GetDateTime(12);
                //cd.IsAllowElection = Utils.GetBool(reader.GetInt32(13));
                //cd.PartySupports = Utils.GetArray(reader.GetString(14)).Select(x => float.Parse(x)).ToArray();
                //cd.RGBCountryColor = Utils.GetArray(reader.GetString(15)).Select(x => int.Parse(x)).ToArray();
                //cd.GraphicCulture = reader.GetString(16);
                //// 17-19は一旦保留
                //cd.CountryNames = Utils.GetArray(reader.GetString(20));
                //cd.PartyNames = Utils.GetArray(reader.GetString(21));
                //cd.CountryFlagPaths = Utils.GetArray(reader.GetString(22));

                var test = new List<object>();
                foreach (string name in NameDefinition.CountryDataFieldNameList)
                {
                    test.Add(reader[name]);
                }
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

                //pd.ProjectName = reader.GetString(0);
                //pd.ModVersion = reader.GetString(1);
                //pd.SupportedGameVersion = reader.GetString(2);
                //pd.Tags = Utils.GetArray(reader.GetString(3));
                //pd.ThumbnailPicturePath = reader.GetString(4);
                //pd.ReplacePaths = Utils.GetArray(reader.GetString(5));
                //pd.ModPath = reader.GetString(6);
                //pd.UserDir = reader.GetString(7);
                //pd.RemoteFileID = reader.GetString(8);
                //pd.DepondencyMods = Utils.GetArray(reader.GetString(9));
                //pd.DepondencyDLCs = Utils.GetArray(reader.GetString(10));
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

                //id.Name = reader.GetString(0);
                //id.SmallIdeologies = Utils.GetArray(reader.GetString(1));
                //id.RGBIdeologyColor = Utils.GetArray(reader.GetString(2)).Select(x => int.Parse(x)).ToArray();
                //id.ID = reader.GetInt32(3);
                //id.Rule_CanForceGovernment = Utils.GetBool(reader.GetInt32(4));
                //id.Rule_CanPuppet = Utils.GetBool(reader.GetInt32(5));
                //id.Rule_CanSendVolunteers = Utils.GetBool(reader.GetInt32(6));
                //id.Rule_CanLowerTension = Utils.GetBool(reader.GetInt32(7));
                //id.Rule_CanCreateCollaborationGovernment = Utils.GetBool(reader.GetInt32(8));
                //id.Rule_CanDeclareWarOnSameIdeology = Utils.GetBool(reader.GetInt32(9));
                //id.Rule_CanOnlyJustifyWarOnThreatCountry = Utils.GetBool(reader.GetInt32(10));
                //id.Rule_CanGuaranteeOtherIdeologies = Utils.GetBool(reader.GetInt32(10));
                //id.Modifier_GenerateWarGoalTension = reader.GetFloat(11);
                //id.Modifier_GuaranteeTension = reader.GetFloat(12);
                //id.Modifier_CivilianIntelToOthers = reader.GetInt32(13);
                //id.Modifier_ArmyIntelToOthers = reader.GetInt32(14);
                //id.Modifier_NavyIntelToOthers = reader.GetInt32(15);
                //id.Modifier_AirforceIntelToOthers = reader.GetInt32(16);
                //id.Modifier_JustifyWarGoalWhenInMajorWarTime = reader.GetFloat(17);
                //id.Modifier_JoinFactionTension = reader.GetFloat(18);
                //id.Modifier_LendLeaseTension = reader.GetFloat(19);
                //id.Modifier_AnnexCostFactor = reader.GetFloat(20);
                //id.Modifier_SendVolunteersTension = reader.GetFloat(21);
                //id.Modifier_TakeStatesCostFactor = reader.GetFloat(22);
                //id.Modifier_DriftDefenceFactor = reader.GetFloat(23);
                //id.Modifier_PuppetCostFactor = reader.GetFloat(24);
                //id.CanAIUse = Utils.GetBool(reader.GetInt32(25));
                //id.CanBeBoosted = Utils.GetBool(reader.GetInt32(26));
                //id.WarImpactOnWorldTension = reader.GetFloat(27);
                //id.FactionImpactOnWorldTension = reader.GetFloat(28);
                //id.CanCollaborate = Utils.GetBool(reader.GetInt32(29));
                //id.CanHostGovernmentInExile = Utils.GetBool(reader.GetInt32(30));

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

                for (int i = 0; i < (int)CommandCreator.GetDataCount(dbc.sqlc, NameDefinition.CountryDataTableName); i++)
                {
                    var cd = new CountryDataHanger();
                    ReadCountryData(NameDefinition.CountryDataTableName, i, cd, dbc.sqlc);
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
        public ProjectDataHanger GetProjectData(string dbFile)
        {
            var pd = new ProjectDataHanger();

            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);
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

                for (int i = 0; i < (int)CommandCreator.GetDataCount(dbc.sqlc, NameDefinition.IdeologyDataTableName); i++)
                {
                    var id = new IdeologyDataHanger();
                    ReadIdeologyData(NameDefinition.IdeologyDataTableName, i, id, dbc.sqlc);
                    idList.Add(id);
                }
            }

            return idList;
        }
    }
}
