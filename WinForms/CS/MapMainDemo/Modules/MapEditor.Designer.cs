namespace DevExpress.XtraMap.Demos {
    partial class MapEditorDemo {
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
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem1 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem2 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem3 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem4 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem5 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem6 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.ColorLegendItem colorLegendItem7 = new DevExpress.XtraMap.ColorLegendItem();
            DevExpress.XtraMap.MapOverlay mapOverlay1 = new DevExpress.XtraMap.MapOverlay();
            DevExpress.XtraMap.MapOverlayTextItem mapOverlayTextItem1 = new DevExpress.XtraMap.MapOverlayTextItem();
            DevExpress.XtraMap.MapOverlay mapOverlay2 = new DevExpress.XtraMap.MapOverlay();
            DevExpress.XtraMap.MapOverlayTextItem mapOverlayTextItem2 = new DevExpress.XtraMap.MapOverlayTextItem();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.kmlFileDataAdapter1 = new DevExpress.XtraMap.KmlFileDataAdapter();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.fillEdit = new DevExpress.XtraEditors.ColorPickEdit();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ExportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.strokeEdit = new DevExpress.XtraEditors.ColorPickEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ExportBarButtonItem});
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ribbonControl1.Size = new System.Drawing.Size(977, 183);
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(26.804559994944D, 33.947806856342D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorLegendItem1.Color = System.Drawing.Color.Gray;
            colorLegendItem1.Text = "Roads/Parking";
            colorLegendItem2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            colorLegendItem2.Text = "Services";
            colorLegendItem3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            colorLegendItem3.Text = "Botanic Gardens";
            colorLegendItem4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            colorLegendItem4.Text = "Pools and Fountains";
            colorLegendItem5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(47)))));
            colorLegendItem5.Text = "Recreation/Play Areas";
            colorLegendItem6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(92)))), ((int)(((byte)(7)))));
            colorLegendItem6.Text = "Residential Buildings";
            colorLegendItem7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            colorLegendItem7.Text = "Reception/Restaurant";
            colorListLegend1.CustomItems.Add(colorLegendItem1);
            colorListLegend1.CustomItems.Add(colorLegendItem2);
            colorListLegend1.CustomItems.Add(colorLegendItem3);
            colorListLegend1.CustomItems.Add(colorLegendItem4);
            colorListLegend1.CustomItems.Add(colorLegendItem5);
            colorListLegend1.CustomItems.Add(colorLegendItem6);
            colorListLegend1.CustomItems.Add(colorLegendItem7);
            colorListLegend1.Header = "Resort Map";
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 183);
            this.mapControl1.MapEditor.ShowEditorPanel = true;
            this.mapControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapControl1.Measurements.AreaUnits = DevExpress.XtraMap.AreaMeasurementUnit.SquareMeter;
            this.mapControl1.Measurements.DistanceUnits = DevExpress.XtraMap.MeasureUnit.Meter;
            this.mapControl1.Measurements.ShowToolbar = true;
            this.mapControl1.MinZoomLevel = 17D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            mapOverlayTextItem1.Text = "Fill:";
            mapOverlay1.Items.Add(mapOverlayTextItem1);
            mapOverlay1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            mapOverlay1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            mapOverlayTextItem2.Text = "Stroke:";
            mapOverlay2.Items.Add(mapOverlayTextItem2);
            mapOverlay2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            mapOverlay2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mapControl1.Overlays.Add(mapOverlay1);
            this.mapControl1.Overlays.Add(mapOverlay2);
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(977, 471);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 18D;
            this.mapControl1.OverlaysArranged += new DevExpress.XtraMap.OverlaysArrangedEventHandler(this.OnOverlaysArranged);
            this.imageLayer1.DataProvider = this.AzureMapDataProvider;
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.Imagery;
            this.vectorItemsLayer1.Data = this.kmlFileDataAdapter1;
            this.vectorItemsLayer1.ToolTipPattern = "{name}";
            this.kmlFileDataAdapter1.ItemsLoaded += new DevExpress.XtraMap.ItemsLoadedEventHandler(this.OnItemsLoaded);
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.BeforeShowToolTip);
            // 
            // fillEdit
            // 
            this.fillEdit.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.fillEdit.Location = new System.Drawing.Point(13, 246);
            this.fillEdit.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.fillEdit.Name = "fillEdit";
            this.fillEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.fillEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fillEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced;
            this.fillEdit.Size = new System.Drawing.Size(77, 22);
            this.fillEdit.TabIndex = 14;
            this.fillEdit.EditValueChanged += new System.EventHandler(this.OnColorEditValueChanged);
            this.fillEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.OnCustomDisplayText);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ExportBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ExportBarButtonItem
            // 
            this.ExportBarButtonItem.Caption = "Save to KML";
            this.ExportBarButtonItem.Id = 7;
            this.ExportBarButtonItem.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Export;
            this.ExportBarButtonItem.Name = "ExportBarButtonItem";
            this.ExportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnExportBarButtonItemClick);
            // 
            // strokeEdit
            // 
            this.strokeEdit.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.strokeEdit.Location = new System.Drawing.Point(95, 246);
            this.strokeEdit.Margin = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.strokeEdit.Name = "strokeEdit";
            this.strokeEdit.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.strokeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.strokeEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced;
            this.strokeEdit.Size = new System.Drawing.Size(77, 22);
            this.strokeEdit.TabIndex = 39;
            this.strokeEdit.EditValueChanged += new System.EventHandler(this.OnColorEditValueChanged);
            this.strokeEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.OnCustomDisplayText);
            // 
            // MapEditorDemo
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strokeEdit);
            this.Controls.Add(this.fillEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "MapEditorDemo";
            this.Size = new System.Drawing.Size(977, 654);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            this.Controls.SetChildIndex(this.fillEdit, 0);
            this.Controls.SetChildIndex(this.strokeEdit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private ImageLayer imageLayer1;
        private AzureMapDataProvider AzureMapDataProvider;
        private XtraEditors.ColorPickEdit fillEdit;
        private XtraBars.BarButtonItem ExportBarButtonItem;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraEditors.ColorPickEdit strokeEdit;
        private VectorItemsLayer vectorItemsLayer1;
        private KmlFileDataAdapter kmlFileDataAdapter1;
        private Utils.ToolTipController toolTipController1;
    }
}
