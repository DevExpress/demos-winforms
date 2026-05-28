namespace DevExpress.XtraMap.Demos {
    partial class CoordinateSystems {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
            OnDispose();
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.AttributeItemKeyProvider attributeItemKeyProvider1 = new DevExpress.XtraMap.AttributeItemKeyProvider();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinateSystems));
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureImageryMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.HotelPlanLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.HotelsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.HotelsItemStorage = new DevExpress.XtraMap.MapItemStorage();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.AzureLabelsMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl1);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.TilesLayer.DataProvider = this.AzureImageryMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            attributeItemKeyProvider1.AttributeName = "CATEGORY";
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1;
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette;
            this.HotelPlanLayer.Colorizer = keyColorColorizer1;
            this.HotelPlanLayer.EnableSelection = false;
            this.HotelPlanLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HotelPlanLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HotelPlanLayer.Name = "HotelPlanLayer";
            this.HotelPlanLayer.ToolTipPattern = "{NAME}";
            this.HotelPlanLayer.Visible = false;
            this.HotelPlanLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.HotelPlanLayer_DataLoaded);
            this.HotelsLayer.Data = this.HotelsItemStorage;
            this.HotelsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White;
            this.HotelsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.HotelsLayer.Name = "HotelsOnMapLayer";
            this.HotelsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White;
            this.HotelsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-21.1685D, -175.1343D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.ImageList = this.imageCollection1;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.HotelsLayer);
            this.mapControl1.Layers.Add(this.HotelPlanLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 15D;
            this.mapControl1.MinZoomLevel = 13D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(500, 332);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 13D;
            this.mapControl1.DrawMapItem += new DevExpress.XtraMap.DrawMapItemEventHandler(this.mapControl1_DrawMapItem);
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(83, 93);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Hotel_1.png");
            this.imageCollection1.Images.SetKeyName(1, "Hotel_2.png");
            this.imageCollection1.Images.SetKeyName(2, "Hotel_3.png");
            this.imageCollection1.Images.SetKeyName(3, "Hotel_1_h.png");
            this.imageCollection1.Images.SetKeyName(4, "Hotel_2_h.png");
            this.imageCollection1.Images.SetKeyName(5, "Hotel_3_h.png");
            this.imageLayer1.DataProvider = this.AzureLabelsMapDataProvider;
            this.AzureLabelsMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseLabelsRoad;
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageSize = new System.Drawing.Size(31, 31);
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(0, "back_btn_2.png");
            // 
            // CoordinateSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CoordinateSystems";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private Utils.ToolTipController toolTipController1;
        private Utils.ImageCollection imageCollection1;
        private Utils.ImageCollection imageCollection2;
        private ImageLayer TilesLayer;
        private VectorItemsLayer HotelPlanLayer;
        private VectorItemsLayer HotelsLayer;
        private AzureMapDataProvider AzureImageryMapDataProvider;
        private AzureMapDataProvider AzureLabelsMapDataProvider;
        private MapItemStorage HotelsItemStorage;
        private ImageLayer imageLayer1;
    }
}
