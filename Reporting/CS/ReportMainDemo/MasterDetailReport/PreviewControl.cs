using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.MasterDetailReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new MasterDetailReport.Report();
        }
    }
}

