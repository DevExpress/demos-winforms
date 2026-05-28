using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraMap.Demos {
    partial class ClusterCustomization {
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
            DevExpress.XtraMap.MouseHoverInteractiveClusterMode mouseHoverInteractiveClusterMode1 = new DevExpress.XtraMap.MouseHoverInteractiveClusterMode();
            DevExpress.XtraMap.MapOverlay mapOverlay1 = new DevExpress.XtraMap.MapOverlay();
            DevExpress.XtraMap.MapOverlayTextItem mapOverlayTextItem1 = new DevExpress.XtraMap.MapOverlayTextItem();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping3 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping4 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping5 = new DevExpress.XtraMap.MapItemAttributeMapping();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.BackgroundLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ShapefileAdapter = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.ItemsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.ItemsClusterer = new DevExpress.XtraMap.DistanceBasedClusterer();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(1117, 256);
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(38D, -98D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.InteractiveClusterMode = mouseHoverInteractiveClusterMode1;
            this.mapControl1.Layers.Add(this.BackgroundLayer);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 256);
            this.mapControl1.MaxZoomLevel = 9D;
            this.mapControl1.MinZoomLevel = 4D;
            this.mapControl1.Name = "mapControl1";
            mapOverlayTextItem1.Text = "Top Ranked US Universities";
            mapOverlayTextItem1.TextStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mapOverlay1.Items.Add(mapOverlayTextItem1);
            mapOverlay1.Margin = new System.Windows.Forms.Padding(6, 6, 0, 0);
            mapOverlay1.Padding = new System.Windows.Forms.Padding(4);
            this.mapControl1.Overlays.Add(mapOverlay1);
            this.mapControl1.ScrollArea = new DevExpress.Map.MapBounds(-155D, 63D, -50D, 20D);
            this.mapControl1.Size = new System.Drawing.Size(1117, 648);
            this.mapControl1.TabIndex = 2;
            this.mapControl1.ZoomLevel = 5D;
            this.BackgroundLayer.Data = this.ShapefileAdapter;
            this.BackgroundLayer.EnableHighlighting = false;
            this.BackgroundLayer.EnableSelection = false;
            this.BackgroundLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            this.vectorItemsLayer1.Data = this.ItemsDataAdapter;
            mapItemAttributeMapping1.Member = "Name";
            mapItemAttributeMapping1.Name = "Name";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "City";
            mapItemAttributeMapping2.Name = "City";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping3.Member = "State";
            mapItemAttributeMapping3.Name = "State";
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping4.Member = "InfoUri";
            mapItemAttributeMapping4.Name = "Info";
            mapItemAttributeMapping5.Member = "SiteUri";
            mapItemAttributeMapping5.Name = "Site";
            this.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3);
            this.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping4);
            this.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping5);
            this.ItemsDataAdapter.Clusterer = this.ItemsClusterer;
            this.ItemsDataAdapter.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Pushpin;
            this.ItemsDataAdapter.Mappings.Latitude = "Lat";
            this.ItemsDataAdapter.Mappings.Longitude = "Lon";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.svgImageCollection1.Add("bo_address", "image://svgimages/business objects/bo_address.svg");
            // 
            // ClusterCustomization
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapControl1);
            this.Name = "ClusterCustomization";
            this.Size = new System.Drawing.Size(1117, 904);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MapControl mapControl1;
        private VectorItemsLayer BackgroundLayer;
        private ShapefileDataAdapter ShapefileAdapter;
        private VectorItemsLayer vectorItemsLayer1;
        private ListSourceDataAdapter ItemsDataAdapter;
        private DistanceBasedClusterer ItemsClusterer;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
