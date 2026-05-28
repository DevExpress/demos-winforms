using System.Reflection;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraMap.Native;

namespace DevExpress.XtraMap.Demos {
    public class DemosInfo : ModulesInfo {
        static void UpdateModuleInfo(ModuleInfo item) {
            item.RecreateModuleIfNecessary(Assembly.GetCallingAssembly());
        }
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, RibbonMenuManager manager) {
            Cursor currentCursor = Cursor.Current;
            try {
                ModuleInfo item = DemosInfo.GetItem(name);
                TutorialControlBase tutorial = (TutorialControlBase)item.TModule;
                Cursor.Current = Cursors.WaitCursor;
                TutorialControlBase oldTutorial = null;

                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorial = MapModulesPool.GetPreviousModule() ?? (TutorialControlBase)Instance.CurrentModuleBase.TModule;
                }
                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                MapTutorialControl tc = tutorial as MapTutorialControl;
                if(tc != null) {
                    MapModulesPool.RegisterModule(tc);
                    UpdateModuleInfo(item);
                    tc.AppendOverlays();
                }
                manager.AllowExport(tc != null ? tc.MapControl : null);
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                Instance.CurrentModuleBase = item;

                if(oldTutorial != null) {
                    oldTutorial.Visible = false;
                    MapTutorialControl mapTutorialControl = oldTutorial as MapTutorialControl;
                    if(mapTutorialControl != null)
                        MapUtils.ReleaseMapHandle(mapTutorialControl.MapControl);
                }
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}
