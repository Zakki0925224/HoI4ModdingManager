using HoI4ModdingManager.ModdingProjectManager.Forms;
using System;
using System.Windows.Forms;

namespace HoI4ModdingManager
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectEditor());
        }
    }
}
