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
            Console.WriteLine(data.ProjectDataList[0].project_name);
            Console.WriteLine(data.ProjectDataList[0].created_at);
            Console.WriteLine(data.ProjectDataList[0].updated_at);
            Console.WriteLine(data.ProjectDataList[0].number_of_countries);
            Console.WriteLine(data.ProjectDataList[0].number_of_ideologies);

            Console.WriteLine("----Country Data----");
            
            for (int i = 0; i < data.CountryDataList.Count; i++)
            {
                Console.WriteLine("★" + data.CountryDataList[i].country_name);
                Console.WriteLine(data.CountryDataList[i].id);
                Console.WriteLine(data.CountryDataList[i].country_tag);
            }

            Console.WriteLine("----Ideology Data----");

            for (int i = 0; i < data.IdeologyDataList.Count; i++)
            {
                Console.WriteLine("★" + data.IdeologyDataList[i].ideology_name);
                Console.WriteLine(data.IdeologyDataList[i].color_r);
                Console.WriteLine(data.IdeologyDataList[i].color_g);
                Console.WriteLine(data.IdeologyDataList[i].color_b);
            }
        }
    }
}
