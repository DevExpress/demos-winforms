using DevExpress.XtraCharts;

namespace DevExpress.SalesDemo.Win.Modules {
    partial class ucSalesByRange {
        
        
        
        private System.ComponentModel.IContainer components = null;

        
        
        
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        
        
        
        
        private void InitializeComponent() {
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel2 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.rangeControl = new DevExpress.XtraEditors.RangeControl();
            this.pieChart = new DevExpress.XtraCharts.ChartControl();
            this.ucSalesByRangelayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.barChart = new DevExpress.XtraCharts.ChartControl();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBarChart = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPieChart = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRangeControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnPrev = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBtnNext = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSalesByRangelayoutControl1ConvertedLayout)).BeginInit();
            this.ucSalesByRangelayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNext)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.rangeControl.Client = this.pieChart;
            this.rangeControl.Location = new System.Drawing.Point(52, 348);
            this.rangeControl.Name = "rangeControl";
            rangeControlRange1.Maximum = 4.5D;
            rangeControlRange1.Minimum = -0.5D;
            rangeControlRange1.Owner = this.rangeControl;
            this.rangeControl.SelectedRange = rangeControlRange1;
            this.rangeControl.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag;
            this.rangeControl.ShowToolTips = false;
            this.rangeControl.ShowZoomScrollBar = false;
            this.rangeControl.Size = new System.Drawing.Size(730, 111);
            this.rangeControl.StyleController = this.ucSalesByRangelayoutControl1ConvertedLayout;
            this.rangeControl.TabIndex = 1;
            this.rangeControl.Text = "rangeControl1";
            this.rangeControl.VisibleRangeMaximumScaleFactor = 1D;
            
            
            
            this.pieChart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.pieChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pieChart.DataBindings = null;
            this.pieChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.pieChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pieChart.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.pieChart.Legend.EquallySpacedItems = false;
            this.pieChart.Legend.MarkerSize = new System.Drawing.Size(18, 18);
            this.pieChart.Legend.Name = "Default Legend";
            this.pieChart.Legend.Padding.Bottom = 10;
            this.pieChart.Legend.Padding.Left = 10;
            this.pieChart.Legend.Padding.Right = 10;
            this.pieChart.Legend.Padding.Top = 10;
            this.pieChart.Legend.TextOffset = 8;
            this.pieChart.Legend.VerticalIndent = 12;
            this.pieChart.Location = new System.Drawing.Point(2, 2);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding.Right = 0;
            series1.ArgumentDataMember = "GroupName";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesLabel1.TextPattern = "{VP:P0}";
            series1.Label = doughnutSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "TotalCost";
            doughnutSeriesView1.HoleRadiusPercent = 45;
            series1.View = doughnutSeriesView1;
            this.pieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            doughnutSeriesLabel2.TextPattern = "{VP:G2}";
            this.pieChart.SeriesTemplate.Label = doughnutSeriesLabel2;
            this.pieChart.SeriesTemplate.View = doughnutSeriesView2;
            this.pieChart.Size = new System.Drawing.Size(414, 342);
            this.pieChart.TabIndex = 2;
            
            
            
            this.ucSalesByRangelayoutControl1ConvertedLayout.AllowCustomization = false;
            this.ucSalesByRangelayoutControl1ConvertedLayout.Controls.Add(this.barChart);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Controls.Add(this.pieChart);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Controls.Add(this.rangeControl);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Controls.Add(this.btnPrev);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Controls.Add(this.btnNext);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSalesByRangelayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ucSalesByRangelayoutControl1ConvertedLayout.Name = "ucSalesByRangelayoutControl1ConvertedLayout";
            this.ucSalesByRangelayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1032, 574, 650, 400);
            this.ucSalesByRangelayoutControl1ConvertedLayout.OptionsView.UseParentAutoScaleFactor = true;
            this.ucSalesByRangelayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.ucSalesByRangelayoutControl1ConvertedLayout.Size = new System.Drawing.Size(836, 461);
            this.ucSalesByRangelayoutControl1ConvertedLayout.TabIndex = 2;
            
            
            
            this.barChart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.barChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.DataBindings = null;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisX.Reverse = true;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Margins.Left = 38;
            xyDiagram1.Margins.Right = 2;
            xyDiagram1.Rotated = true;
            this.barChart.Diagram = xyDiagram1;
            this.barChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.barChart.Legend.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None;
            this.barChart.Legend.MarkerSize = new System.Drawing.Size(1, 16);
            this.barChart.Legend.Name = "Default Legend";
            this.barChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.Location = new System.Drawing.Point(420, 2);
            this.barChart.Margin = new System.Windows.Forms.Padding(0);
            this.barChart.Name = "barChart";
            this.barChart.Padding.Bottom = 24;
            this.barChart.Padding.Left = 0;
            this.barChart.Padding.Right = 0;
            this.barChart.Padding.Top = 24;
            series2.ArgumentDataMember = "GroupName";
            sideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel1.Indent = 4;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside;
            sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.White;
            sideBySideBarSeriesLabel1.TextPattern = "{V:N0}";
            series2.Label = sideBySideBarSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendTextPattern = "{V:N1}";
            series2.Name = "Series 1";
            series2.ValueDataMembersSerializable = "TotalCost";
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesView1.ColorEach = true;
            series2.View = sideBySideBarSeriesView1;
            this.barChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.barChart.Size = new System.Drawing.Size(414, 342);
            this.barChart.TabIndex = 6;
            
            
            
            this.btnPrev.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(2, 348);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 111);
            this.btnPrev.StyleController = this.ucSalesByRangelayoutControl1ConvertedLayout;
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            
            
            
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(786, 348);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 111);
            this.btnNext.StyleController = this.ucSalesByRangelayoutControl1ConvertedLayout;
            this.btnNext.TabIndex = 3;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            
            
            
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(836, 461);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBarChart,
            this.lciPieChart,
            this.layoutControlGroup3});
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "tableLayoutPanelitem";
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 50D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 50D;
            this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition5,
            columnDefinition6});
            rowDefinition2.Height = 75D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 25D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2,
            rowDefinition3});
            this.layoutControlGroup2.Size = new System.Drawing.Size(836, 461);
            
            
            
            this.lciBarChart.Control = this.barChart;
            this.lciBarChart.Location = new System.Drawing.Point(418, 0);
            this.lciBarChart.Name = "lciBarChart";
            this.lciBarChart.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciBarChart.Size = new System.Drawing.Size(418, 346);
            this.lciBarChart.TextSize = new System.Drawing.Size(0, 0);
            this.lciBarChart.TextVisible = false;
            
            
            
            this.lciPieChart.Control = this.pieChart;
            this.lciPieChart.Location = new System.Drawing.Point(0, 0);
            this.lciPieChart.Name = "lciPieChart";
            this.lciPieChart.Size = new System.Drawing.Size(418, 346);
            this.lciPieChart.TextSize = new System.Drawing.Size(0, 0);
            this.lciPieChart.TextVisible = false;
            
            
            
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRangeControl,
            this.lciBtnPrev,
            this.lciBtnNext});
            this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 346);
            this.layoutControlGroup3.Name = "tableLayoutPanel1item";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 50D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 2D;
            this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.layoutControlGroup3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlGroup3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup3.Size = new System.Drawing.Size(836, 115);
            
            
            
            this.lciRangeControl.Control = this.rangeControl;
            this.lciRangeControl.Location = new System.Drawing.Point(50, 0);
            this.lciRangeControl.MinSize = new System.Drawing.Size(54, 20);
            this.lciRangeControl.Name = "lciRangeControl";
            this.lciRangeControl.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciRangeControl.Size = new System.Drawing.Size(734, 115);
            this.lciRangeControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRangeControl.TextSize = new System.Drawing.Size(0, 0);
            this.lciRangeControl.TextVisible = false;
            
            
            
            this.lciBtnPrev.Control = this.btnPrev;
            this.lciBtnPrev.Location = new System.Drawing.Point(0, 0);
            this.lciBtnPrev.MinSize = new System.Drawing.Size(20, 24);
            this.lciBtnPrev.Name = "lciBtnPrev";
            this.lciBtnPrev.Size = new System.Drawing.Size(50, 115);
            this.lciBtnPrev.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnPrev.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnPrev.TextVisible = false;
            
            
            
            this.lciBtnNext.Control = this.btnNext;
            this.lciBtnNext.Location = new System.Drawing.Point(784, 0);
            this.lciBtnNext.MinSize = new System.Drawing.Size(20, 24);
            this.lciBtnNext.Name = "lciBtnNext";
            this.lciBtnNext.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciBtnNext.Size = new System.Drawing.Size(50, 115);
            this.lciBtnNext.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBtnNext.TextSize = new System.Drawing.Size(0, 0);
            this.lciBtnNext.TextVisible = false;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucSalesByRangelayoutControl1ConvertedLayout);
            this.Name = "ucSalesByRange";
            this.Size = new System.Drawing.Size(836, 461);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSalesByRangelayoutControl1ConvertedLayout)).EndInit();
            this.ucSalesByRangelayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBtnNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraCharts.ChartControl pieChart;
        private XtraEditors.RangeControl rangeControl;
        private XtraCharts.ChartControl barChart;
        private XtraEditors.SimpleButton btnNext;
        private XtraEditors.SimpleButton btnPrev;
        private XtraLayout.LayoutControl ucSalesByRangelayoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem lciBarChart;
        private XtraLayout.LayoutControlItem lciPieChart;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem lciRangeControl;
        private XtraLayout.LayoutControlItem lciBtnPrev;
        private XtraLayout.LayoutControlItem lciBtnNext;
    }
}
