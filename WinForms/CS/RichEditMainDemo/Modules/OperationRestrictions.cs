using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraVerticalGrid.Rows;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class OperationRestrictionsModule : TutorialControl {
        public OperationRestrictionsModule() {
            InitializeComponent();
            RibbonControl ribbonControl = richEditControl.CreateRibbon();
            Controls.Add(ribbonControl);
            LoadDocument("OperationRestrictions.docx");
            propertyGridControl1.SelectedObject = new RichEditOptionsProvider(RichEdit.Options);
            propertyGridControl1.ExpandAllRows();
            RichEdit.Options.Behavior.MaxZoomFactor = RichEditZoomOptionsProvider.DefaultMaxZoomFactor;
            RichEdit.Options.Behavior.MinZoomFactor = RichEditZoomOptionsProvider.DefaultMinZoomFactor;
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }

        void edtReadOnly_CheckedChanged(object sender, System.EventArgs e) {
            RichEdit.ReadOnly = edtReadOnly.Checked;
        }
        void PropertyGridControl1_CellValueChanged(object sender, XtraVerticalGrid.Events.CellValueChangedEventArgs e) {
            if(IsDocumentCapabilitiesProperty(e.Row))
                RichEdit.LoadDocument(RichEdit.Options.DocumentSaveOptions.CurrentFileName);
        }
        bool IsDocumentCapabilitiesProperty(BaseRow row) {
            return FindDocumentCapabilitiesRow(row) != null;
        }
        BaseRow FindDocumentCapabilitiesRow(BaseRow row) {
            BaseRow documentCapabilitiesRow = propertyGridControl1.GetRowByFieldName("DocumentCapabilities");
            if(row.ParentRow == null)
                return null;
            if(documentCapabilitiesRow == row.ParentRow)
                return row.ParentRow;
            else
                return FindDocumentCapabilitiesRow(row.ParentRow);
        }
    }
}
