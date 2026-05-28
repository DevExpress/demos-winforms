using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets.MasterDetailDataSetTableAdapters;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeMasterDetailModule : MailMergeModuleBase {
        protected override void LoadTemplate(SpreadsheetControl spreadsheetControl) {
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\\MasterDetailTemplate.xlsx"));
        }
        protected override void LoadData(IWorkbook book) {
            MasterDetailDataSet dataSet = new MasterDetailDataSet();
            SuppliersTableAdapter adapter = new SuppliersTableAdapter();
            adapter.Fill(dataSet.Suppliers);
            OrderDetailsTableAdapter orderDetailsAdapter = new OrderDetailsTableAdapter();
            orderDetailsAdapter.Fill(dataSet.OrderDetails);
            ProductsTableAdapter productsAdapter = new ProductsTableAdapter();
            productsAdapter.Fill(dataSet.Products);
            book.MailMergeDataSource = dataSet;
            book.MailMergeDataMember = "Suppliers";
        }
        protected override bool ShowHideCommentsItem {
            get { return false; }
        }
        protected override bool ShowFilterPanel {
            get { return false; }
        }
    }
}
