using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DevExpress.XtraPivotGrid.Demos {
    public class PivotDemoHelper {
        public static ImageCollection GetTransmissionGlyphs() {
            ImageCollection result = new ImageCollection();
            result.ImageSize = ScaleUtils.ScaleValue(new Size(15, 15));
            StubGlyphOptions options = new StubGlyphOptions();
            options.ColorMode = GlyphColorMode.Red;
            result.AddImage(CreateStubGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A");
            options.ColorMode = GlyphColorMode.Green;
            result.AddImage(CreateStubGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M");
            options.ColorMode = GlyphColorMode.Blue;
            result.AddImage(CreateStubGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V");
            options.ColorMode = GlyphColorMode.Yellow;
            result.AddImage(CreateStubGlyph("Ltd", result.ImageSize, options, UserLookAndFeel.Default), "Ltd");
            return result;
        }
        static Image CreateStubGlyph(string text, Size glyphSize, StubGlyphOptions options, ISkinProvider skinProvider) {
            var img = new Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(img)) {
                using (GraphicsCache cache = new GraphicsCache(g))
                    GlyphPainter.Default.DrawGlyph(cache, options, text, new Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal);
            }
            return img;
        }
    }
}
