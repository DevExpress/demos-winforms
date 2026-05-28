using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class FirstLookModule : SpreadsheetRibbonTutorialControlBase {
        public FirstLookModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("InvestmentPortfolio.xltx"));
            spreadsheetControl1.InvalidFormatException += SpreadsheetControl1_InvalidFormatException;
            spreadsheetControl1.DocumentClosing += SpreadsheetControl1_DocumentClosing;
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return homeRibbonPage1;
            }
        }

        private void SpreadsheetControl1_InvalidFormatException(object sender, SpreadsheetInvalidFormatExceptionEventArgs e) {
            XtraMessageBox.Show(string.Format("Cannot open the file '{0}' because the file format or file extension is not valid.\n" +
                "Verify that file has not been corrupted and that the file extension matches the format of the file.", e.SourceUri),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SpreadsheetControl1_DocumentClosing(object sender, CancelEventArgs e) {
            if(spreadsheetControl1.Modified) {
                string currentFileName = spreadsheetControl1.Options.Save.CurrentFileName;
                string message = !string.IsNullOrEmpty(currentFileName) ?
                    string.Format("Do you want to save the changes you made for '{0}'?", currentFileName) :
                    "Do you want to save the changes?";
                DialogResult result = XtraMessageBox.Show(message, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                    e.Cancel = !spreadsheetControl1.SaveDocument();
                else
                    e.Cancel = result == DialogResult.Cancel;
            }
        }
    }
}
