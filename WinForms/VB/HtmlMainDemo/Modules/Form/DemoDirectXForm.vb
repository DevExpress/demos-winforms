Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Public Partial Class DemoDirectXForm
        Inherits DirectXForm

        Public Sub New()
            InitializeComponent()
            AddHandler HtmlElementMouseDown, AddressOf DemoDirectXForm_HtmlElementMouseDown
        End Sub

        Private Sub DemoDirectXForm_HtmlElementMouseDown(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim args = TryCast(e.MouseArgs, DXMouseEventArgs)
            If e.Element Is Nothing OrElse args Is Nothing Then Return
            Dim id = e.Element.Id
            If e.HasClassName("addbutton") Then
                args.Handled = True
                Return
            End If

            If Equals(id, "loginbutton") Then
                args.Handled = True
                Return
            End If

            If Equals(id, "infobutton") Then
                args.Handled = True
                Return
            End If
        End Sub

        Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
            MyBase.OnShown(e)
            If Not HtmlTemplate.Template.Contains(searchEdit.Name) Then searchEdit.Visible = False
        End Sub
    End Class
End Namespace
