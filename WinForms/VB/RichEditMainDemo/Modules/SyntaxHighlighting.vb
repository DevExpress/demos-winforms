Imports System
Imports System.Drawing
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Export
Imports DevExpress.XtraRichEdit.Import
Imports DevExpress.XtraRichEdit.Internal
Imports DevExpress.XtraRichEdit.Services

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class SyntaxHighlightingModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            richEditControl.AddService(GetType(ISyntaxHighlightService), New SyntaxHighlightService(richEditControl))
            Dim commandFactory As IRichEditCommandFactoryService = richEditControl.GetService(Of IRichEditCommandFactoryService)()
            Dim newCommandFactory As CustomRichEditCommandFactoryService = New CustomRichEditCommandFactoryService(commandFactory)
            richEditControl.RemoveService(GetType(IRichEditCommandFactoryService))
            richEditControl.AddService(GetType(IRichEditCommandFactoryService), newCommandFactory)
            Dim importManager As IDocumentImportManagerService = richEditControl.GetService(Of IDocumentImportManagerService)()
            importManager.UnregisterAllImporters()
            importManager.RegisterImporter(New PlainTextDocumentImporter())
            importManager.RegisterImporter(New SourcesCodeDocumentImporter())
            Dim exportManager As IDocumentExportManagerService = richEditControl.GetService(Of IDocumentExportManagerService)()
            exportManager.UnregisterAllExporters()
            exportManager.RegisterExporter(New PlainTextDocumentExporter())
            exportManager.RegisterExporter(New SourcesCodeDocumentExporter())
            LoadTypeScriptCode("SyntaxHighlighting.ts")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub LoadTypeScriptCode(ByVal fileName As String)
            Dim path As String = DemoUtils.GetRelativePath(fileName)
            If Not String.IsNullOrEmpty(path) Then RichEdit.LoadDocument(path, DocumentFormat.PlainText)
        End Sub

        Private Sub richEditControl_InitializeDocument(ByVal sender As Object, ByVal e As EventArgs)
            Dim document As Document = richEditControl.Document
            document.BeginUpdate()
            Try
                document.DefaultCharacterProperties.FontName = "Courier New"
                document.DefaultCharacterProperties.FontSize = 10
                document.Sections(0).Page.Width = Units.InchesToDocumentsF(100)
                document.Sections(0).LineNumbering.CountBy = 1
                document.Sections(0).LineNumbering.RestartType = LineNumberingRestart.Continuous
                Dim tabSize As SizeF = richEditControl.MeasureSingleLineString("    ", document.DefaultCharacterProperties)
                Dim tabs As TabInfoCollection = document.Paragraphs(0).BeginUpdateTabs(True)
                Try
                    For i As Integer = 1 To 30
                        Dim tab As TabInfo = New TabInfo()
                        tab.Position = i * tabSize.Width
                        tabs.Add(tab)
                    Next
                Finally
                    document.Paragraphs(0).EndUpdateTabs(tabs)
                End Try
            Finally
                document.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
