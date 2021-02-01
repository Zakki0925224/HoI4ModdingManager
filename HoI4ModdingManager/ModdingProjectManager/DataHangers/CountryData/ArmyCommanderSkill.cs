namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.CountryData
{
    public class ArmyCommanderSkill
    {
        public ArmyCommanderSkill()
        {
            Initialize();
        }

        public int AttackSkill { get; set; }
        public int DefenseSkill { get; set; }
        public int PlanningSkill { get; set; }
        public int LogisticsSkill { get; set; }

        public void Initialize()
        {
            this.AttackSkill = 0;
            this.DefenseSkill = 0;
            this.PlanningSkill = 0;
            this.LogisticsSkill = 0;
        }
    }
}
