using System.IO;

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
