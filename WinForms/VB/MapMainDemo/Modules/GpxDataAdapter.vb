Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Map
Imports DevExpress.XtraCharts

Namespace DevExpress.XtraMap.Demos

    Public Partial Class GpxDataAdapterDemo
        Inherits FooteredMapTutorialControl

        Const PointStrokeWidth As Integer = 2

        Private ReadOnly TrackColor As Color = Color.FromArgb(30, 140, 210)

        Private highlightedDot As MapDot

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return MapControl.Overlays.ToArray()
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chartControl1.DataSource = gpxFileDataAdapter1
            AddHandler gridLookUpEdit1.CustomDisplayText, AddressOf OnGridLookUpCustomDisplayText
            FillActivities()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
        End Sub

        Private Sub FillActivities()
            Dim xmlDataSet As DataSet = New DataSet("XML DataSet")
            xmlDataSet.ReadXml(DemoUtils.GetRelativePath("Gpx\Activities.xml"))
            Dim activities As DataTable = xmlDataSet.Tables("Activity")
            activities.Columns("Data").ColumnMapping = MappingType.Hidden
            gridLookUpEdit1.Properties.DataSource = activities
            gridLookUpEdit1.EditValue = activities.DefaultView(0)
        End Sub

        Private Sub VectorItemsLayer1_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            PopulateMapLayer()
            PopulateParams()
            RestoreInitialView()
            CType(chartControl1.Diagram, XYDiagram).AxisX.WholeRange.Auto = True
            CType(chartControl1.Diagram, XYDiagram).AxisX.VisualRange.Auto = True
            chartControl1.EndInit()
        End Sub

        Private Sub PopulateParams()
            Dim info As GpxTrackInfo = CalculateTrackInfo(gpxFileDataAdapter1)
            htmlContentControl1.DataContext = info
            Dim isTrackHasHeartRate As Boolean = info.AverageHeartRate <> 0
            chartControl1.Series(1).Visible = isTrackHasHeartRate
            htmlContentControl1.HtmlTemplate.Template = GenerateTrackTemplate(isTrackHasHeartRate)
            htmlContentControl1.MaximumSize = htmlContentControl1.GetContentSize()
        End Sub

        Private Sub PopulateMapLayer()
            Dim pathSegment As MapPathSegment = CType(Enumerable.First(GpxDataLayer.Data.Items), MapPath).Segments(0)
            Dim startPosition As CoordPoint = pathSegment.Points(0)
            Dim endPosition As CoordPoint = pathSegment.Points.Last()
            Dim startPoint As MapDot = New MapDot() With {.Location = startPosition, .Stroke = Color.White, .StrokeWidth = PointStrokeWidth, .Fill = TrackColor, .Size = DemoUtils.DipToPixels(16)}
            Dim finishPoint As MapDot = New MapDot() With {.Location = endPosition, .Stroke = Color.White, .StrokeWidth = PointStrokeWidth, .Fill = TrackColor, .Size = DemoUtils.DipToPixels(16)}
            highlightedDot = New MapDot() With {.Fill = TrackColor, .Stroke = Color.White, .StrokeWidth = PointStrokeWidth, .Visible = False, .Size = DemoUtils.DipToPixels(10)}
            startPoint.TitleOptions.Pattern = "A"
            startPoint.TitleOptions.TextColor = Color.White
            startPoint.TitleOptions.TextGlowColor = Color.Transparent
            startPoint.TitleOptions.Visibility = VisibilityMode.Visible
            finishPoint.TitleOptions.Pattern = "B"
            finishPoint.TitleOptions.TextColor = Color.White
            finishPoint.TitleOptions.TextGlowColor = Color.Transparent
            finishPoint.TitleOptions.Visibility = VisibilityMode.Visible
            mapItemStorage1.Items.AddRange(New MapItem() {startPoint, finishPoint, highlightedDot})
        End Sub

        Private Sub ChartControl1_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            If e.CrosshairElementGroups.Count > 0 Then
                Dim sourceItem As DataRowView = CType(e.CrosshairElementGroups(0).CrosshairElements(0).SeriesPoint.Tag, DataRowView)
                highlightedDot.Location = New GeoPoint(CDbl(sourceItem("lat")), CDbl(sourceItem("lon")))
            End If
        End Sub

        Private Sub OnGridLookUpCustomDisplayText(ByVal sender As Object, ByVal e As XtraEditors.Controls.CustomDisplayTextEventArgs)
            Dim rowView As DataRowView = TryCast(e.Value, DataRowView)
            If rowView IsNot Nothing Then e.DisplayText = String.Format("{0:D} - {1}", rowView("Date"), rowView("Title"))
        End Sub

        Private Sub OnGridLookUpEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            chartControl1.BeginInit()
            mapItemStorage1.Items.Clear()
            Dim uriStr As String = String.Format("Gpx\{0}.gpx", CType(gridLookUpEdit1.EditValue, DataRowView)("Data"))
            gpxFileDataAdapter1.FileUri = DemoUtils.GetFileUri(uriStr)
        End Sub

        Private Sub ChartControl1_MouseMove(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs)
            highlightedDot.Visible = chartControl1.CalcHitInfo(New Point(e.X, e.Y)).InDiagram
        End Sub

        Protected Overrides Sub RestoreInitialView()
            MapControl.Measurements.RemoveRulers()
            MapControl.ZoomToFitLayerItems(New LayerBase() {GpxDataLayer})
        End Sub

        Private Sub mapControl1_OverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs)
            Dim rulerRect As Rectangle = e.OverlayArrangements(0).OverlayLayout
            e.OverlayArrangements(0).OverlayLayout = New Rectangle(New Point(gridLookUpEdit1.Left, MapControl.ClientSize.Height - rulerRect.Height - DemoUtils.DipToPixels(14)), rulerRect.Size)
        End Sub
    End Class

    Public Class GpxTrackInfo

        Public Property Duration As TimeSpan

        Public Property Distance As Double

        Public Property AverageHeartRate As Integer

        Public Property MinHeartRate As Integer

        Public Property MaxHeartRate As Integer

        Public Property AveragePace As String

        Public Property MaxPace As String
    End Class
End Namespace
