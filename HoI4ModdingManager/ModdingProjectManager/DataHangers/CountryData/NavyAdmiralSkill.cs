namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.CountryData
{
    public class NavyAdmiralSkill
    {
        public NavyAdmiralSkill()
        {
            Initialize();
        }

        public int AttackSkill { get; set; }
        public int DefenseSkill { get; set; }
        public int ManeuveringSkill { get; set; }
        public int CoordinationSkill { get; set; }

        public void Initialize()
        {
            this.AttackSkill = 0;
            this.DefenseSkill = 0;
            this.ManeuveringSkill = 0;
            this.CoordinationSkill = 0;
        }
    }
}
