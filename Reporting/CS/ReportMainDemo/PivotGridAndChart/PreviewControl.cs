namespace XtraReportsDemos.PivotGridAndChart {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new XtraReportsDemos.PivotGridAndChart.Report();
        }
    }
}
