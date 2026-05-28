using System;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class DocumentPropertiesModule : TutorialControl {
        public DocumentPropertiesModule() {
            InitializeComponent();
            LoadDocument("DocumentProperties.docx");
        }

        Document Document { get { return richEditControl.Document; } }
        public override RichEditControl RichEdit { get { return richEditControl; } }

        void OnCalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            if(e.Arguments.Count == 0 || e.VariableName != "CustomProperty")
                return;

            string fieldName = e.Arguments[0].Value;
            object customProperty = Document.CustomProperties[fieldName];
            if(customProperty != null)
                e.Value = customProperty.ToString();
            e.Handled = true;
        }
        void RichEditControl_DocumentPropertiesChanged(object sender, EventArgs e) {
            Document.Fields.Update();
        }
        void RichEditControl_CustomPropertiesChanged(object sender, EventArgs e) {
            Document.Fields.Update();
        }
        void OnCategoryItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("DOCPROPERTY Category");
        }
        void OnCreatedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("CREATEDATE");
        }
        void OnCreatorItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("AUTHOR");
        }
        void OnDescriptionItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("COMMENTS");
        }
        void OnKeywordsItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("KEYWORDS");
        }
        void OnLastModifiedByItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("LASTSAVEDBY");
        }
        void OnLastPrintedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("PRINTDATE");
        }
        void OnModifiedItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("SAVEDATE");
        }
        void OnRevisionItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("REVNUM");
        }
        void OnSubjectItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("SUBJECT");
        }
        void OnTitleItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            InsertField("TITLE");
        }
        void InsertField(string code) {
            Document.BeginUpdate();
            Field field = Document.Fields.Create(richEditControl.Document.CaretPosition, code);
            field.Update();
            Document.EndUpdate();
        }
    }
}
