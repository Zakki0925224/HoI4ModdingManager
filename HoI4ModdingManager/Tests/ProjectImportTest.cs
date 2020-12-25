using HoI4ModdingManager.ModdingProjectManager;
using System;

namespace HoI4ModdingManager.Tests
{
    class ProjectImportTest
    {
        public void ImportProject()
        {
            string filePath = @"C:\Users\miyaz\Documents\Visual Studio 2019\Projects\C#\HoI4ModdingManager\HoI4ModdingManager\Tests\test-mod.hmp"; 

            var exim = new EXIM();
            var data = new DataContainer();

            exim.ImportProject(filePath, data);

            var projectData = data.ProjectDataList;
            var countryData = data.CountryDataList;
            var ideologyData = data.IdeologyDataList;

            Console.WriteLine(projectData[0].project_name);
            Console.WriteLine(projectData[0].created_at);
            Console.WriteLine(projectData[0].updated_at);
            Console.WriteLine(projectData[0].number_of_countries);
            Console.WriteLine(projectData[0].number_of_ideologies);
        }
    }
}
