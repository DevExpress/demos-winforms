Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class MaximizedWidgetControl
        Inherits XtraEditors.XtraUserControl

        Private updateTimer As Timer = New Timer()

        Private index As Integer = 0

        Public Sub New()
            InitializeComponent()
            If components IsNot Nothing Then components.Add(updateTimer)
            updateTimer.Interval = 1000
            AddHandler updateTimer.Tick, AddressOf OnTimerTick
            updateTimer.Start()
            For i As Integer = 0 To 30 - 1
                AddNewSeriesPoint()
            Next
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            AddNewSeriesPoint()
        End Sub

        Const BeginDate As Integer = 40000

        Protected Sub AddNewSeriesPoint()
            If IsDisposed Then
                updateTimer.Stop()
                Return
            End If

            chartControl1.BeginInit()
            chartControl2.BeginInit()
            Dim data As StockData = GetData(index)
            Dim points1 = chartControl1.Series(0).Points
            Dim seriesPoint1 As SeriesPoint = New SeriesPoint(data.Date, CObj(data.LowPrice), CObj(data.HighPrice), CObj(data.OpenPrice), CObj(data.ClosePrice))
            points1.Add(seriesPoint1)
            Dim [date] As Integer = BeginDate
            If index > 40 Then [date] = BeginDate + index - 30
            TryCast(chartControl1.Diagram, IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(Date.FromOADate([date]), data.Date)
            TryCast(chartControl2.Diagram, IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(Date.FromOADate([date]), data.Date)
            index += 1
            Dim points2 = chartControl2.Series(0).Points
            Dim seriesPoint2 As SeriesPoint = New SeriesPoint(data.Date, data.Volumne)
            points2.Add(seriesPoint2)
            Cleanup(points1, points2)
            chartControl1.EndInit()
            chartControl2.EndInit()
        End Sub

        Private Sub Cleanup(ByVal points1 As SeriesPointCollection, ByVal points2 As SeriesPointCollection)
            If index > 40 Then
                points1.RemoveAt(0)
                points2.RemoveAt(0)
            End If
        End Sub
    End Class
End Namespace
