Imports System

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class LayoutInteractivePrinting
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Squeeze
            layoutWaybill1.layoutControl1.ShowPrintPreview()
            layoutWaybill1.pedLogo.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom
        End Sub

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
