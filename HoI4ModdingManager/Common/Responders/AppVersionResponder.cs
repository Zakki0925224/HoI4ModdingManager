using System;

namespace HoI4ModdingManager.Common.Responders
{
    /// <summary>
    /// ソフトのバージョン情報を返す
    /// </summary>
    static class AppVersionResponder
    {
        /// <summary>
        /// AssembryVersionを取得
        /// </summary>
        /// <returns></returns>
        private static Version GetAssembryVersion()
        {
            return AssemblyResponder.RespondAssembryVersionRaw();
        }

        /// <summary>
        /// メジャーバージョンを返す
        /// </summary>
        /// <returns></returns>
        private static int RespondMajorVersion()
        {
            return GetAssembryVersion().Major;
        }

        /// <summary>
        /// マイナーバージョンを返す
        /// </summary>
        /// <returns></returns>
        private static int RespondMinorVersion()
        {
            return GetAssembryVersion().Minor;
        }

        /// <summary>
        /// ビルドバージョンを返す
        /// </summary>
        /// <returns></returns>
        private static int RespondBuildVersion()
        {
            return GetAssembryVersion().Build;
        }

        /// <summary>
        /// リビジョンバージョンを返す
        /// </summary>
        /// <returns></returns>
        private static int RespondRevisionVersion()
        {
            return GetAssembryVersion().Revision;
        }

        /// <summary>
        /// 通称バージョン（メジャー+マイナー）を返す
        /// </summary>
        /// <returns></returns>
        public static string RespondAliasVersion()
        {
            string aliasVersion = $"{RespondMajorVersion()}.{RespondMinorVersion()}";
            return aliasVersion;
        }

        /// <summary>
        /// AlphaまたはBetaを返す（それ以外は空文字を返す）
        /// </summary>
        /// <returns></returns>
        public static string RespondVersionType()
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
