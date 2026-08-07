using System;
using System.Linq;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraCharts.Demos {
    public partial class RealTimeChartDemo : ChartDemoModule {
        readonly double[] fpsBuffer = new double[10];
        int lastIndex = 0;
        DateTime lastTime = DateTime.Now;
        double lastFPSUpdateTime = 0;
        readonly SensorDataGenerator dataGenerator;

        internal override bool ChartDesignerEnabled { get { return false; } }
        internal override ChartControl ChartControl { get { return chart; } }
        internal override object ExportedObject { get { return null; } }

        public RealTimeChartDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            dataGenerator = new SensorDataGenerator();
            dataGenerator.GenerateInitialData();
            ChartControl.DataSource = dataGenerator.DataSource;
            ColorizeSeries();
            dataGenerator.Start();
            synchronousTimer.Enabled = true;
            ChartControl.EndInit();
            SwiftPlotDiagramAxisX axisX = ((SwiftPlotDiagram)ChartControl.Diagram).AxisX;
            axisX.VisualRange.SetMinMaxValues((DateTime)axisX.WholeRange.MaxValue - new TimeSpan(0, 0, 10), ((DateTime)axisX.WholeRange.MaxValue).AddSeconds(1));
        }
        void ColorizeSeries() {
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(2);
            ChartControl.Series[0].View.Color = paletteEntries[0].Color;
            ChartControl.Series[1].View.Color = paletteEntries[1].Color;
            ChartControl.Series[2].View.Color = paletteEntries[0].Color;
            ChartControl.Series[3].View.Color = paletteEntries[1].Color;
            ChartControl.Series[4].View.Color = paletteEntries[0].Color;
            ChartControl.Series[5].View.Color = paletteEntries[1].Color;
            ChartControl.Series[6].View.Color = paletteEntries[0].Color;
            ChartControl.Series[7].View.Color = paletteEntries[1].Color;
            ChartControl.Legend.CustomItems[0].MarkerColor = paletteEntries[0].Color;
            ChartControl.Legend.CustomItems[1].MarkerColor = paletteEntries[1].Color;
        }
        void synchronousTimer_Tick(object sender, EventArgs e) {
            if(dataGenerator != null)
                dataGenerator.UpdateDataSource();
        }
        void Chart_CustomPaint(object sender, CustomPaintEventArgs e) {
            DateTime currentTime = DateTime.Now;
            double diff = Math.Max(1, (currentTime - lastTime).TotalMilliseconds);
            lastTime = currentTime;
            if(diff != 1)
                fpsBuffer[lastIndex++] = 1000 / diff;
            if(lastFPSUpdateTime == 0 || lastFPSUpdateTime > 100) {
                chart.Titles[1].Text = string.Format("FPS: {0:0.00}", fpsBuffer.Average());
                lastFPSUpdateTime = 0;
            }
            lastFPSUpdateTime += diff;
            if(lastIndex >= fpsBuffer.Length)
                lastIndex = 0;
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            ColorizeSeries();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && components != null && dataGenerator != null) {
                dataGenerator.Stop();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
