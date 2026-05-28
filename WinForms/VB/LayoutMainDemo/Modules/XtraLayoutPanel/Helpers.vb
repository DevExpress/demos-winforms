Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Extensions

Namespace DevExpress.XtraLayout.Demos

    Friend Module ToolboxControlHelper

        Const DefaultMargin As Integer = 4

        Private ReadOnly DefaultFont As Font = AppearanceObject.DefaultFont

        Public Function CreateToolboxItemImage(ByVal text As String, ByVal glyph As Image, ByVal foreColor As Color) As Image
            Dim imageSz As Size = CalculateImageSize(text, glyph)
            Return New Bitmap(imageSz.Width, imageSz.Height).Draw(Sub(x)
                x.DrawImage(glyph, New Point(0, 0))
                x.Graphics.DrawString(text, DefaultFont, x.GetSolidBrush(foreColor), glyph.Width + DefaultMargin, 0)
            End Sub)
        End Function

        Private Function CalculateImageSize(ByVal text As String, ByVal glyph As Image) As Size
            Dim graphics As Graphics = GraphicsInfo.Default.AddGraphics(Nothing)
            Try
                Dim textSz As Size = graphics.MeasureString(text, DefaultFont).ToSize()
                Return New Size(glyph.Width + textSz.Width + 2 * DefaultMargin, glyph.Height * 2)
            Finally
                Call GraphicsInfo.Default.ReleaseGraphics()
            End Try
        End Function
    End Module

    Friend NotInheritable Class SimpleSizeConverter
        Inherits SizeConverter

        Public Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
            Return False
        End Function
    End Class

    Friend NotInheritable Class SimplePaddingConverter
        Inherits PaddingConverter

        Public Overrides Function GetPropertiesSupported(ByVal context As ITypeDescriptorContext) As Boolean
            Return False
        End Function
    End Class
End Namespace
