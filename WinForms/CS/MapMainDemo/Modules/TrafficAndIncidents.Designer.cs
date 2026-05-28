namespace DevExpress.XtraMap.Demos {
    partial class TrafficAndIncidents {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TileLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.RouteLayer = new DevExpress.XtraMap.InformationLayer();
            this.RouteProvider = new DevExpress.XtraMap.AzureRouteDataProvider();
            this.GeocodeLayer = new DevExpress.XtraMap.InformationLayer();
            this.GeoCodeProvider = new DevExpress.XtraMap.AzureGeocodeDataProvider();
            this.SearchLayer = new DevExpress.XtraMap.InformationLayer();
            this.SearchProvider = new DevExpress.XtraMap.AzureSearchDataProvider();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.DataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.TrafficIncidentLayer = new DevExpress.XtraMap.InformationLayer();
            this.TrafficIncidentProvider = new DevExpress.XtraMap.AzureTrafficIncidentDataProvider();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.TravelModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.MaxAlternativedSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.OptimizeWaypointsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.RouteAvoidTypesComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.RouteSectionTypesComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PropertiesLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.MaxAlternativesControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.OptimizeWaypoints = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.RouteAvoidTypesControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.AvoidTypesControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.TravelModeLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.TravelModeControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.RouteSectionTypesControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.RouteSectionTypesControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAlternativedSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimizeWaypointsCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteAvoidTypesComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAlternativesControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimizeWaypoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteAvoidTypesControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvoidTypesControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            this.sidePanelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl);
            this.panelControl1.Controls.Add(this.sidePanelOptions);
            this.panelControl1.Size = new System.Drawing.Size(773, 571);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(773, 150);
            this.TileLayer.DataProvider = this.AzureMapDataProvider;
            this.TileLayer.Name = "TilesLayer";
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.RouteLayer.DataProvider = this.RouteProvider;
            this.RouteLayer.EnableHighlighting = false;
            this.RouteLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(210)))));
            this.RouteLayer.ItemStyle.StrokeWidth = 4;
            this.RouteLayer.Name = "RouteLayer";
            this.RouteLayer.SelectedItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(210)))));
            this.RouteLayer.SelectedItemStyle.StrokeWidth = 4;
            this.RouteLayer.Error += new DevExpress.XtraMap.MapErrorEventHandler(this.OnRouteLayerError);
            this.RouteProvider.AzureKey = null;
            this.RouteProvider.CultureName = "en-US";
            this.RouteProvider.RouteCalculated += new DevExpress.XtraMap.AzureRouteCalculatedEventHandler(this.OnRouteCalculated);
            this.RouteProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnRouteLayerItemsGenerating);
            this.GeocodeLayer.DataProvider = this.GeoCodeProvider;
            this.GeocodeLayer.Name = "GeocodeLayer";
            this.GeoCodeProvider.AzureKey = null;
            this.GeoCodeProvider.CultureName = "en-US";
            this.GeoCodeProvider.MaxVisibleResultCount = 1;
            this.GeoCodeProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnGeoCodeAndSearchLayerItemsGenerating);
            this.SearchLayer.DataProvider = this.SearchProvider;
            this.SearchLayer.Name = "SearchLayer";
            this.SearchProvider.AzureKey = null;
            this.SearchProvider.CultureName = "en-US";
            this.SearchProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.OnGeoCodeAndSearchLayerItemsGenerating);
            this.ItemsLayer.Data = this.DataAdapter;
            this.ItemsLayer.Name = "ItemsLayer";
            this.DataAdapter.Mappings.Latitude = "Latitude";
            this.DataAdapter.Mappings.Longitude = "Longitude";
            this.DataAdapter.Mappings.Text = "Text";
            this.DataAdapter.Mappings.Type = "Type";
            this.TrafficIncidentLayer.DataProvider = this.TrafficIncidentProvider;
            this.TrafficIncidentLayer.ViewportChanged += new DevExpress.XtraMap.ViewportChangedEventHandler(this.OnInformationLayerViewportChanged);
            this.TrafficIncidentProvider.AzureKey = null;
            this.TrafficIncidentProvider.CultureName = "en-US";
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.TravelModeRadioGroup);
            this.layoutControl.Controls.Add(this.MaxAlternativedSpinEdit);
            this.layoutControl.Controls.Add(this.OptimizeWaypointsCheckEdit);
            this.layoutControl.Controls.Add(this.RouteAvoidTypesComboBoxEdit);
            this.layoutControl.Controls.Add(this.RouteSectionTypesComboBoxEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(893, 193, 806, 536);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(197, 538);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            // 
            // TravelModeRadioGroup
            // 
            this.TravelModeRadioGroup.EditValue = "Car";
            this.TravelModeRadioGroup.Location = new System.Drawing.Point(10, 28);
            this.TravelModeRadioGroup.MenuManager = this;
            this.TravelModeRadioGroup.Name = "TravelModeRadioGroup";
            this.TravelModeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TravelModeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.TravelModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TravelModeRadioGroup.Properties.Columns = 1;
            this.TravelModeRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TravelModeRadioGroup.Size = new System.Drawing.Size(177, 8);
            this.TravelModeRadioGroup.StyleController = this.layoutControl;
            this.TravelModeRadioGroup.TabIndex = 4;
            this.TravelModeRadioGroup.SelectedIndexChanged += new System.EventHandler(this.OnRoutePropertyChanged);
            // 
            // MaxAlternativedSpinEdit
            // 
            this.MaxAlternativedSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MaxAlternativedSpinEdit.Location = new System.Drawing.Point(107, 214);
            this.MaxAlternativedSpinEdit.MenuManager = this;
            this.MaxAlternativedSpinEdit.Name = "MaxAlternativedSpinEdit";
            this.MaxAlternativedSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MaxAlternativedSpinEdit.Properties.IsFloatValue = false;
            this.MaxAlternativedSpinEdit.Properties.MaskSettings.Set("mask", "N00");
            this.MaxAlternativedSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxAlternativedSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.MaxAlternativedSpinEdit.Size = new System.Drawing.Size(76, 20);
            this.MaxAlternativedSpinEdit.StyleController = this.layoutControl;
            this.MaxAlternativedSpinEdit.TabIndex = 6;
            this.MaxAlternativedSpinEdit.EditValueChanged += new System.EventHandler(this.OnRoutePropertyChanged);
            // 
            // OptimizeWaypointsCheckEdit
            // 
            this.OptimizeWaypointsCheckEdit.Location = new System.Drawing.Point(14, 238);
            this.OptimizeWaypointsCheckEdit.Margin = new System.Windows.Forms.Padding(0);
            this.OptimizeWaypointsCheckEdit.MenuManager = this;
            this.OptimizeWaypointsCheckEdit.Name = "OptimizeWaypointsCheckEdit";
            this.OptimizeWaypointsCheckEdit.Properties.Caption = "Optimize Waypoints";
            this.OptimizeWaypointsCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OptimizeWaypointsCheckEdit.Size = new System.Drawing.Size(169, 20);
            this.OptimizeWaypointsCheckEdit.StyleController = this.layoutControl;
            this.OptimizeWaypointsCheckEdit.TabIndex = 7;
            this.OptimizeWaypointsCheckEdit.CheckedChanged += new System.EventHandler(this.OnRoutePropertyChanged);
            // 
            // RouteAvoidTypesComboBoxEdit
            // 
            this.RouteAvoidTypesComboBoxEdit.EditValue = "";
            this.RouteAvoidTypesComboBoxEdit.Location = new System.Drawing.Point(14, 74);
            this.RouteAvoidTypesComboBoxEdit.MenuManager = this;
            this.RouteAvoidTypesComboBoxEdit.Name = "RouteAvoidTypesComboBoxEdit";
            this.RouteAvoidTypesComboBoxEdit.Properties.AutoHeight = false;
            this.RouteAvoidTypesComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RouteAvoidTypesComboBoxEdit.Size = new System.Drawing.Size(169, 20);
            this.RouteAvoidTypesComboBoxEdit.StyleController = this.layoutControl;
            this.RouteAvoidTypesComboBoxEdit.TabIndex = 8;
            this.RouteAvoidTypesComboBoxEdit.EditValueChanged += new System.EventHandler(this.OnRoutePropertyChanged);
            // 
            // RouteSectionTypesComboBoxEdit
            // 
            this.RouteSectionTypesComboBoxEdit.EditValue = "";
            this.RouteSectionTypesComboBoxEdit.Location = new System.Drawing.Point(14, 144);
            this.RouteSectionTypesComboBoxEdit.MenuManager = this;
            this.RouteSectionTypesComboBoxEdit.Name = "RouteSectionTypesComboBoxEdit";
            this.RouteSectionTypesComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RouteSectionTypesComboBoxEdit.Size = new System.Drawing.Size(169, 20);
            this.RouteSectionTypesComboBoxEdit.StyleController = this.layoutControl;
            this.RouteSectionTypesComboBoxEdit.TabIndex = 9;
            this.RouteSectionTypesComboBoxEdit.EditValueChanged += new System.EventHandler(this.OnRoutePropertyChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PropertiesLayoutGroup,
            this.RouteAvoidTypesControlGroup,
            this.TravelModeLayoutGroup,
            this.RouteSectionTypesControlGroup});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(197, 538);
            this.Root.TextVisible = false;
            // 
            // PropertiesLayoutGroup
            // 
            this.PropertiesLayoutGroup.CustomizationFormText = "Properties";
            this.PropertiesLayoutGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.PropertiesLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.MaxAlternativesControlItem,
            this.OptimizeWaypoints,
            this.emptySpaceItem1});
            this.PropertiesLayoutGroup.Location = new System.Drawing.Point(0, 178);
            this.PropertiesLayoutGroup.Name = "PropertiesLayoutGroup";
            this.PropertiesLayoutGroup.Size = new System.Drawing.Size(197, 360);
            this.PropertiesLayoutGroup.Text = "Properties";
            // 
            // MaxAlternativesControlItem
            // 
            this.MaxAlternativesControlItem.Control = this.MaxAlternativedSpinEdit;
            this.MaxAlternativesControlItem.CustomizationFormText = "Max Alternatives";
            this.MaxAlternativesControlItem.Location = new System.Drawing.Point(0, 0);
            this.MaxAlternativesControlItem.Name = "MaxAlternativesControlItem";
            this.MaxAlternativesControlItem.Size = new System.Drawing.Size(173, 24);
            this.MaxAlternativesControlItem.Text = "Max Alternatives";
            this.MaxAlternativesControlItem.TextSize = new System.Drawing.Size(81, 13);
            // 
            // OptimizeWaypoints
            // 
            this.OptimizeWaypoints.Control = this.OptimizeWaypointsCheckEdit;
            this.OptimizeWaypoints.CustomizationFormText = "OptimizeWaypoints";
            this.OptimizeWaypoints.Location = new System.Drawing.Point(0, 24);
            this.OptimizeWaypoints.Name = "OptimizeWaypoints";
            this.OptimizeWaypoints.Size = new System.Drawing.Size(173, 24);
            this.OptimizeWaypoints.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(173, 266);
            // 
            // RouteAvoidTypesControlGroup
            // 
            this.RouteAvoidTypesControlGroup.CustomizationFormText = "Route Avoid Types";
            this.RouteAvoidTypesControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.RouteAvoidTypesControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.AvoidTypesControlItem});
            this.RouteAvoidTypesControlGroup.Location = new System.Drawing.Point(0, 38);
            this.RouteAvoidTypesControlGroup.Name = "RouteAvoidTypesControlGroup";
            this.RouteAvoidTypesControlGroup.Size = new System.Drawing.Size(197, 70);
            this.RouteAvoidTypesControlGroup.Text = "Route Avoid Types";
            // 
            // AvoidTypesControlItem
            // 
            this.AvoidTypesControlItem.Control = this.RouteAvoidTypesComboBoxEdit;
            this.AvoidTypesControlItem.CustomizationFormText = "Route Avoid Types";
            this.AvoidTypesControlItem.Location = new System.Drawing.Point(0, 0);
            this.AvoidTypesControlItem.Name = "AvoidTypesControlItem";
            this.AvoidTypesControlItem.Size = new System.Drawing.Size(173, 24);
            this.AvoidTypesControlItem.Text = "Route Avoid Types";
            this.AvoidTypesControlItem.TextVisible = false;
            // 
            // TravelModeLayoutGroup
            // 
            this.TravelModeLayoutGroup.CustomizationFormText = "Travel Mode";
            this.TravelModeLayoutGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.TravelModeLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TravelModeControlItem});
            this.TravelModeLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.TravelModeLayoutGroup.Name = "TravelModeLayoutGroup";
            this.TravelModeLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 4, 0);
            this.TravelModeLayoutGroup.Size = new System.Drawing.Size(197, 38);
            this.TravelModeLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.TravelModeLayoutGroup.Text = "Travel Mode";
            // 
            // TravelModeControlItem
            // 
            this.TravelModeControlItem.Control = this.TravelModeRadioGroup;
            this.TravelModeControlItem.Location = new System.Drawing.Point(0, 0);
            this.TravelModeControlItem.Name = "TravelModeControlItem";
            this.TravelModeControlItem.Size = new System.Drawing.Size(181, 12);
            this.TravelModeControlItem.TextVisible = false;
            // 
            // RouteSectionTypesControlGroup
            // 
            this.RouteSectionTypesControlGroup.CustomizationFormText = "Route Section Types";
            this.RouteSectionTypesControlGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.RouteSectionTypesControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.RouteSectionTypesControlItem});
            this.RouteSectionTypesControlGroup.Location = new System.Drawing.Point(0, 108);
            this.RouteSectionTypesControlGroup.Name = "RouteSectionTypesControlGroup";
            this.RouteSectionTypesControlGroup.Size = new System.Drawing.Size(197, 70);
            this.RouteSectionTypesControlGroup.Text = "Route Section Types";
            // 
            // RouteSectionTypesControlItem
            // 
            this.RouteSectionTypesControlItem.Control = this.RouteSectionTypesComboBoxEdit;
            this.RouteSectionTypesControlItem.CustomizationFormText = "Route Section Types";
            this.RouteSectionTypesControlItem.Location = new System.Drawing.Point(0, 0);
            this.RouteSectionTypesControlItem.Name = "RouteSectionTypesControlItem";
            this.RouteSectionTypesControlItem.Size = new System.Drawing.Size(173, 24);
            this.RouteSectionTypesControlItem.Text = "Route Section Types";
            this.RouteSectionTypesControlItem.TextVisible = false;
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(38.90507D, -77.01909D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.TileLayer);
            this.mapControl.Layers.Add(this.TrafficIncidentLayer);
            this.mapControl.Layers.Add(this.SearchLayer);
            this.mapControl.Layers.Add(this.ItemsLayer);
            this.mapControl.Layers.Add(this.GeocodeLayer);
            this.mapControl.Layers.Add(this.RouteLayer);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.MinZoomLevel = 5D;
            this.mapControl.Name = "mapControl";
            this.mapControl.NavigationPanelOptions.Visible = false;
            this.mapControl.Size = new System.Drawing.Size(575, 571);
            this.mapControl.TabIndex = 0;
            this.mapControl.ToolTipController = this.toolTipController1;
            this.mapControl.ZoomLevel = 11D;
            this.mapControl.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.OnMapItemClick);
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneOptions.Location = new System.Drawing.Point(1, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(197, 571);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(197, 571);
            this.tabPaneOptions.TabIndex = 8;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(197, 538);
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(575, 0);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Size = new System.Drawing.Size(198, 571);
            this.sidePanelOptions.TabIndex = 6;
            // 
            // TrafficAndIncidents
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TrafficAndIncidents";
            this.Size = new System.Drawing.Size(773, 739);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAlternativedSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimizeWaypointsCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteAvoidTypesComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAlternativesControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimizeWaypoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteAvoidTypesControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvoidTypesControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelModeControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteSectionTypesControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            this.sidePanelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MapControl mapControl;
        private Utils.ToolTipController toolTipController1;
        private InformationLayer RouteLayer;
        private InformationLayer GeocodeLayer;
        private InformationLayer SearchLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter DataAdapter;
        private ImageLayer TileLayer;
        private AzureMapDataProvider AzureMapDataProvider;
        private InformationLayer TrafficIncidentLayer;
        private AzureRouteDataProvider RouteProvider;
        private AzureGeocodeDataProvider GeoCodeProvider;
        private AzureSearchDataProvider SearchProvider;
        private AzureTrafficIncidentDataProvider TrafficIncidentProvider;

        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;

        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup TravelModeLayoutGroup;
        private XtraEditors.RadioGroup TravelModeRadioGroup;
        private XtraLayout.LayoutControlItem TravelModeControlItem;
        private XtraLayout.LayoutControlGroup PropertiesLayoutGroup;
        private XtraEditors.SpinEdit MaxAlternativedSpinEdit;
        private XtraLayout.LayoutControlItem MaxAlternativesControlItem;
        private XtraEditors.CheckEdit OptimizeWaypointsCheckEdit;
        private XtraLayout.LayoutControlItem OptimizeWaypoints;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem AvoidTypesControlItem;
        private XtraLayout.LayoutControlGroup RouteAvoidTypesControlGroup;
        private XtraEditors.CheckedComboBoxEdit RouteAvoidTypesComboBoxEdit;
        private XtraEditors.CheckedComboBoxEdit RouteSectionTypesComboBoxEdit;
        private XtraLayout.LayoutControlGroup RouteSectionTypesControlGroup;
        private XtraLayout.LayoutControlItem RouteSectionTypesControlItem;
    }
}
