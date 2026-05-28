using System;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class FinancialIndicatorsDemo : ChartDemoModule {
        const int MaxZoomPointCount = 183;
        DefaultBoolean crosshairEnabled;

        XYDiagram XYDiagram {
            get { return chart.Diagram as XYDiagram; }
        }
        FinancialSeriesViewBase FinancialSeriesView {
            get {
                if(chart.Series.Count == 0)
                    return null;
                return chart.Series[0].View as FinancialSeriesViewBase;
            }
        }
        bool IsToolbarInteractionEnabled {
            get {
                return trendLineBarCheckItem.Checked || fibbArcBarCheckItem.Checked || fibbFansBarCheckItem.Checked ||
                    fibbRetrBarCheckItem.Checked || removeBarCheckItem.Checked || addTextAnnotationBarItem.Checked || addImageAnnotationBarItem.Checked;
            }
        }
        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public FinancialIndicatorsDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            ChartControl.DataSource = CsvReader.ReadFinancialData("USDJPYDaily.csv");
            ChartControl.EndInit();
            AddIndicators();
        }

        void AddIndicators() {
            FibonacciIndicator indicator = new FibonacciIndicator() {
                Kind = FibonacciIndicatorKind.FibonacciArcs,
            };
            indicator.Point1.Argument = new DateTime(2017, 9, 20);
            indicator.Point2.Argument = new DateTime(2017, 11, 20);
            FinancialSeriesView.Indicators.Add(indicator);
            indicator = new FibonacciIndicator() {
                Kind = FibonacciIndicatorKind.FibonacciFans,
            };
            indicator.Point1.Argument = new DateTime(2017, 9, 8);
            indicator.Point2.Argument = new DateTime(2017, 11, 6);
            FinancialSeriesView.Indicators.Add(indicator);
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            DateTime visualMin = ((DateTime)XYDiagram.AxisX.VisualRange.MaxValue).AddDays(-300);
            DateTime visualMax = ((DateTime)XYDiagram.AxisX.WholeRange.MaxValue).AddDays(XYDiagram.AxisX.WholeRange.SideMarginsValue);
            XYDiagram.AxisX.VisualRange.SetMinMaxValues(visualMin, visualMax);
            crosshairEnabled = ChartControl.CrosshairEnabled;
        }
        void chart_BeforeZoom(object sender, ChartBeforeZoomEventArgs e) {
            if(!(e.Axis is AxisX))
                return;
            double rangeLengthInMeasureUnits = e.NewRange.Max - e.NewRange.Min;
            if(rangeLengthInMeasureUnits > MaxZoomPointCount)
                e.Cancel = true;
        }
        void checkItem_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            ChartControl.CrosshairEnabled = IsToolbarInteractionEnabled ? DefaultBoolean.False : crosshairEnabled;
        }

        private void chart_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(IsToolbarInteractionEnabled)
                ChartControl.CrosshairEnabled = crosshairEnabled;
        }
    }
}
