using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Gauges.Digital;
using DevExpress.XtraTab;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Win.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class GaugesNewStyles : TutorialControl {
        int animationLockCounterCore = 0;
        Timer timer;
        bool IsAnimationLocked {
            get { return animationLockCounterCore > 0; }
        }
        public GaugesNewStyles() {
            InitializeComponent();
            this.Load += new EventHandler(OnLoad);
        }
        void OnLoad(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 166;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(IsAnimationLocked) return;
            DevExpress.XtraBars.Navigation.TabNavigationPage activePage = xtraTabControl1.SelectedPage;
            if(!xtraTabControl1.Visible || activePage == null) return;
            LockAnimation();
            List<GaugeControl> gauges = CollectChildGauges(activePage);
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
                if(cGauge!=null) {
                    foreach(IScale _scale in cGauge.Scales) _scale.Value = AnimateScaleValue(_scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if(lGauge!=null) {
                    foreach(IScale _scale in lGauge.Scales) _scale.Value = AnimateScaleValue(_scale);
                }
                DigitalGauge dGauge = gb as DigitalGauge;
                if(dGauge != null) {
                    dGauge.Text = AnimateStringValue(dGauge);
                }
            }
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
        List<GaugeControl> CollectChildGauges(Control parentControl) {
            List<GaugeControl> result = new List<GaugeControl>();
            foreach(Control control in parentControl.Controls) {
                if(control is GaugeControl) result.Add(control as GaugeControl);
                else if(control.Controls.Count > 0) {
                    result.AddRange(CollectChildGauges(control));
                }
            }
            return result;
        }
    }
}
