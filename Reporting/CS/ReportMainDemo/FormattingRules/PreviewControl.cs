using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.FormattingRules {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.FormattingRules.Report();
        }
    }
}
