using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoI4ModdingManager.ModdingProjectManager.ProjectImporter
{
    /// <summary>
    /// データベースファイルの整合性チェック
    /// </summary>
    class FileChecker
    {
        public static bool IsThisFileCanUse(string filePath)
        {
            // 拡張子
            string extension = ".hmp";

            if (!File.Exists(filePath))
                return false;

            if (Path.GetExtension(filePath) != extension)
                return false;

            return true;
        }
    }
}
