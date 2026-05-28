Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.HTML.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Text Formatting", "Html.cs")>
    Public Module HtmlTextFormatting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            Dim images = New DevExpress.Utils.SvgImageCollection()
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg")
            images.Add("info", "image://svgimages/icon builder/actions_info.svg")
            images.Add("logo", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("logo"))
            htmlContentControl.HtmlImages = images
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Semantics")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.Semantics"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.Semantics")>
        Public Sub Semantics(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Semantics.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Semantics.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("New Line")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.NewLine"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.NewLine")>
        Public Sub NewLine(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("NewLine.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("NewLine.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Headings")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.Headings"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.Headings")>
        Public Sub Headings(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Headings.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Headings.css"))
        End Sub
    End Module

    '[CodeExampleClass("Link", "Html.cs")]
    Public Module HtmlLink

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            Dim images = New DevExpress.Utils.SvgImageCollection()
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg")
            htmlContentControl.HtmlImages = images
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Link Navigation")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.LinkNavigation"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.LinkNavigation")>
        Public Sub LinkNavigation(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkNavigation.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkNavigation.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Link Auto-Navigation")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.LinkAutoNavigation"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.LinkAutoNavigation")>
        Public Sub LinkAutoNavigation(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkAutoNavigation.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkAutoNavigation.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Link Click")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.LinkClick"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.LinkClick")>
        Public Sub LinkClick(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkClick.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("LinkClick.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("List", "Html.cs")>
    Public Module HtmlList

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            Dim images = New DevExpress.Utils.SvgImageCollection()
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg")
            images.Add("info", "image://svgimages/icon builder/actions_info.svg")
            images.Add("warning", "image://svgimages/icon builder/security_warningcircled2.svg")
            images.Add("clock", "image://svgimages/outlook inspired/employeequickprobationnotice.svg")
            images.Add("walking", "image://svgimages/outlook inspired/walking.svg")
            images.Add("attention", "image://svgimages/business objects/bo_attention.svg")
            htmlContentControl.HtmlImages = images
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Unordered List")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.UnorderedList"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.UnorderedList")>
        Public Sub UnorderedList(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("UnorderedList.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("UnorderedList.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Numbered List")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.NumberedList"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.NumberedList")>
        Public Sub NumberedList(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("NumberedList.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("NumberedList.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("List Markers")>
        <DevExpress.HTML.Demos.CodeExamples.HtmlFile("Html.ListMarkers"), DevExpress.HTML.Demos.CodeExamples.CssFile("Html.ListMarkers")>
        Public Sub ListMarkers(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListMarkers.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListMarkers.css"))
        End Sub
    End Module
End Namespace
