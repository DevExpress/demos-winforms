using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;

namespace Examples {
    [CodeExampleClass("Common Concepts", "CommonConcepts.cs")]
    [CodeExampleHighlightTokens("UserControl")]
    public static class DocumentLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            DocumentManager documentManager = new DocumentManager();
            XtraUserControl documentManagerHost = new XtraUserControl();
            documentManagerHost.Parent = sampleHost;
            documentManagerHost.Dock = DockStyle.Fill;
            TabbedView view = new TabbedView();
            documentManager.View = view;
            documentManager.ViewCollection.Add(view);
            documentManager.ContainerControl = documentManagerHost;
            return new object[] { documentManager };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var documentManager = DocumentManager.FromControl(sampleHost);
            if(documentManager != null)
                documentManager.Dispose();
        }
        [CodeExampleCase("Add Document via new Control")]
        public static void AddDocumentViaControl(DocumentManager documentManager) {
            var control = new UserControl();
            control.Text = "Document1";
            documentManager.View.AddDocument(control);
        }
        [CodeExampleCase("Add Document via QueryControl event")]
        [CodeExampleUnderlineTokens("QueryControl")]
        public static void AddDocumentViaQueryControl(DocumentManager documentManager) {
            documentManager.View.QueryControl += (sender, e) =>
            {
                if(e.Document.ControlName == "UserControl1")
                    e.Control = new UserControl();
            };
            documentManager.View.AddDocument("Document1", "UserControl1");
        }
        [CodeExampleCase("Add Document via ControlName")]
        public static void AddDocumentViaControlName(DocumentManager documentManager) {
            documentManager.View.AddDocument("Document1", "UserControl1");
            var control = new UserControl();
            control.Name = "UserControl1";
            documentManager.View.AddDocument(control);
        }
    }
}
