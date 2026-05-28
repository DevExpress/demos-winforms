// Assembly {TutorialsAssembly}
namespace DevExpress.DXperience.Demos.CodeDemo.Data {
    using DevExpress.LookAndFeel;
    using DevExpress.Skins;
    using DevExpress.Utils;
    using DevExpress.Utils.Drawing;
    using System.Drawing;

    public static class ImageHelper {
        static Image CreateGlyph(string text, Size glyphSize, StubGlyphOptions options, ISkinProvider skinProvider) {
            var img = new Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using(Graphics g = Graphics.FromImage(img)) {
                using(GraphicsCache cache = new GraphicsCache(g))
                    GlyphPainter.Default.DrawGlyph(cache, options, text, new Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal);
            }
            return img;
        }
        public static ImageCollection GetGlyphs() {
            ImageCollection result = new ImageCollection();
            result.ImageSize = ScaleUtils.ScaleValue(new Size(15, 15));
            StubGlyphOptions options = new StubGlyphOptions();
            options.ColorMode = GlyphColorMode.All;
            result.AddImage(CreateGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A");
            result.AddImage(CreateGlyph("B", result.ImageSize, options, UserLookAndFeel.Default), "B");
            result.AddImage(CreateGlyph("C", result.ImageSize, options, UserLookAndFeel.Default), "C");
            result.AddImage(CreateGlyph("D", result.ImageSize, options, UserLookAndFeel.Default), "D");
            result.AddImage(CreateGlyph("E", result.ImageSize, options, UserLookAndFeel.Default), "E");
            result.AddImage(CreateGlyph("F", result.ImageSize, options, UserLookAndFeel.Default), "F");
            result.AddImage(CreateGlyph("G", result.ImageSize, options, UserLookAndFeel.Default), "G");
            result.AddImage(CreateGlyph("H", result.ImageSize, options, UserLookAndFeel.Default), "H");
            result.AddImage(CreateGlyph("I", result.ImageSize, options, UserLookAndFeel.Default), "I");
            result.AddImage(CreateGlyph("J", result.ImageSize, options, UserLookAndFeel.Default), "J");
            result.AddImage(CreateGlyph("K", result.ImageSize, options, UserLookAndFeel.Default), "K");
            result.AddImage(CreateGlyph("L", result.ImageSize, options, UserLookAndFeel.Default), "L");
            result.AddImage(CreateGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M");
            result.AddImage(CreateGlyph("N", result.ImageSize, options, UserLookAndFeel.Default), "N");
            result.AddImage(CreateGlyph("O", result.ImageSize, options, UserLookAndFeel.Default), "O");
            result.AddImage(CreateGlyph("P", result.ImageSize, options, UserLookAndFeel.Default), "P");
            result.AddImage(CreateGlyph("Q", result.ImageSize, options, UserLookAndFeel.Default), "Q");
            result.AddImage(CreateGlyph("R", result.ImageSize, options, UserLookAndFeel.Default), "R");
            result.AddImage(CreateGlyph("S", result.ImageSize, options, UserLookAndFeel.Default), "S");
            result.AddImage(CreateGlyph("T", result.ImageSize, options, UserLookAndFeel.Default), "T");
            result.AddImage(CreateGlyph("U", result.ImageSize, options, UserLookAndFeel.Default), "U");
            result.AddImage(CreateGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V");
            result.AddImage(CreateGlyph("W", result.ImageSize, options, UserLookAndFeel.Default), "W");
            result.AddImage(CreateGlyph("X", result.ImageSize, options, UserLookAndFeel.Default), "X");
            result.AddImage(CreateGlyph("Y", result.ImageSize, options, UserLookAndFeel.Default), "Y");
            result.AddImage(CreateGlyph("Z", result.ImageSize, options, UserLookAndFeel.Default), "Z");
            return result;
        }
    }
}
