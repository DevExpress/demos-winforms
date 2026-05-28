using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraDiagram.Demos;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
namespace DevExpress.Diagram.Demos {
    public static class DiagramDemoFileHelper {
        public static Stream GetDataStream(string fileName) {
            return File.OpenRead(DiagramTutorialControl.GetDataFileName(fileName));
        }
        public static Image GetImageResource(string path) {
            var assembly = typeof(DiagramDemoFileHelper).Assembly;
            var stream = AssemblyHelper.GetResourceStream(assembly, path, true);
            return new Bitmap(stream);
        }
        public static SvgImage GetSvgImageResource(string path) {
            var assembly = typeof(DiagramDemoFileHelper).Assembly;
            var stream = AssemblyHelper.GetResourceStream(assembly, path, true);
            return SvgImage.FromStream(stream);
        }
    }
}
