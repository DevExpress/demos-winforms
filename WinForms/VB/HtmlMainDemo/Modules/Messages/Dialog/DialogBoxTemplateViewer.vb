Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Class DialogBoxTemplateViewer
        Inherits TemplateCodeViewer

        Private form As HtmlDialogForm

        Private previewTimer As Timer = New Timer()

        Public Event ActiveTemplateChanged As EventHandler

        Public Sub New()
            lciTemplate.Text = "Choose the Template:"
            AddHandler iceTemplates.EditValueChanged, AddressOf OnActiveTemplateChanged
            previewTimer.Interval = 500
            AddHandler previewTimer.Tick, AddressOf OnUpdatePreview
            previewTimer.Start()
        End Sub

        Public ReadOnly Property ActiveTemplate As HtmlTemplate
            Get
                Return CType(iceTemplates.EditValue, HtmlTemplate)
            End Get
        End Property

        Private Sub OnUpdatePreview(ByVal sender As Object, ByVal e As EventArgs)
            If form Is Nothing OrElse ActiveTemplate Is Nothing Then Return
            If Not Equals(ActiveTemplate.Styles, form.HtmlTemplate.Styles) OrElse Not Equals(ActiveTemplate.Template, form.HtmlTemplate.Template) Then form.HtmlTemplate.Assign(ActiveTemplate)
        End Sub

        Private Sub OnActiveTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnUpdatePreview(sender, e)
            RaiseEvent ActiveTemplateChanged(sender, e)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            RemoveHandler iceTemplates.EditValueChanged, AddressOf OnActiveTemplateChanged
            If previewTimer IsNot Nothing Then RemoveHandler previewTimer.Tick, AddressOf OnUpdatePreview
            DisposeHelper.Dispose(previewTimer)
            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub LayoutChanged()
            form.Update()
        End Sub

        Public Sub Init(ByVal form As HtmlDialogForm, ByVal templates As HtmlTemplateCollection)
            UpdateForm(form)
            FillTemplates(templates)
        End Sub

        Public Sub UpdateForm(ByVal form As HtmlDialogForm)
            Me.form = form
        End Sub
    End Class
End Namespace
