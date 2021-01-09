using HoI4ModdingManager.ModdingProjectManager;
using System;

namespace HoI4ModdingManager.Tests
{
    class ProjectImportTest
    {
        public static void ImportProject(string filePath)
        {

            var exim = new EXIM();
            var data = new DataContainer();

            exim.ImportProject(filePath, data);

            Console.WriteLine("----Project Data----");
            Console.WriteLine(data.ProjectData[0].project_name);
            Console.WriteLine(data.ProjectData[0].created_at);
            Console.WriteLine(data.ProjectData[0].updated_at);
            Console.WriteLine(data.ProjectData[0].number_of_countries);
            Console.WriteLine(data.ProjectData[0].number_of_ideologies);

            Console.WriteLine("----Country Data----");
            
            for (int i = 0; i < data.CountryData.Count; i++)
            {
                Console.WriteLine("★" + data.CountryData[i].country_name);
                Console.WriteLine(data.CountryData[i].id);
                Console.WriteLine(data.CountryData[i].country_tag);
            }

            Console.WriteLine("----Ideology Data----");

            for (int i = 0; i < data.IdeologyData.Count; i++)
            {
                Console.WriteLine("★" + data.IdeologyData[i].ideology_name);
                Console.WriteLine(data.IdeologyData[i].color_r);
                Console.WriteLine(data.IdeologyData[i].color_g);
                Console.WriteLine(data.IdeologyData[i].color_b);
            }
        }
    }
}
