Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.WindowsMailClient.Win.Forms

    Public Partial Class SignatureEditFormControl
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub LoadText(ByVal text As String)
            richEditControl1.MhtText = text
            richEditControl1.Document.BeginUpdate()
            For Each p As Paragraph In richEditControl1.Document.Paragraphs
                p.LeftIndent = Units.InchesToDocumentsF(-0.09F)
            Next

            richEditControl1.Document.EndUpdate()
        End Sub

        Public Function GetText() As String
            Return richEditControl1.MhtText
        End Function
    End Class
End Namespace
