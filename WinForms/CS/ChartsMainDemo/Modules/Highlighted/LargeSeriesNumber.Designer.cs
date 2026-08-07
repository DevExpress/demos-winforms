namespace DevExpress.XtraCharts.Demos {
    partial class LargeSeriesNumberDemo {
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
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel1 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel2 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel3 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel4 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel5 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel6 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel7 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel8 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel9 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel10 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel11 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel12 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter1 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember3 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries;
            this.chart.CrosshairOptions.ShowArgumentLabels = true;
            customAxisLabel1.AxisValueSerializable = "1";
            customAxisLabel1.Name = "January";
            customAxisLabel2.AxisValueSerializable = "31";
            customAxisLabel2.Name = "February";
            customAxisLabel3.AxisValueSerializable = "59";
            customAxisLabel3.Name = "March";
            customAxisLabel4.AxisValueSerializable = "90";
            customAxisLabel4.Name = "April";
            customAxisLabel5.AxisValueSerializable = "120";
            customAxisLabel5.Name = "May";
            customAxisLabel6.AxisValueSerializable = "151";
            customAxisLabel6.Name = "June";
            customAxisLabel7.AxisValueSerializable = "181";
            customAxisLabel7.Name = "July";
            customAxisLabel8.AxisValueSerializable = "212";
            customAxisLabel8.Name = "August";
            customAxisLabel9.AxisValueSerializable = "243";
            customAxisLabel9.Name = "September";
            customAxisLabel10.AxisValueSerializable = "273";
            customAxisLabel10.Name = "October";
            customAxisLabel11.AxisValueSerializable = "303";
            customAxisLabel11.Name = "November";
            customAxisLabel12.AxisValueSerializable = "334";
            customAxisLabel12.Name = "December";
            xyDiagram1.AxisX.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel1,
            customAxisLabel2,
            customAxisLabel3,
            customAxisLabel4,
            customAxisLabel5,
            customAxisLabel6,
            customAxisLabel7,
            customAxisLabel8,
            customAxisLabel9,
            customAxisLabel10,
            customAxisLabel11,
            customAxisLabel12});
            xyDiagram1.AxisX.Label.TextPattern = "Day {A:0.}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "367";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.Title.Text = "Sea Ice Area, Millions km²";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}<br/>Day {A:0.}: {V:0.000M km²}";
            dataMember1.ColumnName = "DayOfYear";
            dataMember2.ColumnName = "IceArea";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "Year";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3});
            this.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1;
            lineSeriesView1.LineStyle.DXLineJoin = DevExpress.Drawing.DXLineJoin.Round;
            this.chart.SeriesTemplate.View = lineSeriesView1;
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 0;
            chartTitle1.Text = "Global Sea Ice Area";
            chartTitle1.TitleID = 0;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            chartTitle2.Text = "From NSIDC NASA Team sea ice concentration data";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            chartTitle2.TitleID = 1;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.ChartControl_BoundDataChanged);
            this.chart.LegendItemChecked += new DevExpress.XtraCharts.LegendItemCheckedEventHandler(this.ChartControl_LegendItemChecked);
            // 
            // LargeSeriesNumberDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "LargeSeriesNumberDemo";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
    }
}
