Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Sql.DataApi
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CustomDraw

    Public Class CustomControl
        Inherits DevExpress.XtraReports.UI.XRControl

        Private ReadOnly controlData As System.Collections.Generic.List(Of System.Tuple(Of String, Double)) = New System.Collections.Generic.List(Of System.Tuple(Of String, Double))()

        Private Sub UpdateData()
            Me.controlData.Clear()
            If Me.DesignMode Then
                Me.controlData.Add(System.Tuple.Create("", 1.0))
                Return
            End If

            If Me.RootReport Is Nothing Then Return
            Dim dataSource As DevExpress.DataAccess.Sql.SqlDataSource = TryCast(Me.RootReport.DataSource, DevExpress.DataAccess.Sql.SqlDataSource)
            If dataSource Is Nothing Then Return
            Dim regions As DevExpress.DataAccess.Sql.DataApi.ITable = dataSource.Result("AboutRegions")
            If regions Is Nothing Then Return
            Dim count As Integer = System.Math.Min(regions.Count(), 10)
            For i As Integer = 0 To count - 1
                Dim region As DevExpress.DataAccess.Sql.DataApi.IRow = regions(i)
                Dim population As Double = CDbl(region("PopulationPortion"))
                Dim country As String = String.Format("{0}, {1:p}", region("Country"), population)
                Me.controlData.Add(System.Tuple.Create(country, population))
            Next
        End Sub

        Protected Overrides Function CreateBrick(ByVal childrenBricks As DevExpress.XtraPrinting.VisualBrick()) As VisualBrick
            Return New DevExpress.XtraPrinting.PanelBrick(Me)
        End Function

        Private isCompatible As Boolean? = Nothing

        Protected Overrides Sub PutStateToBrick(ByVal brick As DevExpress.XtraPrinting.VisualBrick, ByVal ps As DevExpress.XtraPrinting.PrintingSystemBase)
            MyBase.PutStateToBrick(brick, ps)
            Me.UpdateData()
            If Not Me.isCompatible.HasValue Then Me.isCompatible = XtraReportsDemos.CustomDraw.CustomControl.CheckCompatibility()
            If Me.controlData.Count = 0 OrElse Not Me.isCompatible.Value Then Return
            Dim itemHeight As Single = Me.GetItemHeight(brick.Rect)
            Dim r As System.Drawing.RectangleF = XtraReportsDemos.CustomDraw.CustomControl.GetGraphicsRect(brick.Rect, itemHeight)
            Dim scale As Double = Me.GetScale()
            For i As Integer = 0 To Me.controlData.Count - 1
                Call XtraReportsDemos.CustomDraw.CustomControl.DrawPopulationInfo(CType(brick, DevExpress.XtraPrinting.PanelBrick), r, Me.controlData(CInt((i))).Item1, Me.controlData(CInt((i))).Item2, scale)
                r.Offset(0, itemHeight)
            Next
        End Sub

        Private Shared Function CheckCompatibility() As Boolean
            Try
                Dim ignore As Object = GetType(System.Drawing.RectangleF)
            Catch
                Return False
            End Try

            Return True
        End Function

        Private Function GetItemHeight(ByVal bounds As System.Drawing.RectangleF) As Single
            Return bounds.Height / System.Math.Max(Me.controlData.Count, 10)
        End Function

        Private Function GetScale() As Double
            Dim value As Double = If(Me.controlData.Count > 0, Me.controlData(CInt((0))).Item2, 1)
            Return 1 / value
        End Function

        Private Shared Function GetGraphicsRect(ByVal bounds As System.Drawing.RectangleF, ByVal itemHeight As Single) As RectangleF
            Const indent As Integer = 10
            Dim r As System.Drawing.RectangleF = New System.Drawing.RectangleF(0, 0, bounds.Width, itemHeight)
            r.Inflate(-2 * indent, -2 * indent)
            Return r
        End Function

        Private Shared Sub DrawPopulationInfo(ByVal panel As DevExpress.XtraPrinting.PanelBrick, ByVal r As System.Drawing.RectangleF, ByVal text As String, ByVal portion As Double, ByVal scale As Double)
            Dim barRect As System.Drawing.RectangleF = XtraReportsDemos.CustomDraw.CustomControl.GetBarRect(r, portion, scale)
            r.Height = barRect.Top - r.Top
            Dim textStyle As DevExpress.XtraPrinting.BrickStyle = New DevExpress.XtraPrinting.BrickStyle() With {.ForeColor = panel.Style.ForeColor, .BackColor = System.Drawing.Color.Transparent, .Font = panel.Style.Font}
            textStyle.ChangeAlignment(DevExpress.XtraPrinting.TextAlignment.BottomLeft)
            Dim textBrick As DevExpress.XtraPrinting.TextBrick = New DevExpress.XtraPrinting.TextBrick(textStyle)
            textBrick.Rect = r
            textBrick.Text = text
            panel.Bricks.Add(textBrick)
            Dim barStyle As DevExpress.XtraPrinting.BrickStyle = New DevExpress.XtraPrinting.BrickStyle() With {.Sides = DevExpress.XtraPrinting.BorderSide.All, .BorderColor = System.Drawing.Color.FromArgb(173, 148, 116), .BorderStyle = DevExpress.XtraPrinting.BrickBorderStyle.Inset, .BorderWidth = 1, .BackColor = System.Drawing.Color.FromArgb(232, 216, 195)}
            Dim barBrick As DevExpress.XtraPrinting.VisualBrick = New DevExpress.XtraPrinting.VisualBrick(barStyle)
            barBrick.Rect = barRect
            panel.Bricks.Add(barBrick)
        End Sub

        Private Shared Function GetBarRect(ByVal r As System.Drawing.RectangleF, ByVal portion As Double, ByVal scale As Double) As RectangleF
            Dim barWidth As Single = CSng((r.Width * portion * scale))
            Dim barHeight As Single = CSng((CDbl(r.Height) / 3.0))
            Return New System.Drawing.RectangleF(r.Left, r.Bottom - barHeight, barWidth, barHeight)
        End Function
    End Class
End Namespace
