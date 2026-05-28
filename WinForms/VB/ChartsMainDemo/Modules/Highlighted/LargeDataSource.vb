Imports System
Imports System.Collections.Generic
Imports System.Runtime
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class LargeDataSourceDemo
        Inherits ChartDemoModuleWithOptions

        Const InitialPointsCount As Integer = 2500000

        Private totalPointsCount As Integer = 0

        Private seriesIndex As Integer = 1

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim diagram As XYDiagram2D = TryCast(ChartControl.Diagram, XYDiagram2D)
            diagram.ZoomingOptions.AxisXMaxZoomPercent = 100000000
            diagram.ZoomingOptions.AxisYMaxZoomPercent = 100000000
            totalPointsCount = 0
            AddSeries(InitialPointsCount, False)
        End Sub

        Private Function ShowProgressPanel() As IOverlaySplashScreenHandle
            Return SplashScreenManager.ShowOverlayForm(Me, OverlayWindowOptions.Default)
        End Function

        Private Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
            SplashScreenManager.CloseOverlayForm(handle)
        End Sub

        Private Sub AddSeries(ByVal pointsCount As Integer, ByVal showProgressPanel As Boolean)
            Dim progressPanelHandle As IOverlaySplashScreenHandle = Nothing
            If showProgressPanel Then progressPanelHandle = Me.ShowProgressPanel()
            Try
                Dim series As Series = New Series()
                series.Name = "Series " & Math.Min(Threading.Interlocked.Increment(seriesIndex), seriesIndex - 1)
                Dim adapter As ResamplingDataAdapter = New ResamplingDataAdapter() With {.DataSorted = True}
                adapter.DataSource = GenerateSeriesDataSourceSine(pointsCount)
                adapter.SetDataMembers("Argument", "Value")
                series.DataAdapter = adapter
                series.CrosshairLabelPattern = "{S}:" & Microsoft.VisualBasic.Constants.vbTab & "{V:0.0}"
                series.View = New SwiftPlotSeriesView()
                ChartControl.Series.Add(series)
                totalPointsCount += pointsCount
                ChartControl.Titles(1).Text = String.Format("Total Points Count: {0:#,0.}", totalPointsCount)
            Catch __unusedOutOfMemoryException1__ As OutOfMemoryException
                Dim seriesList As List(Of Series) = New List(Of Series)(chart.Series.ToArray())
                chart.Series.Clear()
                For Each series As Series In seriesList
                    CType(series.DataAdapter, DataSourceAdapter).DataSource = Nothing
                Next

                totalPointsCount = 0
                GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce
                GC.Collect(2, GCCollectionMode.Forced)
                GC.WaitForFullGCComplete()
                AddSeries(pointsCount, showProgressPanel)
            Finally
                If progressPanelHandle IsNot Nothing Then CloseProgressPanel(progressPanelHandle)
            End Try
        End Sub

        Private Sub btnAdd250K_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddSeries(250000, True)
        End Sub

        Private Sub btnAdd500K_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddSeries(500000, True)
        End Sub

        Private Sub btnAdd1M_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddSeries(1000000, True)
        End Sub
    End Class
End Namespace
