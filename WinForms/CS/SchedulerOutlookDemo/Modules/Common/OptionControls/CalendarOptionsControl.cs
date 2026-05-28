using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CalendarOptionsControl : UserControl {
        CheckEdit[] chkEditList;
        public CalendarOptionsControl() {
            InitializeComponent();
            FillTime(this.cbStartTime);
            FillTime(this.cbEndTime);
            this.chkEditList = new CheckEdit[] { this.chkSun, this.chkMo, this.chkTu, this.chkWed, this.chkThu, this.chkFri, this.chkSat };
            FillDayOfWeek(this.cbFirstDayOfWeek);            
        }

        public void LoadOptions(CommonOptions options) {
            this.cbStartTime.EditValue = options.WorkTime.Start;
            this.cbEndTime.EditValue = options.WorkTime.End;
            for (int i = 0; i < this.chkEditList.Length; i++)
                this.chkEditList[i].Checked = ((1 << i) & (int)options.WorkDays) != 0;
            this.cbFirstDayOfWeek.EditValue = options.FirstDayOfWeek;
            this.chkEnableReminders.Checked = options.EnableReminders;
            this.chkEnableNavigationButtons.Checked = options.EnableNavigationButtons;
            this.chkAllowEditAppointment.Checked = options.AllowEditAppointment;
            this.chkAllowAsyncLayout.Checked = options.AllowAsyncLayout;
        }

        public void SaveOptions(CommonOptions options) {
            TimeSpan start = (TimeSpan)this.cbStartTime.EditValue;
            TimeSpan end = (TimeSpan)this.cbEndTime.EditValue;
            if (start > end)
                end = start + TimeSpan.FromHours(1);
            options.WorkTime = new TimeOfDayInterval(start, end);
            int workDays = 0;
            for (int i = 0; i < this.chkEditList.Length; i++)
                if (this.chkEditList[i].Checked)
                    workDays |= 1 << i;
            options.WorkDays = (WeekDays)workDays;
            options.FirstDayOfWeek = (FirstDayOfWeek)this.cbFirstDayOfWeek.EditValue;
            options.EnableReminders = this.chkEnableReminders.Checked;
            options.EnableNavigationButtons = this.chkEnableNavigationButtons.Checked;
            options.AllowEditAppointment = this.chkAllowEditAppointment.Checked;
            options.AllowAsyncLayout = this.chkAllowAsyncLayout.Checked;
        }

        void FillTime(ComboBoxEdit cbTime) {
            cbTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            cbTime.Properties.DisplayFormat.FormatString = @"hh\:mm";
            TimeSpan span = TimeSpan.Zero;
            while (span < TimeSpan.FromHours(23)) {
                cbTime.Properties.Items.Add(span);
                span += TimeSpan.FromMinutes(15);
            }
        }
        void FillDayOfWeek(ComboBoxEdit cbDayOfWeek) {
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Sunday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Monday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Tuesday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Wednesday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Thursday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Friday);
            cbDayOfWeek.Properties.Items.Add(FirstDayOfWeek.Saturday);            
        }
    }
}
