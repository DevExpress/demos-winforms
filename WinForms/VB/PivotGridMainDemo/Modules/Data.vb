Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos

    Public Class PivotDemoHelper

        Public Shared Function GetTransmissionGlyphs() As ImageCollection
            Dim result As ImageCollection = New ImageCollection()
            result.ImageSize = ScaleUtils.ScaleValue(New Size(15, 15))
            Dim options As StubGlyphOptions = New StubGlyphOptions()
            options.ColorMode = GlyphColorMode.Red
            result.AddImage(CreateStubGlyph("A", result.ImageSize, options, UserLookAndFeel.Default), "A")
            options.ColorMode = GlyphColorMode.Green
            result.AddImage(CreateStubGlyph("M", result.ImageSize, options, UserLookAndFeel.Default), "M")
            options.ColorMode = GlyphColorMode.Blue
            result.AddImage(CreateStubGlyph("V", result.ImageSize, options, UserLookAndFeel.Default), "V")
            options.ColorMode = GlyphColorMode.Yellow
            result.AddImage(CreateStubGlyph("Ltd", result.ImageSize, options, UserLookAndFeel.Default), "Ltd")
            Return result
        End Function

        Private Shared Function CreateStubGlyph(ByVal text As String, ByVal glyphSize As Size, ByVal options As StubGlyphOptions, ByVal skinProvider As ISkinProvider) As Image
            Dim img = New Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(img)
                Using cache As GraphicsCache = New GraphicsCache(g)
                    Call GlyphPainter.Default.DrawGlyph(cache, options, text, New Rectangle(Point.Empty, glyphSize), skinProvider, ObjectState.Normal)
                End Using
            End Using

            Return img
        End Function
    End Class
End Namespace
