namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    public class ProjectDataHanger
    {
        public ProjectDataHanger()
        {
            Initialize();
        }

        public string ProjectName { get; set; }
        public string ModVersion { get; set; }
        public string SupportedGameVersion { get; set; }
        public string[] Tags { get; set; }
        public string ThumbnailPicturePath { get; set; }
        public string[] ReplacePaths { get; set; }
        public string ModPath { get; set; }
        public string UserDir { get; set; }
        public string RemoteFileID { get; set; }
        public string[] DepondencyMods { get; set; }
        public string[] DepondencyDLCs { get; set; }

        public void Initialize()
        {
            this.ProjectName = "";
            this.ModVersion = "";
            this.SupportedGameVersion = "";
            this.Tags = new string[] { };
            this.ThumbnailPicturePath = "";
            this.ReplacePaths = new string[] { };
            this.ModPath = "";
            this.UserDir = "";
            this.RemoteFileID = "";
            this.DepondencyMods = new string[] { };
            this.DepondencyDLCs = new string[] { };
        }

    }
}
