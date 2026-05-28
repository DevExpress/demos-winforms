using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.DrillDownReport {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.DrillDownReport.DrillDownReport();
        }
    }
}

