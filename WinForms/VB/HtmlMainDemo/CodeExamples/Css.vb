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

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Colors & Shadows", "Css.cs")>
    Public Module HtmlColorsAndShadows

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Color"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Color")>
        Public Sub Color(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Color.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Color.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("fill")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Fill"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Fill")>
        Public Sub Fill(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Fill.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Fill.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundColor")>
        Public Sub BackgroundColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("opacity")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Opacity"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Opacity")>
        Public Sub Opacity(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Opacity.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Opacity.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("box-shadow")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BoxShadow"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BoxShadow")>
        Public Sub BoxShadow(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BoxShadow.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BoxShadow.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Background", "Css.cs")>
    Public Module HtmlBackground

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            Dim images = New DevExpress.Utils.SvgImageCollection()
            images.Add("ellipse-1", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("svg-ellipse-1"))
            images.Add("ellipse-2", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("svg-ellipse-2"))
            images.Add("ellipse-3", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("svg-ellipse-3"))
            images.Add("ellipse-4", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("svg-ellipse-4"))
            images.Add("logo", DevExpress.DXperience.Demos.CodeDemo.Helpers.Assets.SvgImages("logo"))
            htmlContentControl.HtmlImages = images
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundColor")>
        Public Sub BackgroundColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-image")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundImage"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundImage")>
        Public Sub BackgroundImage(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundImage.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundImage.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-repeat")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundRepeat"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundRepeat")>
        Public Sub BackgroundRepeat(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundRepeat.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundRepeat.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-position")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundPosition"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundPosition")>
        Public Sub BackgroundPosition(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundPosition.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundPosition.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("background-size")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BackgroundSize"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BackgroundSize")>
        Public Sub BackgroundSize(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundSize.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BackgroundSize.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Margin", "Css.cs")>
    Public Module HtmlMargin

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("margin")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Margin"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Margin")>
        Public Sub Margin(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Margin.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Margin.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("margin-top")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MarginTop"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MarginTop")>
        Public Sub MarginTop(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginTop.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginTop.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("margin-bottom")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MarginBottom"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MarginBottom")>
        Public Sub MarginBottom(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginBottom.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginBottom.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("margin-left")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MarginLeft"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MarginLeft")>
        Public Sub MarginLeft(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginLeft.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginLeft.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("margin-right")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MarginRight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MarginRight")>
        Public Sub MarginRight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginRight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MarginRight.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Padding", "Css.cs")>
    Public Module HtmlPadding

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("padding")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Paddings"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Padding")>
        Public Sub Padding(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Padding.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Paddings.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("padding-left")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.PaddingLeft"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.PaddingLeft")>
        Public Sub PaddingLeft(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingLeft.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingLeft.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("padding-right")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.PaddingRight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.PaddingRight")>
        Public Sub PaddingRight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingRight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingRight.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("padding-top")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.PaddingTop"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.PaddingTop")>
        Public Sub PaddingTop(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingTop.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingTop.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("padding-bottom")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.PaddingBottom"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.PaddingBottom")>
        Public Sub PaddingBottom(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingBottom.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PaddingBottom.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Border", "Css.cs")>
    Public Module HtmlBorder

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Borders"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Borders")>
        Public Sub Border(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Borders.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Borders.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderColor")>
        Public Sub BorderColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderStyle")>
        Public Sub BorderStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderWidth")>
        Public Sub BorderWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-radius")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderRadius"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderRadius")>
        Public Sub BorderRadius(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRadius.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRadius.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-spacing")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderSpacing"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderSpacing")>
        Public Sub BorderSpacing(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderSpacing.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderSpacing.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTop"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTop")>
        Public Sub BorderTop(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTop.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTop.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTopColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTopColor")>
        Public Sub BorderTopColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTopStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTopStyle")>
        Public Sub BorderTopStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTopWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTopWidth")>
        Public Sub BorderTopWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottom"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottom")>
        Public Sub BorderBottom(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottom.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottom.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottomColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottomColor")>
        Public Sub BorderBottomColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottomStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottomStyle")>
        Public Sub BorderBottomStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottomWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottomWidth")>
        Public Sub BorderBottomWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-left")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderLeft"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderLeft")>
        Public Sub BorderLeft(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeft.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeft.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-left-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderLeftColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderLeftColor")>
        Public Sub BorderLeftColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-left-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderLeftStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderLeftStyle")>
        Public Sub BorderLeftStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-left-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderLeftWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderLeftWidth")>
        Public Sub BorderLeftWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderLeftWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-right")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderRight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderRight")>
        Public Sub BorderRight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRight.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-right-color")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderRightColor"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderRightColor")>
        Public Sub BorderRightColor(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightColor.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightColor.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-right-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderRightStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderRightStyle")>
        Public Sub BorderRightStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-right-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderRightWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderRightWidth")>
        Public Sub BorderRightWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderRightWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top-left-radius")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTopLeftRadius"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTopLeftRadius")>
        Public Sub BorderTopLeftRadius(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopLeftRadius.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopLeftRadius.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-top-right-radius")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderTopRightRadius"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderTopRightRadius")>
        Public Sub BorderTopRightRadius(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopRightRadius.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderTopRightRadius.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom-left-radius")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottomLeftRadius"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottomLeftRadius")>
        Public Sub BorderBottomLeftRadius(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomLeftRadius.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomLeftRadius.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("border-bottom-right-radius")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.BorderBottomRightRadius"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.BorderBottomRightRadius")>
        Public Sub BorderBottomRightRadius(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomRightRadius.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("BorderBottomRightRadius.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Size", "Css.cs")>
    Public Module HtmlSize

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Width"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Width")>
        Public Sub Width(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Width.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Width.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("height")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Height"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Height")>
        Public Sub Height(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Height.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Height.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("max-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MaxWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MaxWidth")>
        Public Sub MaxWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MaxWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MaxWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("max-height")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MaxHeight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MaxHeight")>
        Public Sub MaxHeight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MaxHeight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MaxHeight.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("min-height")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MinHeight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MinHeight")>
        Public Sub MinHeight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MinHeight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MinHeight.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("min-width")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.MinWidth"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.MinWidth")>
        Public Sub MinWidth(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MinWidth.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("MinWidth.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("overflow")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Overflow"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Overflow")>
        Public Sub Overflow(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Overflow.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Overflow.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Font", "Css.cs")>
    Public Module HtmlFont

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("font")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Font"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Font")>
        Public Sub Font(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Font.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Font.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("font-family")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FontFamily"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FontFamily")>
        Public Sub FontFamily(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontFamily.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontFamily.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("font-size")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FontSize"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FontSize")>
        Public Sub FontSize(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontSize.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontSize.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("font-style")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FontStyle"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FontStyle")>
        Public Sub FontStyle(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontStyle.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontStyle.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("font-weight")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FontWeight"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FontWeight")>
        Public Sub FontWeight(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontWeight.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FontWeight.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Text", "Css.cs")>
    Public Module HtmlText

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("text-align")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.TextAlign"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.TextAlign")>
        Public Sub TextAlign(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextAlign.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextAlign.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("white-space")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.WhiteSpace"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.WhiteSpace")>
        Public Sub WhiteSpace(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("WhiteSpace.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("WhiteSpace.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("text-decoration-line")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.TextDecorationLine"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.TextDecorationLine")>
        Public Sub TextDecorationLine(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextDecorationLine.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextDecorationLine.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("text-overflow")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.TextOverflow"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.TextOverflow")>
        Public Sub TextOverflow(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextOverflow.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("TextOverflow.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("overflow-wrap")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.OverflowWrap"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.OverflowWrap")>
        Public Sub OverflowWrap(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("OverflowWrap.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("OverflowWrap.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("List", "Css.cs")>
    Public Module HtmlLists

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("list-style-position")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.ListStylePosition"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.ListStylePosition")>
        Public Sub ListStylePosition(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListStylePosition.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListStylePosition.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("list-style-type")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.ListStyleType"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.ListStyleType")>
        Public Sub ListStyleType(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListStyleType.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ListStyleType.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Image", "Css.cs")>
    Public Module HtmlImage

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            Dim images = New DevExpress.Utils.ImageCollection()
            Dim assembly = GetType(DevExpress.HTML.Demos.CodeExamples.HtmlImage).Assembly
            Dim imageResName = assembly.GetManifestResourceNames().FirstOrDefault(Function(n) n.EndsWith("auto.png"))
            Dim stream = assembly.GetManifestResourceStream(imageResName)
            Dim image = System.Drawing.Image.FromStream(stream)
            images.ImageSize = New System.Drawing.Size(image.Width, image.Height)
            images.AddImage(image, "image")
            htmlContentControl.HtmlImages = images
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("object-fit")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.ObjectFit"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.ObjectFit")>
        Public Sub ObjectFit(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ObjectFit.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ObjectFit.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Selection", "Css.cs")>
    Public Module HtmlSelection

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim htmlContentControl As DevExpress.XtraEditors.HtmlContentControl = New DevExpress.XtraEditors.HtmlContentControl()
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill
            htmlContentControl.Parent = sampleHost
            htmlContentControl.AllowContentSelection = DevExpress.Utils.DefaultBoolean.[True]
            Return New Object() {htmlContentControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
        ' do nothing 
        End Sub

        Public Function GetSelection(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl) As DevExpress.Utils.Html.Internal.IDxHtmlSelection
            Dim root As DevExpress.Utils.Html.DxHtmlRootElement = CType(htmlContentControl, DevExpress.XtraEditors.IHtmlContentControl).Element
            If root IsNot Nothing Then Return root.Selection
            Return Nothing
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("::selection")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Selection"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Selection")>
        Public Sub Selection(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Selection.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Selection.css"))
            Dim lSelection = DevExpress.HTML.Demos.CodeExamples.HtmlSelection.GetSelection(htmlContentControl)
            If lSelection Is Nothing Then Return
            Dim textElement = TryCast(htmlContentControl.FindElementById(CStr(("text-container"))).ChildNodes.First(), DevExpress.Utils.Html.DxHtmlElementBase)
            lSelection.Current = New DevExpress.Utils.Html.Internal.DxHtmlSelectionRange(textElement, textElement, 20, 300)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("user-select")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.UserSelect"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.UserSelect")>
        Public Sub UserSelect(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("UserSelect.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("UserSelect.css"))
            Dim selection = DevExpress.HTML.Demos.CodeExamples.HtmlSelection.GetSelection(htmlContentControl)
            If selection Is Nothing Then Return
            Dim textElement = TryCast(htmlContentControl.FindElementById(CStr(("text-container"))).ChildNodes.First(), DevExpress.Utils.Html.DxHtmlElementBase)
            selection.Current = New DevExpress.Utils.Html.Internal.DxHtmlSelectionRange(textElement, textElement, 20, 300)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Layout", "Css.cs")>
    Public Module HtmlLayout

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("display")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Display"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Display")>
        Public Sub Display(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Display.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Display.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("visibility")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Visibility"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Visibility")>
        Public Sub Visibility(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Visibility.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Visibility.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("position")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Position"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Position")>
        Public Sub Position(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Position.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Position.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("top / bottom / left / right")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.PositionMargins"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.PositionMargins")>
        Public Sub PositionMargins(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PositionMargins.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("PositionMargins.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("z-index")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.ZIndex"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.ZIndex")>
        Public Sub ZIndex(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ZIndex.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("ZIndex.css"))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Flex", "Css.cs")>
    Public Module HtmlFlex

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Container")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("flex-direction")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FlexDirection"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FlexDirection")>
        Public Sub FlexDirection(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexDirection.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexDirection.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Container")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("flex-wrap")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FlexWrap"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FlexWrap")>
        Public Sub FlexWrap(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexWrap.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexWrap.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Container")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("justify-content")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.JustifyContent"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.JustifyContent")>
        Public Sub JustifyContent(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("JustifyContent.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("JustifyContent.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Container")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("align-items")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.AlignItems"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.AlignItems")>
        Public Sub AlignItems(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignItems.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignItems.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Container")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("align-content")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.AlignContent"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.AlignContent")>
        Public Sub AlignContent(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignContent.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignContent.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("order")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.Order"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.Order")>
        Public Sub Order(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Order.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("Order.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("flex-grow")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FlexGrow"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FlexGrow")>
        Public Sub FlexGrow(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexGrow.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexGrow.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("flex-shrink")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FlexShrink"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FlexShrink")>
        Public Sub FlexShrink(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexShrink.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexShrink.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("flex-basis")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.FlexBasis"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.FlexBasis")>
        Public Sub FlexBasis(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexBasis.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("FlexBasis.css"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleGroupName("Items")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("align-self")>
        <DevExpress.HTML.Demos.CodeExamples.CssFile("Css.AlignSelf"), DevExpress.HTML.Demos.CodeExamples.HtmlFile("Css.AlignSelf")>
        Public Sub AlignSelf(ByVal htmlContentControl As DevExpress.XtraEditors.HtmlContentControl)
            htmlContentControl.HtmlTemplate.[Set](DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignSelf.html"), DevExpress.DXperience.Demos.CodeDemo.Helpers.Loader.Load("AlignSelf.css"))
        End Sub
    End Module
End Namespace
