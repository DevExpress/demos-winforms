using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevExpress.XtraRichEdit.Demos {
    public class RichEditDemoExceptionsHandler {
        readonly RichEditControl control;

        public RichEditDemoExceptionsHandler(RichEditControl control) {
            this.control = control;
        }
        public void Install() {
            if(control != null)
                control.UnhandledException += OnRichEditControlUnhandledException;
        }
        protected virtual void OnRichEditControlUnhandledException(object sender, RichEditUnhandledExceptionEventArgs e) {
            try {
                if(e.Exception != null)
                    throw e.Exception;
            }
            catch(RichEditUnsupportedFormatException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch(ExternalException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch(System.IO.IOException ex) {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
