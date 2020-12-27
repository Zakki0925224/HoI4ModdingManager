using System.IO;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;

namespace HoI4ModdingManager.Common.PageLayout
{
    class ResourceLoader
    {
        private static Assembly asm = Assembly.GetExecutingAssembly();

        public static ChromiumWebBrowser GetBrowser()
        {
            var result = new ChromiumWebBrowser("http://redering");
            result.RegisterResourceHandler("http://rendering/assets/css/bootstrap.min.css", GetStreamResource("HoI4ModdingManager.Common.PageLayout.assets.css.bootstrap.min.css"), "text/css");
            result.RegisterResourceHandler("http://rendering/assets/js/bootstrap.min.js", GetStreamResource("HoI4ModdingManager.Common.PageLayout.assets.js.bootstrap.min.js"), "text/javascript");

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
