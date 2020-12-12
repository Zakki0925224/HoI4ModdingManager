using System;

namespace HoI4ModdingManager.ModdingProjectManager.Data
{
    class ProjectData
    {
        public string project_name;
        public DateTime created_at;
        public DateTime updated_at;

        /// <summary>
        /// データをすべて初期化
        /// </summary>
        public void Initialize()
        {
            project_name = null;
            created_at = DateTime.MinValue;
            updated_at = DateTime.MinValue;
        }
    }
}
