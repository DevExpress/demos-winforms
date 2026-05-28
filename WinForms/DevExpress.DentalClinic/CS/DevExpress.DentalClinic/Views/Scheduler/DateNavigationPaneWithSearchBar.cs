using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace DevExpress.DentalClinic.View {
    public partial class DateNavigationPaneWithSearchBar : SchedulerDateNavigationBarPanel {
        public DateNavigationPaneWithSearchBar() {
            InitializeComponent();
            Controls.SetChildIndex(this.beSearch, Controls.Count - 1);
            this.beSearch.Properties.Buttons[0].IsDefaultButton = true;
            this.beSearch.ButtonClick += OnBeSearchButtonClick;
            this.beSearch.EditValueChanged += BeSearch_EditValueChanged;
        }

        private void BeSearch_EditValueChanged(object sender, EventArgs e) {
            //var editor = (ButtonEdit)sender;
            //FindAndSelectAppointment(editor.Text);
        }

        void OnBeSearchButtonClick(object sender, XtraEditors.Controls.ButtonPressedEventArgs e) {
            var editor = (ButtonEdit)sender;
            FindAndSelectAppointment(editor.Text);
        }

        void FindAndSelectAppointment(string text) {
            if (SchedulerControl == null)
                return;
            DateTime start = SchedulerControl.ActiveView.SelectedInterval.Start;
            var appointments = SchedulerControl.DataStorage.GetAppointments(start, start.AddYears(2));
            text = text.ToLowerInvariant();
            AppointmentBaseCollection selectedAppointments = SchedulerControl.SelectedAppointments;
            var appointment = appointments.FirstOrDefault(x => x.Subject.ToLowerInvariant().Contains(text) && !selectedAppointments.Contains(x));
            if (appointment == null)
                return;
            SchedulerControl.ActiveView.SelectAppointment(appointment);
        }
    }
}
