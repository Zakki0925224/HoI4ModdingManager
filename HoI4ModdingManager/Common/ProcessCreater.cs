using System.Diagnostics;
using System.Windows.Forms;

namespace HoI4ModdingManager.Common
{
    class ProcessCreater
    {
        /// <summary>
        /// 引数を指定して新規プロセスを開始
        /// </summary>
        /// <param name="filePath">開きたいファイルパス</param>
        public void CreateNewProcess(string filePath)
        {
            var psi = new ProcessStartInfo()
            {
                FileName = Application.ExecutablePath,
                Arguments = $"\"{filePath}\""
            };
            Process.Start(psi);
        }
    }
}
