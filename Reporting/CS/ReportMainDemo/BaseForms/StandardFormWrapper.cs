using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace XtraReportsDemos {
    class StandardFormWrapper : IDesignForm {
        readonly ReportDesigner.MainForm wrappedForm;

        public Form Form {
            get { return wrappedForm; }
        }
        public XRDesignPanel ActiveXRDesignPanel {
            get { return wrappedForm.ActiveXRDesignPanel; }
        }
        public StandardFormWrapper() {
            wrappedForm = new ReportDesigner.MainForm();
        }
        public void OpenReport(XtraReport newReport) {
            wrappedForm.OpenReport(newReport);
        }
    }
}
