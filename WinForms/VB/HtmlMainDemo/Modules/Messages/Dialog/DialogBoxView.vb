Imports DevExpress.Skins
Imports DevExpress.Tutorials.TodoApp
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Internal
Imports System
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos

    Public Partial Class DialogBoxView
        Inherits XtraUserControl

        Private preview As HtmlDialogForm

        Public Sub New()
            InitializeComponent()
            svgImages.Add("logo", DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("logo"))
            dialogTemplateViewer.Init(preview, htmlDialogTemplateCollection)
        End Sub

        Protected Overrides Sub OnFirstLoad()
            MyBase.OnFirstLoad()
            AddHandler hostDialog.SizeChanged, Sub(s, e) CenterPreview()
        End Sub

        Private Function CreateLoginArgs() As XtraDialogArgs
            Return CreateDialogArgs(New DialogLoginControl(loginTemplate) With {.HtmlImages = svgImages})
        End Function

        Private Function CreateFeedbackArgs() As XtraDialogArgs
            Return CreateDialogArgs(New DialogFeedbackControl(feedbackTemplate) With {.HtmlImages = svgImages}, "Feedback")
        End Function

        Private Function CreateDialogArgs(ByVal content As Control, ByVal Optional caption As String = "") As XtraDialogArgs
            Dim args = New XtraDialogArgs()
            args.HtmlImages = svgImages
            args.Caption = caption
            args.Content = content
            Return args
        End Function

        Private Sub OnShowDialogBoxButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim args As XtraDialogArgs = If(Equals(dialogTemplateViewer.ActiveTemplate.Name, loginFormTemplate.Name), CreateLoginArgs(), CreateFeedbackArgs())
            args.HtmlTemplate.Assign(dialogTemplateViewer.ActiveTemplate)
            XtraDialog.Show(args)
        End Sub

        Private Sub OnActiveTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdatePreview()
            PresentationHelper.CenterParent(hostDialog, preview)
            dialogTemplateViewer.UpdateForm(preview)
        End Sub

        Private Sub UpdatePreview()
            preview?.Dispose()
            preview = New HtmlDialogForm() With {.FormBorderStyle = FormBorderStyle.FixedDialog, .MinimizeBox = False, .MaximizeBox = False}
            AddHandler preview.SizeChanged, Sub(s, e) CenterPreview()
            Dim args = If(Equals(dialogTemplateViewer.ActiveTemplate.Name, loginFormTemplate.Name), CreateLoginArgs(), CreateFeedbackArgs())
            TryCast(preview, IMessageForm(Of XtraDialogArgs)).Message = args
            preview.HtmlTemplate.Assign(dialogTemplateViewer.ActiveTemplate)
        End Sub

        Private Sub CenterPreview()
            preview.Bounds = RectangleHelper.GetCenterBounds(hostDialog.ClientRectangle, preview.Size)
        End Sub
    End Class
End Namespace
