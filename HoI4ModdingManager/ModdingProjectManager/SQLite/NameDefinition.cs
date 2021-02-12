using System.Collections.Generic;

namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    static class NameDefinition
    {
        public static string CountryDataTableName = "country_data";
        public static Dictionary<string, string> CountryDataFieldNameList = new Dictionary<string, string>()
        {
            { "Name", "name" },
            { "CountryTag", "country_tag" },
            { "CapitalStateID", "capital_state_id" },
            { "Stability", "stability" },
            { "WarSupport", "war_support" },
            { "PoliticalPower", "political_power" },
            { "ResearchSlots", "research_slots" },
            { "Convoys", "convoys" },
            { "UnitFileID", "unit_file_id" },
            { "Technologies", "technologies" },
            { "Ideas", "ideas" },
            { "RulingPartyIdeology", "ruling_party_ideology" },
            { "LastElectionAt", "last_election_at" },
            { "IsAllowElection", "is_allow_election" },
            { "PartySupports", "party_supports" },
            { "RGBCountryColor", "rgb_country_color" },
            { "GraphicCulture", "graphic_culture" },
            { "CountryNames", "country_names" },
            { "PartyNames", "party_names" },
            { "CountryFlagPaths", "country_flag_paths" }
        };

        public static string IdeologyDataTableName = "ideology_data";
        public static Dictionary<string, string> IdeologyDataFieldNameList = new Dictionary<string, string>()
        {
            { "Name", "name" },
            { "SmallIdeologies", "small_ideologies" },
            { "RGBIdeologyColor", "rgb_ideology_color" },
            { "ID", "id" },
            { "Rule_CanForceGovernment", "rule_can_force_government" },
            { "Rule_CanPuppet", "rule_can_puppet" },
            { "Rule_CanSendVolunteers", "rule_can_send_volunteers" },
            { "Rule_CanLowerTension", "rule_can_lower_tension" },
            { "Rule_CanCreateCollaborationGovernment", "rule_can_create_collaboration_government" },
            { "Rule_CanDeclareWarOnSameIdeology", "rule_can_declare_war_on_same_ideology" },
            { "Rule_CanOnlyJustifyWarOnThreatCountry", "rule_can_only_justify_war_on_threat_country" },
            { "Rule_CanGuaranteeOtherIdeologies", "rule_can_guarantee_other_ideologies" },
            { "Modifier_GenerateWarGoalTension", "modifier_generate_war_goal_tension" },
            { "Modifier_GuaranteeTension", "modifier_guarantee_tension" },
            { "Modifier_CivilianIntelToOthers", "modifier_civilian_intel_to_others" },
            { "Modifier_ArmyIntelToOthers", "modifier_army_intel_to_others" },
            { "Modifier_NavyIntelToOthers", "modifier_navy_intel_to_others" },
            { "Modifier_AirforceIntelToOthers", "modifier_airforce_intel_to_others" },
            { "Modifier_JustifyWarGoalWhenInMajorWarTime", "modifier_justify_war_goal_when_in_major_war_time" },
            { "Modifier_JoinFactionTension", "modifier_join_faction_tension" },
            { "Modifier_LendLeaseTension", "modifier_lend_lease_tension" },
            { "Modifier_AnnexCostFactor", "modifier_annex_cost_factor" },
            { "Modifier_SendVolunteersTension", "modifier_send_volunteers_tension" },
            { "Modifier_TakeStatesCostFactor", "modifier_take_states_cost_factor" },
            { "Modifier_DriftDefenceFactor", "modifier_drift_defence_factor" },
            { "Modifier_PuppetCostFactor", "modifier_puppet_cost_factor" },
            { "CanAiUse", "can_ai_use" },
            { "CanBeBoosted", "can_be_boosted" },
            { "WarImpactOnWorldTension", "war_impact_on_world_tension" },
            { "FactionImpactOnWorldTension", "faction_impact_on_world_tension" },
            { "CanCollaborate", "can_collaborate" },
            { "CanHostGovernmentInExile", "can_host_government_in_exile" }
        };

        public static string ProjectDataTableName = "project_data";
        public static Dictionary<string, string> ProjectDataFieldNameList = new Dictionary<string, string>()
        {
            { "ProjectName", "project_name" },
            { "ModVersion", "mod_version" },
            { "SupportedGameVersion", "supported_game_version" },
            { "Tags", "tags" },
            { "ThumbnailPicturePath", "thumbnail_picture_path" },
            { "ReplacePaths", "replace_paths" },
            { "ModPath", "mod_path" },
            { "UserDir", "user_dir" },
            { "RemoteFileID", "remote_file_id" },
            { "DepondencyMods", "depondency_mods" },
            { "DepondencyDLCs", "depondency_dlcs" }
        };
    }
}
