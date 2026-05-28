using System;
using System.Drawing;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Import;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.Services;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class SyntaxHighlightingModule : TutorialControl {
        public SyntaxHighlightingModule() {
            InitializeComponent();

            richEditControl.AddService(typeof(ISyntaxHighlightService), new SyntaxHighlightService(richEditControl));
            IRichEditCommandFactoryService commandFactory = richEditControl.GetService<IRichEditCommandFactoryService>();
            CustomRichEditCommandFactoryService newCommandFactory = new CustomRichEditCommandFactoryService(commandFactory);
            richEditControl.RemoveService(typeof(IRichEditCommandFactoryService));
            richEditControl.AddService(typeof(IRichEditCommandFactoryService), newCommandFactory);

            IDocumentImportManagerService importManager = richEditControl.GetService<IDocumentImportManagerService>();
            importManager.UnregisterAllImporters();
            importManager.RegisterImporter(new PlainTextDocumentImporter());
            importManager.RegisterImporter(new SourcesCodeDocumentImporter());

            IDocumentExportManagerService exportManager = richEditControl.GetService<IDocumentExportManagerService>();
            exportManager.UnregisterAllExporters();
            exportManager.RegisterExporter(new PlainTextDocumentExporter());
            exportManager.RegisterExporter(new SourcesCodeDocumentExporter());

            LoadTypeScriptCode("SyntaxHighlighting.ts");
        }

        public override RichEditControl RichEdit { get { return richEditControl; } }

        void LoadTypeScriptCode(String fileName) {
            string path = DemoUtils.GetRelativePath(fileName);
            if(!String.IsNullOrEmpty(path))
                RichEdit.LoadDocument(path, DocumentFormat.PlainText);
        }
        void richEditControl_InitializeDocument(object sender, EventArgs e) {
            Document document = richEditControl.Document;
            document.BeginUpdate();
            try {
                document.DefaultCharacterProperties.FontName = "Courier New";
                document.DefaultCharacterProperties.FontSize = 10;
                document.Sections[0].Page.Width = Units.InchesToDocumentsF(100);
                document.Sections[0].LineNumbering.CountBy = 1;
                document.Sections[0].LineNumbering.RestartType = LineNumberingRestart.Continuous;

                SizeF tabSize = richEditControl.MeasureSingleLineString("    ", document.DefaultCharacterProperties);
                TabInfoCollection tabs = document.Paragraphs[0].BeginUpdateTabs(true);
                try {
                    for(int i = 1; i <= 30; i++) {
                        TabInfo tab = new TabInfo();
                        tab.Position = i * tabSize.Width;
                        tabs.Add(tab);
                    }
                }
                finally {
                    document.Paragraphs[0].EndUpdateTabs(tabs);
                }
            }
            finally {
                document.EndUpdate();
            }
        }
    }
}
