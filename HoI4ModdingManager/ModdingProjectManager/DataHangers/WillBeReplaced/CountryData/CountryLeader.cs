using System;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers.WillBeReplaced.CountryData
{
    class CountryLeader
    {
        public CountryLeader()
        {
            Initialize();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public DateTime Expire { get; set; }
        public string SmallIdeology { get; set; }
        public string[] Traits { get; set; }

        public void Initialize()
        {
            this.Name = "";
            this.Description = "";
            this.PicturePath = "";
            this.Expire = DateTime.MinValue;
            this.SmallIdeology = "";
            this.Traits = new string[] { };
        }
    }
}
