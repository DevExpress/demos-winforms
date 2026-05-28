using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.ReportMerging {
    public class PreviewControl : ReportModule {
        protected override void OnSetViewer() {
            Viewer.SetPageView(3, 2);
        }
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.ReportMerging.MergedReport();
        }
    }
}
