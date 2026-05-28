using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Styles;
using DevExpress.XtraGauges.Presets.Localization;
using DevExpress.XtraGauges.Presets.Styles;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Win.Gauges.Digital;
using DevExpress.XtraLayout;

namespace DevExpress.XtraGauges.Demos {
    public partial class GaugeStylesXPF : TutorialControl {
        List<RadioButton> radioButton = new List<RadioButton>();
        public GaugeStylesXPF() {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 166;
            timer.Tick += OnTimerTick;
            ApplyLocalization();
        }
        void ApplyLocalization() {
            Clever.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClever);
            Classic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClassic);
            Future.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeFuture);
            MagicLight.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeMagicLight);
            iStyle.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeiStyle);
            Eco.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeEco);
            Cosmic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeCosmic);
            Smart.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeSmart);
            Progressive.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeProgressive);
            YellowSubmarine.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeYellowSubmarine);
            Red.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeRed);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            foreach(var item in layoutControl1.Controls) {
                if(item is RadioButton)
                    radioButton.Add((RadioButton)item);
            }
            timer.Start();
        }
        void ApplySelectStyle(object sender, EventArgs e) {
            foreach(RadioButton item in radioButton) 
                if(item.Checked) OnThemeRadioButtonCheckedChanged(item, EventArgs.Empty);
        }
        void OnThemeRadioButtonCheckedChanged(object sender, EventArgs e) {
            if(tabbedControlGroup2.SelectedTabPage == null)
                return;
            RadioButton radioButton = sender as RadioButton;
            if(radioButton.Checked) {
                StyleCollectionKey key = new StyleCollectionKey(tabbedControlGroup2.SelectedTabPage.Name);
                key.Name = radioButton.Text.Replace(" ", "");
                key.Tag = (string)tabbedControlGroup2.SelectedTabPage.Tag;
                StyleCollection styleCollection = StyleLoader.Load(key);
                if(styleCollection == null)
                    return;
                switch(tabbedControlGroup2.SelectedTabPage.Name) {
                    case "Circular":
                        styleCollection.Apply(circularGauge1);
                        break;
                    case "Digital":
                        styleCollection.Apply(digitalGauge1);
                        break;
                    case "Linear":
                        styleCollection.Apply(linearGauge1);
                        break;
                }
            }
        }
        #region Animation
        int animationLockCounterCore = 0;
        readonly Timer timer;
        bool IsAnimationLocked {
            get { return animationLockCounterCore > 0; }
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(IsAnimationLocked)
                return;
            LayoutGroup activePage = tabbedControlGroup2.SelectedTabPage;
            if(!tabbedControlGroup2.Visible || activePage == null)
                return;
            LockAnimation();
            List<GaugeControl> gauges = CollectChildGauges();
            foreach(GaugeControl gauge in gauges) DoAnimation(gauge);
            UnlockAnimation();
        }
        void UnlockAnimation() {
            animationLockCounterCore--;
        }
        void LockAnimation() {
            animationLockCounterCore++;
        }
        void DoAnimation(GaugeControl gauge) {
            foreach(IGauge gb in gauge.Gauges) {
                ICircularGauge cGauge = gb as ICircularGauge;
                if(cGauge != null) {
                    foreach(IScale _scale in cGauge.Scales) _scale.Value = AnimateScaleValue(_scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if(lGauge != null) {
                    foreach(IScale _scale in lGauge.Scales) _scale.Value = AnimateScaleValue(_scale);
                }
                DigitalGauge dGauge = gb as DigitalGauge;
                if(dGauge != null) 
                    dGauge.Text = AnimateStringValue(dGauge);
            }
        }
        List<GaugeControl> CollectChildGauges() {
            List<GaugeControl> result = new List<GaugeControl>();
            foreach(var item in layoutControl1.Controls) {
                if(item is GaugeControl)
                    result.Add((GaugeControl)item);
            }
            return result;
        }
        float AnimateScaleValue(IScale scale) {
            var random = DevExpress.Data.Utils.NonCryptographicRandom.System;
            float deviation = ((float)random.NextDouble() - (scale as IConvertibleScale).Percent);
            return scale.Value + (scale.ScaleLength * 0.025f) * deviation;
        }
        string AnimateStringValue(DigitalGauge dGauge) {
            int value = DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            return value.ToString();
        }
        #endregion
        protected override bool? UseRoundedPanel {
            get { return false; }
        }
    }
}
