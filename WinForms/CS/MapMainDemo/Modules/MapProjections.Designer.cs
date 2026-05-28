using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraMap.Demos {
    partial class MapProjections {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.MapCustomElement mapCustomElement1 = new DevExpress.XtraMap.MapCustomElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapProjections));
            DevExpress.XtraMap.MapPolygon mapPolygon1 = new DevExpress.XtraMap.MapPolygon();
            DevExpress.XtraMap.MapCustomElement mapCustomElement2 = new DevExpress.XtraMap.MapCustomElement();
            this.FileLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ShapefileDataAdapter = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.Data = new DevExpress.XtraMap.MapItemStorage();
            this.btnCurrent = new DevExpress.XtraBars.BarButtonItem();
            this.barEditCalendar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.chkSteadily = new DevExpress.XtraBars.BarCheckItem();
            this.btnMinus = new DevExpress.XtraBars.BarButtonItem();
            this.btnPlus = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.chkPlay = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.projectionsList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelMain = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.GridLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.GridData = new DevExpress.XtraMap.MapItemStorage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ShowGridBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.sidePanelMain.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.chkSteadily,
            this.btnMinus,
            this.btnPlus,
            this.barEditCalendar,
            this.btnCurrent,
            this.ShowGridBarCheckItem});
            this.ribbonControl1.MaxItemId = 9;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.FileLayer.Data = this.ShapefileDataAdapter;
            this.FileLayer.EnableHighlighting = false;
            this.FileLayer.EnableSelection = false;
            this.FileLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(211)))), ((int)(((byte)(236)))));
            this.FileLayer.ItemStyle.Stroke = System.Drawing.Color.Transparent;
            this.FileLayer.ItemStyle.StrokeWidth = 0;
            this.FileLayer.Name = "FileLayer";
            this.FileLayer.ShapeTitlesPattern = "";
            this.FileLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.DayAndNight_DataLoaded);
            this.ItemsLayer.Data = this.Data;
            this.ItemsLayer.EnableHighlighting = false;
            this.ItemsLayer.EnableSelection = false;
            this.ItemsLayer.Name = "ItemsLayer";
            mapCustomElement1.Image = ((System.Drawing.Image)(resources.GetObject("mapCustomElement1.Image")));
            mapCustomElement1.UseAnimation = false;
            mapPolygon1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            mapPolygon1.Stroke = System.Drawing.Color.Transparent;
            mapPolygon1.StrokeWidth = 0;
            mapCustomElement2.Image = ((System.Drawing.Image)(resources.GetObject("mapCustomElement2.Image")));
            mapCustomElement2.UseAnimation = false;
            this.Data.Items.Add(mapCustomElement1);
            this.Data.Items.Add(mapPolygon1);
            this.Data.Items.Add(mapCustomElement2);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Caption = "Current Time";
            this.btnCurrent.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCurrent.Id = 6;
            this.btnCurrent.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.CurrentTime;
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCurrent_ItemClick);
            // 
            // barEditCalendar
            // 
            this.barEditCalendar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barEditCalendar.Edit = this.repositoryItemDateEdit1;
            this.barEditCalendar.EditWidth = 150;
            this.barEditCalendar.Id = 24;
            this.barEditCalendar.Name = "barEditCalendar";
            this.barEditCalendar.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "G";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // chkSteadily
            // 
            this.chkSteadily.Caption = "Steadily";
            this.chkSteadily.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkSteadily.Id = 30;
            this.chkSteadily.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Time;
            this.chkSteadily.Name = "chkSteadily";
            this.chkSteadily.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkSteadily_CheckedChanged);
            // 
            // btnMinus
            // 
            this.btnMinus.Caption = "Backward";
            this.btnMinus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnMinus.Id = 31;
            this.btnMinus.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Backward;
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMinus_ItemClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Caption = "Forward";
            this.btnPlus.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnPlus.Id = 32;
            this.btnPlus.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Forward;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlus_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Custom Time";
            this.barStaticItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barStaticItem1.Id = 46;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.chkSteadily);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMinus);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPlus);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Interactivity";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditCalendar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCurrent);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Set Date and Time";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LargeChange = 24;
            this.repositoryItemTrackBar1.Maximum = 8760;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(25, "25")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "1",
            "25"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "1",
            "25"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // chkPlay
            // 
            this.chkPlay.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.chkPlay.Id = 9;
            this.chkPlay.Name = "chkPlay";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "-1";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "+1";
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.AllowSnap = false;
            this.sidePanel2.Controls.Add(this.tabPaneOptions);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel2.Location = new System.Drawing.Point(300, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(200, 350);
            this.sidePanel2.TabIndex = 7;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneOptions.Location = new System.Drawing.Point(1, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(199, 350);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(199, 350);
            this.tabPaneOptions.TabIndex = 1;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(199, 317);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.projectionsList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(408, 359, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(199, 317);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // projectionsList
            // 
            this.projectionsList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.projectionsList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.projectionsList.FixedLineWidth = 1;
            this.projectionsList.HorzScrollStep = 2;
            this.projectionsList.KeyFieldName = "Name";
            this.projectionsList.Location = new System.Drawing.Point(0, 22);
            this.projectionsList.MinWidth = 16;
            this.projectionsList.Name = "projectionsList";
            this.projectionsList.OptionsBehavior.Editable = false;
            this.projectionsList.OptionsBehavior.ReadOnly = true;
            this.projectionsList.OptionsView.ShowIndentAsRowStyle = true;
            this.projectionsList.ParentFieldName = "ParentPrjName";
            this.projectionsList.Size = new System.Drawing.Size(199, 295);
            this.projectionsList.TabIndex = 0;
            this.projectionsList.TreeLevelWidth = 13;
            this.projectionsList.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
            this.projectionsList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnProjectionsListFocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 16;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 56;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(199, 317);
            this.Root.Text = "Projection";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.projectionsList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 295);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // sidePanelMain
            // 
            this.sidePanelMain.AllowResize = false;
            this.sidePanelMain.AllowSnap = false;
            this.sidePanelMain.Controls.Add(this.sidePanel3);
            this.sidePanelMain.Controls.Add(this.sidePanel2);
            this.sidePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanelMain.Location = new System.Drawing.Point(0, 150);
            this.sidePanelMain.Name = "sidePanelMain";
            this.sidePanelMain.Size = new System.Drawing.Size(500, 350);
            this.sidePanelMain.TabIndex = 6;
            this.sidePanelMain.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.mapControl1);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(0, 0);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(300, 350);
            this.sidePanel3.TabIndex = 0;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // mapControl1
            // 
            this.mapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.FileLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            this.mapControl1.Layers.Add(this.GridLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowZoomTrackbar = false;
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(300, 350);
            this.mapControl1.TabIndex = 5;
            this.GridLayer.Data = this.GridData;
            this.GridLayer.Name = "GridLayer";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.ShowGridBarCheckItem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ShowGridBarCheckItem
            // 
            this.ShowGridBarCheckItem.BindableChecked = true;
            this.ShowGridBarCheckItem.Caption = "Show Grid";
            this.ShowGridBarCheckItem.Checked = true;
            this.ShowGridBarCheckItem.Id = 8;
            this.ShowGridBarCheckItem.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.ShowGrid;
            this.ShowGridBarCheckItem.Name = "ShowGridBarCheckItem";
            this.ShowGridBarCheckItem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnShowGridCheckedChanged);
            // 
            // MapProjections
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanelMain);
            this.Name = "MapProjections";
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.sidePanelMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.sidePanelMain.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private XtraBars.BarButtonItem btnCurrent;
        private XtraBars.BarCheckItem chkPlay;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarEditItem barEditCalendar;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private XtraBars.BarCheckItem chkSteadily;
        private XtraBars.BarButtonItem btnMinus;
        private XtraBars.BarButtonItem btnPlus;
        private XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private MapControl mapControl1;
        private DevExpress.XtraTreeList.TreeList projectionsList;
        private XtraBars.BarStaticItem barStaticItem1;
        private XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private XtraBars.Navigation.TabPane tabPaneOptions;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private System.Windows.Forms.Timer timer;
        private VectorItemsLayer FileLayer;
        private ShapefileDataAdapter ShapefileDataAdapter;
        private VectorItemsLayer ItemsLayer;
        private MapItemStorage Data;
        private XtraEditors.SidePanel sidePanel2;
        private XtraEditors.SidePanel sidePanelMain;
        private XtraEditors.SidePanel sidePanel3;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private RibbonPageGroup ribbonPageGroup2;
        private RibbonPageGroup ribbonPageGroup1;
        private XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private RibbonPageGroup ribbonPageGroup3;
        private VectorItemsLayer GridLayer;
        private MapItemStorage GridData;
        private XtraBars.BarCheckItem ShowGridBarCheckItem;
    }
}
