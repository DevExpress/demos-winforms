using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.DrillThroughReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.DrillThroughReport.Report();
        }
    }
}

