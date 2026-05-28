using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos.CodeExamples {
    [CodeExampleClass("Text Formatting", "Html.cs")]
    public static class HtmlTextFormatting {
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
        [CodeExampleCase("Semantics")]
        [HtmlFile("Html.Semantics"), CssFile("Html.Semantics")]
        public static void Semantics(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Semantics.html"), Loader.Load("Semantics.css"));
        }
        [CodeExampleCase("New Line")]
        [HtmlFile("Html.NewLine"), CssFile("Html.NewLine")]
        public static void NewLine(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("NewLine.html"), Loader.Load("NewLine.css"));

        }
        [CodeExampleCase("Headings")]
        [HtmlFile("Html.Headings"), CssFile("Html.Headings")]
        public static void Headings(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Headings.html"), Loader.Load("Headings.css"));
        }
    }
    //[CodeExampleClass("Link", "Html.cs")]
    public static class HtmlLink {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("Link Navigation")]
        [HtmlFile("Html.LinkNavigation"), CssFile("Html.LinkNavigation")]
        public static void LinkNavigation(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("LinkNavigation.html"), Loader.Load("LinkNavigation.css"));
        }
        [CodeExampleCase("Link Auto-Navigation")]
        [HtmlFile("Html.LinkAutoNavigation"), CssFile("Html.LinkAutoNavigation")]
        public static void LinkAutoNavigation(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("LinkAutoNavigation.html"), Loader.Load("LinkAutoNavigation.css"));
        }
        [CodeExampleCase("Link Click")]
        [HtmlFile("Html.LinkClick"), CssFile("Html.LinkClick")]
        public static void LinkClick(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("LinkClick.html"), Loader.Load("LinkClick.css"));
        }
    }
    [CodeExampleClass("List", "Html.cs")]
    public static class HtmlList {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            var images = new SvgImageCollection();
            images.Add("employee", "image://svgimages/business objects/bo_employee.svg");
            images.Add("info", "image://svgimages/icon builder/actions_info.svg");
            images.Add("warning", "image://svgimages/icon builder/security_warningcircled2.svg");
            images.Add("clock", "image://svgimages/outlook inspired/employeequickprobationnotice.svg");
            images.Add("walking", "image://svgimages/outlook inspired/walking.svg");
            images.Add("attention", "image://svgimages/business objects/bo_attention.svg");
            htmlContentControl.HtmlImages = images;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("Unordered List")]
        [HtmlFile("Html.UnorderedList"), CssFile("Html.UnorderedList")]
        public static void UnorderedList(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("UnorderedList.html"), Loader.Load("UnorderedList.css"));
        }
        [CodeExampleCase("Numbered List")]
        [HtmlFile("Html.NumberedList"), CssFile("Html.NumberedList")]
        public static void NumberedList(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("NumberedList.html"), Loader.Load("NumberedList.css"));
        }
        [CodeExampleCase("List Markers")]
        [HtmlFile("Html.ListMarkers"), CssFile("Html.ListMarkers")]
        public static void ListMarkers(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ListMarkers.html"), Loader.Load("ListMarkers.css"));
        }
    }
}
