using System.Diagnostics;
using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Workers
{
    class ProcessCreater
    {
        /// <summary>
        /// 引数を指定して新規プロセスを開始
        /// </summary>
        /// <param name="filePath">開きたいファイルパス</param>
        public void CreateNewProcess(string filePath)
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = Application.ExecutablePath,
                Arguments = "\"" + filePath + "\""
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
