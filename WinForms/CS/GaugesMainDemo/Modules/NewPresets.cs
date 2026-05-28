using System;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class NewPresets : TutorialControl {
        readonly Data.Utils.NonCryptographicRandom random = new Data.Utils.NonCryptographicRandom(10000);
        int loadingCount = 0;
        public NewPresets() {
            InitializeComponent();
            InitLevelIndicatorPage();
            InitProgressPage();
            InitRatingPage();
            InitEqualizerPage();
            loadingTimer.Start();
            equalizerTimer.Interval = 200;
            equalizerTimer.Start();
        }
        void InitLevelIndicatorPage() {
            equalizerLevel.Value = (int)((ILinearGauge)levelIndicator.Gauges[0]).Scales[0].Value;
        }
        void InitProgressPage() {
            ratingValue.SelectedIndex = 2;
        }
        void InitRatingPage() {
            progressValue.Value = (int)((ILinearGauge)progress1.Gauges[0]).Scales[0].Value;
        }
        void InitEqualizerPage() {
            foreach(IScale _scale in ((ILinearGauge)equalizer.Gauges[0]).Scales) 
                _scale.Value = 0;
        }
        void OnLevelIndicatorValueChanged(object sender, EventArgs e) {
            ((ILinearGauge)levelIndicator.Gauges[0]).Scales[0].Value = equalizerLevel.Value;
        }
        void OnProgressValueChanged(object sender, EventArgs e) {
            ((ILinearGauge)progress1.Gauges[0]).Scales[0].Value = progressValue.Value;
            ((ILinearGauge)progress2.Gauges[0]).Scales[0].Value = progressValue.Value;
        }
        void OnRatingChanged(object sender, EventArgs e) {
            ((ILinearGauge)rating.Gauges[0]).Scales[0].Value = (int)ratingValue.EditValue;
        }
        void OnLoadingTimerTick(object sender, EventArgs e) {
            ((ILinearGauge)rating1.Gauges[0]).Scales[0].Value = (float)(++loadingCount % 10) * 10f + (float)DateTime.Now.Millisecond * 0.01f;
        }
        void OnEqualizerTimerTick(object sender, EventArgs e) {
            int freqCount = ((ILinearGauge)equalizer.Gauges[0]).Scales.Count;
            for(int i = 0; i < freqCount; i++) {
                double timeFactor = ((double)DateTime.Now.Millisecond + (double)i * 50d) * 0.0002d;
                float noiseFactor = (float)random.NextDouble() * 0.4f;
                float f = (float)Math.Sin(Math.PI * timeFactor) + noiseFactor;
                ((ILinearGauge)equalizer.Gauges[0]).Scales[i].Value = 20f + 60f * f; ;
            }
        }
        protected override bool? UseRoundedPanel {
            get { return false; }
        }
    }
}
