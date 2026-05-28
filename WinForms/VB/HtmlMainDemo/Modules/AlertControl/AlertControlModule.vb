Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers.Data
Imports DevExpress.Utils
Imports DevExpress.Utils.Html
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Alerter

Namespace DevExpress.HTML.Demos

    Public Partial Class AlertControlModule
        Inherits TutorialControlBase

        Private previewTemplate As String

        Private previewStyles As String

        Public Sub New()
            InitializeComponent()
            AddHandler templateViewer.ActiveTemplateChanged, AddressOf TemplateViewer_ActiveTemplateChanged
            templateViewer.Init(alertControl1)
            alertControlProperties.Init(alertControl1)
            AddHandler alertControl1.HtmlElementMouseClick, AddressOf AlertControl1_HtmlElementMouseClick
            AddHandler alertControl1.BeforeFormShow, AddressOf AlertControl1_BeforeFormShow
            UpdatePreview()
            Dim previewTimer As Timer = New Timer()
            previewTimer.Interval = 200
            AddHandler previewTimer.Tick, Sub(s, e) UpdatePreview()
            previewTimer.Start()
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdatePropertiesHeight()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UpdatePropertiesHeight()
        End Sub

        Private Sub UpdatePropertiesHeight()
            mainPanel.Rows(4).Height = Math.Min(alertControlProperties.GetBestHeight(), mainPanel.Height \ 2) / ScaleUtils.ScaleFactor.Height
        End Sub

        Private Sub UpdatePreview()
            htmlPreview.HtmlImages = alertControl1.HtmlImages
            Dim newContext As AlertInfo = GetCurrentAlertInfo()
            If TypeOf htmlPreview.DataContext Is AlertInfo Then
                UpdateAlertinfo(CType(htmlPreview.DataContext, AlertInfo))
            Else
                htmlPreview.DataContext = GetCurrentAlertInfo()
            End If

            Dim currentTemlpate As HtmlTemplate = GetCurrentTemplate()
            If Not Equals(currentTemlpate.Styles, previewStyles) OrElse Not Equals(currentTemlpate.Template, previewTemplate) Then
                previewStyles = currentTemlpate.Styles
                previewTemplate = currentTemlpate.Template
                htmlPreview.HtmlTemplate.Set($"<div class=""preview-h-container""><div class=""preview-v-container"" id=""previewRoot"">{previewTemplate}</div></div>", $".preview-h-container{{display:flex;flex-direction:row;align-items:center;justify-content: center;height: 100%;}}.preview-v-container{{display:flex;flex-direction:column;}}{previewStyles}")
            End If
        End Sub

        Private Sub TemplateViewer_ActiveTemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitAlertInfo(templateViewer.ActiveTemplate)
        End Sub

        Private Sub InitAlertInfo(ByVal currentTemplate As HtmlTemplate)
            If currentTemplate Is glowTemplate Then
                alertInfoProperties.Init("Sample Alert", "The color of a glowing effect around this alert box changes depending on the color of the ""Image"" icon", True)
            ElseIf currentTemplate Is toastTemplate Then
                alertInfoProperties.Init("Windows 11 Inspired Toast", "Use the selector at the top right corner to change a template. Click the ""Show an Alert"" button to display a notification.", False)
            ElseIf currentTemplate Is simpleTemplate Then
                alertInfoProperties.Init("Sample Alert", "Use the selector at the top right corner to change a template. Click the ""Show an Alert"" button to display a notification.", True)
            ElseIf currentTemplate Is darkTemplate Then
                alertInfoProperties.Init(Nothing, "Use the selector at the top right corner to change a template. Click the ""Show an Alert"" button to display a notification.", False)
            End If
        End Sub

        Private Sub AlertControl1_HtmlElementMouseClick(ByVal sender As Object, ByVal e As AlertHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "closeButton") OrElse e.ParentHasId("closeButton") OrElse Equals(e.ElementId, "okButton") OrElse e.ParentHasId("okButton") Then
                e.HtmlPopup.Close()
            Else
                e.HtmlPopup.Pinned = Not e.HtmlPopup.Pinned
            End If
        End Sub

        Private Sub AlertControl1_BeforeFormShow(ByVal sender As Object, ByVal e As AlertFormEventArgs)
            e.HtmlPopup.HtmlTemplate.Assign(GetCurrentTemplate())
        End Sub

        Private Function GetCurrentSvgImageColor() As String
            Dim image As SvgImage = alertInfoProperties.SvgImage
            If alertInfoProperties.SvgImage Is Nothing Then Return Nothing
            Return GetCurrentSvgImageColor(image.Root)
        End Function

        Private Function GetCurrentSvgImageColor(ByVal element As SvgElement) As String
            If Not String.IsNullOrEmpty(element.Fill) Then Return element.StyleName
            For Each child As SvgElement In element.Elements
                Dim color As String = GetCurrentSvgImageColor(child)
                If Not Equals(color, Nothing) Then Return color
            Next

            Return Nothing
        End Function

        Private Function GetPatchedGlowTemplate(ByVal template As HtmlTemplate) As HtmlTemplate
            Dim colorName As String = GetCurrentSvgImageColor()
            If String.IsNullOrEmpty(colorName) Then Return template
            Dim styles As String = template.Styles.Replace("@Black", "@" & colorName)
            Return New HtmlTemplate(template.Template, styles)
        End Function

        Private Function GetPatchedTemplate(ByVal template As HtmlTemplate) As HtmlTemplate
            If Equals(template.Name, glowTemplate.Name) Then
                Return GetPatchedGlowTemplate(template)
            Else
                Return template
            End If
        End Function

        Private Function GetCurrentTemplate() As HtmlTemplate
            Return GetPatchedTemplate(templateViewer.ActiveTemplate)
        End Function

        Private Function GetCurrentAlertInfo() As AlertInfo
            Dim info As AlertInfo = New AlertInfo(Nothing, Nothing)
            alertInfoProperties.UpdateAlertInfo(info)
            Return info
        End Function

        Private Sub UpdateAlertinfo(ByVal info As AlertInfo)
            alertInfoProperties.UpdateAlertInfo(info)
        End Sub

        Private Sub ShowAlertButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            alertControl1.Show(FindForm(), GetCurrentAlertInfo())
        End Sub
    End Class
End Namespace
