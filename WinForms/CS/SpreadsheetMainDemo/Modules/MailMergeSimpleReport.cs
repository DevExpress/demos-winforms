using System.Configuration;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class MailMergeSimpleReportModule : MailMergeModuleBase {
        protected override bool ShowFilterPanel { get { return false; } }
        protected override bool ShowParametersPanel { get { return true; } }

        protected override void LoadTemplate(SpreadsheetControl spreadsheetControl) {
            ConfigureConnectionString();
            IWorkbook book = spreadsheetControl.Document;
            book.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\\TableReportTemplate.xlsx"));
        }
        static void ConfigureConnectionString() {
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection csSection = config.ConnectionStrings;
            ConnectionStringSettings newSettings = new ConnectionStringSettings("nwindConnection", @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path, "System.Data.OleDb");
            csSection.ConnectionStrings.Add(newSettings);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        protected override void LoadData(IWorkbook book) { }

        protected override void HideComments(IWorkbook book, bool visible) {
            book.BeginUpdate();
            book.Worksheets[0].Rows[1].Visible = visible;
            book.Worksheets[0].Rows[2].Visible = visible;
            book.Worksheets[0].Rows[3].Visible = visible;
            book.Worksheets[0].Rows[4].Visible = visible;
            book.Worksheets[0].Rows[8].Visible = visible;
            book.Worksheets[0].Rows[9].Visible = visible;
            book.Worksheets[0].Rows[11].Visible = visible;
            book.Worksheets[0].Rows[12].Visible = visible;
            book.Worksheets[0].Rows[18].Visible = visible;
            book.EndUpdate();
        }
    }
}
