namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.WillBeReplaced
{
    class IdeologyDataHanger
    {
        public IdeologyDataHanger()
        {
            Initialize();
        }

        public string Name { get; set; }
        public string[] SmallIdeologies { get; set; }
        public int[] RGBIdeologyColor { get; set; }
        public int ID { get; set; }
        public bool Rule_CanForceGovernment { get; set; }
        public bool Rule_CanPuppet { get; set; }
        public bool Rule_CanSendVolunteers { get; set; }
        public bool Rule_CanLowerTension { get; set; }
        public bool Rule_CanCreateCollaborationGovernment { get; set; }
        public bool Rule_CanDeclareWarOnSameIdeology { get; set; }
        public bool Rule_CanOnlyJustifyWarOnThreatCountry { get; set; }
        public bool Rule_CanGuaranteeOtherIdeologies { get; set; }
        public float Modifier_GenerateWargoalTension { get; set; }
        public float Modifier_GuaranteeTension { get; set; }
        public int Modifier_CivilianIntelToOthers { get; set; }
        public int Modifier_ArmyIntelToOthers { get; set; }
        public int Modifier_NavyIntelToOthers { get; set; }
        public int Modifier_AirforceIntelToOthers { get; set; }
        public float Modifier_JustifyWarGoalWhenInMajorWarTime { get; set; }
        public float Modifier_JoinFactionTension { get; set; }
        public float Modifier_LendLeaseTension { get; set; }
        public float Modifier_AnnexCostFactor { get; set; }
        public float Modifier_SendVolunteersTension { get; set; }
        public float Modifier_TakeStatesCostFactor { get; set; }
        public float Modifier_DriftDefenceFactor { get; set; }
        public float Modifier_PuppetCostFactor { get; set; }
        public bool CanAIUse { get; set; }
        public bool CanBeBoosted { get; set; }
        public float WarImpactOnWorldTension { get; set; }
        public float FactionImpactOnWorldTension { get; set; }
        public bool CanCollaborate { get; set; }
        public bool CanHostGovernmentInExile { get; set; }
        
        public void Initialize()
        {
            this.Name = "";
            this.SmallIdeologies = new string[] { };
            this.RGBIdeologyColor = new int[] { };
            this.ID = 0;
            this.Rule_CanForceGovernment = false;
            this.Rule_CanPuppet = false;
            this.Rule_CanSendVolunteers = false;
            this.Rule_CanLowerTension = false;
            this.Rule_CanCreateCollaborationGovernment = false;
            this.Rule_CanDeclareWarOnSameIdeology = false;
            this.Rule_CanOnlyJustifyWarOnThreatCountry = false;
            this.Rule_CanGuaranteeOtherIdeologies = false;
            this.Modifier_GenerateWargoalTension = 0;
            this.Modifier_GuaranteeTension = 0;
            this.Modifier_CivilianIntelToOthers = 0;
            this.Modifier_ArmyIntelToOthers = 0;
            this.Modifier_NavyIntelToOthers = 0;
            this.Modifier_AirforceIntelToOthers = 0;
            this.Modifier_JustifyWarGoalWhenInMajorWarTime = 0;
            this.Modifier_JoinFactionTension = 0;
            this.Modifier_LendLeaseTension = 0;
            this.Modifier_AnnexCostFactor = 0;
            this.Modifier_SendVolunteersTension = 0;
            this.Modifier_TakeStatesCostFactor = 0;
            this.Modifier_DriftDefenceFactor = 0;
            this.Modifier_PuppetCostFactor = 0;
            this.CanAIUse = false;
            this.CanBeBoosted = false;
            this.WarImpactOnWorldTension = 0;
            this.FactionImpactOnWorldTension = 0;
            this.CanCollaborate = false;
            this.CanHostGovernmentInExile = false;
        }
    }
}
