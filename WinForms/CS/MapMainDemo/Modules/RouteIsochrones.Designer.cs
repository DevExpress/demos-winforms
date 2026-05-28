namespace DevExpress.XtraMap.Demos {
    partial class RouteIsochrones {
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel12 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.RouteIsochroneLayer = new DevExpress.XtraMap.InformationLayer();
            this.RouteIsochroneProvider = new DevExpress.XtraMap.AzureRouteIsochroneDataProvider();
            this.TileLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.GeocodeLayer = new DevExpress.XtraMap.InformationLayer();
            this.GeoCodeProvider = new DevExpress.XtraMap.AzureGeocodeDataProvider();
            this.SearchLayer = new DevExpress.XtraMap.InformationLayer();
            this.SearchProvider = new DevExpress.XtraMap.AzureSearchDataProvider();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            this.sidePanelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl1);
            this.panelControl1.Controls.Add(this.sidePanelOptions);
            this.panelControl1.Size = new System.Drawing.Size(601, 312);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(601, 150);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 1500;
            this.vectorItemsLayer1.Data = this.listSourceDataAdapter1;
            this.vectorItemsLayer1.Name = "ItemsLayer";
            this.listSourceDataAdapter1.Mappings.Latitude = "Latitude";
            this.listSourceDataAdapter1.Mappings.Longitude = "Longitude";
            this.listSourceDataAdapter1.Mappings.Text = "Text";
            this.listSourceDataAdapter1.Mappings.Type = "Type";
            this.RouteIsochroneLayer.DataProvider = this.RouteIsochroneProvider;
            this.RouteIsochroneProvider.AzureKey = null;
            this.RouteIsochroneProvider.LayerItemsGenerating += new DevExpress.XtraMap.LayerItemsGeneratingEventHandler(this.IsochroneItemsGenerating);
            this.TileLayer.DataProvider = this.AzureMapDataProvider;
            this.TileLayer.Name = "TilesLayer";
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.GeocodeLayer.DataProvider = this.GeoCodeProvider;
            this.GeocodeLayer.Name = "GeocodeLayer";
            this.GeoCodeProvider.AzureKey = null;
            this.GeoCodeProvider.CultureName = "en-US";
            this.GeoCodeProvider.MaxVisibleResultCount = 1;
            this.GeoCodeProvider.LocationInformationReceived += new DevExpress.XtraMap.LocationInformationReceivedEventHandler(this.OnGeoCodeLocationInformationReceived);
            this.SearchLayer.DataProvider = this.SearchProvider;
            this.SearchLayer.Name = "SearchLayer";
            this.SearchProvider.AzureKey = null;
            this.SearchProvider.CultureName = "en-US";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(11, 28);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Time, minutes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Distance, kilometers"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Distance, miles")});
            this.radioGroup1.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.radioGroup1.Size = new System.Drawing.Size(175, 48);
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.TabIndex = 5;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.trackBarControl1);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(744, 179, 806, 536);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(197, 279);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 15;
            this.trackBarControl1.Location = new System.Drawing.Point(7, 110);
            this.trackBarControl1.MenuManager = this;
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.trackBarControl1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel7.Label = "5";
            trackBarLabel7.Value = 5;
            trackBarLabel8.Label = "10";
            trackBarLabel8.Value = 10;
            trackBarLabel9.Label = "15";
            trackBarLabel9.Value = 15;
            trackBarLabel10.Label = "20";
            trackBarLabel10.Value = 20;
            trackBarLabel11.Label = "25";
            trackBarLabel11.Value = 25;
            trackBarLabel12.Label = "30";
            trackBarLabel12.Value = 30;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel7,
            trackBarLabel8,
            trackBarLabel9,
            trackBarLabel10,
            trackBarLabel11,
            trackBarLabel12});
            this.trackBarControl1.Properties.Maximum = 30;
            this.trackBarControl1.Properties.Minimum = 5;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Properties.SmallChange = 5;
            this.trackBarControl1.Properties.TickFrequency = 5;
            this.trackBarControl1.Size = new System.Drawing.Size(183, 72);
            this.trackBarControl1.StyleController = this.layoutControl1;
            this.trackBarControl1.TabIndex = 6;
            this.trackBarControl1.Value = 15;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.ParametersChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(197, 279);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(197, 80);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Isochone Parameter";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroup1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 52);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 80);
            this.layoutControlGroup2.Name = "Time, minutes";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 6, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(197, 199);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trackBarControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(187, 76);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 76);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(187, 95);
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(42.3589935302734D, -71.0586318969727D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TileLayer);
            this.mapControl1.Layers.Add(this.GeocodeLayer);
            this.mapControl1.Layers.Add(this.SearchLayer);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Layers.Add(this.RouteIsochroneLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MinZoomLevel = 5D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(403, 312);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 11D;
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPaneOptions.Location = new System.Drawing.Point(1, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(197, 312);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(197, 312);
            this.tabPaneOptions.TabIndex = 8;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(197, 279);
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(403, 0);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Size = new System.Drawing.Size(198, 312);
            this.sidePanelOptions.TabIndex = 6;
            // 
            // RouteIsochrones
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RouteIsochrones";
            this.Size = new System.Drawing.Size(601, 480);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            this.sidePanelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MapControl mapControl1;
        private ImageLayer TileLayer;
        private InformationLayer RouteIsochroneLayer;
        private InformationLayer GeocodeLayer;
        private InformationLayer SearchLayer;
        private AzureMapDataProvider AzureMapDataProvider;
        private AzureRouteIsochroneDataProvider RouteIsochroneProvider;
        private AzureGeocodeDataProvider GeoCodeProvider;
        private AzureSearchDataProvider SearchProvider;

        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private XtraEditors.RadioGroup radioGroup1;

        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private VectorItemsLayer vectorItemsLayer1;
        private ListSourceDataAdapter listSourceDataAdapter1;
        private XtraEditors.TrackBarControl trackBarControl1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
