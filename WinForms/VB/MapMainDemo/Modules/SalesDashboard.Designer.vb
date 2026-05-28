Namespace DevExpress.XtraMap.Demos

    Partial Class SalesDashboard

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping3 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping4 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping5 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.SalesDashboard))
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleMarkerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleMarkerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleMarkerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Size = New System.Drawing.Size(601, 141)
            Me.TilesLayer.DataProvider = Me.AzureMapDataProvider
            Me.TilesLayer.Name = "TilesLayer"
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.ItemsLayer.Data = Me.ListSourceDataAdapter
            Me.ItemsLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent
            Me.ItemsLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.ItemsLayer.ItemImageIndex = 0
            Me.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent
            Me.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.ItemsLayer.Name = "ItemsLayer"
            Me.ItemsLayer.ToolTipPattern = "Address:  {ShopAddress}" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Phone:  {ShopPhone}" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Fax:  {ShopFax}"
            mapItemAttributeMapping1.Member = "Name"
            mapItemAttributeMapping1.Name = "ShopName"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping2.Member = "Phone"
            mapItemAttributeMapping2.Name = "ShopPhone"
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping3.Member = "Fax"
            mapItemAttributeMapping3.Name = "ShopFax"
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping4.Member = "Address"
            mapItemAttributeMapping4.Name = "ShopAddress"
            mapItemAttributeMapping4.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping5.Member = "Image"
            mapItemAttributeMapping5.Name = "ShopImage"
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3)
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping4)
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping5)
            Me.ListSourceDataAdapter.Mappings.Latitude = "LocationLatitude"
            Me.ListSourceDataAdapter.Mappings.Longitude = "LocationLongitude"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(39, 39)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "ShopImage.png")
            ' 
            ' toolTipController1
            ' 
            Me.toolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.[False]
            Me.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopRight
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.toolTipController1_BeforeShow)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.chartControl1)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 141)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(714, 210, 857, 576)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(601, 339)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(381, 260)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(220, 79)
            Me.gaugeControl1.TabIndex = 5
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 208, 67)
            Me.circularGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent() {Me.arcScaleMarkerComponent1, Me.arcScaleMarkerComponent2})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
            ' 
            ' arcScaleMarkerComponent1
            ' 
            Me.arcScaleMarkerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleMarkerComponent1.Name = "circularGauge1_Marker1"
            Me.arcScaleMarkerComponent1.ZOrder = -100
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleComponent1.AppearanceScale.Width = 3F
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 159F)
            Me.arcScaleComponent1.EndAngle = 0F
            Me.arcScaleComponent1.MajorTickCount = 6
            Me.arcScaleComponent1.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:C0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleComponent1.MajorTickmark.TextOffset = 34F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleComponent1.MinorTickmark.ShowTick = False
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.RadiusX = 101F
            Me.arcScaleComponent1.RadiusY = 101F
            Me.arcScaleComponent1.StartAngle = -180F
            ' 
            ' arcScaleMarkerComponent2
            ' 
            Me.arcScaleMarkerComponent2.ArcScale = Me.arcScaleComponent1
            Me.arcScaleMarkerComponent2.Name = "circularGauge1_Marker2"
            Me.arcScaleMarkerComponent2.ZOrder = -100
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.EndOffset = 8F
            Me.arcScaleNeedleComponent1.Name = "needle"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
            Me.arcScaleNeedleComponent1.StartOffset = -6F
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' arcScaleSpindleCapComponent1
            ' 
            Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleSpindleCapComponent1.Name = "circularGauge10_SpindleCap1"
            Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.Empty
            Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(15F, 15F)
            Me.arcScaleSpindleCapComponent1.ZOrder = -100
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisX.QualitativeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisY.Label.TextPattern = "{V:C0}"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.Location = New System.Drawing.Point(381, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "Name"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "Value"
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesView1.ColorEach = True
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            series1.View = sideBySideBarSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.Size = New System.Drawing.Size(220, 220)
            Me.chartControl1.TabIndex = 4
            chartTitle1.Font = New System.Drawing.Font("Tahoma", 12F)
            chartTitle1.Text = ""
            chartTitle1.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((128)))))), (CInt(((CByte((0)))))))
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(37.68R, -122.419R)
            Me.mapControl1.ScrollArea = New DevExpress.Map.MapBounds(New DevExpress.XtraMap.GeoPoint(37.83R, -122.66R), New DevExpress.XtraMap.GeoPoint(37.58R, -122.21))
            Me.mapControl1.ImageList = Me.imageCollection1
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.ItemsLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MinZoomLevel = 8R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Height = 70
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(379, 339)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 11.1R
            AddHandler Me.mapControl1.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.mapControl1_SelectionChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem1, Me.simpleLabelItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 339)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.chartControl1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(379, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(222, 220)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.gaugeControl1
            Me.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(379, 258)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 0, 2, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(222, 81)
            Me.layoutControlItem3.Text = "No data. Select a shop to view its details."
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(379, 339)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 21F)
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.simpleLabelItem1.CustomizationFormText = "LabelsimpleLabelItem1"
            Me.simpleLabelItem1.Location = New System.Drawing.Point(379, 220)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Size = New System.Drawing.Size(222, 38)
            Me.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.simpleLabelItem1.Text = "Shop Total Sales"
            Me.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(206, 34)
            ' 
            ' SalesDashboard
            ' 
            Me.panelControl1.Controls.Add(Me.layoutControl1)
            Me.Name = "SalesDashboard"
            Me.Size = New System.Drawing.Size(601, 480)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.layoutControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleMarkerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleMarkerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private arcScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent

        Private arcScaleMarkerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleMarkerComponent

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ListSourceDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider
    End Class
End Namespace
