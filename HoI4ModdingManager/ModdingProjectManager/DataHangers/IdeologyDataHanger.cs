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

        public bool DataChanged { get; set; }

        private string _name;
        public string Name
        {
            get => this._name;
            set
            {
                this._name = value;
                this.DataChanged = true;
            }
        }

        private string[] _smallIdeologies;
        public string[] SmallIdeologies
        {
            get => this._smallIdeologies;
            set
            {
                this._smallIdeologies = value;
                this.DataChanged = true;
            }
        }

        private int[] _rgbIdeologyColor;
        public int[] RGBIdeologyColor
        {
            get => this._rgbIdeologyColor;
            set
            {
                this._rgbIdeologyColor = value;
                this.DataChanged = true;
            }
        }

        private int _id;
        public int ID
        {
            get => this._id;
            set
            {
                this._id = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanForceGovernment;
        public bool Rule_CanForceGovernment
        {
            get => this._rule_CanForceGovernment;
            set
            {
                this._rule_CanForceGovernment = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanPuppet;
        public bool Rule_CanPuppet
        {
            get => this._rule_CanPuppet;
            set
            {
                this._rule_CanPuppet = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanSendVolunteers;
        public bool Rule_CanSendVolunteers
        {
            get => this._rule_CanSendVolunteers;
            set
            {
                this._rule_CanSendVolunteers = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanLowerTension;
        public bool Rule_CanLowerTension
        {
            get => this._rule_CanLowerTension;
            set
            {
                this._rule_CanLowerTension = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanCreateCollaborationGovernment;
        public bool Rule_CanCreateCollaborationGovernment
        {
            get => this._rule_CanCreateCollaborationGovernment;
            set
            {
                this._rule_CanCreateCollaborationGovernment = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanDeclareWarOnSameIdeology;
        public bool Rule_CanDeclareWarOnSameIdeology
        {
            get => this._rule_CanDeclareWarOnSameIdeology;
            set
            {
                this._rule_CanDeclareWarOnSameIdeology = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanOnlyJustifyWarOnThreatCountry;
        public bool Rule_CanOnlyJustifyWarOnThreatCountry
        {
            get => this._rule_CanOnlyJustifyWarOnThreatCountry;
            set
            {
                this._rule_CanOnlyJustifyWarOnThreatCountry = value;
                this.DataChanged = true;
            }
        }

        private bool _rule_CanGuaranteeOtherIdeologies;
        public bool Rule_CanGuaranteeOtherIdeologies
        {
            get => this._rule_CanGuaranteeOtherIdeologies;
            set
            {
                this._rule_CanGuaranteeOtherIdeologies = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_GenerateWarGoalTension;
        public float Modifier_GenerateWarGoalTension
        {
            get => this._modifier_GenerateWarGoalTension;
            set
            {
                this._modifier_GenerateWarGoalTension = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_GuaranteeTension;
        public float Modifier_GuaranteeTension
        {
            get => this._modifier_GuaranteeTension;
            set
            {
                this._modifier_GuaranteeTension = value;
                this.DataChanged = true;
            }
        }

        private int _modifier_CivilianIntelToOthers;
        public int Modifier_CivilianIntelToOthers
        {
            get => this._modifier_CivilianIntelToOthers;
            set
            {
                this._modifier_CivilianIntelToOthers = value;
                this.DataChanged = true;
            }
        }

        private int _modifier_ArmyIntelToOthers;
        public int Modifier_ArmyIntelToOthers
        {
            get => this._modifier_ArmyIntelToOthers;
            set
            {
                this._modifier_ArmyIntelToOthers = value;
                this.DataChanged = true;
            }
        }

        private int _modifier_NavyIntelToOthers;
        public int Modifier_NavyIntelToOthers
        {
            get => this._modifier_NavyIntelToOthers;
            set
            {
                this._modifier_NavyIntelToOthers = value;
                this.DataChanged = true;
            }
        }

        private int _modifier_AirforceIntelToOthers;
        public int Modifier_AirforceIntelToOthers
        {
            get => this._modifier_AirforceIntelToOthers;
            set
            {
                this._modifier_AirforceIntelToOthers = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_JustifyWarGoalWhenInMajorWarTime;
        public float Modifier_JustifyWarGoalWhenInMajorWarTime
        {
            get => this._modifier_JustifyWarGoalWhenInMajorWarTime;
            set
            {
                this._modifier_JustifyWarGoalWhenInMajorWarTime = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_JoinFactionTension;
        public float Modifier_JoinFactionTension
        {
            get => this._modifier_JoinFactionTension;
            set
            {
                this._modifier_JoinFactionTension = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_LendLeaseTension;
        public float Modifier_LendLeaseTension
        {
            get => this._modifier_LendLeaseTension;
            set
            {
                this._modifier_LendLeaseTension = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_AnnexCostFactor;
        public float Modifier_AnnexCostFactor
        {
            get => this._modifier_AnnexCostFactor;
            set
            {
                this._modifier_AnnexCostFactor = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_SendVolunteersTension;
        public float Modifier_SendVolunteersTension
        {
            get => this._modifier_SendVolunteersTension;
            set
            {
                this._modifier_SendVolunteersTension = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_TakeStatesCostFactor;
        public float Modifier_TakeStatesCostFactor
        {
            get => this._modifier_TakeStatesCostFactor;
            set
            {
                this._modifier_TakeStatesCostFactor = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_DriftDefenceFactor;
        public float Modifier_DriftDefenceFactor
        {
            get => this._modifier_DriftDefenceFactor;
            set
            {
                this._modifier_DriftDefenceFactor = value;
                this.DataChanged = true;
            }
        }

        private float _modifier_PuppetCostFactor;
        public float Modifier_PuppetCostFactor
        {
            get => this._modifier_PuppetCostFactor;
            set
            {
                this._modifier_PuppetCostFactor = value;
                this.DataChanged = true;
            }
        }

        private bool _canAIUse;
        public bool CanAIUse
        {
            get => this._canAIUse;
            set
            {
                this._canAIUse = value;
                this.DataChanged = true;
            }
        }

        private bool _canBeBoosted;
        public bool CanBeBoosted
        {
            get => this._canBeBoosted;
            set
            {
                this._canBeBoosted = value;
                this.DataChanged = true;
            }
        }

        private float _warImpactOnWorldTension;
        public float WarImpactOnWorldTension
        {
            get => this._warImpactOnWorldTension;
            set
            {
                this._warImpactOnWorldTension = value;
                this.DataChanged = true;
            }
        }

        private float _factionImpactOnWorldTension;
        public float FactionImpactOnWorldTension
        {
            get => this._factionImpactOnWorldTension;
            set
            {
                this._factionImpactOnWorldTension = value;
                this.DataChanged = true;
            }
        }

        private bool _canCollaborate;
        public bool CanCollaborate
        {
            get => this._canCollaborate;
            set
            {
                this._canCollaborate = value;
                this.DataChanged = true;
            }
        }

        private bool _canHostGovernmentInExile;
        public bool CanHostGovernmentInExile
        {
            get => this._canHostGovernmentInExile;
            set
            {
                this._canHostGovernmentInExile = value;
                this.DataChanged = true;
            }
        }

        public void Initialize()
        {
            this.DataChanged = false;
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
