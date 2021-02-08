using System;
using System.Data.Linq.Mapping;
using System.Linq;
using HoI4ModdingManager.ModdingProjectManager.SQLite;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectExporter
{
    [Table(Name = "country_data")]
    class CountryDataTable
    {
        [Column(Name = "name", DbType = "TEXT")]
        public string Name { get; set; }
        [Column(Name = "country_tag", DbType = "TEXT")]
        public string CountryTag { get; set; }
        [Column(Name = "capital_state_id", DbType = "INTEGER")]
        public int CapitalStateID { get; set; }
        [Column(Name = "stability", DbType = "REAL")]
        public float Stability { get; set; }
        [Column(Name = "war_support", DbType = "REAL")]
        public float WarSupport { get; set; }
        [Column(Name = "political_power", DbType = "INTEGER")]
        public int PoliticalPower { get; set; }
        [Column(Name = "research_slots", DbType = "INTEGER")]
        public int ResearchSlots { get; set; }
        [Column(Name = "convoys", DbType = "INTEGER")]
        public int Convoys { get; set; }
        [Column(Name = "unit_file_id", DbType = "TEXT")]
        public string UnitFileID { get; set; }
        [Column(Name = "technologies", DbType = "TEXT")]
        public string Technologies { get; set; }
        [Column(Name = "ideas", DbType = "TEXT")]
        public string Ideas { get; set; }
        [Column(Name = "ruling_party_ideology", DbType = "TEXT")]
        public string RulingPartyIdeology { get; set; }
        [Column(Name = "last_election_at", DbType = "BLOB")]
        public DateTime LastElectionAt { get; set; }
        [Column(Name = "is_allow_election", DbType = "INTEGER")]
        public int IsAllowElection { get; set; }
        [Column(Name = "party_supports", DbType = "TEXT")]
        public string PartySupports { get; set; }
        [Column(Name = "rgb_country_color", DbType = "TEXT")]
        public string RGBCountryColor { get; set; }
        [Column(Name = "graphic_culture", DbType = "TEXT")]
        public string GraphicCulture { get; set; }
        [Column(Name = "country_names", DbType = "TEXT")]
        public string CountryNames { get; set; }
        [Column(Name = "party_names", DbType = "TEXT")]
        public string PartyNames { get; set; }
        [Column(Name = "country_flag_paths", DbType = "TEXT")]
        public string CountryFlagPaths { get; set; }

        public CountryDataTable(string name,
                                string countryTag,
                                int capitalStateID,
                                float stability,
                                float warSupport,
                                int politicalPower,
                                int researchSlots,
                                int convoys,
                                string unitFileID,
                                string[] technologies,
                                string[] ideas,
                                string rulingPartyIdeology,
                                DateTime lastElectionAt,
                                bool isAllowElection,
                                float[] partySupports,
                                int[] rgbCountryColor,
                                string graphicCulture,
                                string[] countryNames,
                                string[] partyNames,
                                string[] countryFlagPaths)
        {
            this.Name = name;
            this.CountryTag = countryTag;
            this.CapitalStateID = capitalStateID;
            this.Stability = stability;
            this.WarSupport = warSupport;
            this.PoliticalPower = politicalPower;
            this.ResearchSlots = researchSlots;
            this.Convoys = convoys;
            this.UnitFileID = unitFileID;
            this.Technologies = string.Join(",", technologies);
            this.Ideas = string.Join(",", ideas);
            this.RulingPartyIdeology = rulingPartyIdeology;
            this.LastElectionAt = lastElectionAt;
            this.IsAllowElection = Utils.ConvertInt(isAllowElection);
            this.PartySupports = string.Join(",", partySupports.Select(x => x.ToString()));
            this.RGBCountryColor = string.Join(",", rgbCountryColor.Select(x => x.ToString()));
            this.GraphicCulture = graphicCulture;
            this.CountryNames = string.Join(",", countryNames);
            this.PartyNames = string.Join(",", partyNames);
            this.CountryFlagPaths = string.Join(",", countryFlagPaths);
        }
    }
}
