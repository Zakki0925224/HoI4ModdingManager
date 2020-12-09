using System;

namespace HoI4ModdingManager.ModdingProjectManager.Data
{
    class CountriesData
    {
        public int id;
        public string created_at;
        public string updated_at;
        public string country_tag;
        public string country_name;
        public string country_name_neutrality;
        public string country_name_neutrality_def;
        public string country_name_neutrality_adj;
        public string country_name_democratic;
        public string country_name_democratic_def;
        public string country_name_democratic_adj;
        public string country_name_fascism;
        public string country_name_fascism_def;
        public string country_name_fascism_adj;
        public string country_name_communism;
        public string country_name_communism_def;
        public string country_name_communism_adj;
        public string party_name_neutrality;
        public string party_name_neutrality_long;
        public string party_name_democratic;
        public string party_name_democratic_long;
        public string party_name_fascism;
        public string party_name_fascism_long;
        public string party_name_communism;
        public string party_name_communism_long;
        public int capital_state_id;
        public int initial_teach_slot;
        public int initial_stability;
        public int initial_war_coop;
        public int initial_political_power;
        public int initial_transport;
        public string graphic_culture;
        public string initial_ideology;
        public string last_election_at;
        public int election_interval;
        public bool is_no_election;

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            id = 0;
            created_at = null;
            updated_at = null;
            country_tag = null;
            country_name = null;
            country_name_neutrality = null;
            country_name_neutrality_def = null;
            country_name_neutrality_adj = null;
            country_name_democratic = null;
            country_name_democratic_def = null;
            country_name_democratic_adj = null;
            country_name_fascism = null;
            country_name_fascism_def = null;
            country_name_fascism_adj = null;
            country_name_communism = null;
            country_name_communism_def = null;
            country_name_communism_adj = null;
            party_name_neutrality = null;
            party_name_neutrality_long = null;
            party_name_democratic = null;
            party_name_democratic_long = null;
            party_name_fascism = null;
            party_name_fascism_long = null;
            party_name_communism = null;
            party_name_communism_long = null;
            capital_state_id = 0;
            initial_teach_slot = 0;
            initial_stability = 0;
            initial_war_coop = 0;
            initial_political_power = 0;
            initial_transport = 0;
            graphic_culture = null;
            initial_ideology = null;
            last_election_at = null;
            election_interval = 0;
            is_no_election = false;
        }
    }
}
