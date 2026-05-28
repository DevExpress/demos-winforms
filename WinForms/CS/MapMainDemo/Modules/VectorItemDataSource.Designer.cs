namespace DevExpress.XtraMap.Demos {
    partial class VectorItemDataSource {
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
            OnDispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.MapDotSizeMapping mapDotSizeMapping1 = new DevExpress.XtraMap.MapDotSizeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.FixedMiniMapBehavior fixedMiniMapBehavior1 = new DevExpress.XtraMap.FixedMiniMapBehavior();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorItemDataSource));
            this.MiniMapImageTilesLayer = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.MiniMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.MiniMapVectorItemsLayer = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.MiniMapDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureImageryMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ListSourceDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.panelSeparator = new DevExpress.XtraEditors.PanelControl();
            this.AzureLabelsMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl1);
            this.panelControl1.Size = new System.Drawing.Size(601, 312);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Size = new System.Drawing.Size(601, 150);
            this.MiniMapImageTilesLayer.DataProvider = this.MiniMapDataProvider;
            this.MiniMapImageTilesLayer.Name = "ImageTilesLayer";
            this.MiniMapVectorItemsLayer.Data = this.MiniMapDataAdapter;
            this.MiniMapVectorItemsLayer.ItemStyle.Fill = System.Drawing.Color.Red;
            this.MiniMapVectorItemsLayer.ItemStyle.Stroke = System.Drawing.Color.White;
            this.MiniMapVectorItemsLayer.ItemStyle.StrokeWidth = 1;
            this.MiniMapVectorItemsLayer.Name = "DataLayer";
            this.MiniMapDataAdapter.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Dot;
            this.MiniMapDataAdapter.Mappings.Latitude = "Latitude";
            this.MiniMapDataAdapter.Mappings.Longitude = "Longitude";
            mapDotSizeMapping1.DefaultValue = 8D;
            this.MiniMapDataAdapter.PropertyMappings.Add(mapDotSizeMapping1);
            this.TilesLayer.DataProvider = this.AzureImageryMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            this.ItemsLayer.Data = this.ListSourceDataAdapter;
            this.ItemsLayer.ItemImageIndex = 0;
            this.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.Transparent;
            this.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.ItemsLayer.ItemStyle.StrokeWidth = 0;
            this.ItemsLayer.Name = "ItemsLayer";
            this.ItemsLayer.ToolTipPattern = "{Desc}";
            mapItemAttributeMapping1.Member = "Description";
            mapItemAttributeMapping1.Name = "Desc";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "Name";
            mapItemAttributeMapping2.Name = "Name";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.ListSourceDataAdapter.Mappings.Latitude = "Latitude";
            this.ListSourceDataAdapter.Mappings.Longitude = "Longitude";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-36D, 145D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableZooming = false;
            this.mapControl1.ImageList = this.imageCollection1;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopLeft;
            fixedMiniMapBehavior1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-30D, 133D);
            fixedMiniMapBehavior1.ZoomLevel = 2.7D;
            miniMap1.Behavior = fixedMiniMapBehavior1;
            miniMap1.Height = 200;
            miniMap1.Layers.Add(this.MiniMapImageTilesLayer);
            miniMap1.Layers.Add(this.MiniMapVectorItemsLayer);
            miniMap1.Width = 260;
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.ScrollArea = new DevExpress.Map.MapBounds(137D, -31.4D, 153.61D, -41.12D);
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.None;
            this.mapControl1.Size = new System.Drawing.Size(601, 312);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 6D;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(40, 40);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "SunkShipImage.png");
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // panelSeparator
            // 
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator.Location = new System.Drawing.Point(0, 150);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(601, 8);
            this.panelSeparator.TabIndex = 1;
            this.panelSeparator.Visible = false;
            this.AzureLabelsMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseLabelsRoad;
            this.imageLayer1.DataProvider = this.AzureLabelsMapDataProvider;
            // 
            // VectorItemDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panelSeparator);
            this.Name = "VectorItemDataSource";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panelSeparator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSeparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private XtraEditors.PanelControl panelSeparator;
        private Utils.ToolTipController toolTipController1;
        private Utils.ImageCollection imageCollection1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter ListSourceDataAdapter;
        private ListSourceDataAdapter MiniMapDataAdapter;
        private AzureMapDataProvider AzureImageryMapDataProvider;
        private AzureMapDataProvider AzureLabelsMapDataProvider;
        private AzureMapDataProvider MiniMapDataProvider;
        private MiniMapImageTilesLayer MiniMapImageTilesLayer;
        private MiniMapVectorItemsLayer MiniMapVectorItemsLayer;
        private ImageLayer imageLayer1;
    }
}
