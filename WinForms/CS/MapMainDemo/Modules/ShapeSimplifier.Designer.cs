namespace DevExpress.XtraMap.Demos {
    partial class ShapeSimplifierDemo {
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
            this.isActive = false;
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.vectorItemsLayer3 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage2 = new DevExpress.XtraMap.MapItemStorage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mfTrackBarControl = new DevExpress.XtraEditors.TrackBarControl();
            this.shapeTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.ceAutoMode = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeTypeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.MaxItemId = 8;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(733, 150);
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.vectorItemsLayer1);
            this.mapControl1.Layers.Add(this.vectorItemsLayer2);
            this.mapControl1.Layers.Add(this.vectorItemsLayer3);
            this.mapControl1.Location = new System.Drawing.Point(0, 150);
            this.mapControl1.MapEditor.AllowSaveActions = false;
            this.mapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl1.MaxZoomLevel = 12D;
            this.mapControl1.MinZoomLevel = 5D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Height = 60;
            this.mapControl1.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl1.NavigationPanelOptions.ShowMilesScale = false;
            this.mapControl1.NavigationPanelOptions.ShowScrollButtons = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(523, 350);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 5D;
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer1.EnableHighlighting = false;
            this.vectorItemsLayer1.EnableSelection = false;
            this.vectorItemsLayer1.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.OnDataLoaded);
            this.shapefileDataAdapter1.ItemsLoaded += new DevExpress.XtraMap.ItemsLoadedEventHandler(this.OnItemsLoaded);
            this.vectorItemsLayer2.Data = this.mapItemStorage1;
            this.vectorItemsLayer2.EnableHighlighting = false;
            this.vectorItemsLayer2.EnableSelection = false;
            this.vectorItemsLayer2.ItemStyle.StrokeWidth = 3;
            this.vectorItemsLayer2.Visible = false;
            this.vectorItemsLayer3.Data = this.mapItemStorage2;
            this.vectorItemsLayer3.EnableHighlighting = false;
            this.vectorItemsLayer3.EnableSelection = false;
            this.vectorItemsLayer3.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(523, 150);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Size = new System.Drawing.Size(210, 350);
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
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(209, 350);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(209, 350);
            this.tabPaneOptions.TabIndex = 0;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(209, 317);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.mfTrackBarControl);
            this.layoutControl1.Controls.Add(this.shapeTypeRadioGroup);
            this.layoutControl1.Controls.Add(this.ceAutoMode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(393, 24, 865, 812);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(209, 317);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mfTrackBarControl
            // 
            this.mfTrackBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mfTrackBarControl.EditValue = null;
            this.mfTrackBarControl.Location = new System.Drawing.Point(9, 32);
            this.mfTrackBarControl.MenuManager = this;
            this.mfTrackBarControl.Name = "mfTrackBarControl";
            this.mfTrackBarControl.Properties.AutoSize = false;
            this.mfTrackBarControl.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.mfTrackBarControl.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel3.Label = "0";
            trackBarLabel4.Label = "100";
            trackBarLabel4.Value = 280;
            this.mfTrackBarControl.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel3,
            trackBarLabel4});
            this.mfTrackBarControl.Properties.Maximum = 280;
            this.mfTrackBarControl.Properties.ShowLabels = true;
            this.mfTrackBarControl.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mfTrackBarControl.Size = new System.Drawing.Size(190, 44);
            this.mfTrackBarControl.StyleController = this.layoutControl1;
            this.mfTrackBarControl.TabIndex = 2;
            this.mfTrackBarControl.ValueChanged += new System.EventHandler(this.OnTrackBarControlValueChanged);
            // 
            // shapeTypeRadioGroup
            // 
            this.shapeTypeRadioGroup.AutoSizeInLayoutControl = true;
            this.shapeTypeRadioGroup.Location = new System.Drawing.Point(8, 140);
            this.shapeTypeRadioGroup.MenuManager = this;
            this.shapeTypeRadioGroup.Name = "shapeTypeRadioGroup";
            this.shapeTypeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.shapeTypeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.shapeTypeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.shapeTypeRadioGroup.Properties.Columns = 2;
            this.shapeTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Polygon"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Polyline")});
            this.shapeTypeRadioGroup.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.shapeTypeRadioGroup.Properties.SelectedIndexChanged += new System.EventHandler(this.ShapeTypeSelectedIndexChanged);
            this.shapeTypeRadioGroup.Size = new System.Drawing.Size(193, 24);
            this.shapeTypeRadioGroup.StyleController = this.layoutControl1;
            this.shapeTypeRadioGroup.TabIndex = 4;
            // 
            // ceAutoMode
            // 
            this.ceAutoMode.EditValue = true;
            this.ceAutoMode.Location = new System.Drawing.Point(9, 80);
            this.ceAutoMode.MenuManager = this;
            this.ceAutoMode.Name = "ceAutoMode";
            this.ceAutoMode.Properties.Caption = "Auto";
            this.ceAutoMode.Size = new System.Drawing.Size(191, 20);
            this.ceAutoMode.StyleController = this.layoutControl1;
            this.ceAutoMode.TabIndex = 6;
            this.ceAutoMode.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(209, 317);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 172);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem1.Size = new System.Drawing.Size(209, 145);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 110);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlGroup1.Size = new System.Drawing.Size(209, 62);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Shape Type";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem4.Control = this.shapeTypeRadioGroup;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(193, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlGroup2.Size = new System.Drawing.Size(209, 110);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Tolerance";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.mfTrackBarControl;
            this.layoutControlItem2.Enabled = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(192, 48);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(192, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(193, 48);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceAutoMode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(193, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ShapeSimplifierDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.sidePanelOptions);
            this.Name = "ShapeSimplifierDemo";
            this.Size = new System.Drawing.Size(733, 500);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfTrackBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeTypeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private VectorItemsLayer vectorItemsLayer1;
        private System.Windows.Forms.Timer timer1;
        private VectorItemsLayer vectorItemsLayer2;
        private MapItemStorage mapItemStorage1;
        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.TrackBarControl mfTrackBarControl;
        private XtraEditors.RadioGroup shapeTypeRadioGroup;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.CheckEdit ceAutoMode;
        private ShapefileDataAdapter shapefileDataAdapter1;
        private VectorItemsLayer vectorItemsLayer3;
        private MapItemStorage mapItemStorage2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
