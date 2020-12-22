using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.ModdingProjectManager.ProjectImporter;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;

namespace HoI4ModdingManager.Tests
{
    class ProjectImportTest
    {
        public void StartProjectImportTest(string filePath)
        {
            var pi = new SQLiteImporter();

            var pdh = new ProjectDataHanger();
            var cdh = new CountryDataHanger();
            var idh = new IdeologyDataHanger();

            pi.ImportProjectData(filePath, "project_data", pdh);
            pi.ImportCountryData(filePath, "countries_data", 0, cdh);
            pi.ImportIdeologyData(filePath, "ideologies_data", 0, idh);
        }
    }
}
