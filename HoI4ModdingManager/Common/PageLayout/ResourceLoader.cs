using System.IO;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;

namespace HoI4ModdingManager.Common.PageLayout
{
    /// <summary>
    /// ブラウザのリソースをロード
    /// </summary>
    class ResourceLoader
    {
        private static Assembly asm = Assembly.GetExecutingAssembly();

        public static ChromiumWebBrowser GetBrowser()
        {
            var result = new ChromiumWebBrowser("http://hmm");
            // 自作
            result.RegisterResourceHandler("http://hmm/assets/css/dashboard.css", GetStreamResource("HoI4ModdingManager.Common.PageLayout.assets.css.dashboard.css"), "text/css");
            result.RegisterResourceHandler("http://hmm/assets/js/dashboard.js", GetStreamResource("HoI4ModdingManager.Common.PageLayout.assets.js.dashboard.js"), "text/javascript");

            return result;
        }

        public static Stream GetStreamResource(string name)
        {
            return asm.GetManifestResourceStream(name);
        }

        public static string GetStringResource(string name)
        {
            string text = string.Empty;
            using (var reader = new StreamReader(asm.GetManifestResourceStream(name)))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}
