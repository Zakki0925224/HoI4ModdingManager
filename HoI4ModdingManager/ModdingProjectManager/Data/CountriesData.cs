using System;

namespace HoI4ModdingManager.ModdingProjectManager.Data
{
    class CountriesData
    {
        public int? id;
        public DateTime? created_at;
        public DateTime? updated_at;
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
        public int? capital_state_id;
        public int? initial_teach_slot;
        public int? initial_stability;
        public int? initial_war_coop;
        public int? initial_political_power;
        public int? initial_transport;
        public string graphic_culture;
        public string initial_ideology;
        public DateTime? last_election_at;
        public int? election_interval;
        public bool? is_no_election;

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            id = null;
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
            capital_state_id = null;
            initial_teach_slot = null;
            initial_stability = null;
            initial_war_coop = null;
            initial_political_power = null;
            initial_transport = null;
            graphic_culture = null;
            initial_ideology = null;
            last_election_at = null;
            election_interval = null;
            is_no_election = null;
        }
    }
}
