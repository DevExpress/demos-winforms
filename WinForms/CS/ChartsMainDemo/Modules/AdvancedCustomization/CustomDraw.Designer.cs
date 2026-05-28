namespace DevExpress.XtraCharts.Demos {
    partial class CustomDrawDemo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDrawDemo));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.dS51 = new DevExpress.XtraCharts.Demos.DS5();
            this.oleDbAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dS51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS51
            // 
            this.dS51.DataSetName = "DS5";
            this.dS51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbAdapter
            // 
            this.oleDbAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.Label.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            xyDiagram1.AxisX.Label.TextPattern = "{A:yyyy}";
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.chart.Legend.HorizontalIndent = 16;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Padding.Bottom = 0;
            this.chart.Legend.Padding.Left = 10;
            this.chart.Legend.Padding.Right = 30;
            this.chart.Legend.Padding.Top = 0;
            this.chart.Legend.TextOffset = 8;
            this.chart.Legend.VerticalIndent = 8;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "LastName";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "OrderDate";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chart.SeriesTemplate.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.MaxLineCount = 2;
            sideBySideBarSeriesLabel1.MaxWidth = 300;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.SeriesDataMember = "LastName";
            this.chart.SeriesTemplate.DateTimeSummaryOptions.SummaryFunction = "SUM([Freight])";
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Sales Volume by Year";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chart_ObjectHotTracked);
            this.chart.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.chart_CustomDrawSeries);
            this.chart.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chart_CustomDrawSeriesPoint);
            this.chart.CustomDrawAxisLabel += new DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(this.chart_CustomDrawAxisLabel);
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            this.chart.MouseLeave += new System.EventHandler(this.chart_MouseLeave);
            // 
            // CustomDrawDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "CustomDrawDemo";
            ((System.ComponentModel.ISupportInitialize)(this.dS51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        System.ComponentModel.IContainer components = null;
        DS5 dS51;
        System.Data.OleDb.OleDbDataAdapter oleDbAdapter;
        System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        System.Data.OleDb.OleDbConnection oleDbConnection;
        ChartControl chart;

    }
}
