Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ListBoundModeModule
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

        Private Sub ListBoundModeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            DemoUtils.FillResources(schedulerStorage, 5)
            InitAppointments()
            schedulerControl.Start = TutorialConstants.Now
        End Sub

        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = schedulerStorage.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"
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
    End Class
End Namespace
