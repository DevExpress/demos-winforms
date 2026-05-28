namespace XtraReportsDemos.CrossBandContent {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new Report();
        }
    }
}
