using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;

namespace DevExpress.RealtorWorld.Win {
    public class BaseModule : XtraUserControl {
        internal bool FirstShowing = true;
        public virtual string ModuleCaption { get { return string.Empty; } }
        public virtual string ModuleName { get { return ModuleCaption; } }
        internal virtual void ShowModule(object item) {
            FirstShowing = false;
        }
        internal virtual void HideModule() { }
        internal virtual void InitModule(IDXMenuManager manager, object data) {
            SetMenuManager(this.Controls, manager);
        }

        void SetMenuManager(ControlCollection controlCollection, IDXMenuManager manager) {
            foreach(Control ctrl in controlCollection) {
                GridControl grid = ctrl as GridControl;
                if(grid != null) {
                    grid.MenuManager = manager;
                    break;
                }
                PivotGridControl pivot = ctrl as PivotGridControl;
                if(pivot != null) {
                    pivot.MenuManager = manager;
                    break;
                }
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) {
                    edit.MenuManager = manager;
                    break;
                }
                SetMenuManager(ctrl.Controls, manager);
            }
        }
        public virtual bool AllowWaitDialog { get { return true; } }
    }
}
