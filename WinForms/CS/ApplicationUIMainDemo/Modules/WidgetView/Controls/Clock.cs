using DevExpress.DXperience.Demos;
using System;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class Clock : XtraEditors.XtraUserControl {
        Timer timer = new Timer();
        public Clock() {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += OnTick;
            timer.Start();
            OnTick(null, null);
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                DisableTimer();
            }
            base.Dispose(disposing);
        }
        void DisableTimer() {
            if(timer != null) {
                timer.Tick -= OnTick;
                timer.Stop();
                timer.Dispose();
            }
            timer = null;
        }
        void OnTick(object sender, EventArgs e) {
            if(IsDisposed) {
                DisableTimer();
                return;
            }
            var currentDate = MainFormHelper.TakeScreens ? TutorialConstants.Now : DateTime.Now;
            labelControl1.Text =
                "<b>" + currentDate.ToLongTimeString() +
                "</b><br><size=10>" + currentDate.ToLongDateString();
        }
    }
}
