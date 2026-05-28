using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ChangeViewForm : XtraForm {
        ViewOptionsControl viewOptionsControl;
        CalendarOptionsControl calendarOptionsControl;
        AppointmentOptionsControl appointmentOptionsControl;

        public ChangeViewForm() {
            InitializeComponent();
            this.accordionControl1.SelectedElement = this.accordionControlElement2;
            this.viewOptionsControl = new ViewOptionsControl();
            this.calendarOptionsControl = new CalendarOptionsControl();
            this.appointmentOptionsControl = new AppointmentOptionsControl();
            this.viewOptionsControl.Dock = DockStyle.Fill;
            this.calendarOptionsControl.Dock = DockStyle.Fill;
            this.appointmentOptionsControl.Dock = DockStyle.Fill;
            this.panelControl1.Controls.Add(this.viewOptionsControl);
            this.panelControl1.Controls.Add(this.calendarOptionsControl);
            this.panelControl1.Controls.Add(this.appointmentOptionsControl);
            UpdateCurrentOptionsVisibility();
        }

        public void LoadOptions(CommonOptions options) {
            this.viewOptionsControl.LoadOptions(options);
            this.calendarOptionsControl.LoadOptions(options);
            this.appointmentOptionsControl.LoadOptions(options);
        }

        public void SaveOptions(CommonOptions options) {
            this.viewOptionsControl.SaveOptions(options);
            this.calendarOptionsControl.SaveOptions(options);
            this.appointmentOptionsControl.SaveOptions(options);
        }

        void accordionControl1_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e) {
            if (e.Element.Tag == null)
                return;
            UpdateCurrentOptionsVisibility();
        }

        void UpdateCurrentOptionsVisibility() {
            string optionsName = this.accordionControl1.SelectedElement.Tag.ToString();
            SetOptionsControlVisible(this.viewOptionsControl, optionsName == "Views");
            SetOptionsControlVisible(this.calendarOptionsControl, optionsName == "Calendars");
            SetOptionsControlVisible(this.appointmentOptionsControl, optionsName == "Appointments");
        }

        void SetOptionsControlVisible(Control control, bool value) {
            if (control == null)
                return;
            control.Visible = value;
        }
    }
}
