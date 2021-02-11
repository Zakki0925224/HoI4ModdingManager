using HoI4ModdingManager.Common.Providers;
using System;
using System.IO;

namespace HoI4ModdingManager.Common.Utils
{
    static class FileIO
    {
        public static void CreateNewDataBaseFile(string filePath)
        {
            if (StringChecker.IsUsingUnusableCharsInFileName(filePath))
                throw new Exception();

            if (Path.GetExtension(filePath) != ".hmp")
                throw new Exception();

            try
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBoxProvider.ShowErrorMessageBox(e.Message);
                throw e;
            }
        }

        public static string OpenDataBaseFile(bool useDialog, string filePath = "")
        {
            if (useDialog)
                filePath = DialogProvider.ShowOpenFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

            if (filePath == "")
                return "";

            if (!FileChecker.IsThisFileCanUse(filePath))
            {
                MessageBoxProvider.ShowErrorMessageBox("指定されたファイルは使用できません。");
                return "";
            }
            else
            {
                return filePath;
            }

        }

        public static FileStream CreateFileStream(string filePath, FileMode fileMode, FileAccess fileAccess)
        {
            FileStream fs;

            try
            {
                fs = new FileStream(filePath, fileMode, fileAccess);
            }
            catch (Exception e)
            {
                MessageBoxProvider.ShowErrorMessageBox(e.Message);
                throw e;
            }

            return fs;
        }
    }
}
