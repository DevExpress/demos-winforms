using System;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraCharts.Demos {
    public partial class TimeSpanDataAggregationDemo : ChartDemoModule {
        const int PointCount = 50000;

        XYDiagram Diagram {
            get { return chart.Diagram as XYDiagram; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public TimeSpanDataAggregationDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            GeneratePoints(chart.Series[0], 20, 35, 80);
            GeneratePoints(chart.Series[1], 20, 25, 50);
            ChartControl.EndInit();
        }
        void GeneratePoints(Series series, double initialValue, double min, double max) {
            if(series != null) {
                series.Points.BeginUpdate();
                series.Points.Clear();
                double value = initialValue;
                double threshold = (min - initialValue) / 0.2;
                for(double i = 0; i < threshold; i++) {
                    series.Points.Add(new SeriesPoint(TimeSpan.FromSeconds(i), value));
                    value += TutorialConstants.Random.NextDouble() - 0.3;
                }
                for(double i = threshold; i < PointCount; i++) {
                    series.Points.Add(new SeriesPoint(TimeSpan.FromSeconds(i), value));
                    value = Math.Max(Math.Min(value + TutorialConstants.Random.NextDouble() - 0.5, max), min);
                }
                series.Points.EndUpdate();
            }
        }
        void Chart_AxisVisualRangeChanged(object sender, AxisRangeChangedEventArgs e) {
            AxisX axisX = Diagram.AxisX;
            AxisY axisY = Diagram.AxisY;
            if(axisX.Equals(e.Axis)) {
                axisX.Title.Text = "Measure Unit: " + e.Axis.TimeSpanScaleOptions.MeasureUnit;
            }
            else if(axisY.Equals(e.Axis)) {
                Diagram.SecondaryAxesY[0].WholeRange.SetMinMaxValues(Utils.ConvertCelsiusToFahrenheit(axisY.VisualRange.MinValueInternal),
                    Utils.ConvertCelsiusToFahrenheit(axisY.VisualRange.MaxValueInternal));
            }
        }
        void Chart_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            if(e.CrosshairElementGroups.Count > 0 && e.CrosshairElementGroups[0].CrosshairElements.Count > 0) {
                foreach(CrosshairElement element in e.CrosshairElementGroups[0].CrosshairElements) {
                    if(element.LabelElement != null && element.SeriesPoint != null)
                        element.LabelElement.Text += string.Format(", {0:0}°F", Utils.ConvertCelsiusToFahrenheit(element.SeriesPoint.Values[0]));
                }
            }
        }
    }
}
