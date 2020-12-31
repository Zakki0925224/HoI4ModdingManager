using HoI4ModdingManager.Common.Providers;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HoI4ModdingManager.ModManager.ModImporter
{
    class ModLoader
    {
        /// <summary>
        /// ロードされたmodが使用可能かどうか
        /// </summary>
        private bool IsAvailable { get; set; }

        /// <summary>
        /// ローカルmodかどうか
        /// </summary>
        private bool IsLocalMod { get; set; }

        /// <summary>
        /// steamのmodかどうか
        /// steamのmodだった場合編集保護をかける
        /// </summary>
        private bool IsSteamMod { get; set; }

        /// <summary>
        /// C:\Users\<User>\Documents\Paradox Interactive\Hearts of Iron IV\mod\
        /// 内の.modファイルをロードしたときのチェック
        /// </summary>
        private void DotModFileChecker(string filePath)
        {
            if (!File.Exists(filePath))
            {
                IsAvailable = false;
                // error message
                return;
            }

            if (Path.GetExtension(filePath) != ".mod")
            {
                IsAvailable = false;
                // error message
                return;
            }

            IsAvailable = true;

            if (Regex.IsMatch(Path.GetFileNameWithoutExtension(filePath), "ugc_"))
            {
                IsSteamMod = true;
                IsLocalMod = false;
            }
            else
            {
                IsSteamMod = false;
                IsLocalMod = true;
            }
        }

        /// <summary>
        /// BOM付きかどうかを判別
        /// </summary>
        private bool ExitsBOM(byte[] bytes)
        {
            // UTF-8 with BOM
            if ((bytes[0] == 0xef) && (bytes[1] == 0xbb) && (bytes[2] == 0xbf))
                return true;

            else
                return false;
        }

        /// <summary>
        /// .modファイルの中身を取得
        /// </summary>
        private void ReadDotModFile(string filePath)
        {
            if (!IsAvailable)
                return;

            string content = null;

            using (var sr = new StreamReader(filePath))
            {
                try
                {
                    content = sr.ReadToEnd();
                }
                catch (Exception e) when (e is OutOfMemoryException ||
                                          e is IOException)
                {
                    MessageBoxProvider.ShowErrorMessageBox(e.Message);
                    return;
                }
            }

            if (content == null)
            {
                // ぬるぽ
                //error message
                return;
            }

            if (ExitsBOM(Encoding.UTF8.GetBytes(content)))
            {
                // bomがついてたらだめなやーつ
                // error message
                return;
            }

            // 一行ずつデータを取得
            string[] contents = content.Split('\n');

            string version;
            string[] tags;
            string name;
            string supported_version;
            string path;
            string[] replace_path;
            string[] dependencies;
            string picture;
            string remote_file_id;

            foreach (string str in contents)
            {
                // version
                if (Regex.IsMatch(str, "version="))
                {
                    // ""で囲まれた文字列を取得
                    var matches = new Regex("\"(.+?)\"").Matches(str);

                    if (matches.Count == 1)
                    {
                        version = matches[0].Value;
                        // この行での処理は終了したので次の行へ
                        continue;
                    }
                    else
                    {
                        // 構文エラー
                        MessageBoxProvider.ShowErrorMessageBox("構文エラー");
                    }
                }

                // name
                if (Regex.IsMatch(str, "name="))
                {
                    var matches = new Regex("\"(.+?)\"").Matches(str);

                    if (matches.Count == 1)
                    {
                        name = matches[0].Value;
                        continue;
                    }
                    else
                    {
                        MessageBoxProvider.ShowErrorMessageBox("構文エラー");
                    }
                }
            }
        }
    }
}
