using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HoI4ModdingManager.Workers
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
        /// AssembryVersionを返す
        /// </summary>
        /// <returns></returns>
        public string RespondAssembryVersion()
        {
            AssemblyName assemblyName = Assembly.GetExecutingAssembly().GetName();
            Version version = assemblyName.Version;
            return version.ToString();
        }
    }
}
