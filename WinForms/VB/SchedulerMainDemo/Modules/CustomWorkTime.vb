Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CustomWorkTimeModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub CustomWorkTimeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            DemoUtils.FillResources(schedulerStorage, 5)
            InitAppointments()
            schedulerControl.Start = TutorialConstants.Now
        End Sub

        Private Sub InitAppointments()
            schedulerStorage.Appointments.Mappings.Start = "StartTime"
            schedulerStorage.Appointments.Mappings.End = "EndTime"
            schedulerStorage.Appointments.Mappings.Subject = "Subject"
            schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
            schedulerStorage.Appointments.Mappings.Description = "Description"
            schedulerStorage.Appointments.Mappings.Label = "Label"
            schedulerStorage.Appointments.Mappings.Location = "Location"
            schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            schedulerStorage.Appointments.Mappings.ResourceId = "OwnerId"
            schedulerStorage.Appointments.Mappings.Status = "Status"
            schedulerStorage.Appointments.Mappings.Type = "EventType"
            Dim eventList As CustomEventList = New CustomEventList()
            GenerateEvents(eventList)
            schedulerStorage.Appointments.DataSource = eventList
        End Sub

        Private Sub GenerateEvents(ByVal eventList As CustomEventList)
            Dim count As Integer = schedulerStorage.Resources.Count
            For i As Integer = 0 To count - 1
                Dim resource As Resource = schedulerStorage.Resources(i)
                Dim subjPrefix As String = resource.Caption & "'s "
                eventList.Add(CreateEvent(eventList, subjPrefix & "meeting", resource.Id, 2, 5))
                eventList.Add(CreateEvent(eventList, subjPrefix & "travel", resource.Id, 3, 6))
                eventList.Add(CreateEvent(eventList, subjPrefix & "phone call", resource.Id, 0, 10))
            Next
        End Sub

        Private Function CreateEvent(ByVal eventList As CustomEventList, ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomEvent
            Dim apt As CustomEvent = New CustomEvent(eventList)
            apt.Subject = subject
            apt.OwnerId = resourceId
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes \ 4))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function

        Private workTimes As TimeOfDayInterval() = New TimeOfDayInterval() {New TimeOfDayInterval(TimeSpan.FromHours(0), TimeSpan.FromHours(16)), New TimeOfDayInterval(TimeSpan.FromHours(10), TimeSpan.FromHours(20)), Nothing, New TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(15)), New TimeOfDayInterval(TimeSpan.FromHours(16), TimeSpan.FromHours(24))}

        Private Sub schedulerControl_QueryWorkTime(ByVal sender As Object, ByVal e As QueryWorkTimeEventArgs)
            If Not chkCustomWorkTime.Checked Then Return
            If schedulerStorage.Resources Is Nothing Then Return
            Dim resourceIndex As Integer = schedulerStorage.Resources.Items.IndexOf(e.Resource)
            If resourceIndex >= 0 Then
                If resourceIndex = 0 Then
                    If e.Interval.Start.Day Mod 2 = 0 Then
                        e.WorkTime = workTimes(resourceIndex Mod workTimes.Length)
                    Else
                        e.WorkTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(13)))
                        e.WorkTimes.Add(New TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(18)))
                    End If
                Else
                    If schedulerControl.WorkDays.IsWorkDay(e.Interval.Start.Date) Then e.WorkTime = workTimes(resourceIndex Mod workTimes.Length)
                End If
            End If
        End Sub

        Private Sub chkCustomWorkTime_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveView.LayoutChanged()
        End Sub
    End Class
End Namespace
