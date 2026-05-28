Namespace DevExpress.MailClient.Win
    Partial Public Class Calendar
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Calendar))
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeScaleMonth1 As New DevExpress.XtraScheduler.TimeScaleMonth()
            Dim timeScaleWeek1 As New DevExpress.XtraScheduler.TimeScaleWeek()
            Dim timeScaleDay1 As New DevExpress.XtraScheduler.TimeScaleDay()
            Dim timeScaleHour1 As New DevExpress.XtraScheduler.TimeScaleHour()
            Dim timeScaleFixedInterval1 As New DevExpress.XtraScheduler.TimeScaleFixedInterval()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ContactInfo", "ContactInfo", DevExpress.XtraScheduler.FieldValueType.String))
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndDate"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartDate"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
            Me.schedulerStorage1.Resources.Mappings.Caption = "Name"
            Me.schedulerStorage1.Resources.Mappings.Id = "ID"
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
            resources.ApplyResources(Me.schedulerControl1, "schedulerControl1")
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Start = New Date(2011, 12, 26, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.GanttView.Enabled = False
            timeScaleMonth1.Enabled = False
            timeScaleMonth1.Width = 100
            timeScaleWeek1.Width = 100
            timeScaleDay1.Width = 100
            timeScaleHour1.Enabled = False
            timeScaleHour1.Width = 100
            timeScaleFixedInterval1.Enabled = False
            timeScaleFixedInterval1.Value = System.TimeSpan.Parse("00:30:00")
            timeScaleFixedInterval1.Width = 100
            Me.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleMonth1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleWeek1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleDay1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleHour1)
            Me.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleFixedInterval1)
            Me.schedulerControl1.Views.WorkWeekView.ShowFullWeek = True
            Me.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' Calendar
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Calendar"
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    End Class
End Namespace
