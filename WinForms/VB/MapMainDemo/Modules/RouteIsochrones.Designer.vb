Namespace DevExpress.XtraMap.Demos

    Partial Class RouteIsochrones

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
            Dim trackBarLabel7 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel8 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel9 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel10 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel11 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel12 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.listSourceDataAdapter1 = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.RouteIsochroneLayer = New DevExpress.XtraMap.InformationLayer()
            Me.RouteIsochroneProvider = New DevExpress.XtraMap.AzureRouteIsochroneDataProvider()
            Me.TileLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.GeocodeLayer = New DevExpress.XtraMap.InformationLayer()
            Me.GeoCodeProvider = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.SearchLayer = New DevExpress.XtraMap.InformationLayer()
            Me.SearchProvider = New DevExpress.XtraMap.AzureSearchDataProvider()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            Me.sidePanelOptions.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.panelControl1.Controls.Add(Me.sidePanelOptions)
            Me.panelControl1.Size = New System.Drawing.Size(601, 312)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Size = New System.Drawing.Size(601, 150)
            ' 
            ' splashScreenManager1
            ' 
            splashScreenManager1.ClosingDelay = 1500
            Me.vectorItemsLayer1.Data = Me.listSourceDataAdapter1
            Me.vectorItemsLayer1.Name = "ItemsLayer"
            Me.listSourceDataAdapter1.Mappings.Latitude = "Latitude"
            Me.listSourceDataAdapter1.Mappings.Longitude = "Longitude"
            Me.listSourceDataAdapter1.Mappings.Text = "Text"
            Me.listSourceDataAdapter1.Mappings.Type = "Type"
            Me.RouteIsochroneLayer.DataProvider = Me.RouteIsochroneProvider
            Me.RouteIsochroneProvider.AzureKey = Nothing
            AddHandler Me.RouteIsochroneProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.IsochroneItemsGenerating)
            Me.TileLayer.DataProvider = Me.AzureMapDataProvider
            Me.TileLayer.Name = "TilesLayer"
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.GeocodeLayer.DataProvider = Me.GeoCodeProvider
            Me.GeocodeLayer.Name = "GeocodeLayer"
            Me.GeoCodeProvider.AzureKey = Nothing
            Me.GeoCodeProvider.CultureName = "en-US"
            Me.GeoCodeProvider.MaxVisibleResultCount = 1
            AddHandler Me.GeoCodeProvider.LocationInformationReceived, New DevExpress.XtraMap.LocationInformationReceivedEventHandler(AddressOf Me.OnGeoCodeLocationInformationReceived)
            Me.SearchLayer.DataProvider = Me.SearchProvider
            Me.SearchLayer.Name = "SearchLayer"
            Me.SearchProvider.AzureKey = Nothing
            Me.SearchProvider.CultureName = "en-US"
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Location = New System.Drawing.Point(11, 28)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Time, minutes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Distance, kilometers"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Distance, miles")})
            Me.radioGroup1.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.radioGroup1.Size = New System.Drawing.Size(175, 48)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 5
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.ParametersChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.trackBarControl1)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(744, 179, 806, 536)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(197, 279)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.EditValue = 15
            Me.trackBarControl1.Location = New System.Drawing.Point(7, 110)
            Me.trackBarControl1.MenuManager = Me
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.trackBarControl1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel7.Label = "5"
            trackBarLabel7.Value = 5
            trackBarLabel8.Label = "10"
            trackBarLabel8.Value = 10
            trackBarLabel9.Label = "15"
            trackBarLabel9.Value = 15
            trackBarLabel10.Label = "20"
            trackBarLabel10.Value = 20
            trackBarLabel11.Label = "25"
            trackBarLabel11.Value = 25
            trackBarLabel12.Label = "30"
            trackBarLabel12.Value = 30
            Me.trackBarControl1.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11, trackBarLabel12})
            Me.trackBarControl1.Properties.Maximum = 30
            Me.trackBarControl1.Properties.Minimum = 5
            Me.trackBarControl1.Properties.ShowLabels = True
            Me.trackBarControl1.Properties.SmallChange = 5
            Me.trackBarControl1.Properties.TickFrequency = 5
            Me.trackBarControl1.Size = New System.Drawing.Size(183, 72)
            Me.trackBarControl1.StyleController = Me.layoutControl1
            Me.trackBarControl1.TabIndex = 6
            Me.trackBarControl1.Value = 15
            AddHandler Me.trackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.ParametersChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(197, 279)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(197, 80)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Isochone Parameter"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.radioGroup1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 52)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlGroup2.Name = "Time, minutes"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 6, 0)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(197, 199)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.trackBarControl1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(187, 76)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 76)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(187, 95)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(42.3589935302734R, -71.0586318969727R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TileLayer)
            Me.mapControl1.Layers.Add(Me.GeocodeLayer)
            Me.mapControl1.Layers.Add(Me.SearchLayer)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Layers.Add(Me.RouteIsochroneLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MinZoomLevel = 5R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(403, 312)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 11R
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(197, 312)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(197, 312)
            Me.tabPaneOptions.TabIndex = 8
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(197, 279)
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(403, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(198, 312)
            Me.sidePanelOptions.TabIndex = 6
            ' 
            ' RouteIsochrones
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "RouteIsochrones"
            Me.Size = New System.Drawing.Size(601, 480)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            Me.sidePanelOptions.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private TileLayer As DevExpress.XtraMap.ImageLayer

        Private RouteIsochroneLayer As DevExpress.XtraMap.InformationLayer

        Private GeocodeLayer As DevExpress.XtraMap.InformationLayer

        Private SearchLayer As DevExpress.XtraMap.InformationLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private RouteIsochroneProvider As DevExpress.XtraMap.AzureRouteIsochroneDataProvider

        Private GeoCodeProvider As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private SearchProvider As DevExpress.XtraMap.AzureSearchDataProvider

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private listSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter

        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
