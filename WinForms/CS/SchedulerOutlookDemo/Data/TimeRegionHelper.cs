using System;
using System.Drawing;
using System.Linq;
using DevExpress.Utils.Svg;
using DevExpress.XtraScheduler.Native;

namespace DevExpress.XtraScheduler.Demos {
    public static class TimeRegionHelper {
        static DateTime BaseDate { get; set; }
        static TimeSpan Start { get; set; }
        static TimeSpan End { get; set; }

        static TimeRegionHelper() {
            BaseDate = DateTimeHelper.GetStartOfWeek(DateTime.Today).AddDays(-15);
            Start = TimeSpan.FromHours(13);
            End = TimeSpan.FromHours(14);
        }

        public static void Attach(SchedulerControl scheduler) {
            TimeRegion timeRegion1 = new TimeRegion();
            timeRegion1.Start = BaseDate + Start;
            timeRegion1.End = BaseDate + End;
            timeRegion1.Editable = false;
            timeRegion1.Recurrence = new RecurrenceInfo();
            timeRegion1.Recurrence.Start = timeRegion1.Start;
            timeRegion1.Recurrence.Type = RecurrenceType.Weekly;
            timeRegion1.Recurrence.WeekDays = WeekDays.WorkDays;
            scheduler.TimeRegions.Add(timeRegion1);

            TimeRegion timeRegion2 = new TimeRegion();
            timeRegion2.Start = BaseDate;
            timeRegion2.End = BaseDate.AddDays(1);
            timeRegion2.Editable = false;
            timeRegion2.Recurrence = new RecurrenceInfo();
            timeRegion2.Recurrence.Start = timeRegion2.Start;
            timeRegion2.Recurrence.Type = RecurrenceType.Weekly;
            timeRegion2.Recurrence.WeekDays = WeekDays.WeekendDays;
            scheduler.TimeRegions.Add(timeRegion2);

            scheduler.TimeRegionCustomize += (s, e) => {
                if (e.Appointment == null)
                    return;
                if (e.Appointment.StatusKey.Equals(3))
                    e.Editable = true;
            };
            SvgImage svgImage = DemoUtils.GetResourceSvgImage("Images.Dinner.svg");
            scheduler.CustomDrawTimeRegion += (s, e) => {
                if (e.TimeRegion == timeRegion2)
                    return;
                e.DrawDefault();
                Rectangle bounds = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                double scaleFactor = (double)bounds.Height / svgImage.Height;
                Image img = svgImage.Render(null, Math.Min(scaleFactor, 1));
                int x = e.Bounds.Location.X + (e.Bounds.Width / 2 - img.Width / 2);
                int y = e.Bounds.Location.Y + (e.Bounds.Height / 2 - img.Height / 2);
                e.Cache.DrawImage(img, new Point(x, y));
                e.Handled = true;
            };

            scheduler.PopupMenuShowing += (s, e) => {
                if (scheduler.SelectedAppointments.Any(x => IsIntersectWithRegion(x.Start, x.End)))
                    e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
            };
        }

        public static bool IsIntersectWithRegion(DateTime start, DateTime end) {
            if (IsWeekEnd(start) || IsWeekEnd(end))
                return true;
            TimeInterval interval = new TimeInterval(start, end);
            TimeInterval regionInterval = new TimeInterval(BaseDate, DateTime.MaxValue);
            if (!regionInterval.IntersectsWith(interval))
                return false;
            TimeOfDayInterval dayInterval = new TimeOfDayInterval(start.TimeOfDay, start.TimeOfDay + interval.Duration);
            TimeOfDayInterval dayRegionInterval = new TimeOfDayInterval(Start, End);
            return dayInterval.IntersectsWithExcludingBounds(dayRegionInterval);
        }
        
        static bool IsWeekEnd(DateTime dateTime) {
            return dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}
