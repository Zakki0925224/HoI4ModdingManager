using System;
using System.Reflection;

namespace HoI4ModdingManager.Common.Responders
{
    /// <summary>
    /// アプリケーションのアセンブリ情報を返す
    /// </summary>
    class AssemblyResponder
    {
        /// <summary>
        /// AssemblyTitleを返す
        /// </summary>
        /// <returns></returns>
        public string RespondAssemblyTitle()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
        }

        /// <summary>
        /// AssemblyCopyrightを返す
        /// </summary>
        /// <returns></returns>
        public string RespondAssemblyCopyright()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        }

        /// <summary>
        /// AssembryVersionを返す（string）
        /// </summary>
        /// <returns></returns>
        public string RespondAssembryVersion()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            var version = assemblyName.Version;
            return version.ToString();
        }

        /// <summary>
        /// AssembryVersionを返す（Versionクラス）
        /// </summary>
        /// <returns></returns>
        public Version RespondAssembryVersionRaw()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            return assemblyName.Version;
        }
    }
}
