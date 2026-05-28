using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public class TutorialControl : TutorialControlBase, IDXMenuManager {
        public TutorialControl() {
            AutoMergeRibbon = true;
            RichEditDemoExceptionsHandler exceptionHandler = new RichEditDemoExceptionsHandler(RichEdit);
            exceptionHandler.Install();
        }
        public virtual RichEditControl RichEdit {
            get { return null; }
        }
        protected void LoadDocument(string fileName) {
            string path = DemoUtils.GetRelativePath(fileName);
            if(!string.IsNullOrEmpty(path))
                RichEdit.LoadDocument(path);
        }
        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, this, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) {
            return this;
        }
        void IDXMenuManager.DisposeManager() { }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            RichEditControl control = ctrl as RichEditControl;
            if(control != null) control.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        protected override void DoShow() {
            base.DoShow();
            if(RichEdit != null) {
                RichEdit.ReplaceService<IUserAccountService>(new UserAccountService());
                RichEdit.Select();
            }
        }
        //
        sealed class UserAccountService : IUserAccountService {
            static string userName;
            string IUserAccountService.GetUserName() {
                return userName ?? (userName = GetCurrentUserName());
            }
            string GetCurrentUserName() {
                try {
                    return SystemInformation.UserName;
                }
                catch { return null; }
            }
        }
    }
}
