Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Text
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucCardWidget
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Price As Decimal

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property PPrice As Double

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Delta As Double

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            labelControl1.StateIndex = If(Delta > 0, 0, 1)
            If labelControl1.StateIndex = 0 Then
                labelControl1.Text = Price.ToString("C1") & "<br><color=63,136,48>" & PPrice.ToString("P") & "<br><b><color=63,136,48><size=+2>" & Delta.ToString("F2")
            Else
                labelControl1.Text = Price.ToString("C1") & "<br><color=214,5,5>" & PPrice.ToString("P") & "<br><b><color=214,5,5><size=+2>" & Delta.ToString("F2")
            End If
        End Sub
    End Class

    Public Class OverviewLabel
        Inherits LabelControl

        Private Shared positiveColor As Color = Color.FromArgb(63, 136, 48)

        Private Shared negativeColor As Color = Color.FromArgb(214, 5, 5)

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property StateIndex As Integer

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then DestroyFitAppearance()
            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            MyBase.OnTextChanged(e)
            DestroyFitAppearance()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            DestroyFitAppearance()
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            If IsDesignMode OrElse GetFitHeight() <= 1 Then Return
            Using cache As GraphicsCache = New GraphicsCache(e.Graphics)
                cache.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                DrawText(cache, GetFitAppearance(cache))
                DrawStateIndicator(cache, GetFitHeight() * 2)
            End Using
        End Sub

        Private Sub DrawText(ByVal cache As GraphicsCache, ByVal appearance As LabelControlAppearanceObject)
            Dim rect = ClientRectangle
            rect.Height -= Padding.Bottom
            StringPainter.Default.DrawString(cache, appearance, Text, rect, appearance.TextOptions, Me)
        End Sub

        Private Sub DrawStateIndicator(ByVal cache As GraphicsCache, ByVal height As Integer)
            Dim p1 As Point = Point.Empty
            Dim p2 As Point = Point.Empty
            Dim p3 As Point = Point.Empty
            Dim _width As Integer = CInt(2 * height / Math.Sqrt(3))
            p1.X = ClientRectangle.Left + Padding.Left + _width \ 2
            p2.X = ClientRectangle.Left + Padding.Left
            p3.X = ClientRectangle.Left + Padding.Left + _width
            Dim y As Integer = ClientRectangle.Bottom - Padding.Bottom - 5
            Dim stateColor As Color = Color.Empty
            If StateIndex = 0 Then
                p1.Y = y - height
                p3.Y = y
                p2.Y = p3.Y
                stateColor = positiveColor
            Else
                p1.Y = y
                p3.Y = y - height
                p2.Y = p3.Y
                stateColor = negativeColor
            End If

            cache.FillPolygon(New Point() {p1, p2, p3}, stateColor)
        End Sub

        Private Function GetFitHeight() As Integer
            Return CInt((ClientRectangle.Height - Padding.Bottom) / 4F + 0.5F)
        End Function

        Private labelControlAppearanceObject As LabelControlAppearanceObject

        Private Function GetFitAppearance(ByVal cache As GraphicsCache) As LabelControlAppearanceObject
            If labelControlAppearanceObject IsNot Nothing Then Return labelControlAppearanceObject
            Dim obj As LabelControlAppearanceObject = New LabelControlAppearanceObject()
            obj.Assign(ViewInfo.PaintAppearance)
            obj.Font = New Font(obj.Font.FontFamily, GetFitHeight(), GraphicsUnit.Pixel)
            labelControlAppearanceObject = obj
            Return obj
        End Function

        Private Sub DestroyFitAppearance()
            If labelControlAppearanceObject IsNot Nothing Then
                Dim _font = labelControlAppearanceObject.Font
                labelControlAppearanceObject.Font = Nothing
                If _font IsNot Nothing AndAlso _font IsNot Utils.AppearanceObject.DefaultFont Then _font.Dispose()
                labelControlAppearanceObject.Dispose()
            End If

            labelControlAppearanceObject = Nothing
        End Sub
    End Class
End Namespace
