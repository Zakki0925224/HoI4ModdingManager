using System;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    class CountryDataHanger
    {
        public int Id { get; set; }
        public string Country_tag { get; set; }
        public string Country_name { get; set; }
        public string Country_name_neutrality { get; set; }
        public string Country_name_neutrality_def { get; set; }
        public string Country_name_neutrality_adj { get; set; }
        public string Country_name_democratic { get; set; }
        public string Country_name_democratic_def { get; set; }
        public string Country_name_democratic_adj { get; set; }
        public string Country_name_fascism { get; set; }
        public string Country_name_fascism_def { get; set; }
        public string Country_name_fascism_adj { get; set; }
        public string Country_name_communism { get; set; }
        public string Country_name_communism_def { get; set; }
        public string Country_name_communism_adj { get; set; }
        public string Party_name_neutrality { get; set; }
        public string Party_name_neutrality_long { get; set; }
        public string Party_name_democratic { get; set; }
        public string Party_name_democratic_long { get; set; }
        public string Party_name_fascism { get; set; }
        public string Party_name_fascism_long { get; set; }
        public string Party_name_communism { get; set; }
        public string Party_name_communism_long { get; set; }
        public int Capital_state_id { get; set; }
        public int Initial_teach_slot { get; set; }
        public int Initial_stability { get; set; }
        public int Initial_war_coop { get; set; }
        public int Initial_political_power { get; set; }
        public int Initial_transport { get; set; }
        public string Graphic_culture { get; set; }
        public string Initial_ideology { get; set; }
        public DateTime Last_election_at { get; set; }
        public int Election_interval { get; set; }
        public bool Is_no_election { get; set; }
        public int Color_r { get; set; }
        public int Color_g { get; set; }
        public int Color_b { get; set; }
        public string Country_flag_path_neutrality { get; set; }
        public string Country_flag_path_neutrality_medium { get; set; }
        public string Country_flag_path_neutrality_small { get; set; }
        public string Country_flag_path_democratic { get; set; }
        public string Country_flag_path_democratic_medium { get; set; }
        public string Country_flag_path_democratic_small { get; set; }
        public string Country_flag_path_fascism { get; set; }
        public string Country_flag_path_fascism_medium { get; set; }
        public string Country_flag_path_fascism_small { get; set; }
        public string Country_flag_path_communism { get; set; }
        public string Country_flag_path_communism_medium { get; set; }
        public string Country_flag_path_communism_small { get; set; }
        public int Party_support_neutrality { get; set; }
        public int Party_support_democratic { get; set; }
        public int Party_support_fascism { get; set; }
        public int Party_support_communism { get; set; }

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            Id = 0;
            Country_tag = "";
            Country_name = "";
            Country_name_neutrality = "";
            Country_name_neutrality_def = "";
            Country_name_neutrality_adj = "";
            Country_name_democratic = "";
            Country_name_democratic_def = "";
            Country_name_democratic_adj = "";
            Country_name_fascism = "";
            Country_name_fascism_def = "";
            Country_name_fascism_adj = "";
            Country_name_communism = "";
            Country_name_communism_def = "";
            Country_name_communism_adj = "";
            Party_name_neutrality = "";
            Party_name_neutrality_long = "";
            Party_name_democratic = "";
            Party_name_democratic_long = "";
            Party_name_fascism = "";
            Party_name_fascism_long = "";
            Party_name_communism = "";
            Party_name_communism_long = "";
            Capital_state_id = 0;
            Initial_teach_slot = 0;
            Initial_stability = 0;
            Initial_war_coop = 0;
            Initial_political_power = 0;
            Initial_transport = 0;
            Graphic_culture = "";
            Initial_ideology = "";
            Last_election_at = DateTime.MinValue;
            Election_interval = 0;
            Is_no_election = false;
            Color_r = 0;
            Color_g = 0;
            Color_b = 0;
            Country_flag_path_neutrality = "";
            Country_flag_path_neutrality_medium = "";
            Country_flag_path_neutrality_small = "";
            Country_flag_path_democratic = "";
            Country_flag_path_democratic_medium = "";
            Country_flag_path_democratic_small = "";
            Country_flag_path_fascism = "";
            Country_flag_path_fascism_medium = "";
            Country_flag_path_fascism_small = "";
            Country_flag_path_communism = "";
            Country_flag_path_communism_medium = "";
            Country_flag_path_communism_small = "";
            Party_support_neutrality = 0;
            Party_support_democratic = 0;
            Party_support_fascism = 0;
            Party_support_communism = 0;
        }
    }
}
