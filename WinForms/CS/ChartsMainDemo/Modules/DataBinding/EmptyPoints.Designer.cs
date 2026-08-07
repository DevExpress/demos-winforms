namespace DevExpress.XtraCharts.Demos {
    partial class EmptyPointsDemo {
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane2 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY2 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.labelViewType = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupSeriesView = new DevExpress.XtraEditors.RadioGroup();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupViewType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeriesView = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeriesView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // labelViewType
            // 
            this.labelViewType.Location = new System.Drawing.Point(12, 12);
            this.labelViewType.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelViewType.Name = "labelViewType";
            this.labelViewType.Size = new System.Drawing.Size(53, 13);
            this.labelViewType.TabIndex = 58;
            this.labelViewType.Text = "View Type:";
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.radioGroupSeriesView);
            this.layoutControl.Controls.Add(this.checkEdit1);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(244, 313, 650, 400);
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // radioGroupSeriesView
            // 
            this.radioGroupSeriesView.AutoSizeInLayoutControl = true;
            this.radioGroupSeriesView.Location = new System.Drawing.Point(14, 36);
            this.radioGroupSeriesView.Name = "radioGroupSeriesView";
            this.radioGroupSeriesView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSeriesView.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSeriesView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupSeriesView.Properties.Columns = 1;
            this.radioGroupSeriesView.Size = new System.Drawing.Size(213, 8);
            this.radioGroupSeriesView.StyleController = this.layoutControl;
            this.radioGroupSeriesView.TabIndex = 4;
            this.radioGroupSeriesView.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(12, 92);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Display Empty Points";
            this.checkEdit1.Size = new System.Drawing.Size(217, 20);
            this.checkEdit1.StyleController = this.layoutControl;
            this.checkEdit1.TabIndex = 4;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupViewType,
            this.emptySpaceItem,
            this.layoutControlGroup1});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupViewType
            // 
            this.layoutControlGroupViewType.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupViewType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeriesView});
            this.layoutControlGroupViewType.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupViewType.Name = "layoutControlGroupViewType";
            this.layoutControlGroupViewType.Size = new System.Drawing.Size(241, 58);
            this.layoutControlGroupViewType.Text = "Series Views";
            // 
            // layoutControlItemSeriesView
            // 
            this.layoutControlItemSeriesView.Control = this.radioGroupSeriesView;
            this.layoutControlItemSeriesView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView";
            this.layoutControlItemSeriesView.Size = new System.Drawing.Size(217, 12);
            this.layoutControlItemSeriesView.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 414);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Empty Points";
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 58);
            this.layoutControlGroup1.Name = "layoutControlGroupLabel";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup1.Size = new System.Drawing.Size(241, 66);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Empty Points";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItemLabelVisible";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItemLabelVisible";
            this.layoutControlItem1.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.ShowOnlyInFocusedPane = false;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1";
            xyDiagram1.AxisY.Title.Text = "Wind, m/s";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagramPane1.Name = "Pane 1";
            xyDiagramPane1.PaneID = 0;
            xyDiagramPane2.Name = "Pane 2";
            xyDiagramPane2.PaneID = 1;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1,
            xyDiagramPane2});
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.GridLines.Visible = true;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.Title.Text = "Pressure, mmHg";
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            secondaryAxisY1.VisibleInPanesSerializable = "0";
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = false;
            secondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near;
            secondaryAxisY2.AxisID = 1;
            secondaryAxisY2.GridLines.Visible = true;
            secondaryAxisY2.Name = "Secondary AxisY 2";
            secondaryAxisY2.Title.Text = "Temperature, °C";
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            secondaryAxisY2.VisibleInPanesSerializable = "1";
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1,
            secondaryAxisY2});
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.CrosshairLabelPattern = "{S}: {V} m/s";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Wind";
            series1.SeriesID = 0;
            series1.ValueDataMembersSerializable = "Wind";
            series2.ArgumentDataMember = "Date";
            series2.CrosshairLabelPattern = "{S}: {V} mmHG";
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Pressure";
            series2.SeriesID = 1;
            series2.ValueDataMembersSerializable = "Pressure";
            sideBySideBarSeriesView1.AxisYName = "Secondary AxisY 1";
            sideBySideBarSeriesView1.PaneName = "Pane 1";
            series2.View = sideBySideBarSeriesView1;
            series3.ArgumentDataMember = "Date";
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series3.Name = "Temperature";
            series3.SeriesID = 2;
            series3.ValueDataMembersSerializable = "DayTemperature";
            sideBySideBarSeriesView2.AxisYName = "Secondary AxisY 2";
            sideBySideBarSeriesView2.PaneName = "Pane 2";
            series3.View = sideBySideBarSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Weather in Washington for July";
            chartTitle1.TitleID = 0;
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // EmptyPointsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "EmptyPointsDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeriesView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        System.ComponentModel.IContainer components = null;
        DevExpress.XtraEditors.LabelControl labelViewType;
        XtraLayout.LayoutControl layoutControl;
        XtraEditors.RadioGroup radioGroupSeriesView;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraLayout.LayoutControlGroup layoutControlGroupViewType;
        XtraLayout.LayoutControlItem layoutControlItemSeriesView;
        XtraLayout.EmptySpaceItem emptySpaceItem;
        ChartControl chart;
        private XtraEditors.CheckEdit checkEdit1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
