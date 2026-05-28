Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls

    Public Partial Class HtmlButton
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            context = New HtmlDataContext()
            htmlContentControl1.DataContext = context
        End Sub

        Private context As HtmlDataContext

        <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Overrides Property Text As String
            Get
                Return context.Text
            End Get

            Set(ByVal value As String)
                context.Text = value
            End Set
        End Property

        Private Class HtmlDataContext

            Public Property Text As String
        End Class
    End Class
End Namespace
