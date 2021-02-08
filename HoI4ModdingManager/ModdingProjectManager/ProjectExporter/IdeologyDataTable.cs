using HoI4ModdingManager.ModdingProjectManager.SQLite;
using System.Data.Linq.Mapping;
using System.Linq;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectExporter
{
    [Table(Name = "ideology_data")]
    class IdeologyDataTable
    {
        [Column(Name = "name", DbType = "TEXT")]
        public string Name { get; set; }

        [Column(Name = "small_ideologies", DbType = "TEXT")]
        public string SmallIdeologies { get; set; }

        [Column(Name = "rgb_ideology_color", DbType = "TEXT")]
        public string RGBIdeologyColor { get; set; }

        [Column(Name = "id", DbType = "INTEGER")]
        public int ID { get; set; }

        [Column(Name = "rule_can_force_government", DbType = "INTEGER")]
        public int Rule_CanForceGovernment { get; set; }

        [Column(Name = "rule_can_puppet", DbType = "INTEGER")]
        public int Rule_CanPuppet { get; set; }

        [Column(Name = "rule_can_send_volunteers", DbType = "INTEGER")]
        public int Rule_CanSendVolunteers { get; set; }

        [Column(Name = "rule_can_lower_tension", DbType = "INTEGER")]
        public int Rule_CanLowerTension { get; set; }

        [Column(Name = "rule_can_create_collaboration_government", DbType = "INTEGER")]
        public int Rule_CanCreateCollaborationGovernment { get; set; }

        [Column(Name = "rule_can_declare_war_on_same_ideology", DbType = "INTEGER")]
        public int Rule_CanDeclareWarOnSameIdeology { get; set; }

        [Column(Name = "rule_can_only_justify_war_on_threat_country", DbType = "INTEGER")]
        public int Rule_CanOnlyJustifyWarOnThreatCountry { get; set; }

        [Column(Name = "rule_can_guarantee_other_ideologies", DbType = "INTEGER")]
        public int Rule_CanGuaranteeOtherIdeologies { get; set; }

        [Column(Name = "modifier_generate_war_goal_tension", DbType = "REAL")]
        public float Modifier_GenerateWarGoalTension { get; set; }

        [Column(Name = "modifier_guarantee_tension", DbType = "REAL")]
        public float Modifier_GuaranteeTension { get; set; }

        [Column(Name = "modifier_civilian_intel_to_others", DbType = "INTEGER")]
        public int Modifier_CivilianIntelToOthers { get; set; }

        [Column(Name = "modifier_army_intel_to_others", DbType = "INTEGER")]
        public int Modifier_ArmyIntelToOthers { get; set; }

        [Column(Name = "modifier_navy_intel_to_others", DbType = "INTEGER")]
        public int Modifier_NavyIntelToOthers { get; set; }

        [Column(Name = "modifier_airforce_intel_to_others", DbType = "INTEGER")]
        public int Modifier_AirforceIntelToOthers { get; set; }

        [Column(Name = "modifier_justify_war_goal_when_in_major_war_time", DbType = "REAL")]
        public float Modifier_JustifyWarGoalWhenInMajorWarTime { get; set; }

        [Column(Name = "modifier_join_faction_tension", DbType = "REAL")]
        public float Modifier_JoinFactionTension { get; set; }

        [Column(Name = "modifier_lend_lease_tension", DbType = "REAL")]
        public float Modifier_LendLeaseTension { get; set; }

        [Column(Name = "modifier_annex_cost_factor", DbType = "REAL")]
        public float Modifier_AnnexCostFactor { get; set; }

        [Column(Name = "modifier_send_volunteers_tension", DbType = "REAL")]
        public float Modifier_SendVolunteersTension { get; set; }

        [Column(Name = "modifier_take_states_cost_factor", DbType = "REAL")]
        public float Modifier_TakeStatesCostFactor { get; set; }

        [Column(Name = "modifier_drift_defence_factor", DbType = "REAL")]
        public float Modifier_DriftDefenceFactor { get; set; }

        [Column(Name = "modifier_puppet_cost_factor", DbType = "REAL")]
        public float Modifier_PuppetCostFactor { get; set; }

        [Column(Name = "can_ai_use", DbType = "INTEGER")]
        public int CanAIUse { get; set; }

        [Column(Name = "can_be_boosted", DbType = "INTEGER")]
        public int CanBeBoosted { get; set; }

        [Column(Name = "war_impact_on_world_tension", DbType = "REAL")]
        public float WarImpactOnWorldTension { get; set; }

        [Column(Name = "faction_impact_on_world_tension", DbType = "REAL")]
        public float FactionImpactOnWorldTension { get; set; }

        [Column(Name = "can_collaborate", DbType = "INTEGER")]
        public int CanCollaborate { get; set; }

        [Column(Name = "can_host_government_in_exile", DbType = "INTEGER")]
        public int CanHostGovernmentInExile { get; set; }

        public IdeologyDataTable(string name,
                                 string[] smallIdeologies,
                                 int[] rgbIdeologyColor,
                                 int id,
                                 bool rule_CanForceGovernment,
                                 bool rule_CanPuppet,
                                 bool rule_CanSendVolunteers,
                                 bool rule_CanLowerTension,
                                 bool rule_CanCreateCollaborationGovernment,
                                 bool rule_CanDeclareWarOnSameIdeology,
                                 bool rule_CanOnlyJustifyWarOnThreatCountry,
                                 bool rule_CanGuaranteeOtherIdeologies,
                                 float modifier_GenerateWarGoalTension,
                                 float modifier_GuaranteeTension,
                                 int modifier_CivilianIntelToOthers,
                                 int modifier_ArmyIntelToOthers,
                                 int modifier_NavyIntelToOthers,
                                 int modifier_AirforceIntelToOthers,
                                 float modifier_JustifyWarGoalWhenInMajorWarTime,
                                 float modifier_JoinFactionTension,
                                 float modifier_LendLeaseTension,
                                 float modifier_AnnexCostFactor,
                                 float modifier_SendVolunteersTension,
                                 float modifier_TakeStatesCostFactor,
                                 float modifier_DriftDefenceFactor,
                                 float modifier_PuppetCostFactor,
                                 bool canAIUse,
                                 bool canBeBoosted,
                                 float warImpactOnWorldTension,
                                 float factionImpactOnWorldTension,
                                 bool canCollaborate,
                                 bool canHostGovernmentInExile)
        {
            this.Name = name;
            this.SmallIdeologies = string.Join(",", smallIdeologies);
            this.RGBIdeologyColor = string.Join(",", rgbIdeologyColor.Select(x => x.ToString()));
            this.ID = id;
            this.Rule_CanForceGovernment = Utils.ConvertInt(rule_CanForceGovernment);
            this.Rule_CanPuppet = Utils.ConvertInt(rule_CanPuppet);
            this.Rule_CanSendVolunteers = Utils.ConvertInt(rule_CanSendVolunteers);
            this.Rule_CanLowerTension = Utils.ConvertInt(rule_CanLowerTension);
            this.Rule_CanCreateCollaborationGovernment = Utils.ConvertInt(rule_CanCreateCollaborationGovernment);
            this.Rule_CanDeclareWarOnSameIdeology = Utils.ConvertInt(rule_CanDeclareWarOnSameIdeology);
            this.Rule_CanOnlyJustifyWarOnThreatCountry = Utils.ConvertInt(rule_CanOnlyJustifyWarOnThreatCountry);
            this.Rule_CanGuaranteeOtherIdeologies = Utils.ConvertInt(rule_CanGuaranteeOtherIdeologies);
            this.Modifier_GenerateWarGoalTension = modifier_GenerateWarGoalTension;
            this.Modifier_GuaranteeTension = modifier_GuaranteeTension;
            this.Modifier_CivilianIntelToOthers = modifier_CivilianIntelToOthers;
            this.Modifier_ArmyIntelToOthers = modifier_ArmyIntelToOthers;
            this.Modifier_NavyIntelToOthers = modifier_NavyIntelToOthers;
            this.Modifier_AirforceIntelToOthers = modifier_AirforceIntelToOthers;
            this.Modifier_JustifyWarGoalWhenInMajorWarTime = modifier_JustifyWarGoalWhenInMajorWarTime;
            this.Modifier_JoinFactionTension = modifier_JoinFactionTension;
            this.Modifier_LendLeaseTension = modifier_LendLeaseTension;
            this.Modifier_AnnexCostFactor = modifier_AnnexCostFactor;
            this.Modifier_SendVolunteersTension = modifier_SendVolunteersTension;
            this.Modifier_TakeStatesCostFactor = modifier_TakeStatesCostFactor;
            this.Modifier_DriftDefenceFactor = modifier_DriftDefenceFactor;
            this.Modifier_PuppetCostFactor = modifier_PuppetCostFactor;
            this.CanAIUse = Utils.ConvertInt(canAIUse);
            this.CanBeBoosted = Utils.ConvertInt(canBeBoosted);
            this.WarImpactOnWorldTension = warImpactOnWorldTension;
            this.FactionImpactOnWorldTension = factionImpactOnWorldTension;
            this.CanCollaborate = Utils.ConvertInt(canCollaborate);
            this.CanHostGovernmentInExile = Utils.ConvertInt(canHostGovernmentInExile);
        }
    }
}
