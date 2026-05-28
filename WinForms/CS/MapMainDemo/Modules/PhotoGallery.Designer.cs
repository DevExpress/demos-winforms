namespace DevExpress.XtraMap.Demos {
    partial class PhotoGallery {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
            OnDispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.MapPushpin mapPushpin1 = new DevExpress.XtraMap.MapPushpin();
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.FixedMiniMapBehavior fixedMiniMapBehavior1 = new DevExpress.XtraMap.FixedMiniMapBehavior();
            this.MiniMapImageTilesLayer = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.MiniMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.MiniMapVectorItemsLayer = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.MiniMapData = new DevExpress.XtraMap.MapItemStorage();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ListSourceDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.PushpinLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.MapItemStorage = new DevExpress.XtraMap.MapItemStorage();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiniMapImageTilesLayer
            // 
            this.MiniMapImageTilesLayer.DataProvider = this.MiniMapDataProvider;
            this.MiniMapImageTilesLayer.Name = "ImageTilesLayer";
            // 
            // MiniMapVectorItemsLayer
            // 
            this.MiniMapVectorItemsLayer.Data = this.MiniMapData;
            this.MiniMapVectorItemsLayer.ItemStyle.Fill = System.Drawing.Color.Red;
            this.MiniMapVectorItemsLayer.ItemStyle.Stroke = System.Drawing.Color.White;
            this.MiniMapVectorItemsLayer.ItemStyle.StrokeWidth = 2;
            this.MiniMapVectorItemsLayer.Name = "DataLayer";
            // 
            // TilesLayer
            // 
            this.TilesLayer.DataProvider = this.AzureMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            this.TilesLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.TilesLayer_DataLoaded);
            // 
            // ItemsLayer
            // 
            this.ItemsLayer.Data = this.ListSourceDataAdapter;
            this.ItemsLayer.ItemStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLayer.Name = "ItemsLayer";
            this.ItemsLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.ItemsLayer_DataLoaded);
            // 
            // ListSourceDataAdapter
            // 
            this.ListSourceDataAdapter.Mappings.Latitude = "Latitude";
            this.ListSourceDataAdapter.Mappings.Longitude = "Longitude";
            this.ListSourceDataAdapter.Mappings.Text = "CityName";
            // 
            // PushpinLayer
            // 
            this.PushpinLayer.Data = this.MapItemStorage;
            this.PushpinLayer.Name = "PushpinLayer";
            this.PushpinLayer.Visible = false;
            // 
            // MapItemStorage
            // 
            this.MapItemStorage.Items.Add(mapPushpin1);
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(47.5D, 2D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Layers.Add(this.PushpinLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 139);
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopLeft;
            fixedMiniMapBehavior1.ZoomLevel = 0.5D;
            miniMap1.Behavior = fixedMiniMapBehavior1;
            miniMap1.Height = 255;
            miniMap1.Layers.Add(this.MiniMapImageTilesLayer);
            miniMap1.Layers.Add(this.MiniMapVectorItemsLayer);
            miniMap1.Width = 255;
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.MinZoomLevel = 0.1D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(1032, 471);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapControl1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // galleryControl1
            // 
            this.galleryControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            // 
            // 
            // 
            this.galleryControl1.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.galleryControl1.Gallery.ColumnCount = 3;
            this.galleryControl1.Gallery.DistanceBetweenItems = 5;
            this.galleryControl1.Gallery.DistanceItemImageToText = 2;
            this.galleryControl1.Gallery.DrawImageBackground = false;
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(280, 180);
            this.galleryControl1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.galleryControl1.Gallery.RowCount = 2;
            this.galleryControl1.Gallery.ShowItemText = true;
            this.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.galleryControl1.Location = new System.Drawing.Point(74, 26);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(12, 12);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(1, 1);
            this.galleryControlClient1.Size = new System.Drawing.Size(10, 10);
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.galleryControl1);
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "PhotoGallery";
            this.Size = new System.Drawing.Size(1032, 610);
            this.Load += new System.EventHandler(this.PhotoGallery_Load);
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            this.Controls.SetChildIndex(this.galleryControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter ListSourceDataAdapter;
        private VectorItemsLayer PushpinLayer;
        private MapItemStorage MapItemStorage;
        private AzureMapDataProvider AzureMapDataProvider;
        private AzureMapDataProvider MiniMapDataProvider;
        private MapItemStorage MiniMapData;
        private MiniMapImageTilesLayer MiniMapImageTilesLayer;
        private MiniMapVectorItemsLayer MiniMapVectorItemsLayer;
    }
}
