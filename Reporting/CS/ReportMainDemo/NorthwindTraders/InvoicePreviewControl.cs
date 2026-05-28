namespace XtraReportsDemos.NorthwindTraders {
    public class InvoicePreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new InvoiceReport();
        }
    }
}
