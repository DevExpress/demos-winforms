using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler.Demos.DemoData;

namespace DevExpress.XtraScheduler.Demos {
    public partial class RangeControlModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const int DailySchedulerType = 0;
        const int MonthlySchedulerType = 1;
        const int YearlySchedulerType = 2;
        
        public RangeControlModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            Scheduler.LimitInterval = new TimeInterval(SchedulerDataHelper.Start.AddYears(-10), SchedulerDataHelper.Start.AddYears(10));
            Scheduler.Start = SchedulerDataHelper.Start;
            UpdateSchedulerType(DailySchedulerType);
            ResetOptions();
        }
        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }
        
        void OnModuleLoad(object sender, EventArgs e) {
            SchedulerDataHelper.Attach(this.schedulerControl);
        }
        
        void rgrpSchedulerType_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSchedulerType(Convert.ToInt32(this.rgrpSchedulerType.EditValue));
        }

        void chkAutoFormatCaptions_CheckedChanged(object sender, EventArgs e) {
            Scheduler.OptionsRangeControl.AutoFormatScaleCaptions = this.chkAutoFormatCaptions.Checked;
        }

        void chkAllowChangeActiveView_CheckedChanged(object sender, EventArgs e) {
            Scheduler.OptionsRangeControl.AllowChangeActiveView = this.chkAllowChangeActiveView.Checked;
        }

        void cbThumbnailDisplay_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxItem item = (ImageComboBoxItem)this.cbThumbnailDisplay.SelectedItem;
            Scheduler.OptionsRangeControl.DataDisplayType = (RangeControlDataDisplayType)item.Value;
        }

        void spinMaxIntervalCount_EditValueChanged(object sender, EventArgs e) {
            Scheduler.OptionsRangeControl.MaxSelectedIntervalCount = Convert.ToInt32(this.spinMaxIntervalCount.EditValue);
        }

        void spinThumbnailHeight_EditValueChanged(object sender, EventArgs e) {
            Scheduler.OptionsRangeControl.ThumbnailHeight = Convert.ToInt32(this.spinThumbnailHeight.EditValue);
        }

        void UpdateSchedulerType(int schedulerType) {
            DateTime baseDate = Scheduler.Start;
            TimeScaleCollection scales = Scheduler.OptionsRangeControl.Scales;
            scales.BeginUpdate();
            scales.Clear();
            TimeInterval rangeInterval = TimeInterval.Empty;
            switch (schedulerType) {
                case DailySchedulerType: {
                        scales.Add(new TimeScaleWeek());
                        scales.Add(new TimeScaleDay());
                        rangeInterval = new TimeInterval(baseDate.AddDays(-10), baseDate.AddDays(50));
                        break;
                    }
                case MonthlySchedulerType: {
                        TimeScaleMonth monthScale = new TimeScaleMonth();
                        monthScale.DisplayFormat = "yyyy MMMM";
                        scales.Add(monthScale);
                        TimeScaleWeek weekScale = new TimeScaleWeek();
                        weekScale.DisplayFormat = "MM/dd";
                        weekScale.Width = 80;
                        scales.Add(weekScale);
                        rangeInterval = new TimeInterval(baseDate.AddMonths(-3), baseDate.AddMonths(3));
                        Scheduler.ActiveViewType = SchedulerViewType.Month;
                        break;
                    }
                case YearlySchedulerType: {
                        scales.Add(new TimeScaleYear());
                        scales.Add(new TimeScaleQuarter());
                        scales.Add(new TimeScaleMonth());
                        rangeInterval = new TimeInterval(baseDate.AddYears(-1), baseDate.AddYears(1));
                        Scheduler.ActiveViewType = SchedulerViewType.Timeline;
                        break;
                    }
            }
            scales.EndUpdate();

            SetRangeInterval(rangeInterval);
            this.chkAutoFormatCaptions.Enabled = schedulerType != YearlySchedulerType;
        }

        void SetRangeInterval(TimeInterval interval) {
            Scheduler.OptionsRangeControl.RangeMinimum = interval.Start;
            Scheduler.OptionsRangeControl.RangeMaximum = interval.End;
            Scheduler.LimitInterval = interval;
        }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkAutoFormatCaptions.Checked = true;
                this.chkAllowChangeActiveView.Checked = true;
                this.spinMaxIntervalCount.EditValue = 7;
                this.spinThumbnailHeight.EditValue = 0;
                this.cbThumbnailDisplay.EditValue = RangeControlDataDisplayType.Auto;
                this.rgrpSchedulerType.EditValue = 0;
            } finally {
                Scheduler.EndUpdate();
            }
        }
    }
}
