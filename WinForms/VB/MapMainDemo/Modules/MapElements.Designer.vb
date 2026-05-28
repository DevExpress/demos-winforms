Namespace DevExpress.XtraMap.Demos

    Partial Class MapElements

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Me.OnDispose()
            If disposing AndAlso Me.components IsNot Nothing Then Me.components.Dispose()
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim geoMapCoordinateSystem1 As DevExpress.XtraMap.GeoMapCoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping3 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.MapElements))
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.PathsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.PathsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.PlanesLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.PlanesDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.AirportsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.AirportsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.RoutesLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.RoutesStorage = New DevExpress.XtraMap.MapItemStorage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ShowPlanesCheckItem = New DevExpress.XtraBars.BarCheckItem()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.panelControl1.Size = New System.Drawing.Size(601, 193)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ShowPlanesCheckItem})
            Me.ribbonControl1.MaxItemId = 10
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(601, 256)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.TilesLayer.DataProvider = Me.AzureMapDataProvider
            Me.TilesLayer.Name = "TilesLayer"
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.PathsLayer.Data = Me.PathsDataAdapter
            Me.PathsLayer.EnableHighlighting = False
            Me.PathsLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent
            Me.PathsLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.PathsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent
            Me.PathsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.PathsLayer.Name = "PathsLayer"
            Me.PathsLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent
            Me.PathsLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent
            Me.PathsDataAdapter.Mappings.Latitude = "Latitude"
            Me.PathsDataAdapter.Mappings.Longitude = "Longitude"
            Me.PathsDataAdapter.Mappings.Type = "ItemType"
            Me.PlanesLayer.Data = Me.PlanesDataAdapter
            Me.PlanesLayer.Name = "PlanesLayer"
            Me.PlanesDataAdapter.Mappings.Latitude = "Latitude"
            Me.PlanesDataAdapter.Mappings.Longitude = "Longitude"
            Me.PlanesDataAdapter.Mappings.Type = "ItemType"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(32R, 10R)
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.PathsLayer)
            Me.mapControl1.Layers.Add(Me.AirportsLayer)
            Me.mapControl1.Layers.Add(Me.RoutesLayer)
            Me.mapControl1.Layers.Add(Me.PlanesLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MaxZoomLevel = 10R
            Me.mapControl1.MinZoomLevel = 3R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(601, 193)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 3R
            AddHandler Me.mapControl1.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.OnMapSelectionChanged)
            AddHandler Me.mapControl1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnMapControlMouseDown)
            AddHandler Me.mapControl1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnMapControlMouseUp)
            Me.AirportsLayer.Data = Me.AirportsDataAdapter
            Me.AirportsLayer.Name = "Airports"
            Me.AirportsLayer.ToolTipPattern = " {Name} ( {IATA} ) "
            AddHandler Me.AirportsLayer.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.AirportsLayer_DataLoaded)
            mapItemAttributeMapping1.Member = "Name"
            mapItemAttributeMapping1.Name = "Name"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping2.Member = "City"
            mapItemAttributeMapping2.Name = "City"
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping3.Member = "IATA"
            mapItemAttributeMapping3.Name = "IATA"
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3)
            Me.AirportsDataAdapter.Mappings.Type = "ItemType"
            Me.AirportsDataAdapter.Mappings.XCoordinate = "Longitude"
            Me.AirportsDataAdapter.Mappings.YCoordinate = "Latitude"
            Me.RoutesLayer.Data = Me.RoutesStorage
            Me.RoutesLayer.Name = "RoutesLayer"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.ShowPlanesCheckItem)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            ' 
            ' ShowPlanesCheckItem
            ' 
            Me.ShowPlanesCheckItem.BindableChecked = True
            Me.ShowPlanesCheckItem.Caption = "Show Planes"
            Me.ShowPlanesCheckItem.Checked = True
            Me.ShowPlanesCheckItem.Id = 9
            Me.ShowPlanesCheckItem.ImageOptions.SvgImage = CType((resources.GetObject("ShowPlanesCheckItem.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ShowPlanesCheckItem.Name = "ShowPlanesCheckItem"
            AddHandler Me.ShowPlanesCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPlanesVisibilityCheckedChanged)
            ' 
            ' MapElements
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10F, 23F)
            Me.Name = "MapElements"
            Me.Size = New System.Drawing.Size(601, 480)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private PathsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private PathsDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private PlanesLayer As DevExpress.XtraMap.VectorItemsLayer

        Private PlanesDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private AirportsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private AirportsDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private RoutesLayer As DevExpress.XtraMap.VectorItemsLayer

        Private RoutesStorage As DevExpress.XtraMap.MapItemStorage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ShowPlanesCheckItem As DevExpress.XtraBars.BarCheckItem
    End Class
End Namespace
