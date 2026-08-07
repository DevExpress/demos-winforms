using System;
using DevExpress.XtraPrinting;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class SpreadsheetModule : BaseModule {
        const string FileName = "LoanCalculator.xlsx";

        public SpreadsheetModule() {
            InitializeComponent();
            string filePath = DemoUtils.GetRelativePath(FileName);
            if(String.IsNullOrEmpty(filePath))
                return;
            this.spreadsheetControl1.LoadDocument(filePath);
        }

        protected override bool AutoMergeRibbon { get { return true; } }
        public override IPrintable PrintableComponent { get { return spreadsheetControl1; } }
        public override IPrintable ExportComponent { get { return spreadsheetControl1; } }
        public override bool AllowRtfTitle { get { return false; } }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name);
        }

    }
}
