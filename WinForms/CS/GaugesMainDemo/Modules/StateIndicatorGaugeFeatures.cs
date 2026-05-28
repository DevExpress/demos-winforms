using System;

namespace DevExpress.XtraGauges.Demos {
    public partial class StateIndicatorGaugeFeatures : TutorialControl {
        public StateIndicatorGaugeFeatures() {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region StateIndicator Gauge
        void StateIndicatorGaugeFeatures_Load(object sender, EventArgs e) {
            smilesState.Value = stateIndicatorComponent3.StateIndex;
            arrowsState.Value = stateIndicatorComponent2.StateIndex;
            elLightsState.Value = stateIndicatorComponent1.StateIndex;
            trafficLightState.Value = stateIndicatorComponent4.StateIndex;

            this.trafficLightState.EditValueChanged += new System.EventHandler(this.OnTrafficLightStateChanged);
            this.elLightsState.EditValueChanged += new System.EventHandler(OnElLightStateChanged);
            this.arrowsState.EditValueChanged += new System.EventHandler(OnArrowStateChanged);
            this.smilesState.EditValueChanged += new System.EventHandler(OnSmileStateChanged);
            this.currencyState.EditValueChanged += new System.EventHandler(OnCurrencyStateChanged);
            this.flagsState.EditValueChanged += new System.EventHandler(OnFlagStateChanged);
        }
        void OnFlagStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent6.StateIndex = flagsState.Value;
        }
        void OnCurrencyStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent5.StateIndex = currencyState.Value;
        }
        void OnTrafficLightStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent4.StateIndex = trafficLightState.Value;
        }
        void OnSmileStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent3.StateIndex = smilesState.Value;
        }
        void OnArrowStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent2.StateIndex = arrowsState.Value;
        }
        void OnElLightStateChanged(object sender, EventArgs e) {
            stateIndicatorComponent1.StateIndex = elLightsState.Value;
        }
        #endregion
        protected override bool? AllowBorderRounding {
            get { return false; }
        }
    }
}
