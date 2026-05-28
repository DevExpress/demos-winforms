Imports DevExpress.Portable

Namespace DevExpress.XtraGantt.Demos.Utils

    Friend Class EventLogger

        Private logView As XtraRichEdit.RichEditControl

        Public Sub New(ByVal logView As XtraRichEdit.RichEditControl)
            Me.logView = logView
            logView.Views.SimpleView.Padding = New PortablePadding(2)
            logView.Document.AppendHtmlText(String.Empty)
        End Sub

        Public Sub Append(ByVal value As String)
            If Not logView.Enabled Then Return
            logView.Document.AppendHtmlText(String.Format("<b>{0}</b><br/>", value))
            AppendCore()
        End Sub

        Private Sub AppendCore()
            If logView.Visible Then logView.ScrollToCaret(logView.HtmlText.Length)
        End Sub

        Public Sub AppendWithIndent(ByVal value As String)
            If Not logView.Enabled Then Return
            logView.Document.AppendHtmlText(String.Format("{0}<br/>", value))
            AppendCore()
        End Sub
    End Class
End Namespace
