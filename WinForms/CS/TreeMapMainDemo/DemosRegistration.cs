using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeMap.Demos {
    public class DemosInfo : ModulesInfo {
        public static void DoShowModule(string name, GroupControl group, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                Instance.CurrentModuleBase = item;
                TutorialControlBase tutorialBase = item.TModule as TutorialControlBase;
                tutorialBase.Bounds = group.DisplayRectangle;
                tutorialBase.Visible = false;
                group.Controls.Add(tutorialBase);
                tutorialBase.Dock = DockStyle.Fill;
                tutorialBase.RibbonMenuManager = manager;
                tutorialBase.TutorialName = name;
                tutorialBase.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
                TreeMapTutorialControl treeMapTutorial = tutorialBase as TreeMapTutorialControl;
                if(treeMapTutorial != null) {
                    manager.AllowExport(treeMapTutorial.ActiveDemoModule);
                }
            }
            catch { }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}
