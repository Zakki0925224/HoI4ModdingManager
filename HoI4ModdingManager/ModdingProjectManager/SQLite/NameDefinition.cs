namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    static class NameDefinition
    {
        public static string CountryDataTableName = "country_data";
        public static string[] CountryDataFieldNameList =
        {
            "name",
            "country_tag",
            "capital_state_id",
            "stability",
            "war_support",
            "political_power",
            "research_slots",
            "convoys",
            "unit_file_id",
            "technologies",
            "ideas",
            "ruling_party_ideology",
            "last_election_at",
            "is_allow_election",
            "party_supports",
            "rgb_country_color",
            "graphic_culture",
            "country_names",
            "party_names",
            "country_flag_paths"
        };

        public static string IdeologyDataTableName = "ideology_data";
        public static string[] IdeologyDataFieldNameList =
        {
            "name",
            "small_ideologies",
            "rgb_ideology_color",
            "id",
            "rule_can_force_government",
            "rule_can_puppet",
            "rule_can_send_volunteers",
            "rule_can_lower_tension",
            "rule_can_create_collaboration_government",
            "rule_can_declare_war_on_same_ideology",
            "rule_can_only_justify_war_on_threat_country",
            "rule_can_guarantee_other_ideologies",
            "modifier_generate_war_goal_tension",
            "modifier_guarantee_tension",
            "modifier_civilian_intel_to_others",
            "modifier_army_intel_to_others",
            "modifier_navy_intel_to_others",
            "modifier_airforce_intel_to_others",
            "modifier_justify_war_goal_when_in_major_war_time",
            "modifier_join_faction_tension",
            "modifier_lend_lease_tension",
            "modifier_annex_cost_factor",
            "modifier_send_volunteers_tension",
            "modifier_take_states_cost_factor",
            "modifier_drift_defence_factor",
            "modifier_puppet_cost_factor",
            "can_ai_use",
            "can_be_boosted",
            "war_impact_on_world_tension",
            "faction_impact_on_world_tension",
            "can_collaborate",
            "can_host_government_in_exile"
        };

        public static string ProjectDataTableName = "project_data";
        public static string[] ProjectDataFieldNameList =
        {
            "project_name",
            "mod_version",
            "supported_game_version",
            "tags",
            "thumbnail_picture_path",
            "replace_paths",
            "mod_path",
            "user_dir",
            "remote_file_id",
            "depondency_mods",
            "depondency_dlcs",
        };
    }
}
