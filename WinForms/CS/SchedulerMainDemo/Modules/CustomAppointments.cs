using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Drawing;


namespace DevExpress.XtraScheduler.Demos {
	public partial class CustomAppointmentsModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		ImageCollection fCustomImages;
		const int CustomImagesOccurenceIndex = 0;
		const int CustomImagesExceptionIndex = 1;
		const int CustomImagesBizTripIndex = 2;
		const int CustomImagesHolidayIndex = 3;

		public CustomAppointmentsModule() {
			this.fCustomImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.appointment_icons.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(15, 15));

			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected AppointmentDisplayOptions DisplayOptions { get { return schedulerControl.ActiveView.AppointmentDisplayOptions; } }

		protected bool IsDefaultAppointmentImages { get { return rgrpAptImages.SelectedIndex == 0; } }
		protected bool IsExternalAppointmentImages { get { return rgrpAptImages.SelectedIndex == 1; } }
		protected bool IsCustomAppointmentImages { get { return rgrpAptImages.SelectedIndex == 2; } }
		protected ImageCollection CustomImages { get { return fCustomImages; } }

		private void CustomAppointmentsModule_Load(object sender, System.EventArgs e) {
			schedulerControl.DataStorage.EnableReminders = true;
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            schedulerControl.DataStorage.EnableReminders = false;
		}
		private void CustomAppointmentsModule_VisibleChanged(object sender, System.EventArgs e) {
			if (Visible) {
				UpdateControls();
			}
		}
		private void schedulerControl_ActiveViewChanged(object sender, System.EventArgs e) {
			UpdateControls();
		}
		void UpdateControls() {
			AppointmentDisplayOptions options = DisplayOptions;

			chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.StartTimeVisibility);
			chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.EndTimeVisibility);

			cbStatus.EditValue = options.StatusDisplayType;
			chkShowRecurrence.Checked = options.ShowRecurrence;
			chkShowReminder.Checked = options.ShowReminder;
			cbTimeDisplayType.EditValue = options.TimeDisplayType;
			rgrpAptImages.SelectedIndex = schedulerControl.AppointmentImages != null ? 1 : 0;
		}
		private void chkStartTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
			DisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkStartTimeVisibility.CheckState);
		}
		private void chkEndTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
			DisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkEndTimeVisibility.CheckState);
		}
		private void chkShowRecurrence_CheckedChanged(object sender, EventArgs e) {
			DisplayOptions.ShowRecurrence = chkShowRecurrence.Checked;
		}
		private void chkShowReminder_CheckedChanged(object sender, EventArgs e) {
			DisplayOptions.ShowReminder = chkShowReminder.Checked;
		}
		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)cbStatus.EditValue;
		}
		private void cbTimeDisplayType_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.TimeDisplayType = (AppointmentTimeDisplayType)cbTimeDisplayType.EditValue;
		}


		private void schedulerControl_InitAppointmentImages(object sender, DevExpress.XtraScheduler.AppointmentImagesEventArgs e) {
			if (!IsCustomAppointmentImages)
				return;

			Appointment apt = e.Appointment;
			AppointmentImageInfoCollection c = e.ImageInfoList;

			c.Clear();
			c.Images = CustomImages;

			if (e.Appointment.IsRecurring)
				SetRecurrentAppointmentImages(c, e.Appointment.IsException);
			else
				SetNotRecurrentAppointmentImages(c, e.Appointment);

			if (DisplayOptions.ShowReminder && apt.HasReminder)
				c.AddStandard(AppointmentImageType.Reminder);
		}
		void SetRecurrentAppointmentImages(AppointmentImageInfoCollection c, bool isException) {
			if (!DisplayOptions.ShowRecurrence)
				return;

			if (isException) {
				AddImageByIndex(c, CustomImagesExceptionIndex);

				AppointmentImageInfo info = new AppointmentImageInfo();
				info.Image = SystemIcons.Warning.ToBitmap();
				c.Add(info);
			}
			else
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
		private void schedulerControl_InitAppointmentDisplayText(object sender, DevExpress.XtraScheduler.AppointmentDisplayTextEventArgs e) {
			if (!chkText.Checked)
				return;
			Appointment apt = e.Appointment;
			e.Text = GetCustomSubject(apt);
			e.Description = GetCustomDescription(apt);
		}
		string GetCustomSubject(Appointment apt) {
			string s = apt.Subject;
			if (apt.Location.Length > 0) {
				s += String.Format(" - [{0}]", apt.Location);
			}
			return s;
		}
		string GetCustomDescription(Appointment apt) {
			string s = apt.Description;
			if (apt.IsRecurring) {
				return String.Format("{0}\r\nOccurs on {1}", s, RecurrenceInfo.GetDescription(apt, schedulerControl.FirstDayOfWeek));
			}
			return s;
		}
		private void chkCustomDisplayText_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.ActiveView.LayoutChanged();
		}
		private void chkCustomImages_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.AppointmentImages = IsExternalAppointmentImages ? this.imcAppointmentIcons : null;
		}
		private void chkToolTip_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.ToolTipController = chkToolTip.Checked ? this.toolTipController1 : null;
		}
		private void toolTipController1_BeforeShow(object sender, DevExpress.Utils.ToolTipControllerShowEventArgs e) {
			ToolTipController controller = sender as ToolTipController;
            AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
            if (aptViewInfo == null) return;
            Appointment apt = aptViewInfo.Appointment;
			if (apt == null) return;
			e.IconType = ToolTipIconType.Information;
			e.Title = e.ToolTip;
			e.ToolTip = GetCustomDescription(apt);
		}

		private void rgrpAptImages_SelectedIndexChanged(object sender, EventArgs e) {
			schedulerControl.AppointmentImages = IsExternalAppointmentImages ? this.imcAppointmentIcons : null;
			schedulerControl.ActiveView.LayoutChanged();
		}
	}
}
