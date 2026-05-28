using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler.UI;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
// ...

namespace DevExpress.XtraScheduler.Demos {
	public partial class MyAppointmentEditForm : DevExpress.XtraEditors.XtraForm {
		SchedulerControl _control;
		Appointment _apt;
		bool _openRecurrenceForm = false;
		int _suspendUpdateCount;
        IDXMenuManager _menuManager;
		private DevExpress.XtraEditors.CheckEdit _checkAllDay;
		// Note that the MyAppointmentFormController class is inherited from
		// the AppointmentFormController one to add custom properties.
		// See its declaration at the end of this file.
		MyAppointmentFormController _controller;

		public MyAppointmentEditForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) {
			this._openRecurrenceForm = openRecurrenceForm;
			this._controller = new MyAppointmentFormController(control, apt);
			this._apt = apt;
			this._control = control;
			//
			// Required for Windows Form Designer support
			//
			SuspendUpdate();
			InitializeComponent();
			ResumeUpdate();

			UpdateForm();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected IAppointmentStorage Appointments { get { return _control.DataStorage.Appointments; } }
        protected internal bool IsNewAppointment { get { return _controller != null ? _controller.IsNewAppointment : true; } }
		protected bool IsUpdateSuspended { get { return _suspendUpdateCount > 0; } }
        public IDXMenuManager MenuManager { get { return _menuManager; } }

		protected void SuspendUpdate() {
			_suspendUpdateCount++;
		}
		protected void ResumeUpdate() {
			if (_suspendUpdateCount > 0)
				_suspendUpdateCount--;
		}

        public void SetMenuManager(IDXMenuManager menuManager) {
            SetMenuManagerCore(Controls, menuManager);
            this._menuManager = menuManager;
        }
        void SetMenuManagerCore(Control.ControlCollection controls, IDXMenuManager menuManager) {
            int count = controls.Count;
            for (int i = 0; i < count; i++) {
                Control control = controls[i];
                SetMenuManagerCore(control.Controls, menuManager);
                BaseEdit baseEdit = control as BaseEdit;
                if (baseEdit == null)
                    continue;
                baseEdit.MenuManager = menuManager;
            }
        }
		private void btnAddRec_Click(object sender, System.EventArgs e) {
			OnRecurrenceButton();
		}

		void OnRecurrenceButton() {
			ShowRecurrenceForm();
		}

		void ShowRecurrenceForm() {
			if (!_control.SupportsRecurrence)
				return;

			// Prepare to edit appointment's recurrence.
			Appointment editedAptCopy = _controller.EditedAppointmentCopy;
			Appointment editedPattern = _controller.EditedPattern;
			Appointment patternCopy = _controller.PrepareToRecurrenceEdit();

			AppointmentRecurrenceForm dlg = new AppointmentRecurrenceForm(patternCopy, _control.OptionsView.FirstDayOfWeek, _controller);
            dlg.SetMenuManager(MenuManager);
			// Required for skins support.
			dlg.LookAndFeel.ParentLookAndFeel = this.LookAndFeel.ParentLookAndFeel;
            dlg.ShowExceptionsRemoveMsgBox = _controller.AreExceptionsPresent();

			DialogResult result = dlg.ShowDialog(this);
			dlg.Dispose();

			if (result == DialogResult.Abort)
				_controller.RemoveRecurrence();
			else
				if (result == DialogResult.OK) {
					_controller.ApplyRecurrence(patternCopy);
					if (_controller.EditedAppointmentCopy != editedAptCopy)
						UpdateForm();
				}
			UpdateIntervalControls();
		}

		private void btnOK_Click(object sender, System.EventArgs e) {
			// Required to check appointment's conflicts.
			if (!_controller.IsConflictResolved())
				return;

			_controller.Subject = txSubject.Text;
			_controller.SetStatus(edStatus.AppointmentStatus);
			_controller.SetLabel(edLabel.AppointmentLabel);
			_controller.AllDay = this._checkAllDay.Checked;
			_controller.DisplayStart = this.dtStart.DateTime.Date + this.timeStart.Time.TimeOfDay;
			_controller.DisplayEnd = this.dtEnd.DateTime.Date + this.timeEnd.Time.TimeOfDay;
			_controller.CustomName = txCustomName.Text;
			_controller.CustomStatus = txCustomStatus.Text;

			// Save all changes made to the appointment edited in a form.
			_controller.ApplyChanges();
		}

		void UpdateForm() {
			SuspendUpdate();
			try {
				txSubject.Text = _controller.Subject;

                edStatus.AppointmentStatus = Appointments.Statuses.GetById(_controller.StatusKey);
                edLabel.AppointmentLabel = Appointments.Labels.GetById(_controller.LabelKey);

                dtStart.DateTime = _controller.DisplayStart.Date;
				dtEnd.DateTime = _controller.DisplayEnd.Date;

				timeStart.Time = DateTime.MinValue.AddTicks(_controller.Start.TimeOfDay.Ticks);
				timeEnd.Time = DateTime.MinValue.AddTicks(_controller.End.TimeOfDay.Ticks);
				_checkAllDay.Checked = _controller.AllDay;

				edStatus.Storage = _control.DataStorage;
				edLabel.Storage = _control.DataStorage;

				txCustomName.Text = _controller.CustomName;
				txCustomStatus.Text = _controller.CustomStatus;
            } finally {
				ResumeUpdate();
			}
			UpdateIntervalControls();
		}

		private void MyAppointmentEditForm_Activated(object sender, System.EventArgs e) {
			// Required to show the recurrence form.
			if (_openRecurrenceForm) {
				_openRecurrenceForm = false;
				OnRecurrenceButton();
			}
		}

		private void dtStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				_controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		protected virtual void UpdateIntervalControls() {
			if (IsUpdateSuspended)
				return;

			SuspendUpdate();
			try {
				dtStart.EditValue = _controller.DisplayStart.Date;
				dtEnd.EditValue = _controller.DisplayEnd.Date;
				timeStart.EditValue = _controller.DisplayStart.TimeOfDay;
				timeEnd.EditValue = _controller.DisplayEnd.TimeOfDay;

                Appointment editedAptCopy = _controller.EditedAppointmentCopy;
                bool showControls = IsNewAppointment || !editedAptCopy.Type.Equals(AppointmentType.Pattern);
                dtStart.Enabled = showControls;
                dtEnd.Enabled = showControls;
                bool enableTime = showControls && !_controller.AllDay;
                timeStart.Visible = enableTime;
                timeStart.Enabled = enableTime;
                timeEnd.Visible = enableTime;
                timeEnd.Enabled = enableTime;
                _checkAllDay.Enabled = showControls;
            } finally {
				ResumeUpdate();
			}
		}
		private void timeStart_EditValueChanged(object sender, System.EventArgs e) {
			if (!IsUpdateSuspended)
				_controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay;
			UpdateIntervalControls();
		}
		private void timeEnd_EditValueChanged(object sender, System.EventArgs e) {
            if (IsUpdateSuspended)
                return;
			if (IsIntervalValid())
				_controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				timeEnd.EditValue = _controller.End.TimeOfDay;
		}
		private void dtEnd_EditValueChanged(object sender, System.EventArgs e) {
            if (IsUpdateSuspended)
                return;
			if (IsIntervalValid())
				_controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			else
				dtEnd.EditValue = _controller.DisplayEnd.Date;
		}
		bool IsIntervalValid() {
			DateTime start = dtStart.DateTime + timeStart.Time.TimeOfDay;
			DateTime end = dtEnd.DateTime + timeEnd.Time.TimeOfDay;
			return end >= start;
		}

		private void checkAllDay_CheckedChanged(object sender, System.EventArgs e) {
			_controller.AllDay = this._checkAllDay.Checked;
			if (!IsUpdateSuspended)
				UpdateAppointmentStatus();

			UpdateIntervalControls();
		}
		void UpdateAppointmentStatus() {
			IAppointmentStatus currentStatus = edStatus.AppointmentStatus;
			IAppointmentStatus newStatus = _controller.UpdateStatus(currentStatus);
			if (newStatus != currentStatus)
				edStatus.AppointmentStatus = newStatus;
		}
	}
	public class MyAppointmentFormController : AppointmentFormController {

		public string CustomName { get { return (string)EditedAppointmentCopy.CustomFields["CustomName"]; } set { EditedAppointmentCopy.CustomFields["CustomName"] = value; } }
		public string CustomStatus { get { return (string)EditedAppointmentCopy.CustomFields["CustomStatus"]; } set { EditedAppointmentCopy.CustomFields["CustomStatus"] = value; } }

		string SourceCustomName { get { return (string)SourceAppointment.CustomFields["CustomName"]; } set { SourceAppointment.CustomFields["CustomName"] = value; } }
		string SourceCustomStatus { get { return (string)SourceAppointment.CustomFields["CustomStatus"]; } set { SourceAppointment.CustomFields["CustomStatus"] = value; } }

		public MyAppointmentFormController(SchedulerControl control, Appointment apt)
			: base(control, apt) {
		}

		public override bool IsAppointmentChanged() {
			if (base.IsAppointmentChanged())
				return true;
			return SourceCustomName != CustomName ||
				SourceCustomStatus != CustomStatus;
		}

		protected override void ApplyCustomFieldsValues() {
			SourceCustomName = CustomName;
			SourceCustomStatus = CustomStatus;
		}
	}
}
