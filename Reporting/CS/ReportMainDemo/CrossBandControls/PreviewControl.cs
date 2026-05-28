using DevExpress.XtraReports.UI;


namespace XtraReportsDemos.CrossBandControls {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}
