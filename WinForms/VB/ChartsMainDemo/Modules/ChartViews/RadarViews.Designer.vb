Namespace DevExpress.XtraCharts.Demos

    Partial Class RadarViewsDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.RadarViewsDemo))
            Dim radarDiagram1 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim radarPointSeriesView1 As DevExpress.XtraCharts.RadarPointSeriesView = New DevExpress.XtraCharts.RadarPointSeriesView()
            Dim circularMarkerWidenAnimation1 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((6R)))})
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((14R)))})
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((18R)))})
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((21R)))})
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((19R)))})
            Dim seriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((15R)))})
            Dim seriesPoint23 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint24 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim radarPointSeriesView2 As DevExpress.XtraCharts.RadarPointSeriesView = New DevExpress.XtraCharts.RadarPointSeriesView()
            Dim circularMarkerWidenAnimation2 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim radarDiagram2 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint25 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint26 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint27 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim seriesPoint28 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint29 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint30 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint31 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint32 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint33 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint34 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint35 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint36 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim radarLineSeriesView1 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
            Dim circularMarkerSlideAnimation1 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim quinticEasingFunction1 As DevExpress.XtraCharts.QuinticEasingFunction = New DevExpress.XtraCharts.QuinticEasingFunction()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint37 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((6R)))})
            Dim seriesPoint38 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim seriesPoint39 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint40 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((14R)))})
            Dim seriesPoint41 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((18R)))})
            Dim seriesPoint42 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((21R)))})
            Dim seriesPoint43 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint44 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint45 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((19R)))})
            Dim seriesPoint46 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((15R)))})
            Dim seriesPoint47 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint48 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim radarLineSeriesView2 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
            Dim circularMarkerSlideAnimation2 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim quinticEasingFunction2 As DevExpress.XtraCharts.QuinticEasingFunction = New DevExpress.XtraCharts.QuinticEasingFunction()
            Dim sideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim radarDiagram3 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint49 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((6R)))})
            Dim seriesPoint50 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim seriesPoint51 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint52 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((14R)))})
            Dim seriesPoint53 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((18R)))})
            Dim seriesPoint54 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((21R)))})
            Dim seriesPoint55 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint56 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((22R)))})
            Dim seriesPoint57 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((19R)))})
            Dim seriesPoint58 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((15R)))})
            Dim seriesPoint59 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((10R)))})
            Dim seriesPoint60 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((7R)))})
            Dim radarAreaSeriesView1 As DevExpress.XtraCharts.RadarAreaSeriesView = New DevExpress.XtraCharts.RadarAreaSeriesView()
            Dim circularSeriesCircularUnwindAnimation1 As DevExpress.XtraCharts.CircularSeriesCircularUnwindAnimation = New DevExpress.XtraCharts.CircularSeriesCircularUnwindAnimation()
            Dim linearEasingFunction1 As DevExpress.XtraCharts.LinearEasingFunction = New DevExpress.XtraCharts.LinearEasingFunction()
            Dim circularMarkerWidenAnimation3 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint61 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint62 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((2R)))})
            Dim seriesPoint63 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim seriesPoint64 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint65 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint66 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint67 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint68 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((13R)))})
            Dim seriesPoint69 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((11R)))})
            Dim seriesPoint70 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((8R)))})
            Dim seriesPoint71 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((5R)))})
            Dim seriesPoint72 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((3R)))})
            Dim radarAreaSeriesView2 As DevExpress.XtraCharts.RadarAreaSeriesView = New DevExpress.XtraCharts.RadarAreaSeriesView()
            Dim circularSeriesCircularUnwindAnimation2 As DevExpress.XtraCharts.CircularSeriesCircularUnwindAnimation = New DevExpress.XtraCharts.CircularSeriesCircularUnwindAnimation()
            Dim linearEasingFunction2 As DevExpress.XtraCharts.LinearEasingFunction = New DevExpress.XtraCharts.LinearEasingFunction()
            Dim circularMarkerWidenAnimation4 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim sideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim radarDiagram4 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
            Dim series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarPointSeriesLabel1 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
            Dim scatterRadarLineSeriesView1 As DevExpress.XtraCharts.ScatterRadarLineSeriesView = New DevExpress.XtraCharts.ScatterRadarLineSeriesView()
            Dim circularSeriesSpinZoomInAnimation1 As DevExpress.XtraCharts.CircularSeriesSpinZoomInAnimation = New DevExpress.XtraCharts.CircularSeriesSpinZoomInAnimation()
            Dim exponentialEasingFunction1 As DevExpress.XtraCharts.ExponentialEasingFunction = New DevExpress.XtraCharts.ExponentialEasingFunction()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim radarDiagram5 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
            Dim series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarRangeAreaSeriesLabel1 As DevExpress.XtraCharts.RadarRangeAreaSeriesLabel = New DevExpress.XtraCharts.RadarRangeAreaSeriesLabel()
            Dim seriesPoint73 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 1, 1, 0, 0, 0, 0), New Object() {(CObj((6R))), (CObj((2R)))})
            Dim seriesPoint74 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 2, 1, 0, 0, 0, 0), New Object() {(CObj((7R))), (CObj((2R)))})
            Dim seriesPoint75 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 3, 1, 0, 0, 0, 0), New Object() {(CObj((10R))), (CObj((3R)))})
            Dim seriesPoint76 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 4, 1, 0, 0, 0, 0), New Object() {(CObj((14R))), (CObj((5R)))})
            Dim seriesPoint77 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 5, 1, 0, 0, 0, 0), New Object() {(CObj((18R))), (CObj((8R)))})
            Dim seriesPoint78 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 6, 1, 0, 0, 0, 0), New Object() {(CObj((21R))), (CObj((11R)))})
            Dim seriesPoint79 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 7, 1, 0, 0, 0, 0), New Object() {(CObj((22R))), (CObj((13R)))})
            Dim seriesPoint80 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 8, 1, 0, 0, 0, 0), New Object() {(CObj((22R))), (CObj((13R)))})
            Dim seriesPoint81 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 9, 1, 0, 0, 0, 0), New Object() {(CObj((19R))), (CObj((11R)))})
            Dim seriesPoint82 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 10, 1, 0, 0, 0, 0), New Object() {(CObj((15R))), (CObj((8R)))})
            Dim seriesPoint83 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 11, 1, 0, 0, 0, 0), New Object() {(CObj((10R))), (CObj((5R)))})
            Dim seriesPoint84 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2001, 12, 1, 0, 0, 0, 0), New Object() {(CObj((7R))), (CObj((3R)))})
            Dim radarRangeAreaSeriesView1 As DevExpress.XtraCharts.RadarRangeAreaSeriesView = New DevExpress.XtraCharts.RadarRangeAreaSeriesView()
            Dim circularSeriesLinearUnwindAnimation1 As DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation = New DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation()
            Dim circularMarkerSlideAnimation3 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle10 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentPoint = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentLine = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentArea = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentScatterLine = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentRangeArea = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelPoint = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPoint_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPoint = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelLine = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelLine_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartLine = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelArea = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelArea_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartArea = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelScatterLine = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelScatterLine_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartScatterLine = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelRangeArea = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelRangeArea_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartRangeArea = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditMarkerSize = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditMarkerVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxDiagramStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditTextDirection = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditRotationDirection = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditStartAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditAxisLabelAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupMarker = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemMarkerSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMarkerVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMarkerKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupDiagram = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemStartAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRotationDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemStyle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemTextDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemFunction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentScatterLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentRangeArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPoint.SuspendLayout()
            Me.dockPanelPoint_Container.SuspendLayout()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelLine.SuspendLayout()
            Me.dockPanelLine_Container.SuspendLayout()
            CType((Me.chartLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarLineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarLineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelArea.SuspendLayout()
            Me.dockPanelArea_Container.SuspendLayout()
            CType((Me.chartArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarDiagram3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarAreaSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelScatterLine.SuspendLayout()
            Me.dockPanelScatterLine_Container.SuspendLayout()
            CType((Me.chartScatterLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarDiagram4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((scatterRadarLineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelRangeArea.SuspendLayout()
            Me.dockPanelRangeArea_Container.SuspendLayout()
            CType((Me.chartRangeArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarDiagram5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarRangeAreaSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarRangeAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxDiagramStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditTextDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditRotationDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditStartAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditAxisLabelAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStartAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRotationDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTextDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentPoint, Me.documentLine, Me.documentArea, Me.documentScatterLine, Me.documentRangeArea})
            ' 
            ' documentPoint
            ' 
            Me.documentPoint.Caption = "Point"
            Me.documentPoint.ControlName = "dockPanelPoint"
            Me.documentPoint.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentPoint.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentPoint.ImageOptions.SvgImage = CType((resources.GetObject("documentPoint.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentPoint.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentPoint.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentPoint.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentPoint.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentLine
            ' 
            Me.documentLine.Caption = "Line"
            Me.documentLine.ControlName = "dockPanelLine"
            Me.documentLine.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentLine.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentLine.ImageOptions.SvgImage = CType((resources.GetObject("documentLine.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentLine.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentLine.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentLine.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentLine.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentArea
            ' 
            Me.documentArea.Caption = "Area"
            Me.documentArea.ControlName = "dockPanelArea"
            Me.documentArea.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentArea.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentArea.ImageOptions.SvgImage = CType((resources.GetObject("documentArea.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentArea.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentArea.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentArea.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentArea.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentScatterLine
            ' 
            Me.documentScatterLine.Caption = "Scatter Line"
            Me.documentScatterLine.ControlName = "dockPanelScatterLine"
            Me.documentScatterLine.FloatLocation = New System.Drawing.Point(135, 123)
            Me.documentScatterLine.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentScatterLine.ImageOptions.SvgImage = CType((resources.GetObject("documentScatterLine.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentScatterLine.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentScatterLine.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentScatterLine.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentScatterLine.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentRangeArea
            ' 
            Me.documentRangeArea.Caption = "Range Area"
            Me.documentRangeArea.ControlName = "dockPanelRangeArea"
            Me.documentRangeArea.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentRangeArea.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentRangeArea.ImageOptions.SvgImage = CType((resources.GetObject("documentRangeArea.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentRangeArea.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentRangeArea.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentRangeArea.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentRangeArea.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelPoint, Me.dockPanelLine, Me.dockPanelArea, Me.dockPanelScatterLine, Me.dockPanelRangeArea})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelPoint
            ' 
            Me.dockPanelPoint.Controls.Add(Me.dockPanelPoint_Container)
            Me.dockPanelPoint.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelPoint.DockedAsTabbedDocument = True
            Me.dockPanelPoint.ID = New System.Guid("7e5954d1-e03c-4fc3-b52b-c477f73026b3")
            Me.dockPanelPoint.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPoint.Name = "dockPanelPoint"
            Me.dockPanelPoint.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelPoint.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelPoint.Text = "Point"
            ' 
            ' dockPanelPoint_Container
            ' 
            Me.dockPanelPoint_Container.Controls.Add(Me.chartPoint)
            Me.dockPanelPoint_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPoint_Container.Name = "dockPanelPoint_Container"
            Me.dockPanelPoint_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelPoint_Container.TabIndex = 0
            ' 
            ' chartPoint
            ' 
            Me.chartPoint.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            radarDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            radarDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            radarDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            radarDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
            radarDiagram1.AxisY.Label.TextPattern = "{V}°C"
            radarDiagram1.AxisY.VisualRange.Auto = False
            radarDiagram1.AxisY.VisualRange.AutoSideMargins = False
            radarDiagram1.AxisY.VisualRange.MaxValueSerializable = "24.2"
            radarDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
            radarDiagram1.AxisY.VisualRange.SideMarginsValue = 0R
            radarDiagram1.AxisY.WholeRange.Auto = False
            radarDiagram1.AxisY.WholeRange.AutoSideMargins = False
            radarDiagram1.AxisY.WholeRange.MaxValueSerializable = "24.2"
            radarDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
            radarDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
            Me.chartPoint.Diagram = radarDiagram1
            Me.chartPoint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPoint.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartPoint.Legend.Name = "Default Legend"
            Me.chartPoint.Location = New System.Drawing.Point(0, 0)
            Me.chartPoint.Name = "chartPoint"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Night (min)"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
            series1.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            circularMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            radarPointSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation1
            series1.View = radarPointSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Day (max)"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24})
            series2.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            circularMarkerWidenAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            radarPointSeriesView2.SeriesPointAnimation = circularMarkerWidenAnimation2
            series2.View = radarPointSeriesView2
            Me.chartPoint.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            sideBySideBarSeriesLabel1.TextPattern = "{V:G2}"
            Me.chartPoint.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartPoint.Size = New System.Drawing.Size(788, 545)
            Me.chartPoint.TabIndex = 1
            Me.chartPoint.TabStop = False
            chartTitle1.Text = "Average Temperature in London"
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.weather.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            Me.chartPoint.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' dockPanelLine
            ' 
            Me.dockPanelLine.Controls.Add(Me.dockPanelLine_Container)
            Me.dockPanelLine.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelLine.DockedAsTabbedDocument = True
            Me.dockPanelLine.ID = New System.Guid("7c0f8b13-052b-4281-8834-ab6160ef824f")
            Me.dockPanelLine.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine.Name = "dockPanelLine"
            Me.dockPanelLine.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelLine.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelLine.Text = "Line"
            ' 
            ' dockPanelLine_Container
            ' 
            Me.dockPanelLine_Container.Controls.Add(Me.chartLine)
            Me.dockPanelLine_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine_Container.Name = "dockPanelLine_Container"
            Me.dockPanelLine_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelLine_Container.TabIndex = 0
            ' 
            ' chartLine
            ' 
            Me.chartLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            radarDiagram2.AxisX.DateTimeScaleOptions.AutoGrid = False
            radarDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            radarDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            radarDiagram2.AxisX.Label.TextPattern = "{A:MMMM}"
            radarDiagram2.AxisY.Label.TextPattern = "{V}°C"
            radarDiagram2.AxisY.VisualRange.Auto = False
            radarDiagram2.AxisY.VisualRange.AutoSideMargins = False
            radarDiagram2.AxisY.VisualRange.MaxValueSerializable = "24.2"
            radarDiagram2.AxisY.VisualRange.MinValueSerializable = "0"
            radarDiagram2.AxisY.VisualRange.SideMarginsValue = 0R
            radarDiagram2.AxisY.WholeRange.Auto = False
            radarDiagram2.AxisY.WholeRange.AutoSideMargins = False
            radarDiagram2.AxisY.WholeRange.MaxValueSerializable = "24.2"
            radarDiagram2.AxisY.WholeRange.MinValueSerializable = "0"
            radarDiagram2.AxisY.WholeRange.SideMarginsValue = 0R
            Me.chartLine.Diagram = radarDiagram2
            Me.chartLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartLine.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartLine.Legend.Name = "Default Legend"
            Me.chartLine.Location = New System.Drawing.Point(0, 0)
            Me.chartLine.Name = "chartLine"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series3.Name = "Night (min)"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36})
            series3.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            radarLineSeriesView1.LineMarkerOptions.Size = 8
            radarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
            quinticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
            circularMarkerSlideAnimation1.EasingFunction = quinticEasingFunction1
            radarLineSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation1
            series3.View = radarLineSeriesView1
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series4.Name = "Day (max)"
            series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43, seriesPoint44, seriesPoint45, seriesPoint46, seriesPoint47, seriesPoint48})
            series4.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            radarLineSeriesView2.LineMarkerOptions.Size = 8
            radarLineSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
            quinticEasingFunction2.EasingMode = DevExpress.XtraCharts.EasingMode.Out
            circularMarkerSlideAnimation2.EasingFunction = quinticEasingFunction2
            radarLineSeriesView2.SeriesPointAnimation = circularMarkerSlideAnimation2
            series4.View = radarLineSeriesView2
            Me.chartLine.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3, series4}
            sideBySideBarSeriesLabel2.TextPattern = "{V:G2}"
            Me.chartLine.SeriesTemplate.Label = sideBySideBarSeriesLabel2
            Me.chartLine.Size = New System.Drawing.Size(788, 545)
            Me.chartLine.TabIndex = 1
            Me.chartLine.TabStop = False
            chartTitle3.Text = "Average Temperature in London"
            chartTitle4.Alignment = System.Drawing.StringAlignment.Far
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = "From www.weather.com"
            chartTitle4.TextColor = System.Drawing.Color.Gray
            Me.chartLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4})
            ' 
            ' dockPanelArea
            ' 
            Me.dockPanelArea.Controls.Add(Me.dockPanelArea_Container)
            Me.dockPanelArea.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelArea.DockedAsTabbedDocument = True
            Me.dockPanelArea.ID = New System.Guid("1139f990-080c-43d3-acd7-57869fed505a")
            Me.dockPanelArea.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea.Name = "dockPanelArea"
            Me.dockPanelArea.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelArea.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelArea.Text = "Area"
            ' 
            ' dockPanelArea_Container
            ' 
            Me.dockPanelArea_Container.Controls.Add(Me.chartArea)
            Me.dockPanelArea_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea_Container.Name = "dockPanelArea_Container"
            Me.dockPanelArea_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelArea_Container.TabIndex = 0
            ' 
            ' chartArea
            ' 
            Me.chartArea.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            radarDiagram3.AxisX.DateTimeScaleOptions.AutoGrid = False
            radarDiagram3.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            radarDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            radarDiagram3.AxisX.Label.TextPattern = "{A:MMMM}"
            radarDiagram3.AxisX.WholeRange.AutoSideMargins = False
            radarDiagram3.AxisX.WholeRange.SideMarginsValue = 0R
            radarDiagram3.AxisY.Label.TextPattern = "{V}°C"
            radarDiagram3.AxisY.VisualRange.Auto = False
            radarDiagram3.AxisY.VisualRange.AutoSideMargins = False
            radarDiagram3.AxisY.VisualRange.MaxValueSerializable = "24.2"
            radarDiagram3.AxisY.VisualRange.MinValueSerializable = "0"
            radarDiagram3.AxisY.VisualRange.SideMarginsValue = 0R
            radarDiagram3.AxisY.WholeRange.Auto = False
            radarDiagram3.AxisY.WholeRange.AutoSideMargins = False
            radarDiagram3.AxisY.WholeRange.MaxValueSerializable = "24.2"
            radarDiagram3.AxisY.WholeRange.MinValueSerializable = "0"
            radarDiagram3.AxisY.WholeRange.SideMarginsValue = 0R
            Me.chartArea.Diagram = radarDiagram3
            Me.chartArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartArea.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartArea.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartArea.Legend.Name = "Default Legend"
            Me.chartArea.Location = New System.Drawing.Point(0, 0)
            Me.chartArea.Name = "chartArea"
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series5.Name = "Day (max)"
            series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint49, seriesPoint50, seriesPoint51, seriesPoint52, seriesPoint53, seriesPoint54, seriesPoint55, seriesPoint56, seriesPoint57, seriesPoint58, seriesPoint59, seriesPoint60})
            series5.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            radarAreaSeriesView1.MarkerOptions.Size = 8
            radarAreaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularSeriesCircularUnwindAnimation1.EasingFunction = linearEasingFunction1
            radarAreaSeriesView1.SeriesAnimation = circularSeriesCircularUnwindAnimation1
            circularMarkerWidenAnimation3.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
            radarAreaSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation3
            series5.View = radarAreaSeriesView1
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series6.Name = "Night (min)"
            series6.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint61, seriesPoint62, seriesPoint63, seriesPoint64, seriesPoint65, seriesPoint66, seriesPoint67, seriesPoint68, seriesPoint69, seriesPoint70, seriesPoint71, seriesPoint72})
            series6.ToolTipPointPattern = "{A:MMMM}: {V:0.##}°C"
            radarAreaSeriesView2.MarkerOptions.Size = 8
            radarAreaSeriesView2.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularSeriesCircularUnwindAnimation2.EasingFunction = linearEasingFunction2
            radarAreaSeriesView2.SeriesAnimation = circularSeriesCircularUnwindAnimation2
            circularMarkerWidenAnimation4.BeginTime = System.TimeSpan.Parse("00:00:01.2000000")
            radarAreaSeriesView2.SeriesPointAnimation = circularMarkerWidenAnimation4
            series6.View = radarAreaSeriesView2
            Me.chartArea.SeriesSerializable = New DevExpress.XtraCharts.Series() {series5, series6}
            sideBySideBarSeriesLabel3.TextPattern = "{V:G2}"
            Me.chartArea.SeriesTemplate.Label = sideBySideBarSeriesLabel3
            Me.chartArea.Size = New System.Drawing.Size(788, 545)
            Me.chartArea.TabIndex = 1
            Me.chartArea.TabStop = False
            chartTitle5.Text = "Average Temperature in London"
            chartTitle6.Alignment = System.Drawing.StringAlignment.Far
            chartTitle6.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle6.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle6.Text = "From www.weather.com"
            chartTitle6.TextColor = System.Drawing.Color.Gray
            Me.chartArea.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle5, chartTitle6})
            ' 
            ' dockPanelScatterLine
            ' 
            Me.dockPanelScatterLine.Controls.Add(Me.dockPanelScatterLine_Container)
            Me.dockPanelScatterLine.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelScatterLine.DockedAsTabbedDocument = True
            Me.dockPanelScatterLine.FloatLocation = New System.Drawing.Point(135, 123)
            Me.dockPanelScatterLine.ID = New System.Guid("6a7e3a57-b87a-42ae-adf8-3662f3db313a")
            Me.dockPanelScatterLine.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelScatterLine.Name = "dockPanelScatterLine"
            Me.dockPanelScatterLine.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelScatterLine.SavedIndex = 3
            Me.dockPanelScatterLine.SavedMdiDocument = True
            Me.dockPanelScatterLine.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelScatterLine.Text = "Scatter Line"
            ' 
            ' dockPanelScatterLine_Container
            ' 
            Me.dockPanelScatterLine_Container.Controls.Add(Me.chartScatterLine)
            Me.dockPanelScatterLine_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelScatterLine_Container.Name = "dockPanelScatterLine_Container"
            Me.dockPanelScatterLine_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelScatterLine_Container.TabIndex = 0
            ' 
            ' chartScatterLine
            ' 
            Me.chartScatterLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            radarDiagram4.AxisX.GridLines.MinorVisible = True
            radarDiagram4.AxisX.Label.TextPattern = "{A:0.##}"
            radarDiagram4.AxisX.NumericScaleOptions.AutoGrid = False
            radarDiagram4.AxisX.NumericScaleOptions.GridSpacing = 0.523598R
            radarDiagram4.AxisX.WholeRange.Auto = False
            radarDiagram4.AxisX.WholeRange.AutoSideMargins = False
            radarDiagram4.AxisX.WholeRange.MaxValueSerializable = "6.28"
            radarDiagram4.AxisX.WholeRange.MinValueSerializable = "0"
            radarDiagram4.AxisX.WholeRange.SideMarginsValue = 0R
            radarDiagram4.AxisY.Label.Angle = -90
            radarDiagram4.StartAngleInDegrees = 270R
            Me.chartScatterLine.Diagram = radarDiagram4
            Me.chartScatterLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartScatterLine.Legend.Name = "Default Legend"
            Me.chartScatterLine.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartScatterLine.Location = New System.Drawing.Point(0, 0)
            Me.chartScatterLine.Name = "chartScatterLine"
            radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarPointSeriesLabel1.TextPattern = "{V:N2}"
            series7.Label = radarPointSeriesLabel1
            series7.Name = "Function"
            series7.ToolTipPointPattern = "{A:F2}: {V:F2}"
            scatterRadarLineSeriesView1.Closed = False
            scatterRadarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
            exponentialEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
            exponentialEasingFunction1.Exponent = 5R
            circularSeriesSpinZoomInAnimation1.EasingFunction = exponentialEasingFunction1
            scatterRadarLineSeriesView1.SeriesAnimation = circularSeriesSpinZoomInAnimation1
            series7.View = scatterRadarLineSeriesView1
            Me.chartScatterLine.SeriesSerializable = New DevExpress.XtraCharts.Series() {series7}
            Me.chartScatterLine.Size = New System.Drawing.Size(788, 545)
            Me.chartScatterLine.TabIndex = 1
            Me.chartScatterLine.TabStop = False
            chartTitle7.Text = "Function in Polar Coordinates"
            chartTitle8.Alignment = System.Drawing.StringAlignment.Far
            chartTitle8.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle8.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle8.Text = ""
            chartTitle8.TextColor = System.Drawing.Color.Gray
            Me.chartScatterLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle7, chartTitle8})
            ' 
            ' dockPanelRangeArea
            ' 
            Me.dockPanelRangeArea.Controls.Add(Me.dockPanelRangeArea_Container)
            Me.dockPanelRangeArea.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelRangeArea.DockedAsTabbedDocument = True
            Me.dockPanelRangeArea.ID = New System.Guid("82fdea7e-c25b-4029-be54-a03d22bc283e")
            Me.dockPanelRangeArea.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea.Name = "dockPanelRangeArea"
            Me.dockPanelRangeArea.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelRangeArea.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelRangeArea.Text = "Range Area"
            ' 
            ' dockPanelRangeArea_Container
            ' 
            Me.dockPanelRangeArea_Container.Controls.Add(Me.chartRangeArea)
            Me.dockPanelRangeArea_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea_Container.Name = "dockPanelRangeArea_Container"
            Me.dockPanelRangeArea_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelRangeArea_Container.TabIndex = 0
            ' 
            ' chartRangeArea
            ' 
            Me.chartRangeArea.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            radarDiagram5.AxisX.DateTimeScaleOptions.AutoGrid = False
            radarDiagram5.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            radarDiagram5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            radarDiagram5.AxisX.Label.TextPattern = "{A:MMMM}"
            radarDiagram5.AxisX.WholeRange.AutoSideMargins = False
            radarDiagram5.AxisX.WholeRange.SideMarginsValue = 0R
            radarDiagram5.AxisY.Label.TextPattern = "{V}°C"
            Me.chartRangeArea.Diagram = radarDiagram5
            Me.chartRangeArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartRangeArea.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartRangeArea.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartRangeArea.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartRangeArea.Legend.Name = "Default Legend"
            Me.chartRangeArea.Location = New System.Drawing.Point(0, 0)
            Me.chartRangeArea.Name = "chartRangeArea"
            series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            radarRangeAreaSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarRangeAreaSeriesLabel1.TextPattern = "{V:F}"
            series8.Label = radarRangeAreaSeriesLabel1
            series8.Name = "Day-Night"
            series8.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint73, seriesPoint74, seriesPoint75, seriesPoint76, seriesPoint77, seriesPoint78, seriesPoint79, seriesPoint80, seriesPoint81, seriesPoint82, seriesPoint83, seriesPoint84})
            series8.ToolTipPointPattern = "{A:MMMM}: {V2:0.##}°C - {V1:0.##}°C"
            radarRangeAreaSeriesView1.Border1.Color = System.Drawing.Color.FromArgb((CInt(((CByte((27)))))), (CInt(((CByte((174)))))), (CInt(((CByte((73)))))))
            radarRangeAreaSeriesView1.Border2.Color = System.Drawing.Color.FromArgb((CInt(((CByte((216)))))), (CInt(((CByte((0)))))), (CInt(((CByte((121)))))))
            radarRangeAreaSeriesView1.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[True]
            radarRangeAreaSeriesView1.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[True]
            radarRangeAreaSeriesView1.SeriesAnimation = circularSeriesLinearUnwindAnimation1
            circularMarkerSlideAnimation3.BeginTime = System.TimeSpan.Parse("00:00:00.4000000")
            circularMarkerSlideAnimation3.Duration = System.TimeSpan.Parse("00:00:00.8000000")
            radarRangeAreaSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation3
            series8.View = radarRangeAreaSeriesView1
            Me.chartRangeArea.SeriesSerializable = New DevExpress.XtraCharts.Series() {series8}
            Me.chartRangeArea.Size = New System.Drawing.Size(788, 545)
            Me.chartRangeArea.TabIndex = 2
            Me.chartRangeArea.TabStop = False
            chartTitle9.Text = "Average Temperature in London"
            chartTitle10.Alignment = System.Drawing.StringAlignment.Far
            chartTitle10.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle10.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle10.Text = "From www.weather.com"
            chartTitle10.TextColor = System.Drawing.Color.Gray
            Me.chartRangeArea.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle9, chartTitle10})
            ' 
            ' documentManager
            ' 
            Me.documentManager.ContainerControl = Me
            Me.documentManager.View = Me.currentTabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.currentTabbedView})
            ' 
            ' currentTabbedView
            ' 
            Me.currentTabbedView.DocumentGroupProperties.HeaderButtons = DevExpress.XtraTab.TabButtons.None
            Me.currentTabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = False
            Me.currentTabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup})
            Me.currentTabbedView.DocumentProperties.AllowClose = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentPoint, Me.documentLine, Me.documentArea, Me.documentRangeArea, Me.documentScatterLine})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditMarkerSize)
            Me.layoutControl.Controls.Add(Me.checkEditMarkerVisible)
            Me.layoutControl.Controls.Add(Me.comboBoxEditMarkerKind)
            Me.layoutControl.Controls.Add(Me.comboBoxEditFunction)
            Me.layoutControl.Controls.Add(Me.comboBoxDiagramStyle)
            Me.layoutControl.Controls.Add(Me.comboBoxEditTextDirection)
            Me.layoutControl.Controls.Add(Me.comboBoxEditRotationDirection)
            Me.layoutControl.Controls.Add(Me.spinEditStartAngle)
            Me.layoutControl.Controls.Add(Me.spinEditAxisLabelAngle)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 136, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 229)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Show Series Labels"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 19)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 6
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditMarkerSize
            ' 
            Me.spinEditMarkerSize.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditMarkerSize.Location = New System.Drawing.Point(107, 338)
            Me.spinEditMarkerSize.Name = "spinEditMarkerSize"
            Me.spinEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMarkerSize.Properties.IsFloatValue = False
            Me.spinEditMarkerSize.Properties.Mask.EditMask = "N00"
            Me.spinEditMarkerSize.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditMarkerSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMarkerSize.Size = New System.Drawing.Size(122, 20)
            Me.spinEditMarkerSize.StyleController = Me.layoutControl
            Me.spinEditMarkerSize.TabIndex = 8
            ' 
            ' checkEditMarkerVisible
            ' 
            Me.checkEditMarkerVisible.EditValue = True
            Me.checkEditMarkerVisible.Location = New System.Drawing.Point(12, 315)
            Me.checkEditMarkerVisible.Name = "checkEditMarkerVisible"
            Me.checkEditMarkerVisible.Properties.Caption = "Visible"
            Me.checkEditMarkerVisible.Size = New System.Drawing.Size(217, 19)
            Me.checkEditMarkerVisible.StyleController = Me.layoutControl
            Me.checkEditMarkerVisible.TabIndex = 7
            AddHandler Me.checkEditMarkerVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditMarkerVisible_CheckedChanged)
            ' 
            ' comboBoxEditMarkerKind
            ' 
            Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(107, 362)
            Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
            Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxEditMarkerKind.StyleController = Me.layoutControl
            Me.comboBoxEditMarkerKind.TabIndex = 9
            ' 
            ' comboBoxEditFunction
            ' 
            Me.comboBoxEditFunction.Location = New System.Drawing.Point(107, 31)
            Me.comboBoxEditFunction.Name = "comboBoxEditFunction"
            Me.comboBoxEditFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditFunction.Properties.Items.AddRange(New Object() {"Archimedean Spiral", "Cardioid", "Cartesian Folium"})
            Me.comboBoxEditFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditFunction.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxEditFunction.StyleController = Me.layoutControl
            Me.comboBoxEditFunction.TabIndex = 0
            AddHandler Me.comboBoxEditFunction.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditFunction_SelectedIndexChanged)
            ' 
            ' comboBoxDiagramStyle
            ' 
            Me.comboBoxDiagramStyle.EditValue = "Polygon"
            Me.comboBoxDiagramStyle.Location = New System.Drawing.Point(107, 94)
            Me.comboBoxDiagramStyle.Name = "comboBoxDiagramStyle"
            Me.comboBoxDiagramStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxDiagramStyle.Properties.Items.AddRange(New Object() {"Circle", "Polygon"})
            Me.comboBoxDiagramStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxDiagramStyle.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxDiagramStyle.StyleController = Me.layoutControl
            Me.comboBoxDiagramStyle.TabIndex = 2
            AddHandler Me.comboBoxDiagramStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditDiagramStyle_SelectedIndexChanged)
            ' 
            ' comboBoxEditTextDirection
            ' 
            Me.comboBoxEditTextDirection.Location = New System.Drawing.Point(107, 118)
            Me.comboBoxEditTextDirection.Name = "comboBoxEditTextDirection"
            Me.comboBoxEditTextDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditTextDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditTextDirection.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxEditTextDirection.StyleController = Me.layoutControl
            Me.comboBoxEditTextDirection.TabIndex = 3
            AddHandler Me.comboBoxEditTextDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditTextDirection_SelectedIndexChanged)
            ' 
            ' comboBoxEditRotationDirection
            ' 
            Me.comboBoxEditRotationDirection.EditValue = "Counterclockwise"
            Me.comboBoxEditRotationDirection.Location = New System.Drawing.Point(107, 142)
            Me.comboBoxEditRotationDirection.Name = "comboBoxEditRotationDirection"
            Me.comboBoxEditRotationDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditRotationDirection.Properties.Items.AddRange(New Object() {"Counterclockwise", "Clockwise"})
            Me.comboBoxEditRotationDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditRotationDirection.Size = New System.Drawing.Size(122, 20)
            Me.comboBoxEditRotationDirection.StyleController = Me.layoutControl
            Me.comboBoxEditRotationDirection.TabIndex = 4
            AddHandler Me.comboBoxEditRotationDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditRotationDirection_SelectedIndexChanged)
            ' 
            ' spinEditStartAngle
            ' 
            Me.spinEditStartAngle.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditStartAngle.Location = New System.Drawing.Point(107, 166)
            Me.spinEditStartAngle.Name = "spinEditStartAngle"
            Me.spinEditStartAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditStartAngle.Properties.DisplayFormat.FormatString = "0°"
            Me.spinEditStartAngle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditStartAngle.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditStartAngle.Properties.IsFloatValue = False
            Me.spinEditStartAngle.Properties.Mask.EditMask = "N00"
            Me.spinEditStartAngle.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
            Me.spinEditStartAngle.Size = New System.Drawing.Size(122, 20)
            Me.spinEditStartAngle.StyleController = Me.layoutControl
            Me.spinEditStartAngle.TabIndex = 5
            AddHandler Me.spinEditStartAngle.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditStartAngle_EditValueChanged)
            ' 
            ' spinEditAxisLabelAngle
            ' 
            Me.spinEditAxisLabelAngle.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Location = New System.Drawing.Point(107, 252)
            Me.spinEditAxisLabelAngle.Name = "spinEditAxisLabelAngle"
            Me.spinEditAxisLabelAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditAxisLabelAngle.Properties.DisplayFormat.FormatString = "0°"
            Me.spinEditAxisLabelAngle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditAxisLabelAngle.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Properties.IsFloatValue = False
            Me.spinEditAxisLabelAngle.Properties.Mask.EditMask = "N00"
            Me.spinEditAxisLabelAngle.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Properties.MinValue = New Decimal(New Integer() {360, 0, 0, -2147483648})
            Me.spinEditAxisLabelAngle.Size = New System.Drawing.Size(122, 20)
            Me.spinEditAxisLabelAngle.StyleController = Me.layoutControl
            Me.spinEditAxisLabelAngle.TabIndex = 18
            AddHandler Me.spinEditAxisLabelAngle.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditAxisLabelAngle_EditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupLabel, Me.layoutControlGroupMarker, Me.emptySpaceItem, Me.layoutControlGroupDiagram, Me.layoutControlGroupGeneral})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.CustomizationFormText = "Label"
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItem1})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 198)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 86)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.spinEditAxisLabelAngle
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItemAxisLabelAngle"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.Text = "Y-Axis Label Angle:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlGroupMarker
            ' 
            Me.layoutControlGroupMarker.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupMarker.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupMarker.CustomizationFormText = "Marker"
            Me.layoutControlGroupMarker.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarker.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemMarkerSize, Me.layoutControlItemMarkerVisible, Me.layoutControlItemMarkerKind})
            Me.layoutControlGroupMarker.Location = New System.Drawing.Point(0, 284)
            Me.layoutControlGroupMarker.Name = "layoutControlGroupMarker"
            Me.layoutControlGroupMarker.Size = New System.Drawing.Size(241, 110)
            Me.layoutControlGroupMarker.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarker.Text = "Marker"
            ' 
            ' layoutControlItemMarkerSize
            ' 
            Me.layoutControlItemMarkerSize.Control = Me.spinEditMarkerSize
            Me.layoutControlItemMarkerSize.CustomizationFormText = "Size:"
            Me.layoutControlItemMarkerSize.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItemMarkerSize.Name = "layoutControlItemMarkerSize"
            Me.layoutControlItemMarkerSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMarkerSize.Text = "Size:"
            Me.layoutControlItemMarkerSize.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemMarkerVisible
            ' 
            Me.layoutControlItemMarkerVisible.Control = Me.checkEditMarkerVisible
            Me.layoutControlItemMarkerVisible.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItemMarkerVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemMarkerVisible.Name = "layoutControlItemMarkerVisible"
            Me.layoutControlItemMarkerVisible.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemMarkerVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemMarkerVisible.TextVisible = False
            ' 
            ' layoutControlItemMarkerKind
            ' 
            Me.layoutControlItemMarkerKind.Control = Me.comboBoxEditMarkerKind
            Me.layoutControlItemMarkerKind.CustomizationFormText = "Kind:"
            Me.layoutControlItemMarkerKind.Location = New System.Drawing.Point(0, 47)
            Me.layoutControlItemMarkerKind.Name = "layoutControlItemMarkerKind"
            Me.layoutControlItemMarkerKind.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMarkerKind.Text = "Kind:"
            Me.layoutControlItemMarkerKind.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 394)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 150)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupDiagram
            ' 
            Me.layoutControlGroupDiagram.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupDiagram.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemStartAngle, Me.layoutControlItemRotationDirection, Me.layoutControlItemStyle, Me.layoutControlItemTextDirection})
            Me.layoutControlGroupDiagram.Location = New System.Drawing.Point(0, 63)
            Me.layoutControlGroupDiagram.Name = "layoutControlGroupDiagram"
            Me.layoutControlGroupDiagram.Size = New System.Drawing.Size(241, 135)
            Me.layoutControlGroupDiagram.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupDiagram.Text = "Diagram"
            ' 
            ' layoutControlItemStartAngle
            ' 
            Me.layoutControlItemStartAngle.Control = Me.spinEditStartAngle
            Me.layoutControlItemStartAngle.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemStartAngle.Name = "layoutControlItemStartAngle"
            Me.layoutControlItemStartAngle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStartAngle.Text = "Start Angle:"
            Me.layoutControlItemStartAngle.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemRotationDirection
            ' 
            Me.layoutControlItemRotationDirection.Control = Me.comboBoxEditRotationDirection
            Me.layoutControlItemRotationDirection.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemRotationDirection.Name = "layoutControlItemRotationDirection"
            Me.layoutControlItemRotationDirection.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemRotationDirection.Text = "Rotation Direction:"
            Me.layoutControlItemRotationDirection.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemStyle
            ' 
            Me.layoutControlItemStyle.Control = Me.comboBoxDiagramStyle
            Me.layoutControlItemStyle.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemStyle.Name = "layoutControlItemStyle"
            Me.layoutControlItemStyle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStyle.Text = "Style:"
            Me.layoutControlItemStyle.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemTextDirection
            ' 
            Me.layoutControlItemTextDirection.Control = Me.comboBoxEditTextDirection
            Me.layoutControlItemTextDirection.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemTextDirection.Name = "layoutControlItemTextDirection"
            Me.layoutControlItemTextDirection.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemTextDirection.Text = "Text Direction:"
            Me.layoutControlItemTextDirection.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemFunction})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 63)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemFunction
            ' 
            Me.layoutControlItemFunction.Control = Me.comboBoxEditFunction
            Me.layoutControlItemFunction.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemFunction.Name = "layoutControlItemFunction"
            Me.layoutControlItemFunction.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemFunction.Text = "Function:"
            Me.layoutControlItemFunction.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' RadarViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "RadarViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentScatterLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentRangeArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPoint.ResumeLayout(False)
            Me.dockPanelPoint_Container.ResumeLayout(False)
            CType((radarDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarPointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarPointSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelLine.ResumeLayout(False)
            Me.dockPanelLine_Container.ResumeLayout(False)
            CType((radarDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarLineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarLineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelArea.ResumeLayout(False)
            Me.dockPanelArea_Container.ResumeLayout(False)
            CType((radarDiagram3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarAreaSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartArea), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelScatterLine.ResumeLayout(False)
            Me.dockPanelScatterLine_Container.ResumeLayout(False)
            CType((radarDiagram4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarPointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((scatterRadarLineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartScatterLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelRangeArea.ResumeLayout(False)
            Me.dockPanelRangeArea_Container.ResumeLayout(False)
            CType((radarDiagram5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarRangeAreaSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarRangeAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartRangeArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxDiagramStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditTextDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditRotationDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditStartAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditAxisLabelAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStartAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRotationDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTextDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelPoint As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelPoint_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentPoint As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditMarkerSize As DevExpress.XtraEditors.SpinEdit

        Private checkEditMarkerVisible As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditMarkerKind As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxDiagramStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupMarker As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemMarkerSize As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMarkerVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMarkerKind As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemFunction As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemStyle As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private comboBoxEditTextDirection As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemTextDirection As DevExpress.XtraLayout.LayoutControlItem

        Private chartPoint As DevExpress.XtraCharts.ChartControl

        Private dockPanelLine As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelLine_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelArea As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelArea_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelRangeArea As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelRangeArea_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelScatterLine As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelScatterLine_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentLine As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentArea As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentRangeArea As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentScatterLine As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartLine As DevExpress.XtraCharts.ChartControl

        Private chartArea As DevExpress.XtraCharts.ChartControl

        Private chartRangeArea As DevExpress.XtraCharts.ChartControl

        Private chartScatterLine As DevExpress.XtraCharts.ChartControl

        Private comboBoxEditRotationDirection As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditStartAngle As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemRotationDirection As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemStartAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupDiagram As DevExpress.XtraLayout.LayoutControlGroup

        Private spinEditAxisLabelAngle As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
