using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;

namespace DevExpress.XtraGantt.Demos {
    public class DemosInfo : ModulesInfo {
        static TreeList GetTreeListByControl(Control control) {
            if(control == null) return null;
            foreach(Control cntl in control.Controls)
                if(cntl is TreeList)
                    return (TreeList)cntl;
            return null;
        }
        public static void CloseCustomizationForm(Control control) {
            TreeList treeList = GetTreeListByControl(control);
            if(treeList != null)
                treeList.DestroyCustomization();
        }
        //
        public static void ShowModule(string name, GroupControl group, GanttRibbonMenuManager manager) {
            if(Instance != null && Instance.CurrentModuleBase != null) {
                var tControl = Instance.CurrentModuleBase.TModule as TutorialControl;
                if(tControl != null && tControl.IsActiveDemo)
                    return;
            }
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorialControl = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    oldTutorialControl = Instance.CurrentModuleBase.TModule;
                }
                CloseCustomizationForm(oldTutorialControl);
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
                    manager.AllowExport(tc.AllowPrintOptions ? tc.MainControl : null);
                    manager.AllowShowCriticalPath(tc.AllowShowCriticalPath ? tc.MainControl : null);
                    manager.RefreshViewMenu(tc.MainControl);
                } else {
                    manager.RefreshViewMenu(null);
                }

                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorialControl != null)
                    oldTutorialControl.Visible = false;
                RaiseModuleChanged();
            }
            finally { Cursor.Current = currentCursor; }
        }
    }
}
