namespace DevExpress.XtraSankey.Demos {
    partial class Interaction {
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
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.AttributeItemKeyProvider attributeItemKeyProvider1 = new DevExpress.XtraMap.AttributeItemKeyProvider();
            DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm sankeyLinearLayoutAlgorithm1 = new DevExpress.XtraCharts.Sankey.SankeyLinearLayoutAlgorithm();
            DevExpress.XtraCharts.Sankey.SankeyTitle sankeyTitle1 = new DevExpress.XtraCharts.Sankey.SankeyTitle();
            DevExpress.XtraCharts.Sankey.SankeyTitle sankeyTitle2 = new DevExpress.XtraCharts.Sankey.SankeyTitle();
            DevExpress.XtraCharts.Sankey.SankeyTitle sankeyTitle3 = new DevExpress.XtraCharts.Sankey.SankeyTitle();
            this.sidePanelRightRoot = new DevExpress.XtraEditors.SidePanel();
            this.sidePanelRight1 = new DevExpress.XtraEditors.SidePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sidePanelRight2 = new DevExpress.XtraEditors.SidePanel();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.backgroundLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.interactableItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.sankeyDiagramControl1 = new DevExpress.XtraCharts.Sankey.SankeyDiagramControl();
            this.sidePanelLeftRoot = new DevExpress.XtraEditors.SidePanel();
            this.sidePanelRightRoot.SuspendLayout();
            this.sidePanelRight1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanelRight2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.sidePanelLeftRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanelRightRoot
            // 
            this.sidePanelRightRoot.Controls.Add(this.sidePanelRight1);
            this.sidePanelRightRoot.Controls.Add(this.sidePanelRight2);
            this.sidePanelRightRoot.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelRightRoot.Location = new System.Drawing.Point(620, 0);
            this.sidePanelRightRoot.Name = "sidePanelRightRoot";
            this.sidePanelRightRoot.Size = new System.Drawing.Size(400, 649);
            this.sidePanelRightRoot.TabIndex = 1;
            this.sidePanelRightRoot.Text = "sidePanel1";
            // 
            // sidePanelRight1
            // 
            this.sidePanelRight1.Controls.Add(this.gridControl1);
            this.sidePanelRight1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanelRight1.Location = new System.Drawing.Point(1, 300);
            this.sidePanelRight1.Name = "sidePanelRight1";
            this.sidePanelRight1.Size = new System.Drawing.Size(399, 349);
            this.sidePanelRight1.TabIndex = 1;
            this.sidePanelRight1.Text = "sidePanel1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(399, 349);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.OnGridSelectionChanged);
            // 
            // sidePanelRight2
            // 
            this.sidePanelRight2.Controls.Add(this.mapControl1);
            this.sidePanelRight2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanelRight2.Location = new System.Drawing.Point(1, 0);
            this.sidePanelRight2.Name = "sidePanelRight2";
            this.sidePanelRight2.Size = new System.Drawing.Size(399, 300);
            this.sidePanelRight2.TabIndex = 0;
            this.sidePanelRight2.Text = "sidePanel1";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(40D, 0D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.EnableAnimation = false;
            this.mapControl1.EnableRotation = false;
            this.mapControl1.Layers.Add(this.backgroundLayer);
            this.mapControl1.Layers.Add(this.interactableItemsLayer);
            this.mapControl1.Layers.Add(this.vectorItemsLayer2);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 3D;
            this.mapControl1.MinZoomLevel = 0.5D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.RenderMode = DevExpress.XtraMap.RenderMode.GdiPlus;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Multiple;
            this.mapControl1.Size = new System.Drawing.Size(399, 299);
            this.mapControl1.TabIndex = 5;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.OnMapSelectionChanged);
            this.mapControl1.Resize += new System.EventHandler(this.mapControl1_Resize);
            this.backgroundLayer.EnableHighlighting = false;
            this.backgroundLayer.EnableSelection = false;
            this.backgroundLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            attributeItemKeyProvider1.AttributeName = "CONTINENT";
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1;
            this.interactableItemsLayer.Colorizer = keyColorColorizer1;
            this.interactableItemsLayer.Data = this.shapefileDataAdapter1;
            this.interactableItemsLayer.EnableHighlighting = false;
            this.shapefileDataAdapter1.ItemsLoaded += new DevExpress.XtraMap.ItemsLoadedEventHandler(this.Adapter_ItemsLoaded);
            this.vectorItemsLayer2.Data = this.mapItemStorage1;
            this.vectorItemsLayer2.EnableHighlighting = false;
            this.vectorItemsLayer2.EnableSelection = false;
            // 
            // sankeyDiagramControl1
            // 
            this.sankeyDiagramControl1.BorderOptions.Thickness = 0;
            this.sankeyDiagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            sankeyLinearLayoutAlgorithm1.NodeAlignment = DevExpress.XtraCharts.Sankey.SankeyNodeAlignment.Near;
            this.sankeyDiagramControl1.LayoutAlgorithm = sankeyLinearLayoutAlgorithm1;
            this.sankeyDiagramControl1.Location = new System.Drawing.Point(0, 0);
            this.sankeyDiagramControl1.Name = "sankeyDiagramControl1";
            this.sankeyDiagramControl1.SelectionMode = DevExpress.XtraCharts.Sankey.SankeySelectionMode.Multiple;
            this.sankeyDiagramControl1.Size = new System.Drawing.Size(620, 649);
            this.sankeyDiagramControl1.SourceDataMember = "Exporter";
            this.sankeyDiagramControl1.TabIndex = 4;
            this.sankeyDiagramControl1.TargetDataMember = "Importer";
            this.sankeyDiagramControl1.Text = "sankeyDiagramControl1";
            sankeyTitle1.Text = "Major oil trade movements";
            sankeyTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            sankeyTitle2.Text = "Trade flows worldwide (million tonnes)";
            sankeyTitle3.Dock = DevExpress.XtraCharts.Sankey.SankeyTitleDockStyle.Bottom;
            sankeyTitle3.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8F);
            sankeyTitle3.Text = "bp Statistical Review of World Energy 2020";
            sankeyTitle3.TextAlignment = System.Drawing.StringAlignment.Far;
            sankeyTitle3.TextColor = System.Drawing.Color.Gray;
            this.sankeyDiagramControl1.Titles.Add(sankeyTitle1);
            this.sankeyDiagramControl1.Titles.Add(sankeyTitle2);
            this.sankeyDiagramControl1.Titles.Add(sankeyTitle3);
            this.sankeyDiagramControl1.WeightDataMember = "Sum";
            this.sankeyDiagramControl1.CustomizeNodeToolTip += new DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventHandler(this.OnCustomizeNodeToolTip);
            this.sankeyDiagramControl1.CustomizeLinkToolTip += new DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventHandler(this.OnCustomizeLinkToolTip);
            this.sankeyDiagramControl1.HighlightedItemsChanged += new DevExpress.XtraCharts.Sankey.SankeyHighlightedItemsChangedEventHandler(this.OnSankeyHighlightedItemsChanged);
            this.sankeyDiagramControl1.SelectedItemsChanged += new DevExpress.XtraCharts.Sankey.SankeySelectedItemsChangedEventHandler(this.OnSankeySelectedItemsChanged);
            // 
            // sidePanelLeftRoot
            // 
            this.sidePanelLeftRoot.Controls.Add(this.sankeyDiagramControl1);
            this.sidePanelLeftRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanelLeftRoot.Location = new System.Drawing.Point(0, 0);
            this.sidePanelLeftRoot.Name = "sidePanelLeftRoot";
            this.sidePanelLeftRoot.Size = new System.Drawing.Size(620, 649);
            this.sidePanelLeftRoot.TabIndex = 2;
            this.sidePanelLeftRoot.Text = "sidePanel1";
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanelLeftRoot);
            this.Controls.Add(this.sidePanelRightRoot);
            this.Name = "Interaction";
            this.Size = new System.Drawing.Size(1020, 649);
            this.sidePanelRightRoot.ResumeLayout(false);
            this.sidePanelRight1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanelRight2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.sidePanelLeftRoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private XtraEditors.SidePanel sidePanelRightRoot;
        private XtraEditors.SidePanel sidePanelRight1;
        private XtraEditors.SidePanel sidePanelRight2;
        private XtraEditors.SidePanel sidePanelLeftRoot;
        private XtraCharts.Sankey.SankeyDiagramControl sankeyDiagramControl1;
        private XtraMap.MapControl mapControl1;
        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private XtraMap.VectorItemsLayer interactableItemsLayer;
        private XtraMap.VectorItemsLayer vectorItemsLayer2;
        private XtraMap.MapItemStorage mapItemStorage1;
        private XtraMap.VectorItemsLayer backgroundLayer;
        private XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
    }
}
