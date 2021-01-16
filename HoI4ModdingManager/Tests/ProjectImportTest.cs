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
            Console.WriteLine(data.ProjectData.Project_name);
            Console.WriteLine(data.ProjectData.Created_at);
            Console.WriteLine(data.ProjectData.Updated_at);
            Console.WriteLine(data.ProjectData.Number_of_countries);
            Console.WriteLine(data.ProjectData.Number_of_ideologies);

            Console.WriteLine("----Country Data----");
            
            for (int i = 0; i < data.CountryData.Count; i++)
            {
                Console.WriteLine("★" + data.CountryData[i].Country_name);
                Console.WriteLine(data.CountryData[i].Id);
                Console.WriteLine(data.CountryData[i].Country_tag);
            }

            Console.WriteLine("----Ideology Data----");

            for (int i = 0; i < data.IdeologyData.Count; i++)
            {
                Console.WriteLine("★" + data.IdeologyData[i].Ideology_name);
                Console.WriteLine(data.IdeologyData[i].Color_r);
                Console.WriteLine(data.IdeologyData[i].Color_g);
                Console.WriteLine(data.IdeologyData[i].Color_b);
            }
        }
    }
}
