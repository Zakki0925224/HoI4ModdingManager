using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectExporter
{
    class WriteData
    {
        private void WriteCountryData(List<CountryDataHanger> data, SQLiteConnection sqlc, string tableName)
        {
            // 一度テーブル上のデータを全て削除
            CommandCreator.DeleteAllDataOnTable(sqlc, tableName);

            using (var content = new DataContext(sqlc))
            {
                var table = content.GetTable<CountryDataTable>();

                foreach (CountryDataHanger cdh in data)
                {
                    table.InsertOnSubmit(new CountryDataTable(cdh.Name,
                                                              cdh.CountryTag,
                                                              cdh.CapitalStateID,
                                                              cdh.Stability,
                                                              cdh.WarSupport,
                                                              cdh.PoliticalPower,
                                                              cdh.ResearchSlots,
                                                              cdh.Convoys,
                                                              cdh.UnitFileID,
                                                              cdh.Technologies,
                                                              cdh.Ideas,
                                                              cdh.RulingPartyIdeology,
                                                              cdh.LastElectionAt,
                                                              cdh.IsAllowElection,
                                                              cdh.PartySupports,
                                                              cdh.RGBCountryColor,
                                                              cdh.GraphicCulture,
                                                              cdh.CountryNames,
                                                              cdh.PartyNames,
                                                              cdh.CountryFlagPaths));
                }

                content.SubmitChanges();
            }
        }

        private void WriteIdeologyData(List<IdeologyDataHanger> data, SQLiteConnection sqlc, string tableName)
        {
            // 一度テーブル上のデータを全て削除
            CommandCreator.DeleteAllDataOnTable(sqlc, tableName);

            using (var content = new DataContext(sqlc))
            {
                var table = content.GetTable<IdeologyDataTable>();

                foreach (IdeologyDataHanger idh in data)
                {
                    table.InsertOnSubmit(new IdeologyDataTable(idh.Name,
                                                               idh.SmallIdeologies,
                                                               idh.RGBIdeologyColor,
                                                               idh.ID,
                                                               idh.Rule_CanForceGovernment,
                                                               idh.Rule_CanPuppet,
                                                               idh.Rule_CanSendVolunteers,
                                                               idh.Rule_CanOnlyJustifyWarOnThreatCountry,
                                                               idh.Rule_CanGuaranteeOtherIdeologies,
                                                               idh.Rule_CanDeclareWarOnSameIdeology,
                                                               idh.Rule_CanOnlyJustifyWarOnThreatCountry,
                                                               idh.Rule_CanGuaranteeOtherIdeologies,
                                                               idh.Modifier_GenerateWarGoalTension,
                                                               idh.Modifier_GuaranteeTension,
                                                               idh.Modifier_CivilianIntelToOthers,
                                                               idh.Modifier_ArmyIntelToOthers,
                                                               idh.Modifier_NavyIntelToOthers,
                                                               idh.Modifier_AirforceIntelToOthers,
                                                               idh.Modifier_JustifyWarGoalWhenInMajorWarTime,
                                                               idh.Modifier_JoinFactionTension,
                                                               idh.Modifier_LendLeaseTension,
                                                               idh.Modifier_AnnexCostFactor,
                                                               idh.Modifier_SendVolunteersTension,
                                                               idh.Modifier_TakeStatesCostFactor,
                                                               idh.Modifier_DriftDefenceFactor,
                                                               idh.Modifier_PuppetCostFactor,
                                                               idh.CanAIUse,
                                                               idh.CanBeBoosted,
                                                               idh.WarImpactOnWorldTension,
                                                               idh.FactionImpactOnWorldTension,
                                                               idh.CanCollaborate,
                                                               idh.CanHostGovernmentInExile));
                }

                content.SubmitChanges();
            }
        }

        private void WriteProjectData(ProjectDataHanger data, SQLiteConnection sqlc, string tableName)
        {
            // 一度テーブル上のデータを全て削除
            CommandCreator.DeleteAllDataOnTable(sqlc, tableName);

            using (var content = new DataContext(sqlc))
            {
                var table = content.GetTable<ProjectDataTable>();

                table.InsertOnSubmit(new ProjectDataTable(data.ProjectName,
                                                          data.ModVersion,
                                                          data.SupportedGameVersion,
                                                          data.Tags,
                                                          data.ThumbnailPicturePath,
                                                          data.ReplacePaths,
                                                          data.ModPath,
                                                          data.UserDir,
                                                          data.RemoteFileID,
                                                          data.DepondencyMods,
                                                          data.DepondencyDLCs));

                content.SubmitChanges();
            }
        }

        public void WriteDataToDataBase(DataContainer data, string dbFile, string projectDataTableName, string countryDataTableName, string ideologyDataTableName)
        {
            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);

                // テーブルが存在しなければ作成する
                CommandCreator.CreateCountryDataTable(dbc.sqlc, countryDataTableName);
                CommandCreator.CreateIdeologyDataTable(dbc.sqlc, ideologyDataTableName);
                CommandCreator.CreateProjectDataTable(dbc.sqlc, projectDataTableName);

                WriteCountryData(data.CountryData, dbc.sqlc, countryDataTableName);
                WriteIdeologyData(data.IdeologyData, dbc.sqlc, ideologyDataTableName);
                WriteProjectData(data.ProjectData, dbc.sqlc, projectDataTableName);
            }
        }
    }
}
