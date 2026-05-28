using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.Subreports {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new MasterReport();
        }
    }
}

