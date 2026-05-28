using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CalculatedFieldsReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.CalculatedFieldsReport.Report();
        }
    }
}
