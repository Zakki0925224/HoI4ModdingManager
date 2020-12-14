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
        /// <param name="args">ファイルパス引数</param>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0)
                Application.Run(new ProjectDashBoard());
            else
                Application.Run(new ProjectDashBoard(args[0]));
        }
    }
}
