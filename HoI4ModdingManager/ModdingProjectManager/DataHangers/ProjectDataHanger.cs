using Newtonsoft.Json;

namespace HoI4ModdingManager.ModdingProjectManager.DataHangers
{
    public class ProjectDataHanger
    {
        public ProjectDataHanger()
        {
            Initialize();
        }

        public bool DataChanged { get; set; }

        private string _projectName;
        public string ProjectName
        {
            get => this._projectName;
            set
            {
                this._projectName = value;
                this.DataChanged = true;
            }
        }

        private string _modVersion;
        public string ModVersion
        {
            get => this._modVersion;
            set
            {
                this._modVersion = value;
                this.DataChanged = true;
            }
        }

        private string _supportedGameVersion;
        public string SupportedGameVersion
        {
            get => this._supportedGameVersion;
            set
            {
                this._supportedGameVersion = value;
                this.DataChanged = true;
            }
        }

        private string[] _tags;
        public string[] Tags
        {
            get => this._tags;
            set
            {
                this._tags = value;
                this.DataChanged = true;
            }
        }

        private string _thumbnailPicturePath;
        public string ThumbnailPicturePath
        {
            get => this._thumbnailPicturePath;
            set
            {
                this._thumbnailPicturePath = value;
                this.DataChanged = true;
            }
        }

        private string[] _replacePaths;
        public string[] ReplacePaths
        {
            get => this._replacePaths;
            set
            {
                this._replacePaths = value;
                this.DataChanged = true;
            }
        }

        private string _modPath;
        public string ModPath
        {
            get => this._modPath;
            set
            {
                this._modPath = value;
                this.DataChanged = true;
            }
        }

        private string _userDir;
        public string UserDir
        {
            get => this._userDir;
            set
            {
                this._userDir = value;
                this.DataChanged = true;
            }
        }

        private string _remoteFileID;
        public string RemoteFileID
        {
            get => this._remoteFileID;
            set
            {
                this._remoteFileID = value;
                this.DataChanged = true;
            }
        }

        private string[] _depondencyMods;
        public string[] DepondencyMods
        {
            get => this._depondencyMods;
            set
            {
                this._depondencyMods = value;
                this.DataChanged = true;
            }
        }

        private string[] _depondencyDLCs;
        public string[] DepondencyDLCs
        {
            get => this._depondencyDLCs;
            set
            {
                this._depondencyDLCs = value;
                this.DataChanged = true;
            }
        }

        public void Initialize()
        {
            this.DataChanged = false;
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
