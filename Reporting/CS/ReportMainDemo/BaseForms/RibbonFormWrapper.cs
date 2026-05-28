using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using RibbonReportDesigner;

namespace XtraReportsDemos {
    class RibbonFormWrapper : IDesignForm {
        readonly MainFormBase wrappedForm;

        public Form Form {
            get { return wrappedForm; }
        }
        public XRDesignPanel ActiveXRDesignPanel {
            get { return wrappedForm.ActiveXRDesignPanel; }
        }
        public RibbonFormWrapper(bool useOldRibbonStyle) {
            if(useOldRibbonStyle)
                wrappedForm = new MainForm();
            else
                wrappedForm = new OfficeInspiredMainForm();
        }
        public void OpenReport(XtraReport newReport) {
            wrappedForm.OpenReport(newReport);
        }
    }
}
