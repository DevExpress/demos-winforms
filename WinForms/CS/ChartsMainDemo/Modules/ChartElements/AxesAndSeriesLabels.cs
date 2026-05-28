using System;

namespace DevExpress.XtraCharts.Demos {
    public partial class AxesAndSeriesLabelsDemo : ChartDemoModuleWithOptions {
        AxisLabelResolveOverlappingOptions AxisResolveOverlappingOptions {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                return diagram != null ? diagram.AxisX.Label.ResolveOverlappingOptions : null;
            }
        }
        PointSeriesLabel SeriesLabel {
            get {
                if(chart.Series.Count == 0)
                    return null;
                return chart.Series[0].Label as PointSeriesLabel;
            }
        }
        AxisX AxisX {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                return diagram != null ? diagram.AxisX : null;
            }
        }
        AxisY AxisY {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                return diagram != null ? diagram.AxisY : null;
            }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public AxesAndSeriesLabelsDemo() {
            InitializeComponent();
            InitControls();
        }

        void InitControls() {
            spinEditAxisLabelsMinIndent.Value = AxisResolveOverlappingOptions.MinIndent;
            checkEditAllowStaggerAxisLabels.Checked = AxisResolveOverlappingOptions.AllowStagger;
            checkEditAllowRotateAxisLabels.Checked = AxisResolveOverlappingOptions.AllowRotate;
            checkEditAllowHideAxisLabels.Checked = AxisResolveOverlappingOptions.AllowHide;
            spinEditSeriesLabelsMinIndent.Value = SeriesLabel.ResolveOverlappingMinIndent;
            comboBoxEditSeriesLabelsResolveOverlappingMode.SelectedIndex = (int)SeriesLabel.ResolveOverlappingMode;
            comboBoxEditAxisXLabelsPattern.SelectedIndex = 0;
            comboBoxEditSeriesLabelsPattern.SelectedIndex = 0;
            checkEditShowCustomLabels.Checked = true;
            comboBoxEditCustomLabelsMode.SelectedIndex = 1;
        }

        void spinEditAxisLabelsMinIndent_EditValueChanged(object sender, EventArgs e) {
            if(AxisResolveOverlappingOptions != null)
                AxisResolveOverlappingOptions.MinIndent = (int)spinEditAxisLabelsMinIndent.Value;
        }
        void checkEditAllowStaggerAxisLabels_CheckedChanged(object sender, EventArgs e) {
            if(AxisResolveOverlappingOptions != null)
                AxisResolveOverlappingOptions.AllowStagger = checkEditAllowStaggerAxisLabels.Checked;
        }
        void checkEditAllowRotateAxisLabels_CheckedChanged(object sender, EventArgs e) {
            if(AxisResolveOverlappingOptions != null)
                AxisResolveOverlappingOptions.AllowRotate = checkEditAllowRotateAxisLabels.Checked;
        }
        void checkEditAllowHideAxisLabels_CheckedChanged(object sender, EventArgs e) {
            if(AxisResolveOverlappingOptions != null)
                AxisResolveOverlappingOptions.AllowHide = checkEditAllowHideAxisLabels.Checked;
        }
        void spinEditSeriesLabelsMinIndent_EditValueChanged(object sender, EventArgs e) {
            if(SeriesLabel != null)
                SeriesLabel.ResolveOverlappingMinIndent = (int)spinEditSeriesLabelsMinIndent.Value;
        }
        void comboBoxEditSeriesLabelsResolveOverlappingMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(SeriesLabel != null && SeriesLabel.Position == PointLabelPosition.Outside)
                SeriesLabel.ResolveOverlappingMode = (ResolveOverlappingMode)comboBoxEditSeriesLabelsResolveOverlappingMode.SelectedIndex;
        }
        void comboBoxEditAxisXLabelsPattern_TextChanged(object sender, EventArgs e) {
            if(AxisX != null)
                AxisX.Label.TextPattern = comboBoxEditAxisXLabelsPattern.Text;
        }
        void comboBoxEditSeriesLabelsPattern_TextChanged(object sender, EventArgs e) {
            if(SeriesLabel != null)
                SeriesLabel.TextPattern = comboBoxEditSeriesLabelsPattern.Text;
        }
        void checkEditShowCustomLabels_CheckedChanged(object sender, EventArgs e) {
            comboBoxEditCustomLabelsMode.Enabled = checkEditShowCustomLabels.Checked;
            if(AxisY != null)
                foreach(CustomAxisLabel label in AxisY.CustomLabels)
                    label.Visible = checkEditShowCustomLabels.Checked;
        }
        void comboBoxEditCustomLabelsMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(AxisY != null)
                AxisY.LabelVisibilityMode = (AxisLabelVisibilityMode)comboBoxEditCustomLabelsMode.SelectedIndex;
        }
    }
}
