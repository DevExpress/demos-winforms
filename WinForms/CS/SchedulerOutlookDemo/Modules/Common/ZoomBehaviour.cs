using System;
using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraScheduler.Demos {
    public static class ZoomBehaviour {
        static BarEditItem TrackBarItem { get; set; }
        static SchedulerControl Scheduler { get; set; }
        static RepositoryItemZoomTrackBar TrackBarRepositoryItem { get { return (TrackBarItem != null) ? TrackBarItem.Edit as RepositoryItemZoomTrackBar : null; } }

        public static void RegisterZoomTracker(BarEditItem trackBarItem) {
            TrackBarItem = trackBarItem;
            TrackBarItem.EditValueChanged += OnTrackBarItemEditValueChanged;
        }

        public static void Attach(SchedulerControl scheduler) {
            Scheduler = scheduler;
            scheduler.ActiveViewChanged += OnSchedulerActiveViewChanged;
            scheduler.DayView.PropertyChanged += OvViewPropertyChanged;
            scheduler.WorkWeekView.PropertyChanged += OvViewPropertyChanged;
            scheduler.FullWeekView.PropertyChanged += OvViewPropertyChanged;
            UpdateTrackBar();
        }

        public static void Detach(SchedulerControl scheduler) {
            scheduler.ActiveViewChanged -= OnSchedulerActiveViewChanged;
            scheduler.DayView.PropertyChanged -= OvViewPropertyChanged;
            scheduler.WorkWeekView.PropertyChanged -= OvViewPropertyChanged;
            scheduler.FullWeekView.PropertyChanged -= OvViewPropertyChanged;
            Scheduler = null;
            UpdateTrackBar();
        }

        static void OvViewPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            if (e.PropertyName == "TimeScale")
                UpdateTrackBar();
        }

        static void OnTrackBarItemEditValueChanged(object sender, EventArgs e) {
            UpdateControl();
        }


        static void OnSchedulerActiveViewChanged(object sender, EventArgs e) {
            UpdateTrackBar();
        }

        static void UpdateControl() {
            if (Scheduler == null)
                return;
            if (TrackBarItem.EditValue == null)
                return;
            DayView dayView = Scheduler.ActiveView as DayView;
            if (dayView != null)
                dayView.TimeScale = dayView.TimeSlots[(int)TrackBarItem.EditValue].Value;
            TimelineView timelineView = Scheduler.ActiveView as TimelineView;
            if (timelineView != null)
                timelineView.GetBaseTimeScale().Width = (int)TrackBarItem.EditValue;
        }

        static void UpdateTrackBar() {
            if (TrackBarItem == null || TrackBarRepositoryItem == null)
                return;
            if (Scheduler == null) {
                TrackBarItem.Enabled = false;
                TrackBarRepositoryItem.Maximum = 0;
                TrackBarItem.EditValue = null;
                return;
            }
            DayView dayView = Scheduler.ActiveView as DayView;
            if (dayView != null) {
                TrackBarRepositoryItem.Minimum = 0;
                TrackBarRepositoryItem.Middle = 1;
                TrackBarRepositoryItem.Maximum = dayView.TimeSlots.Count - 1;
                TrackBarItem.EditValue = GetTimeSlotIndex(dayView.TimeSlots, dayView.TimeScale);
            }
            TimelineView timelineView = Scheduler.ActiveView as TimelineView;
            if (timelineView != null) {
                TrackBarRepositoryItem.Maximum = 100;
                TrackBarRepositoryItem.Minimum = 40;
                TrackBarItem.EditValue = timelineView.GetBaseTimeScale().Width;
            }
            TrackBarItem.Enabled = timelineView != null || dayView != null;
        }
        static int GetTimeSlotIndex(TimeSlotCollection timeSlots, TimeSpan scale) {
            for (int i = 0; i < timeSlots.Count; i++)
                if (timeSlots[i].Value == scale)
                    return i;
            return -1;
        }
    }
}
