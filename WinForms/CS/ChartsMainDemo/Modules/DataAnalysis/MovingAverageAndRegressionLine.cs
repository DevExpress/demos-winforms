using System;

namespace DevExpress.XtraCharts.Demos {
    public partial class MovingAverageAndRegressionLineDemo : ChartDemoModuleWithOptions {
        Series Series {
            get { return chart.Series.Count > 0 ? chart.Series[0] : null; }
        }
        XYDiagramSeriesViewBase SeriesView {
            get { return Series != null ? Series.View as XYDiagramSeriesViewBase : null; }
        }

        internal override ChartControl ChartControl {
            get { return chart; }
        }


        public MovingAverageAndRegressionLineDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            Series.BindToData(PointGenerator.Generate(), "Argument", "Value");
            checkEditRegressionLineVisible.Checked = true;
            radioGroupMovingAverage.SelectedIndex = 0;
            comboBoxEditMovingAverageKind.SelectedIndex = 0;
            XYDiagram diagram = (XYDiagram)ChartControl.Diagram;
            ChartControl.Diagram = diagram;
            ChartControl.EndInit();
            ChartControl.BeginInit();
            diagram.AxisX.VisualRange.SetMinMaxValues(-1250, 1250);
            diagram.AxisY.VisualRange.SetMinMaxValues(-700, 1800);
            ChartControl.EndInit();
        }

        MovingAverage GetMovingAverage() {
            if(SeriesView == null)
                return null;
            string indicatorName = radioGroupMovingAverage.EditValue as string;
            foreach(Indicator indicator in SeriesView.Indicators) {
                if(indicator is MovingAverage && indicator.Name == indicatorName)
                    return (MovingAverage)indicator;
            }
            return null;
        }
        void HideAllMovingAverages() {
            if(SeriesView == null)
                return;
            foreach(Indicator indicator in SeriesView.Indicators) {
                if(indicator is MovingAverage)
                    indicator.Visible = false;
            }
        }
        void checkEditRegressionLineVisible_CheckedChanged(object sender, EventArgs e) {
            if(SeriesView == null)
                return;
            foreach(Indicator indicator in SeriesView.Indicators) {
                if(indicator is RegressionLine)
                    indicator.Visible = checkEditRegressionLineVisible.Checked;
            }
        }
        void radioGroupMovingAverage_SelectedIndexChanged(object sender, EventArgs e) {
            string indicatorName = radioGroupMovingAverage.EditValue as string;
            HideAllMovingAverages();
            MovingAverage movingAverage = GetMovingAverage();
            if(movingAverage == null)
                return;
            movingAverage.Visible = true;
            spinEditPointsCount.Value = movingAverage.PointsCount;
            spinEditEnvelopePercent.Value = (decimal)movingAverage.EnvelopePercent;
            comboBoxEditMovingAverageKind.SelectedIndex = (int)movingAverage.Kind;
        }
        void spinEditPointsCount_Properties_ValueChanged(object sender, EventArgs e) {
            MovingAverage movingAverage = GetMovingAverage();
            if(movingAverage == null)
                return;
            movingAverage.PointsCount = (int)spinEditPointsCount.Value;
        }
        void comboBoxEditMovingAverageKind_SelectedIndexChanged(object sender, EventArgs e) {
            MovingAverage movingAverage = GetMovingAverage();
            if(movingAverage == null)
                return;
            movingAverage.Kind = (MovingAverageKind)comboBoxEditMovingAverageKind.SelectedIndex;
            if(comboBoxEditMovingAverageKind.SelectedIndex == 0)
                spinEditEnvelopePercent.Enabled = false;
            else
                spinEditEnvelopePercent.Enabled = true;
        }
        void spinEditEnvelopePercent_Properties_ValueChanged(object sender, EventArgs e) {
            MovingAverage movingAverage = GetMovingAverage();
            if(movingAverage == null)
                return;
            movingAverage.EnvelopePercent = (double)spinEditEnvelopePercent.Value;
        }
    }
}
