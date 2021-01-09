using System;
using System.Reflection;

namespace HoI4ModdingManager.Common.Responders
{
    /// <summary>
    /// アプリケーションのアセンブリ情報を返す
    /// </summary>
    static class AssemblyResponder
    {
        /// <summary>
        /// AssemblyTitleを返す
        /// </summary>
        /// <returns></returns>
        public static string RespondAssemblyTitle()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
        }

        /// <summary>
        /// AssemblyCopyrightを返す
        /// </summary>
        /// <returns></returns>
        public static string RespondAssemblyCopyright()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        }

        /// <summary>
        /// AssembryVersionを返す（string）
        /// </summary>
        /// <returns></returns>
        public static string RespondAssembryVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            var version = assemblyName.Version;
            return version.ToString();
        }

        /// <summary>
        /// AssembryVersionを返す（Versionクラス）
        /// </summary>
        /// <returns></returns>
        public static Version RespondAssembryVersionRaw()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            return assemblyName.Version;
        }
    }
}
