' Assembly {TutorialsAssembly}
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports System.Drawing

Namespace DevExpress.DXperience.Demos.CodeDemo.Data

    Public Module ImageHelper

        Private Function CreateGlyph(ByVal text As String, ByVal glyphSize As System.Drawing.Size, ByVal options As DevExpress.Utils.Drawing.StubGlyphOptions, ByVal skinProvider As DevExpress.Skins.ISkinProvider) As Image
            Dim img = New System.Drawing.Bitmap(glyphSize.Width, glyphSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(img)
                Using cache As DevExpress.Utils.Drawing.GraphicsCache = New DevExpress.Utils.Drawing.GraphicsCache(g)
                    Call DevExpress.Utils.Drawing.GlyphPainter.[Default].DrawGlyph(cache, options, text, New System.Drawing.Rectangle(System.Drawing.Point.Empty, glyphSize), skinProvider, DevExpress.Utils.Drawing.ObjectState.Normal)
                End Using
            End Using

            Return img
        End Function

        Public Function GetGlyphs() As ImageCollection
            Dim result As DevExpress.Utils.ImageCollection = New DevExpress.Utils.ImageCollection()
            result.ImageSize = DevExpress.Utils.ScaleUtils.ScaleValue(New System.Drawing.Size(15, 15))
            Dim options As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
            options.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.All
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("A", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "A")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("B", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "B")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("C", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "C")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("D", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "D")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("E", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "E")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("F", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "F")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("G", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "G")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("H", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "H")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("I", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "I")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("J", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "J")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("K", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "K")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("L", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "L")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("M", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "M")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("N", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "N")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("O", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "O")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("P", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "P")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("Q", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "Q")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("R", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "R")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("S", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "S")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("T", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "T")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("U", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "U")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("V", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "V")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("W", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "W")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("X", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "X")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("Y", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "Y")
            result.AddImage(DevExpress.DXperience.Demos.CodeDemo.Data.ImageHelper.CreateGlyph("Z", result.ImageSize, options, DevExpress.LookAndFeel.UserLookAndFeel.[Default]), "Z")
            Return result
        End Function
    End Module
End Namespace
