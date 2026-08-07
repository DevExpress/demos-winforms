namespace DevExpress.XtraCharts.Demos {
    partial class MovingAverageAndRegressionLineDemo {
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
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ExponentialMovingAverage exponentialMovingAverage1 = new DevExpress.XtraCharts.ExponentialMovingAverage();
            DevExpress.XtraCharts.SimpleMovingAverage simpleMovingAverage1 = new DevExpress.XtraCharts.SimpleMovingAverage();
            DevExpress.XtraCharts.TriangularMovingAverage triangularMovingAverage1 = new DevExpress.XtraCharts.TriangularMovingAverage();
            DevExpress.XtraCharts.TripleExponentialMovingAverageTema tripleExponentialMovingAverageTema1 = new DevExpress.XtraCharts.TripleExponentialMovingAverageTema();
            DevExpress.XtraCharts.WeightedMovingAverage weightedMovingAverage1 = new DevExpress.XtraCharts.WeightedMovingAverage();
            DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
            DevExpress.XtraCharts.XYMarkerWidenAnimation xyMarkerWidenAnimation1 = new DevExpress.XtraCharts.XYMarkerWidenAnimation();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupMovingAverage = new DevExpress.XtraEditors.RadioGroup();
            this.comboBoxEditMovingAverageKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinEditPointsCount = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditEnvelopePercent = new DevExpress.XtraEditors.SpinEdit();
            this.checkEditRegressionLineVisible = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupMovingAverage = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemMovingAverageKind = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemEnvelopePercent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemMovingAverage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPointsCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupRegressionLine = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemShowRegressionLine = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(exponentialMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(triangularMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tripleExponentialMovingAverageTema1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(weightedMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMovingAverage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMovingAverageKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPointsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEnvelopePercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRegressionLineVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMovingAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMovingAverageKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEnvelopePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMovingAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPointsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRegressionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowRegressionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.Location = new System.Drawing.Point(528, 0);
            this.sidePanelOptions.Size = new System.Drawing.Size(260, 571);
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(259, 571);
            this.tabPaneOptions.Size = new System.Drawing.Size(259, 571);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(259, 538);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A:n1}";
            this.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chart.CrosshairOptions.ShowValueLine = true;
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.CrosshairLabelPattern = "{A:F0}: {V}";
            series1.Name = "Measurements Data";
            series1.SeriesID = 0;
            exponentialMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            exponentialMovingAverage1.EnvelopePercent = 35D;
            exponentialMovingAverage1.IndicatorID = 0;
            exponentialMovingAverage1.LineStyle.Thickness = 2;
            exponentialMovingAverage1.Name = "Exponential Moving Average";
            exponentialMovingAverage1.PointsCount = 50;
            exponentialMovingAverage1.ShowInLegend = true;
            exponentialMovingAverage1.Visible = false;
            simpleMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            simpleMovingAverage1.EnvelopePercent = 35D;
            simpleMovingAverage1.IndicatorID = 1;
            simpleMovingAverage1.LineStyle.Thickness = 2;
            simpleMovingAverage1.Name = "Simple Moving Average";
            simpleMovingAverage1.PointsCount = 50;
            simpleMovingAverage1.ShowInLegend = true;
            simpleMovingAverage1.Visible = false;
            triangularMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            triangularMovingAverage1.EnvelopePercent = 35D;
            triangularMovingAverage1.IndicatorID = 2;
            triangularMovingAverage1.LineStyle.Thickness = 2;
            triangularMovingAverage1.Name = "Triangular Moving Average";
            triangularMovingAverage1.PointsCount = 50;
            triangularMovingAverage1.ShowInLegend = true;
            triangularMovingAverage1.Visible = false;
            tripleExponentialMovingAverageTema1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            tripleExponentialMovingAverageTema1.EnvelopePercent = 35D;
            tripleExponentialMovingAverageTema1.IndicatorID = 3;
            tripleExponentialMovingAverageTema1.LineStyle.Thickness = 2;
            tripleExponentialMovingAverageTema1.Name = "Triple Exponential Moving Average (TEMA)";
            tripleExponentialMovingAverageTema1.PointsCount = 50;
            tripleExponentialMovingAverageTema1.ShowInLegend = true;
            tripleExponentialMovingAverageTema1.Visible = false;
            weightedMovingAverage1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            weightedMovingAverage1.EnvelopePercent = 35D;
            weightedMovingAverage1.IndicatorID = 4;
            weightedMovingAverage1.LineStyle.Thickness = 2;
            weightedMovingAverage1.Name = "Weighted Moving Average";
            weightedMovingAverage1.PointsCount = 50;
            weightedMovingAverage1.ShowInLegend = true;
            weightedMovingAverage1.Visible = false;
            regressionLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(33)))));
            regressionLine1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            regressionLine1.IndicatorID = 5;
            regressionLine1.LineStyle.Thickness = 2;
            regressionLine1.Name = "Regression Line";
            regressionLine1.ShowInLegend = true;
            regressionLine1.Visible = false;
            pointSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            exponentialMovingAverage1,
            simpleMovingAverage1,
            triangularMovingAverage1,
            tripleExponentialMovingAverageTema1,
            weightedMovingAverage1,
            regressionLine1});
            pointSeriesView1.PointMarkerOptions.Size = 2;
            xyMarkerWidenAnimation1.Enabled = false;
            pointSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1;
            series1.View = pointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(528, 571);
            this.chart.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.radioGroupMovingAverage);
            this.layoutControl1.Controls.Add(this.comboBoxEditMovingAverageKind);
            this.layoutControl1.Controls.Add(this.spinEditPointsCount);
            this.layoutControl1.Controls.Add(this.spinEditEnvelopePercent);
            this.layoutControl1.Controls.Add(this.checkEditRegressionLineVisible);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(428, 287, 650, 400);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroupRoot;
            this.layoutControl1.Size = new System.Drawing.Size(259, 538);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // radioGroupMovingAverage
            // 
            this.radioGroupMovingAverage.AutoSizeInLayoutControl = true;
            this.radioGroupMovingAverage.Location = new System.Drawing.Point(12, 34);
            this.radioGroupMovingAverage.Name = "radioGroupMovingAverage";
            this.radioGroupMovingAverage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupMovingAverage.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupMovingAverage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupMovingAverage.Properties.Columns = 1;
            this.radioGroupMovingAverage.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Simple Moving Average", "Simple Moving Average"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Exponential Moving Average", "Exponential Moving Average"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Weighted Moving Average", "Weighted Moving Average"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Triangular Moving Average", "Triangular Moving Average"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Triple Exponential Moving Average (TEMA)", "Triple Exponential Moving Average (TEMA)")});
            this.radioGroupMovingAverage.Size = new System.Drawing.Size(235, 128);
            this.radioGroupMovingAverage.StyleController = this.layoutControl1;
            this.radioGroupMovingAverage.TabIndex = 4;
            this.radioGroupMovingAverage.SelectedIndexChanged += new System.EventHandler(this.radioGroupMovingAverage_SelectedIndexChanged);
            // 
            // comboBoxEditMovingAverageKind
            // 
            this.comboBoxEditMovingAverageKind.Location = new System.Drawing.Point(112, 190);
            this.comboBoxEditMovingAverageKind.Name = "comboBoxEditMovingAverageKind";
            this.comboBoxEditMovingAverageKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMovingAverageKind.Properties.Items.AddRange(new object[] {
            "MovingAverage",
            "Envelope",
            "Moving Average and Envelope"});
            this.comboBoxEditMovingAverageKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMovingAverageKind.Size = new System.Drawing.Size(135, 20);
            this.comboBoxEditMovingAverageKind.StyleController = this.layoutControl1;
            this.comboBoxEditMovingAverageKind.TabIndex = 5;
            this.comboBoxEditMovingAverageKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMovingAverageKind_SelectedIndexChanged);
            // 
            // spinEditPointsCount
            // 
            this.spinEditPointsCount.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinEditPointsCount.Location = new System.Drawing.Point(112, 166);
            this.spinEditPointsCount.Name = "spinEditPointsCount";
            this.spinEditPointsCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPointsCount.Properties.IsFloatValue = false;
            this.spinEditPointsCount.Properties.Mask.EditMask = "N00";
            this.spinEditPointsCount.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditPointsCount.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.spinEditPointsCount.Properties.ValueChanged += new System.EventHandler(this.spinEditPointsCount_Properties_ValueChanged);
            this.spinEditPointsCount.Size = new System.Drawing.Size(135, 20);
            this.spinEditPointsCount.StyleController = this.layoutControl1;
            this.spinEditPointsCount.TabIndex = 6;
            // 
            // spinEditEnvelopePercent
            // 
            this.spinEditEnvelopePercent.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditEnvelopePercent.Location = new System.Drawing.Point(112, 214);
            this.spinEditEnvelopePercent.Name = "spinEditEnvelopePercent";
            this.spinEditEnvelopePercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditEnvelopePercent.Properties.DisplayFormat.FormatString = "0\\%";
            this.spinEditEnvelopePercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditEnvelopePercent.Properties.IsFloatValue = false;
            this.spinEditEnvelopePercent.Properties.Mask.EditMask = "N00";
            this.spinEditEnvelopePercent.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinEditEnvelopePercent.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditEnvelopePercent.Properties.ValueChanged += new System.EventHandler(this.spinEditEnvelopePercent_Properties_ValueChanged);
            this.spinEditEnvelopePercent.Size = new System.Drawing.Size(135, 20);
            this.spinEditEnvelopePercent.StyleController = this.layoutControl1;
            this.spinEditEnvelopePercent.TabIndex = 7;
            // 
            // checkEditRegressionLineVisible
            // 
            this.checkEditRegressionLineVisible.Location = new System.Drawing.Point(12, 280);
            this.checkEditRegressionLineVisible.Name = "checkEditRegressionLineVisible";
            this.checkEditRegressionLineVisible.Properties.Caption = "Show";
            this.checkEditRegressionLineVisible.Size = new System.Drawing.Size(235, 20);
            this.checkEditRegressionLineVisible.StyleController = this.layoutControl1;
            this.checkEditRegressionLineVisible.TabIndex = 8;
            this.checkEditRegressionLineVisible.CheckedChanged += new System.EventHandler(this.checkEditRegressionLineVisible_CheckedChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroupMovingAverage,
            this.layoutControlGroupRegressionLine});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(259, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 312);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(259, 226);
            // 
            // layoutControlGroupMovingAverage
            // 
            this.layoutControlGroupMovingAverage.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupMovingAverage.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemMovingAverageKind,
            this.layoutControlItemEnvelopePercent,
            this.layoutControlItemMovingAverage,
            this.layoutControlItemPointsCount});
            this.layoutControlGroupMovingAverage.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMovingAverage.Name = "layoutControlGroupMovingAverage";
            this.layoutControlGroupMovingAverage.Size = new System.Drawing.Size(259, 246);
            this.layoutControlGroupMovingAverage.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupMovingAverage.Text = "Moving Average";
            // 
            // layoutControlItemMovingAverageKind
            // 
            this.layoutControlItemMovingAverageKind.Control = this.comboBoxEditMovingAverageKind;
            this.layoutControlItemMovingAverageKind.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItemMovingAverageKind.Name = "layoutControlItemMovingAverageKind";
            this.layoutControlItemMovingAverageKind.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItemMovingAverageKind.Text = "Kind:";
            this.layoutControlItemMovingAverageKind.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItemEnvelopePercent
            // 
            this.layoutControlItemEnvelopePercent.Control = this.spinEditEnvelopePercent;
            this.layoutControlItemEnvelopePercent.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItemEnvelopePercent.Name = "layoutControlItemEnvelopePercent";
            this.layoutControlItemEnvelopePercent.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItemEnvelopePercent.Text = "Envelope Percent:";
            this.layoutControlItemEnvelopePercent.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItemMovingAverage
            // 
            this.layoutControlItemMovingAverage.Control = this.radioGroupMovingAverage;
            this.layoutControlItemMovingAverage.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemMovingAverage.Name = "layoutControlItemMovingAverage";
            this.layoutControlItemMovingAverage.Size = new System.Drawing.Size(239, 132);
            this.layoutControlItemMovingAverage.TextVisible = false;
            // 
            // layoutControlItemPointsCount
            // 
            this.layoutControlItemPointsCount.Control = this.spinEditPointsCount;
            this.layoutControlItemPointsCount.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItemPointsCount.Name = "layoutControlItemPointsCount";
            this.layoutControlItemPointsCount.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItemPointsCount.Text = "Point Count:";
            this.layoutControlItemPointsCount.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlGroupRegressionLine
            // 
            this.layoutControlGroupRegressionLine.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupRegressionLine.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemShowRegressionLine});
            this.layoutControlGroupRegressionLine.Location = new System.Drawing.Point(0, 246);
            this.layoutControlGroupRegressionLine.Name = "layoutControlGroupRegressionLine";
            this.layoutControlGroupRegressionLine.Size = new System.Drawing.Size(259, 66);
            this.layoutControlGroupRegressionLine.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRegressionLine.Text = "Regression Line";
            // 
            // layoutControlItemShowRegressionLine
            // 
            this.layoutControlItemShowRegressionLine.Control = this.checkEditRegressionLineVisible;
            this.layoutControlItemShowRegressionLine.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemShowRegressionLine.Name = "layoutControlItemShowRegressionLine";
            this.layoutControlItemShowRegressionLine.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItemShowRegressionLine.TextVisible = false;
            // 
            // MovingAverageAndRegressionLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "MovingAverageAndRegressionLineDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(exponentialMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(triangularMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tripleExponentialMovingAverageTema1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(weightedMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMovingAverage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMovingAverageKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPointsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditEnvelopePercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditRegressionLineVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMovingAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMovingAverageKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEnvelopePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMovingAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPointsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRegressionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemShowRegressionLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        XtraLayout.LayoutControl layoutControl1;
        XtraEditors.RadioGroup radioGroupMovingAverage;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraLayout.LayoutControlItem layoutControlItemMovingAverage;
        XtraEditors.ComboBoxEdit comboBoxEditMovingAverageKind;
        XtraEditors.SpinEdit spinEditPointsCount;
        XtraEditors.SpinEdit spinEditEnvelopePercent;
        XtraEditors.CheckEdit checkEditRegressionLineVisible;
        XtraLayout.EmptySpaceItem emptySpaceItem1;
        XtraLayout.LayoutControlGroup layoutControlGroupMovingAverage;
        XtraLayout.LayoutControlItem layoutControlItemMovingAverageKind;
        XtraLayout.LayoutControlItem layoutControlItemEnvelopePercent;
        XtraLayout.LayoutControlItem layoutControlItemPointsCount;
        XtraLayout.LayoutControlGroup layoutControlGroupRegressionLine;
        XtraLayout.LayoutControlItem layoutControlItemShowRegressionLine;
    }
}
