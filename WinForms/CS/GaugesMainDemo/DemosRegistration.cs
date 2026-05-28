using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGauges.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                manager.AllowExport(null);

                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;

                TutorialControl gaugeTutorial = item.TModule as TutorialControl;
                if(gaugeTutorial != null) {
                    if(gaugeTutorial.ShowExportMenu) {
                        manager.AllowExport(gaugeTutorial.ExportControl);
                    }
                    else manager.AllowExport(null);
                }
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}
