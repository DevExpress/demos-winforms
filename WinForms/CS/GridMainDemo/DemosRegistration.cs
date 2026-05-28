using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace DevExpress.XtraGrid.Demos {
    public class DemosInfo : ModulesInfo {
        static BaseView GetBaseViewByControl(Control control) {
            if(control == null) return null;
            foreach(GridControl grid in control.Controls.OfType<GridControl>())
                return grid.MainView;
            //due latest changes within demos - need to do it recursive
            return CheckControl(control, true);
        }
        static BaseView CheckControl(Control cntl, bool checkChildren) {
            if(cntl is GridControl)
                return ((GridControl)cntl).MainView;
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
            BaseView view = GetBaseViewByControl(control);
            if(view == null) return;
            foreach(GridView gv in view.GridControl.ViewCollection.OfType<GridView>())
                gv.DestroyCustomization();
        }
        static void UpdateOptions(Control control) {
            if(control == null)
                return;
            foreach(Control ctrl in control.Controls)
                UpdateOptions(ctrl);
            BaseView view = GetBaseViewByControl(control);
            if(view == null) return;
            view.GridControl.ViewCollection.OfType<GridView>().ToList().
                ForEach(v => v.OptionsCustomization.UseAdvancedCustomizationForm = Utils.DefaultBoolean.True);
        }
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, GridRibbonMenuManager manager) {
            if(Instance.CurrentModuleBase != null)
                if(Instance.CurrentModuleBase.TModule is TutorialControl && ((TutorialControl)Instance.CurrentModuleBase.TModule).IsActiveDemo) return;
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
                if(ctc != null) ctc.SelectExampleByName(item.CodeExampleName);
                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                TutorialControl tc = item.TModule as TutorialControl;
                CloseCustomizationForm(oldTutorial);
                UpdateOptions(tutorial);
                if(tc != null) {
                    manager.AllowExport(tc.ExportView);
                    manager.RefreshOptionsMenu(tc.ShowViewOptions ? GetBaseViewByControl(tutorial) : null);
                }
                else {
                    manager.AllowExport(null);
                    manager.RefreshOptionsMenu(null);
                }
                manager.InitBlendingMenu(null);
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Visible = true;
                item.WasShown = true;
				if(oldTutorial != null) {
					oldTutorial.Visible = false;
					oldTutorial.Parent = null;
				}
            }
            finally { Cursor.Current = currentCursor; }
            RaiseModuleChanged();
        }
    }
}
