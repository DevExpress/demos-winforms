namespace DevExpress.XtraMap.Demos {
    partial class OpenStreetMapProvider {
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
            DevExpress.XtraMap.MiniMap miniMap1 = new DevExpress.XtraMap.MiniMap();
            DevExpress.XtraMap.DynamicMiniMapBehavior dynamicMiniMapBehavior1 = new DevExpress.XtraMap.DynamicMiniMapBehavior();
            this.MiniMapImageTilesLayer = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.MiniMapDataProvider = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.BaseProvider = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.OverlayLayer = new DevExpress.XtraMap.ImageLayer();
            this.OverlayProvider = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.trackBarControl2 = new DevExpress.XtraEditors.TrackBarControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(801, 422);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(53, 51, 53, 51);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.OptionsMenuMinWidth = 587;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(801, 183);
            this.MiniMapImageTilesLayer.DataProvider = this.MiniMapDataProvider;
            this.MiniMapDataProvider.WebRequest += new DevExpress.XtraMap.MapWebRequestEventHandler(this.OnWebRequest);
            this.TilesLayer.DataProvider = this.BaseProvider;
            this.TilesLayer.Name = "TilesLayer";
            this.BaseProvider.WebRequest += new DevExpress.XtraMap.MapWebRequestEventHandler(this.OnWebRequest);
            this.OverlayLayer.DataProvider = this.OverlayProvider;
            this.OverlayLayer.Name = "OverlayLayer";
            this.OverlayProvider.WebRequest += new DevExpress.XtraMap.MapWebRequestEventHandler(this.OnWebRequest);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.HotTrackItems = true;
            this.listBoxControl1.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.listBoxControl1.Location = new System.Drawing.Point(2, 30);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(190, 106);
            this.listBoxControl1.StyleController = this.layoutControl1;
            this.listBoxControl1.TabIndex = 5;
            this.listBoxControl1.SelectedValueChanged += new System.EventHandler(this.OnListBoxControl1_SelectedValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.trackBarControl1);
            this.layoutControl1.Controls.Add(this.listBoxControl2);
            this.layoutControl1.Controls.Add(this.trackBarControl2);
            this.layoutControl1.Controls.Add(this.listBoxControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(744, 179, 806, 536);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(194, 381);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = null;
            this.trackBarControl1.Location = new System.Drawing.Point(2, 323);
            this.trackBarControl1.MenuManager = this;
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl1.Properties.Maximum = 255;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl1.Size = new System.Drawing.Size(190, 56);
            this.trackBarControl1.StyleController = this.layoutControl1;
            this.trackBarControl1.TabIndex = 6;
            this.trackBarControl1.EditValueChanged += new System.EventHandler(this.OnTrackBarControl1_EditValueChanged);
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl2.HotTrackItems = true;
            this.listBoxControl2.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.listBoxControl2.Location = new System.Drawing.Point(2, 240);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(190, 59);
            this.listBoxControl2.StyleController = this.layoutControl1;
            this.listBoxControl2.TabIndex = 5;
            this.listBoxControl2.SelectedValueChanged += new System.EventHandler(this.OnListBoxControl2_SelectedValueChanged);
            // 
            // trackBarControl2
            // 
            this.trackBarControl2.EditValue = null;
            this.trackBarControl2.Location = new System.Drawing.Point(2, 160);
            this.trackBarControl2.Name = "trackBarControl2";
            this.trackBarControl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.trackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trackBarControl2.Properties.Maximum = 255;
            this.trackBarControl2.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl2.Size = new System.Drawing.Size(190, 56);
            this.trackBarControl2.StyleController = this.layoutControl1;
            this.trackBarControl2.TabIndex = 6;
            this.trackBarControl2.EditValueChanged += new System.EventHandler(this.OnTrackBarControl2_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.layoutControlItem3,
            this.simpleLabelItem3,
            this.simpleLabelItem4});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(194, 381);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.listBoxControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(194, 110);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trackBarControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 158);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(194, 60);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.trackBarControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 321);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(194, 60);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(194, 28);
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0);
            this.simpleLabelItem1.Text = "Base Layers";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(84, 16);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 218);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(194, 20);
            this.simpleLabelItem2.Text = "Overlay Layers";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(84, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.listBoxControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 238);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(54, 4);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(194, 63);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.Location = new System.Drawing.Point(0, 138);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(194, 20);
            this.simpleLabelItem3.Text = "Transparency";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(84, 16);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.Location = new System.Drawing.Point(0, 301);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(194, 20);
            this.simpleLabelItem4.Text = "Transparency";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(84, 16);
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(50.067D, 14.417D);
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems;
            this.mapControl1.CoordinateSystem = geoMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.OverlayLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopRight;
            miniMap1.Behavior = dynamicMiniMapBehavior1;
            miniMap1.Layers.Add(this.MiniMapImageTilesLayer);
            this.mapControl1.MiniMap = miniMap1;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(603, 422);
            this.mapControl1.TabIndex = 4;
            this.mapControl1.ZoomLevel = 5D;
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneOptions.Location = new System.Drawing.Point(4, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(194, 422);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(194, 422);
            this.tabPaneOptions.TabIndex = 8;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(194, 381);
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(603, 0);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sidePanelOptions.Size = new System.Drawing.Size(198, 422);
            this.sidePanelOptions.TabIndex = 6;
            // 
            // OpenStreetMapProvider
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OpenStreetMapProvider";
            this.Size = new System.Drawing.Size(801, 628);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            this.sidePanelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageLayer TilesLayer;
        private OpenStreetMapDataProvider BaseProvider;
        private ImageLayer OverlayLayer;
        private OpenStreetMapDataProvider OverlayProvider;
        private OpenStreetMapDataProvider MiniMapDataProvider;
        private MiniMapImageTilesLayer MiniMapImageTilesLayer;
        private MapControl mapControl1;

        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private XtraEditors.ListBoxControl listBoxControl1;
        private XtraEditors.TrackBarControl trackBarControl2;
        private XtraEditors.ListBoxControl listBoxControl2;
        private XtraEditors.TrackBarControl trackBarControl1;
        
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;
        private XtraLayout.SimpleLabelItem simpleLabelItem2;
        private XtraLayout.SimpleLabelItem simpleLabelItem3;
        private XtraLayout.SimpleLabelItem simpleLabelItem4;
    }
}
