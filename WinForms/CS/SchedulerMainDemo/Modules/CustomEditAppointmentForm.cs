using System;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CustomEditAppointmentFormModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public CustomEditAppointmentFormModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        void AddCustomFieldsMapping() {
            AppointmentCustomFieldMapping customNameMapping = new AppointmentCustomFieldMapping("CustomName", "CustomName");
            AppointmentCustomFieldMapping customStatusMapping = new AppointmentCustomFieldMapping("CustomStatus", "CustomStatus");
            schedulerStorage.Appointments.CustomFieldMappings.Add(customNameMapping);
            schedulerStorage.Appointments.CustomFieldMappings.Add(customStatusMapping);
        }

        private void CustomEditAppointmentFormModule_Load(object sender, System.EventArgs e) {
            AddCustomFieldsMapping();
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
        private void schedulerControl_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e) {
            Appointment apt = e.Appointment;
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage.Appointments.IsNewAppointment(apt);

            MyAppointmentEditForm f = new MyAppointmentEditForm((SchedulerControl)sender, apt, openRecurrenceForm);
            f.SetMenuManager(this.schedulerControl.MenuManager);
            f.LookAndFeel.ParentLookAndFeel = this.LookAndFeel.ParentLookAndFeel;
            e.DialogResult = f.ShowDialog();
            e.Handled = true;

            if (apt.Type.Equals(AppointmentType.Pattern) && schedulerControl.SelectedAppointments.Contains(apt))
                schedulerControl.SelectedAppointments.Remove(apt);

            schedulerControl.Refresh();
        }
    }
}
