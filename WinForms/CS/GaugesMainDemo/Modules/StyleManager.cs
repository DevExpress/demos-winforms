using System;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraGauges.Base;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Gauges.Digital;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Core;
using DevExpress.XtraLayout;

namespace DevExpress.XtraGauges.Demos {
    public partial class StyleManagerFeature : TutorialControl {
        public StyleManagerFeature() {
            InitializeComponent();
            containers = new IGaugeContainer[] { gControl1, gControl2, gControl3, gControl4 };
            layoutControl1.AllowCustomization = false;
            this.Load += new EventHandler(OnLoad);
            tabGroup.SelectedPageChanged += tabGroup_SelectedPageChanged;
        }
        void tabGroup_SelectedPageChanged(object sender, LayoutTabPageChangedEventArgs e) {
            btnStyleChooser.Enabled = tabGroup.TabPages.IndexOf(e.Page) != 3;
        }
        int animationLockCounterCore = 0;
        Timer timer;
        bool IsAnimationLocked {
            get { return animationLockCounterCore > 0; }
        }
        void OnLoad(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 166;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(IsAnimationLocked || !Visible) return;
            LockAnimation();
            IEnumerable<IGaugeContainer> gControls = CollectChildGauges(layoutControl1);
            foreach(IGaugeContainer gauge in gControls)
                DoAnimation(gauge);
            UnlockAnimation();
        }
        void UnlockAnimation() {
            animationLockCounterCore--;
        }
        void LockAnimation() {
            animationLockCounterCore++;
        }
        void DoAnimation(IGaugeContainer gauge) {
            foreach(IGauge gb in gauge.Gauges) {
                ICircularGauge cGauge = gb as ICircularGauge;
                if(cGauge != null) {
                    foreach(IBaseScale _scale in cGauge.Scales) 
                        _scale.Value = AnimateScaleValue(_scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if(lGauge != null) {
                    foreach(IBaseScale _scale in lGauge.Scales) 
                        _scale.Value = AnimateScaleValue(_scale);
                }
                IDigitalGauge dGauge = gb as IDigitalGauge;
                if(dGauge != null) {
                    dGauge.Text = AnimateStringValue(dGauge);
                }
            }
        }
        float AnimateScaleValue(IBaseScale scale) {
            var random = DevExpress.Data.Utils.NonCryptographicRandom.System;
            float deviation = ((float)random.NextDouble() - scale.Percent);
            return scale.Value + (scale.ScaleLength * 0.05f) * deviation;
        }
        string AnimateStringValue(IDigitalGauge gauge) {
            return Convert.ToString(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);
        }
        IEnumerable<IGaugeContainer> CollectChildGauges(Control parentControl) {
            List<IGaugeContainer> result = new List<IGaugeContainer>();
            foreach(Control control in parentControl.Controls) {
                if(control is IGaugeContainer)
                    result.Add(control as IGaugeContainer);
                else if(control.Controls.Count > 0) {
                    result.AddRange(CollectChildGauges(control));
                }
            }
            return result;
        }
        IGaugeContainer[] containers;
        void ShowStyleManagerClick(object sender, EventArgs e) {
            LockAnimation();
            StyleManager.Show(containers[tabGroup.SelectedTabPageIndex]);
            UnlockAnimation();
        }
        void ShowStyleChooserClick(object sender, EventArgs e) {
            LockAnimation();
            StyleChooser.Show(containers[tabGroup.SelectedTabPageIndex].Gauges[0]);
            UnlockAnimation();
        }
        protected override bool? UseRoundedPanel {
            get { return false; }
        }
    }
}
