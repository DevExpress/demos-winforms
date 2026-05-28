using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.XtraTreeList.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, TreeListRibbonMenuManager manager) {
            ModuleInfo _item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                CodeTutorialControlBase ctcb = _item.TModule as CodeTutorialControlBase;
                if(ctcb != null) 
                    ctcb.SelectExampleByName(_item.CodeExampleName);

                TutorialControlBase tutorial = _item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = _item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = _item.TModule as TutorialControl;
                CloseCustomizationForm(oldTutorial);
                UpdateOptions(tutorial);
                if(tc != null) {
                    manager.AllowExport(tc.AllowPrintOptions ? tc.MainControl : null);
                    manager.RefreshOptionsMenu(tc);
                }
                else {
                    manager.AllowExport(null);
                    manager.RefreshOptionsMenu(null);
                }
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                _item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
        static TreeList GetTreeList(Control control) {
            if(control == null) return null;
            foreach(TreeList TreeList in control.Controls.OfType<TreeList>())
                return TreeList;
            //due latest changes within demos - need to do it recursive
            return CheckControl(control, true);
        }
        static TreeList CheckControl(Control cntl, bool checkChildren) {
            if(cntl is TreeList)
                return (TreeList)cntl;
            if(!checkChildren) return null;
            foreach(Control c in cntl.Controls) {
                var res = CheckControl(c, checkChildren);
                if(res != null) return res;
            }
            return null;
        }
        static void CloseCustomizationForm(Control control) {
            if(control == null)
                return;
            foreach(Control ctrl in control.Controls)
                CloseCustomizationForm(ctrl);
            TreeList treeList = GetTreeList(control);
            if(treeList == null) return;
            treeList.DestroyCustomization();
        }
        static void UpdateOptions(Control control) {
            if(control == null)
                return;
            foreach(Control ctrl in control.Controls)
                UpdateOptions(ctrl);
            TreeList treeList = GetTreeList(control);
            if(treeList == null) return;
            treeList.OptionsCustomization.UseAdvancedCustomizationForm = Utils.DefaultBoolean.True;
        }
    }
}
