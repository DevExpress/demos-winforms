using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.Charts {
    public class PreviewControl : ReportModule {
        protected override void OnSetViewer() {
            Viewer.SetPageView(2, 1);
        }
        protected override XtraReport CreateReport() {
            return new Charts.Report();
        }
    }
}
