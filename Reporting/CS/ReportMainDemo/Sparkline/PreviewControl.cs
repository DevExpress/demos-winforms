namespace XtraReportsDemos.Sparkline {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new Report();
        }
    }
}
