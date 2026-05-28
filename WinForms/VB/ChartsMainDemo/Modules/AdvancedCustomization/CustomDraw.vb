Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class CustomDrawDemo
        Inherits ChartDemoModule

        Private ReadOnly photos As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()

        Private ReadOnly seriesIndexes As Dictionary(Of Series, Integer) = New Dictionary(Of Series, Integer)()

        Private ReadOnly legendBackgroundBrushes As Dictionary(Of Color, SolidBrush) = New Dictionary(Of Color, SolidBrush)()

        Private bestEmployees As Dictionary(Of Integer, String)

        Private selectedSeries As Series

        Private chartSkinBackColor As Color

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            BindChartToData()
            InitializePhotos()
            UpdateLegendBackColor()
            ChartControl.EndInit()
        End Sub

        Private Sub BindChartToData()
            chart.DataSource = dS51.Employees
            Dim path As String = GetRelativePath("nwind.mdb")
            If path.Length > 0 Then
                SetConnectionString(oleDbConnection, path)
            Else
                XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                oleDbAdapter.Fill(dS51)
                bestEmployees = SelectBestEmployees()
            Catch e As OleDbException
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Sub

        Private Sub InitializePhotos()
            Dim imageBytes As Byte()
            For Each row As DataRow In dS51.Employees.Rows
                imageBytes = CType(row.ItemArray(4), Byte())
                Dim lastName As String = String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf & "{1}", row.ItemArray(CInt(2)).ToString(), row.ItemArray(CInt(3)).ToString())
                Using stream As MemoryStream = New MemoryStream(imageBytes)
                    If Not photos.ContainsKey(lastName) Then photos.Add(lastName, ResizeImage(Image.FromStream(stream), 48, 48))
                End Using
            Next
        End Sub

        Private Sub UpdateLegendBackColor()
            chartSkinBackColor = GetChartBackground(LookAndFeel)
            ChartControl.Legend.BackColor = chartSkinBackColor
        End Sub

        Private Sub RenderEllipses(ByVal g As Graphics, ByVal brush As Brush, ByVal location As Integer, ByVal side As Integer)
            g.FillEllipse(Brushes.White, New Rectangle(New Point(location - 1, location - 1), New Size(side + 2, side + 2)))
            g.FillEllipse(brush, New Rectangle(New Point(location, location), New Size(side, side)))
        End Sub

        Private Function CalculateAxisLabelText(ByVal axisValue As Double) As String
            Const dollar As String = "$"
            Dim millions As Double = axisValue / 1000
            If millions = 0 Then
                Return String.Format("{0}{1}", dollar, millions)
            ElseIf millions < 1 Then
                Return String.Format("{0}{1}{2}", dollar, axisValue, "K")
            End If

            Return String.Format("{0}{1}{2}", dollar, millions, "M")
        End Function

        Private Function CalculateFontSize(ByVal ratio As Double, ByVal minFontSize As Integer, ByVal maxFontSize As Integer) As Single
            Return CSng(minFontSize + (maxFontSize - minFontSize) * ratio)
        End Function

        Private Function SelectBestEmployees() As Dictionary(Of Integer, String)
            Return dS51.Employees.GroupBy(Function(g) New With {g.LastName, g.OrderDate.Year}).Select(Function(o) New With {o.Key.Year, .FullName = String.Format("{0} {1}", o.Key.LastName, Enumerable.FirstOrDefault(Of DS5.EmployeesRow)(o).FirstName), .SumFreight = o.Sum(Function(v) v.Freight)}).GroupBy(Function(y) y.Year).SelectMany(Function(r) r.Where(Function(b) b.SumFreight = r.Max(Function(c) c.SumFreight))).ToDictionary(Function(k) k.Year, Function(v) v.FullName)
        End Function

        Private Function DrawMarkerOnPhoto(ByVal srcImage As Image, ByVal isSelected As Boolean, ByVal color As Color, ByVal hatchColor As Color, ByVal location As Integer, ByVal side As Integer) As Image
            Dim dstImage As Image = New Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat)
            Dim g As Graphics = Graphics.FromImage(dstImage)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim graphicsPath As GraphicsPath = New GraphicsPath()
            graphicsPath.AddRectangle(New Rectangle(-1, -1, dstImage.Width + 2, dstImage.Height + 2))
            graphicsPath.AddEllipse(0, 0, dstImage.Width, dstImage.Height)
            g.DrawImage(srcImage, 0, 0)
            g.FillPath(GetLegendMarkerBackground(chartSkinBackColor), graphicsPath)
            If isSelected Then
                RenderEllipses(g, New HatchBrush(HatchStyle.DarkUpwardDiagonal, color, hatchColor), location - 2, side + 3)
            Else
                RenderEllipses(g, New LinearGradientBrush(New Rectangle(New Point(), srcImage.Size), color, hatchColor, LinearGradientMode.BackwardDiagonal), location, side)
            End If

            Return dstImage
        End Function

        Private Function GetLegendMarkerBackground(ByVal chartSkinBackColor As Color) As Brush
            Dim brush As SolidBrush = Nothing
            If Not legendBackgroundBrushes.TryGetValue(chartSkinBackColor, brush) Then
                brush = New SolidBrush(chartSkinBackColor)
                legendBackgroundBrushes(chartSkinBackColor) = brush
            End If

            Return brush
        End Function

        Private Sub chart_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            Dim isSelected As Boolean = selectedSeries IsNot Nothing AndAlso Equals(e.Series.Name, selectedSeries.Name)
            Dim photo As Bitmap = New Bitmap(48, 48)
            Using g As Graphics = Graphics.FromImage(photo)
                For Each fullName As String In photos.Keys
                    If fullName.Contains(e.Series.Name) Then
                        g.DrawImage(photos(fullName), New Rectangle(New Point(0, 0), New Size(48, 48)))
                        e.LegendText = fullName
                        Exit For
                    End If
                Next
            End Using

            e.LegendMarkerImage = DrawMarkerOnPhoto(photo, isSelected, e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, 33, 13)
            e.DisposeLegendMarkerImage = True
            If isSelected AndAlso TypeOf e.SeriesDrawOptions Is BarDrawOptions Then
                CType(e.SeriesDrawOptions, BarDrawOptions).FillStyle.FillMode = FillMode.Hatch
                CType(CType(e.SeriesDrawOptions, BarDrawOptions).FillStyle.Options, HatchFillOptions).HatchStyle = HatchStyle.DarkUpwardDiagonal
            End If
        End Sub

        Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim list As List(Of Object) = TryCast(e.SeriesPoint.Tag, List(Of Object))
            If list Is Nothing OrElse list.Count = 0 Then Return
            Dim row As DataRow = CType(list(0), DataRowView).Row
            Dim year As Integer =(CDate(row("OrderDate"))).Year
            If bestEmployees(year).Contains(row("LastName").ToString()) Then
                e.LabelText = String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf & " Best employee in the {1}", bestEmployees(year), year)
                Dim entries As PaletteEntry() = chart.GetPaletteEntries(chart.Series.Count)
                Dim border As RectangularBorder = CType(e.SeriesDrawOptions, BarDrawOptions).Border
                border.Color = MixColors(Color.FromArgb(100, 0, 0, 0), entries(seriesIndexes(e.Series)).Color)
                border.Thickness = 4
            Else
                e.LabelText = String.Empty
            End If
        End Sub

        Private Sub chart_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
            If TypeOf e.Item.Axis Is AxisX Then Return
            Dim axisValue As Double = Double.Parse(e.Item.Text)
            Dim max As Double = e.Item.Axis.WholeRange.MaxValueInternal
            Dim ratio As Double = axisValue / max
            e.Item.Text = CalculateAxisLabelText(axisValue)
            e.Item.TextColor = InterpolateColors(Color.FromArgb(255, 170, 42, 0), Color.Green, ratio)
            If ratio > 0 Then e.Item.DXFont = New DXFont("Tahoma", CalculateFontSize(ratio, 8, 15))
        End Sub

        Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            selectedSeries = If(e.HitInfo.InSeries, CType(e.HitInfo.Series, Series), Nothing)
            chart.Invalidate()
        End Sub

        Private Sub chart_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            selectedSeries = Nothing
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To chart.Series.Count - 1
                seriesIndexes(chart.Series(i)) = i
            Next
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateLegendBackColor()
        End Sub
    End Class
End Namespace
