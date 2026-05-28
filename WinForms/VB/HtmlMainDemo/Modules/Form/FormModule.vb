Imports System.Collections.Generic
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Html
Imports DevExpress.Utils.DirectXForm.Painter
Imports DevExpress.LookAndFeel
Imports System.Windows.Forms
Imports System
Imports DevExpress.Skins.XtraForm
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.DPI
Imports DevExpress.Utils.Drawing.Helpers

Namespace DevExpress.HTML.Demos

    Public Partial Class FormModule
        Inherits TutorialControlBase

        Private previewForm As PreviewDirectXForm = New PreviewDirectXForm()

        Public Sub New()
            InitializeComponent()
            Dim customTemplate = New HtmlTemplate(previewForm.HtmlTemplate)
            customTemplate.Tag = "Custom HTML-CSS Template"
            previewForm.Text = "DirectX Form - Default HTML-CSS Template"
            previewForm.Size = New Size(800, 600)
            previewForm.Clear()
            AddHandler previewForm.HtmlElementMouseClick, AddressOf Form_HtmlElementMouseClick
            Tutorials.TodoApp.PresentationHelper.CenterParent(hostPanel, previewForm)
            templateViewer.Init(previewForm, New HtmlTemplateCollection(New List(Of HtmlTemplate) From {customTemplate, defaultTemplate}))
            Dim previewContent = New HtmlContentControl()
            previewContent.Parent = previewForm
            previewContent.Dock = DockStyle.Fill
            previewContent.HtmlTemplate.Assign(contentTemplate)
            AddHandler previewContent.ElementMouseClick, Sub(s, e)
                If Equals(e.ElementId, "showform") Then ShowForm()
            End Sub
        End Sub

        Private Sub ShowForm()
            Using form = New DemoDirectXForm()
                form.HtmlTemplate.Assign(previewForm.HtmlTemplate)
                form.Size = ScaleDPI.ScaleSize(New Size(1000, 600))
                form.StartPosition = FormStartPosition.CenterScreen
                form.ShowDialog(Me)
            End Using
        End Sub

        Private Sub Form_HtmlElementMouseClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "infobutton") Then
                BeginInvoke(New Action(Sub()
                    Using aboutForm = New AboutDirectXForm(aboutFormTemplate, svgImages, ScaleDPI)
                        aboutForm.ShowDialog(Me)
                    End Using
                End Sub))
            End If
        End Sub

#Region "Utils"
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            If previewForm IsNot Nothing AndAlso Not previewForm.Visible Then previewForm.Show()
        End Sub

        Protected Overrides Sub DoHide()
            If previewForm IsNot Nothing AndAlso previewForm.Visible Then previewForm.Hide()
            MyBase.DoHide()
        End Sub

        Private Sub OnPanelSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If previewForm Is Nothing Then Return
            Dim size = CType(sender, Control).Size
            Dim padding As Integer = ScaleDPI.ScaleHorizontal(20)
            Dim minWidth As Integer = ScaleDPI.ScaleHorizontal(600)
            Dim minHeight As Integer = ScaleDPI.ScaleHorizontal(800)
            Dim maxSize As Size = ScaleDPI.ScaleSize(New Size(1000, 750))
            Dim height As Integer = Math.Min(size.Height - padding * 2, maxSize.Height)
            Dim width As Integer = Math.Min(size.Width - padding * 2, maxSize.Width)
            If height > width * 3 \ 4 Then
                height = width * 3 \ 4
            Else
                width = height * 4 \ 3
            End If

            If width < minWidth Then width = minWidth
            If height < minHeight Then height = minHeight
            If height > width * 3 \ 4 Then
                height = width * 3 \ 4
            Else
                width = height * 4 \ 3
            End If

            previewForm.SetBounds((size.Width - width) \ 2, (size.Height - height) \ 2, width, height)
        End Sub
#End Region  ' Utils
    End Class

#Region "PreviewForm"
    Friend Class PreviewDirectXForm
        Inherits DemoDirectXForm

        Protected Overrides Function CreateFormBorderPainter() As FormPainter
            Return New PreviewDirectXFormPainter(Me, LookAndFeel)
        End Function

        Friend Sub Clear()
            For Each control As Control In Controls
                If control IsNot ContainerControl Then control.Dispose()
            Next
        End Sub
    End Class

    Friend Class PreviewDirectXFormPainter
        Inherits DirectXFormPainter

        Public Sub New(ByVal owner As DirectXForm, ByVal lf As UserLookAndFeel)
            MyBase.New(owner, lf)
        End Sub

        Protected Overrides Sub WMNCHitTest(ByRef msg As Message)
            MyBase.WMNCHitTest(msg)
            If msg.Result <> IntPtr.Zero Then msg.Result = New IntPtr(Utils.Drawing.Helpers.NativeMethods.HT.HTCLIENT)
        End Sub

        Protected Overrides Sub OnClick(ByVal e As MouseEventArgs, ByVal kind As FormCaptionButtonAction)
        End Sub
    End Class

#End Region  ' PreviewForm
    Public Class AboutDirectXForm
        Inherits DirectXForm

        Public Sub New(ByVal template As HtmlTemplate, ByVal htmlImages As Object, ByVal scaleDpi As ScaleHelper)
            MyBase.New()
            Me.HtmlImages = htmlImages
            HtmlTemplate.Assign(template)
            StartPosition = FormStartPosition.CenterParent
            Size = scaleDpi.ScaleSize(FormDefaultSize)
            FormBorderStyle = FormBorderStyle.FixedDialog
            AddHandler HtmlElementMouseClick, AddressOf OnHtmlElementMouseClick
        End Sub

        Private Shared ReadOnly FormDefaultSize As Size = New Size(660, 460)

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)
            If m.Msg = MSG.WM_DPICHANGED Then Size = ScaleDPI.ScaleSize(FormDefaultSize)
        End Sub

        Private Sub OnHtmlElementMouseClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            If e.Element Is Nothing Then Return
            Dim id = e.Element.Id
            Dim parentId = e.Element.ParentElement?.Id
            If Equals(id, "contentbutton") OrElse Equals(parentId, "contentbutton") Then
                Close()
            End If
        End Sub
    End Class
End Namespace
