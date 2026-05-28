Imports System.Drawing
Imports DevExpress.Data.Utils.Security
Imports DevExpress.Utils.Html
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.HTML.Demos

    Public Partial Class RepositoryItems
        Inherits TutorialControl

        Private loginTemplate, signupTemplate As String

        Public Sub New()
            InitializeComponent()
            InitTemplates()
            InitCodeViewer()
            InitDataContext()
            EnsureSkinColors()
        End Sub

        Private Sub InitTemplates()
            loginTemplate = htmlContentControl.HtmlTemplate.Template
            signupTemplate = Properties.Resources.SignUpTemplate
        End Sub

        Private Sub InitCodeViewer()
            templateCodeViewer.Fill(htmlContentControl)
        End Sub

        Private Sub InitDataContext()
            Dim defaultPhoto = svgImageCollection1("default_photo")
            bindingSource.DataSource = New UserInfo(defaultPhoto)
            htmlContentControl.DataContext = bindingSource
        End Sub

        Private Sub OnHtmlElementMouseDown(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "signup") Then
                loginTemplate = htmlContentControl.HtmlTemplate.Template
                htmlContentControl.HtmlTemplate.Template = signupTemplate
                templateCodeViewer.UpdateHtmlTemplate()
            End If

            If Equals(e.ElementId, "login") Then
                signupTemplate = htmlContentControl.HtmlTemplate.Template
                htmlContentControl.HtmlTemplate.Template = loginTemplate
                templateCodeViewer.UpdateHtmlTemplate()
            End If

            If Equals(e.ElementId, "choose_Photo") Then
                htmlContentControl.ShowEditor("Photo")
                If htmlContentControl.ActiveEditor IsNot Nothing Then CType(htmlContentControl.ActiveEditor, PictureEdit).LoadImage()
            End If
        End Sub

        Private Sub OnPictureEditImageChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            pictureEdit.OptionsMask.MaskType = If(htmlContentControl.ActiveEditor.EditValue IsNot Nothing, PictureEditMaskType.Circle, PictureEditMaskType.None)
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            EnsureSkinColors()
        End Sub

        Private Sub EnsureSkinColors()
            Dim checkedImage = checkEdit.ImageOptions.SvgImageChecked
            checkEdit.ImageOptions.SvgImageChecked = Nothing
            If checkedImage.DefaultStyle Is Nothing Then checkedImage.DefaultStyle = New SvgStyle()
            checkedImage.DefaultStyle.SetValue("fill", GetSkinColor("@HighlightAlternate"))
            checkEdit.ImageOptions.SvgImageChecked = checkedImage
        End Sub

        Private Function GetSkinColor(ByVal skinColorName As String) As String
            Return ColorTranslator.ToHtml(Utils.Colors.DXSkinColorHelper.GetDXSkinColor(Skins.ColorCreator.Create(skinColorName), LookAndFeel))
        End Function
    End Class

    Public Class UserInfo

        Private photoField As Byte()

        Private ReadOnly defaultPhoto As SvgImage

        Public Sub New(ByVal defaultPhoto As SvgImage)
            Me.defaultPhoto = defaultPhoto
        End Sub

        Public Property Email As String

        Private ReadOnly passwordData As SensitiveData = SensitiveData.CreateForCurrentUser()

        Public Property Password As String
            Get
                Return passwordData.Text
            End Get

            Set(ByVal value As String)
                passwordData.Text = value
            End Set
        End Property

        Private ReadOnly confirmData As SensitiveData = SensitiveData.CreateForCurrentUser()

        Public Property Confirm As String
            Get
                Return confirmData.Text
            End Get

            Set(ByVal value As String)
                confirmData.Text = value
            End Set
        End Property

        Public Property Agreement As Boolean

        Public ReadOnly Property IsDefaultPhoto As Boolean
            Get
                Return photoField Is Nothing
            End Get
        End Property

        Public ReadOnly Property HasPhoto As Boolean
            Get
                Return Not IsDefaultPhoto
            End Get
        End Property

        Public Property Photo As Object
            Get
                Return If(CObj(photoField), defaultPhoto)
            End Get

            Set(ByVal value As Object)
                If photoField Is value Then Return
                photoField = TryCast(value, Byte())
            End Set
        End Property
    End Class
End Namespace
