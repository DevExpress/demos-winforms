Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class CustomEditAppointmentFormModule
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

        Private Sub AddCustomFieldsMapping()
            Dim customNameMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping("CustomName", "CustomName")
            Dim customStatusMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping("CustomStatus", "CustomStatus")
            schedulerStorage.Appointments.CustomFieldMappings.Add(customNameMapping)
            schedulerStorage.Appointments.CustomFieldMappings.Add(customStatusMapping)
        End Sub

        Private Sub CustomEditAppointmentFormModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddCustomFieldsMapping()
            FillData(schedulerControl, schedulerStorage)
        End Sub

        Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim apt As Appointment = e.Appointment
            Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso schedulerStorage.Appointments.IsNewAppointment(apt)
            Dim f As MyAppointmentEditForm = New MyAppointmentEditForm(CType(sender, SchedulerControl), apt, openRecurrenceForm)
            f.SetMenuManager(schedulerControl.MenuManager)
            f.LookAndFeel.ParentLookAndFeel = LookAndFeel.ParentLookAndFeel
            e.DialogResult = f.ShowDialog()
            e.Handled = True
            If apt.Type.Equals(AppointmentType.Pattern) AndAlso schedulerControl.SelectedAppointments.Contains(apt) Then schedulerControl.SelectedAppointments.Remove(apt)
            schedulerControl.Refresh()
        End Sub
    End Class
End Namespace
