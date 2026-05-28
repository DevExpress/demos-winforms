using System;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;

namespace DevExpress.XtraScheduler.Demos {
    public partial class SplitAppointmentToolModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public SplitAppointmentToolModule() {
            InitializeComponent();
        }

        private void SplitAppointmentToolModule_Load(object sender, EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
        }

        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu) {
                SplitAppointmentOperationCommand command = new SplitAppointmentOperationCommand(schedulerControl);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter = new SchedulerMenuItemCommandWinAdapter(command);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);
            }
        }
    }
}
