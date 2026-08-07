Namespace DevExpress.XtraCharts.Demos

    Partial Class HitTestingDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim textAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
            Dim chartAnchorPoint1 As DevExpress.XtraCharts.ChartAnchorPoint = New DevExpress.XtraCharts.ChartAnchorPoint()
            Dim freePosition1 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane2 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim constantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 6, 0, 0, 0), New Object() {(CObj((56.48R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 3, 0, 0, 0), New Object() {(CObj((53.78R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 0, 0, 0, 0), New Object() {(CObj((57.74R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 21, 0, 0, 0), New Object() {(CObj((64.4R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 18, 0, 0, 0), New Object() {(CObj((72.5R)))})
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 15, 0, 0, 0), New Object() {(CObj((72.68R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 12, 0, 0, 0), New Object() {(CObj((69.62R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 9, 0, 0, 0), New Object() {(CObj((67.28R)))})
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 6, 0, 0, 0), New Object() {(CObj((62.42R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 3, 0, 0, 0), New Object() {(CObj((60.62R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 0, 0, 0, 0), New Object() {(CObj((62.6R)))})
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 21, 0, 0, 0), New Object() {(CObj((71.96R)))})
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 18, 0, 0, 0), New Object() {(CObj((77.9R)))})
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 15, 0, 0, 0), New Object() {(CObj((78.98R)))})
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 12, 0, 0, 0), New Object() {(CObj((76.28R)))})
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 9, 0, 0, 0), New Object() {(CObj((71.06R)))})
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 6, 0, 0, 0), New Object() {(CObj((60.8R)))})
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 3, 0, 0, 0), New Object() {(CObj((58.64R)))})
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 0, 0, 0, 0), New Object() {(CObj((63.14R)))})
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 21, 0, 0, 0), New Object() {(CObj((68.54R)))})
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 18, 0, 0, 0), New Object() {(CObj((75.2R)))})
            Dim seriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 15, 0, 0, 0), New Object() {(CObj((77.18R)))})
            Dim seriesPoint23 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 12, 0, 0, 0), New Object() {(CObj((74.48R)))})
            Dim seriesPoint24 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 9, 0, 0, 0), New Object() {(CObj((64.58R)))})
            Dim seriesPoint25 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 6, 0, 0, 0), New Object() {(CObj((59.36R)))})
            Dim seriesPoint26 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 3, 0, 0, 0), New Object() {(CObj((60.08R)))})
            Dim seriesPoint27 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 0, 0, 0, 0), New Object() {(CObj((61.16R)))})
            Dim seriesPoint28 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 21, 0, 0, 0), New Object() {(CObj((63.86R)))})
            Dim seriesPoint29 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 18, 0, 0, 0), New Object() {(CObj((65.66R)))})
            Dim seriesPoint30 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 15, 0, 0, 0), New Object() {(CObj((65.12R)))})
            Dim seriesPoint31 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 12, 0, 0, 0), New Object() {(CObj((63.86R)))})
            Dim seriesPoint32 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 9, 0, 0, 0), New Object() {(CObj((61.52R)))})
            Dim seriesPoint33 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 6, 0, 0, 0), New Object() {(CObj((51.8R)))})
            Dim seriesPoint34 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 3, 0, 0, 0), New Object() {(CObj((52.34R)))})
            Dim seriesPoint35 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 0, 0, 0, 0), New Object() {(CObj((57.2R)))})
            Dim seriesPoint36 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 21, 0, 0, 0), New Object() {(CObj((60.44R)))})
            Dim seriesPoint37 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 18, 0, 0, 0), New Object() {(CObj((65.48R)))})
            Dim seriesPoint38 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 15, 0, 0, 0), New Object() {(CObj((66.56R)))})
            Dim seriesPoint39 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 12, 0, 0, 0), New Object() {(CObj((64.04R)))})
            Dim seriesPoint40 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 9, 0, 0, 0), New Object() {(CObj((60.26R)))})
            Dim seriesPoint41 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 6, 0, 0, 0), New Object() {(CObj((51.44R)))})
            Dim seriesPoint42 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 3, 0, 0, 0), New Object() {(CObj((50.18R)))})
            Dim seriesPoint43 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 0, 0, 0, 0), New Object() {(CObj((56.12R)))})
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint44 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 6, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint45 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 3, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint46 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 0, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint47 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 21, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint48 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 18, 0, 0, 0), New Object() {(CObj((1020R)))})
            Dim seriesPoint49 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 15, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint50 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 12, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint51 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 9, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint52 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 6, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint53 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 3, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint54 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 0, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint55 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 21, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint56 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 18, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint57 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 15, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint58 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 12, 0, 0, 0), New Object() {(CObj((1024R)))})
            Dim seriesPoint59 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 9, 0, 0, 0), New Object() {(CObj((1024R)))})
            Dim seriesPoint60 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 6, 0, 0, 0), New Object() {(CObj((1024R)))})
            Dim seriesPoint61 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 3, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint62 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 0, 0, 0, 0), New Object() {(CObj((1024R)))})
            Dim seriesPoint63 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 21, 0, 0, 0), New Object() {(CObj((1023R)))})
            Dim seriesPoint64 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 18, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint65 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 15, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint66 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 12, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint67 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 9, 0, 0, 0), New Object() {(CObj((1021R)))})
            Dim seriesPoint68 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 6, 0, 0, 0), New Object() {(CObj((1020R)))})
            Dim seriesPoint69 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 3, 0, 0, 0), New Object() {(CObj((1019R)))})
            Dim seriesPoint70 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 0, 0, 0, 0), New Object() {(CObj((1019R)))})
            Dim seriesPoint71 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 21, 0, 0, 0), New Object() {(CObj((1019R)))})
            Dim seriesPoint72 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 18, 0, 0, 0), New Object() {(CObj((1017R)))})
            Dim seriesPoint73 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 15, 0, 0, 0), New Object() {(CObj((1017R)))})
            Dim seriesPoint74 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 12, 0, 0, 0), New Object() {(CObj((1017R)))})
            Dim seriesPoint75 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 9, 0, 0, 0), New Object() {(CObj((1017R)))})
            Dim seriesPoint76 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 6, 0, 0, 0), New Object() {(CObj((1017R)))})
            Dim seriesPoint77 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 3, 0, 0, 0), New Object() {(CObj((1016R)))})
            Dim seriesPoint78 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 0, 0, 0, 0), New Object() {(CObj((1016R)))})
            Dim seriesPoint79 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 21, 0, 0, 0), New Object() {(CObj((1016R)))})
            Dim seriesPoint80 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 18, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint81 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 15, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint82 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 12, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint83 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 9, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint84 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 6, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint85 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 3, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim seriesPoint86 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 0, 0, 0, 0), New Object() {(CObj((1015R)))})
            Dim areaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesPoint87 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 6, 0, 0, 0), New Object() {(CObj((69R)))})
            Dim seriesPoint88 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 3, 0, 0, 0), New Object() {(CObj((76R)))})
            Dim seriesPoint89 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 11, 0, 0, 0, 0), New Object() {(CObj((66R)))})
            Dim seriesPoint90 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 21, 0, 0, 0), New Object() {(CObj((49R)))})
            Dim seriesPoint91 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 18, 0, 0, 0), New Object() {(CObj((45R)))})
            Dim seriesPoint92 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 15, 0, 0, 0), New Object() {(CObj((48R)))})
            Dim seriesPoint93 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 12, 0, 0, 0), New Object() {(CObj((57R)))})
            Dim seriesPoint94 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 9, 0, 0, 0), New Object() {(CObj((66R)))})
            Dim seriesPoint95 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 6, 0, 0, 0), New Object() {(CObj((78R)))})
            Dim seriesPoint96 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 3, 0, 0, 0), New Object() {(CObj((83R)))})
            Dim seriesPoint97 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 10, 0, 0, 0, 0), New Object() {(CObj((72R)))})
            Dim seriesPoint98 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 21, 0, 0, 0), New Object() {(CObj((52R)))})
            Dim seriesPoint99 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 18, 0, 0, 0), New Object() {(CObj((40R)))})
            Dim seriesPoint100 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 15, 0, 0, 0), New Object() {(CObj((41R)))})
            Dim seriesPoint101 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 12, 0, 0, 0), New Object() {(CObj((37R)))})
            Dim seriesPoint102 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 9, 0, 0, 0), New Object() {(CObj((41R)))})
            Dim seriesPoint103 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 6, 0, 0, 0), New Object() {(CObj((68R)))})
            Dim seriesPoint104 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 3, 0, 0, 0), New Object() {(CObj((78R)))})
            Dim seriesPoint105 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 9, 0, 0, 0, 0), New Object() {(CObj((71R)))})
            Dim seriesPoint106 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 21, 0, 0, 0), New Object() {(CObj((63R)))})
            Dim seriesPoint107 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 18, 0, 0, 0), New Object() {(CObj((47R)))})
            Dim seriesPoint108 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 15, 0, 0, 0), New Object() {(CObj((44R)))})
            Dim seriesPoint109 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 12, 0, 0, 0), New Object() {(CObj((48R)))})
            Dim seriesPoint110 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 9, 0, 0, 0), New Object() {(CObj((68R)))})
            Dim seriesPoint111 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 6, 0, 0, 0), New Object() {(CObj((81R)))})
            Dim seriesPoint112 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 3, 0, 0, 0), New Object() {(CObj((85R)))})
            Dim seriesPoint113 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 8, 0, 0, 0, 0), New Object() {(CObj((76R)))})
            Dim seriesPoint114 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 21, 0, 0, 0), New Object() {(CObj((65R)))})
            Dim seriesPoint115 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 18, 0, 0, 0), New Object() {(CObj((57R)))})
            Dim seriesPoint116 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 15, 0, 0, 0), New Object() {(CObj((62R)))})
            Dim seriesPoint117 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 12, 0, 0, 0), New Object() {(CObj((53R)))})
            Dim seriesPoint118 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 9, 0, 0, 0), New Object() {(CObj((62R)))})
            Dim seriesPoint119 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 6, 0, 0, 0), New Object() {(CObj((76R)))})
            Dim seriesPoint120 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 3, 0, 0, 0), New Object() {(CObj((80R)))})
            Dim seriesPoint121 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 7, 0, 0, 0, 0), New Object() {(CObj((82R)))})
            Dim seriesPoint122 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 21, 0, 0, 0), New Object() {(CObj((73R)))})
            Dim seriesPoint123 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 18, 0, 0, 0), New Object() {(CObj((57R)))})
            Dim seriesPoint124 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 15, 0, 0, 0), New Object() {(CObj((55R)))})
            Dim seriesPoint125 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 12, 0, 0, 0), New Object() {(CObj((64R)))})
            Dim seriesPoint126 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 9, 0, 0, 0), New Object() {(CObj((74R)))})
            Dim seriesPoint127 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 6, 0, 0, 0), New Object() {(CObj((89R)))})
            Dim seriesPoint128 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 3, 0, 0, 0), New Object() {(CObj((87R)))})
            Dim seriesPoint129 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(New System.DateTime(2008, 6, 6, 0, 0, 0, 0), New Object() {(CObj((80R)))})
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((textAnnotation1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((constantLine1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            textAnnotation1.AnchorPoint = chartAnchorPoint1
            textAnnotation1.AnnotationID = 0
            textAnnotation1.AutoHeight = True
            textAnnotation1.AutoWidth = True
            textAnnotation1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            textAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None
            textAnnotation1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            textAnnotation1.Name = "Text Annotation 1"
            freePosition1.DockCorner = DevExpress.XtraCharts.DockCorner.RightBottom
            freePosition1.InnerIndents.Left = 0
            freePosition1.InnerIndents.Top = 0
            textAnnotation1.ShapePosition = freePosition1
            textAnnotation1.Text = "From <href=http://www.weather.com/>www.weather.com</href>"
            textAnnotation1.TextColor = System.Drawing.Color.Gray
            Me.chart.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {textAnnotation1})
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 10R
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Interlaced = True
            xyDiagram1.AxisX.Label.TextPattern = "{A:dd/MM HH:mm}"
            xyDiagram1.AxisX.Title.Text = "Date"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
            xyDiagram1.AxisX.VisualRange.EndSideMargin = 0R
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "06/11/2008 08:00:00.000"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "06/05/2008 22:00:00.000"
            xyDiagram1.AxisX.VisualRange.StartSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.Auto = False
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "06/11/2008 08:00:00.000"
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "06/05/2008 22:00:00.000"
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            xyDiagram1.AxisY.Title.Text = "Temperature, F"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DefaultPane.LayoutOptions.RowSpan = 20
            xyDiagram1.PaneDistance = 4
            xyDiagramPane1.LayoutOptions.RowSpan = 10
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane2.LayoutOptions.RowSpan = 17
            xyDiagramPane2.Name = "Pane 2"
            xyDiagramPane2.PaneID = 1
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1, xyDiagramPane2})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.MinorVisible = True
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Name = "secondaryAxisY1"
            secondaryAxisY1.NumericScaleOptions.AutoGrid = False
            secondaryAxisY1.NumericScaleOptions.GridSpacing = 4R
            secondaryAxisY1.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            secondaryAxisY1.Title.Text = "Pressure, mbar"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY1.VisualRange.Auto = False
            secondaryAxisY1.VisualRange.AutoSideMargins = False
            secondaryAxisY1.VisualRange.EndSideMargin = 0R
            secondaryAxisY1.VisualRange.MaxValueSerializable = "1025"
            secondaryAxisY1.VisualRange.MinValueSerializable = "1014"
            secondaryAxisY1.VisualRange.StartSideMargin = 0R
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY1.WholeRange.Auto = False
            secondaryAxisY1.WholeRange.AutoSideMargins = False
            secondaryAxisY1.WholeRange.EndSideMargin = 0R
            secondaryAxisY1.WholeRange.MaxValueSerializable = "1025"
            secondaryAxisY1.WholeRange.MinValueSerializable = "1014"
            secondaryAxisY1.WholeRange.StartSideMargin = 0R
            secondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY2.AxisID = 1
            constantLine1.AxisValueSerializable = "100"
            constantLine1.ConstantLineID = 0
            constantLine1.Name = "ConstantLine1"
            constantLine1.ShowInLegend = False
            constantLine1.Title.Visible = False
            secondaryAxisY2.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {constantLine1})
            secondaryAxisY2.GridLines.MinorVisible = True
            secondaryAxisY2.GridLines.Visible = True
            secondaryAxisY2.Name = "secondaryAxisY2"
            secondaryAxisY2.NumericScaleOptions.AutoGrid = False
            secondaryAxisY2.NumericScaleOptions.GridSpacing = 50R
            secondaryAxisY2.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            secondaryAxisY2.Title.Text = "Humidity, %"
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            secondaryAxisY2.VisibleInPanesSerializable = "1"
            secondaryAxisY2.VisualRange.Auto = False
            secondaryAxisY2.VisualRange.AutoSideMargins = False
            secondaryAxisY2.VisualRange.EndSideMargin = 0R
            secondaryAxisY2.VisualRange.MaxValueSerializable = "120"
            secondaryAxisY2.VisualRange.MinValueSerializable = "0"
            secondaryAxisY2.VisualRange.StartSideMargin = 0R
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY2.WholeRange.Auto = False
            secondaryAxisY2.WholeRange.AutoSideMargins = False
            secondaryAxisY2.WholeRange.EndSideMargin = 0R
            secondaryAxisY2.WholeRange.MaxValueSerializable = "120"
            secondaryAxisY2.WholeRange.MinValueSerializable = "0"
            secondaryAxisY2.WholeRange.StartSideMargin = 0R
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.RuntimeHitTesting = True
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            series1.Label = pointSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Name = "Temperature (F)"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43})
            series1.SeriesID = 0
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.View = lineSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            pointSeriesLabel2.Angle = 90
            pointSeriesLabel2.LineLength = 5
            series2.Label = pointSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Pressure (mbar)"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint44, seriesPoint45, seriesPoint46, seriesPoint47, seriesPoint48, seriesPoint49, seriesPoint50, seriesPoint51, seriesPoint52, seriesPoint53, seriesPoint54, seriesPoint55, seriesPoint56, seriesPoint57, seriesPoint58, seriesPoint59, seriesPoint60, seriesPoint61, seriesPoint62, seriesPoint63, seriesPoint64, seriesPoint65, seriesPoint66, seriesPoint67, seriesPoint68, seriesPoint69, seriesPoint70, seriesPoint71, seriesPoint72, seriesPoint73, seriesPoint74, seriesPoint75, seriesPoint76, seriesPoint77, seriesPoint78, seriesPoint79, seriesPoint80, seriesPoint81, seriesPoint82, seriesPoint83, seriesPoint84, seriesPoint85, seriesPoint86})
            series2.SeriesID = 1
            areaSeriesView1.AxisYName = "secondaryAxisY1"
            areaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[False]
            areaSeriesView1.PaneName = "Pane 1"
            areaSeriesView1.Transparency =(CByte((0)))
            series2.View = areaSeriesView1
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
            series3.Label = sideBySideBarSeriesLabel1
            series3.Name = "Relative humidity (%)"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint87, seriesPoint88, seriesPoint89, seriesPoint90, seriesPoint91, seriesPoint92, seriesPoint93, seriesPoint94, seriesPoint95, seriesPoint96, seriesPoint97, seriesPoint98, seriesPoint99, seriesPoint100, seriesPoint101, seriesPoint102, seriesPoint103, seriesPoint104, seriesPoint105, seriesPoint106, seriesPoint107, seriesPoint108, seriesPoint109, seriesPoint110, seriesPoint111, seriesPoint112, seriesPoint113, seriesPoint114, seriesPoint115, seriesPoint116, seriesPoint117, seriesPoint118, seriesPoint119, seriesPoint120, seriesPoint121, seriesPoint122, seriesPoint123, seriesPoint124, seriesPoint125, seriesPoint126, seriesPoint127, seriesPoint128, seriesPoint129})
            series3.SeriesID = 2
            sideBySideBarSeriesView1.AxisYName = "secondaryAxisY2"
            sideBySideBarSeriesView1.BarWidth = 1.5R
            sideBySideBarSeriesView1.PaneName = "Pane 2"
            series3.View = sideBySideBarSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3}
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 2
            chartTitle1.Text = "Weather in London"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.MouseLeave, New System.EventHandler(AddressOf Me.chart_MouseLeave)
            AddHandler Me.chart.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.chart_MouseMove)
            AddHandler Me.chart.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.chart_MouseUp)
            ' 
            ' HitTestingDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "HitTestingDemo"
            CType((textAnnotation1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((constantLine1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
