using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DentalClinic.Model;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Internal;
using DevExpress.Mvvm;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic {
    public static class InvoiceHelper {
        public static Task RescheduleAppointments() {
            return Task.Run(() => {
                string databasePath = DBPathHelper.EnsureWriteable(Application.StartupPath, "DentalCabinet.db");
                string connectionString = @"XpoProvider=SQLite;Data Source=" + databasePath;
                var authentication = new AuthenticationStandard();
                var security = new SecurityStrategyComplex(typeof(PermissionPolicyUser), typeof(PermissionPolicyRole), authentication);
                var objectSpaceProvider = new SecuredObjectSpaceProvider(security, connectionString, null);
                security.RegisterXPOAdapterProviders();
                var objectSpace = objectSpaceProvider.CreateUpdatingObjectSpace(true);
                UnitOfWork session = (objectSpace as XPObjectSpace).Session as UnitOfWork;
                var allAppointments = new XPCollection<Appointment>(session);
                var doctors = new XPCollection<Doctor>(session);
                foreach(var doctor in doctors) {
                    var doctorAppointments = allAppointments.Where(i => i.Doctor == doctor);
                    var canceledAppointments = doctorAppointments.Where(i => i.Status == AppointmentStatus.Canceled);
                    int canceledAppointmentsCount = canceledAppointments.Count();
                    int actualCanceledAppointmentsCount = (int)(canceledAppointmentsCount * 0.2);
                    int canceledPastAppointmentsCount = canceledAppointmentsCount - actualCanceledAppointmentsCount;
                    var pastAppointments = doctorAppointments
                        .Where(i => i.Status == AppointmentStatus.Completed || i.Status == AppointmentStatus.Failed)
                        .Concat(canceledAppointments.Take(canceledPastAppointmentsCount))
                        .OrderBy(i => i.Date);
                    RescheduleAppointments(pastAppointments, true);
                    var actualAppointments = doctorAppointments
                        .Where(i => i.Status == AppointmentStatus.Open)
                        .Concat(canceledAppointments.Skip(canceledPastAppointmentsCount))
                        .OrderBy(i => i.Date);
                    RescheduleAppointments(actualAppointments, false);
                }
                session.CommitChanges();
            });
        }
        public static void RescheduleAppointments(IEnumerable<Appointment> appointments, bool useBackDirection) {
            int startHour = 9, endHour = 18, lunchHour = 12, lunchDuration = 1;
            var initialTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, startHour, 0, 0);
            var nextFreeTime = initialTime;
            Func<DateTime, TimeSpan, DateTime> offsetTime = (d, s) => useBackDirection ? d - s : d + s;
            foreach(var appointment in appointments) {
                var workStartTime = new DateTime(nextFreeTime.Year, nextFreeTime.Month, nextFreeTime.Day, startHour, 0, 0);
                var workEndTime = new DateTime(nextFreeTime.Year, nextFreeTime.Month, nextFreeTime.Day, endHour, 0, 0);
                var lunchStartTime = new DateTime(nextFreeTime.Year, nextFreeTime.Month, nextFreeTime.Day, lunchHour, 0, 0);
                var lunchEndTime = lunchStartTime.AddHours(lunchDuration);
                var duration = TimeSpan.Zero;
                foreach(var item in appointment.ProcedureCollection)
                    duration += item.Procedure.Duration;
                DateTime offsettedTime = offsetTime(nextFreeTime, duration);
                if(useBackDirection ? offsettedTime < workStartTime : offsettedTime > workEndTime) {
                    nextFreeTime = nextFreeTime.AddDays(useBackDirection ? -1 : 1);
                    nextFreeTime = new DateTime(nextFreeTime.Year, nextFreeTime.Month, nextFreeTime.Day, useBackDirection ? endHour : startHour, 0, 0);
                    lunchStartTime = new DateTime(nextFreeTime.Year, nextFreeTime.Month, nextFreeTime.Day, lunchHour, 0, 0);
                    lunchEndTime = lunchStartTime.AddHours(lunchDuration);
                }
                offsettedTime = offsetTime(nextFreeTime, duration);
                if(nextFreeTime >= lunchStartTime && nextFreeTime <= lunchEndTime || offsettedTime >= lunchStartTime && offsettedTime <= lunchEndTime || (useBackDirection
                    ? lunchEndTime < nextFreeTime && lunchStartTime > offsettedTime
                    : lunchStartTime > nextFreeTime && lunchEndTime < offsettedTime))
                    nextFreeTime = useBackDirection ? lunchStartTime : lunchEndTime;
                appointment.Date = nextFreeTime;
                appointment.Duration = duration;
                var invoice = appointment.Patient.InvoiceCollection.FirstOrDefault(i => i.Appointment == appointment);
                if(useBackDirection) {
                    if(invoice != null)
                        invoice.Date = nextFreeTime;
                    appointment.Date -= duration;
                    nextFreeTime -= duration;
                }
                else {
                    nextFreeTime += duration;
                    if(invoice != null)
                        invoice.Date = nextFreeTime;
                }
            }
        }
    }
    public static class ScheduleHelper {
        public static IList<DateTimeRange> GetFreeIntervals(UnitOfWork session, Guid doctorId, TimeSpan duration) {
            DateTime date = DateTime.Now;
            List<Appointment> appointments = GetSortedAppointments(date, doctorId, session);
            List<DateTimeRange> busyRanges = new List<DateTimeRange>();
            foreach(var apt in appointments) {
                DateTimeRange appointmentRange = new DateTimeRange(apt.Date, apt.EndDate);
                if(busyRanges.Count == 0) {
                    busyRanges.Add(appointmentRange);
                    continue;
                }
                var currentRange = busyRanges[busyRanges.Count - 1];
                if(currentRange.IntersectsWith(appointmentRange))
                    busyRanges[busyRanges.Count - 1] = currentRange.Union(appointmentRange);
                else
                    busyRanges.Add(appointmentRange);
            }
            List<DateTimeRange> result = new List<DateTimeRange>();
            DateTime current = date;
            DateTime endWorkDay = new DateTime(current.Year, current.Month, current.Day, 18, 0, 0);
            DateTimeRange freeRange;
            foreach(var range in busyRanges) {
                if(range.Start.Day != current.Day && range.Start > current) {
                    if(current < endWorkDay) {
                        freeRange = new DateTimeRange(current, endWorkDay);
                        if(freeRange.Duration >= duration)
                            AddFreeRange(result, freeRange, duration);
                    }
                    current = current.AddDays(1);
                    current = new DateTime(current.Year, current.Month, current.Day, 9, 0, 0);
                }
                freeRange = new DateTimeRange(current, range.Start);
                if(freeRange.Duration >= duration)
                    AddFreeRange(result, freeRange, duration);
                current = range.End;
            }
            if(result.Count == 0) {
                current = current.AddDays(1);
                result = GetEmptyIntervals(current, duration);
            }
            return result;
        }
        static TimeSpan Step = TimeSpan.FromMinutes(15);
        static void AddFreeRange(List<DateTimeRange> result, DateTimeRange freeRange, TimeSpan duration) {
            if(freeRange.Duration - duration >= Step) {
                while(freeRange.Duration - duration >= Step) {
                    var dateTimeRange = new DateTimeRange(freeRange.Start, duration);
                    result.Add(dateTimeRange);
                    freeRange = new DateTimeRange(freeRange.Start.Add(Step), freeRange.End);
                }
            }
            else result.Add(freeRange);
        }
        public static List<DateTimeRange> GetEmptyIntervals(DateTime date, TimeSpan duration) {
            List<DateTimeRange> result = new List<DateTimeRange>();
            DateTimeRange freeRange = new DateTimeRange(new DateTime(date.Year, date.Month, date.Day, 9, 0, 0), new DateTime(date.Year, date.Month, date.Day, 18, 0, 0));
            while(freeRange.Duration - duration >= Step) {
                var dateTimeRange = new DateTimeRange(freeRange.Start, duration);
                result.Add(dateTimeRange);
                freeRange = new DateTimeRange(freeRange.Start.Add(Step), freeRange.End);
            }
            return result;
        }
        static List<Appointment> GetSortedAppointments(DateTime date, Guid doctorId, UnitOfWork session) {
            var appointments = new XPCollection<Appointment>(session).Where(x => x.Date >= date && x.Doctor.Oid == doctorId).ToList();
            appointments.Sort((x, y) => {
                if(x.Date < y.Date)
                    return -1;
                if(x.Date > y.Date)
                    return 1;
                if(x.Date == y.Date) {
                    if(x.EndDate > y.EndDate) {
                        return -1;
                    }
                    else if(x.EndDate < y.EndDate)
                        return 1;
                }
                return 0;
            });
            return appointments;
        }
    }
    public class ImageValueConverter : Xpo.Metadata.ValueConverter {
        public override Type StorageType { get { return typeof(byte[]); } }
        public override object ConvertToStorageType(object value) {
            if(value == null) {
                return null;
            }
            else {
                var cnv = new System.Drawing.ImageConverter();
                return cnv.ConvertTo(value, StorageType);
            }
        }
        public override object ConvertFromStorageType(object value) {
            if(value == null) {
                return null;
            }
            else {
                var cnv = new System.Drawing.ImageConverter();
                return cnv.ConvertFrom(value);
            }
        }
    }
    public static class DBPathHelper {
        public static string EnsureWriteable(string path, string name) {
            // removed usage of path given that we use new api, however left the parameter for backward compatibility
            string filePath = DevAVDataDirectoryHelper.GetFile(name);
            if(!string.IsNullOrEmpty(filePath)) {
                var attributes = System.IO.File.GetAttributes(filePath);
                if((attributes & System.IO.FileAttributes.ReadOnly) == System.IO.FileAttributes.ReadOnly)
                    System.IO.File.SetAttributes(filePath, attributes & (~System.IO.FileAttributes.ReadOnly));
            }
            return filePath;
        }
    }
}
