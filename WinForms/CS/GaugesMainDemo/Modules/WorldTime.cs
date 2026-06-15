using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;

namespace DevExpress.XtraGauges.Demos {
    public partial class WorldTime : TutorialControl {
        int lockTimerCounter = 0;
        int animationLockCounterCore = 0;
        Dictionary<string, int> timeShifts;

        bool IsAnimationLocked { get { return animationLockCounterCore > 0; } }

        public WorldTime() {
            timeShifts = new Dictionary<string, int>();
            timeShifts.Add("Washington", -4);
            timeShifts.Add("Paris", +1);
            timeShifts.Add("Madrid", +1);
            timeShifts.Add("London", +0);
            timeShifts.Add("Tokyo", +9);
            timeShifts.Add("Rome", +1);
            InitializeComponent();
            timer.Start();
            OnTimerTick(null, null);
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(lockTimerCounter == 0) {
                lockTimerCounter++;
                if(!Visible || IsAnimationLocked) return;
                LockAnimation();
                List<GaugeControl> gauges = CollectChildGauges(layoutControl1);
                foreach(GaugeControl gauge in gauges) DoAnimation(gauge);
                UnlockAnimation();
                lockTimerCounter--;
            }
        }
        void UnlockAnimation() {
            animationLockCounterCore--;
        }
        void LockAnimation() {
            animationLockCounterCore++;
        }
        void DoAnimation(GaugeControl gauge) {
            DateTime time = DateTime.UtcNow.AddHours(timeShifts[gauge.Name]);
            foreach(IGauge gb in gauge.Gauges) {
                ICircularGauge cGauge = gb as ICircularGauge;
                if(cGauge != null) {
                    UpdateClock(time, cGauge.Scales[0], cGauge.Scales[1], cGauge.Scales[2]);
                }
            }
        }
        void UpdateClock(DateTime dt, IArcScale h, IArcScale m, IArcScale s) {
            int hour = dt.Hour <= 12 ? dt.Hour : dt.Hour - 12;
            int min = dt.Minute;
            int sec = dt.Second;
            h.Value = (float)hour + (float)(min) / 60.0f;
            m.Value = ((float)min + (float)(sec) / 60.0f) / 5f;
            s.Value = sec / 5.0f;
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
