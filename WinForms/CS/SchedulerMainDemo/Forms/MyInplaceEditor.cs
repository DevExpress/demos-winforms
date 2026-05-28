using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos.Forms {
    public partial class MyInplaceEditor : DevExpress.XtraEditors.XtraForm {
        Appointment appointment;
        SchedulerControl control;

        public MyInplaceEditor() {
            InitializeComponent();
            SubscribeKeyDownEvents();
        }
        public event EventHandler CommitChanges;
        public event EventHandler RollbackChanges;

        private void SubscribeKeyDownEvents() {
            appointmentLabelEdit.KeyDown += new KeyEventHandler(AppointmentLabelEdit_KeyDown);
            edtDescription.KeyDown += new KeyEventHandler(Editor_KeyDown);
            edtSubject.KeyDown += new KeyEventHandler(Editor_KeyDown);
        }
        public void AppointmentLabelEdit_KeyDown(object sender, KeyEventArgs e) {
            if (!appointmentLabelEdit.IsPopupOpen)
                Editor_KeyDown(sender, e);
        }
        void Editor_KeyDown(object sender, KeyEventArgs e) {
            switch(e.KeyCode) {
                case Keys.Enter:
                    e.Handled = true;
                    OnCommitChanges();
                    break;
                case Keys.Escape:
                    e.Handled = true;
                    OnRollbackChanges();
                    break;
            }
        }

        void OnCommitChanges() {
            if(CommitChanges != null)
                CommitChanges(this, EventArgs.Empty);
        }

        void OnRollbackChanges() {
            if(RollbackChanges != null)
                RollbackChanges(this, EventArgs.Empty);
        }
        protected override void OnShown(EventArgs e) {
            ISchedulerStorageBase storage = control.DataStorage;
            if(storage.Appointments.IsNewAppointment(appointment)) {
                edtSubject.SelectionLength = 0;
                edtSubject.SelectionStart = edtSubject.Text.Length;
            }
            base.OnShown(e);
        }
      
        public void FillForm(SchedulerControl control, Appointment appointment) {
            this.appointment = appointment;
            this.control = control;
            ISchedulerStorage storage = control.DataStorage;
            this.appointmentLabelEdit.Storage = storage;
            this.appointmentLabelEdit.AppointmentLabel = storage.Appointments.Labels.GetById(appointment.LabelKey);
            this.edtSubject.Text = appointment.Subject;
            this.edtDescription.Text = appointment.Description;
        }
        public void ApplyChanges() {
            appointment.Subject = edtSubject.Text;
            appointment.Description = edtDescription.Text;
            appointment.LabelKey = control.DataStorage.Appointments.Labels.IndexOf(appointmentLabelEdit.AppointmentLabel);            
        }
    }
}

