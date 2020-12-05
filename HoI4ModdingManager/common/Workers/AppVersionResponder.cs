using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoI4ModdingManager.Workers
{
    /// <summary>
    /// ソフトのバージョン情報を返す
    /// </summary>
    class AppVersionResponder
    {
        /// <summary>
        /// AssembryVersionを取得
        /// </summary>
        /// <returns></returns>
        private Version GetAssembryVersion()
        {
            AssemblyResponder ar = new AssemblyResponder();
            return ar.RespondAssembryVersionRaw();
        }

        /// <summary>
        /// メジャーバージョンを返す
        /// </summary>
        /// <returns></returns>
        private int RespondMajorVersion()
        {
            return GetAssembryVersion().Major;
        }

        /// <summary>
        /// マイナーバージョンを返す
        /// </summary>
        /// <returns></returns>
        private int RespondMinorVersion()
        {
            return GetAssembryVersion().Minor;
        }

        /// <summary>
        /// ビルドバージョンを返す
        /// </summary>
        /// <returns></returns>
        private int RespondBuildVersion()
        {
            return GetAssembryVersion().Build;
        }

        /// <summary>
        /// リビジョンバージョンを返す
        /// </summary>
        /// <returns></returns>
        private int RespondRevisionVersion()
        {
            return GetAssembryVersion().Revision;
        }

        /// <summary>
        /// 通称バージョン（メジャー+マイナー）を返す
        /// </summary>
        /// <returns></returns>
        public string RespondAliasVersion()
        {
            string aliasVersion = RespondMajorVersion().ToString() + "." + RespondMinorVersion().ToString();
            return aliasVersion;
        }

        /// <summary>
        /// AlphaまたはBetaを返す（それ以外は空文字を返す）
        /// </summary>
        /// <returns></returns>
        public string RespondVersionType()
        {
            switch (RespondAliasVersion())
            {
                case "0.1":
                    return "Alpha";

                default:
                    return "";
            }
        }
    }
}
