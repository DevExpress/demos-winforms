Namespace DevExpress.XtraMap.Demos

    Partial Class TrafficAndIncidents

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
            Me.TileLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.RouteLayer = New DevExpress.XtraMap.InformationLayer()
            Me.RouteProvider = New DevExpress.XtraMap.AzureRouteDataProvider()
            Me.GeocodeLayer = New DevExpress.XtraMap.InformationLayer()
            Me.GeoCodeProvider = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.SearchLayer = New DevExpress.XtraMap.InformationLayer()
            Me.SearchProvider = New DevExpress.XtraMap.AzureSearchDataProvider()
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.DataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.TrafficIncidentLayer = New DevExpress.XtraMap.InformationLayer()
            Me.TrafficIncidentProvider = New DevExpress.XtraMap.AzureTrafficIncidentDataProvider()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.TravelModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.MaxAlternativedSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.OptimizeWaypointsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.RouteAvoidTypesComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.RouteSectionTypesComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.PropertiesLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.MaxAlternativesControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.OptimizeWaypoints = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.RouteAvoidTypesControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.AvoidTypesControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TravelModeLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.TravelModeControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.RouteSectionTypesControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.RouteSectionTypesControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapControlField = New DevExpress.XtraMap.MapControl()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.TravelModeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.MaxAlternativedSpinEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.OptimizeWaypointsCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RouteAvoidTypesComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RouteSectionTypesComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.PropertiesLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.MaxAlternativesControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.OptimizeWaypoints), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RouteAvoidTypesControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.AvoidTypesControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TravelModeLayoutGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.TravelModeControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RouteSectionTypesControlGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RouteSectionTypesControlItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            Me.sidePanelOptions.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControlField)
            Me.panelControl1.Controls.Add(Me.sidePanelOptions)
            Me.panelControl1.Size = New System.Drawing.Size(773, 571)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Size = New System.Drawing.Size(773, 150)
            Me.TileLayer.DataProvider = Me.AzureMapDataProvider
            Me.TileLayer.Name = "TilesLayer"
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.RouteLayer.DataProvider = Me.RouteProvider
            Me.RouteLayer.EnableHighlighting = False
            Me.RouteLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((140)))))), (CInt(((CByte((210)))))))
            Me.RouteLayer.ItemStyle.StrokeWidth = 4
            Me.RouteLayer.Name = "RouteLayer"
            Me.RouteLayer.SelectedItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((30)))))), (CInt(((CByte((140)))))), (CInt(((CByte((210)))))))
            Me.RouteLayer.SelectedItemStyle.StrokeWidth = 4
            AddHandler Me.RouteLayer.[Error], New DevExpress.XtraMap.MapErrorEventHandler(AddressOf Me.OnRouteLayerError)
            Me.RouteProvider.AzureKey = Nothing
            Me.RouteProvider.CultureName = "en-US"
            AddHandler Me.RouteProvider.RouteCalculated, New DevExpress.XtraMap.AzureRouteCalculatedEventHandler(AddressOf Me.OnRouteCalculated)
            AddHandler Me.RouteProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnRouteLayerItemsGenerating)
            Me.GeocodeLayer.DataProvider = Me.GeoCodeProvider
            Me.GeocodeLayer.Name = "GeocodeLayer"
            Me.GeoCodeProvider.AzureKey = Nothing
            Me.GeoCodeProvider.CultureName = "en-US"
            Me.GeoCodeProvider.MaxVisibleResultCount = 1
            AddHandler Me.GeoCodeProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnGeoCodeAndSearchLayerItemsGenerating)
            Me.SearchLayer.DataProvider = Me.SearchProvider
            Me.SearchLayer.Name = "SearchLayer"
            Me.SearchProvider.AzureKey = Nothing
            Me.SearchProvider.CultureName = "en-US"
            AddHandler Me.SearchProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnGeoCodeAndSearchLayerItemsGenerating)
            Me.ItemsLayer.Data = Me.DataAdapter
            Me.ItemsLayer.Name = "ItemsLayer"
            Me.DataAdapter.Mappings.Latitude = "Latitude"
            Me.DataAdapter.Mappings.Longitude = "Longitude"
            Me.DataAdapter.Mappings.Text = "Text"
            Me.DataAdapter.Mappings.Type = "Type"
            Me.TrafficIncidentLayer.DataProvider = Me.TrafficIncidentProvider
            AddHandler Me.TrafficIncidentLayer.ViewportChanged, New DevExpress.XtraMap.ViewportChangedEventHandler(AddressOf Me.OnInformationLayerViewportChanged)
            Me.TrafficIncidentProvider.AzureKey = Nothing
            Me.TrafficIncidentProvider.CultureName = "en-US"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.Controls.Add(Me.TravelModeRadioGroup)
            Me.layoutControl.Controls.Add(Me.MaxAlternativedSpinEdit)
            Me.layoutControl.Controls.Add(Me.OptimizeWaypointsCheckEdit)
            Me.layoutControl.Controls.Add(Me.RouteAvoidTypesComboBoxEdit)
            Me.layoutControl.Controls.Add(Me.RouteSectionTypesComboBoxEdit)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(893, 193, 806, 536)
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(197, 538)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' TravelModeRadioGroup
            ' 
            Me.TravelModeRadioGroup.EditValue = "Car"
            Me.TravelModeRadioGroup.Location = New System.Drawing.Point(10, 28)
            Me.TravelModeRadioGroup.MenuManager = Me
            Me.TravelModeRadioGroup.Name = "TravelModeRadioGroup"
            Me.TravelModeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.TravelModeRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.TravelModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.TravelModeRadioGroup.Properties.Columns = 1
            Me.TravelModeRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.TravelModeRadioGroup.Size = New System.Drawing.Size(177, 8)
            Me.TravelModeRadioGroup.StyleController = Me.layoutControl
            Me.TravelModeRadioGroup.TabIndex = 4
            AddHandler Me.TravelModeRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnRoutePropertyChanged)
            ' 
            ' MaxAlternativedSpinEdit
            ' 
            Me.MaxAlternativedSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.MaxAlternativedSpinEdit.Location = New System.Drawing.Point(107, 214)
            Me.MaxAlternativedSpinEdit.MenuManager = Me
            Me.MaxAlternativedSpinEdit.Name = "MaxAlternativedSpinEdit"
            Me.MaxAlternativedSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.MaxAlternativedSpinEdit.Properties.IsFloatValue = False
            Me.MaxAlternativedSpinEdit.Properties.MaskSettings.[Set]("mask", "N00")
            Me.MaxAlternativedSpinEdit.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.MaxAlternativedSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.MaxAlternativedSpinEdit.Size = New System.Drawing.Size(76, 20)
            Me.MaxAlternativedSpinEdit.StyleController = Me.layoutControl
            Me.MaxAlternativedSpinEdit.TabIndex = 6
            AddHandler Me.MaxAlternativedSpinEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnRoutePropertyChanged)
            ' 
            ' OptimizeWaypointsCheckEdit
            ' 
            Me.OptimizeWaypointsCheckEdit.Location = New System.Drawing.Point(14, 238)
            Me.OptimizeWaypointsCheckEdit.Margin = New System.Windows.Forms.Padding(0)
            Me.OptimizeWaypointsCheckEdit.MenuManager = Me
            Me.OptimizeWaypointsCheckEdit.Name = "OptimizeWaypointsCheckEdit"
            Me.OptimizeWaypointsCheckEdit.Properties.Caption = "Optimize Waypoints"
            Me.OptimizeWaypointsCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.OptimizeWaypointsCheckEdit.Size = New System.Drawing.Size(169, 20)
            Me.OptimizeWaypointsCheckEdit.StyleController = Me.layoutControl
            Me.OptimizeWaypointsCheckEdit.TabIndex = 7
            AddHandler Me.OptimizeWaypointsCheckEdit.CheckedChanged, New System.EventHandler(AddressOf Me.OnRoutePropertyChanged)
            ' 
            ' RouteAvoidTypesComboBoxEdit
            ' 
            Me.RouteAvoidTypesComboBoxEdit.EditValue = ""
            Me.RouteAvoidTypesComboBoxEdit.Location = New System.Drawing.Point(14, 74)
            Me.RouteAvoidTypesComboBoxEdit.MenuManager = Me
            Me.RouteAvoidTypesComboBoxEdit.Name = "RouteAvoidTypesComboBoxEdit"
            Me.RouteAvoidTypesComboBoxEdit.Properties.AutoHeight = False
            Me.RouteAvoidTypesComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RouteAvoidTypesComboBoxEdit.Size = New System.Drawing.Size(169, 20)
            Me.RouteAvoidTypesComboBoxEdit.StyleController = Me.layoutControl
            Me.RouteAvoidTypesComboBoxEdit.TabIndex = 8
            AddHandler Me.RouteAvoidTypesComboBoxEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnRoutePropertyChanged)
            ' 
            ' RouteSectionTypesComboBoxEdit
            ' 
            Me.RouteSectionTypesComboBoxEdit.EditValue = ""
            Me.RouteSectionTypesComboBoxEdit.Location = New System.Drawing.Point(14, 144)
            Me.RouteSectionTypesComboBoxEdit.MenuManager = Me
            Me.RouteSectionTypesComboBoxEdit.Name = "RouteSectionTypesComboBoxEdit"
            Me.RouteSectionTypesComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RouteSectionTypesComboBoxEdit.Size = New System.Drawing.Size(169, 20)
            Me.RouteSectionTypesComboBoxEdit.StyleController = Me.layoutControl
            Me.RouteSectionTypesComboBoxEdit.TabIndex = 9
            AddHandler Me.RouteSectionTypesComboBoxEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnRoutePropertyChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.PropertiesLayoutGroup, Me.RouteAvoidTypesControlGroup, Me.TravelModeLayoutGroup, Me.RouteSectionTypesControlGroup})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(197, 538)
            Me.Root.TextVisible = False
            ' 
            ' PropertiesLayoutGroup
            ' 
            Me.PropertiesLayoutGroup.CustomizationFormText = "Properties"
            Me.PropertiesLayoutGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.PropertiesLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.MaxAlternativesControlItem, Me.OptimizeWaypoints, Me.emptySpaceItem1})
            Me.PropertiesLayoutGroup.Location = New System.Drawing.Point(0, 178)
            Me.PropertiesLayoutGroup.Name = "PropertiesLayoutGroup"
            Me.PropertiesLayoutGroup.Size = New System.Drawing.Size(197, 360)
            Me.PropertiesLayoutGroup.Text = "Properties"
            ' 
            ' MaxAlternativesControlItem
            ' 
            Me.MaxAlternativesControlItem.Control = Me.MaxAlternativedSpinEdit
            Me.MaxAlternativesControlItem.CustomizationFormText = "Max Alternatives"
            Me.MaxAlternativesControlItem.Location = New System.Drawing.Point(0, 0)
            Me.MaxAlternativesControlItem.Name = "MaxAlternativesControlItem"
            Me.MaxAlternativesControlItem.Size = New System.Drawing.Size(173, 24)
            Me.MaxAlternativesControlItem.Text = "Max Alternatives"
            Me.MaxAlternativesControlItem.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' OptimizeWaypoints
            ' 
            Me.OptimizeWaypoints.Control = Me.OptimizeWaypointsCheckEdit
            Me.OptimizeWaypoints.CustomizationFormText = "OptimizeWaypoints"
            Me.OptimizeWaypoints.Location = New System.Drawing.Point(0, 24)
            Me.OptimizeWaypoints.Name = "OptimizeWaypoints"
            Me.OptimizeWaypoints.Size = New System.Drawing.Size(173, 24)
            Me.OptimizeWaypoints.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(173, 266)
            ' 
            ' RouteAvoidTypesControlGroup
            ' 
            Me.RouteAvoidTypesControlGroup.CustomizationFormText = "Route Avoid Types"
            Me.RouteAvoidTypesControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.RouteAvoidTypesControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.AvoidTypesControlItem})
            Me.RouteAvoidTypesControlGroup.Location = New System.Drawing.Point(0, 38)
            Me.RouteAvoidTypesControlGroup.Name = "RouteAvoidTypesControlGroup"
            Me.RouteAvoidTypesControlGroup.Size = New System.Drawing.Size(197, 70)
            Me.RouteAvoidTypesControlGroup.Text = "Route Avoid Types"
            ' 
            ' AvoidTypesControlItem
            ' 
            Me.AvoidTypesControlItem.Control = Me.RouteAvoidTypesComboBoxEdit
            Me.AvoidTypesControlItem.CustomizationFormText = "Route Avoid Types"
            Me.AvoidTypesControlItem.Location = New System.Drawing.Point(0, 0)
            Me.AvoidTypesControlItem.Name = "AvoidTypesControlItem"
            Me.AvoidTypesControlItem.Size = New System.Drawing.Size(173, 24)
            Me.AvoidTypesControlItem.Text = "Route Avoid Types"
            Me.AvoidTypesControlItem.TextVisible = False
            ' 
            ' TravelModeLayoutGroup
            ' 
            Me.TravelModeLayoutGroup.CustomizationFormText = "Travel Mode"
            Me.TravelModeLayoutGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.TravelModeLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TravelModeControlItem})
            Me.TravelModeLayoutGroup.Location = New System.Drawing.Point(0, 0)
            Me.TravelModeLayoutGroup.Name = "TravelModeLayoutGroup"
            Me.TravelModeLayoutGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 4, 0)
            Me.TravelModeLayoutGroup.Size = New System.Drawing.Size(197, 38)
            Me.TravelModeLayoutGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.TravelModeLayoutGroup.Text = "Travel Mode"
            ' 
            ' TravelModeControlItem
            ' 
            Me.TravelModeControlItem.Control = Me.TravelModeRadioGroup
            Me.TravelModeControlItem.Location = New System.Drawing.Point(0, 0)
            Me.TravelModeControlItem.Name = "TravelModeControlItem"
            Me.TravelModeControlItem.Size = New System.Drawing.Size(181, 12)
            Me.TravelModeControlItem.TextVisible = False
            ' 
            ' RouteSectionTypesControlGroup
            ' 
            Me.RouteSectionTypesControlGroup.CustomizationFormText = "Route Section Types"
            Me.RouteSectionTypesControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.RouteSectionTypesControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.RouteSectionTypesControlItem})
            Me.RouteSectionTypesControlGroup.Location = New System.Drawing.Point(0, 108)
            Me.RouteSectionTypesControlGroup.Name = "RouteSectionTypesControlGroup"
            Me.RouteSectionTypesControlGroup.Size = New System.Drawing.Size(197, 70)
            Me.RouteSectionTypesControlGroup.Text = "Route Section Types"
            ' 
            ' RouteSectionTypesControlItem
            ' 
            Me.RouteSectionTypesControlItem.Control = Me.RouteSectionTypesComboBoxEdit
            Me.RouteSectionTypesControlItem.CustomizationFormText = "Route Section Types"
            Me.RouteSectionTypesControlItem.Location = New System.Drawing.Point(0, 0)
            Me.RouteSectionTypesControlItem.Name = "RouteSectionTypesControlItem"
            Me.RouteSectionTypesControlItem.Size = New System.Drawing.Size(173, 24)
            Me.RouteSectionTypesControlItem.Text = "Route Section Types"
            Me.RouteSectionTypesControlItem.TextVisible = False
            ' 
            ' mapControl
            ' 
            Me.mapControlField.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControlField.CenterPoint = New DevExpress.XtraMap.GeoPoint(38.90507R, -77.01909R)
            Me.mapControlField.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControlField.Layers.Add(Me.TileLayer)
            Me.mapControlField.Layers.Add(Me.TrafficIncidentLayer)
            Me.mapControlField.Layers.Add(Me.SearchLayer)
            Me.mapControlField.Layers.Add(Me.ItemsLayer)
            Me.mapControlField.Layers.Add(Me.GeocodeLayer)
            Me.mapControlField.Layers.Add(Me.RouteLayer)
            Me.mapControlField.Location = New System.Drawing.Point(0, 0)
            Me.mapControlField.MinZoomLevel = 5R
            Me.mapControlField.Name = "mapControl"
            Me.mapControlField.NavigationPanelOptions.Visible = False
            Me.mapControlField.Size = New System.Drawing.Size(575, 571)
            Me.mapControlField.TabIndex = 0
            Me.mapControlField.ToolTipController = Me.toolTipController1
            Me.mapControlField.ZoomLevel = 11R
            AddHandler Me.mapControlField.MapItemClick, New DevExpress.XtraMap.MapItemClickEventHandler(AddressOf Me.OnMapItemClick)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(197, 571)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(197, 571)
            Me.tabPaneOptions.TabIndex = 8
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(197, 538)
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(575, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(198, 571)
            Me.sidePanelOptions.TabIndex = 6
            ' 
            ' TrafficAndIncidents
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TrafficAndIncidents"
            Me.Size = New System.Drawing.Size(773, 739)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.TravelModeRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.MaxAlternativedSpinEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.OptimizeWaypointsCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RouteAvoidTypesComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RouteSectionTypesComboBoxEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.PropertiesLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.MaxAlternativesControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.OptimizeWaypoints), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RouteAvoidTypesControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.AvoidTypesControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TravelModeLayoutGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.TravelModeControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RouteSectionTypesControlGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RouteSectionTypesControlItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControlField), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            Me.sidePanelOptions.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControlField As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private RouteLayer As DevExpress.XtraMap.InformationLayer

        Private GeocodeLayer As DevExpress.XtraMap.InformationLayer

        Private SearchLayer As DevExpress.XtraMap.InformationLayer

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private DataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private TileLayer As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private TrafficIncidentLayer As DevExpress.XtraMap.InformationLayer

        Private RouteProvider As DevExpress.XtraMap.AzureRouteDataProvider

        Private GeoCodeProvider As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private SearchProvider As DevExpress.XtraMap.AzureSearchDataProvider

        Private TrafficIncidentProvider As DevExpress.XtraMap.AzureTrafficIncidentDataProvider

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private TravelModeLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private TravelModeRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private TravelModeControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private PropertiesLayoutGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private MaxAlternativedSpinEdit As DevExpress.XtraEditors.SpinEdit

        Private MaxAlternativesControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private OptimizeWaypointsCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private OptimizeWaypoints As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private AvoidTypesControlItem As DevExpress.XtraLayout.LayoutControlItem

        Private RouteAvoidTypesControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private RouteAvoidTypesComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit

        Private RouteSectionTypesComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit

        Private RouteSectionTypesControlGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private RouteSectionTypesControlItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
