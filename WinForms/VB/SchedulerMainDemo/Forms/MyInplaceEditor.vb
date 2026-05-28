Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos.Forms

    Public Partial Class MyInplaceEditor
        Inherits XtraEditors.XtraForm

        Private appointment As Appointment

        Private control As SchedulerControl

        Public Sub New()
            InitializeComponent()
            SubscribeKeyDownEvents()
        End Sub

        Public Event CommitChanges As EventHandler

        Public Event RollbackChanges As EventHandler

        Private Sub SubscribeKeyDownEvents()
            AddHandler appointmentLabelEdit.KeyDown, New KeyEventHandler(AddressOf AppointmentLabelEdit_KeyDown)
            AddHandler edtDescription.KeyDown, New KeyEventHandler(AddressOf Editor_KeyDown)
            AddHandler edtSubject.KeyDown, New KeyEventHandler(AddressOf Editor_KeyDown)
        End Sub

        Public Sub AppointmentLabelEdit_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If Not appointmentLabelEdit.IsPopupOpen Then Editor_KeyDown(sender, e)
        End Sub

        Private Sub Editor_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Enter
                    e.Handled = True
                    OnCommitChanges()
                Case Keys.Escape
                    e.Handled = True
                    OnRollbackChanges()
            End Select
        End Sub

        Private Sub OnCommitChanges()
            RaiseEvent CommitChanges(Me, EventArgs.Empty)
        End Sub

        Private Sub OnRollbackChanges()
            RaiseEvent RollbackChanges(Me, EventArgs.Empty)
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            Dim storage As ISchedulerStorageBase = control.DataStorage
            If storage.Appointments.IsNewAppointment(appointment) Then
                edtSubject.SelectionLength = 0
                edtSubject.SelectionStart = edtSubject.Text.Length
            End If

            MyBase.OnShown(e)
        End Sub

        Public Sub FillForm(ByVal control As SchedulerControl, ByVal appointment As Appointment)
            Me.appointment = appointment
            Me.control = control
            Dim storage As ISchedulerStorage = control.DataStorage
            appointmentLabelEdit.Storage = storage
            appointmentLabelEdit.AppointmentLabel = storage.Appointments.Labels.GetById(appointment.LabelKey)
            edtSubject.Text = appointment.Subject
            edtDescription.Text = appointment.Description
        End Sub

        Public Sub ApplyChanges()
            appointment.Subject = edtSubject.Text
            appointment.Description = edtDescription.Text
            appointment.LabelKey = control.DataStorage.Appointments.Labels.IndexOf(appointmentLabelEdit.AppointmentLabel)
        End Sub
    End Class
End Namespace
