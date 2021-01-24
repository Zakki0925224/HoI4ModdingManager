namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.WillBeReplaced.CountryData
{
    class ArmyCommander
    {
        public ArmyCommander()
        {
            Initialize();
        }

        public string Name { get; set; }
        public string PortraitPath { get; set; }
        public string[] Traits { get; set; }
        public int Skill { get; set; }
        public ArmyCommanderSkill Skills { get; set; }
        public bool IsMarshal { get; set; }

        public void Initialize()
        {
            this.Name = "";
            this.PortraitPath = "";
            this.Traits = new string[] { };
            this.Skill = 1;
            this.Skills = new ArmyCommanderSkill();
            this.IsMarshal = false;
        }
    }
}
