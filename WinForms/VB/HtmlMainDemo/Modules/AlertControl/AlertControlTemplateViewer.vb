Imports System
Imports DevExpress.Utils.Html
Imports DevExpress.XtraBars.Alerter

Namespace DevExpress.HTML.Demos

    Public Class AlertControlTemplateViewer
        Inherits TemplateCodeViewer

        Private control As AlertControl

        Public Sub New()
            MyBase.New()
            lciTemplate.Text = "Choose the Template:"
            AddHandler iceTemplates.EditValueChanged, AddressOf IceTemplates_EditValueChanged
        End Sub

        Private Sub IceTemplates_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent ActiveTemplateChanged(Me, e)
        End Sub

        Public ReadOnly Property ActiveTemplate As HtmlTemplate
            Get
                Return CType(iceTemplates.EditValue, HtmlTemplate)
            End Get
        End Property

        Public Event ActiveTemplateChanged As EventHandler

        Public Sub Init(ByVal control As AlertControl)
            Me.control = control
            FillTemplates(control.HtmlTemplates)
        End Sub

        Private Overloads Sub InitializeComponent()
            CType(iceTemplates.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(lciTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' iceTemplates
            ' 
            ' 
            ' AlertControlTemplateViewer
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Name = "AlertControlTemplateViewer"
            CType(iceTemplates.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(lciTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
    End Class
End Namespace
