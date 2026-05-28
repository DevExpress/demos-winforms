namespace DevExpress.XtraMap.Demos {
    partial class MapElements {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            OnDispose();
            if(disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.GeoMapCoordinateSystem geoMapCoordinateSystem1 = new DevExpress.XtraMap.GeoMapCoordinateSystem();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping3 = new DevExpress.XtraMap.MapItemAttributeMapping();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapElements));
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.PathsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PathsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.PlanesLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PlanesDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.AirportsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.AirportsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.RoutesLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.RoutesStorage = new DevExpress.XtraMap.MapItemStorage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ShowPlanesCheckItem = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl1);
            this.panelControl1.Size = new System.Drawing.Size(601, 193);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ShowPlanesCheckItem});
            this.ribbonControl1.MaxItemId = 10;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(601, 256);
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.TilesLayer.DataProvider = this.AzureMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.PathsLayer.Data = this.PathsDataAdapter;
            this.PathsLayer.EnableHighlighting = false;
            this.PathsLayer.HighlightedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.HighlightedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsLayer.Name = "PathsLayer";
            this.PathsLayer.SelectedItemStyle.Fill = System.Drawing.Color.Transparent;
            this.PathsLayer.SelectedItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.PathsDataAdapter.Mappings.Latitude = "Latitude";
            this.PathsDataAdapter.Mappings.Longitude = "Longitude";
            this.PathsDataAdapter.Mappings.Type = "ItemType";
            this.PlanesLayer.Data = this.PlanesDataAdapter;
            this.PlanesLayer.Name = "PlanesLayer";
            this.PlanesDataAdapter.Mappings.Latitude = "Latitude";
            this.PlanesDataAdapter.Mappings.Longitude = "Longitude";
            this.PlanesDataAdapter.Mappings.Type = "ItemType";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(32D, 10D);
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems;
            this.mapControl1.CoordinateSystem = geoMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.PathsLayer);
            this.mapControl1.Layers.Add(this.AirportsLayer);
            this.mapControl1.Layers.Add(this.RoutesLayer);
            this.mapControl1.Layers.Add(this.PlanesLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 10D;
            this.mapControl1.MinZoomLevel = 3D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(601, 193);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.OnMapSelectionChanged);
            this.mapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMapControlMouseDown);
            this.mapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMapControlMouseUp);
            this.AirportsLayer.Data = this.AirportsDataAdapter;
            this.AirportsLayer.Name = "Airports";
            this.AirportsLayer.ToolTipPattern = " {Name} ( {IATA} ) ";
            this.AirportsLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.AirportsLayer_DataLoaded);
            mapItemAttributeMapping1.Member = "Name";
            mapItemAttributeMapping1.Name = "Name";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "City";
            mapItemAttributeMapping2.Name = "City";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping3.Member = "IATA";
            mapItemAttributeMapping3.Name = "IATA";
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3);
            this.AirportsDataAdapter.Mappings.Type = "ItemType";
            this.AirportsDataAdapter.Mappings.XCoordinate = "Longitude";
            this.AirportsDataAdapter.Mappings.YCoordinate = "Latitude";
            this.RoutesLayer.Data = this.RoutesStorage;
            this.RoutesLayer.Name = "RoutesLayer";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ShowPlanesCheckItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ShowPlanesCheckItem
            // 
            this.ShowPlanesCheckItem.BindableChecked = true;
            this.ShowPlanesCheckItem.Caption = "Show Planes";
            this.ShowPlanesCheckItem.Checked = true;
            this.ShowPlanesCheckItem.Id = 9;
            this.ShowPlanesCheckItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ShowPlanesCheckItem.ImageOptions.SvgImage")));
            this.ShowPlanesCheckItem.Name = "ShowPlanesCheckItem";
            this.ShowPlanesCheckItem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPlanesVisibilityCheckedChanged);
            // 
            // MapElements
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.Name = "MapElements";
            this.Size = new System.Drawing.Size(601, 480);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }        

        #endregion

        private MapControl mapControl1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer PathsLayer;
        private ListSourceDataAdapter PathsDataAdapter;
        private VectorItemsLayer PlanesLayer;
        private ListSourceDataAdapter PlanesDataAdapter;
        private AzureMapDataProvider AzureMapDataProvider;
        private VectorItemsLayer AirportsLayer;
        private ListSourceDataAdapter AirportsDataAdapter;
        private VectorItemsLayer RoutesLayer;
        private MapItemStorage RoutesStorage;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarCheckItem ShowPlanesCheckItem;
    }
}
