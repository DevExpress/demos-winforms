Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraSplashScreen
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class PerformanceTestModule
        Inherits TutorialControl

        Const DAY_COUNT As Integer = 100

        Const MAX_APPOINTMENTS_PER_DAY As Integer = 1000

        Private data50 As BindingList(Of Record) = Nothing

        Private data100 As BindingList(Of Record) = Nothing

        Private data500 As BindingList(Of Record) = Nothing

        Private data1000 As BindingList(Of Record) = Nothing

        Private subjects As String() = {"Peter Dolan's meeting", "Peter Dolan's phone call", "Peter Dolan's travel", "Ryan Fischer's meeting", "Ryan Fischer's phone call", "Ryan Fischer's travel"}

        Public Sub New()
            InitializeComponent()
            PrepareViews()
            DemoUtils.FillResources(schedulerDataStorage, 2)
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Function GetRandomDouble(ByVal rnd As DevExpress.Data.Utils.NonCryptographicRandom, ByVal min As Double, ByVal max As Double) As Double
            Return min + (max - min) * rnd.NextDouble()
        End Function

        Private Sub PrepareViews()
            schedulerControl.MonthView.Enabled = True
            schedulerControl.TimelineView.Enabled = True
            schedulerControl.GanttView.Enabled = False
            schedulerControl.DayView.Enabled = True
            schedulerControl.WorkWeekView.Enabled = True
            schedulerControl.FullWeekView.Enabled = True
            schedulerControl.AgendaView.Enabled = False
        End Sub

        Private Sub PerformanceTestModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            grSwitch.SelectedIndex = 0
        End Sub

        Private Sub UpdateAppointmentStorage()
            Dim aptsPerDay As Integer = Convert.ToInt32(grSwitch.EditValue)
            Select Case aptsPerDay
                Case 50
                    If data50 Is Nothing Then GenerateAppointments(aptsPerDay, data50)
                    schedulerDataStorage.Appointments.DataSource = data50
                Case 100
                    If data100 Is Nothing Then GenerateAppointments(aptsPerDay, data100)
                    schedulerDataStorage.Appointments.DataSource = data100
                Case 500
                    If data500 Is Nothing Then GenerateAppointments(aptsPerDay, data500)
                    schedulerDataStorage.Appointments.DataSource = data500
                Case 1000
                    If data1000 Is Nothing Then GenerateAppointments(aptsPerDay, data1000)
                    schedulerDataStorage.Appointments.DataSource = data1000
            End Select
        End Sub

        Private Sub GenerateAppointments(ByVal aptsPerDay As Integer, <Out> ByRef list As BindingList(Of Record))
            Dim start As Date = TutorialConstants.Today.AddDays(-DAY_COUNT \ 2)
            Dim appointments As List(Of Record) = Enumerable.Range(0, DAY_COUNT * aptsPerDay).[Select](Function(i) CreateNewRecord(i, aptsPerDay, TutorialConstants.Random, start)).ToList()
            list = New BindingList(Of Record)(appointments)
        End Sub

        Private Function CreateNewRecord(ByVal index As Integer, ByVal aptsPerDay As Integer, ByVal rnd As DevExpress.Data.Utils.NonCryptographicRandom, ByVal start As Date) As Record
            Dim day As Integer = index \ aptsPerDay
            Dim rec As Record = New Record()
            rec.Id = index + 1
            rec.StartTime = start.AddDays(day).AddHours(GetRandomDouble(rnd, 0, 18))
            rec.EndTime = rec.StartTime.AddHours(GetRandomDouble(rnd, 0.5, 6.0))
            Dim subjectIndex As Integer = rnd.Next(0, subjects.Length)
            rec.Subject = subjects(subjectIndex)
            rec.Label = rnd.Next(0, 11)
            rec.ResourceId = If(subjectIndex < 3, 1, 2)
            Return rec
        End Function

        Private Sub PerformanceTestModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveViewType = SchedulerViewType.Day
            schedulerControl.DayView.DayCount = 1
            schedulerControl.GroupType = SchedulerGroupType.Resource
            schedulerControl.Start = TutorialConstants.Today
        End Sub

        Private Sub grSwitch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            BeginInvoke(New Action(Sub()
                Call SplashScreenManager.ShowDefaultWaitForm()
                UpdateAppointmentStorage()
                Call SplashScreenManager.CloseDefaultWaitForm()
            End Sub))
        End Sub
    End Class

    Public Class Record

        Public Property Id As Integer

        Public Property Subject As String

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property Label As Integer

        Public Property ResourceId As Integer
    End Class
End Namespace
