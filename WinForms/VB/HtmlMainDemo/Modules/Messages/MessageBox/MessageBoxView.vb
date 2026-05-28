Imports DevExpress.Skins
Imports DevExpress.Tutorials.TodoApp
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Internal
Imports System
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class MessageBoxView
        Inherits XtraUserControl

        Private preview As HtmlMessageBoxForm = New HtmlMessageBoxForm() With {.FormBorderStyle = FormBorderStyle.FixedDialog, .MinimizeBox = False, .MaximizeBox = False}

        Public Sub New()
            InitializeComponent()
            AddHandler propertiesMessageBox.Changed, Sub(s, e) UpdatePreview()
            AddHandler templateViewer.ActiveTemplateChanged, Sub(s, e)
                InitMessageBox(templateViewer.ActiveTemplate)
                UpdatePreview()
            End Sub
            templateViewer.Init(preview, htmlMessageTemplateCollection)
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            PresentationHelper.CenterParent(hostMessage, preview)
            AddHandler hostMessage.SizeChanged, Sub(s, e) CenterPreview()
        End Sub

        Private Function CreateMessageBoxArgs() As XtraMessageBoxArgs
            Dim args As XtraMessageBoxArgs = propertiesMessageBox.GetMessageArgs()
            args.HtmlImages = svgImages
            args.HtmlTemplate.Assign(templateViewer.ActiveTemplate)
            args.Caption = propertiesMessageBox.Caption
            args.Text = propertiesMessageBox.MessageText
            args.ImageOptions.SvgImage = propertiesMessageBox.SvgImage
            args.DefaultButtonIndex = 0
            Return args
        End Function

        Private Sub OnShowMessageBoxButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim args = CreateMessageBoxArgs()
            Dim result = XtraMessageBox.Show(args)
            messageBoxResult.Output(result)
        End Sub

        Private Sub InitMessageBox(ByVal currentTemplate As HtmlTemplate)
            If currentTemplate Is confirmMessageTemplate2 Then
                propertiesMessageBox.Init("Delete file permanently?", "If you delete this file you won't be able to recover it. Do you want to delete it?", False)
            ElseIf currentTemplate Is notificationMessageTemplate1 Then
                propertiesMessageBox.Init("Successful", "Your changes have been successfully saved.", True)
            ElseIf currentTemplate Is confirmMessageTemplate1 Then
                propertiesMessageBox.Init("Application", "Do you want to save changes to the file?", False)
            End If
        End Sub

        Private Sub UpdatePreview()
            TryCast(preview, IMessageForm(Of XtraMessageBoxArgs)).Message = CreateMessageBoxArgs()
            CenterPreview()
        End Sub

        Private Sub CenterPreview()
            preview.Bounds = RectangleHelper.GetCenterBounds(hostMessage.ClientRectangle, preview.Size)
        End Sub
    End Class
End Namespace
