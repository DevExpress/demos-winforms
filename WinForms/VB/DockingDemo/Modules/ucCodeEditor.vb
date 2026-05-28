Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit

Namespace DevExpress.XtraBars.Demos.DockingDemo

    Public Partial Class ucCodeEditor
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub LoadCode(ByVal stream As Stream)
            richEditControl1.LoadDocument(stream, DocumentFormat.Rtf)
            richEditControl1.Document.Sections(0).Page.Width = 10000
        End Sub
    End Class
End Namespace
