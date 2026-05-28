Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Html

Namespace DevExpress.HTML.Demos

    Public Class FormTemplateViewer
        Inherits TemplateCodeViewer

        Private form As DirectXForm

        Private previewTimer As Timer = New Timer()

        Public Sub New()
            lciTemplate.Text = "Choose the Template:"
            AddHandler iceTemplates.EditValueChanged, AddressOf OnActiveTemplateChanged
            previewTimer.Interval = 500
            AddHandler previewTimer.Tick, AddressOf OnUpdatePreview
            previewTimer.Start()
        End Sub

        Private Sub OnUpdatePreview(ByVal sender As Object, ByVal e As EventArgs)
            If form Is Nothing OrElse ActiveTemplate Is Nothing Then Return
            If Not Equals(ActiveTemplate.Styles, form.HtmlTemplate.Styles) OrElse Not Equals(ActiveTemplate.Template, form.HtmlTemplate.Template) Then form.HtmlTemplate.Assign(ActiveTemplate)
        End Sub

        Private Sub OnActiveTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            form.HtmlTemplate.Assign(ActiveTemplate)
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

        Public ReadOnly Property ActiveTemplate As HtmlTemplate
            Get
                Return CType(iceTemplates.EditValue, HtmlTemplate)
            End Get
        End Property

        Public Sub Init(ByVal form As DirectXForm, ByVal templates As HtmlTemplateCollection)
            Me.form = form
            FillTemplates(templates)
        End Sub
    End Class
End Namespace
