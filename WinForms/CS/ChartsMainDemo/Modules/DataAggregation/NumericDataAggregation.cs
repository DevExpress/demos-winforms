using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraCharts.Demos {
    public partial class NumericDataAggregationDemo : ChartDemoModule {
        const int PointCount = 500000;

        Series Series {
            get { return chart.Series.Count > 0 ? chart.Series[0] : null; }
        }
        XYDiagram Diagram {
            get { return chart.Diagram as XYDiagram; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public NumericDataAggregationDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            LoadPoints();
            Diagram.AxisX.NumericScaleOptions.ScaleMode = ScaleMode.Automatic;
            CrosshairFreePosition crosshairPosition = new CrosshairFreePosition();
            crosshairPosition.DockTarget = ((XYDiagram2D)ChartControl.Diagram).DefaultPane;
            crosshairPosition.DockCorner = DockCorner.LeftTop;
            ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition;
            foreach(Series series in chart.Series)
                series.CrosshairLabelPattern = "{A} : {V:F2}";
            ChartControl.EndInit();
        }

        void LoadPoints() {
            if(Series != null) {
                double value = 0;
                double argument = 1;
                Series.Points.BeginUpdate();
                Series.Points.Clear();
                for(double i = 0; i < PointCount; i++) {
                    Series.Points.Add(new SeriesPoint(argument, value));
                    value += (TutorialConstants.Random.NextDouble() * 10.0 - 5.0);
                    argument++;
                }
                Series.Points.EndUpdate();
            }
        }

        void chart_AxisVisualRangeChanged(object sender, AxisRangeChangedEventArgs e) {
            if(e.Axis is AxisX)
                ((AxisX)e.Axis).Title.Text = "Measure Unit: " + e.Axis.NumericScaleOptions.MeasureUnit;
        }
    }
}
