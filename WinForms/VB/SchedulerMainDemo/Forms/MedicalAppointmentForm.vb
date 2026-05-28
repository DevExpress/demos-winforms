Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Internal
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Native
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Printing
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Demos
#If Not NET
Imports System.Data.Entity

#Else
using Microsoft.EntityFrameworkCore;
#End If
Namespace Modules

    ''' <summary>
    ''' Summary description for AppointmentRibbonForm.
    ''' </summary>
    Public Partial Class MedicalAppointmentForm
        Inherits Ribbon.RibbonForm
        Implements IDXManagerPopupMenu

#Region "Fields"
        Private _openRecurrenceForm As Boolean

        Private ReadOnly _storage As ISchedulerStorage

        Private ReadOnly _control As SchedulerControl

        Private _recurringIcon As Icon

        Private _normalIcon As Icon

        Private ReadOnly _controller As AppointmentFormController

        Private _menuManager As IDXMenuManager

        Private _supressCancelCore As Boolean

        Private _dataContext As MedicScheduleContext

        Private _patient As Patient

#End Region
        <EditorBrowsable(EditorBrowsableState.Never)>
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            Me.New(control, apt, False)
        End Sub

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
            Guard.ArgumentNotNull(control, "control")
            Guard.ArgumentNotNull(control.DataStorage, "control.DataStorage")
            Guard.ArgumentNotNull(apt, "apt")
            _openRecurrenceForm = openRecurrenceForm
            _controller = CreateController(control, apt)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            LoadIcons()
            _control = control
            _storage = control.DataStorage
            edtResource.SchedulerControl = control
            edtResource.Storage = _storage
            riAppointmentResource.SchedulerControl = control
            riAppointmentResource.Storage = _storage
            riAppointmentStatus.Storage = _storage
            riAppointmentLabel.Storage = _storage
            BindControllerToControls()
            AddHandler cmbPatient.EditValueChanged, AddressOf cmbPatient_EditValueChanged
            AddHandler cmbPatient.MouseDown, AddressOf cmbPatient_MouseDown
            _supressCancelCore = False
            AddHandler edtResource.EditValueChanged, AddressOf edtResource_EditValueChanged
            pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom
        End Sub

        Private Sub edtResource_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RefreshMedic(Storage.Resources.GetResourceById(edtResource.EditValue))
        End Sub

#Region "Properties"
        Public Property MenuManager As IDXMenuManager
            Get
                Return _menuManager
            End Get

            Private Set(ByVal value As IDXMenuManager)
                _menuManager = value
            End Set
        End Property

        Protected Friend ReadOnly Property Controller As AppointmentFormController
            Get
                Return _controller
            End Get
        End Property

        Protected Friend ReadOnly Property SchedulerControl As SchedulerControl
            Get
                Return _control
            End Get
        End Property

        Protected Friend ReadOnly Property Storage As ISchedulerStorage
            Get
                Return _storage
            End Get
        End Property

        Protected Friend ReadOnly Property IsNewAppointment As Boolean
            Get
                Return If(_controller IsNot Nothing, _controller.IsNewAppointment, True)
            End Get
        End Property

        Protected Friend ReadOnly Property RecurringIcon As Icon
            Get
                Return _recurringIcon
            End Get
        End Property

        Protected Friend ReadOnly Property NormalIcon As Icon
            Get
                Return _normalIcon
            End Get
        End Property

        Protected Friend ReadOnly Property OpenRecurrenceForm As Boolean
            Get
                Return _openRecurrenceForm
            End Get
        End Property

        Public Property [ReadOnly] As Boolean
            Get
                Return Controller.ReadOnly
            End Get

            Set(ByVal value As Boolean)
                If Controller.ReadOnly = value Then Return
                Controller.ReadOnly = value
            End Set
        End Property

        Protected Overrides ReadOnly Property ShowMode As FormShowMode
            Get
                Return FormShowMode.AfterInitialization
            End Get
        End Property

#End Region
        Public Sub SetDataContext(ByVal dataContext As MedicScheduleContext)
            _dataContext = dataContext
        End Sub

        Public Overridable Sub LoadFormData(ByVal appointment As Appointment)
            _patient = CType(appointment.CustomFields("Patient"), Patient)
            RefreshPatient(_patient)
            If _patient IsNot Nothing Then cmbPatient.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(_patient.Name, _patient.Id))
        End Sub

        Private Sub RefreshPatient(ByVal patient As Patient)
            tbPhone.DataBindings.Clear()
            edtBirthday.DataBindings.Clear()
            cmbPatient.DataBindings.Clear()
            If patient Is Nothing Then Return
            tbPhone.DataBindings.Add(New Binding("EditValue", patient, "Phone", True, DataSourceUpdateMode.OnPropertyChanged))
            edtBirthday.DataBindings.Add(New Binding("EditValue", patient, "Birthday", True, DataSourceUpdateMode.OnPropertyChanged))
            cmbPatient.DataBindings.Add(New Binding("EditValue", patient, "Id", True, DataSourceUpdateMode.OnPropertyChanged))
        End Sub

        Private Sub RefreshMedic(ByVal resource As Resource)
            pictureEdit1.Image = Nothing
            edtPhoneMedic.Text = ""
            If resource Is Nothing Then Return
            Dim medic As Medic = TryCast(resource.GetRow(Storage), Medic)
            If medic Is Nothing Then Return
            pictureEdit1.Image = resource.GetImage()
            edtPhoneMedic.Text = medic.Phone
            lbMedic.Text = medic.Name
            Dim hospitalDepartment As HospitalDepartment = _dataContext.HospitalDepartments.Find(medic.DepartmentId)
            If hospitalDepartment Is Nothing Then Return
            lbDepartment.Text = hospitalDepartment.Name
        End Sub

        Private Sub cmbPatient_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If cmbPatient.Properties.Items.Count > 1 Then Return
            cmbPatient.Properties.Items.Clear()
            Dim patients As BindingList(Of Patient) = _dataContext.Patients.Local.ToBindingList()
            For Each patient As Patient In patients
                cmbPatient.Properties.Items.Add(New DevExpress.XtraEditors.Controls.ImageComboBoxItem(patient.Name, patient.Id))
            Next
        End Sub

        Private Sub cmbPatient_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RefreshPatient(_dataContext.Patients.Find(cmbPatient.EditValue))
        End Sub

        Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
            appointment.CustomFields("Patient") = _dataContext.Patients.Find(cmbPatient.EditValue)
            Return True
        End Function

        Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
            If _patient Is Nothing Then Return True
            If _patient.Id.Equals(cmbPatient.EditValue) Then Return False
            Return True
        End Function

        Public Overridable Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
            Call MenuManagerUtils.SetMenuManager(Controls, menuManager)
            _menuManager = menuManager
        End Sub

        Protected Overridable Sub BindControllerToControls()
            BindControllerToIcon()
            BindProperties(tbLocation, "Text", "Location")
            BindProperties(tbDescription, "Text", "Description")
            BindProperties(edtStartDate, "EditValue", "DisplayStartDate")
            BindProperties(edtStartDate, "Enabled", "IsDateTimeEditable")
            BindProperties(edtStartTime, "EditValue", "DisplayStartTime")
            BindProperties(edtStartTime, "Enabled", "IsTimeEnabled")
            BindProperties(edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
            BindProperties(edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
            BindProperties(edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
            BindProperties(edtEndTime, "Enabled", "IsTimeEnabled", DataSourceUpdateMode.Never)
            BindProperties(edtResource, "ResourceId", "ResourceId")
            BindProperties(edtResource, "Enabled", "CanEditResource")
            BindToBoolPropertyAndInvert(edtResource, "Visible", "ResourceSharing")
            BindProperties(barLabel, "EditValue", "Label")
            BindProperties(barStatus, "EditValue", "Status")
            BindBoolToVisibility(barReminder, "Visibility", "ReminderVisible")
            BindProperties(barReminder, "Editvalue", "ReminderTimeBeforeStart")
            BindProperties(btnDelete, "Enabled", "CanDeleteAppointment")
            BindBoolToVisibility(btnRecurrence, "Visibility", "ShouldShowRecurrenceButton")
            BindProperties(btnRecurrence, "Down", "IsRecurrentAppointment")
            BindToBoolPropertyAndInvert(ribbonControl1, "Enabled", "ReadOnly")
            BindBoolToVisibility(btnTimeZones, "Visibility", "TimeZonesEnabled")
            BindProperties(btnTimeZones, "Down", "TimeZoneVisible")
        End Sub

        Protected Overridable Sub BindControllerToIcon()
            Dim binding As Binding = New Binding("Icon", Controller, "AppointmentType")
            AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
            DataBindings.Add(binding)
        End Sub

        Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
            e.Value = e.Value.ToString()
        End Sub

        Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
            Dim type As AppointmentType = CType(e.Value, AppointmentType)
            If type.Equals(AppointmentType.Pattern) Then
                e.Value = RecurringIcon
            Else
                e.Value = NormalIcon
            End If
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
            BindToIsReadOnly(target, updateMode)
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
            Dim binding As Binding = New Binding(targetProperty, Controller, sourceProperty, True)
            AddHandler binding.Format, objectToStringConverter
            target.DataBindings.Add(binding)
        End Sub

        Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
            target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
            BindToIsReadOnly(target)
        End Sub

        Protected Overridable Sub BindToIsReadOnly(ByVal control As Control)
            BindToIsReadOnly(control, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Protected Overridable Sub BindToIsReadOnly(ByVal control As Control, ByVal updateMode As DataSourceUpdateMode)
            If Not(TypeOf control Is BaseEdit) OrElse control.DataBindings("ReadOnly") IsNot Nothing Then Return
            control.DataBindings.Add("ReadOnly", Controller, "ReadOnly", True, updateMode)
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
        End Sub

        Protected Overridable Sub BindProperties(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
            Dim binding As Binding = New Binding(targetProperty, Controller, sourceProperty, True)
            AddHandler binding.Format, objectToStringConverter
            target.DataBindings.Add(binding)
        End Sub

        Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
            target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
        End Sub

        Protected Overridable Sub BindBoolToVisibility(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String)
            target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, False))
        End Sub

        Protected Overridable Sub BindBoolToVisibility(ByVal target As BarItem, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal invert As Boolean)
            target.DataBindings.Add(New BoolToVisibilityBinding(targetProperty, Controller, sourceProperty, invert))
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Controller Is Nothing Then Return
            SubscribeControlsEvents()
            LoadFormData(Controller.EditedAppointmentCopy)
        End Sub

        Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
            Return New AppointmentFormController(control, apt)
        End Function

        Protected Friend Overridable Sub LoadIcons()
            Dim asm As Assembly = GetType(SchedulerControl).Assembly
            _recurringIcon = ResourceImageHelperCore.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm)
            _normalIcon = ResourceImageHelperCore.CreateIconFromResources(SchedulerIconNames.Appointment, asm)
        End Sub

        Protected Friend Overridable Sub SubscribeControlsEvents()
            AddHandler edtEndDate.Validating, New CancelEventHandler(AddressOf OnEdtEndDateValidating)
            AddHandler edtEndDate.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndDateInvalidValue)
            AddHandler edtEndTime.Validating, New CancelEventHandler(AddressOf OnEdtEndTimeValidating)
            AddHandler edtEndTime.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndTimeInvalidValue)
            AddHandler riDuration.Validating, New CancelEventHandler(AddressOf OnCbReminderValidating)
        End Sub

        Protected Friend Overridable Sub UnsubscribeControlsEvents()
            RemoveHandler edtEndDate.Validating, New CancelEventHandler(AddressOf OnEdtEndDateValidating)
            RemoveHandler edtEndDate.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndDateInvalidValue)
            RemoveHandler edtEndTime.Validating, New CancelEventHandler(AddressOf OnEdtEndTimeValidating)
            RemoveHandler edtEndTime.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndTimeInvalidValue)
            RemoveHandler riDuration.Validating, New CancelEventHandler(AddressOf OnCbReminderValidating)
        End Sub

        Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then edtEndDate.DataBindings("EditValue").WriteValue()
        End Sub

        Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        End Sub

        Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then edtEndTime.DataBindings("EditValue").WriteValue()
        End Sub

        Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        End Sub

        Protected Friend Overridable Function IsValidInterval() As Boolean
            Return AppointmentModificationControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
        End Function

        Protected Friend Overridable Sub OnOkButton()
            Save(True)
        End Sub

        Protected Overridable Sub OnSaveButton()
            Save(False)
        End Sub

        Private Sub Save(ByVal closeAfterSave As Boolean)
            If Not ValidateEndDateAndTime() Then Return
            If Not SaveFormData(Controller.EditedAppointmentCopy) Then Return
            If Not Controller.IsConflictResolved() Then
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment OrElse IsAppointmentChanged(Controller.EditedAppointmentCopy) Then Controller.ApplyChanges()
            If closeAfterSave Then
                _supressCancelCore = True
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Function ValidateEndDateAndTime() As Boolean
            edtEndDate.DoValidate()
            edtEndTime.DoValidate()
            Return String.IsNullOrEmpty(edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(edtEndDate.ErrorText)
        End Function

        Protected Overridable Sub OnSaveAsButton()
            Dim fileDialog As SaveFileDialog = New SaveFileDialog()
            fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
            fileDialog.FilterIndex = 1
            If fileDialog.ShowDialog() <> DialogResult.OK Then Return
            Try
                Using stream As Stream = fileDialog.OpenFile()
                    ExportAppointment(stream)
                End Using
            Catch
                ShowMessageBox("Error: could not export appointments", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ExportAppointment(ByVal stream As Stream)
            If stream Is Nothing Then Return
            Dim aptsToExport As AppointmentBaseCollection = New AppointmentBaseCollection()
            aptsToExport.Add(Controller.EditedAppointmentCopy)
            Dim exporter As iCalendarExporter = New iCalendarExporter(_storage, aptsToExport)
            exporter.ProductIdentifier = "-//Developer Express Inc."
            exporter.Export(stream)
        End Sub

        Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
            Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
        End Function

        Protected Friend Overridable Sub OnDeleteButton()
            If IsNewAppointment Then Return
            Controller.DeleteAppointment()
            DialogResult = DialogResult.Abort
            Close()
        End Sub

        Protected Friend Overridable Sub OnRecurrenceButton()
            If Not Controller.ShouldShowRecurrenceButton Then Return
            Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()
            Dim result As DialogResult
            Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, SchedulerControl.OptionsView.FirstDayOfWeek)
                result = ShowRecurrenceForm(form)
            End Using

            If result = DialogResult.Abort Then
                Controller.RemoveRecurrence()
            ElseIf result = DialogResult.OK Then
                Controller.ApplyRecurrence(patternCopy)
            End If

            btnRecurrence.Down = Controller.IsRecurrentAppointment
        End Sub

        Protected Overridable Sub OnCloseButton()
            Close()
        End Sub

        Private Function CancelCore() As Boolean
            Dim result As Boolean = True
            If DialogResult <> DialogResult.Abort AndAlso Controller IsNot Nothing AndAlso Controller.IsAppointmentChanged() AndAlso Not _supressCancelCore Then
                Dim saveBeforeCloseDialogResult As DialogResult = ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_SaveBeforeClose), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_SaveBeforeClose), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                If saveBeforeCloseDialogResult = DialogResult.Cancel Then
                    result = False
                ElseIf saveBeforeCloseDialogResult = DialogResult.Yes Then
                    Save(True)
                End If
            End If

            Return result
        End Function

        Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
            Return FormTouchUIAdapter.ShowDialog(form, Me)
        End Function

        Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek) As Form
            Dim form As AppointmentRecurrenceForm = New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
            form.SetMenuManager(MenuManager)
            form.LookAndFeel.ParentLookAndFeel = LookAndFeel
            form.ShowExceptionsRemoveMsgBox = _controller.AreExceptionsPresent()
            Return form
        End Function

        Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs)
            If _openRecurrenceForm Then
                _openRecurrenceForm = False
                OnRecurrenceButton()
            End If
        End Sub

        Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim span As TimeSpan = CType(barReminder.EditValue, TimeSpan)
            e.Cancel = span.Ticks < 0 AndAlso span <> TimeSpan.MinValue
            If Not e.Cancel Then barReminder.DataBindings("EditValue").WriteValue()
        End Sub

        Protected Friend Overridable Sub OnNextButton()
            If CancelCore() Then
                _supressCancelCore = True
                Dim command As OpenNextAppointmentCommand = New OpenNextAppointmentCommand(SchedulerControl)
                command.Execute()
                Close()
            End If
        End Sub

        Protected Friend Overridable Sub OnPreviousButton()
            If CancelCore() Then
                _supressCancelCore = True
                Dim command As OpenPrevAppointmentCommand = New OpenPrevAppointmentCommand(SchedulerControl)
                command.Execute()
                Close()
            End If
        End Sub

        Protected Friend Overridable Sub OnTimeZonesButton()
            Controller.TimeZoneVisible = Not Controller.TimeZoneVisible
        End Sub

        Protected Overridable Sub OnApplicationButtonClick()
            dvInfo.Document = SchedulerControl.GetPrintPreviewDocument(New MemoPrintStyle())
            dvInfo.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
        End Sub

        Private Sub btnSaveAndClose_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnOkButton()
        End Sub

        Private Sub barButtonDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnDeleteButton()
        End Sub

        Private Sub barRecurrence_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnRecurrenceButton()
        End Sub

        Private Sub bvbSave_ItemClick(ByVal sender As Object, ByVal e As Ribbon.BackstageViewItemEventArgs)
            OnSaveButton()
        End Sub

        Private Sub bvbSaveAs_ItemClick(ByVal sender As Object, ByVal e As Ribbon.BackstageViewItemEventArgs)
            OnSaveAsButton()
        End Sub

        Private Sub bvbClose_ItemClick(ByVal sender As Object, ByVal e As Ribbon.BackstageViewItemEventArgs)
            OnCloseButton()
        End Sub

        Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnSaveButton()
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            e.Cancel = Not CancelCore()
            MyBase.OnClosing(e)
        End Sub

        Private Sub btnNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnNextButton()
        End Sub

        Private Sub btnPrevious_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnPreviousButton()
        End Sub

        Private Sub btnTimeZones_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnTimeZonesButton()
        End Sub

        Private Sub ribbonControl1_ApplicationButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            OnApplicationButtonClick()
        End Sub

        Private Sub OutlookAppointmentForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
