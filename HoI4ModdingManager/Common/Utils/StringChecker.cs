using HoI4ModdingManager.Common.Providers;
using System;
using System.IO;

namespace HoI4ModdingManager.Common.Utils
{
    static class StringChecker
    {
        private static char[] UnusableChars =
        {
            '\\',
            '/',
            ':',
            '*',
            '?',
            '\"',
            '<',
            '>',
            '|'
        };

        /// <summary>
        /// ファイル名に使用不能文字が使用されているか判定
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static bool IsUsingUnusableCharsInFileName(string fullPath)
        {
            if (!IsThisFilePath(fullPath))
                return true;

            string fileName = Path.GetFileNameWithoutExtension(Path.GetFullPath(fullPath));

            foreach (char unusableChar in UnusableChars)
            {
                if (fileName.IndexOf(unusableChar) != -1)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// 引数がファイルパスかどうかを判定
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsThisFilePath(string filePath)
        {
            try
            {
                Path.GetFullPath(filePath);
                return true;
            }
            catch (Exception e)
            {

                //throw e;
                MessageBoxProvider.ShowErrorMessageBox(e.Message);
                return false;
            }
        }
    }
}
