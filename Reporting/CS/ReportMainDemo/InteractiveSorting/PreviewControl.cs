using DevExpress.XtraReports.UI;


namespace XtraReportsDemos.InteractiveSorting {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}

