using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CarryoverSummaryReport {
    public class PreviewControl : ReportModule {

        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.CarryoverSummaryReport.Report();
        }
    }
}
