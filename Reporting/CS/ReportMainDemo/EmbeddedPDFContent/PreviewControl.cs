namespace XtraReportsDemos.EmbeddedPDFContent {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new XtraReportsDemos.EmbeddedPDFContent.Invoice();
        }
    }
}
