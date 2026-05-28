Imports System.Reflection

Namespace DevExpress.AI.Demos

    Public Partial Class PdfViewerAIModule
        Inherits AITutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
            pdfViewer1.CreateRibbon()
            Dim pdfStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.PageContent.pdf")
            pdfViewer1.LoadDocument(pdfStream)
            UpdatePaddings()
        End Sub

        Protected Overrides Sub UpdatePaddings()
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset)
        End Sub
    End Class
End Namespace
