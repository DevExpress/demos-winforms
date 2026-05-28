Imports System
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class XPOBoundModeModule
        Inherits TutorialControl

        Private baseDate As Date = TutorialConstants.Today

        Public Sub New()
            XpoDefault.DataLayer = New SimpleDataLayer(New InMemoryDataStore())
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub XPOBoundModeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.Start = baseDate
            InitData()
        End Sub

        Private Sub OnAppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            For Each apt As Appointment In e.Objects
                Dim o As XPBaseObject = TryCast(apt.GetSourceObject(schedulerStorage), XPBaseObject)
                If o IsNot Nothing Then o.Save()
            Next
        End Sub

        Private Sub InitData()
            If xpCollectionEmployees.Count <= 0 Then
                For i As Integer = 0 To 5 - 1
                    AddEmployee(DemoUtils.Users(i))
                Next
            End If

            If xpCollectionTasks.Count <= 0 Then
                For i As Integer = 0 To xpCollectionEmployees.Count - 1
                    AddTasks(CType(xpCollectionEmployees(i), Employee))
                Next
            End If
        End Sub

        Private Sub AddEmployee(ByVal name As String)
            Dim employee As Employee = New Employee(session1)
            employee.Name = name
            xpCollectionEmployees.Add(employee)
            employee.Save()
        End Sub

        Private Sub AddTasks(ByVal employee As Employee)
            AddTask(employee, "meeting", 2, 5)
            AddTask(employee, "travel", 3, 6)
            AddTask(employee, "phone call", 0, 10)
        End Sub

        Private Sub AddTask(ByVal employee As Employee, ByVal taskName As String, ByVal status As Integer, ByVal label As Integer)
            Dim task As Task = New Task(session1)
            task.Employee = employee
            task.Subject = employee.Name & "'s " & taskName
            Dim rangeInMinutes As Integer = 60 * 24
            task.Created = baseDate + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes))
            task.Finish = task.Created + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes \ 4))
            task.Status = status
            task.Label = label
            xpCollectionTasks.Add(task)
            task.Save()
        End Sub
    End Class

    ' XP object
    Public Class Task
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public AllDay As Boolean ' Appointment.AllDay

        <Size(SizeAttribute.Unlimited)>
        Public Description As String ' Appointment.Description

        Public Finish As Date ' Appointment.End

        Public Label As Integer ' Appointment.Label

        Public Location As String ' Appointment.Location

        <Size(SizeAttribute.Unlimited)>
        Public Recurrence As String ' Appointment.RecurrenceInfo

        <Size(SizeAttribute.Unlimited)>
        Public Reminder As String ' Appointment.ReminderInfo

        Public Created As Date ' Appointment.Start

        Public Status As Integer ' Appointment.Status

        Public Subject As String ' Appointment.Subject

        Public AppointmentType As Integer ' Appointment.Type

        Public Employee As Employee
    End Class

    ' XP object
    Public Class Employee
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        <Size(SizeAttribute.Unlimited)>
        Public Name As String ' Resource.Caption
    End Class
End Namespace
