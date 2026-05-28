using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Demos.DemoData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class TimelineViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const int DefaultTimeScaleWidth = 75;

        public TimelineViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            HideUnusedViews();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkAutoHeight.Checked = false;
                this.spinMinHeight.Enabled = this.chkAutoHeight.Checked;
                this.spinMaxHeight.Enabled = this.chkAutoHeight.Checked;
                this.spinHeight.Value = 0;
                this.spinMinHeight.Value = 0;
                this.spinMaxHeight.Value = 0;
                this.cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto;
                this.cbStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.chkSelectionBarVisible.Checked = true;
                this.chkStatusOrientation.Checked = true;
                this.chkSetResourceHeight.Checked = false;
                this.lciResourceHeight.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                this.spinResourceHeight.EditValue = 200;
                RestoreDefaultScales();
                UpdateTimeScaleWidthTrackBar();
                this.chkShowOverAppointment.Checked = false;
                this.cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.CurrentDate;
                this.chkStretchAppointments.Checked = Scheduler.TimelineView.AppointmentDisplayOptions.StretchAppointments;
                this.chkStretchAppointments.Enabled = !this.chkAutoHeight.Checked;
                Scheduler.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never;
                Scheduler.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        protected override IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new string[] {
                "AppointmentStatusDisplayType",
                "ShowTimeIndicatorOverAppointment",
                "ShowAppointmentStatusVertically"
            };
        }

        void OnTimelineViewModuleLoad(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(this.schedulerControl);
            ResetOptions();
        }

        void OnTimelineViewModuleVisibleChanged(object sender, System.EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Timeline;
        }

        void OnChkSelectionBarVisibleCheckedChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.SelectionBar.Visible = this.chkSelectionBarVisible.Checked;
        }

        void OnChkFixedResourceHeightCheckedChanged(object sender, EventArgs e) {
            var checkEdit = (CheckEdit)sender;
            this.chkCellAutoHeight.Enabled = !checkEdit.Checked;
            Scheduler.BeginUpdate();
            try {
                int resourceHeight = (int)this.spinResourceHeight.Value;
                Scheduler.TimelineView.ResourceHeight = checkEdit.Checked ? resourceHeight : 0;
                this.lciResourceHeight.Visibility = checkEdit.Checked ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
                Scheduler.GroupType = SchedulerGroupType.Resource;
            } finally {
                Scheduler.EndUpdate();
            }
        }
        void OnSpinResourceHeightEditValueChanged(object sender, EventArgs e) {
            if (Scheduler.TimelineView.ResourceHeight <= 0)
                return;
            SpinEdit spinEdit = (SpinEdit)sender;
            Scheduler.TimelineView.ResourceHeight = this.chkSetResourceHeight.Checked ? (int)spinEdit.Value : 0;
        }

        void OnChkCellAutoHeightCheckedChanged(object sender, EventArgs e) {
            var checkEdit = (CheckEdit)sender;
            Scheduler.BeginUpdate();
            try {
                if (checkEdit.Checked) {
                    this.chkSetResourceHeight.Enabled = false;
                    Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = SchedulerCellAutoHeightMode.Full;
                    Scheduler.TimelineView.CellsAutoHeightOptions.MinHeight = 100;
                    Scheduler.TimelineView.CellsAutoHeightOptions.MaxHeight = 500;
                    Scheduler.GroupType = SchedulerGroupType.Resource;
                } else {
                    this.chkSetResourceHeight.Enabled = true;
                    Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = SchedulerCellAutoHeightMode.None;
                }
            } finally {
                Scheduler.EndUpdate();
            }
        }

        void OnBtnEditScalesClick(object sender, EventArgs e) {
            TimeScalesEditForm form = new TimeScalesEditForm(Scheduler.TimelineView.Scales, FindForm());
            form.RestoreDefaultClicked += OnRestoreDefaultScalesClicked;
            form.ShowDialog();
            UpdateTimeScaleWidthTrackBar();
        }

        void OnRestoreDefaultScalesClicked(object sender, EventArgs e) {
            RestoreDefaultScales();
        }

        void UpdateTimeScaleWidthTrackBar() {
            this.trckScaleWidth.Value = Scheduler.TimelineView.GetBaseTimeScale().Width;
            this.trckScaleWidth.Enabled = Scheduler.TimelineView.Scales.Count > 0;
        }

        void OnChkAutoHeightCheckedChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = this.chkAutoHeight.Checked;
            this.chkStretchAppointments.Enabled = !this.chkAutoHeight.Checked;
            this.spinMinHeight.Enabled = this.chkAutoHeight.Checked;
            this.spinMaxHeight.Enabled = this.chkAutoHeight.Checked;
        }

        void OnSpinHeightEditValueChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentHeight = Convert.ToInt32(this.spinHeight.Value);
        }
        void OnSpinMinHeightEditValueChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentMinHeight = Convert.ToInt32(this.spinMinHeight.Value);
        }
        void OnSpinMaxHeightEditValueChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentMaxHeight = Convert.ToInt32(this.spinMaxHeight.Value);
        }

        void OnCbStatusEditValueChanged(object sender, EventArgs e) {
            if (!typeof(AppointmentStatusDisplayType).IsAssignableFrom(this.cbStatus.EditValue.GetType()))
                return;
            Scheduler.TimelineView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        void OnCbSnapToCellsModeEditValueChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.SnapToCellsMode = (AppointmentSnapToCellsMode)this.cbSnapToCellsMode.EditValue;
        }

        void OnTrckScaleWidthEditValueChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.Scales.ForEach(x => x.Width = this.trckScaleWidth.Value);
        }

        void OnChkShowOverAppointmentCheckedChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.TimeIndicatorDisplayOptions.ShowOverAppointment = this.chkShowOverAppointment.Checked;
        }

        void OnCbTimeIndicatorVisibilitySelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)this.cbTimeIndicatorVisibility.EditValue;
        }

        void OnChkStatusOrientationCheckedChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = this.chkStatusOrientation.Checked;
        }

        void OnChkStretchAppointmentsCheckedChanged(object sender, EventArgs e) {
            Scheduler.TimelineView.AppointmentDisplayOptions.StretchAppointments = this.chkStretchAppointments.Checked;
        }

        void OnChkCustomSortCheckedChanged(object sender, EventArgs e) {
            if (this.chkCustomSort.Checked) {
                Scheduler.CustomAppointmentSort += CustomAppointmentSort;
                this.chkCustomGroup.Checked = false;
            }
            else
                Scheduler.CustomAppointmentSort -= CustomAppointmentSort;
            Scheduler.Refresh();
        }

        void OnChkCustomGroupCheckedChanged(object sender, EventArgs e) {
            if (this.chkCustomGroup.Checked) {
                Scheduler.CustomAppointmentGroup += CustomAppointmentGroup;
                this.chkCustomSort.Checked = false;
            }
            else
                Scheduler.CustomAppointmentGroup -= CustomAppointmentGroup;
            Scheduler.Refresh();
        }

        void CustomAppointmentSort(object sender, CustomAppointmentSortEventArgs e) {
            IAppointmentLayoutInfo viewInfoX = e.AppointmentLayoutInfo1;
            IAppointmentLayoutInfo viewInfoY = e.AppointmentLayoutInfo2;
            e.Result = viewInfoX.Start.CompareTo(viewInfoY.Start);
            if (e.Result != 0)
                return;
            e.Result = -viewInfoX.End.CompareTo(viewInfoY.End);
            if (e.Result != 0)
                return;
            Appointment aptX = viewInfoX.Appointment;
            Appointment aptY = viewInfoY.Appointment;
            e.Result = ((int)aptX.LabelKey).CompareTo((int)aptY.LabelKey);
            if (e.Result != 0)
                return;
            e.Result = aptX.Start.CompareTo(aptY.Start);
            if (e.Result != 0)
                return;
            e.Result = -aptX.End.CompareTo(aptY.End);
        }

        void CustomAppointmentGroup(object sender, CustomAppointmentGroupEventArgs e) {
            e.GroupKey = (int)e.AppointmentLayoutInfo.Appointment.LabelKey;
        }

        void RestoreDefaultScales() {
            Scheduler.TimelineView.Scales.LoadDefaults();
            Scheduler.TimelineView.Scales.Add(new TimeScaleWorkDay(Scheduler));
            Scheduler.TimelineView.Scales.Add(new TimeScaleWorkHour(Scheduler));
            foreach (TimeScale scaleItem in Scheduler.TimelineView.Scales) {
                scaleItem.Enabled = scaleItem is TimeScaleWorkDay || scaleItem is TimeScaleWeek;
                scaleItem.Width = ScaleDPI.ScaleHorizontal(DefaultTimeScaleWidth);
            }
        }

        void HideUnusedViews() {
            this.schedulerControl.DayView.Enabled = true;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
            this.schedulerControl.YearView.Enabled = false;
        }
    }
}
