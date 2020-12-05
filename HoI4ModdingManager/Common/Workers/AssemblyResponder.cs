using System;
using System.Reflection;

namespace HoI4ModdingManager.Common.Workers
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
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
        }

        /// <summary>
        /// AssemblyCopyrightを返す
        /// </summary>
        /// <returns></returns>
        public string RespondAssemblyCopyright()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        }

        /// <summary>
        /// AssembryVersionを返す（string）
        /// </summary>
        /// <returns></returns>
        public string RespondAssembryVersion()
        {
            AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
            Version version = assemblyName.Version;
            return version.ToString();
        }

        /// <summary>
        /// AssembryVersionを返す（Versionクラス）
        /// </summary>
        /// <returns></returns>
        public Version RespondAssembryVersionRaw()
        {
            AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
            return assemblyName.Version;
        }
    }
}
