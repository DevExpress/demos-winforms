namespace DevExpress.XtraCharts.Demos {
    partial class DrillDownDemo {
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ToolTipRelativePosition toolTipRelativePosition1 = new DevExpress.XtraCharts.ToolTipRelativePosition();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.HighlightPoints = false;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,.##}";
            xyDiagram1.AxisY.Title.Text = "Thousands of USD";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Category";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.SeriesDataMember = "Category";
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 0;
            chartTitle1.Text = "DevAV Total Sales";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.ToolTipController = this.toolTipController1;
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            toolTipRelativePosition1.OffsetY = -15;
            this.chart.ToolTipOptions.ToolTipPosition = toolTipRelativePosition1;
            this.chart.DrillDownStateChanged += new DevExpress.XtraCharts.DrillDownStateChangedEventHandler(this.chart_DrillDownStateChanged);
            // 
            // toolTipController1
            // 
            this.toolTipController1.CloseOnClick = DevExpress.Utils.DefaultBoolean.True;
            this.toolTipController1.InitialDelay = 1;
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ShowBeak = true;
            this.toolTipController1.ShowShadow = false;
            this.toolTipController1.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.toolTipController1.ToolTipLocation = DevExpress.Utils.ToolTipLocation.LeftCenter;
            // 
            // DrillDownDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "DrillDownDemo";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
