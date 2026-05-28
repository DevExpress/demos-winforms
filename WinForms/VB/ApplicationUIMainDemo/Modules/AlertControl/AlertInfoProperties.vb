Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class AlertInfoProperties
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private _caption, _text, _captionHtml, _textHtml, _hotTrackedTextHtml As String

        Public Sub InitValues(ByVal caption As String, ByVal text As String, ByVal captionHtml As String, ByVal textHtml As String, ByVal hotTrackedTextHtml As String)
            _caption = caption
            _captionHtml = captionHtml
            _text = text
            _textHtml = textHtml
            _hotTrackedTextHtml = hotTrackedTextHtml
        End Sub

        Public ReadOnly Property Caption As String
            Get
                Return txtCaption.Text
            End Get
        End Property

        Public ReadOnly Property TextInfo As String
            Get
                Return txtText.Text
            End Get
        End Property

        Public ReadOnly Property HotTrackedText As String
            Get
                Return txtHotTrackedText.Text
            End Get
        End Property

        Public ReadOnly Property Image As Image
            Get
                If ceShowAnimatedImage.Checked Then Return ResourceImageHelperCore.CreateImageFromResources("DevExpress.ApplicationUI.Demos.Images.Alarm-Clock.gif", GetType(AlertInfoProperties).Assembly)
                If icbImage.SelectedIndex > 4 Then Return Nothing
                Return svgImageCollection1.GetImage(icbImage.SelectedIndex)
            End Get
        End Property

        Private allowHtml As Boolean = False

        Private _initValues As Boolean = False

        Friend Sub UpdateInfo(ByVal allowHtml As Boolean)
            _initValues = True
            Me.allowHtml = allowHtml
            If allowHtml Then
                txtCaption.Text = _captionHtml
                txtText.Text = _textHtml
                txtHotTrackedText.Text = _hotTrackedTextHtml
                txtHotTrackedTextitem.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Else
                txtCaption.Text = _caption
                txtText.Text = _text
                txtHotTrackedText.Text = ""
                txtHotTrackedTextitem.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            End If

            _initValues = False
        End Sub

        Private Sub txtCaption_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            If allowHtml Then
                _captionHtml = txtCaption.Text
            Else
                _caption = txtCaption.Text
            End If
        End Sub

        Private Sub txtText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            If allowHtml Then
                _textHtml = txtText.Text
            Else
                _text = txtText.Text
            End If
        End Sub

        Private Sub txtSelectedText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If _initValues Then Return
            If allowHtml Then _hotTrackedTextHtml = txtHotTrackedText.Text
        End Sub

        Private Sub ceShowAnimatedImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            icbImage.Enabled = Not ceShowAnimatedImage.Checked
        End Sub
    End Class
End Namespace
