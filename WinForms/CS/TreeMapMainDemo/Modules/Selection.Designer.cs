namespace DevExpress.XtraTreeMap.Demos {
    partial class Selection {
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
            DevExpress.XtraMap.ChoroplethColorizer choroplethColorizer1 = new DevExpress.XtraMap.ChoroplethColorizer();
            DevExpress.XtraMap.LinearRangeDistribution linearRangeDistribution1 = new DevExpress.XtraMap.LinearRangeDistribution();
            DevExpress.XtraMap.ShapeAttributeValueProvider shapeAttributeValueProvider1 = new DevExpress.XtraMap.ShapeAttributeValueProvider();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView1 = new DevExpress.XtraCharts.SplineAreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            this.vectorItemsLayer1.Data = this.shapefileDataAdapter1;
            this.vectorItemsLayer1.EnableHighlighting = false;
            this.vectorItemsLayer1.EnableSelection = false;
            this.vectorItemsLayer1.Name = "BackgroundLayer";
            this.vectorItemsLayer1.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden;
            choroplethColorizer1.ApproximateColors = true;
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1;
            choroplethColorizer1.RangeStops.Add(0D);
            choroplethColorizer1.RangeStops.Add(13D);
            shapeAttributeValueProvider1.AttributeName = "MAP_COLOR";
            choroplethColorizer1.ValueProvider = shapeAttributeValueProvider1;
            this.vectorItemsLayer2.Colorizer = choroplethColorizer1;
            this.vectorItemsLayer2.Name = "FileLayer";
            // 
            // layoutControl
            // 
            this.layoutControl.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl.Controls.Add(this.label1);
            this.layoutControl.Controls.Add(this.chartControl1);
            this.layoutControl.Controls.Add(this.mapControl);
            this.layoutControl.Controls.Add(this.treeMapControl1);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(778, 293, 845, 627);
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(731, 522);
            this.layoutControl.TabIndex = 2;
            this.layoutControl.Text = "layoutControl1";
            this.layoutControl.ClientSizeChanged += new System.EventHandler(this.layoutControl_ClientSizeChanged);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(248, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.StyleController = this.layoutControl;
            this.label1.TabIndex = 10;
            this.label1.Text = "Top Countries By GDP";
            this.label1.UseMnemonic = false;
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,,,}B$";
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.DefaultPane.BorderVisible = false;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(367, 324);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Year";
            series1.CrosshairLabelPattern = "{S}: {V:#,,,}B$";
            series1.Name = "GDP";
            series1.ValueDataMembersSerializable = "GDP";
            splineAreaSeriesView1.Transparency = ((byte)(100));
            series1.View = splineAreaSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Size = new System.Drawing.Size(364, 198);
            this.chartControl1.TabIndex = 9;
            chartTitle1.Text = "GDP Dynamic";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(45D, 0D);
            this.mapControl.EnableAnimation = false;
            this.mapControl.EnableScrolling = false;
            this.mapControl.EnableZooming = false;
            this.mapControl.InitialMapSize = new System.Drawing.Size(340, 340);
            this.mapControl.Layers.Add(this.vectorItemsLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer2);
            this.mapControl.Location = new System.Drawing.Point(367, 37);
            this.mapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl.Name = "mapControl";
            this.mapControl.NavigationPanelOptions.Visible = false;
            this.mapControl.RenderMode = DevExpress.XtraMap.RenderMode.DirectX;
            this.mapControl.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl.Size = new System.Drawing.Size(364, 287);
            this.mapControl.TabIndex = 8;
            this.mapControl.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.mapControl_SelectionChanged);
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.Appearance.GroupStyle.SubGroupFill = System.Drawing.Color.Transparent;
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.treeMapControl1.BorderOptions.Visible = false;
            treeMapPaletteColorizer1.LegendItemPattern = null;
            treeMapPaletteColorizer1.Palette = new DevExpress.XtraTreeMap.Palette(new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(150)))), ((int)(((byte)(211))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(127)))), ((int)(((byte)(56))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(195)))), ((int)(((byte)(25))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(194))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(73))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(91)))), ((int)(((byte)(143))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(76)))), ((int)(((byte)(26))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(117)))), ((int)(((byte)(10))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(119))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(105)))), ((int)(((byte)(47))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(171)))), ((int)(((byte)(220))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(153)))), ((int)(((byte)(92))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(208)))), ((int)(((byte)(58))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(129)))), ((int)(((byte)(195)))))});
            this.treeMapControl1.Colorizer = treeMapPaletteColorizer1;
            treeMapFlatDataAdapter1.DataMember = null;
            treeMapFlatDataAdapter1.GroupDataMembersSerializable = "Continent";
            treeMapFlatDataAdapter1.LabelDataMember = "Name";
            treeMapFlatDataAdapter1.ValueDataMember = "GDP";
            this.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(0, 37);
            this.treeMapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.SelectionMode = DevExpress.XtraTreeMap.ElementSelectionMode.Single;
            this.treeMapControl1.Size = new System.Drawing.Size(367, 485);
            this.treeMapControl1.TabIndex = 7;
            this.treeMapControl1.SelectionChanged += new DevExpress.XtraTreeMap.SelectionChangedEventHandler(this.treeMapControl_SelectionChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(731, 522);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 37);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(367, 485);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.treeMapControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem4";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(367, 485);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(367, 37);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(364, 485);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mapControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.Name = "layoutControlItem3";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(364, 287);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.TrimClientAreaToControl = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chartControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 287);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem4.Name = "layoutControlItem5";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(364, 198);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(731, 37);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Selection
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl);
            this.Name = "Selection";
            this.Size = new System.Drawing.Size(731, 522);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraMap.MapControl mapControl;
        private XtraCharts.ChartControl chartControl1;
        private TreeMapControl treeMapControl1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.LabelControl label1;
        private XtraMap.VectorItemsLayer vectorItemsLayer1;
        private XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private XtraMap.VectorItemsLayer vectorItemsLayer2;
    }
}
