using HoI4ModdingManager.ModdingProjectManager.DataHangers.CountryData;
using HoI4ModdingManager.ModdingProjectManager.SQLite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    public class CountryDataHanger
    {
        public CountryDataHanger()
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

        private string _countryTag;
        public string CountryTag
        {
            get => this._countryTag;
            set
            {
                this._countryTag = value;
                this.DataChanged = true;
            }
        }

        private int _capitalStateID;
        public int CapitalStateID
        {
            get => this._capitalStateID;
            set
            {
                this._capitalStateID = value;
                this.DataChanged = true;
            }
        }

        private float _stability;
        public float Stability
        {
            get => this._stability;
            set
            {
                this._stability = value;
                this.DataChanged = true;
            }
        }

        private float _warSupport;
        public float WarSupport
        {
            get => this._warSupport;
            set
            {
                this._warSupport = value;
                this.DataChanged = true;
            }
        }

        private int _politicalPower;
        public int PoliticalPower
        {
            get => this._politicalPower;
            set
            {
                this._politicalPower = value;
                this.DataChanged = true;
            }
        }

        private int _researchSlots;
        public int ResearchSlots
        {
            get => this._researchSlots;
            set
            {
                this._researchSlots = value;
                this.DataChanged = true;
            }
        }

        private int _convoys;
        public int Convoys
        {
            get => this._convoys;
            set
            {
                this._convoys = value;
                this.DataChanged = true;
            }
        }

        private string _unitFileID;
        public string UnitFileID
        {
            get => this._unitFileID;
            set
            {
                this._unitFileID = value;
                this.DataChanged = true;
            }
        }

        private string[] _technologies;
        public string[] Technologies
        {
            get => this._technologies;
            set
            {
                this._technologies = value;
                this.DataChanged = true;
            }
        }

        private string[] _ideas;
        public string[] Ideas
        {
            get => this._ideas;
            set
            {
                this._ideas = value;
                this.DataChanged = true;
            }
        }

        private string _rulingPartyIdeology;
        public string RulingPartyIdeology
        {
            get => this._rulingPartyIdeology;
            set
            {
                this._rulingPartyIdeology = value;
                this.DataChanged = true;
            }
        }

        private DateTime _lastElectionAt;
        public DateTime LastElectionAt
        {
            get => this._lastElectionAt;
            set
            {
                this._lastElectionAt = value;
                this.DataChanged = true;
            }
        }

        private bool _isAllowElection;
        public bool IsAllowElection
        {
            get => this._isAllowElection;
            set
            {
                this._isAllowElection = value;
                this.DataChanged = true;
            }
        }

        private float[] _partySupports;
        public float[] PartySupports
        {
            get => this._partySupports;
            set
            {
                this._partySupports = value;
                this.DataChanged = true;
            }
        }

        private int[] _rgbCountryColor;
        public int[] RGBCountryColor
        {
            get => this._rgbCountryColor;
            set
            {
                this._rgbCountryColor = value;
                this.DataChanged = true;
            }
        }

        private string _graphicCulture;
        public string GraphicCulture
        {
            get => this._graphicCulture;
            set
            {
                this._graphicCulture = value;
                this.DataChanged = true;
            }
        }

        private List<CountryLeader> _definedCountryLeaders;
        public List<CountryLeader> DefinedCountryLeaders
        {
            get => this._definedCountryLeaders;
            set
            {
                this._definedCountryLeaders = value;
                this.DataChanged = true;
            }
        }

        private List<ArmyCommander> _definedArmyCommanders;
        public List<ArmyCommander> DefinedArmyCommanders
        {
            get => this._definedArmyCommanders;
            set
            {
                this._definedArmyCommanders = value;
                this.DataChanged = true;
            }
        }

        private List<NavyAdmiral> _definedNavyAdmirals;
        public List<NavyAdmiral> DefinedNavyAdmirals
        {
            get => this._definedNavyAdmirals;
            set
            {
                this._definedNavyAdmirals = value;
                this.DataChanged = true;
            }
        }

        private string[] _countryNames;
        public string[] CountryNames
        {
            get => this._countryNames;
            set
            {
                this._countryNames = value;
                this.DataChanged = true;
            }
        }

        private string[] _partyNames;
        public string[] PartyNames
        {
            get => this._partyNames;
            set
            {
                this._partyNames = value;
                this.DataChanged = true;
            }
        }

        private string[] _countryFlagPaths;
        public string[] CountryFlagPaths
        {
            get => this._countryFlagPaths;
            set
            {
                this._countryFlagPaths = value;
                this.DataChanged = true;
            }
        }

        public void Initialize()
        {
            this.DataChanged = false;
            this.Name = "";
            this.CountryTag = "";
            this.CapitalStateID = 0;
            this.Stability = 0;
            this.WarSupport = 0;
            this.PoliticalPower = 0;
            this.ResearchSlots = 0;
            this.Convoys = 0;
            this.UnitFileID = "";
            this.Technologies = new string[] { };
            this.Ideas = new string[] { };
            this.RulingPartyIdeology = "";
            this.LastElectionAt = DateTime.MinValue;
            this.IsAllowElection = false;
            this.PartySupports = new float[] { };
            this.RGBCountryColor = new int[] { };
            this.GraphicCulture = "";
            this.DefinedCountryLeaders = new List<CountryLeader>();
            this.DefinedArmyCommanders = new List<ArmyCommander>();
            this.DefinedNavyAdmirals = new List<NavyAdmiral>();
            this.CountryNames = new string[] { };
            this.PartyNames = new string[] { };
            this.CountryFlagPaths = new string[] { };
        }

        /// <summary>
        /// データベースから生データを取得し、プロパティに変換
        /// </summary>
        public void ImportFromDataBase(string name,
                                       string countryTag,
                                       string capitalStateID,
                                       string stability,
                                       string warSupport,
                                       string politicalPower,
                                       string researchSlots,
                                       string convoys,
                                       string unitFileID,
                                       string technologies,
                                       string ideas,
                                       string rulingPartyIdeology,
                                       string lastElectionAt,
                                       string isAllowElection,
                                       string partySupports,
                                       string rgbCountryColor,
                                       string graphicCulture,
                                       string countryNames,
                                       string partyNames,
                                       string countryFlagPaths)
        {
            this.Name = name;
            this.CountryTag = countryTag;
            this.CapitalStateID = int.Parse(capitalStateID);
            this.Stability = float.Parse(stability);
            this.WarSupport = float.Parse(warSupport);
            this.PoliticalPower = int.Parse(politicalPower);
            this.ResearchSlots = int.Parse(researchSlots);
            this.Convoys = int.Parse(convoys);
            this.UnitFileID = unitFileID;
            this.Technologies = JsonConvert.DeserializeObject<string[]>(technologies);
            this.Ideas = JsonConvert.DeserializeObject<string[]>(ideas);
            this.RulingPartyIdeology = rulingPartyIdeology;
            this.LastElectionAt = DateTime.Parse(lastElectionAt);
            this.IsAllowElection = Utils.GetBool(int.Parse(isAllowElection));
            this.PartySupports = JsonConvert.DeserializeObject<float[]>(partySupports);
            this.RGBCountryColor = JsonConvert.DeserializeObject<int[]>(rgbCountryColor);
            this.GraphicCulture = graphicCulture;
            this.CountryNames = JsonConvert.DeserializeObject<string[]>(countryNames);
            this.PartyNames = JsonConvert.DeserializeObject<string[]>(partyNames);
            this.CountryFlagPaths = JsonConvert.DeserializeObject<string[]>(countryFlagPaths);
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
                this.CountryTag,
                this.CapitalStateID.ToString(),
                this.Stability.ToString(),
                this.WarSupport.ToString(),
                this.PoliticalPower.ToString(),
                this.ResearchSlots.ToString(),
                this.Convoys.ToString(),
                this.UnitFileID,
                JsonConvert.SerializeObject(this.Technologies),
                JsonConvert.SerializeObject(this.Ideas),
                this.RulingPartyIdeology,
                this.LastElectionAt.ToString(),
                Utils.ConvertInt(this.IsAllowElection).ToString(),
                JsonConvert.SerializeObject(this.PartySupports),
                JsonConvert.SerializeObject(this.RGBCountryColor),
                this.GraphicCulture,
                JsonConvert.SerializeObject(this.CountryNames),
                JsonConvert.SerializeObject(this.PartyNames),
                JsonConvert.SerializeObject(this.CountryFlagPaths)
            };
        }
    }
}
