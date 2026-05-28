using System;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Native;

namespace DevExpress.XtraScheduler.Demos {
	public partial class RangeControlModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const int DailySchedulerType = 0;
        const int MonthlySchedulerType = 1;
        const int YearlySchedulerType = 2;
        DateTime startDate = CarsDataHelper.GetStartDate();

        public RangeControlModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            UpdateSchedulerType(DailySchedulerType);

            InitPropertyEditors();
            
            // TODO: Add any initialization after the InitializeComponent call
        }
        protected override int TakeScreenDelay => 300;
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
        public SchedulerOptionsRangeControl Options { get { return schedulerControl.OptionsRangeControl; } }

		private void MonthViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
        private void InitPropertyEditors() {
            chkAutoFormatCaptions.Checked = Options.AutoFormatScaleCaptions;
            chkAllowChangeActiveView.Checked = Options.AllowChangeActiveView;
            Options.MaxSelectedIntervalCount = 7;
            spinMaxIntervalCount.EditValue = Options.MaxSelectedIntervalCount;
            spinThumbnailHeight.EditValue = Options.ThumbnailHeight;
            cbThumbnailDisplay.EditValue = Options.DataDisplayType;
        }
        private void rgrpSchedulerType_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSchedulerType(Convert.ToInt32(rgrpSchedulerType.EditValue)); 
        }
        private void chkAutoFormatCaptions_CheckedChanged(object sender, EventArgs e) {
            Options.AutoFormatScaleCaptions = chkAutoFormatCaptions.Checked; 
        }
        private void chkAllowChangeActiveView_CheckedChanged(object sender, EventArgs e) {
            Options.AllowChangeActiveView = chkAllowChangeActiveView.Checked;
        }
        private void cbThumbnailDisplay_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxItem item = (ImageComboBoxItem)cbThumbnailDisplay.SelectedItem;
            Options.DataDisplayType = (RangeControlDataDisplayType)item.Value;
        }
        private void spinMaxIntervalCount_EditValueChanged(object sender, EventArgs e) {
            Options.MaxSelectedIntervalCount = Convert.ToInt32(spinMaxIntervalCount.EditValue);
        }
        private void spinThumbnailHeight_EditValueChanged(object sender, EventArgs e) {
            Options.ThumbnailHeight = Convert.ToInt32(spinThumbnailHeight.EditValue);
        }
        private void UpdateSchedulerType(int schedulerType) {
            DateTime baseDate = startDate;

            TimeScaleCollection scales = schedulerControl.OptionsRangeControl.Scales;
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
                        schedulerControl.ActiveViewType = SchedulerViewType.Month;
                        break;
                    }
                case YearlySchedulerType: {
                        scales.Add(new TimeScaleYear());
                        scales.Add(new TimeScaleQuarter());
                        scales.Add(new TimeScaleMonth());
                        rangeInterval = new TimeInterval(baseDate.AddYears(-1), baseDate.AddYears(1));
                        schedulerControl.ActiveViewType = SchedulerViewType.Timeline;
                        break;
                    }
            }
            scales.EndUpdate();
            
            SetRangeInterval(rangeInterval);
            chkAutoFormatCaptions.Enabled = schedulerType != YearlySchedulerType;
        }
        private void SetRangeInterval(TimeInterval interval) {
            Options.RangeMinimum = interval.Start;
            Options.RangeMaximum = interval.End;

            schedulerControl.LimitInterval = interval;
        }

	}
}
