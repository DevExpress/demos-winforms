using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;

namespace DevExpress.SalesDemo.Win.Modules {
    public class BaseModule : XtraUserControl, ISupportNavigation {
        public virtual void Init(BarManager menuManager) { }
        #region ISupportNavigation Members
        public virtual void OnNavigatedFrom(INavigationArgs args) { }
        public virtual void OnNavigatedTo(INavigationArgs args) { }
        #endregion
    }
}
