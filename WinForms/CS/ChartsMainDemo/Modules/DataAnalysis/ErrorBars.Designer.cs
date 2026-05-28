namespace DevExpress.XtraCharts.Demos {
    partial class ErrorBarsDemo {
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
            this.dataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupEndStyle = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupDirection = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupErrorBarsKind = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupSeriesView = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupDirection = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemDirection = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupErrorBarKind = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemErrorBarKind = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupSeriesView = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeriesView = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupEndStyle = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemEndStyle = new DevExpress.XtraLayout.LayoutControlItem();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEndStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupErrorBarsKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeriesView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupErrorBarKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemErrorBarKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupEndStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEndStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 544);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "ChartDataSource";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Argument";
            this.dataColumn1.ColumnName = "Argument";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Value";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "PositiveError";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NegativeError";
            this.dataColumn4.DataType = typeof(double);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.radioGroupEndStyle);
            this.layoutControl.Controls.Add(this.radioGroupDirection);
            this.layoutControl.Controls.Add(this.radioGroupErrorBarsKind);
            this.layoutControl.Controls.Add(this.radioGroupSeriesView);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 544);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // radioGroupEndStyle
            // 
            this.radioGroupEndStyle.AutoSizeInLayoutControl = true;
            this.radioGroupEndStyle.EditValue = 0;
            this.radioGroupEndStyle.Location = new System.Drawing.Point(12, 259);
            this.radioGroupEndStyle.Name = "radioGroupEndStyle";
            this.radioGroupEndStyle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupEndStyle.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupEndStyle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupEndStyle.Properties.Columns = 1;
            this.radioGroupEndStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Cap"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "No Cap")});
            this.radioGroupEndStyle.Size = new System.Drawing.Size(217, 38);
            this.radioGroupEndStyle.StyleController = this.layoutControl;
            this.radioGroupEndStyle.TabIndex = 17;
            this.radioGroupEndStyle.SelectedIndexChanged += new System.EventHandler(this.radioGroupEndStyle_SelectedIndexChanged);
            // 
            // radioGroupDirection
            // 
            this.radioGroupDirection.AutoSizeInLayoutControl = true;
            this.radioGroupDirection.EditValue = 0;
            this.radioGroupDirection.Location = new System.Drawing.Point(12, 163);
            this.radioGroupDirection.Name = "radioGroupDirection";
            this.radioGroupDirection.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupDirection.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupDirection.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupDirection.Properties.Columns = 1;
            this.radioGroupDirection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Both"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Minus"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Plus")});
            this.radioGroupDirection.Size = new System.Drawing.Size(217, 53);
            this.radioGroupDirection.StyleController = this.layoutControl;
            this.radioGroupDirection.TabIndex = 18;
            this.radioGroupDirection.SelectedIndexChanged += new System.EventHandler(this.radioGroupDirection_SelectedIndexChanged);
            // 
            // radioGroupErrorBarsKind
            // 
            this.radioGroupErrorBarsKind.AutoSizeInLayoutControl = true;
            this.radioGroupErrorBarsKind.Location = new System.Drawing.Point(12, 112);
            this.radioGroupErrorBarsKind.Name = "radioGroupErrorBarsKind";
            this.radioGroupErrorBarsKind.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupErrorBarsKind.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupErrorBarsKind.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupErrorBarsKind.Properties.Columns = 1;
            this.radioGroupErrorBarsKind.Size = new System.Drawing.Size(217, 8);
            this.radioGroupErrorBarsKind.StyleController = this.layoutControl;
            this.radioGroupErrorBarsKind.TabIndex = 16;
            this.radioGroupErrorBarsKind.SelectedIndexChanged += new System.EventHandler(this.radioGroupErrorBarsKind_SelectedIndexChanged);
            // 
            // radioGroupSeriesView
            // 
            this.radioGroupSeriesView.AutoSizeInLayoutControl = true;
            this.radioGroupSeriesView.EditValue = 0;
            this.radioGroupSeriesView.Location = new System.Drawing.Point(12, 31);
            this.radioGroupSeriesView.Name = "radioGroupSeriesView";
            this.radioGroupSeriesView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSeriesView.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSeriesView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupSeriesView.Properties.Columns = 1;
            this.radioGroupSeriesView.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Bar"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Point")});
            this.radioGroupSeriesView.Size = new System.Drawing.Size(217, 38);
            this.radioGroupSeriesView.StyleController = this.layoutControl;
            this.radioGroupSeriesView.TabIndex = 15;
            this.radioGroupSeriesView.SelectedIndexChanged += new System.EventHandler(this.radioGroupSeriesView_SelectedIndexChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupDirection,
            this.layoutControlGroupErrorBarKind,
            this.layoutControlGroupSeriesView,
            this.emptySpaceItem1,
            this.layoutControlGroupEndStyle});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 544);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupDirection
            // 
            this.layoutControlGroupDirection.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupDirection.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemDirection});
            this.layoutControlGroupDirection.Location = new System.Drawing.Point(0, 132);
            this.layoutControlGroupDirection.Name = "layoutControlGroupDirection";
            this.layoutControlGroupDirection.Size = new System.Drawing.Size(241, 96);
            this.layoutControlGroupDirection.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupDirection.Text = "Direction";
            // 
            // layoutControlItemDirection
            // 
            this.layoutControlItemDirection.Control = this.radioGroupDirection;
            this.layoutControlItemDirection.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemDirection.Name = "layoutControlItemDirection";
            this.layoutControlItemDirection.Size = new System.Drawing.Size(221, 57);
            this.layoutControlItemDirection.Text = "Direction:";
            this.layoutControlItemDirection.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemDirection.TextVisible = false;
            // 
            // layoutControlGroupErrorBarKind
            // 
            this.layoutControlGroupErrorBarKind.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupErrorBarKind.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemErrorBarKind});
            this.layoutControlGroupErrorBarKind.Location = new System.Drawing.Point(0, 81);
            this.layoutControlGroupErrorBarKind.Name = "layoutControlGroupErrorBarKind";
            this.layoutControlGroupErrorBarKind.Size = new System.Drawing.Size(241, 51);
            this.layoutControlGroupErrorBarKind.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupErrorBarKind.Text = "Error Bar Kind";
            // 
            // layoutControlItemErrorBarKind
            // 
            this.layoutControlItemErrorBarKind.Control = this.radioGroupErrorBarsKind;
            this.layoutControlItemErrorBarKind.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemErrorBarKind.Name = "layoutControlItemErrorBarKind";
            this.layoutControlItemErrorBarKind.Size = new System.Drawing.Size(221, 12);
            this.layoutControlItemErrorBarKind.Text = "Error Bar Kind:";
            this.layoutControlItemErrorBarKind.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemErrorBarKind.TextVisible = false;
            // 
            // layoutControlGroupSeriesView
            // 
            this.layoutControlGroupSeriesView.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupSeriesView.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeriesView});
            this.layoutControlGroupSeriesView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupSeriesView.Name = "layoutControlGroupSeriesView";
            this.layoutControlGroupSeriesView.Size = new System.Drawing.Size(241, 81);
            this.layoutControlGroupSeriesView.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupSeriesView.Text = "SeriesV iew";
            // 
            // layoutControlItemSeriesView
            // 
            this.layoutControlItemSeriesView.Control = this.radioGroupSeriesView;
            this.layoutControlItemSeriesView.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeriesView.Name = "layoutControlItemSeriesView";
            this.layoutControlItemSeriesView.Size = new System.Drawing.Size(221, 42);
            this.layoutControlItemSeriesView.Text = "Series View";
            this.layoutControlItemSeriesView.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSeriesView.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 309);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(241, 235);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupEndStyle
            // 
            this.layoutControlGroupEndStyle.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupEndStyle.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemEndStyle});
            this.layoutControlGroupEndStyle.Location = new System.Drawing.Point(0, 228);
            this.layoutControlGroupEndStyle.Name = "layoutControlGroupEndStyle";
            this.layoutControlGroupEndStyle.Size = new System.Drawing.Size(241, 81);
            this.layoutControlGroupEndStyle.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupEndStyle.Text = "End Style";
            // 
            // layoutControlItemEndStyle
            // 
            this.layoutControlItemEndStyle.Control = this.radioGroupEndStyle;
            this.layoutControlItemEndStyle.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemEndStyle.Name = "layoutControlItemEndStyle";
            this.layoutControlItemEndStyle.Size = new System.Drawing.Size(221, 42);
            this.layoutControlItemEndStyle.Text = "End Style:";
            this.layoutControlItemEndStyle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemEndStyle.TextVisible = false;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "65";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Table1.Argument";
            series1.DataSource = this.dataSet;
            series1.LegendName = "Default Legend";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Table1.Value";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LegendName = "Default Legend";
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 3;
            // 
            // ErrorBarsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ErrorBarsDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEndStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupErrorBarsKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeriesView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupErrorBarKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemErrorBarKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupEndStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEndStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        XtraLayout.LayoutControl layoutControl;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraLayout.LayoutControlItem layoutControlItemDirection;
        XtraLayout.LayoutControlItem layoutControlItemEndStyle;
        XtraLayout.LayoutControlItem layoutControlItemErrorBarKind;
        XtraLayout.LayoutControlItem layoutControlItemSeriesView;
        System.Data.DataSet dataSet;
        System.Data.DataTable dataTable1;
        System.Data.DataColumn dataColumn1;
        System.Data.DataColumn dataColumn2;
        System.Data.DataColumn dataColumn3;
        System.Data.DataColumn dataColumn4;
        XtraEditors.RadioGroup radioGroupEndStyle;
        XtraEditors.RadioGroup radioGroupDirection;
        XtraEditors.RadioGroup radioGroupErrorBarsKind;
        XtraEditors.RadioGroup radioGroupSeriesView;
        XtraLayout.LayoutControlGroup layoutControlGroupEndStyle;
        XtraLayout.LayoutControlGroup layoutControlGroupDirection;
        XtraLayout.LayoutControlGroup layoutControlGroupErrorBarKind;
        XtraLayout.LayoutControlGroup layoutControlGroupSeriesView;
        ChartControl chart;
        XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
