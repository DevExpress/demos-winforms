namespace DevExpress.XtraCharts.Demos {
    partial class CustomPaintDemo {
        System.ComponentModel.IContainer components = null;

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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.toggleSwitchClusteringMode = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButtonGeneratePoints = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonClearClusters = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupClusteringMode = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemClusteringMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemGeneratePoints = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemClearClusters = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchClusteringMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupClusteringMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemClusteringMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGeneratePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemClearClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CacheToMemory = true;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Arguments";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.MinorCount = 4;
            xyDiagram1.AxisY.Title.Text = "Values";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Multiple;
            this.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point;
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 6F);
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            pointSeriesLabel1.TextPattern = "{V:F2}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Random Series";
            series1.View = pointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 3;
            chartTitle1.Text = "Random Points Generator";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.SelectedItemsChanging += new DevExpress.XtraCharts.SelectedItemsChangingEventHandler(this.chart_SelectedItemsChanging);
            this.chart.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectHotTracked);
            this.chart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chart_CustomPaint);
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.toggleSwitchClusteringMode);
            this.layoutControl.Controls.Add(this.simpleButtonGeneratePoints);
            this.layoutControl.Controls.Add(this.simpleButtonClearClusters);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // toggleSwitchClusteringMode
            // 
            this.toggleSwitchClusteringMode.EditValue = true;
            this.toggleSwitchClusteringMode.Location = new System.Drawing.Point(12, 34);
            this.toggleSwitchClusteringMode.Name = "toggleSwitchClusteringMode";
            this.toggleSwitchClusteringMode.Properties.OffText = "Manual";
            this.toggleSwitchClusteringMode.Properties.OnText = "Automatic";
            this.toggleSwitchClusteringMode.Size = new System.Drawing.Size(217, 18);
            this.toggleSwitchClusteringMode.StyleController = this.layoutControl;
            this.toggleSwitchClusteringMode.TabIndex = 4;
            this.toggleSwitchClusteringMode.Toggled += new System.EventHandler(this.toggleSwitchClusteringMode_Toggled);
            // 
            // simpleButtonGeneratePoints
            // 
            this.simpleButtonGeneratePoints.Location = new System.Drawing.Point(2, 74);
            this.simpleButtonGeneratePoints.Name = "simpleButtonGeneratePoints";
            this.simpleButtonGeneratePoints.Size = new System.Drawing.Size(237, 22);
            this.simpleButtonGeneratePoints.StyleController = this.layoutControl;
            this.simpleButtonGeneratePoints.TabIndex = 5;
            this.simpleButtonGeneratePoints.Text = "Generate Points";
            this.simpleButtonGeneratePoints.Click += new System.EventHandler(this.simpleButtonGeneratePoints_Click);
            // 
            // simpleButtonClearClusters
            // 
            this.simpleButtonClearClusters.Location = new System.Drawing.Point(2, 108);
            this.simpleButtonClearClusters.Name = "simpleButtonClearClusters";
            this.simpleButtonClearClusters.Size = new System.Drawing.Size(237, 22);
            this.simpleButtonClearClusters.StyleController = this.layoutControl;
            this.simpleButtonClearClusters.TabIndex = 6;
            this.simpleButtonClearClusters.Text = "Clear Clusters";
            this.simpleButtonClearClusters.Click += new System.EventHandler(this.simpleButtonClearClusters_Click);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroupClusteringMode,
            this.layoutControlItemGeneratePoints,
            this.layoutControlItemClearClusters});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(241, 406);
            // 
            // layoutControlGroupClusteringMode
            // 
            this.layoutControlGroupClusteringMode.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupClusteringMode.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemClusteringMode});
            this.layoutControlGroupClusteringMode.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupClusteringMode.Name = "layoutControlGroupClusteringMode";
            this.layoutControlGroupClusteringMode.Size = new System.Drawing.Size(241, 64);
            this.layoutControlGroupClusteringMode.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupClusteringMode.Text = "Clustering Mode";
            // 
            // layoutControlItemClusteringMode
            // 
            this.layoutControlItemClusteringMode.Control = this.toggleSwitchClusteringMode;
            this.layoutControlItemClusteringMode.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemClusteringMode.Name = "layoutControlItemClusteringMode";
            this.layoutControlItemClusteringMode.Size = new System.Drawing.Size(221, 22);
            this.layoutControlItemClusteringMode.TextVisible = false;
            // 
            // layoutControlItemGeneratePoints
            // 
            this.layoutControlItemGeneratePoints.Control = this.simpleButtonGeneratePoints;
            this.layoutControlItemGeneratePoints.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItemGeneratePoints.Name = "layoutControlItemGeneratePoints";
            this.layoutControlItemGeneratePoints.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItemGeneratePoints.Size = new System.Drawing.Size(241, 34);
            this.layoutControlItemGeneratePoints.Text = "Generate Points";
            this.layoutControlItemGeneratePoints.TextVisible = false;
            // 
            // layoutControlItemClearClusters
            // 
            this.layoutControlItemClearClusters.Control = this.simpleButtonClearClusters;
            this.layoutControlItemClearClusters.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItemClearClusters.Name = "layoutControlItemClearClusters";
            this.layoutControlItemClearClusters.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItemClearClusters.Size = new System.Drawing.Size(241, 34);
            this.layoutControlItemClearClusters.TextVisible = false;
            // 
            // CustomPaintDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "CustomPaintDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchClusteringMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupClusteringMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemClusteringMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGeneratePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemClearClusters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        XtraLayout.LayoutControl layoutControl;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraEditors.ToggleSwitch toggleSwitchClusteringMode;
        XtraEditors.SimpleButton simpleButtonGeneratePoints;
        XtraLayout.EmptySpaceItem emptySpaceItem1;
        XtraLayout.LayoutControlGroup layoutControlGroupClusteringMode;
        XtraLayout.LayoutControlItem layoutControlItemClusteringMode;
        XtraLayout.LayoutControlItem layoutControlItemGeneratePoints;
        XtraEditors.SimpleButton simpleButtonClearClusters;
        XtraLayout.LayoutControlItem layoutControlItemClearClusters;
    }
}
