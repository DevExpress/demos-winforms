Imports System
Imports System.Drawing
Imports System.Linq
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos

    Public Module TimeRegionHelper

        Private Property BaseDate As Date

        Private Property Start As TimeSpan

        Private Property [End] As TimeSpan

        Sub New()
            BaseDate = DateTimeHelper.GetStartOfWeek(Date.Today).AddDays(-15)
            Start = TimeSpan.FromHours(13)
            [End] = TimeSpan.FromHours(14)
        End Sub

        Public Sub Attach(ByVal scheduler As SchedulerControl)
            Dim timeRegion1 As TimeRegion = New TimeRegion()
            timeRegion1.Start = BaseDate + Start
            timeRegion1.End = BaseDate + [End]
            timeRegion1.Editable = False
            timeRegion1.Recurrence = New RecurrenceInfo()
            timeRegion1.Recurrence.Start = timeRegion1.Start
            timeRegion1.Recurrence.Type = RecurrenceType.Weekly
            timeRegion1.Recurrence.WeekDays = WeekDays.WorkDays
            scheduler.TimeRegions.Add(timeRegion1)
            Dim timeRegion2 As TimeRegion = New TimeRegion()
            timeRegion2.Start = BaseDate
            timeRegion2.End = BaseDate.AddDays(1)
            timeRegion2.Editable = False
            timeRegion2.Recurrence = New RecurrenceInfo()
            timeRegion2.Recurrence.Start = timeRegion2.Start
            timeRegion2.Recurrence.Type = RecurrenceType.Weekly
            timeRegion2.Recurrence.WeekDays = WeekDays.WeekendDays
            scheduler.TimeRegions.Add(timeRegion2)
            AddHandler scheduler.TimeRegionCustomize, Sub(s, e)
                If e.Appointment Is Nothing Then Return
                If e.Appointment.StatusKey.Equals(3) Then e.Editable = True
            End Sub
            Dim svgImage As SvgImage = DemoUtils.GetResourceSvgImage("Images.Dinner.svg")
            AddHandler scheduler.CustomDrawTimeRegion, Sub(s, e)
                If e.TimeRegion Is timeRegion2 Then Return
                e.DrawDefault()
                Dim bounds As Rectangle = New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
                Dim scaleFactor As Double = CDbl(bounds.Height) / svgImage.Height
                Dim img As Image = svgImage.Render(Nothing, Math.Min(scaleFactor, 1))
                Dim x As Integer = e.Bounds.Location.X + (e.Bounds.Width \ 2 - img.Width \ 2)
                Dim y As Integer = e.Bounds.Location.Y + (e.Bounds.Height \ 2 - img.Height \ 2)
                e.Cache.DrawImage(img, New Point(x, y))
                e.Handled = True
            End Sub
            AddHandler scheduler.PopupMenuShowing, Sub(s, e)
                If scheduler.SelectedAppointments.Any(Function(x) IsIntersectWithRegion(x.Start, x.End)) Then e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu)
            End Sub
        End Sub

        Public Function IsIntersectWithRegion(ByVal start As Date, ByVal [end] As Date) As Boolean
            If IsWeekEnd(start) OrElse IsWeekEnd([end]) Then Return True
            Dim interval As TimeInterval = New TimeInterval(start, [end])
            Dim regionInterval As TimeInterval = New TimeInterval(BaseDate, Date.MaxValue)
            If Not regionInterval.IntersectsWith(interval) Then Return False
            Dim dayInterval As TimeOfDayInterval = New TimeOfDayInterval(start.TimeOfDay, start.TimeOfDay + interval.Duration)
            Dim dayRegionInterval As TimeOfDayInterval = New TimeOfDayInterval(TimeRegionHelper.Start, TimeRegionHelper.End)
            Return dayInterval.IntersectsWithExcludingBounds(dayRegionInterval)
        End Function

        Private Function IsWeekEnd(ByVal dateTime As Date) As Boolean
            Return dateTime.DayOfWeek = DayOfWeek.Sunday OrElse dateTime.DayOfWeek = DayOfWeek.Saturday
        End Function
    End Module
End Namespace
