using HoI4ModdingManager.ModdingProjectManager;
using System;

namespace HoI4ModdingManager.Tests
{
    class ProjectImportTest
    {
        public void ImportProject()
        {
            string filePath = @"(ﾟДﾟ#) ｾﾞｯﾀｲﾊﾟｽｶｸﾅｺﾞﾙｧ"; 

            var exim = new EXIM();
            var data = new DataContainer();

            exim.ImportProject(filePath, data);

            var projectData = data.ProjectDataList;
            var countryData = data.CountryDataList;
            var ideologyData = data.IdeologyDataList;

            Console.WriteLine("----Project Data----");
            Console.WriteLine(projectData[0].project_name);
            Console.WriteLine(projectData[0].created_at);
            Console.WriteLine(projectData[0].updated_at);
            Console.WriteLine(projectData[0].number_of_countries);
            Console.WriteLine(projectData[0].number_of_ideologies);

            Console.WriteLine("----Country Data----");
            
            for (int i = 0; i < countryData.Count; i++)
            {
                Console.WriteLine("★" + countryData[i].country_name);
                Console.WriteLine(countryData[i].id);
                Console.WriteLine(countryData[i].country_tag);
            }

            Console.WriteLine("----Ideology Data----");

            for (int i = 0; i < ideologyData.Count; i++)
            {
                Console.WriteLine("★" + ideologyData[i].ideology_name);
                Console.WriteLine(ideologyData[i].color_r);
                Console.WriteLine(ideologyData[i].color_g);
                Console.WriteLine(ideologyData[i].color_b);
            }
        }
    }
}
