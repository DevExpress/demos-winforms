Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class RemindersModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub RemindersModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerDataStorage.Appointments.Clear()
            schedulerControl.DataStorage.EnableReminders = Visible
            'schedulerControl.OptionsBehavior.ShowRemindersForm = this.Visible;
            schedulerControl.Start = TutorialConstants.Today
        End Sub

        Private Sub btnCreateAppointmentWithReminder_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim now As Date = TutorialConstants.Now + TimeSpan.FromMinutes(5)
            Dim apt As Appointment = schedulerDataStorage.CreateAppointment(AppointmentType.Normal)
            apt.Start = now
            apt.Duration = TimeSpan.FromHours(1)
            apt.Subject = "Appointment with Reminder"
            apt.HasReminder = True
            schedulerDataStorage.Appointments.Add(apt)
            schedulerControl.ActiveView.GotoTimeInterval(New TimeInterval(apt.Start, apt.Duration))
        End Sub

        Private Sub btnGotoToday_Click(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.GoToToday()
        End Sub
    End Class
End Namespace
