using System.Data.Linq.Mapping;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectExporter
{
    [Table(Name = "project_data")]
    public class ProjectDataTable
    {
        [Column(Name = "project_name", DbType = "TEXT")]
        public string ProjectName { get; set; }
        [Column(Name = "mod_version", DbType = "TEXT")]
        public string ModVersion { get; set; }
        [Column(Name = "supported_game_version", DbType = "TEXT")]
        public string SupportedGameVersion { get; set; }
        [Column(Name = "tags", DbType = "TEXT")]
        public string Tags { get; set; }
        [Column(Name = "thumbnail_picture_path", DbType = "TEXT")]
        public string ThumbnailPicturePath { get; set; }
        [Column(Name = "replace_paths", DbType = "TEXT")]
        public string ReplacePaths { get; set; }
        [Column(Name = "mod_path", DbType = "TEXT")]
        public string ModPath { get; set; }
        [Column(Name = "user_dir", DbType = "TEXT")]
        public string UserDir { get; set; }
        [Column(Name = "remote_file_id", DbType = "TEXT")]
        public string RemoteFileID { get; set; }
        [Column(Name = "depondency_mods", DbType = "TEXT")]
        public string DepondencyMods { get; set; }
        [Column(Name = "depondency_dlcs", DbType = "TEXT")]
        public string DepondencyDLCs { get; set; }

        public ProjectDataTable(string projectName,
                                string modVersion,
                                string supportedGameVersion,
                                string[] tags,
                                string thumbnailPicturePath,
                                string[] replacePaths,
                                string modPath,
                                string userDir,
                                string remoteFileID,
                                string[] depondencyMods,
                                string[] depondencyDLCs)
        {
            ProjectName = projectName;
            ModVersion = modVersion;
            SupportedGameVersion = supportedGameVersion;
            Tags = string.Join(",", tags);
            ThumbnailPicturePath = thumbnailPicturePath;
            ReplacePaths = string.Join(",", replacePaths);
            ModPath = modPath;
            UserDir = userDir;
            RemoteFileID = remoteFileID;
            DepondencyMods = string.Join(",", depondencyMods);
            DepondencyDLCs = string.Join(",", depondencyDLCs);
        }
    }
}
