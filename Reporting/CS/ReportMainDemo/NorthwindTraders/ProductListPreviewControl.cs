namespace XtraReportsDemos.NorthwindTraders {
    public class ProductListPreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new ProductListReport();
        }
    }
}

