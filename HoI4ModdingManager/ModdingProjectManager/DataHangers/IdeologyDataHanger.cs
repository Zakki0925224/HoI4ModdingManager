using HoI4ModdingManager.ModdingProjectManager.SQLite;
using Newtonsoft.Json;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    public class IdeologyDataHanger
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
        public float Modifier_GenerateWarGoalTension { get; set; }
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
            this.Modifier_GenerateWarGoalTension = 0;
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

        /// <summary>
        /// データベースから生データを取得し、プロパティに変換
        /// </summary>
        public void ImportFromDataBase(string name,
                                       string smallIdeologies,
                                       string rgbIdeologyColor,
                                       string id,
                                       string rule_CanForceGovernment,
                                       string rule_CanPuppet,
                                       string rule_CanSendVolunteers,
                                       string rule_CanLowerTension,
                                       string rule_CanCreateCollaborationGovernment,
                                       string rule_CanDeclareWarOnSameIdeology,
                                       string rule_CanOnlyJustifyWarOnThreatCountry,
                                       string rule_CanGuaranteeOtherIdeologies,
                                       string modifier_GenerateWarGoalTension,
                                       string modifier_GuaranteeTension,
                                       string modifier_CivilianIntelToOthers,
                                       string modifier_ArmyIntelToOthers,
                                       string modifier_NavyIntelToOthers,
                                       string modifier_AirforceIntelToOthers,
                                       string modifier_JustifyWarGoalWhenInMajorWarTime,
                                       string modifier_JoinFactionTension,
                                       string modifier_LendLeaseTension,
                                       string modifier_AnnexCostFactor,
                                       string modifier_SendVolunteersTension,
                                       string modifier_TakeStatesCostFactor,
                                       string modifier_DriftDefenceFactor,
                                       string modifier_PuppetCostFactor,
                                       string canAIUse,
                                       string canBeBoosted,
                                       string warImpactOnWorldTension,
                                       string factionImpactOnWorldTension,
                                       string canCollaborate,
                                       string canHostGovernmentInExile)
        {
            this.Name = name;
            this.SmallIdeologies = JsonConvert.DeserializeObject<string[]>(smallIdeologies);
            this.RGBIdeologyColor = JsonConvert.DeserializeObject<int[]>(rgbIdeologyColor);
            this.ID = int.Parse(id);
            this.Rule_CanForceGovernment = Utils.GetBool(int.Parse(rule_CanForceGovernment));
            this.Rule_CanPuppet = Utils.GetBool(int.Parse(rule_CanPuppet));
            this.Rule_CanSendVolunteers = Utils.GetBool(int.Parse(rule_CanSendVolunteers));
            this.Rule_CanLowerTension = Utils.GetBool(int.Parse(rule_CanLowerTension));
            this.Rule_CanCreateCollaborationGovernment = Utils.GetBool(int.Parse(rule_CanCreateCollaborationGovernment));
            this.Rule_CanDeclareWarOnSameIdeology = Utils.GetBool(int.Parse(rule_CanDeclareWarOnSameIdeology));
            this.Rule_CanOnlyJustifyWarOnThreatCountry = Utils.GetBool(int.Parse(rule_CanOnlyJustifyWarOnThreatCountry));
            this.Rule_CanGuaranteeOtherIdeologies = Utils.GetBool(int.Parse(rule_CanGuaranteeOtherIdeologies));
            this.Modifier_GenerateWarGoalTension = float.Parse(modifier_GenerateWarGoalTension);
            this.Modifier_GuaranteeTension = float.Parse(modifier_GuaranteeTension);
            this.Modifier_CivilianIntelToOthers = int.Parse(modifier_CivilianIntelToOthers);
            this.Modifier_ArmyIntelToOthers = int.Parse(modifier_ArmyIntelToOthers);
            this.Modifier_NavyIntelToOthers = int.Parse(modifier_NavyIntelToOthers);
            this.Modifier_AirforceIntelToOthers = int.Parse(modifier_AirforceIntelToOthers);
            this.Modifier_JustifyWarGoalWhenInMajorWarTime = float.Parse(modifier_JustifyWarGoalWhenInMajorWarTime);
            this.Modifier_JoinFactionTension = float.Parse(modifier_JoinFactionTension);
            this.Modifier_LendLeaseTension = float.Parse(modifier_LendLeaseTension);
            this.Modifier_AnnexCostFactor = float.Parse(modifier_AnnexCostFactor);
            this.Modifier_SendVolunteersTension = float.Parse(modifier_SendVolunteersTension);
            this.Modifier_TakeStatesCostFactor = float.Parse(modifier_TakeStatesCostFactor);
            this.Modifier_DriftDefenceFactor = float.Parse(modifier_DriftDefenceFactor);
            this.Modifier_PuppetCostFactor = float.Parse(modifier_PuppetCostFactor);
            this.CanAIUse = Utils.GetBool(int.Parse(canAIUse));
            this.CanBeBoosted = Utils.GetBool(int.Parse(canBeBoosted));
            this.WarImpactOnWorldTension = float.Parse(warImpactOnWorldTension);
            this.FactionImpactOnWorldTension = float.Parse(factionImpactOnWorldTension);
            this.CanCollaborate = Utils.GetBool(int.Parse(canCollaborate));
            this.CanHostGovernmentInExile = Utils.GetBool(int.Parse(canHostGovernmentInExile));
        }

        /// <summary>
        /// プロパティから生データに変換
        /// </summary>
        /// <returns></returns>
        public string[] ExportToDataBase()
        {
            return new string[]
            {
                this.Name,
                JsonConvert.SerializeObject(this.SmallIdeologies),
                JsonConvert.SerializeObject(this.RGBIdeologyColor),
                this.ID.ToString(),
                Utils.ConvertInt(this.Rule_CanForceGovernment).ToString(),
                Utils.ConvertInt(this.Rule_CanPuppet).ToString(),
                Utils.ConvertInt(this.Rule_CanSendVolunteers).ToString(),
                Utils.ConvertInt(this.Rule_CanLowerTension).ToString(),
                Utils.ConvertInt(this.Rule_CanCreateCollaborationGovernment).ToString(),
                Utils.ConvertInt(this.Rule_CanDeclareWarOnSameIdeology).ToString(),
                Utils.ConvertInt(this.Rule_CanOnlyJustifyWarOnThreatCountry).ToString(),
                Utils.ConvertInt(this.Rule_CanGuaranteeOtherIdeologies).ToString(),
                this.Modifier_GenerateWarGoalTension.ToString(),
                this.Modifier_GuaranteeTension.ToString(),
                this.Modifier_CivilianIntelToOthers.ToString(),
                this.Modifier_ArmyIntelToOthers.ToString(),
                this.Modifier_NavyIntelToOthers.ToString(),
                this.Modifier_AirforceIntelToOthers.ToString(),
                this.Modifier_JustifyWarGoalWhenInMajorWarTime.ToString(),
                this.Modifier_JoinFactionTension.ToString(),
                this.Modifier_LendLeaseTension.ToString(),
                this.Modifier_AnnexCostFactor.ToString(),
                this.Modifier_SendVolunteersTension.ToString(),
                this.Modifier_TakeStatesCostFactor.ToString(),
                this.Modifier_DriftDefenceFactor.ToString(),
                this.Modifier_PuppetCostFactor.ToString(),
                Utils.ConvertInt(this.CanAIUse).ToString(),
                Utils.ConvertInt(this.CanBeBoosted).ToString(),
                this.WarImpactOnWorldTension.ToString(),
                this.FactionImpactOnWorldTension.ToString(),
                Utils.ConvertInt(this.CanCollaborate).ToString(),
                Utils.ConvertInt(this.CanHostGovernmentInExile).ToString()
            };
        }
    }
}
