Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Templates", "TemplateGallery.cs")>
    Public Module HtmlTemplateGallery

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            htmlContentControl.HtmlImages = DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Buttons")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("TemplateGallery.Buttons"), DevExpress.HTML.Demos.CodeExamples.CssFile("TemplateGallery.Buttons")>
        Public Sub Buttons(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Buttons.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Buttons.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Button Group")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("TemplateGallery.ButtonGroup"), DevExpress.HTML.Demos.CodeExamples.CssFile("TemplateGallery.ButtonGroup")>
        Public Sub ButtonGroup(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ButtonGroup.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ButtonGroup.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Notifications")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("TemplateGallery.Notifications"), DevExpress.HTML.Demos.CodeExamples.CssFile("TemplateGallery.Notifications")>
        Public Sub Notifications(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Notifications.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Notifications.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Shining ProgressBar")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("TemplateGallery.ProgressBar"), DevExpress.HTML.Demos.CodeExamples.CssFile("TemplateGallery.ProgressBar")>
        Public Sub ProgressBar(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ProgressBar.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ProgressBar.css"))
        End Sub
    End Module
End Namespace
