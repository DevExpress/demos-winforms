using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;

namespace DevExpress.XtraEditors.Demos.Modules {
    public partial class TimerControl : XtraUserControl {
        TimeSpan _timeValue;
        WindowsUIButton startButton, cancelButton;
        public TimerControl() {
            InitializeComponent();
            startButton = (WindowsUIButton)windowsUIButtonPanelStart.Buttons[0];
            cancelButton = (WindowsUIButton)windowsUIButtonPanelCancel.Buttons[0];
            TimeValue = TimeSpan.FromMinutes(1);
        }
        TimeSpan TimeValue {
            get { return _timeValue; }
            set {
                if(_timeValue != value) {
                    _timeValue = value;
                    timeLabel.Text = value.ToString(@"mm\:ss\:ff");
                }
            }
        }
        void Reset() {
            timer.Stop();
            timeLabel.Appearance.ForeColor = Color.CornflowerBlue;
            TimeValue = TimeSpan.FromMinutes(1);
        }
        private void OnButtonClick(object sender, XtraBars.Docking2010.ButtonEventArgs e) {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            ToggleButtonState();
            if(btn.Caption == "Start")
                timer.Start();
            else 
                Reset();
        }
        void ToggleButtonState() {
            cancelButton.Enabled = !cancelButton.Enabled;
            startButton.Enabled = !startButton.Enabled;
        }
        private void OnTick(object sender, EventArgs e) {
            TimeValue = TimeValue.Subtract(TimeSpan.FromMilliseconds(timer.Interval));
            if(TimeValue.TotalMilliseconds == 0) {
                timer.Stop();
                timeLabel.Appearance.ForeColor = Color.Red;
            }
        }
    }
}
