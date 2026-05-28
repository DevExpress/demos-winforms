using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets;
using DevExpress.XtraSpreadsheet.Demos.Modules.MailMergeDataSets.InvoiceDataSetTableAdapters;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeInvoiceModule : MailMergeModuleBase {
        protected override void LoadTemplate(SpreadsheetControl spreadsheetControl) {
            spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\\InvoiceTemplate.xlsx"));
        }
        protected override void LoadData(IWorkbook book) {
            InvoiceDataSet dataSet = new InvoiceDataSet();
            InvoicesTableAdapter invoicesTableAdapter = new InvoicesTableAdapter();
            invoicesTableAdapter.Fill(dataSet.Invoices);
            book.MailMergeDataSource = dataSet;
            book.MailMergeDataMember = "Invoices";
        }
        protected override bool ShowHideCommentsItem {
            get { return false; }
        }
        protected override bool ShowFilterPanel {
            get { return false; }
        }
    }
}
