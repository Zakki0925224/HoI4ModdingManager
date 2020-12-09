using HoI4ModdingManager.ModdingProjectManager.Data;
using HoI4ModdingManager.ModdingProjectManager.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoI4ModdingManager.Test
{
    class Tests
    {
        public void StartTest()
        {
            ProjectImporter pi = new ProjectImporter();

            // 1国家1インスタンスとして保持
            CountriesData cd = new CountriesData();

            pi.GetCountriesData(@"C:\Users\miyaz\Documents\Visual Studio 2019\Projects\C#\HoI4ModdingManager\HoI4ModdingManager\ModdingProjectManager\Data\ExampleDataBase\countries_data.db",
                                "countries_data",
                                0,
                                cd);

            Console.WriteLine(cd.id);
            Console.WriteLine(cd.created_at);
            Console.WriteLine(cd.updated_at);
            Console.WriteLine(cd.country_tag);
            Console.WriteLine(cd.country_name);
            Console.WriteLine(cd.country_name_neutrality);
            Console.WriteLine(cd.country_name_democratic);
            Console.WriteLine(cd.country_name_fascism);
            Console.WriteLine(cd.country_name_communism);
            Console.WriteLine(cd.party_name_neutrality);
            Console.WriteLine(cd.party_name_democratic);
            Console.WriteLine(cd.party_name_communism);
            Console.WriteLine(cd.party_name_fascism);
            Console.WriteLine(cd.capital_state_id);
            Console.WriteLine(cd.initial_teach_slot);
            Console.WriteLine(cd.initial_stability);
            Console.WriteLine(cd.initial_war_coop);
            Console.WriteLine(cd.initial_political_power);
            Console.WriteLine(cd.initial_transport);
            Console.WriteLine(cd.graphic_culture);
            Console.WriteLine(cd.initial_ideology);
            Console.WriteLine(cd.last_election_at);
            Console.WriteLine(cd.election_interval);
            Console.WriteLine(cd.is_no_election);
        }
    }
}
