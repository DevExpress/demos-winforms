namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HyperlinksModule : SpreadsheetRibbonTutorialControlBase {
        public HyperlinksModule() {
            InitializeComponent();

            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.Options.View.ShowPrintArea = false;
            spreadsheetControl1.Options.Print.PrintContent = SpreadsheetPrintContent.EntireWorkbook;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Hyperlinks_template.xlsx"));
        }
    }
}
