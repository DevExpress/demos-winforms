Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraLayout.Utils

Namespace DevExpress.HTML.Demos

    Public Partial Class AlertInfoProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Init(ByVal caption As String, ByVal text As String, ByVal showImageComboBox As Boolean)
            captionItem.Visibility = If(String.IsNullOrEmpty(caption), LayoutVisibility.Never, LayoutVisibility.Always)
            textItem.Visibility = If(String.IsNullOrEmpty(text), LayoutVisibility.Never, LayoutVisibility.Always)
            imageItem.Visibility = If(showImageComboBox, LayoutVisibility.Always, LayoutVisibility.Never)
            txtCaption.Text = caption
            txtText.Text = text
        End Sub

        Public ReadOnly Property Caption As String
            Get
                Return txtCaption.Text
            End Get
        End Property

        Public ReadOnly Property AlertText As String
            Get
                Return txtText.Text
            End Get
        End Property

        Public ReadOnly Property Image As Image
            Get
                If icbImage.SelectedIndex >= svgImageCollection1.Count Then Return Nothing
                Return svgImageCollection1.GetImage(icbImage.SelectedIndex)
            End Get
        End Property

        Public ReadOnly Property SvgImage As SvgImage
            Get
                If icbImage.SelectedIndex >= svgImageCollection1.Count Then Return Nothing
                Return svgImageCollection1(icbImage.SelectedIndex)
            End Get
        End Property

        Public Sub UpdateAlertInfo(ByVal info As AlertInfo)
            info.Caption = Caption
            info.Text = AlertText
            info.ImageOptions.Image = Image
            info.ImageOptions.SvgImage = SvgImage
            info.AutoCloseFormOnClick = ceAutoCloseOnClick.Checked
        End Sub
    End Class
End Namespace
