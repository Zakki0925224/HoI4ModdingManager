using System;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    class ProjectDataHanger
    {
        public string project_name;
        public DateTime created_at;
        public DateTime updated_at;
        public int number_of_countries;
        public int number_of_ideologies;

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            project_name = null;
            created_at = DateTime.MinValue;
            updated_at = DateTime.MinValue;
            number_of_countries = 0;
            number_of_ideologies = 0;
        }
    }
}
