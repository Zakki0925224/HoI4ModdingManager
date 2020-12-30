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

        }
    }
}
