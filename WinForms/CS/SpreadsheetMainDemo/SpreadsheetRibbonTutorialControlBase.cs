using System;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SpreadsheetRibbonTutorialControlBase : SpreadSheetTutorialControlBase {
        public SpreadsheetRibbonTutorialControlBase() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.Options.View.Charts.Antialiasing = DocumentCapability.Enabled;
            spreadsheetControl1.Options.View.Charts.TextAntialiasing = DocumentCapability.Enabled;
        }

        protected internal virtual RibbonPage SelectedRibbonPage {
            get {
                return homeRibbonPage1;
            }
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RibbonPage selectedPage = SelectedRibbonPage;
            if(selectedPage != null)
                ribbonControl1.SelectedPage = selectedPage;
        }
    }
}
