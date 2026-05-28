namespace DevExpress.XtraMap.Demos {
    partial class HeatMap {
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
            //this.isActive = false;
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.HeatmapDensityBasedAlgorithm heatmapDensityBasedAlgorithm1 = new DevExpress.XtraMap.HeatmapDensityBasedAlgorithm();
            DevExpress.XtraMap.HeatmapDataSourceAdapter heatmapDataSourceAdapter1 = new DevExpress.XtraMap.HeatmapDataSourceAdapter();
            DevExpress.XtraMap.ColorScaleLegend colorScaleLegend1 = new DevExpress.XtraMap.ColorScaleLegend();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.heatmapProvider1 = new DevExpress.XtraMap.HeatmapProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mfTrackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.paletteRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl1);
            this.panelControl1.Controls.Add(this.sidePanelOptions);
            this.panelControl1.Size = new System.Drawing.Size(581, 291);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(581, 150);
            this.imageLayer1.DataProvider = this.heatmapProvider1;
            this.imageLayer1.Transparency = ((byte)(50));
            this.imageLayer1.ZIndex = 1;
            heatmapDensityBasedAlgorithm1.PointRadius = 8;
            this.heatmapProvider1.Algorithm = heatmapDensityBasedAlgorithm1;
            heatmapDataSourceAdapter1.Mappings.XCoordinate = "glon";
            heatmapDataSourceAdapter1.Mappings.YCoordinate = "glat";
            this.heatmapProvider1.PointSource = heatmapDataSourceAdapter1;
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.imageLayer2);
            colorScaleLegend1.EnableGradientScale = true;
            colorScaleLegend1.Header = "Seismic Density";
            colorScaleLegend1.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10F);
            colorScaleLegend1.Layer = this.imageLayer1;
            this.mapControl1.Legends.Add(colorScaleLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MapEditor.AllowSaveActions = false;
            this.mapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(365, 291);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.LegendItemCreating += new DevExpress.XtraMap.LegendItemCreatingEventHandler(this.OnLegendItemCreating);
            this.imageLayer2.DataProvider = this.AzureMapDataProvider;
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(365, 0);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Size = new System.Drawing.Size(216, 291);
            this.sidePanelOptions.TabIndex = 6;
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneOptions.Location = new System.Drawing.Point(1, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(215, 291);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(215, 291);
            this.tabPaneOptions.TabIndex = 0;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(215, 258);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.mfTrackBarControl1);
            this.layoutControl1.Controls.Add(this.paletteRadioGroup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(215, 258);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mfTrackBarControl1
            // 
            this.mfTrackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mfTrackBarControl1.EditValue = 8;
            this.mfTrackBarControl1.Location = new System.Drawing.Point(7, 30);
            this.mfTrackBarControl1.Name = "mfTrackBarControl1";
            this.mfTrackBarControl1.Properties.AutoSize = false;
            this.mfTrackBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mfTrackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.mfTrackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "2";
            trackBarLabel1.Value = 2;
            trackBarLabel2.Label = "20";
            trackBarLabel2.Value = 20;
            this.mfTrackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2});
            this.mfTrackBarControl1.Properties.Maximum = 20;
            this.mfTrackBarControl1.Properties.Minimum = 2;
            this.mfTrackBarControl1.Properties.ShowLabels = true;
            this.mfTrackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mfTrackBarControl1.Size = new System.Drawing.Size(201, 46);
            this.mfTrackBarControl1.StyleController = this.layoutControl1;
            this.mfTrackBarControl1.TabIndex = 2;
            this.mfTrackBarControl1.Value = 8;
            this.mfTrackBarControl1.EditValueChanged += new System.EventHandler(this.OnTrackBarControlEditValueChanged);
            // 
            // paletteRadioGroup
            // 
            this.paletteRadioGroup.Location = new System.Drawing.Point(11, 111);
            this.paletteRadioGroup.Name = "paletteRadioGroup";
            this.paletteRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.paletteRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.paletteRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paletteRadioGroup.Properties.ColumnIndent = 0;
            this.paletteRadioGroup.Properties.Columns = 1;
            this.paletteRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.paletteRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Default"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Hot"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cold")});
            this.paletteRadioGroup.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.paletteRadioGroup.Size = new System.Drawing.Size(193, 72);
            this.paletteRadioGroup.StyleController = this.layoutControl1;
            this.paletteRadioGroup.TabIndex = 4;
            this.paletteRadioGroup.SelectedIndexChanged += new System.EventHandler(this.OnPaletteTypeSelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(215, 258);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 6, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(215, 83);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Point Radius";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mfTrackBarControl1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 50);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(90, 14);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(205, 50);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 190);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(215, 68);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 83);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(215, 107);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Palette";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.paletteRadioGroup;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(197, 76);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // HeatMap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HeatMap";
            this.Size = new System.Drawing.Size(581, 459);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paletteRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private ImageLayer imageLayer1;
        private HeatmapProvider heatmapProvider1;
        private ImageLayer imageLayer2;
        private AzureMapDataProvider AzureMapDataProvider;
        private XtraEditors.TrackBarControl mfTrackBarControl1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraEditors.RadioGroup paletteRadioGroup;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
