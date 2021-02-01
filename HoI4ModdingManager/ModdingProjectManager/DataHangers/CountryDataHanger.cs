using HoI4ModdingManager.ModdingProjectManager.DataHangers.CountryData;
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
    }
}
