namespace XtraReportsDemos.PdfVisualSignature {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new XtraReportsDemos.PdfVisualSignature.Report();
        }
    }
}
