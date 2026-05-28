using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.MailClient.Win {
    internal static class UnpackHelper {
        static string Arabic = "ar";
        static string ArabicResource = ".ar.";
        static string Farsi = "fa";
        static string FarsiResource = ".fa.";
        static string Hebrew = "he";
        static string HebrewResource = ".he.";
        //
        internal static void Unpack() {
            try {
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                DirectoryInfo startPath = new DirectoryInfo(Application.StartupPath);
                if(!Directory.Exists(Path.Combine(startPath.ToString(), Arabic)))
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Arabic));
                if(!Directory.Exists(Path.Combine(startPath.ToString(), Farsi)))
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Farsi));
                if(!Directory.Exists(Path.Combine(startPath.ToString(), Hebrew)))
                    Directory.CreateDirectory(Path.Combine(startPath.ToString(), Hebrew));
                string[] resources = executingAssembly.GetManifestResourceNames();
                foreach(string resource in resources) {
                    if(!resource.EndsWith("resources.dll"))
                        continue;
                    CreateResourceIfNeed(executingAssembly, startPath, resource, ArabicResource, Arabic);
                    CreateResourceIfNeed(executingAssembly, startPath, resource, FarsiResource, Farsi);
                    CreateResourceIfNeed(executingAssembly, startPath, resource, HebrewResource, Hebrew);
                }
            }
            catch { }
        }
        static void CreateResourceIfNeed(Assembly executingAssembly, DirectoryInfo startPath, string resource, string resourcePrefix, string resourceLanguagePrefix) {
            if(resource.Contains(resourcePrefix)) {
                string fileName = resource.Remove(0, resource.LastIndexOf(resourcePrefix) + resourcePrefix.Length);
                string langPath = Path.Combine(startPath.ToString(), resourceLanguagePrefix);
                string fullPath = Path.Combine(langPath, fileName);
                using(FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
                    executingAssembly.GetManifestResourceStream(resource).CopyTo(fs);
            }
        }
    }
}
