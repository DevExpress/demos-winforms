using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraPdfViewer.Demos {
    public class DemosInfo : ModulesInfo {
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, RibbonMenuManager menuManager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                ViewerModule viewer = item.TModule as ViewerModule;
                viewer.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                viewer.Visible = false;
                groupControl.Controls.Add(viewer);
                viewer.Dock = DockStyle.Fill;
                viewer.RibbonMenuManager = menuManager;
                viewer.TutorialName = name;
                viewer.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null) {
                    oldTutorial.Visible = false;
                }
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }

    public static class DemoHelpers {
        public static Stream GetDocumentStream() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("Demo.pdf");
            if(stream == null)
                return assembly.GetManifestResourceStream("DevExpress.XtraPdfViewer.Demos.Data.Demo.pdf");
            return stream;
        }
    }
}
