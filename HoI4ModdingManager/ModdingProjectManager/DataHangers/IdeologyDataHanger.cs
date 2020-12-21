namespace HoI4ModdingManager.ModdingProjectManager.Data
{
    class IdeologyDataHanger
    {
        public string ideology_name;
        public string[] small_ideologies;
        public int color_r;
        public int color_g;
        public int color_b;

        // ideology rules
        public bool rule_can_force_government;
        public bool rule_can_puppet;
        public bool rule_can_join_factions;
        public bool rule_can_create_factions;
        public bool rule_can_send_volunteers;
        public bool rule_can_lower_tension;

        // ideology modifier
        public int modifier_generate_wargoal_tension;
        public int modifier_guarantee_tension;
        public int modifier_civilian_intel_to_others;
        public int modifier_army_intel_to_others;
        public int modifier_navy_intel_to_others;
        public int modifier_airforce_intel_to_others;
        public int modifier_justify_war_goal_when_in_major_war_time;
        public int modifier_join_faction_tension;
        public int modifier_lend_lease_tension;
        public int modifier_annex_cost_factor;

        public bool ai_uses_this_ideology;
        public bool can_be_boosted;
        public int war_impact_on_world_tension;
        public bool can_collaborate;
        public bool can_host_government_in_exile;

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            ideology_name = null;
            small_ideologies = null;
            color_r = 0;
            color_g = 0;
            color_b = 0;
            rule_can_force_government = false;
            rule_can_puppet = false;
            rule_can_join_factions = false;
            rule_can_create_factions = false;
            rule_can_send_volunteers = false;
            rule_can_lower_tension = false;
            modifier_generate_wargoal_tension = 0;
            modifier_guarantee_tension = 0;
            modifier_civilian_intel_to_others = 0;
            modifier_army_intel_to_others = 0;
            modifier_navy_intel_to_others = 0;
            modifier_airforce_intel_to_others = 0;
            modifier_justify_war_goal_when_in_major_war_time = 0;
            modifier_join_faction_tension = 0;
            modifier_lend_lease_tension = 0;
            modifier_annex_cost_factor = 0;
            ai_uses_this_ideology = false;
            can_be_boosted = false;
            war_impact_on_world_tension = 0;
            can_collaborate = false;
            can_host_government_in_exile = false;

        }
    }
}
