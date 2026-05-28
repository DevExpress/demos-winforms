namespace XtraReportsDemos.NorthwindTraders {
    public class CatalogPreviewControl : ReportModule {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new CatalogReport();
        }
    }
}
