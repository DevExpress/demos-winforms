using System;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.XtraScheduler.Demos {
	public partial class AppointmentFormStylesModule : DevExpress.XtraScheduler.Demos.TutorialControl {

		public AppointmentFormStylesModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void AppointmentFormStylesModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
        }
		private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
			XtraForm form;
			if(rgrpAptFormStyle.SelectedIndex == 0) {// Outlook
				form = new AppointmentRibbonForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm);
                ((AppointmentRibbonForm)form).ReadOnly = e.ReadOnly;
			}
			else { // Default
				form = new AppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm);
                ((AppointmentForm)form).ReadOnly = e.ReadOnly;
			}
			form.LookAndFeel.ParentLookAndFeel = schedulerControl.LookAndFeel;
			e.DialogResult = form.ShowDialog(e.Parent);
			e.Handled = true;
		}
	}
}
