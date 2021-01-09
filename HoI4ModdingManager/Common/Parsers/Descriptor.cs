using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HoI4ModdingManager.Common.Parsers
{
    /// <summary>
    /// descriptor.mod
    /// </summary>
    class Descriptor
    {
        readonly List<string> keywords = new List<string>()
        {
            "version",
            "name",
            "supported_version",
            "tags",
            "picture",
            "replace_path",
            "remote_file_id",
            "path",
            "user_dir",
            "dependencies"
        };

        readonly List<string> tags = new List<string>()
        {
            "Alternative History",
            "Events",
            "Gameplay",
            "Graphics",
            "Historical",
            "Ideologies",
            "Map",
            "National Focuses",
            "Technologies",
            "Sound",
            "Translation"
        };

        /// <summary>
        /// ある文字とある文字で囲まれた文字列を取得
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string[] GetStringEnclosedByChar(string text, char startChar, char endChar)
        {
            var strings = new Regex(startChar + "(.+?)" + endChar).Matches(text);

            if (strings.Count == 0)
                return new string[] { };
            else
                return strings.Cast<Match>().Select(m => m.Value).ToArray();
        }

        public void CreateArray(string text)
        {
            var dataHanger = new FileData();
            string[] oneLines = text.Split('\n');
            dataHanger.Initialize();

            for (int i = 0; i < oneLines.Length; i++)
            {
                // 左辺="右辺"の形式で検索
                string[] matchedStrings = new Regex("(.+?)=\"(.+?)\"").Matches(oneLines[i]).Cast<Match>().Select(m => m.Value).ToArray();

                if (matchedStrings.Length != 2)
                    continue;

                for (int j = 0; j < keywords.Count; j++)
                {
                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "version"))
                    {
                        dataHanger.Version = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "name"))
                    {
                        dataHanger.Name = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "supported_version"))
                    {
                        dataHanger.SupportedVersion = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "picture"))
                    {
                        dataHanger.PicturePath = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "remote_file_id"))
                    {
                        dataHanger.RemoteFileID = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "path"))
                    {
                        dataHanger.ModPath = matchedStrings[1];
                        break;
                    }

                    if ((keywords[j] == matchedStrings[0]) && (matchedStrings[0] == "user_dir"))
                    {
                        dataHanger.UserDir = matchedStrings[1];
                        break;
                    }
                }

                if (matchedStrings[1] == "{")
                {
                    for (int j = 0; j < keywords.Count; j++)
                    {
                        // TODO
                    }
                }
            }
        }
    }

    class FileData
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public string SupportedVersion { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string PicturePath { get; set; }
        public List<string> ReplacePaths { get; set; } = new List<string>();
        public string RemoteFileID { get; set; }
        public string ModPath { get; set; }
        public string UserDir { get; set; }
        public List<string> Depondencies { get; set; } = new List<string>();

        public void Initialize()
        {
            Version = "";
            Name = "";
            SupportedVersion = "";
            Tags.Clear();
            PicturePath = "";
            ReplacePaths.Clear();
            RemoteFileID = "";
            ModPath = "";
            UserDir = "";
            Depondencies.Clear();

        }
    }

}
