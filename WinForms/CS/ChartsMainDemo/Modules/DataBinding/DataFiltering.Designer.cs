namespace DevExpress.XtraCharts.Demos {
    partial class DataFilteringDemo {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter1 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember3 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.filteringUIContext = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // filteringUIContext
            // 
            this.filteringUIContext.Client = this.chart;
            this.filteringUIContext.Control = this.accordionControl1;
            this.filteringUIContext.QueryLookupData += new DevExpress.Utils.Filtering.QueryDataEventHandler<DevExpress.Utils.Filtering.QueryLookupDataEventArgs, DevExpress.Utils.Filtering.LookupData>(this.filteringUIContext_QueryLookupData);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.Title.Text = "Year";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Sales, millions of USD";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V:$0.00}M";
            dataMember1.ColumnName = "Year";
            dataMember2.ColumnName = "Sales";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "Company";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3});
            this.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1;
            seriesKeyColorColorizer1.Keys.Add("DevAV North");
            seriesKeyColorColorizer1.Keys.Add("DevAV Central");
            seriesKeyColorColorizer1.Keys.Add("DevAV South");
            seriesKeyColorColorizer1.Keys.Add("DevAV West");
            seriesKeyColorColorizer1.Keys.Add("DevAV East");
            this.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1;
            this.chart.Size = new System.Drawing.Size(893, 714);
            this.chart.TabIndex = 6;
            chartTitle1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 14.25F);
            chartTitle1.Text = "Market Share Over Time";
            chartTitle1.TitleID = 0;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControl1.Location = new System.Drawing.Point(893, 0);
            this.accordionControl1.MinimumSize = new System.Drawing.Size(300, 300);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ResizeMode = DevExpress.XtraBars.Navigation.AccordionControlResizeMode.OuterResizeZone;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(300, 714);
            this.accordionControl1.TabIndex = 7;
            // 
            // DataFilteringDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.accordionControl1);
            this.Name = "DataFilteringDemo";
            this.Size = new System.Drawing.Size(1193, 714);
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext;
        XtraBars.Navigation.AccordionControl accordionControl1;
        ChartControl chart;
    }
}
