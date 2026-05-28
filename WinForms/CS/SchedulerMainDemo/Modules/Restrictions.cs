using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class RestrictionsModule : DevExpress.XtraScheduler.Demos.TutorialControl {

		public RestrictionsModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void RestrictionsModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            UpdateControls();
		}
		private void UpdateControls() {
			SchedulerOptionsCustomization opts = schedulerControl.OptionsCustomization;
			chkAllowConflicts.Checked = opts.AllowAppointmentConflicts == AppointmentConflictsMode.Allowed;
			chkAllowCopy.Checked = opts.AllowAppointmentCopy == UsedAppointmentType.All;
			chkAllowCreate.Checked = opts.AllowAppointmentCreate == UsedAppointmentType.All;
			chkAllowDelete.Checked = opts.AllowAppointmentDelete == UsedAppointmentType.All;
			chkAllowDrag.Checked = opts.AllowAppointmentDrag == UsedAppointmentType.All;
			chkAllowDragBetweenResources.Checked = opts.AllowAppointmentDragBetweenResources == UsedAppointmentType.All;
			chkAllowEdit.Checked = opts.AllowAppointmentEdit == UsedAppointmentType.All;
			chkAllowInplaceEditor.Checked = opts.AllowInplaceEditor == UsedAppointmentType.All;
			chkAllowMultiSelect.Checked = opts.AllowAppointmentMultiSelect;
			chkAllowResize.Checked = opts.AllowAppointmentResize == UsedAppointmentType.All;
		}
		private void chkAllowCreate_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentCreate = chkAllowCreate.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowEdit_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentEdit = chkAllowEdit.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowResize_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentResize = chkAllowResize.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowConflicts_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentConflicts = chkAllowConflicts.Checked ? AppointmentConflictsMode.Allowed : AppointmentConflictsMode.Forbidden;
		}

		private void chkAllowDragBetweenResources_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = chkAllowDragBetweenResources.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowDelete_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentDelete = chkAllowDelete.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowCopy_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentCopy = chkAllowCopy.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowDrag_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentDrag = chkAllowDrag.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}

		private void chkAllowMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowAppointmentMultiSelect = chkAllowMultiSelect.Checked;
		}

		private void chkAllowInplaceEditor_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.OptionsCustomization.AllowInplaceEditor = chkAllowInplaceEditor.Checked ? UsedAppointmentType.All : UsedAppointmentType.None;
		}
	}
}
