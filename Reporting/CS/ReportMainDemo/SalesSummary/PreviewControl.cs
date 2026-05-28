using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.SalesSummary {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}

