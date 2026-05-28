Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing

Namespace DevExpress.XtraMap.Demos

    Partial Class Clustering

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
            Dim splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True, GetType(System.Windows.Forms.UserControl))
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapDotSizeMapping1 As DevExpress.XtraMap.MapDotSizeMapping = New DevExpress.XtraMap.MapDotSizeMapping()
            Dim colorListLegend1 As DevExpress.XtraMap.ColorListLegend = New DevExpress.XtraMap.ColorListLegend()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel12 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.Clustering))
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ListSourceDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.barStepInPixels = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
            Me.chkClusteringByAttr = New DevExpress.XtraBars.BarCheckItem()
            Me.chkMarkerClustering = New DevExpress.XtraBars.BarCheckItem()
            Me.chkDistanceBasedClustering = New DevExpress.XtraBars.BarCheckItem()
            Me.chkWithoutClustering = New DevExpress.XtraBars.BarCheckItem()
            Me.chkCustomFactory = New DevExpress.XtraBars.BarCheckItem()
            Me.chkWitoutFactory = New DevExpress.XtraBars.BarCheckItem()
            Me.chkClusteringWitoutAttribute = New DevExpress.XtraBars.BarCheckItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.rpgClusteringMethod = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgCustomClusterRepresentative = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgGroupByAttributeValues = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgAdditionalOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.chkMarkerClustering, Me.chkDistanceBasedClustering, Me.chkWithoutClustering, Me.chkCustomFactory, Me.chkWitoutFactory, Me.chkClusteringByAttr, Me.chkClusteringWitoutAttribute})
            Me.ribbonControl1.Size = New System.Drawing.Size(604, 141)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgClusteringMethod, Me.rpgCustomClusterRepresentative, Me.rpgGroupByAttributeValues, Me.rpgAdditionalOptions})
            ' 
            ' splashScreenManager1
            ' 
            splashScreenManager1.ClosingDelay = 500
            Me.ItemsLayer.Data = Me.ListSourceDataAdapter
            Me.ItemsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White
            Me.ItemsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.Black
            Me.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((194)))))), (CInt(((CByte((18)))))))
            Me.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((51)))))), (CInt(((CByte((117)))))), (CInt(((CByte((11)))))))
            Me.ItemsLayer.ItemStyle.TextColor = System.Drawing.Color.White
            Me.ItemsLayer.ItemStyle.TextGlowColor = System.Drawing.Color.Black
            Me.ItemsLayer.Name = "ItemsLayer"
            Me.ItemsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White
            Me.ItemsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.Black
            mapItemAttributeMapping1.Member = "location"
            mapItemAttributeMapping1.Name = "location"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping2.Member = "genus"
            mapItemAttributeMapping2.Name = "genus"
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.ListSourceDataAdapter.Mappings.Latitude = "lat"
            Me.ListSourceDataAdapter.Mappings.Longitude = "lon"
            Me.ListSourceDataAdapter.Mappings.Type = "type"
            mapDotSizeMapping1.DefaultValue = 7R
            Me.ListSourceDataAdapter.PropertyMappings.Add(mapDotSizeMapping1)
            Me.TilesLayer.DataProvider = Me.AzureMapDataProvider
            Me.TilesLayer.Name = "TilesLayer"
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-37.58R, 143.8R)
            Me.mapControl1.ScrollArea = New DevExpress.Map.MapBounds(New DevExpress.XtraMap.GeoPoint(-37.47R, 143.65R), New DevExpress.XtraMap.GeoPoint(-37.62R, 143.94R))
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.ItemsLayer)
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            colorListLegend1.Header = "Trees density"
            colorListLegend1.Layer = Me.ItemsLayer
            Me.mapControl1.Legends.Add(colorListLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 141)
            Me.mapControl1.MinZoomLevel = 10R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(604, 339)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 12R
            AddHandler Me.mapControl1.MapItemClick, New DevExpress.XtraMap.MapItemClickEventHandler(AddressOf Me.mapControl1_MapItemClick)
            ' 
            ' barStepInPixels
            ' 
            Me.barStepInPixels.Edit = Me.repositoryItemTrackBar1
            Me.barStepInPixels.EditHeight = 40
            Me.barStepInPixels.EditValue = 50
            Me.barStepInPixels.EditWidth = 150
            Me.barStepInPixels.Id = 5
            Me.barStepInPixels.Name = "barStepInPixels"
            ' 
            ' repositoryItemTrackBar1
            ' 
            Me.repositoryItemTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
            Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel10.Label = "10"
            trackBarLabel10.Value = 10
            trackBarLabel11.Label = "80"
            trackBarLabel11.Value = 80
            trackBarLabel12.Label = "150"
            trackBarLabel12.Value = 150
            Me.repositoryItemTrackBar1.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel10, trackBarLabel11, trackBarLabel12})
            Me.repositoryItemTrackBar1.LargeChange = 10
            Me.repositoryItemTrackBar1.Maximum = 150
            Me.repositoryItemTrackBar1.Minimum = 10
            Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
            Me.repositoryItemTrackBar1.ShowLabels = True
            Me.repositoryItemTrackBar1.ShowValueToolTip = True
            Me.repositoryItemTrackBar1.SmallChange = 10
            Me.repositoryItemTrackBar1.TickFrequency = 10
            AddHandler Me.repositoryItemTrackBar1.BeforeShowValueToolTip, New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(AddressOf Me.repositoryItemTrackBar1_BeforeShowValueToolTip)
            AddHandler Me.repositoryItemTrackBar1.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.OnEditValueChanging)
            ' 
            ' chkClusteringByAttr
            ' 
            Me.chkClusteringByAttr.Caption = "Attribute"
            Me.chkClusteringByAttr.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkClusteringByAttr.GroupIndex = 4
            Me.chkClusteringByAttr.Id = 7
            Me.chkClusteringByAttr.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Attribute
            Me.chkClusteringByAttr.Name = "chkClusteringByAttr"
            Me.chkClusteringByAttr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkClusteringByAttr.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkMarkerClustering
            ' 
            Me.chkMarkerClustering.BindableChecked = True
            Me.chkMarkerClustering.Caption = "Marker"
            Me.chkMarkerClustering.Checked = True
            Me.chkMarkerClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkMarkerClustering.GroupIndex = 2
            Me.chkMarkerClustering.Id = 8
            Me.chkMarkerClustering.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Marker
            Me.chkMarkerClustering.Name = "chkMarkerClustering"
            Me.chkMarkerClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkMarkerClustering.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkDistanceBasedClustering
            ' 
            Me.chkDistanceBasedClustering.Caption = "Distance-based"
            Me.chkDistanceBasedClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkDistanceBasedClustering.GroupIndex = 2
            Me.chkDistanceBasedClustering.Id = 9
            Me.chkDistanceBasedClustering.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Distance_based
            Me.chkDistanceBasedClustering.Name = "chkDistanceBasedClustering"
            Me.chkDistanceBasedClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkDistanceBasedClustering.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkWithoutClustering
            ' 
            Me.chkWithoutClustering.Caption = "None"
            Me.chkWithoutClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkWithoutClustering.GroupIndex = 2
            Me.chkWithoutClustering.Id = 10
            Me.chkWithoutClustering.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.None
            Me.chkWithoutClustering.Name = "chkWithoutClustering"
            Me.chkWithoutClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkWithoutClustering.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkCustomFactory
            ' 
            Me.chkCustomFactory.BindableChecked = True
            Me.chkCustomFactory.Caption = "Custom callout"
            Me.chkCustomFactory.Checked = True
            Me.chkCustomFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkCustomFactory.GroupIndex = 3
            Me.chkCustomFactory.Id = 12
            Me.chkCustomFactory.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Custom_callout
            Me.chkCustomFactory.Name = "chkCustomFactory"
            Me.chkCustomFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkCustomFactory.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkWitoutFactory
            ' 
            Me.chkWitoutFactory.Caption = "Default"
            Me.chkWitoutFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkWitoutFactory.GroupIndex = 3
            Me.chkWitoutFactory.Id = 19
            Me.chkWitoutFactory.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.[Default]
            Me.chkWitoutFactory.Name = "chkWitoutFactory"
            Me.chkWitoutFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkWitoutFactory.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' chkClusteringWitoutAttribute
            ' 
            Me.chkClusteringWitoutAttribute.BindableChecked = True
            Me.chkClusteringWitoutAttribute.Caption = "None"
            Me.chkClusteringWitoutAttribute.Checked = True
            Me.chkClusteringWitoutAttribute.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio
            Me.chkClusteringWitoutAttribute.GroupIndex = 4
            Me.chkClusteringWitoutAttribute.Id = 20
            Me.chkClusteringWitoutAttribute.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.None
            Me.chkClusteringWitoutAttribute.Name = "chkClusteringWitoutAttribute"
            Me.chkClusteringWitoutAttribute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.chkClusteringWitoutAttribute.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRibbonItemClick)
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Id = 23
            Me.barStaticItem1.Name = "barStaticItem1"
            ' 
            ' rpgClusteringMethod
            ' 
            Me.rpgClusteringMethod.ItemLinks.Add(Me.chkMarkerClustering)
            Me.rpgClusteringMethod.ItemLinks.Add(Me.chkDistanceBasedClustering)
            Me.rpgClusteringMethod.ItemLinks.Add(Me.chkWithoutClustering)
            Me.rpgClusteringMethod.Name = "rpgClusteringMethod"
            Me.rpgClusteringMethod.Text = "Clustering Method"
            ' 
            ' rpgCustomClusterRepresentative
            ' 
            Me.rpgCustomClusterRepresentative.AllowTextClipping = False
            Me.rpgCustomClusterRepresentative.ItemLinks.Add(Me.chkCustomFactory)
            Me.rpgCustomClusterRepresentative.ItemLinks.Add(Me.chkWitoutFactory)
            Me.rpgCustomClusterRepresentative.Name = "rpgCustomClusterRepresentative"
            Me.rpgCustomClusterRepresentative.Text = "Custom Cluster Representative"
            ' 
            ' rpgGroupByAttributeValues
            ' 
            Me.rpgGroupByAttributeValues.AllowTextClipping = False
            Me.rpgGroupByAttributeValues.ItemLinks.Add(Me.chkClusteringByAttr)
            Me.rpgGroupByAttributeValues.ItemLinks.Add(Me.chkClusteringWitoutAttribute)
            Me.rpgGroupByAttributeValues.Name = "rpgGroupByAttributeValues"
            Me.rpgGroupByAttributeValues.Text = "Group By Attribute Values"
            ' 
            ' rpgAdditionalOptions
            ' 
            Me.rpgAdditionalOptions.ItemLinks.Add(Me.barStaticItem1)
            Me.rpgAdditionalOptions.ItemLinks.Add(Me.barStepInPixels)
            Me.rpgAdditionalOptions.Name = "rpgAdditionalOptions"
            Me.rpgAdditionalOptions.Text = "Step In Pixels"
            ' 
            ' Clustering
            ' 
            Me.AllowDrop = True
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.Name = "Clustering"
            Me.Size = New System.Drawing.Size(604, 480)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private rpgClusteringMethod As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgGroupByAttributeValues As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgAdditionalOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgCustomClusterRepresentative As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barStepInPixels As DevExpress.XtraBars.BarEditItem

        Private repositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar

        Private chkClusteringByAttr As DevExpress.XtraBars.BarCheckItem

        Private chkMarkerClustering As DevExpress.XtraBars.BarCheckItem

        Private chkDistanceBasedClustering As DevExpress.XtraBars.BarCheckItem

        Private chkWithoutClustering As DevExpress.XtraBars.BarCheckItem

        Private chkCustomFactory As DevExpress.XtraBars.BarCheckItem

        Private chkWitoutFactory As DevExpress.XtraBars.BarCheckItem

        Private chkClusteringWitoutAttribute As DevExpress.XtraBars.BarCheckItem

        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ListSourceDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider
    End Class
End Namespace
