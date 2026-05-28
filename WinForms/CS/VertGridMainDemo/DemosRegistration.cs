using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, VGridRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                CodeTutorialControlBase ctc = item.TModule as CodeTutorialControlBase;
                if(ctc != null) 
                    ctc.SelectExampleByName(item.CodeExampleName);

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = item.TModule as TutorialControl;
                if(tc != null) {
                    manager.AllowExport(tc.ExportControl);
                    manager.RefreshOptionsMenu(tc.ViewOptionsControl);
                }
                else {
                    manager.AllowExport(null);
                    manager.RefreshOptionsMenu(null);
                }

                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
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
