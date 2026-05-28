using DevExpress.XtraReports.UserDesigner;

namespace RibbonReportDesigner {
    public partial class MainForm : MainFormBase {
        public MainForm() {
            InitializeComponent();
        }
        public override XRDesignPanel ActiveXRDesignPanel {
            get { return reportDesigner1.ActiveDesignPanel; }
        }
        public override void OpenReport(DevExpress.XtraReports.UI.XtraReport newReport) {
            reportDesigner1.OpenReport(newReport);
        }
        public void CreateNewReport() {
            reportDesigner1.CreateNewReport();
        }
    }
}
