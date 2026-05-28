Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class Overview
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLayoutCalculated()
            BeginInvoke(New MethodInvoker(AddressOf Me.UpdateTableLayoutRowHeight))
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            UpdateTableLayoutRowHeight()
        End Sub

        Private Sub UpdateTableLayoutRowHeight()
            Root.OptionsTableLayoutGroup.RowDefinitions(1).Height = htmlContentControl.GetContentSize().Height
        End Sub

        Private Sub htmlContentControl_ElementMouseClick(ByVal sender As Object, ByVal e As Utils.Html.DxHtmlElementMouseEventArgs)
            If String.IsNullOrEmpty(e.ElementId) Then Return
            XtraMessageBox.Show($"Html Element ({e.ElementId}) clicked!")
        End Sub
    End Class
End Namespace
