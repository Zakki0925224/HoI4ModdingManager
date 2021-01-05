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
        List<string> keywords = new List<string>()
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

        List<string> tags = new List<string>()
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
                return null;
            else
                return strings.Cast<Match>().Select(m => m.Value).ToArray();
        }

        public List<string> CreateArray(string text)
        {
            char[] chars = text.ToCharArray();
            var content = new List<string>();
            var sb = new StringBuilder();

            foreach (char achar in chars)
            {
                if (achar != '\n')
                {
                    sb.Append(achar);
                }
                else
                {
                    content.Add(sb.ToString());
                    sb.Clear();
                }
            }

            return content;
        }
    }
}
