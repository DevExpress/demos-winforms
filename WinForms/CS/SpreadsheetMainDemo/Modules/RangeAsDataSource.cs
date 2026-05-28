using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class RangeAsDataSourceModule : SpreadSheetTutorialControlBase {
        private Timer timer1;
        private IContainer components;
        private LabelControl labelControl2;
        private ZoomTrackBarControl trbStdDev;
        private LabelControl labelControl1;
        private ZoomTrackBarControl trbMean;
        private SidePanel sidePanel2;
        private SpreadsheetControl spreadsheet;
        private ChartControl chartControl1;
        private double mean;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private SeparatorControl separatorControl1;
        private double standardDeviation;

        public RangeAsDataSourceModule() {
            InitializeComponent();
            spreadsheet.LoadDocument(DemoUtils.GetRelativePath("RangeAsDataSource_template.xlsx"));
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheet.Focus();
            timer1.Enabled = true;
        }

        protected override void DoHide() {
            timer1.Enabled = false;
            base.DoHide();
        }

        private void Spreadsheet_DocumentLoaded(object sender, EventArgs e) {
            IWorkbook workbook = spreadsheet.Document;
            Worksheet sheet = workbook.Worksheets[0];

            chartControl1.DataSource = sheet["B3:D103"].GetDataSource();
            Series series = chartControl1.Series[0];
            series.ArgumentDataMember = "Column 0";
            series.ValueDataMembers.AddRange(new string[] { "Column 1" });
            series = chartControl1.Series[1];
            series.ArgumentDataMember = "Column 0";
            series.ValueDataMembers.AddRange(new string[] { "Column 2" });

            mean = trbMean.Value / 10.0;
            standardDeviation = trbStdDev.Value / 100.0;
        }

        private void RangeAsDataSourceModule_Resize(object sender, EventArgs e) {
            sidePanel2.Width = Width / 2;
        }

        private void Mean_EditValueChanged(object sender, EventArgs e) {
            mean = trbMean.Value / 10.0;
        }

        private void StdDev_EditValueChanged(object sender, EventArgs e) {
            standardDeviation = trbStdDev.Value / 100.0;
        }

        private void Spreadsheet_CellValueChanged(object sender, SpreadsheetCellEventArgs e) {
            if(e.Cell.GetReferenceA1() == "F3")
                trbMean.Value = (int)(e.Cell.Value.NumericValue * 10);
            else if(e.Cell.GetReferenceA1() == "F6")
                trbStdDev.Value = (int)(e.Cell.Value.NumericValue * 100);
        }

        private void Timer_Tick(object sender, EventArgs e) {
            spreadsheet.BeginUpdate();
            try {
                Worksheet sheet = spreadsheet.Document.Worksheets[0];
                if(sheet["F3"].Value.NumericValue != mean)
                    sheet["F3"].Value = mean;
                if(sheet["F6"].Value.NumericValue != standardDeviation)
                    sheet["F6"].Value = standardDeviation;
            }
            finally {
                spreadsheet.EndUpdate();
            }
        }

        #region InitializeComponent
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition25 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition26 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition27 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition28 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition29 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition30 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Strip strip21 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip22 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip23 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip24 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.Strip strip25 = new DevExpress.XtraCharts.Strip();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane5 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView9 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView10 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle9 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle10 = new DevExpress.XtraCharts.ChartTitle();
            timer1 = new System.Windows.Forms.Timer(components);
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            trbStdDev = new DevExpress.XtraEditors.ZoomTrackBarControl();
            trbMean = new DevExpress.XtraEditors.ZoomTrackBarControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            spreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(layoutControl1)).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(trbStdDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(trbStdDev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(trbMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(trbMean.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem4)).BeginInit();
            sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(strip25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(separatorControl1)).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += new System.EventHandler(Timer_Tick);
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(301, 13);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(95, 13);
            labelControl2.StyleController = layoutControl1;
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Standard deviation:";
            // 
            // layoutControl1
            // 
            layoutControl1.AllowCustomization = false;
            layoutControl1.AutoScroll = false;
            layoutControl1.AutoSize = true;
            layoutControl1.Controls.Add(trbStdDev);
            layoutControl1.Controls.Add(labelControl2);
            layoutControl1.Controls.Add(trbMean);
            layoutControl1.Controls.Add(labelControl1);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(693, 282, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(1228, 39);
            layoutControl1.TabIndex = 8;
            layoutControl1.Text = "layoutControl1";
            // 
            // trbStdDev
            // 
            trbStdDev.EditValue = 55;
            trbStdDev.Location = new System.Drawing.Point(400, 12);
            trbStdDev.Name = "trbStdDev";
            trbStdDev.Properties.Maximum = 100;
            trbStdDev.Properties.Minimum = 10;
            trbStdDev.Size = new System.Drawing.Size(171, 16);
            trbStdDev.StyleController = layoutControl1;
            trbStdDev.TabIndex = 7;
            trbStdDev.Value = 55;
            trbStdDev.EditValueChanged += new System.EventHandler(StdDev_EditValueChanged);
            // 
            // trbMean
            // 
            trbMean.Location = new System.Drawing.Point(46, 12);
            trbMean.Name = "trbMean";
            trbMean.Properties.Maximum = 50;
            trbMean.Properties.Minimum = -50;
            trbMean.Size = new System.Drawing.Size(171, 16);
            trbMean.StyleController = layoutControl1;
            trbMean.TabIndex = 5;
            trbMean.Value = 0;
            trbMean.EditValueChanged += new System.EventHandler(Mean_EditValueChanged);
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 13);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(30, 13);
            labelControl1.StyleController = layoutControl1;
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Mean:";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            layoutControlItem1,
            layoutControlItem2,
            layoutControlItem3,
            layoutControlItem4});
            Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            Root.Name = "Root";
            columnDefinition25.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition25.Width = 34D;
            columnDefinition26.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition26.Width = 175D;
            columnDefinition27.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition27.Width = 80D;
            columnDefinition28.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition28.Width = 99D;
            columnDefinition29.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition29.Width = 175D;
            columnDefinition30.SizeType = System.Windows.Forms.SizeType.AutoSize;
            columnDefinition30.Width = 645D;
            Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition25,
            columnDefinition26,
            columnDefinition27,
            columnDefinition28,
            columnDefinition29,
            columnDefinition30});
            rowDefinition5.Height = 19D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition5});
            Root.Size = new System.Drawing.Size(1228, 39);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem1.Control = labelControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(34, 19);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem2.Control = trbMean;
            layoutControlItem2.Location = new System.Drawing.Point(34, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            layoutControlItem2.Size = new System.Drawing.Size(175, 19);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem3.Control = labelControl2;
            layoutControlItem3.Location = new System.Drawing.Point(289, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 3;
            layoutControlItem3.Size = new System.Drawing.Size(99, 19);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            layoutControlItem4.Control = trbStdDev;
            layoutControlItem4.Location = new System.Drawing.Point(388, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 4;
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4);
            layoutControlItem4.Size = new System.Drawing.Size(175, 19);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // sidePanel2
            // 
            sidePanel2.Controls.Add(spreadsheet);
            sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel2.Location = new System.Drawing.Point(0, 40);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new System.Drawing.Size(614, 654);
            sidePanel2.TabIndex = 3;
            sidePanel2.Text = "sidePanel1";
            // 
            // spreadsheet
            // 
            spreadsheet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            spreadsheet.Location = new System.Drawing.Point(0, 0);
            spreadsheet.Name = "spreadsheet";
            spreadsheet.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            spreadsheet.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            spreadsheet.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            spreadsheet.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            spreadsheet.Options.Behavior.UseSkinColors = false;
            spreadsheet.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            spreadsheet.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            spreadsheet.Options.View.ShowPrintArea = false;
            spreadsheet.Size = new System.Drawing.Size(613, 654);
            spreadsheet.TabIndex = 8;
            spreadsheet.DocumentLoaded += new System.EventHandler(Spreadsheet_DocumentLoaded);
            spreadsheet.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(Spreadsheet_CellValueChanged);
            // 
            // chartControl1
            // 
            chartControl1.AppearanceNameSerializable = "Light";
            chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram5.AxisX.GridLines.Visible = true;
            strip21.Color = System.Drawing.Color.FromArgb(242, 242, 242);
            strip21.MaxLimit.AxisValueSerializable = "1";
            strip21.MinLimit.AxisValueSerializable = "-1";
            strip21.Name = "Strip 1";
            strip21.ShowInLegend = false;
            strip22.Color = System.Drawing.Color.FromArgb(242, 242, 242);
            strip22.MaxLimit.AxisValueSerializable = "-2";
            strip22.MinLimit.AxisValueSerializable = "-3";
            strip22.Name = "Strip 2";
            strip22.ShowInLegend = false;
            strip23.Color = System.Drawing.Color.FromArgb(242, 242, 242);
            strip23.MaxLimit.AxisValueSerializable = "-4";
            strip23.MinLimit.AxisValueSerializable = "-5";
            strip23.Name = "Strip 3";
            strip23.ShowInLegend = false;
            strip24.Color = System.Drawing.Color.FromArgb(242, 242, 242);
            strip24.MaxLimit.AxisValueSerializable = "3";
            strip24.MinLimit.AxisValueSerializable = "2";
            strip24.Name = "Strip 4";
            strip24.ShowInLegend = false;
            strip25.Color = System.Drawing.Color.FromArgb(242, 242, 242);
            strip25.MaxLimit.AxisValueSerializable = "5";
            strip25.MinLimit.AxisValueSerializable = "4";
            strip25.Name = "Strip 5";
            strip25.ShowInLegend = false;
            xyDiagram5.AxisX.Strips.AddRange(new DevExpress.XtraCharts.Strip[] {
            strip21,
            strip22,
            strip23,
            strip24,
            strip25});
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1;0";
            xyDiagram5.AxisX.VisualRange.Auto = false;
            xyDiagram5.AxisX.VisualRange.MaxValueSerializable = "5";
            xyDiagram5.AxisX.VisualRange.MinValueSerializable = "-5";
            xyDiagram5.AxisX.WholeRange.Auto = false;
            xyDiagram5.AxisX.WholeRange.MaxValueSerializable = "5";
            xyDiagram5.AxisX.WholeRange.MinValueSerializable = "-5";
            xyDiagram5.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1;0";
            xyDiagramPane5.Name = "Pane 1";
            xyDiagramPane5.PaneID = 0;
            xyDiagram5.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane5});
            chartControl1.Diagram = xyDiagram5;
            chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl1.Legend.Name = "Default Legend";
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chartControl1.Location = new System.Drawing.Point(614, 40);
            chartControl1.Name = "chartControl1";
            series9.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}";
            series9.Name = "PDF";
            series9.View = scatterLineSeriesView9;
            series10.CrosshairLabelPattern = "X={A:0.0} Y={V:0.00e+00}";
            series10.Name = "CDF";
            scatterLineSeriesView10.PaneName = "Pane 1";
            series10.View = scatterLineSeriesView10;
            chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9,
        series10};
            chartControl1.Size = new System.Drawing.Size(614, 654);
            chartControl1.TabIndex = 4;
            chartTitle9.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            chartTitle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            chartTitle9.Text = "PROBABILITY DENSITY FUNCTION";
            chartTitle9.TextColor = System.Drawing.Color.DimGray;
            chartTitle10.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle10.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            chartTitle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            chartTitle10.Text = "CUMULATIVE DISTRIBUTION FUNCTION";
            chartTitle10.TextColor = System.Drawing.Color.DimGray;
            chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle9,
            chartTitle10});
            // 
            // separatorControl1
            // 
            separatorControl1.AutoSizeMode = true;
            separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            separatorControl1.Location = new System.Drawing.Point(0, 39);
            separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            separatorControl1.Size = new System.Drawing.Size(1228, 1);
            separatorControl1.TabIndex = 13;
            // 
            // RangeAsDataSourceModule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chartControl1);
            Controls.Add(sidePanel2);
            Controls.Add(separatorControl1);
            Controls.Add(layoutControl1);
            Name = "RangeAsDataSourceModule";
            Size = new System.Drawing.Size(1228, 694);
            Resize += new System.EventHandler(RangeAsDataSourceModule_Resize);
            ((System.ComponentModel.ISupportInitialize)(layoutControl1)).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(trbStdDev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(trbStdDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(trbMean.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(trbMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlItem4)).EndInit();
            sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(strip21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(strip25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(separatorControl1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        #region Dispose
        bool isModuleDisposed = false;
        protected override void Dispose(bool disposing) {
            if(disposing && !isModuleDisposed) {
                timer1.Enabled = false;
                isModuleDisposed = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
