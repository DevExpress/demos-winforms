using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets.FallCatalogDataSetTableAdapters;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeFallCatalogModule : MailMergeModuleBase {
        protected override void LoadTemplate(SpreadsheetControl spreadsheetControl) {
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\\FallCatalogTemplate.xlsx"));
        }
        protected override void LoadData(IWorkbook book) {
            FallCatalogDataSet dataSet = new FallCatalogDataSet();
            Order_DetailsTableAdapter orderDetailsAdapter = new Order_DetailsTableAdapter();
            orderDetailsAdapter.Fill(dataSet.Order_Details);
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            productsAdapter.Fill(dataSet.Products);
            book.MailMergeDataSource = dataSet;
            book.MailMergeDataMember = "Products";
        }
        protected override bool ShowHideCommentsItem {
            get { return false; }
        }
        protected override bool ShowFilterPanel {
            get { return false; }
        }
    }
}
