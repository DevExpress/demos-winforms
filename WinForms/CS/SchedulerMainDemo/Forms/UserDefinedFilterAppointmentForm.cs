using System;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.XtraScheduler.Demos.Forms {
    public partial class UserDefinedFilterAppointmentForm : AppointmentForm {
        public UserDefinedFilterAppointmentForm() {
            InitializeComponent();
        }
        public UserDefinedFilterAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm) {
            InitializeComponent();
            BindToController();
        }

        protected internal new UserDefinedFilterAppointmentFormController Controller { get { return (UserDefinedFilterAppointmentFormController)base.Controller; } }

        protected override AppointmentFormController CreateController(SchedulerControl control, Appointment apt) {
            return new UserDefinedFilterAppointmentFormController(control, apt);
        }
        void BindToController() {
            this.edtPrice.DataBindings.Add("EditValue", Controller, "Price");
            this.edtPrice.DataBindings.Add("ReadOnly", Controller, "ReadOnly");
        }
        public override bool IsAppointmentChanged(Appointment appointment) {
            if (base.IsAppointmentChanged(appointment))
                return true;
            return Controller.IsPriceChanged;
        }
    }

    public class UserDefinedFilterAppointmentFormController : AppointmentFormController {
        public UserDefinedFilterAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt) {
        }

        public Decimal Price {
            get {
                return ObtainPrice(EditedAppointmentCopy);
            }
            set { EditedAppointmentCopy.CustomFields["CustomFieldPrice"] = value; }
        }
        public bool IsPriceChanged { get { return Price != ObtainPrice(SourceAppointment); } }

        protected override void ApplyCustomFieldsValues() {
            base.ApplyCustomFieldsValues();
            SourceAppointment.CustomFields["CustomFieldPrice"] = Price;
        }
        Decimal ObtainPrice(Appointment apt) {
            object value = apt.CustomFields["CustomFieldPrice"];
            try {
                return Convert.ToDecimal(value);
            } catch {
                return 0;
            }
        }
    }
}
