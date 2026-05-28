Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraLayout.Utils
Imports System

Namespace DevExpress.HTML.Demos

    Public Partial Class MessageBoxProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Init(ByVal caption As String, ByVal text As String, ByVal showIcon As Boolean)
            txtCaption.Text = caption
            txtText.Text = text
            imageItem.Visibility = If(showIcon, LayoutVisibility.Always, LayoutVisibility.Never)
        End Sub

        Public Event Changed As EventHandler

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RaiseEvent Changed(sender, e)
        End Sub

        Public ReadOnly Property Caption As String
            Get
                Return txtCaption.Text
            End Get
        End Property

        Public ReadOnly Property MessageText As String
            Get
                Return txtText.Text
            End Get
        End Property

        Public ReadOnly Property SvgImage As SvgImage
            Get
                If icbImage.SelectedIndex >= svgImageCollection1.Count Then Return Nothing
                Return svgImageCollection1(icbImage.SelectedIndex)
            End Get
        End Property

        Public Function GetMessageArgs() As XtraMessageBoxArgs
            Dim args As XtraMessageBoxArgs = New XtraMessageBoxArgs()
            args.Caption = txtCaption.Text
            args.Text = txtText.Text
            args.ImageOptions.SvgImage = SvgImage
            Return args
        End Function
    End Class
End Namespace
