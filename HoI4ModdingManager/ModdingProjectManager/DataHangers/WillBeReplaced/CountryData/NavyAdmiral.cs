namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.WillBeReplaced.CountryData
{
    class NavyAdmiral
    {
        public NavyAdmiral()
        {
            Initialize();
        }

        public string Name { get; set; }
        public string PortraitPath { get; set; }
        public string[] Traits { get; set; }
        public int Skill { get; set; }
        public NavyAdmiralSkill Skills { get; set; }

        public void Initialize()
        {
            this.Name = "";
            this.PortraitPath = "";
            this.Traits = new string[] { };
            this.Skill = 1;
            this.Skills = new NavyAdmiralSkill();
        }
    }
}
