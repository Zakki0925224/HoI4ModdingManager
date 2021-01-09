namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    class IdeologyDataHanger
    {
        public string Ideology_name { get; set; }
        public string[] Small_ideologies { get; set; }
        public int Color_r { get; set; }
        public int Color_g { get; set; }
        public int Color_b { get; set; }

        // ideology rules
        public bool Rule_can_force_government { get; set; }
        public bool Rule_can_puppet { get; set; }
        public bool Rule_can_join_factions { get; set; }
        public bool Rule_can_create_factions { get; set; }
        public bool Rule_can_send_volunteers { get; set; }
        public bool Rule_can_lower_tension { get; set; }

        // ideology modifier
        public int Modifier_generate_wargoal_tension { get; set; }
        public int Modifier_guarantee_tension { get; set; }
        public int Modifier_civilian_intel_to_others { get; set; }
        public int Modifier_army_intel_to_others { get; set; }
        public int Modifier_navy_intel_to_others { get; set; }
        public int Modifier_airforce_intel_to_others { get; set; }
        public int Modifier_justify_war_goal_when_in_major_war_time { get; set; }
        public int Modifier_join_faction_tension { get; set; }
        public int Modifier_lend_lease_tension { get; set; }
        public int Modifier_annex_cost_factor { get; set; }

        public bool Ai_uses_this_ideology { get; set; }
        public bool Can_be_boosted { get; set; }
        public int War_impact_on_world_tension { get; set; }
        public bool Can_collaborate { get; set; }
        public bool Can_host_government_in_exile { get; set; }

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            Ideology_name = "";
            Small_ideologies = new string[] { };
            Color_r = 0;
            Color_g = 0;
            Color_b = 0;
            Rule_can_force_government = false;
            Rule_can_puppet = false;
            Rule_can_join_factions = false;
            Rule_can_create_factions = false;
            Rule_can_send_volunteers = false;
            Rule_can_lower_tension = false;
            Modifier_generate_wargoal_tension = 0;
            Modifier_guarantee_tension = 0;
            Modifier_civilian_intel_to_others = 0;
            Modifier_army_intel_to_others = 0;
            Modifier_navy_intel_to_others = 0;
            Modifier_airforce_intel_to_others = 0;
            Modifier_justify_war_goal_when_in_major_war_time = 0;
            Modifier_join_faction_tension = 0;
            Modifier_lend_lease_tension = 0;
            Modifier_annex_cost_factor = 0;
            Ai_uses_this_ideology = false;
            Can_be_boosted = false;
            War_impact_on_world_tension = 0;
            Can_collaborate = false;
            Can_host_government_in_exile = false;

        }
    }
}
