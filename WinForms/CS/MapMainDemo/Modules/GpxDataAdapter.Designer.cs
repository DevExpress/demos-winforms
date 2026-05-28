using DevExpress.Utils.Layout;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DevExpress.XtraMap.Demos {
    partial class GpxDataAdapterDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GpxDataAdapterDemo));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.GpxDataLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.gpxFileDataAdapter1 = new DevExpress.XtraMap.GpxFileDataAdapter();
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.mapControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tablePanel1);
            this.panelControl1.Size = new System.Drawing.Size(733, 332);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
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
            this.ribbonControl1.Size = new System.Drawing.Size(733, 150);
            // 
            // chartControl1
            // 
            this.chartControl1.AutoLayout = false;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.tablePanel1.SetColumn(this.chartControl1, 0);
            this.tablePanel1.SetColumnSpan(this.chartControl1, 4);
            this.chartControl1.CrosshairOptions.GroupHeaderPattern = "Distance : {A:F2} m";
            this.chartControl1.CrosshairOptions.ShowOnlyInFocusedPane = false;
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Title.Text = "Distance, m";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "Elevation, m";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.DefaultPane.BorderVisible = false;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.PaneDistance = 0;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Label.TextPattern = "{V:mm\\:ss}";
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.Reverse = true;
            secondaryAxisY1.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY1.Title.Text = "Pace, min/km";
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = false;
            secondaryAxisY2.AxisID = 1;
            secondaryAxisY2.Name = "Secondary AxisY 2";
            secondaryAxisY2.Title.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY2.Title.Text = "Heart Rate, BMP";
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.False;
            secondaryAxisY2.VisibleInPanesSerializable = "-1";
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1,
            secondaryAxisY2});
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Margins.Bottom = 2;
            this.chartControl1.Legend.Margins.Left = 2;
            this.chartControl1.Legend.Margins.Right = 2;
            this.chartControl1.Legend.Margins.Top = 2;
            this.chartControl1.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Padding.Bottom = 2;
            this.chartControl1.Legend.Padding.Left = 2;
            this.chartControl1.Legend.Padding.Right = 2;
            this.chartControl1.Legend.Padding.Top = 2;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(3, 213);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chartControl1.Name = "chartControl1";
            this.tablePanel1.SetRow(this.chartControl1, 1);
            this.chartControl1.RuntimeHitTesting = true;
            series1.ArgumentDataMember = "gpxdata:distance";
            series1.CrosshairLabelPattern = "{S} : {V:mm\\:ss}/km";
            series1.Name = "Pace";
            series1.ValueDataMembersSerializable = "Pace";
            series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan;
            lineSeriesView1.AxisYName = "Secondary AxisY 1";
            lineSeriesView1.LineMarkerOptions.Size = 6;
            series1.View = lineSeriesView1;
            series2.ArgumentDataMember = "gpxdata:distance";
            series2.CrosshairLabelPattern = "{S} : {V} BMP";
            series2.Name = "Heart Rate";
            series2.ValueDataMembersSerializable = "gpxtpx:hr";
            lineSeriesView2.AxisYName = "Secondary AxisY 2";
            lineSeriesView2.LineMarkerOptions.Size = 6;
            series2.View = lineSeriesView2;
            series3.ArgumentDataMember = "gpxdata:distance";
            series3.CrosshairLabelPattern = "{S} : {V:F2} m";
            series3.Name = "Elevation";
            series3.ValueDataMembersSerializable = "ele";
            areaSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            areaSeriesView1.Border.Thickness = 2;
            areaSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            areaSeriesView1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            areaSeriesView1.MarkerOptions.Size = 6;
            series3.View = areaSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartControl1.SeriesTemplate.LegendName = "Default Legend";
            this.chartControl1.Size = new System.Drawing.Size(727, 116);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.ValidateDataMembers = false;
            this.chartControl1.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.ChartControl1_CustomDrawCrosshair);
            this.chartControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartControl1_MouseMove);
            // 
            // mapControl1
            // 
            this.tablePanel1.SetColumn(this.mapControl1, 0);
            this.tablePanel1.SetColumnSpan(this.mapControl1, 4);
            this.mapControl1.Controls.Add(this.gridLookUpEdit1);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.GpxDataLayer);
            this.mapControl1.Layers.Add(this.vectorItemsLayer2);
            this.mapControl1.Location = new System.Drawing.Point(3, 3);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.mapControl1.Measurements.ShowToolbar = true;
            this.mapControl1.Measurements.ToolbarOptions.ShowAreaButton = false;
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.tablePanel1.SetRow(this.mapControl1, 0);
            this.mapControl1.Size = new System.Drawing.Size(727, 200);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 10D;
            this.mapControl1.OverlaysArranged += new DevExpress.XtraMap.OverlaysArrangedEventHandler(this.mapControl1_OverlaysArranged);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(10, 10);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(10);
            this.gridLookUpEdit1.MenuManager = this;
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "Title";
            this.gridLookUpEdit1.Properties.PopupSizeable = false;
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.ShowFooter = false;
            this.gridLookUpEdit1.Properties.EditValueChanged += new System.EventHandler(this.OnGridLookUpEditValueChanged);
            this.gridLookUpEdit1.Size = new System.Drawing.Size(472, 20);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            this.imageLayer1.DataProvider = this.AzureMapDataProvider;
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.GpxDataLayer.Data = this.gpxFileDataAdapter1;
            this.GpxDataLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(210)))));
            this.GpxDataLayer.ItemStyle.StrokeWidth = 5;
            this.GpxDataLayer.Name = "GpxDataLayer";
            this.GpxDataLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.VectorItemsLayer1_DataLoaded);
            this.vectorItemsLayer2.Data = this.mapItemStorage1;
            this.vectorItemsLayer2.EnableHighlighting = false;
            this.vectorItemsLayer2.EnableSelection = false;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.htmlContentControl1);
            this.tablePanel1.Controls.Add(this.chartControl1);
            this.tablePanel1.Controls.Add(this.mapControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)});
            this.tablePanel1.Size = new System.Drawing.Size(733, 332);
            this.tablePanel1.TabIndex = 0;
            // 
            // htmlContentControl1
            // 
            this.tablePanel1.SetColumn(this.htmlContentControl1, 0);
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.htmlContentControl1.HtmlImages = this.svgImageCollection1;
            // 
            // 
            // 
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.Location = new System.Drawing.Point(518, 15);
            this.htmlContentControl1.Margin = new System.Windows.Forms.Padding(15);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.tablePanel1.SetRow(this.htmlContentControl1, 0);
            this.htmlContentControl1.Size = new System.Drawing.Size(200, 178);
            this.htmlContentControl1.TabIndex = 2;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Pace", "image://svgimages/dashboards/gaugestylehalfcircular.svg");
            this.svgImageCollection1.Add("HeartRate", "image://svgimages/icon builder/shopping_favorites.svg");
            this.svgImageCollection1.Add("Duration", "image://svgimages/outlook inspired/employeequickprobationnotice.svg");
            this.svgImageCollection1.Add("Distance", "image://svgimages/richedit/rulerhorizontal.svg");
            // 
            // GpxDataAdapterDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GpxDataAdapterDemo";
            this.Size = new System.Drawing.Size(733, 500);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.mapControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MapControl mapControl1;
        private ImageLayer imageLayer1;
        private AzureMapDataProvider AzureMapDataProvider;
        private VectorItemsLayer GpxDataLayer;
        private GpxFileDataAdapter gpxFileDataAdapter1;
        private VectorItemsLayer vectorItemsLayer2;
        private MapItemStorage mapItemStorage1;
        private ChartControl chartControl1;
        private TablePanel tablePanel1;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private GridLookUpEdit gridLookUpEdit1;
        private XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Utils.SvgImageCollection svgImageCollection1;
        private HtmlContentControl htmlContentControl1;
    }
}
