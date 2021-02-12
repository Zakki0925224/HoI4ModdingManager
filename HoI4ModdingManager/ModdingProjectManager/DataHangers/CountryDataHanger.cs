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

        public string Name { get; set; }
        public string CountryTag { get; set; }
        public int CapitalStateID { get; set; }
        public float Stability { get; set; }
        public float WarSupport { get; set; }
        public int PoliticalPower { get; set; }
        public int ResearchSlots { get; set; }
        public int Convoys { get; set; }
        public string UnitFileID { get; set; }
        public string[] Technologies { get; set; }
        public string[] Ideas { get; set; }
        public string RulingPartyIdeology { get; set; }
        public DateTime LastElectionAt { get; set; }
        public bool IsAllowElection { get; set; }
        public float[] PartySupports { get; set; }
        public int[] RGBCountryColor { get; set; }
        public string GraphicCulture { get; set; }
        public List<CountryLeader> DefinedCountryLeaders { get; set; }
        public List<ArmyCommander> DefinedArmyCommanders { get; set; }
        public List<NavyAdmiral> DefinedNavyAdmirals { get; set; }
        public string[] CountryNames { get; set; }
        public string[] PartyNames { get; set; }
        public string[] CountryFlagPaths { get; set; }

        public void Initialize()
        {
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
