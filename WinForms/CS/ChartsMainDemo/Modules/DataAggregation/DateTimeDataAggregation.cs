using System;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraCharts.Demos {
    public partial class DateTimeDataAggregationDemo : ChartDemoModule {
        const int PointCount = 50000;

        Series Series {
            get { return chart.Series.Count > 0 ? chart.Series[0] : null; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public DateTimeDataAggregationDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            LoadPoints();
            ChartControl.EndInit();
        }

        void LoadPoints() {
            if(Series != null) {
                double value = 0;
                DateTime argument = TutorialConstants.Now.AddDays(-PointCount);
                NonCryptographicRandom random = NonCryptographicRandom.System;
                Series.Points.BeginUpdate();
                Series.Points.Clear();
                for(double i = 0; i < PointCount; i++) {
                    Series.Points.Add(new SeriesPoint(argument.AddDays(i), Math.Abs(value)));
                    value += (random.NextDouble() * 10.0 - 5.0);
                }
                Series.Points.EndUpdate();
            }
        }

        void chart_AxisVisualRangeChanged(object sender, AxisRangeChangedEventArgs e) {
            if(e.Axis is AxisX)
                ((AxisX)e.Axis).Title.Text = "Measure Unit: " + e.Axis.DateTimeScaleOptions.MeasureUnit;
        }
    }
}
