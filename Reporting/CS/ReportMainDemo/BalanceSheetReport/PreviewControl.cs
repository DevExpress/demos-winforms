using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.BalanceSheetReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}
