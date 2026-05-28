namespace XtraReportsDemos.SwissQRCode {
    public class PreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new SwissQRBill();
        }
    }
}

