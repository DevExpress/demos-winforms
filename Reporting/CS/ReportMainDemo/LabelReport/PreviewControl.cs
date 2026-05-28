namespace XtraReportsDemos.LabelReport {
    public class PreviewControl : ReportModule {
        protected override void OnSetViewer() {
            Viewer.SetPageView(2, 1);
        }
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new ProductLabelsReport();
        }
    }
}
