using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectExporter
{
    class WriteData
    {
        public void WriteDataToDataBase(DataContainer data, string dbFile)
        {
            using (var dbc = new DataBaseConnector())
            {
                dbc.ConnectionDataBase(dbFile);

                WriteCountryData(data.CountryData, dbc.sqlc);
                WriteIdeologyData(data.IdeologyData, dbc.sqlc);
                WriteProjectData(data.ProjectData, dbc.sqlc);
            }
        }

        private void WriteProjectData(ProjectDataHanger projectData, SQLiteConnection sqlc)
        {
            try
            {
                CommandCreator.DeleteAllDataOnTable(sqlc, NameDefinition.ProjectDataTableName);
                CommandCreator.InsertValues(sqlc, projectData.ExportToDataBase(), NameDefinition.ProjectDataTableName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private void WriteIdeologyData(List<IdeologyDataHanger> ideologyData, SQLiteConnection sqlc)
        {
            try
            {
                CommandCreator.DeleteAllDataOnTable(sqlc, NameDefinition.IdeologyDataTableName);

                foreach (IdeologyDataHanger data in ideologyData)
                    CommandCreator.InsertValues(sqlc, data.ExportToDataBase(), NameDefinition.IdeologyDataTableName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private void WriteCountryData(List<CountryDataHanger> countryData, SQLiteConnection sqlc)
        {
            try
            {
                CommandCreator.DeleteAllDataOnTable(sqlc, NameDefinition.CountryDataTableName);

                foreach (CountryDataHanger data in countryData)
                    CommandCreator.InsertValues(sqlc, data.ExportToDataBase(), NameDefinition.CountryDataTableName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
