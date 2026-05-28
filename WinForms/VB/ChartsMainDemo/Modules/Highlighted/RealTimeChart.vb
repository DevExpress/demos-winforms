Imports System
Imports System.Linq

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class RealTimeChartDemo
        Inherits ChartDemoModule

        Private ReadOnly fpsBuffer As Double() = New Double(9) {}

        Private lastIndex As Integer = 0

        Private lastTime As Date = Date.Now

        Private lastFPSUpdateTime As Double = 0

        Private ReadOnly dataGenerator As SensorDataGenerator

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Friend Overrides ReadOnly Property ExportedObject As Object
            Get
                Return Nothing
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            dataGenerator = New SensorDataGenerator()
            dataGenerator.GenerateInitialData()
            ChartControl.DataSource = dataGenerator.DataSource
            ColorizeSeries()
            dataGenerator.Start()
            synchronousTimer.Enabled = True
            ChartControl.EndInit()
            Dim axisX As SwiftPlotDiagramAxisX = CType(ChartControl.Diagram, SwiftPlotDiagram).AxisX
            axisX.VisualRange.SetMinMaxValues(CDate(axisX.WholeRange.MaxValue) - New TimeSpan(0, 0, 10), (CDate(axisX.WholeRange.MaxValue)).AddSeconds(1))
        End Sub

        Private Sub ColorizeSeries()
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(2)
            ChartControl.Series(0).View.Color = paletteEntries(0).Color
            ChartControl.Series(1).View.Color = paletteEntries(1).Color
            ChartControl.Series(2).View.Color = paletteEntries(0).Color
            ChartControl.Series(3).View.Color = paletteEntries(1).Color
            ChartControl.Series(4).View.Color = paletteEntries(0).Color
            ChartControl.Series(5).View.Color = paletteEntries(1).Color
            ChartControl.Series(6).View.Color = paletteEntries(0).Color
            ChartControl.Series(7).View.Color = paletteEntries(1).Color
            ChartControl.Legend.CustomItems(0).MarkerColor = paletteEntries(0).Color
            ChartControl.Legend.CustomItems(1).MarkerColor = paletteEntries(1).Color
        End Sub

        Private Sub synchronousTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If dataGenerator IsNot Nothing Then dataGenerator.UpdateDataSource()
        End Sub

        Private Sub Chart_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs)
            Dim currentTime As Date = Date.Now
            Dim diff As Double = Math.Max(1, (currentTime - lastTime).TotalMilliseconds)
            lastTime = currentTime
            If diff <> 1 Then fpsBuffer(Math.Min(Threading.Interlocked.Increment(lastIndex), lastIndex - 1)) = 1000 / diff
            If lastFPSUpdateTime = 0 OrElse lastFPSUpdateTime > 100 Then
                chart.Titles(1).Text = String.Format("FPS: {0:0.00}", fpsBuffer.Average())
                lastFPSUpdateTime = 0
            End If

            lastFPSUpdateTime += diff
            If lastIndex >= fpsBuffer.Length Then lastIndex = 0
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            ColorizeSeries()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing AndAlso dataGenerator IsNot Nothing Then
                dataGenerator.Stop()
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
