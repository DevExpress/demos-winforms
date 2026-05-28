using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.CodeExamples {
    [CodeExampleClass("Colors & Shadows", "Css.cs")]
    public static class HtmlColorsAndShadows {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("color")]
        [CssFile("Css.Color"), HtmlFile("Css.Color")]
        public static void Color(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Color.html"), Loader.Load("Color.css"));
        }
        [CodeExampleCase("fill")]
        [CssFile("Css.Fill"), HtmlFile("Css.Fill")]
        public static void Fill(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Fill.html"), Loader.Load("Fill.css"));
        }
        [CodeExampleCase("background-color")]
        [CssFile("Css.BackgroundColor"), HtmlFile("Css.BackgroundColor")]
        public static void BackgroundColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundColor.html"), Loader.Load("BackgroundColor.css"));
        }
        [CodeExampleCase("opacity")]
        [CssFile("Css.Opacity"), HtmlFile("Css.Opacity")]
        public static void Opacity(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Opacity.html"), Loader.Load("Opacity.css"));
        }
        [CodeExampleCase("box-shadow")]
        [CssFile("Css.BoxShadow"), HtmlFile("Css.BoxShadow")]
        public static void BoxShadow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BoxShadow.html"), Loader.Load("BoxShadow.css"));
        }
    }
    [CodeExampleClass("Background", "Css.cs")]
    public static class HtmlBackground {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("ellipse-1", Assets.SvgImages["svg-ellipse-1"]);
            images.Add("ellipse-2", Assets.SvgImages["svg-ellipse-2"]);
            images.Add("ellipse-3", Assets.SvgImages["svg-ellipse-3"]);
            images.Add("ellipse-4", Assets.SvgImages["svg-ellipse-4"]);
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("background-color")]
        [CssFile("Css.BackgroundColor"), HtmlFile("Css.BackgroundColor")]
        public static void BackgroundColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundColor.html"), Loader.Load("BackgroundColor.css"));
        }
        [CodeExampleCase("background-image")]
        [CssFile("Css.BackgroundImage"), HtmlFile("Css.BackgroundImage")]
        public static void BackgroundImage(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundImage.html"), Loader.Load("BackgroundImage.css"));
        }
        [CodeExampleCase("background-repeat")]
        [CssFile("Css.BackgroundRepeat"), HtmlFile("Css.BackgroundRepeat")]
        public static void BackgroundRepeat(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundRepeat.html"), Loader.Load("BackgroundRepeat.css"));
        }
        [CodeExampleCase("background-position")]
        [CssFile("Css.BackgroundPosition"), HtmlFile("Css.BackgroundPosition")]
        public static void BackgroundPosition(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundPosition.html"), Loader.Load("BackgroundPosition.css"));
        }
        [CodeExampleCase("background-size")]
        [CssFile("Css.BackgroundSize"), HtmlFile("Css.BackgroundSize")]
        public static void BackgroundSize(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BackgroundSize.html"), Loader.Load("BackgroundSize.css"));
        }
    }
    [CodeExampleClass("Margin", "Css.cs")]
    public static class HtmlMargin {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("margin")]
        [CssFile("Css.Margin"), HtmlFile("Css.Margin")]
        public static void Margin(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Margin.html"), Loader.Load("Margin.css"));
        }
        [CodeExampleCase("margin-top")]
        [CssFile("Css.MarginTop"), HtmlFile("Css.MarginTop")]
        public static void MarginTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MarginTop.html"), Loader.Load("MarginTop.css"));
        }
        [CodeExampleCase("margin-bottom")]
        [CssFile("Css.MarginBottom"), HtmlFile("Css.MarginBottom")]
        public static void MarginBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MarginBottom.html"), Loader.Load("MarginBottom.css"));
        }
        [CodeExampleCase("margin-left")]
        [CssFile("Css.MarginLeft"), HtmlFile("Css.MarginLeft")]
        public static void MarginLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MarginLeft.html"), Loader.Load("MarginLeft.css"));
        }
        [CodeExampleCase("margin-right")]
        [CssFile("Css.MarginRight"), HtmlFile("Css.MarginRight")]
        public static void MarginRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MarginRight.html"), Loader.Load("MarginRight.css"));
        }
    }
    [CodeExampleClass("Padding", "Css.cs")]
    public static class HtmlPadding {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("padding")]
        [CssFile("Css.Paddings"), HtmlFile("Css.Padding")]
        public static void Padding(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Padding.html"), Loader.Load("Paddings.css"));
        }
        [CodeExampleCase("padding-left")]
        [CssFile("Css.PaddingLeft"), HtmlFile("Css.PaddingLeft")]
        public static void PaddingLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("PaddingLeft.html"), Loader.Load("PaddingLeft.css"));
        }
        [CodeExampleCase("padding-right")]
        [CssFile("Css.PaddingRight"), HtmlFile("Css.PaddingRight")]
        public static void PaddingRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("PaddingRight.html"), Loader.Load("PaddingRight.css"));
        }
        [CodeExampleCase("padding-top")]
        [CssFile("Css.PaddingTop"), HtmlFile("Css.PaddingTop")]
        public static void PaddingTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("PaddingTop.html"), Loader.Load("PaddingTop.css"));
        }
        [CodeExampleCase("padding-bottom")]
        [CssFile("Css.PaddingBottom"), HtmlFile("Css.PaddingBottom")]
        public static void PaddingBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("PaddingBottom.html"), Loader.Load("PaddingBottom.css"));
        }
    }
    [CodeExampleClass("Border", "Css.cs")]
    public static class HtmlBorder {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("border")]
        [CssFile("Css.Borders"), HtmlFile("Css.Borders")]
        public static void Border(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Borders.html"), Loader.Load("Borders.css"));
        }
        [CodeExampleCase("border-color")]
        [CssFile("Css.BorderColor"), HtmlFile("Css.BorderColor")]
        public static void BorderColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderColor.html"), Loader.Load("BorderColor.css"));
        }
        [CodeExampleCase("border-style")]
        [CssFile("Css.BorderStyle"), HtmlFile("Css.BorderStyle")]
        public static void BorderStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderStyle.html"), Loader.Load("BorderStyle.css"));
        }
        [CodeExampleCase("border-width")]
        [CssFile("Css.BorderWidth"), HtmlFile("Css.BorderWidth")]
        public static void BorderWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderWidth.html"), Loader.Load("BorderWidth.css"));
        }
        [CodeExampleCase("border-radius")]
        [CssFile("Css.BorderRadius"), HtmlFile("Css.BorderRadius")]
        public static void BorderRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderRadius.html"), Loader.Load("BorderRadius.css"));
        }
        [CodeExampleCase("border-spacing")]
        [CssFile("Css.BorderSpacing"), HtmlFile("Css.BorderSpacing")]
        public static void BorderSpacing(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderSpacing.html"), Loader.Load("BorderSpacing.css"));
        }
        [CodeExampleCase("border-top")]
        [CssFile("Css.BorderTop"), HtmlFile("Css.BorderTop")]
        public static void BorderTop(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTop.html"), Loader.Load("BorderTop.css"));
        }
        [CodeExampleCase("border-top-color")]
        [CssFile("Css.BorderTopColor"), HtmlFile("Css.BorderTopColor")]
        public static void BorderTopColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTopColor.html"), Loader.Load("BorderTopColor.css"));
        }
        [CodeExampleCase("border-top-style")]
        [CssFile("Css.BorderTopStyle"), HtmlFile("Css.BorderTopStyle")]
        public static void BorderTopStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTopStyle.html"), Loader.Load("BorderTopStyle.css"));
        }
        [CodeExampleCase("border-top-width")]
        [CssFile("Css.BorderTopWidth"), HtmlFile("Css.BorderTopWidth")]
        public static void BorderTopWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTopWidth.html"), Loader.Load("BorderTopWidth.css"));
        }
        [CodeExampleCase("border-bottom")]
        [CssFile("Css.BorderBottom"), HtmlFile("Css.BorderBottom")]
        public static void BorderBottom(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottom.html"), Loader.Load("BorderBottom.css"));
        }
        [CodeExampleCase("border-bottom-color")]
        [CssFile("Css.BorderBottomColor"), HtmlFile("Css.BorderBottomColor")]
        public static void BorderBottomColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottomColor.html"), Loader.Load("BorderBottomColor.css"));
        }
        [CodeExampleCase("border-bottom-style")]
        [CssFile("Css.BorderBottomStyle"), HtmlFile("Css.BorderBottomStyle")]
        public static void BorderBottomStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottomStyle.html"), Loader.Load("BorderBottomStyle.css"));
        }
        [CodeExampleCase("border-bottom-width")]
        [CssFile("Css.BorderBottomWidth"), HtmlFile("Css.BorderBottomWidth")]
        public static void BorderBottomWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottomWidth.html"), Loader.Load("BorderBottomWidth.css"));
        }
        [CodeExampleCase("border-left")]
        [CssFile("Css.BorderLeft"), HtmlFile("Css.BorderLeft")]
        public static void BorderLeft(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderLeft.html"), Loader.Load("BorderLeft.css"));
        }
        [CodeExampleCase("border-left-color")]
        [CssFile("Css.BorderLeftColor"), HtmlFile("Css.BorderLeftColor")]
        public static void BorderLeftColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderLeftColor.html"), Loader.Load("BorderLeftColor.css"));
        }
        [CodeExampleCase("border-left-style")]
        [CssFile("Css.BorderLeftStyle"), HtmlFile("Css.BorderLeftStyle")]
        public static void BorderLeftStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderLeftStyle.html"), Loader.Load("BorderLeftStyle.css"));
        }
        [CodeExampleCase("border-left-width")]
        [CssFile("Css.BorderLeftWidth"), HtmlFile("Css.BorderLeftWidth")]
        public static void BorderLeftWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderLeftWidth.html"), Loader.Load("BorderLeftWidth.css"));
        }
        [CodeExampleCase("border-right")]
        [CssFile("Css.BorderRight"), HtmlFile("Css.BorderRight")]
        public static void BorderRight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderRight.html"), Loader.Load("BorderRight.css"));
        }
        [CodeExampleCase("border-right-color")]
        [CssFile("Css.BorderRightColor"), HtmlFile("Css.BorderRightColor")]
        public static void BorderRightColor(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderRightColor.html"), Loader.Load("BorderRightColor.css"));
        }
        [CodeExampleCase("border-right-style")]
        [CssFile("Css.BorderRightStyle"), HtmlFile("Css.BorderRightStyle")]
        public static void BorderRightStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderRightStyle.html"), Loader.Load("BorderRightStyle.css"));
        }
        [CodeExampleCase("border-right-width")]
        [CssFile("Css.BorderRightWidth"), HtmlFile("Css.BorderRightWidth")]
        public static void BorderRightWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderRightWidth.html"), Loader.Load("BorderRightWidth.css"));
        }
        [CodeExampleCase("border-top-left-radius")]
        [CssFile("Css.BorderTopLeftRadius"), HtmlFile("Css.BorderTopLeftRadius")]
        public static void BorderTopLeftRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTopLeftRadius.html"), Loader.Load("BorderTopLeftRadius.css"));
        }
        [CodeExampleCase("border-top-right-radius")]
        [CssFile("Css.BorderTopRightRadius"), HtmlFile("Css.BorderTopRightRadius")]
        public static void BorderTopRightRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderTopRightRadius.html"), Loader.Load("BorderTopRightRadius.css"));
        }
        [CodeExampleCase("border-bottom-left-radius")]
        [CssFile("Css.BorderBottomLeftRadius"), HtmlFile("Css.BorderBottomLeftRadius")]
        public static void BorderBottomLeftRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottomLeftRadius.html"), Loader.Load("BorderBottomLeftRadius.css"));
        }
        [CodeExampleCase("border-bottom-right-radius")]
        [CssFile("Css.BorderBottomRightRadius"), HtmlFile("Css.BorderBottomRightRadius")]
        public static void BorderBottomRightRadius(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("BorderBottomRightRadius.html"), Loader.Load("BorderBottomRightRadius.css"));
        }
    }

    [CodeExampleClass("Size", "Css.cs")]
    public static class HtmlSize {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("width")]
        [CssFile("Css.Width"), HtmlFile("Css.Width")]
        public static void Width(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Width.html"), Loader.Load("Width.css"));
        }
        [CodeExampleCase("height")]
        [CssFile("Css.Height"), HtmlFile("Css.Height")]
        public static void Height(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Height.html"), Loader.Load("Height.css"));
        }
        [CodeExampleCase("max-width")]
        [CssFile("Css.MaxWidth"), HtmlFile("Css.MaxWidth")]
        public static void MaxWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MaxWidth.html"), Loader.Load("MaxWidth.css"));
        }
        [CodeExampleCase("max-height")]
        [CssFile("Css.MaxHeight"), HtmlFile("Css.MaxHeight")]
        public static void MaxHeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MaxHeight.html"), Loader.Load("MaxHeight.css"));
        }
        [CodeExampleCase("min-height")]
        [CssFile("Css.MinHeight"), HtmlFile("Css.MinHeight")]
        public static void MinHeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MinHeight.html"), Loader.Load("MinHeight.css"));
        }
        [CodeExampleCase("min-width")]
        [CssFile("Css.MinWidth"), HtmlFile("Css.MinWidth")]
        public static void MinWidth(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("MinWidth.html"), Loader.Load("MinWidth.css"));
        }
        [CodeExampleCase("overflow")]
        [CssFile("Css.Overflow"), HtmlFile("Css.Overflow")]
        public static void Overflow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Overflow.html"), Loader.Load("Overflow.css"));
        }
    }
    [CodeExampleClass("Font", "Css.cs")]
    public static class HtmlFont {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("font")]
        [CssFile("Css.Font"), HtmlFile("Css.Font")]
        public static void Font(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Font.html"), Loader.Load("Font.css"));
        }
        [CodeExampleCase("font-family")]
        [CssFile("Css.FontFamily"), HtmlFile("Css.FontFamily")]
        public static void FontFamily(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FontFamily.html"), Loader.Load("FontFamily.css"));
        }
        [CodeExampleCase("font-size")]
        [CssFile("Css.FontSize"), HtmlFile("Css.FontSize")]
        public static void FontSize(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FontSize.html"), Loader.Load("FontSize.css"));
        }
        [CodeExampleCase("font-style")]
        [CssFile("Css.FontStyle"), HtmlFile("Css.FontStyle")]
        public static void FontStyle(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FontStyle.html"), Loader.Load("FontStyle.css"));
        }
        [CodeExampleCase("font-weight")]
        [CssFile("Css.FontWeight"), HtmlFile("Css.FontWeight")]
        public static void FontWeight(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FontWeight.html"), Loader.Load("FontWeight.css"));
        }
    }
    [CodeExampleClass("Text", "Css.cs")]
    public static class HtmlText {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("text-align")]
        [CssFile("Css.TextAlign"), HtmlFile("Css.TextAlign")]
        public static void TextAlign(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("TextAlign.html"), Loader.Load("TextAlign.css"));
        }
        [CodeExampleCase("white-space")]
        [CssFile("Css.WhiteSpace"), HtmlFile("Css.WhiteSpace")]
        public static void WhiteSpace(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("WhiteSpace.html"), Loader.Load("WhiteSpace.css"));
        }
        [CodeExampleCase("text-decoration-line")]
        [CssFile("Css.TextDecorationLine"), HtmlFile("Css.TextDecorationLine")]
        public static void TextDecorationLine(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("TextDecorationLine.html"), Loader.Load("TextDecorationLine.css"));
        }
        [CodeExampleCase("text-overflow")]
        [CssFile("Css.TextOverflow"), HtmlFile("Css.TextOverflow")]
        public static void TextOverflow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("TextOverflow.html"), Loader.Load("TextOverflow.css"));
        }
        [CodeExampleCase("overflow-wrap")]
        [CssFile("Css.OverflowWrap"), HtmlFile("Css.OverflowWrap")]
        public static void OverflowWrap(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("OverflowWrap.html"), Loader.Load("OverflowWrap.css"));
        }
    }
    [CodeExampleClass("List", "Css.cs")]
    public static class HtmlLists {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("list-style-position")]
        [CssFile("Css.ListStylePosition"), HtmlFile("Css.ListStylePosition")]
        public static void ListStylePosition(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ListStylePosition.html"), Loader.Load("ListStylePosition.css"));
        }
        [CodeExampleCase("list-style-type")]
        [CssFile("Css.ListStyleType"), HtmlFile("Css.ListStyleType")]
        public static void ListStyleType(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ListStyleType.html"), Loader.Load("ListStyleType.css"));
        }
    }
    [CodeExampleClass("Image", "Css.cs")]
    public static class HtmlImage {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new ImageCollection();
            var assembly = typeof(DevExpress.HTML.Demos.CodeExamples.HtmlImage).Assembly;
            var imageResName = assembly.GetManifestResourceNames().FirstOrDefault(n => n.EndsWith("auto.png"));
            var stream = assembly.GetManifestResourceStream(imageResName);
            var image = System.Drawing.Image.FromStream(stream);
            images.ImageSize = new System.Drawing.Size(image.Width, image.Height);
            images.AddImage(image, "image");
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("object-fit")]
        [CssFile("Css.ObjectFit"), HtmlFile("Css.ObjectFit")]
        public static void ObjectFit(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ObjectFit.html"), Loader.Load("ObjectFit.css"));
        }
    }
    [CodeExampleClass("Selection", "Css.cs")]
    public static class HtmlSelection {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            HtmlContentControl htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            htmlContentControl.AllowContentSelection = DefaultBoolean.True;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        public static DevExpress.Utils.Html.Internal.IDxHtmlSelection GetSelection(HtmlContentControl htmlContentControl) {
            DevExpress.Utils.Html.DxHtmlRootElement root = ((DevExpress.XtraEditors.IHtmlContentControl)htmlContentControl).Element;
            if(root != null)
                return root.Selection;
            return null;
        }
        [CodeExampleCase("::selection")]
        [CssFile("Css.Selection"), HtmlFile("Css.Selection")]
        public static void Selection(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Selection.html"), Loader.Load("Selection.css"));
            var selection = DevExpress.HTML.Demos.CodeExamples.HtmlSelection.GetSelection(htmlContentControl);
            if(selection == null)
                return;
            var textElement = htmlContentControl.FindElementById("text-container").ChildNodes.First() as DevExpress.Utils.Html.DxHtmlElementBase;
            selection.Current = new DevExpress.Utils.Html.Internal.DxHtmlSelectionRange(textElement, textElement, 20, 300);
        }
        [CodeExampleCase("user-select")]
        [CssFile("Css.UserSelect"), HtmlFile("Css.UserSelect")]
        public static void UserSelect(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("UserSelect.html"), Loader.Load("UserSelect.css"));
            var selection = DevExpress.HTML.Demos.CodeExamples.HtmlSelection.GetSelection(htmlContentControl);
            if(selection == null)
                return;
            var textElement = htmlContentControl.FindElementById("text-container").ChildNodes.First() as DevExpress.Utils.Html.DxHtmlElementBase;
            selection.Current = new DevExpress.Utils.Html.Internal.DxHtmlSelectionRange(textElement, textElement, 20, 300);
        }
    }
    [CodeExampleClass("Layout", "Css.cs")]
    public static class HtmlLayout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("display")]
        [CssFile("Css.Display"), HtmlFile("Css.Display")]
        public static void Display(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Display.html"), Loader.Load("Display.css"));
        }
        [CodeExampleCase("visibility")]
        [CssFile("Css.Visibility"), HtmlFile("Css.Visibility")]
        public static void Visibility(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Visibility.html"), Loader.Load("Visibility.css"));
        }
        [CodeExampleCase("position")]
        [CssFile("Css.Position"), HtmlFile("Css.Position")]
        public static void Position(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Position.html"), Loader.Load("Position.css"));
        }
        [CodeExampleCase("top / bottom / left / right")]
        [CssFile("Css.PositionMargins"), HtmlFile("Css.PositionMargins")]
        public static void PositionMargins(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("PositionMargins.html"), Loader.Load("PositionMargins.css"));
        }
        [CodeExampleCase("z-index")]
        [CssFile("Css.ZIndex"), HtmlFile("Css.ZIndex")]
        public static void ZIndex(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ZIndex.html"), Loader.Load("ZIndex.css"));
        }
    }
    [CodeExampleClass("Flex", "Css.cs")]
    public static class HtmlFlex {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("logo", Assets.SvgImages["logo"]);
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("flex-direction")]
        [CssFile("Css.FlexDirection"), HtmlFile("Css.FlexDirection")]
        public static void FlexDirection(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FlexDirection.html"), Loader.Load("FlexDirection.css"));
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("flex-wrap")]
        [CssFile("Css.FlexWrap"), HtmlFile("Css.FlexWrap")]
        public static void FlexWrap(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FlexWrap.html"), Loader.Load("FlexWrap.css"));
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("justify-content")]
        [CssFile("Css.JustifyContent"), HtmlFile("Css.JustifyContent")]
        public static void JustifyContent(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("JustifyContent.html"), Loader.Load("JustifyContent.css"));
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("align-items")]
        [CssFile("Css.AlignItems"), HtmlFile("Css.AlignItems")]
        public static void AlignItems(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("AlignItems.html"), Loader.Load("AlignItems.css"));
        }
        [CodeExampleGroupName("Container")]
        [CodeExampleCase("align-content")]
        [CssFile("Css.AlignContent"), HtmlFile("Css.AlignContent")]
        public static void AlignContent(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("AlignContent.html"), Loader.Load("AlignContent.css"));
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("order")]
        [CssFile("Css.Order"), HtmlFile("Css.Order")]
        public static void Order(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Order.html"), Loader.Load("Order.css"));
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-grow")]
        [CssFile("Css.FlexGrow"), HtmlFile("Css.FlexGrow")]
        public static void FlexGrow(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FlexGrow.html"), Loader.Load("FlexGrow.css"));
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-shrink")]
        [CssFile("Css.FlexShrink"), HtmlFile("Css.FlexShrink")]
        public static void FlexShrink(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FlexShrink.html"), Loader.Load("FlexShrink.css"));
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("flex-basis")]
        [CssFile("Css.FlexBasis"), HtmlFile("Css.FlexBasis")]
        public static void FlexBasis(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("FlexBasis.html"), Loader.Load("FlexBasis.css"));
        }
        [CodeExampleGroupName("Items")]
        [CodeExampleCase("align-self")]
        [CssFile("Css.AlignSelf"), HtmlFile("Css.AlignSelf")]
        public static void AlignSelf(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("AlignSelf.html"), Loader.Load("AlignSelf.css"));
        }
    }
}
