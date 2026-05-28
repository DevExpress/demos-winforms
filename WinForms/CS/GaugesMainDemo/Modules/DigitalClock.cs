using System;

namespace DevExpress.XtraGauges.Demos {
    public partial class DigitalClock : TutorialControl {
        int lockTimerCounter = 0;
        public DigitalClock() {
            InitializeComponent();
            timer.Start();
            OnTimerTick(null, null);
        }
        int GetStringLength(string str) {
            int counter = 0;
            int pos = 0;
            while(pos < str.Length) {
                if(str[pos] != ':')
                    counter++;
                pos++;
            }
            return counter;
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(lockTimerCounter == 0) {
                lockTimerCounter++;
                UpdateTime();
                lockTimerCounter--;
            }
        }
        void UpdateTime() {
            string time = DateTime.Now.ToLongTimeString();
            if(GetStringLength(time) > digitalGauge2.DigitCount)
                digitalGauge2.DigitCount = GetStringLength(time);
            digitalGauge2.Text = time;
        }
    }
}
