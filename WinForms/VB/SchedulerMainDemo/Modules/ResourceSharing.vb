Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ResourceSharingModule
        Inherits TutorialControl

        Const AttendeeDescription As String = "The following persons are invited:" & Microsoft.VisualBasic.Constants.vbCrLf

        Private Shared ReadOnly labelKeys As Integer() = New Integer() {1, 2, 5, 6, 7}

        Private Shared ReadOnly statusKeys As Integer() = New Integer() {1, 2}

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

        Private Sub ResourceSharingModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.Start = TutorialConstants.Today
            DemoUtils.FillResources(schedulerDataStorage, Integer.MaxValue)
            PrepareMeetings()
        End Sub

#Region "data initialization"
        Private Sub PrepareMeetings()
            Dim resourceCount As Integer = schedulerDataStorage.Resources.Count
            System.Diagnostics.Debug.Assert(resourceCount = 8)
            Dim today As Date = TutorialConstants.Today
            For i As Integer = 0 To 30 - 1
                If today.DayOfWeek <> DayOfWeek.Sunday Then
                    CreateMeeting("Morning meeting", today + TimeSpan.FromHours(9), 1)
                    CreateMeeting("Product delivery planning", today + TimeSpan.FromHours(11), 2)
                    CreateMeeting("New product concept presentation", today + TimeSpan.FromHours(14), 2)
                    CreateMeeting("Discussion", today + TimeSpan.FromHours(16), 1)
                    CreateMeeting("New employee interview", today + TimeSpan.FromHours(17), 1)
                End If

                today = today + TimeSpan.FromDays(1)
            Next
        End Sub

        Private Function GetParticipants() As Integer()
            Dim count As Integer = TutorialConstants.Random.Next(1, 6)
            Dim resources As Integer() = New Integer(count - 1) {}
            For i As Integer = 0 To count - 1
                resources(i) = TutorialConstants.Random.Next(8)
            Next

            Return resources
        End Function

        Private Function CreateMeeting(ByVal subject As String, ByVal [date] As Date, ByVal hours As Integer) As Appointment
            Dim apt As Appointment = schedulerDataStorage.CreateAppointment(AppointmentType.Normal)
            apt.Start = [date]
            apt.Duration = TimeSpan.FromHours(hours)
            apt.Subject = subject
            apt.StatusKey = If(TutorialConstants.Random.Next(100) Mod 2 > 0, statusKeys(0), statusKeys(1))
            apt.LabelKey = labelKeys(TutorialConstants.Random.Next(4))
            Dim description As String = AttendeeDescription
            Dim participants As Integer() = GetParticipants()
            Dim count As Integer = participants.Length
            For i As Integer = 0 To count - 1
                Dim resource As Resource = schedulerDataStorage.Resources(participants(i))
                description += String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf, resource.Caption)
                apt.ResourceIds.Add(resource.Id)
            Next

            apt.Description = description
            schedulerDataStorage.Appointments.Add(apt)
            Return apt
        End Function

#End Region
        Private Sub schedulerStorage_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
            Dim apt As Appointment = TryCast(e.Object, Appointment)
            apt.Description = AttendeeDescription & GetAttendeeNames(apt.ResourceIds)
        End Sub

        Private Function GetAttendeeNames(ByVal resIds As AppointmentResourceIdCollection) As String
            Dim result As String = String.Empty
            Dim resources As ResourceCollection = schedulerDataStorage.Resources.Items
            For Each resource As Resource In resources
                If resIds.Contains(resource.Id) Then result += String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf, resource.Caption)
            Next

            Return result
        End Function
    End Class
End Namespace
