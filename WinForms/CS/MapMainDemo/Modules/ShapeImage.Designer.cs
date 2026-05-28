namespace DevExpress.XtraMap.Demos {
    partial class ShapeImage {
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
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage = new DevExpress.XtraMap.MapItemStorage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.MaxItemId = 10;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.IEBehavior = true;
            this.ribbonControl1.Size = new System.Drawing.Size(843, 141);
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(40.78D, -73.9675D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.imageLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 141);
            this.mapControl.MaxZoomLevel = 17D;
            this.mapControl.MinZoomLevel = 10D;
            this.mapControl.Name = "mapControl";
            this.mapControl.NavigationPanelOptions.XCoordinatePattern = "{CP}{D}°{M:2}\'";
            this.mapControl.NavigationPanelOptions.YCoordinatePattern = "{CP}{D}°{M:2}\'";
            this.mapControl.Size = new System.Drawing.Size(843, 446);
            this.mapControl.TabIndex = 1;
            this.mapControl.ZoomLevel = 14D;
            this.imageLayer1.DataProvider = this.AzureMapDataProvider;
            this.imageLayer1.ViewportChanged += new DevExpress.XtraMap.ViewportChangedEventHandler(this.ImageLayer1_ViewportChanged);
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.vectorItemsLayer1.Data = this.mapItemStorage;
            // 
            // ShapeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.panelControl1.Controls.Add(this.mapControl);
            this.Name = "ShapeImage";
            this.Size = new System.Drawing.Size(843, 587);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.mapControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl;
        private VectorItemsLayer vectorItemsLayer1;
        private MapItemStorage mapItemStorage;
        private ImageLayer imageLayer1;
        private AzureMapDataProvider AzureMapDataProvider;
    }
}
