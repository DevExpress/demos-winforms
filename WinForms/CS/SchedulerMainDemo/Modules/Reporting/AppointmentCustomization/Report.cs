using System;
using DevExpress.XtraScheduler.Reporting;
using System.Drawing;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

        
        bool _allowInitAppointmentText;
        bool _allowInitAppointmentImages;
        bool _showStartTime;
        bool _showEndTime;
        AppointmentStatusDisplayType _statusDisplayType;
        AppointmentTimeDisplayType _timeDisplayType;
        bool _showBell;
        bool _showRecurrence;


		ImageCollection fCustomImages;
		const int CustomImagesOccurenceIndex = 0;
		const int CustomImagesExceptionIndex = 1;
		const int CustomImagesBizTripIndex = 2;
		const int CustomImagesHolidayIndex = 3;

		public Report() {

			InitializeComponent();
            this.fCustomImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.appointment_icons.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(15, 15));
		}
        
        public bool AllowInitAppointmentText { get { return _allowInitAppointmentText; } set { _allowInitAppointmentText = value; } }
        public bool AllowInitAppointmentImages { get { return _allowInitAppointmentImages; } set { _allowInitAppointmentImages = value; } }
        public bool ShowStartTime { get { return _showStartTime; } set { _showStartTime = value; } }
        public bool ShowEndTime { get { return _showEndTime; } set { _showEndTime = value; } }
        public AppointmentStatusDisplayType StatusDisplayType { get { return _statusDisplayType; } set { _statusDisplayType = value; } }
        public AppointmentTimeDisplayType TimeDisplayType { get { return _timeDisplayType; } set { _timeDisplayType = value; } }
        public bool ShowBell { get { return _showBell; } set { _showBell = value; } }
        public bool ShowRecurrence { get { return _showRecurrence; } set { _showRecurrence = value; } }
        
        private void dayViewTimeCells1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e) {
            AppointmentViewInfo vi = (AppointmentViewInfo)e.ViewInfo;
            vi.ShowStartTime = ShowStartTime;
            vi.ShowEndTime = ShowEndTime;
            vi.StatusDisplayType = StatusDisplayType;
            vi.ShowTimeAsClock = TimeDisplayType.Equals(AppointmentTimeDisplayType.Clock);
            vi.ShowBell = ShowBell;
            vi.ShowRecurrence = ShowRecurrence;
        }

        private void dayViewTimeCells1_InitAppointmentImages(object sender, AppointmentImagesEventArgs e) {
            if (!AllowInitAppointmentImages)
                return;

            Appointment apt = e.Appointment;
            AppointmentImageInfoCollection c = e.ImageInfoList;

            c.Clear();
            c.Images = fCustomImages;
            if (_showBell)
                c.AddStandard(AppointmentImageType.Reminder);

            if (e.Appointment.IsRecurring)
                SetRecurrentAppointmentImages(c, e.Appointment.IsException);
            else
                SetNotRecurrentAppointmentImages(c, e.Appointment);
        }
        void SetRecurrentAppointmentImages(AppointmentImageInfoCollection c, bool isException) {
            if (!_showRecurrence)
                return;

            if (isException) {
                AddImageByIndex(c, CustomImagesExceptionIndex);
            } else
                AddImageByIndex(c, CustomImagesOccurenceIndex);
        }
        void SetNotRecurrentAppointmentImages(AppointmentImageInfoCollection c, Appointment apt) {
            AddImageByIndex(c, CustomImagesBizTripIndex);
            AddImageByIndex(c, CustomImagesHolidayIndex);
        }
        void AddImageByIndex(AppointmentImageInfoCollection c, int index) {
            AppointmentImageInfo info = new AppointmentImageInfo();
            info.ImageIndex = index;
            c.Add(info);
        }

        private void dayViewTimeCells1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            if (!AllowInitAppointmentText)
                return;
            e.Text = string.Format("{0} [{1:F2} h]", e.Text, e.Appointment.Duration.TotalHours);
        }
    }
}
