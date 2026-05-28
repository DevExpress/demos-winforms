using System;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Demos.Forms;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
	public partial class UserDefinedFilterModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public UserDefinedFilterModule() {
			InitializeComponent();
		}

		private void FilterControlModule_Load(object sender, EventArgs e) {
			AddCustomFieldsMapping();
            CarsDataHelper.FillData(schedulerControl, schedulerStorage1);
            // load filter criteria string from scheduler storage
            ResetFilterControl();
			filterControlForAppointments.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(filterControlForAppointments_FilterChanged);
		}

		private void AddCustomFieldsMapping() {
			AppointmentCustomFieldMapping customPriceMapping = new AppointmentCustomFieldMapping("CustomFieldPrice", "Price", FieldValueType.Decimal);
			schedulerStorage1.Appointments.CustomFieldMappings.Add(customPriceMapping);
		}
		private void ResetFilterControl() {
			filterControlForAppointments.FilterString = schedulerStorage1.Appointments.Filter;
			string temp = filterControlForAppointments.FilterString;
			schedulerStorage1.Appointments.Filter = String.Empty;
			schedulerStorage1.Appointments.Filter = temp;
            filterControlForAppointments.MenuManager = schedulerControl.MenuManager;
		}
		private void OnBtnApplyClick(object sender, EventArgs e) {
			schedulerControl.DataStorage.Appointments.Filter = filterControlForAppointments.FilterString;
		}
		private void toolTipController1_BeforeShow(object sender, DevExpress.Utils.ToolTipControllerShowEventArgs e) {
			ToolTipController controller = sender as ToolTipController;
			AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
			if(aptViewInfo == null)
				return;
			Appointment apt = aptViewInfo.Appointment;
			if(apt == null)
				return;
			e.IconType = ToolTipIconType.Information;
			e.Title = e.ToolTip;
			e.ToolTip = GetCustomDescription(apt);
		}
		private string GetCustomDescription(Appointment apt) {
			string description = apt.Description;
			if(apt.IsRecurring)
				description = String.Format("{0}\r\nOccurs on {1}", description, RecurrenceInfo.GetDescription(apt, schedulerControl.FirstDayOfWeek));
			string price = String.Format("{0}Price: {1}$", Environment.NewLine, apt.CustomFields["CustomFieldPrice"]);
			return description + price;
		}

		private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
			e.Handled = true;
			UserDefinedFilterAppointmentForm form = new UserDefinedFilterAppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm);
			form.ShowDialog(this);
		}

		private void schedulerControl_InitNewAppointment(object sender, AppointmentEventArgs e) {
			e.Appointment.CustomFields["CustomFieldPrice"] = new Decimal(15);
		}

		private void filterControlForAppointments_FilterChanged(object sender, DevExpress.XtraEditors.FilterChangedEventArgs e) {
			if (e.Action == FilterChangedAction.FieldNameChange) {
				ClauseNode node = e.CurrentNode as ClauseNode;
				if (node == null)
					return;
				int count = node.AdditionalOperands.Count;
				for (int i = 0; i < count; i++)
					node.AdditionalOperands[i] = new OperandValue(null);
			}
		}
	}
}
