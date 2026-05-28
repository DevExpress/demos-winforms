using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos {
    public partial class ColorSchemeGauges : TutorialControl {
        public ColorSchemeGauges() {
            InitializeComponent();
            gaugesDashboard1.ColorPicker = colorPickControl1;
            this.colorPickControl1.ResultColorChanged += ColorPickControlResultColorChanged;
        }
        void ColorPickControlResultColorChanged(object sender, InnerColorPickControlSelectedColorChangedEventArgs e) {
            var activeGauge = GetActiveGauge();
            if(activeGauge != null) {
                activeGauge.ColorScheme.Color = e.NewColor;
                gaugesDashboard1.UpdateColor(e.NewColor);
            }
        }
        GaugeControl GetActiveGauge() {
            var dashboard = ActiveControl as GaugesDashboard;
            if(dashboard != null)
                return dashboard.ActiveGauge;
            return null;
        }
    }
}
