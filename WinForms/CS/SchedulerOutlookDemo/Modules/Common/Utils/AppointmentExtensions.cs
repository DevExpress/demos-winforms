using DevExpress.XtraScheduler.Demos.DemoData;
using System;
using System.Linq;

namespace DevExpress.XtraScheduler.Demos {
    public static class AppointmentExtensions {
        public static bool GetIsPrivate(this Appointment appointment) {
            object value = appointment.CustomFields["IsPrivate"];
            if (value == null)
                return false;
            return (bool)value;
        }

        public static void SetIsPrivate(this Appointment appointment, bool value) {
            appointment.CustomFields["IsPrivate"] = value;
        }

        public static void ToggleIsPrivate(this Appointment appointment) {
            appointment.CustomFields["IsPrivate"] = !appointment.GetIsPrivate();
        }

        public static EventPriority GetPriority(this Appointment appointment) {
            object value = appointment.CustomFields["Priority"];
            return (value == null) ? EventPriority.None : (EventPriority)value;
        }

        public static void SetPriority(this Appointment appointment, EventPriority value) {
            appointment.CustomFields["Priority"] = value;
        }
    }
}
