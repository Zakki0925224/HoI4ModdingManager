using Newtonsoft.Json;

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

        /// <summary>
        /// データベースから生データを取得し、プロパティに変換
        /// </summary>
        public void ImportFromDataBase(string projectName,
                                       string modVersion,
                                       string supportedGameVersion,
                                       string tags,
                                       string thumbnailPicturePath,
                                       string replacePaths,
                                       string modPath,
                                       string userDir,
                                       string remoteFileID,
                                       string depondencyMods,
                                       string depondencyDLCs)
        {
            this.ProjectName = projectName;
            this.ModVersion = modVersion;
            this.SupportedGameVersion = supportedGameVersion;
            this.Tags = JsonConvert.DeserializeObject<string[]>(tags);
            this.ThumbnailPicturePath = thumbnailPicturePath;
            this.ReplacePaths = JsonConvert.DeserializeObject<string[]>(replacePaths);
            this.ModPath = modPath;
            this.UserDir = userDir;
            this.RemoteFileID = remoteFileID;
            this.DepondencyMods = JsonConvert.DeserializeObject<string[]>(depondencyMods);
            this.DepondencyDLCs = JsonConvert.DeserializeObject<string[]>(depondencyDLCs);
        }

        /// <summary>
        /// プロパティから生データに変換
        /// </summary>
        /// <returns></returns>
        public string[] ExportToDataBase()
        {
            return new string[]
            {
                this.ProjectName,
                this.ModVersion,
                this.SupportedGameVersion,
                JsonConvert.SerializeObject(this.Tags),
                this.ThumbnailPicturePath,
                JsonConvert.SerializeObject(this.ReplacePaths),
                this.ModPath,
                this.UserDir,
                this.RemoteFileID,
                JsonConvert.SerializeObject(this.DepondencyMods),
                JsonConvert.SerializeObject(this.DepondencyDLCs)
            };
        }
    }
}
