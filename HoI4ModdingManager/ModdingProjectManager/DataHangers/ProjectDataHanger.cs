﻿using System;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    class ProjectDataHanger
    {
        public string Project_name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public int Number_of_countries { get; set; }
        public int Number_of_ideologies { get; set; }

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            Project_name = null;
            Created_at = DateTime.MinValue;
            Updated_at = DateTime.MinValue;
            Number_of_countries = 0;
            Number_of_ideologies = 0;
        }
    }
}
