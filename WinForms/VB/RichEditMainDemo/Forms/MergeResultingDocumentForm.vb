Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos.Forms

    Public Partial Class MergeResultingDocumentForm
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            Dim ribbonControl As RibbonControl = richEditControl.CreateRibbon()
            Controls.Add(ribbonControl)
        End Sub

        Public ReadOnly Property Document As Document
            Get
                Return richEditControl.Document
            End Get
        End Property

        Private Sub ribbonControl1_ApplicationButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
