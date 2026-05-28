Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

' ...
Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class MyAppointmentEditForm
        Inherits XtraForm

        Private _control As SchedulerControl

        Private _apt As Appointment

        Private _openRecurrenceForm As Boolean = False

        Private _suspendUpdateCount As Integer

        Private _menuManager As IDXMenuManager

        Private _checkAllDay As CheckEdit

        ' Note that the MyAppointmentFormController class is inherited from
        ' the AppointmentFormController one to add custom properties.
        ' See its declaration at the end of this file.
        Private _controller As MyAppointmentFormController

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
            _openRecurrenceForm = openRecurrenceForm
            _controller = New MyAppointmentFormController(control, apt)
            _apt = apt
            _control = control
            '
            ' Required for Windows Form Designer support
            '
            SuspendUpdate()
            InitializeComponent()
            ResumeUpdate()
            UpdateForm()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected ReadOnly Property Appointments As IAppointmentStorage
            Get
                Return _control.DataStorage.Appointments
            End Get
        End Property

        Protected Friend ReadOnly Property IsNewAppointment As Boolean
            Get
                Return If(_controller IsNot Nothing, _controller.IsNewAppointment, True)
            End Get
        End Property

        Protected ReadOnly Property IsUpdateSuspended As Boolean
            Get
                Return _suspendUpdateCount > 0
            End Get
        End Property

        Public ReadOnly Property MenuManager As IDXMenuManager
            Get
                Return _menuManager
            End Get
        End Property

        Protected Sub SuspendUpdate()
            _suspendUpdateCount += 1
        End Sub

        Protected Sub ResumeUpdate()
            If _suspendUpdateCount > 0 Then _suspendUpdateCount -= 1
        End Sub

        Public Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
            SetMenuManagerCore(Controls, menuManager)
            _menuManager = menuManager
        End Sub

        Private Sub SetMenuManagerCore(ByVal controls As Control.ControlCollection, ByVal menuManager As IDXMenuManager)
            Dim count As Integer = controls.Count
            For i As Integer = 0 To count - 1
                Dim control As Control = controls(i)
                SetMenuManagerCore(control.Controls, menuManager)
                Dim baseEdit As BaseEdit = TryCast(control, BaseEdit)
                If baseEdit Is Nothing Then Continue For
                baseEdit.MenuManager = menuManager
            Next
        End Sub

        Private Sub btnAddRec_Click(ByVal sender As Object, ByVal e As EventArgs)
            OnRecurrenceButton()
        End Sub

        Private Sub OnRecurrenceButton()
            ShowRecurrenceForm()
        End Sub

        Private Sub ShowRecurrenceForm()
            If Not _control.SupportsRecurrence Then Return
            ' Prepare to edit appointment's recurrence.
            Dim editedAptCopy As Appointment = _controller.EditedAppointmentCopy
            Dim editedPattern As Appointment = _controller.EditedPattern
            Dim patternCopy As Appointment = _controller.PrepareToRecurrenceEdit()
            Dim dlg As AppointmentRecurrenceForm = New AppointmentRecurrenceForm(patternCopy, _control.OptionsView.FirstDayOfWeek, _controller)
            dlg.SetMenuManager(MenuManager)
            ' Required for skins support.
            dlg.LookAndFeel.ParentLookAndFeel = LookAndFeel.ParentLookAndFeel
            dlg.ShowExceptionsRemoveMsgBox = _controller.AreExceptionsPresent()
            Dim result As DialogResult = dlg.ShowDialog(Me)
            dlg.Dispose()
            If result = DialogResult.Abort Then
                _controller.RemoveRecurrence()
            ElseIf result = DialogResult.OK Then
                _controller.ApplyRecurrence(patternCopy)
                If _controller.EditedAppointmentCopy IsNot editedAptCopy Then UpdateForm()
            End If

            UpdateIntervalControls()
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Required to check appointment's conflicts.
            If Not _controller.IsConflictResolved() Then Return
            _controller.Subject = txSubject.Text
            _controller.SetStatus(edStatus.AppointmentStatus)
            _controller.SetLabel(edLabel.AppointmentLabel)
            _controller.AllDay = _checkAllDay.Checked
            _controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            _controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay
            _controller.CustomName = txCustomName.Text
            _controller.CustomStatus = txCustomStatus.Text
            ' Save all changes made to the appointment edited in a form.
            _controller.ApplyChanges()
        End Sub

        Private Sub UpdateForm()
            SuspendUpdate()
            Try
                txSubject.Text = _controller.Subject
                edStatus.AppointmentStatus = Appointments.Statuses.GetById(_controller.StatusKey)
                edLabel.AppointmentLabel = Appointments.Labels.GetById(_controller.LabelKey)
                dtStart.DateTime = _controller.DisplayStart.Date
                dtEnd.DateTime = _controller.DisplayEnd.Date
                timeStart.Time = Date.MinValue.AddTicks(_controller.Start.TimeOfDay.Ticks)
                timeEnd.Time = Date.MinValue.AddTicks(_controller.End.TimeOfDay.Ticks)
                _checkAllDay.Checked = _controller.AllDay
                edStatus.Storage = _control.DataStorage
                edLabel.Storage = _control.DataStorage
                txCustomName.Text = _controller.CustomName
                txCustomStatus.Text = _controller.CustomStatus
            Finally
                ResumeUpdate()
            End Try

            UpdateIntervalControls()
        End Sub

        Private Sub MyAppointmentEditForm_Activated(ByVal sender As Object, ByVal e As EventArgs)
            ' Required to show the recurrence form.
            If _openRecurrenceForm Then
                _openRecurrenceForm = False
                OnRecurrenceButton()
            End If
        End Sub

        Private Sub dtStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsUpdateSuspended Then _controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            UpdateIntervalControls()
        End Sub

        Protected Overridable Sub UpdateIntervalControls()
            If IsUpdateSuspended Then Return
            SuspendUpdate()
            Try
                dtStart.EditValue = _controller.DisplayStart.Date
                dtEnd.EditValue = _controller.DisplayEnd.Date
                timeStart.EditValue = _controller.DisplayStart.TimeOfDay
                timeEnd.EditValue = _controller.DisplayEnd.TimeOfDay
                Dim editedAptCopy As Appointment = _controller.EditedAppointmentCopy
                Dim showControls As Boolean = IsNewAppointment OrElse Not editedAptCopy.Type.Equals(AppointmentType.Pattern)
                dtStart.Enabled = showControls
                dtEnd.Enabled = showControls
                Dim enableTime As Boolean = showControls AndAlso Not _controller.AllDay
                timeStart.Visible = enableTime
                timeStart.Enabled = enableTime
                timeEnd.Visible = enableTime
                timeEnd.Enabled = enableTime
                _checkAllDay.Enabled = showControls
            Finally
                ResumeUpdate()
            End Try
        End Sub

        Private Sub timeStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsUpdateSuspended Then _controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            UpdateIntervalControls()
        End Sub

        Private Sub timeEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsUpdateSuspended Then Return
            If IsIntervalValid() Then
                _controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay
            Else
                timeEnd.EditValue = _controller.End.TimeOfDay
            End If
        End Sub

        Private Sub dtEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If IsUpdateSuspended Then Return
            If IsIntervalValid() Then
                _controller.DisplayEnd = dtEnd.DateTime + timeEnd.Time.TimeOfDay
            Else
                dtEnd.EditValue = _controller.DisplayEnd.Date
            End If
        End Sub

        Private Function IsIntervalValid() As Boolean
            Dim start As Date = dtStart.DateTime + timeStart.Time.TimeOfDay
            Dim [end] As Date = dtEnd.DateTime + timeEnd.Time.TimeOfDay
            Return [end] >= start
        End Function

        Private Sub checkAllDay_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            _controller.AllDay = _checkAllDay.Checked
            If Not IsUpdateSuspended Then UpdateAppointmentStatus()
            UpdateIntervalControls()
        End Sub

        Private Sub UpdateAppointmentStatus()
            Dim currentStatus As IAppointmentStatus = edStatus.AppointmentStatus
            Dim newStatus As IAppointmentStatus = _controller.UpdateStatus(currentStatus)
            If newStatus IsNot currentStatus Then edStatus.AppointmentStatus = newStatus
        End Sub
    End Class

    Public Class MyAppointmentFormController
        Inherits AppointmentFormController

        Public Property CustomName As String
            Get
                Return CStr(EditedAppointmentCopy.CustomFields("CustomName"))
            End Get

            Set(ByVal value As String)
                EditedAppointmentCopy.CustomFields("CustomName") = value
            End Set
        End Property

        Public Property CustomStatus As String
            Get
                Return CStr(EditedAppointmentCopy.CustomFields("CustomStatus"))
            End Get

            Set(ByVal value As String)
                EditedAppointmentCopy.CustomFields("CustomStatus") = value
            End Set
        End Property

        Private Property SourceCustomName As String
            Get
                Return CStr(SourceAppointment.CustomFields("CustomName"))
            End Get

            Set(ByVal value As String)
                SourceAppointment.CustomFields("CustomName") = value
            End Set
        End Property

        Private Property SourceCustomStatus As String
            Get
                Return CStr(SourceAppointment.CustomFields("CustomStatus"))
            End Get

            Set(ByVal value As String)
                SourceAppointment.CustomFields("CustomStatus") = value
            End Set
        End Property

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
        End Sub

        Public Overrides Function IsAppointmentChanged() As Boolean
            If MyBase.IsAppointmentChanged() Then Return True
            Return Not Equals(SourceCustomName, CustomName) OrElse Not Equals(SourceCustomStatus, CustomStatus)
        End Function

        Protected Overrides Sub ApplyCustomFieldsValues()
            SourceCustomName = CustomName
            SourceCustomStatus = CustomStatus
        End Sub
    End Class
End Namespace
