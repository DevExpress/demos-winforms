Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

    Partial Class PieCharts

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
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As DevExpress.XtraMap.ArgumentItemKeyProvider = New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim colorizerKeyItem1 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem2 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem3 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem4 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem5 As DevExpress.XtraMap.ColorizerKeyItem = New DevExpress.XtraMap.ColorizerKeyItem()
            Dim measureRules1 As DevExpress.XtraMap.MeasureRules = New DevExpress.XtraMap.MeasureRules()
            Dim linearRangeDistribution1 As DevExpress.XtraMap.LinearRangeDistribution = New DevExpress.XtraMap.LinearRangeDistribution()
            Dim chartItemValueProvider1 As DevExpress.XtraMap.ChartItemValueProvider = New DevExpress.XtraMap.ChartItemValueProvider()
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel4 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel5 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel6 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel7 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel8 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel9 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim colorListLegend1 As DevExpress.XtraMap.ColorListLegend = New DevExpress.XtraMap.ColorListLegend()
            Dim sizeLegend1 As DevExpress.XtraMap.SizeLegend = New DevExpress.XtraMap.SizeLegend()
            Dim mapCallout1 As DevExpress.XtraMap.MapCallout = New DevExpress.XtraMap.MapCallout()
            Me.pieChartLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.pieChartDataAdapter = New DevExpress.XtraMap.PieChartDataAdapter()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControlOptions = New DevExpress.XtraLayout.LayoutControl()
            Me.pieSizeRangeTrackBar = New DevExpress.XtraEditors.RangeTrackBarControl()
            Me.pieDataRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.legendTypeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.pieDataLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.pieDataLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pieSizeLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.pieSizeLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.legendTypeLayoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.legendTypeLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.legendTypeEmptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.mapControlField = New DevExpress.XtraMap.MapControl()
            Me.shapefileLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.tooltipCalloutLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.tooptipMapItemStorage = New DevExpress.XtraMap.MapItemStorage()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControlOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControlOptions.SuspendLayout()
            CType((Me.pieSizeRangeTrackBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieSizeRangeTrackBar.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieDataRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.legendTypeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieDataLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieDataLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieSizeLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pieSizeLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.legendTypeLayoutControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.legendTypeLayoutControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.legendTypeEmptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.MaxItemId = 10
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(938, 150)
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((93)))))), (CInt(((CByte((106))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((65)))))), (CInt(((CByte((124)))))), (CInt(((CByte((217))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((221)))))), (CInt(((CByte((116))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((103)))))), (CInt(((CByte((191)))))), (CInt(((CByte((88))))))))
            keyColorColorizer1.Colors.Add(System.Drawing.Color.FromArgb((CInt(((CByte((140)))))), (CInt(((CByte((104)))))), (CInt(((CByte((195))))))))
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            colorizerKeyItem1.Key = "Gases"
            colorizerKeyItem1.Name = "Gases"
            colorizerKeyItem2.Key = "Nuclear"
            colorizerKeyItem2.Name = "Nuclear"
            colorizerKeyItem3.Key = "Petroleum Products"
            colorizerKeyItem3.Name = "Petroleum Products"
            colorizerKeyItem4.Key = "Renewables"
            colorizerKeyItem4.Name = "Renewables"
            colorizerKeyItem5.Key = "Solid Fuels"
            colorizerKeyItem5.Name = "Solid Fuels"
            keyColorColorizer1.Keys.Add(colorizerKeyItem1)
            keyColorColorizer1.Keys.Add(colorizerKeyItem2)
            keyColorColorizer1.Keys.Add(colorizerKeyItem3)
            keyColorColorizer1.Keys.Add(colorizerKeyItem4)
            keyColorColorizer1.Keys.Add(colorizerKeyItem5)
            Me.pieChartLayer.Colorizer = keyColorColorizer1
            Me.pieChartLayer.Data = Me.pieChartDataAdapter
            Me.pieChartDataAdapter.Mappings.Latitude = "Location.Latitude"
            Me.pieChartDataAdapter.Mappings.Longitude = "Location.Longitude"
            Me.pieChartDataAdapter.Mappings.PieSegment = "EnergyType"
            Me.pieChartDataAdapter.Mappings.Value = "Production"
            measureRules1.ApproximateValues = True
            measureRules1.RangeDistribution = linearRangeDistribution1
            measureRules1.RangeStops.Add(1R)
            measureRules1.RangeStops.Add(10R)
            measureRules1.RangeStops.Add(25R)
            measureRules1.RangeStops.Add(50R)
            measureRules1.RangeStops.Add(100R)
            measureRules1.RangeStops.Add(150R)
            measureRules1.ValueProvider = chartItemValueProvider1
            Me.pieChartDataAdapter.MeasureRules = measureRules1
            Me.pieChartDataAdapter.PieItemDataMember = "CountryName"
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(740, 150)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(198, 518)
            Me.sidePanelOptions.TabIndex = 8
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(197, 518)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(197, 518)
            Me.tabPaneOptions.TabIndex = 8
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControlOptions)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(197, 485)
            ' 
            ' layoutControlOptions
            ' 
            Me.layoutControlOptions.Controls.Add(Me.pieSizeRangeTrackBar)
            Me.layoutControlOptions.Controls.Add(Me.pieDataRadioGroup)
            Me.layoutControlOptions.Controls.Add(Me.legendTypeRadioGroup)
            Me.layoutControlOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControlOptions.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlOptions.Name = "layoutControlOptions"
            Me.layoutControlOptions.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(744, 179, 806, 536)
            Me.layoutControlOptions.Root = Me.root
            Me.layoutControlOptions.Size = New System.Drawing.Size(197, 444)
            Me.layoutControlOptions.TabIndex = 2
            Me.layoutControlOptions.Text = "layoutControl1"
            ' 
            ' pieSizeRangeTrackBar
            ' 
            Me.pieSizeRangeTrackBar.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(15, 50)
            Me.pieSizeRangeTrackBar.Location = New System.Drawing.Point(10, 116)
            Me.pieSizeRangeTrackBar.MenuManager = Me
            Me.pieSizeRangeTrackBar.Name = "pieSizeRangeTrackBar"
            Me.pieSizeRangeTrackBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pieSizeRangeTrackBar.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.pieSizeRangeTrackBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "10"
            trackBarLabel1.Value = 10
            trackBarLabel2.Label = "15"
            trackBarLabel2.Value = 15
            trackBarLabel3.Label = "20"
            trackBarLabel3.Value = 20
            trackBarLabel4.Label = "25"
            trackBarLabel4.Value = 25
            trackBarLabel5.Label = "30"
            trackBarLabel5.Value = 30
            trackBarLabel6.Label = "35"
            trackBarLabel6.Value = 35
            trackBarLabel7.Label = "40"
            trackBarLabel7.Value = 40
            trackBarLabel8.Label = "45"
            trackBarLabel8.Value = 45
            trackBarLabel9.Label = "50"
            trackBarLabel9.Value = 50
            trackBarLabel10.Label = "55"
            trackBarLabel10.Value = 55
            trackBarLabel11.Label = "60"
            trackBarLabel11.Value = 60
            Me.pieSizeRangeTrackBar.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11})
            Me.pieSizeRangeTrackBar.Properties.Maximum = 60
            Me.pieSizeRangeTrackBar.Properties.Minimum = 10
            Me.pieSizeRangeTrackBar.Properties.ShowLabels = True
            Me.pieSizeRangeTrackBar.Properties.TickFrequency = 5
            AddHandler Me.pieSizeRangeTrackBar.Properties.ValueChanged, New System.EventHandler(AddressOf Me.PieSizeRangeTrackBarValueChanged)
            Me.pieSizeRangeTrackBar.Size = New System.Drawing.Size(177, 72)
            Me.pieSizeRangeTrackBar.StyleController = Me.layoutControlOptions
            Me.pieSizeRangeTrackBar.TabIndex = 8
            Me.pieSizeRangeTrackBar.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(15, 50)
            ' 
            ' pieDataRadioGroup
            ' 
            Me.pieDataRadioGroup.AutoSizeInLayoutControl = True
            Me.pieDataRadioGroup.Location = New System.Drawing.Point(11, 28)
            Me.pieDataRadioGroup.MenuManager = Me
            Me.pieDataRadioGroup.Name = "pieDataRadioGroup"
            Me.pieDataRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.pieDataRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.pieDataRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pieDataRadioGroup.Properties.Columns = 1
            Me.pieDataRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.pieDataRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Production"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Import")})
            Me.pieDataRadioGroup.Size = New System.Drawing.Size(175, 56)
            Me.pieDataRadioGroup.StyleController = Me.layoutControlOptions
            Me.pieDataRadioGroup.TabIndex = 6
            AddHandler Me.pieDataRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.PieDataRadioGroupSelectedIndexChanged)
            ' 
            ' legendTypeRadioGroup
            ' 
            Me.legendTypeRadioGroup.AutoSizeInLayoutControl = True
            Me.legendTypeRadioGroup.Location = New System.Drawing.Point(11, 218)
            Me.legendTypeRadioGroup.Name = "legendTypeRadioGroup"
            Me.legendTypeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.legendTypeRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.legendTypeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.legendTypeRadioGroup.Properties.Columns = 1
            Me.legendTypeRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.legendTypeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Inline"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Nested")})
            Me.legendTypeRadioGroup.Size = New System.Drawing.Size(175, 56)
            Me.legendTypeRadioGroup.StyleController = Me.layoutControlOptions
            Me.legendTypeRadioGroup.TabIndex = 6
            AddHandler Me.legendTypeRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.LegendTypeRadioGroupSelectedIndexChanged)
            ' 
            ' root
            ' 
            Me.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.root.GroupBordersVisible = False
            Me.root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.pieDataLayoutControlGroup, Me.pieSizeLayoutControlGroup, Me.legendTypeLayoutControlGroup})
            Me.root.Name = "Root"
            Me.root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.root.Size = New System.Drawing.Size(197, 444)
            Me.root.TextVisible = False
            ' 
            ' pieDataLayoutControlGroup
            ' 
            Me.pieDataLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.pieDataLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.pieDataLayoutControlItem})
            Me.pieDataLayoutControlGroup.Location = New System.Drawing.Point(0, 0)
            Me.pieDataLayoutControlGroup.Name = "pieDataLayoutControlGroup"
            Me.pieDataLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.pieDataLayoutControlGroup.Size = New System.Drawing.Size(197, 88)
            Me.pieDataLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.pieDataLayoutControlGroup.Text = "Pie Data"
            ' 
            ' pieDataLayoutControlItem
            ' 
            Me.pieDataLayoutControlItem.Control = Me.pieDataRadioGroup
            Me.pieDataLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.pieDataLayoutControlItem.Name = "pieDataLayoutControlItem"
            Me.pieDataLayoutControlItem.Size = New System.Drawing.Size(179, 60)
            Me.pieDataLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.pieDataLayoutControlItem.TextVisible = False
            ' 
            ' pieSizeLayoutControlGroup
            ' 
            Me.pieSizeLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.pieSizeLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.pieSizeLayoutControlItem})
            Me.pieSizeLayoutControlGroup.Location = New System.Drawing.Point(0, 88)
            Me.pieSizeLayoutControlGroup.Name = "pieSizeLayoutControlGroup"
            Me.pieSizeLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 4, 0)
            Me.pieSizeLayoutControlGroup.Size = New System.Drawing.Size(197, 102)
            Me.pieSizeLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.pieSizeLayoutControlGroup.Text = "Pie Size"
            ' 
            ' pieSizeLayoutControlItem
            ' 
            Me.pieSizeLayoutControlItem.Control = Me.pieSizeRangeTrackBar
            Me.pieSizeLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.pieSizeLayoutControlItem.Name = "pieSizeLayoutControlItem"
            Me.pieSizeLayoutControlItem.Size = New System.Drawing.Size(181, 76)
            Me.pieSizeLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.pieSizeLayoutControlItem.TextVisible = False
            ' 
            ' legendTypeLayoutControlGroup
            ' 
            Me.legendTypeLayoutControlGroup.CustomizationFormText = "Size Legend Type"
            Me.legendTypeLayoutControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.legendTypeLayoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.legendTypeLayoutControlItem, Me.legendTypeEmptySpaceItem})
            Me.legendTypeLayoutControlGroup.Location = New System.Drawing.Point(0, 190)
            Me.legendTypeLayoutControlGroup.Name = "legendTypeLayoutControlGroup"
            Me.legendTypeLayoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.legendTypeLayoutControlGroup.Size = New System.Drawing.Size(197, 254)
            Me.legendTypeLayoutControlGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.legendTypeLayoutControlGroup.Text = "Size Legend Type"
            ' 
            ' legendTypeLayoutControlItem
            ' 
            Me.legendTypeLayoutControlItem.Control = Me.legendTypeRadioGroup
            Me.legendTypeLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.legendTypeLayoutControlItem.CustomizationFormText = "layoutControlItem1"
            Me.legendTypeLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.legendTypeLayoutControlItem.Name = "legendTypeLayoutControlItem"
            Me.legendTypeLayoutControlItem.Size = New System.Drawing.Size(179, 60)
            Me.legendTypeLayoutControlItem.Text = "layoutControlItem1"
            Me.legendTypeLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.legendTypeLayoutControlItem.TextVisible = False
            ' 
            ' legendTypeEmptySpaceItem
            ' 
            Me.legendTypeEmptySpaceItem.AllowHotTrack = False
            Me.legendTypeEmptySpaceItem.Location = New System.Drawing.Point(0, 60)
            Me.legendTypeEmptySpaceItem.Name = "legendTypeEmptySpaceItem"
            Me.legendTypeEmptySpaceItem.Size = New System.Drawing.Size(179, 166)
            Me.legendTypeEmptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' mapControl
            ' 
            Me.mapControlField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.mapControlField.CenterPoint = New DevExpress.XtraMap.GeoPoint(56R, 17R)
            Me.mapControlField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControlField.Layers.Add(Me.shapefileLayer)
            Me.mapControlField.Layers.Add(Me.pieChartLayer)
            Me.mapControlField.Layers.Add(Me.tooltipCalloutLayer)
            colorListLegend1.Header = "EnergyType"
            colorListLegend1.Layer = Me.pieChartLayer
            sizeLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.BottomRight
            sizeLegend1.Header = ""
            sizeLegend1.Layer = Me.pieChartLayer
            sizeLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
            Me.mapControlField.Legends.Add(colorListLegend1)
            Me.mapControlField.Legends.Add(sizeLegend1)
            Me.mapControlField.Location = New System.Drawing.Point(0, 150)
            Me.mapControlField.MaxZoomLevel = 5R
            Me.mapControlField.MinZoomLevel = 3.5R
            Me.mapControlField.Name = "mapControl"
            Me.mapControlField.Size = New System.Drawing.Size(740, 518)
            Me.mapControlField.TabIndex = 9
            Me.mapControlField.ZoomLevel = 3.8R
            AddHandler Me.mapControlField.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.MapControlSelectionChanged)
            Me.shapefileLayer.Data = Me.shapefileDataAdapter
            Me.shapefileLayer.EnableHighlighting = False
            Me.shapefileLayer.EnableSelection = False
            Me.shapefileLayer.MaxZoomLevel = 5
            Me.shapefileLayer.MinZoomLevel = 3
            Me.shapefileLayer.Name = "shapefileLayer"
            Me.tooltipCalloutLayer.Data = Me.tooptipMapItemStorage
            mapCallout1.AllowHtmlText = True
            mapCallout1.UseAnimation = False
            Me.tooptipMapItemStorage.Items.Add(mapCallout1)
            ' 
            ' PieCharts
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mapControlField)
            Me.Controls.Add(Me.sidePanelOptions)
            Me.Name = "PieCharts"
            Me.Size = New System.Drawing.Size(938, 668)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.mapControlField, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControlOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControlOptions.ResumeLayout(False)
            CType((Me.pieSizeRangeTrackBar.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieSizeRangeTrackBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieDataRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.legendTypeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieDataLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieDataLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieSizeLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieSizeLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.legendTypeLayoutControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.legendTypeLayoutControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.legendTypeEmptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlOptions As DevExpress.XtraLayout.LayoutControl

        Private root As DevExpress.XtraLayout.LayoutControlGroup

        Private pieDataLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private pieSizeLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private legendTypeLayoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private pieDataLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private pieSizeLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private legendTypeLayoutControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private pieDataRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private pieSizeRangeTrackBar As DevExpress.XtraEditors.RangeTrackBarControl

        Private legendTypeRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private legendTypeEmptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private mapControlField As DevExpress.XtraMap.MapControl

        Private shapefileLayer As DevExpress.XtraMap.VectorItemsLayer

        Private shapefileDataAdapter As DevExpress.XtraMap.ShapefileDataAdapter

        Private pieChartLayer As DevExpress.XtraMap.VectorItemsLayer

        Private pieChartDataAdapter As DevExpress.XtraMap.PieChartDataAdapter

        Private tooltipCalloutLayer As DevExpress.XtraMap.VectorItemsLayer

        Private tooptipMapItemStorage As DevExpress.XtraMap.MapItemStorage
    End Class
End Namespace
