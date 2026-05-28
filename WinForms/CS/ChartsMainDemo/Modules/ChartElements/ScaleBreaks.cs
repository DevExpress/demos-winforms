using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos {
    public partial class ScaleBreaksDemo : ChartDemoModuleWithOptions {
        Axis Axis {
            get {
                XYDiagram diagram = chart.Diagram as XYDiagram;
                return diagram != null ? diagram.AxisY : null;
            }
        }
        AutoScaleBreaks AutoScaleBreaks {
            get { return Axis != null ? Axis.AutoScaleBreaks : null; }
        }
        ScaleBreakOptions Options {
            get { return Axis != null ? Axis.ScaleBreakOptions : null; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public ScaleBreaksDemo() {
            InitializeComponent();
            if(AutoScaleBreaks != null) {
                checkEditShowScaleBreaks.Checked = AutoScaleBreaks.Enabled;
                spinEditMaxCount.EditValue = AutoScaleBreaks.MaxCount;
            }
            if(Options != null) {
                spinEditSize.EditValue = Options.SizeInPixels;
                colorEditScaleBreakColor.EditValue = Options.Color;
            }
            UpdateControlsState();
        }

        void UpdateControlsState() {
            if(Options == null || AutoScaleBreaks == null)
                return;
            spinEditMaxCount.Enabled = AutoScaleBreaks.Enabled;
            spinEditSize.Enabled = AutoScaleBreaks.Enabled;
            colorEditScaleBreakColor.Enabled = AutoScaleBreaks.Enabled;
            simpleButtonRestoreColor.Enabled = AutoScaleBreaks.Enabled && Options.Color != Color.Empty;
        }
        void checkEditShowScaleBreaks_CheckedChanged(object sender, EventArgs e) {
            if(AutoScaleBreaks != null)
                AutoScaleBreaks.Enabled = checkEditShowScaleBreaks.Checked;
            UpdateControlsState();
        }
        void spinEditSize_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.SizeInPixels = Convert.ToInt32(spinEditSize.EditValue);
        }
        void colorEditScaleBreakColor_EditValueChanged(object sender, EventArgs e) {
            if(Options != null)
                Options.Color = (Color)colorEditScaleBreakColor.EditValue;
            UpdateControlsState();
        }
        void simpleButtonRestoreColor_Click(object sender, EventArgs e) {
            if(Options != null) {
                Options.Color = Color.Empty;
                colorEditScaleBreakColor.EditValue = Options.Color;
            }
        }
        void spinEditMaxCount_EditValueChanged(object sender, EventArgs e) {
            if(AutoScaleBreaks != null)
                AutoScaleBreaks.MaxCount = Convert.ToInt32(spinEditMaxCount.EditValue);
        }
    }
}
