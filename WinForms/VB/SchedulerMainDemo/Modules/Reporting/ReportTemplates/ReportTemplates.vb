Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates

    Public Partial Class ReportTemplatesModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            ControlPrintAdapter1.ReplaceDefaultPrinting()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property DisplayOptions As DayViewAppointmentDisplayOptions
            Get
                Return CType(schedulerControl.DayView.AppointmentDisplayOptions, DayViewAppointmentDisplayOptions)
            End Get
        End Property

        Private Sub ReportTemplates_Load(ByVal sender As Object, ByVal e As EventArgs)
            DemoUtils.FillResources(schedulerStorage, 5)
            InitAppointments()
            schedulerControl.Start = TutorialConstants.Now
        End Sub

        Private Sub InitAppointments()
            GenerateEvents(schedulerStorage)
        End Sub

        Private Sub GenerateEvents(ByVal storage As SchedulerStorage)
            Dim count As Integer = storage.Resources.Count
            Dim appointments As AppointmentStorage = storage.Appointments
            storage.BeginUpdate()
            For i As Integer = 0 To count - 1
                Dim resource As Resource = schedulerStorage.Resources(i)
                CreateAppointentsForResource(storage, resource)
            Next

            storage.EndUpdate()
        End Sub

        Private Sub CreateAppointentsForResource(ByVal storage As SchedulerStorage, ByVal resource As Resource)
            Dim statusCount As Integer = storage.Appointments.Statuses.Count
            Dim appointmentKind As String() = {"appointment", "personal time", "meeting", "travel"}
            Dim labelKind As Integer() = {1, 3, 5, 6}
            Dim subjPrefix As String = resource.Caption & "'s "
            Dim appointments As AppointmentStorage = storage.Appointments
            For i As Integer = 0 To 50 - 1
                Dim statusId As Integer = TutorialConstants.Random.Next(0, statusCount)
                Dim aptKindId As Integer = TutorialConstants.Random.Next(0, appointmentKind.Length)
                Dim labelId As Integer = labelKind(aptKindId)
                Dim subject As String = subjPrefix & appointmentKind(aptKindId)
                Dim dateRange As Integer = TutorialConstants.Random.Next(0, 20)
                Dim start As Date = TutorialConstants.Today.AddDays(dateRange - 2)
                appointments.Add(CreateAppointment(start, subject, resource.Id, statusId, labelId))
            Next
        End Sub

        Private Function CreateAppointment(ByVal start As Date, ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As Appointment
            Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
            apt.Subject = subject
            apt.ResourceId = resourceId
            apt.AllDay = TutorialConstants.Random.Next(0, 5) = 0
            Dim rangeInMinutes As Integer = 60 * 24
            apt.Start = start + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes))
            Dim duration As TimeSpan = TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes \ 4))
            If duration.Ticks = 0 Then duration = TimeSpan.FromMinutes(5)
            apt.End = apt.Start + duration
            apt.StatusKey = status
            apt.LabelKey = label
            Return apt
        End Function

        Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using form As ReportTemplateForm = New ReportTemplateForm(ControlPrintAdapter1)
                form.ShowDialog()
            End Using
        End Sub
    End Class
End Namespace
