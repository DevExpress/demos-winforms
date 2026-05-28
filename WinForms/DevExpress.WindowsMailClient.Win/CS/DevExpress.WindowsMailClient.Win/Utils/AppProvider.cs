using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraSplashScreen;

namespace DevExpress.WindowsMailClient.Win.Utils {
    static class AppProvider {
        public static void ProcessStart(string name) {
            ProcessStart(name, string.Empty);
        }
        public static void ProcessStart(string name, string arguments) {
            try {
                DevExpress.Data.Utils.SafeProcess.Start(name, setup: x => {
                    x.Arguments = arguments;
                    x.Verb = "Open";
                    x.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                });
            }
            catch(System.ComponentModel.Win32Exception) { }
        }
        public static string ApplicationID {
            get { return string.Format("Components_{0}_Demo_Center_{0}", AssemblyInfo.VersionShort.Replace(".", "_")); }
        }
        public static Icon AppIcon {
            get { return ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.WindowsMailClient.Win.AppIcon.ico", Assembly.GetExecutingAssembly()); }
        }
        static Image img;
        public static Image AppImage {
            get {
                if(img == null)
                    img = AppIcon.ToBitmap();
                return img;
            }
        }

        static WeakReference wRef;
        public static MainForm MainForm {
            get { return (wRef != null) ? wRef.Target as MainForm : null; }
            set { wRef = new WeakReference(value); }
        }
        public static float GetDefaultSize() {
            return 8.25F;
        }
        internal static IOverlaySplashScreenHandle ShowProgressPanel(Control owner, OverlayWindowOptions windowOptions = null) {
            IOverlaySplashScreenHandle handle = null;
            try {
                handle = SplashScreenManager.ShowOverlayForm(owner ?? MainForm, windowOptions ?? OverlayWindowOptions.Default);
            }
            catch {
            }
            return handle;
        }
        internal static void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            try {
                SplashScreenManager.CloseOverlayForm(handle);
            }
            catch {
            }
        }
    }
}
