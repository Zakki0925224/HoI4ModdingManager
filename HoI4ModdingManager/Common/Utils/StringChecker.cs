using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            string fileName = Path.GetFileNameWithoutExtension(Path.GetFullPath(fullPath));

            foreach (char unusableChar in UnusableChars)
            {
                if (fileName.IndexOf(unusableChar) != -1)
                    return true;
            }

            return false;
        }
    }
}
