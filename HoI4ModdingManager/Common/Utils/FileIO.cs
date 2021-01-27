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
                throw e;
            }
        }

        public static void OpenDataBaseFile(bool useDialog, string filePath = "")
        {
            if (useDialog)
                filePath = DialogProvider.ShowOpenFileDialog("HoI4 Modding Project (*.hmp)|*.hmp", "プロジェクトを開く...", true);

            if (filePath == "")
                return;

            if (!FileChecker.IsThisFileCanUse(filePath))
            {
                MessageBoxProvider.ShowErrorMessageBox("指定されたファイルは使用できません。");
                return;
            }
            else
            {
                ProcessCreater.CreateNewProcess(filePath);
            }

        }

        public static FileStream CreateFileStream(string filePath, FileMode fileMode, FileAccess fileAccess)
        {
            FileStream fs;

            try
            {
                fs = new FileStream(filePath, fileMode, fileAccess);
            }
            catch (Exception e) when (e is ArgumentNullException ||
                                          e is ArgumentException ||
                                          e is NotSupportedException ||
                                          e is FileNotFoundException ||
                                          e is IOException ||
                                          e is System.Security.SecurityException ||
                                          e is DirectoryNotFoundException ||
                                          e is UnauthorizedAccessException ||
                                          e is PathTooLongException ||
                                          e is ArgumentOutOfRangeException)
            {
                throw new Exception(e.Message);
            }

            return fs;
        }
    }
}
