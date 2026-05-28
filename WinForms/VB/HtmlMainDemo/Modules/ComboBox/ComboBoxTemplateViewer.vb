Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos

    Public Partial Class ComboBoxTemplateViewer
        Inherits TemplateCodeViewer

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Fill(ByVal cbe As ComboBoxEdit)
            FillTemplates(cbe.Properties.HtmlTemplates)
        End Sub
    End Class
End Namespace
