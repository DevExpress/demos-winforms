namespace DevExpress.XtraCharts.Demos {
    partial class ScaleBreaksDemo {
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
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Mercury", new object[] {
            ((object)(0.06D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Venus", new object[] {
            ((object)(0.82D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Earth", new object[] {
            ((object)(1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Mars", new object[] {
            ((object)(0.11D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Jupiter", new object[] {
            ((object)(318D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Saturn", new object[] {
            ((object)(95D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("Uranus", new object[] {
            ((object)(14.6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Neptune", new object[] {
            ((object)(17.2D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarSlideAnimation barSlideAnimation1 = new DevExpress.XtraCharts.BarSlideAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonRestoreColor = new DevExpress.XtraEditors.SimpleButton();
            this.colorEditScaleBreakColor = new DevExpress.XtraEditors.ColorEdit();
            this.spinEditSize = new DevExpress.XtraEditors.SpinEdit();
            this.checkEditShowScaleBreaks = new DevExpress.XtraEditors.CheckEdit();
            this.spinEditMaxCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemMaxCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemShowScaleBreaks = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupAppearance = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemRestoreColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditScaleBreakColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowScaleBreaks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowScaleBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRestoreColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.Location = new System.Drawing.Point(542, 0);
            this.sidePanelOptions.Size = new System.Drawing.Size(242, 567);
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(241, 567);
            this.tabPaneOptions.Size = new System.Drawing.Size(241, 567);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 534);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.simpleButtonRestoreColor);
            this.layoutControl.Controls.Add(this.colorEditScaleBreakColor);
            this.layoutControl.Controls.Add(this.spinEditSize);
            this.layoutControl.Controls.Add(this.checkEditShowScaleBreaks);
            this.layoutControl.Controls.Add(this.spinEditMaxCount);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 534);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // simpleButtonRestoreColor
            // 
            this.simpleButtonRestoreColor.Location = new System.Drawing.Point(12, 180);
            this.simpleButtonRestoreColor.Name = "simpleButtonRestoreColor";
            this.simpleButtonRestoreColor.Size = new System.Drawing.Size(217, 22);
            this.simpleButtonRestoreColor.StyleController = this.layoutControl;
            this.simpleButtonRestoreColor.TabIndex = 9;
            this.simpleButtonRestoreColor.Text = "Restore Default Color";
            this.simpleButtonRestoreColor.Click += new System.EventHandler(this.simpleButtonRestoreColor_Click);
            // 
            // colorEditScaleBreakColor
            // 
            this.colorEditScaleBreakColor.EditValue = System.Drawing.Color.Empty;
            this.colorEditScaleBreakColor.Location = new System.Drawing.Point(83, 148);
            this.colorEditScaleBreakColor.Name = "colorEditScaleBreakColor";
            this.colorEditScaleBreakColor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.colorEditScaleBreakColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEditScaleBreakColor.Size = new System.Drawing.Size(146, 20);
            this.colorEditScaleBreakColor.StyleController = this.layoutControl;
            this.colorEditScaleBreakColor.TabIndex = 8;
            this.colorEditScaleBreakColor.EditValueChanged += new System.EventHandler(this.colorEditScaleBreakColor_EditValueChanged);
            // 
            // spinEditSize
            // 
            this.spinEditSize.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditSize.Location = new System.Drawing.Point(83, 124);
            this.spinEditSize.Name = "spinEditSize";
            this.spinEditSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditSize.Properties.DisplayFormat.FormatString = "0 px";
            this.spinEditSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditSize.Properties.IsFloatValue = false;
            this.spinEditSize.Properties.Mask.EditMask = "N00";
            this.spinEditSize.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinEditSize.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.spinEditSize.Properties.ValidateOnEnterKey = true;
            this.spinEditSize.Size = new System.Drawing.Size(146, 20);
            this.spinEditSize.StyleController = this.layoutControl;
            this.spinEditSize.TabIndex = 7;
            this.spinEditSize.EditValueChanged += new System.EventHandler(this.spinEditSize_EditValueChanged);
            // 
            // checkEditShowScaleBreaks
            // 
            this.checkEditShowScaleBreaks.Location = new System.Drawing.Point(12, 34);
            this.checkEditShowScaleBreaks.Name = "checkEditShowScaleBreaks";
            this.checkEditShowScaleBreaks.Properties.Caption = "Enable Scale Breaks";
            this.checkEditShowScaleBreaks.Size = new System.Drawing.Size(217, 20);
            this.checkEditShowScaleBreaks.StyleController = this.layoutControl;
            this.checkEditShowScaleBreaks.TabIndex = 4;
            this.checkEditShowScaleBreaks.CheckedChanged += new System.EventHandler(this.checkEditShowScaleBreaks_CheckedChanged);
            // 
            // spinEditMaxCount
            // 
            this.spinEditMaxCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMaxCount.Location = new System.Drawing.Point(83, 58);
            this.spinEditMaxCount.Name = "spinEditMaxCount";
            this.spinEditMaxCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditMaxCount.Properties.IsFloatValue = false;
            this.spinEditMaxCount.Properties.Mask.EditMask = "N00";
            this.spinEditMaxCount.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinEditMaxCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditMaxCount.Size = new System.Drawing.Size(146, 20);
            this.spinEditMaxCount.StyleController = this.layoutControl;
            this.spinEditMaxCount.TabIndex = 5;
            this.spinEditMaxCount.EditValueChanged += new System.EventHandler(this.spinEditMaxCount_EditValueChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupGeneral,
            this.emptySpaceItem,
            this.layoutControlGroupAppearance});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 534);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemMaxCount,
            this.layoutControlItemShowScaleBreaks});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(241, 90);
            this.layoutControlGroupGeneral.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupGeneral.Text = "General";
            // 
            // layoutControlItemMaxCount
            // 
            this.layoutControlItemMaxCount.Control = this.spinEditMaxCount;
            this.layoutControlItemMaxCount.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemMaxCount.Name = "layoutControlItemMaxCount";
            this.layoutControlItemMaxCount.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemMaxCount.Text = "Max Count: ";
            this.layoutControlItemMaxCount.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItemShowScaleBreaks
            // 
            this.layoutControlItemShowScaleBreaks.Control = this.checkEditShowScaleBreaks;
            this.layoutControlItemShowScaleBreaks.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemShowScaleBreaks.Name = "layoutControlItemShowScaleBreaks";
            this.layoutControlItemShowScaleBreaks.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemShowScaleBreaks.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 214);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 320);
            // 
            // layoutControlGroupAppearance
            // 
            this.layoutControlGroupAppearance.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupAppearance.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemRestoreColor,
            this.layoutControlItemColor,
            this.layoutControlItemSize});
            this.layoutControlGroupAppearance.Location = new System.Drawing.Point(0, 90);
            this.layoutControlGroupAppearance.Name = "layoutControlGroupAppearance";
            this.layoutControlGroupAppearance.Size = new System.Drawing.Size(241, 124);
            this.layoutControlGroupAppearance.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupAppearance.Text = "Appearance";
            // 
            // layoutControlItemRestoreColor
            // 
            this.layoutControlItemRestoreColor.Control = this.simpleButtonRestoreColor;
            this.layoutControlItemRestoreColor.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemRestoreColor.Name = "layoutControlItemRestoreColor";
            this.layoutControlItemRestoreColor.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItemRestoreColor.Size = new System.Drawing.Size(221, 34);
            this.layoutControlItemRestoreColor.TextVisible = false;
            // 
            // layoutControlItemColor
            // 
            this.layoutControlItemColor.Control = this.colorEditScaleBreakColor;
            this.layoutControlItemColor.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemColor.Name = "layoutControlItemColor";
            this.layoutControlItemColor.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemColor.Text = "Color:";
            this.layoutControlItemColor.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItemSize
            // 
            this.layoutControlItemSize.Control = this.spinEditSize;
            this.layoutControlItemSize.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSize.Name = "layoutControlItemSize";
            this.layoutControlItemSize.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItemSize.Text = "Size:";
            this.layoutControlItemSize.TextSize = new System.Drawing.Size(59, 13);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Title.Text = "Planets";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisY.AutoScaleBreaks.MaxCount = 4;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.ScaleBreakOptions.Style = DevExpress.XtraCharts.ScaleBreakStyle.Straight;
            xyDiagram1.AxisY.Title.Text = "Multiple of Earth mass";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.LegendTextPattern = "{A}: {V}";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            series1.SeriesID = 0;
            barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            barSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Inverted;
            sideBySideBarSeriesView1.Animation = barSlideAnimation1;
            sideBySideBarSeriesView1.ColorEach = true;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(542, 567);
            this.chart.TabIndex = 3;
            chartTitle1.Text = "Mass of Planets in the Solar System";
            chartTitle1.TitleID = 0;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // ScaleBreaksDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ScaleBreaksDemo";
            this.Size = new System.Drawing.Size(784, 567);
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorEditScaleBreakColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowScaleBreaks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowScaleBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRestoreColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        XtraLayout.LayoutControl layoutControl;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraEditors.CheckEdit checkEditShowScaleBreaks;
        XtraLayout.LayoutControlItem layoutControlItemShowScaleBreaks;
        XtraEditors.SpinEdit spinEditMaxCount;
        XtraLayout.LayoutControlItem layoutControlItemMaxCount;
        XtraEditors.SpinEdit spinEditSize;
        XtraLayout.LayoutControlItem layoutControlItemSize;
        XtraEditors.ColorEdit colorEditScaleBreakColor;
        XtraLayout.LayoutControlItem layoutControlItemColor;
        XtraEditors.SimpleButton simpleButtonRestoreColor;
        XtraLayout.LayoutControlGroup layoutControlGroupAppearance;
        XtraLayout.LayoutControlItem layoutControlItemRestoreColor;
        XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        XtraLayout.EmptySpaceItem emptySpaceItem;
        ChartControl chart;
    }
}
