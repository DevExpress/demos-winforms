namespace DevExpress.XtraMap.Demos {
    partial class ItemsMoving {
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
            DevExpress.XtraMap.GeoMapCoordinateSystem geoMapCoordinateSystem1 = new DevExpress.XtraMap.GeoMapCoordinateSystem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsMoving));
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.vectorItemsLayer3 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.solveLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage2 = new DevExpress.XtraMap.MapItemStorage();
            this.mazeLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.mazeData = new DevExpress.XtraMap.MapItemStorage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.ribbonControl1.MaxItemId = 8;
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems;
            this.mapControl1.CoordinateSystem = geoMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer3);
            this.mapControl1.Layers.Add(this.solveLayer);
            this.mapControl1.Layers.Add(this.mazeLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.MinZoomLevel = 2D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(500, 359);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl1_SelectionChanged);
            this.mapControl1.OverlaysArranged += new DevExpress.XtraMap.OverlaysArrangedEventHandler(this.mapControl1_OverlaysArranged);
            this.mapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapControl1_MouseUp);
            this.imageLayer1.DataProvider = this.AzureMapDataProvider;
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.vectorItemsLayer3.AllowEditItems = false;
            this.vectorItemsLayer3.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer3.EnableHighlighting = false;
            this.vectorItemsLayer3.EnableSelection = false;
            this.vectorItemsLayer3.ItemStyle.Fill = System.Drawing.Color.Transparent;
            this.vectorItemsLayer3.ItemStyle.StrokeWidth = 0;
            this.vectorItemsLayer3.Name = "ShapesLayer";
            this.vectorItemsLayer3.ShapeTitlesPattern = "";
            this.shapefileDataAdapter1.ItemsLoaded += new DevExpress.XtraMap.ItemsLoadedEventHandler(this.shapefileDataAdapter1_ItemsLoaded);
            this.solveLayer.AllowEditItems = false;
            this.solveLayer.Data = this.mapItemStorage2;
            this.solveLayer.EnableHighlighting = false;
            this.solveLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.solveLayer.Name = "SolveLayer";
            this.mazeLayer.Data = this.mazeData;
            this.mazeLayer.HighlightedItemStyle.StrokeWidth = 3;
            this.mazeLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mazeLayer.ItemStyle.StrokeWidth = 2;
            this.mazeLayer.Name = "MazeLayer";
            this.mazeLayer.ShapeTitlesPattern = "";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Game";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Restart Game";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ItemsMoving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "ItemsMoving";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private ImageLayer imageLayer1;
        private AzureMapDataProvider AzureMapDataProvider;
        private VectorItemsLayer mazeLayer;
        private MapItemStorage mazeData;
        private VectorItemsLayer solveLayer;
        private MapItemStorage mapItemStorage2;
        private VectorItemsLayer vectorItemsLayer3;
        private ShapefileDataAdapter shapefileDataAdapter1;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}
