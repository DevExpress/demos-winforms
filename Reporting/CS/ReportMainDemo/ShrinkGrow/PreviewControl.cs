using DevExpress.XtraReports.UI;


namespace XtraReportsDemos.ShrinkGrow {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}

