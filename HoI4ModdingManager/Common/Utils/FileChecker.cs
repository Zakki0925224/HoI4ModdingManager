using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoI4ModdingManager.Common.Utils
{
    static class FileChecker
    {
        /// <summary>
        /// このファイルが使用可能かどうかを判定
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsThisFileCanUse(string filePath)
        {
            if (!StringChecker.IsThisFilePath(filePath))
                return false;

            // 拡張子
            string extension = ".hmp";

            if (!File.Exists(Path.GetFullPath(filePath)))
                return false;

            if (Path.GetExtension(Path.GetFullPath(filePath)) != extension)
                return false;

            return true;
        }
    }
}
