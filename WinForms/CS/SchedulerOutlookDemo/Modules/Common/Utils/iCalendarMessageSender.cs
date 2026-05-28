using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraScheduler.iCalendar;

namespace DevExpress.XtraScheduler.Demos {
    public static class iCalendarMessageSender {
        public static void ExportAppointments(Form owner, ISchedulerStorage storage, AppointmentBaseCollection appointments) {
            List<DirectoryInfo> tempDirInfos = new List<DirectoryInfo>(appointments.Count);
            try {
                string[] files = new string[appointments.Count];
                for (int i = 0; i < appointments.Count; i++) {
                    string tempDirectoryName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                    DirectoryInfo tempDirInfo = new DirectoryInfo(tempDirectoryName);
                    if (tempDirInfo.Exists)
                        return;
                    tempDirInfo.Create();
                    tempDirInfos.Add(tempDirInfo);
                    Appointment appointment = appointments[i];
                    AppointmentBaseCollection appointmentsToExport = new AppointmentBaseCollection();
                    appointmentsToExport.Add(appointment);
                    iCalendarExporter exporter = new iCalendarExporter(storage, appointmentsToExport);
                    string filePath = Path.Combine(tempDirectoryName, GetFileName(appointment));
                    using (FileStream output = File.OpenWrite(filePath)) {
                        exporter.Export(output);
                        files[i] = filePath;
                        output.Flush();
                    }
                }
                int appointmentCount = appointments.Count;
                string fileName = appointmentCount == 1 ? string.Format("FW:{0}", GetFileName(appointments[0])) : "";                
                SendAppointmentByMailForm actionForm = new SendAppointmentByMailForm(fileName, files);                
                actionForm.StartPosition = FormStartPosition.CenterParent;
                actionForm.ShowDialog(owner);
                
            } finally {
                foreach (DirectoryInfo tempDirInfo in tempDirInfos)
                    tempDirInfo.Delete(true);
            }
        }
                
        static string GetFileName(Appointment appointment) {
            return string.Format("{0}.ics", string.IsNullOrEmpty(appointment.Subject) ? "Untitled" : appointment.Subject);
        }
    }
}
