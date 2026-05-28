using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace RibbonReportDesigner {
    public partial class OfficeInspiredMainForm : MainFormBase {
        public OfficeInspiredMainForm() {
            InitializeComponent();
        }

        public override XRDesignPanel ActiveXRDesignPanel { get { return reportDesigner1.ActiveDesignPanel; } }

        public override void OpenReport(XtraReport report) {
            reportDesigner1.OpenReport(report);
        }
    }
}
