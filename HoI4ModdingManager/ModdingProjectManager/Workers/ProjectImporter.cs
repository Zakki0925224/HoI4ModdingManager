using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HoI4ModdingManager.Common.Workers;

namespace HoI4ModdingManager.ModdingProjectManager.Workers
{
    class ProjectImporter
    {
        /// <summary>
        /// プロジェクトのインポート
        /// </summary>
        /// <param name="filePath"></param>
        public void Import(string filePath)
        {
            MessageBoxShower mbs = new MessageBoxShower();

            if (!File.Exists(filePath))
            {
                mbs.ErrorMessage("ファイル\"" + filePath + "\"は存在しません。");
                return;
            }

            if (Path.GetExtension(filePath) != ".hmp")
            {
                mbs.ErrorMessage("この種類のファイルを開くことはできません。");
                return;
            }
        }
    }
}
