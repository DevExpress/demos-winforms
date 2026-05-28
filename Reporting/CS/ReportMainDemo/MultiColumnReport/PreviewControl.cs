using DevExpress.XtraReports.UI;


namespace XtraReportsDemos.MultiColumnReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}

