using System;
using DevExpress.Utils;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ContextButtonsModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public ContextButtonsModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        void ContextButtonsModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            //this.schedulerControl.AppointmentContextButtons.Add(new DeleteAppointmentContextButton());
            //this.schedulerControl.AppointmentContextButtons.Add(new OpenAppointmentContextButton());
            //this.chEditKeepInView.Checked = this.schedulerControl.OptionsAppointmentContextButtons.KeepInView;
            this.cbContextButtonAlignment.EditValue = ContextItemAlignment.TopFar;
            this.cbContextButtonVisibility.EditValue = ContextItemVisibility.Auto;
        }
        void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu) {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
            }
        }
        void chEditKeepInView_CheckedChanged(object sender, EventArgs e) {
            //this.schedulerControl.OptionsAppointmentContextButtons.KeepInView = this.chEditKeepInView.Checked;
        }
        void cbOpenContextButtonVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            //ContextItemVisibility visibility = (ContextItemVisibility)cbContextButtonVisibility.EditValue;
            //SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
            //foreach (ContextItem button in appointmentContextButtons)
            //    button.Visibility = visibility;
        }
        void cbContextButtonAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            //ContextItemAlignment alignment = (ContextItemAlignment)cbContextButtonAlignment.EditValue;
            //SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
            //foreach (ContextItem button in appointmentContextButtons)
            //    button.Alignment = alignment;
        }
    }
}

