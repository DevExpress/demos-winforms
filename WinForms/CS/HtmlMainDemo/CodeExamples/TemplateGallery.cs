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
    [CodeExampleClass("Templates", "TemplateGallery.cs")]
    public static class HtmlTemplateGallery {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var htmlContentControl = new HtmlContentControl();
            htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            htmlContentControl.Parent = sampleHost;
            htmlContentControl.HtmlImages = Assets.SvgImages;
            return new object[] { htmlContentControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            /* do nothing */
        }
        [CodeExampleCase("Buttons")]
        [HtmlFile("TemplateGallery.Buttons"), CssFile("TemplateGallery.Buttons")]
        public static void Buttons(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Buttons.html"), Loader.Load("Buttons.css"));
        }
        [CodeExampleCase("Button Group")]
        [HtmlFile("TemplateGallery.ButtonGroup"), CssFile("TemplateGallery.ButtonGroup")]
        public static void ButtonGroup(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ButtonGroup.html"), Loader.Load("ButtonGroup.css"));
        }
        [CodeExampleCase("Notifications")]
        [HtmlFile("TemplateGallery.Notifications"), CssFile("TemplateGallery.Notifications")]
        public static void Notifications(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("Notifications.html"), Loader.Load("Notifications.css"));
        }
        [CodeExampleCase("Shining ProgressBar")]
        [HtmlFile("TemplateGallery.ProgressBar"), CssFile("TemplateGallery.ProgressBar")]
        public static void ProgressBar(HtmlContentControl htmlContentControl) {
            htmlContentControl.HtmlTemplate.Set(Loader.Load("ProgressBar.html"), Loader.Load("ProgressBar.css"));
        }
    }
}
