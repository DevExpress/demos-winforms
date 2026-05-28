using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraPrinting;
using DevExpress.MailClient.Win;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class WordModule : BaseModule {
        const string fileName = "MailMerge.docx";
        public WordModule() {
            InitializeComponent();
            string path = DemoUtils.GetRelativePath(fileName);
            if(string.IsNullOrEmpty(path))
                return;

            var data = DataHelper.Contacts;
            this.richEditControl.Options.MailMerge.DataSource = data;
            this.richEditControl.Options.MailMerge.ViewMergedData = true;
            richEditControl.LoadDocument(path, DocumentFormat.OpenXml);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
            grid.DataSource = data;
            view_FocusedRowChanged(null, null);
        }
        protected override bool AutoMergeRibbon { get { return true; } }
        void view_FocusedRowChanged(object sender, XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            richEditControl.Options.MailMerge.ActiveRecord = view.ViewRowHandleToDataSourceIndex(view.FocusedRowHandle);
        }
        void richEditControl_StartHeaderFooterEditing(object sender, XtraRichEdit.HeaderFooterEditingEventArgs e) {
            headerFooterToolsRibbonPageCategory1.Visible = true;
            ribbonControl1.SelectedPage = headerFooterToolsDesignRibbonPage1;
        }
        void richEditControl_FinishHeaderFooterEditing(object sender, XtraRichEdit.HeaderFooterEditingEventArgs e) {
            headerFooterToolsRibbonPageCategory1.Visible = false;
        }
        void richEditControl_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected;
        }
        public override IPrintable PrintableComponent { get { return this.richEditControl; } }
        public override IPrintable ExportComponent { get { return this.richEditControl; } }
        public override bool AllowRtfTitle { get { return false; } }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name);
        }
    }
}
