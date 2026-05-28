Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports System
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Class ToolTipTemplateViewer
        Inherits TemplateCodeViewer

        Private form As HtmlToolTipWindowBase

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

        Public Sub Init(ByVal form As HtmlToolTipWindowBase, ByVal templates As HtmlTemplateCollection)
            Me.form = form
            FillTemplates(templates)
        End Sub

        Private Overloads Sub InitializeComponent()
            CType(iceTemplates.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lciTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' iceTemplates
            ' 
            iceTemplates.Size = New System.Drawing.Size(417, 20)
            ' 
            ' lciTemplate
            ' 
            lciTemplate.Size = New System.Drawing.Size(421, 47)
            ' 
            ' ToolTipTemplateViewer
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Name = "ToolTipTemplateViewer"
            Size = New System.Drawing.Size(441, 504)
            CType(iceTemplates.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lciTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
    End Class
End Namespace
