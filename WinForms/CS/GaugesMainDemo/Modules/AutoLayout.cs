using DevExpress.XtraGauges.Core.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class AutoLayoutFeature : TutorialControl {
        public AutoLayoutFeature() {
            InitializeComponent();
            trackBarControl1.Value = 6;
            trackBarControl2.Value = 6;
        }
        void trackBarControl1_EditValueChanged(object sender, System.EventArgs e) {
            gaugeControl1.LayoutInterval = trackBarControl1.Value;
            gaugeControl2.LayoutInterval = trackBarControl1.Value;
        }
        void trackBarControl2_EditValueChanged(object sender, System.EventArgs e) {
            gaugeControl1.LayoutPadding = new Thickness(trackBarControl2.Value);
            gaugeControl2.LayoutPadding = new Thickness(trackBarControl2.Value);
        }
    }
}
