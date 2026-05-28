using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.IListDataSource {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
    }
}

