namespace DevExpress.XtraMap.Demos {
    partial class MapArrows {
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
            DevExpress.XtraMap.ChoroplethColorizer choroplethColorizer1 = new DevExpress.XtraMap.ChoroplethColorizer();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem1 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem2 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.ColorizerColorItem colorizerColorItem3 = new DevExpress.XtraMap.ColorizerColorItem();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ShapeAttributeValueProvider shapeAttributeValueProvider1 = new DevExpress.XtraMap.ShapeAttributeValueProvider();
            DevExpress.XtraMap.GeoMapCoordinateSystem geoMapCoordinateSystem1 = new DevExpress.XtraMap.GeoMapCoordinateSystem();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend1 = new DevExpress.XtraMap.ColorScaleLegend();
            this.itemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.MaxItemId = 8;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(721, 256);
            choroplethColorizer1.ApproximateColors = true;
            colorizerColorItem1.Color = System.Drawing.Color.Green;
            colorizerColorItem2.Color = System.Drawing.Color.Yellow;
            colorizerColorItem3.Color = System.Drawing.Color.Red;
            choroplethColorizer1.ColorItems.Add(colorizerColorItem1);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem2);
            choroplethColorizer1.ColorItems.Add(colorizerColorItem3);
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1;
            choroplethColorizer1.RangeStops.Add(0D);
            choroplethColorizer1.RangeStops.Add(22D);
            choroplethColorizer1.RangeStops.Add(56D);
            shapeAttributeValueProvider1.AttributeName = "Speed";
            choroplethColorizer1.ValueProvider = shapeAttributeValueProvider1;
            this.itemsLayer.Colorizer = choroplethColorizer1;
            this.itemsLayer.Data = this.listSourceDataAdapter1;
            this.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Line;
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(46.25D, 13.26D);
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems;
            this.mapControl1.CoordinateSystem = geoMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Layers.Add(this.itemsLayer);
            colorScaleLegend1.DescriptionStyle.Font = new System.Drawing.Font("Tahoma", 10F);
            colorScaleLegend1.EnableGradientScale = true;
            colorScaleLegend1.Header = "Wind Speed, m/s";
            colorScaleLegend1.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F);
            colorScaleLegend1.Layer = this.itemsLayer;
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.mapControl1.Legends.Add(colorScaleLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 256);
            this.mapControl1.MaxZoomLevel = 8D;
            this.mapControl1.MinZoomLevel = 4D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.None;
            this.mapControl1.Size = new System.Drawing.Size(721, 389);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 4.5D;
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer1.EnableHighlighting = false;
            this.vectorItemsLayer1.EnableSelection = false;
            // 
            // MapArrows
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapControl1);
            this.Name = "MapArrows";
            this.Size = new System.Drawing.Size(721, 645);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private VectorItemsLayer itemsLayer;
        private VectorItemsLayer vectorItemsLayer1;
        private ShapefileDataAdapter shapefileDataAdapter1;
        private ListSourceDataAdapter listSourceDataAdapter1;
    }
}
