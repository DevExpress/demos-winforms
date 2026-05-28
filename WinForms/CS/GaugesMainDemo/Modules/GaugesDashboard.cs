using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos{
    public partial class GaugesDashboard : XtraUserControl {
        public GaugesDashboard() {
            InitializeComponent();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        [DefaultValue(null)]
        public ColorPickerControl ColorPicker { get; set; }
        protected internal void UpdateColor(Color color){
            if(ColorPicker != null)
                ColorPicker.SetColor(color);
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateColor();
        }
        void UpdateColor() {
            gasGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Information");
            coldWGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Question");
            hotWGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Critical");
            electricityGauge.Color = CommonSkins.GetSkin(LookAndFeel).Colors.GetColor("Warning");
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UpdateColor();
        }
        public GaugeControl ActiveGauge {
            get {
                if(ActiveControl != null && ActiveControl is GaugeContent) {
                    return (ActiveControl as GaugeContent).Gauge;
                }
                return null;
            }
        }
        
    }
}
