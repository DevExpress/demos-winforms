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
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Native
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Printing
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler.Commands
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System.Linq
Imports DevExpress.LookAndFeel

Namespace DevExpress.XtraScheduler.Demos

    ''' <summary>
    ''' Summary description for AppointmentRibbonForm.
    ''' </summary>
    Public Partial Class OutlookAppointmentForm
        Inherits RibbonForm
        Implements IDXManagerPopupMenu

        Private _OpenRecurrenceForm As Boolean

        Private _recurringIcon As Icon

        Private _normalIcon As Icon

        Private ReadOnly _controller As MyAppointmentFormController

        Private _menuManager As IDXMenuManager

        Private _suppressCancelCore As Boolean

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
            Me.OpenRecurrenceForm = openRecurrenceForm
            _controller = CreateController(control, apt)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            SetupPredefinedConstraints()
            LoadIcons()
            Me.Control = control
            Storage = control.DataStorage
            riAppointmentResource.SchedulerControl = control
            riAppointmentResource.Storage = Storage
            riAppointmentStatus.Storage = Storage
            riAppointmentLabel.Storage = Storage
            BindControllerToControls()
            LookAndFeel.ParentLookAndFeel = control.LookAndFeel
            _suppressCancelCore = False
            Call New LabelsSubMenuController(pmCategorize, _controller).PopulateFrom(control.DataStorage.Appointments.Labels)
        End Sub

        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MenuManager As IDXMenuManager
            Get
                Return _menuManager
            End Get

            Private Set(ByVal value As IDXMenuManager)
                _menuManager = value
            End Set
        End Property

        Protected Friend ReadOnly Property Controller As MyAppointmentFormController
            Get
                Return _controller
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property Control As SchedulerControl

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property Storage As ISchedulerStorage

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

        <DefaultValue(False)>
        Protected Friend Property OpenRecurrenceForm As Boolean
            Get
                Return _OpenRecurrenceForm
            End Get

            Private Set(ByVal value As Boolean)
                _OpenRecurrenceForm = value
            End Set
        End Property

        <DXDescription("DevExpress.XtraScheduler.UI.AppointmentRibbonForm,ReadOnly")>
        <DXCategory(CategoryName.Behavior)>
        <DefaultValue(False)>
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

        Public Overridable Sub LoadFormData(ByVal appointment As Appointment)
            barStatus.Enabled = Not IsIntersectWithRegion(appointment.Start, appointment.End)
        End Sub

        Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
            Return True
        End Function

        Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
            Return False
        End Function

        Public Overridable Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
            Call MenuManagerUtils.SetMenuManager(Controls, menuManager)
            _menuManager = menuManager
        End Sub

        Protected Friend Overridable Sub SetupPredefinedConstraints()
            tbProgress.Properties.Minimum = AppointmentProcessValues.Min
            tbProgress.Properties.Maximum = AppointmentProcessValues.Max
            tbProgress.Properties.SmallChange = AppointmentProcessValues.Step
        End Sub

        Protected Overridable Sub BindControllerToControls()
            DataBindings.Add("Text", Controller, "Caption")
            BindControllerToIcon()
            BindProperties(tbSubject, "Text", "Subject")
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
            BindProperties(chkAllDay, "Checked", "AllDay")
            BindProperties(chkAllDay, "Enabled", "IsDateTimeEditable")
            BindProperties(barLabel, "EditValue", "Label")
            BindProperties(barStatus, "EditValue", "Status")
            BindBoolToVisibility(barReminder, "Visibility", "ReminderVisible")
            BindProperties(barReminder, "Editvalue", "ReminderTimeBeforeStart")
            BindProperties(tbProgress, "Value", "PercentComplete")
            BindProperties(lblPercentCompleteValue, "Text", "PercentComplete", New ConvertEventHandler(AddressOf ObjectToStringConverter))
            tablePanel1.Rows(6).Visible = Controller.ShouldEditTaskProgress
            BindProperties(btnDelete, "Enabled", "CanDeleteAppointment")
            BindBoolToVisibility(btnRecurrence, "Visibility", "ShouldShowRecurrenceButton")
            BindProperties(btnRecurrence, "Down", "IsRecurrentAppointment")
            BindProperties(lblResource, "Enabled", "CanEditResource")
            BindProperties(edtResources, "ResourceIds", "ResourceIds")
            BindProperties(edtResources, "Visible", "ResourceSharing")
            BindProperties(edtResources, "Enabled", "CanEditResource")
            BindProperties(edtResource, "ResourceId", "ResourceId")
            BindProperties(edtResource, "Enabled", "CanEditResource")
            BindToBoolPropertyAndInvert(edtResource, "Visible", "ResourceSharing")
            BindToBoolPropertyAndInvert(ribbonControl1, "Enabled", "ReadOnly")
            BindProperties(edtTimeZone, "Visible", "TimeZoneVisible")
            BindProperties(edtTimeZone, "EditValue", "TimeZoneId")
            BindProperties(edtTimeZone, "Enabled", "TimeZoneEnabled")
            BindBoolToVisibility(btnTimeZones, "Visibility", "TimeZonesEnabled")
            BindProperties(btnTimeZones, "Down", "TimeZoneVisible")
            BindProperties(btnIsPrivate, "Down", "IsPrivate")
            BindProperties(btnLowImportance, "Down", "IsLowPriority")
            BindProperties(btnHighImportance, "Down", "IsHighPriority")
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

        Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As MyAppointmentFormController
            Return New MyAppointmentFormController(control, apt)
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
            AddHandler edtStartDate.Validating, New CancelEventHandler(AddressOf OnEdtStartDateValidating)
            AddHandler edtStartDate.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtStartDateInvalidValue)
            AddHandler edtStartTime.Validating, New CancelEventHandler(AddressOf OnEdtStartTimeValidating)
            AddHandler edtStartTime.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtStartTimeInvalidValue)
        End Sub

        Protected Friend Overridable Sub UnsubscribeControlsEvents()
            RemoveHandler edtEndDate.Validating, New CancelEventHandler(AddressOf OnEdtEndDateValidating)
            RemoveHandler edtEndDate.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndDateInvalidValue)
            RemoveHandler edtEndTime.Validating, New CancelEventHandler(AddressOf OnEdtEndTimeValidating)
            RemoveHandler edtEndTime.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtEndTimeInvalidValue)
            RemoveHandler riDuration.Validating, New CancelEventHandler(AddressOf OnCbReminderValidating)
            RemoveHandler edtStartDate.Validating, New CancelEventHandler(AddressOf OnEdtStartDateValidating)
            RemoveHandler edtStartDate.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtStartDateInvalidValue)
            RemoveHandler edtStartTime.Validating, New CancelEventHandler(AddressOf OnEdtStartTimeValidating)
            RemoveHandler edtStartTime.InvalidValue, New InvalidValueExceptionEventHandler(AddressOf OnEdtStartTimeInvalidValue)
        End Sub

        Protected Friend Overridable Sub OnEdtStartTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End Sub

        Protected Friend Overridable Sub OnEdtStartTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
        End Sub

        Protected Friend Overridable Sub OnEdtStartDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
        End Sub

        Protected Friend Overridable Sub OnEdtStartDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
        End Sub

        Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then edtEndDate.DataBindings("EditValue").WriteValue()
        End Sub

        Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            If Not AppointmentModificationControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) Then
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
            Else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
            End If
        End Sub

        Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then edtEndTime.DataBindings("EditValue").WriteValue()
        End Sub

        Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            If Not AppointmentModificationControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) Then
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
            Else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval)
            End If
        End Sub

        Protected Friend Overridable Function IsValidInterval() As Boolean
            Return AppointmentModificationControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) AndAlso Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
        End Function

        Protected Friend Overridable Sub OnOkButton()
            Save(True)
        End Sub

        Protected Overridable Sub OnSaveButton()
            Save(False)
        End Sub

        Private Sub Save(ByVal closeAfterSave As Boolean)
            If Not ValidateDateAndTime() Then Return
            If Not SaveFormData(Controller.EditedAppointmentCopy) Then Return
            If Not Controller.IsConflictResolved() Then
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If Not Controller.IsTimeValid() Then
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidAppointmentTime), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_InvalidAppointmentTime), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            If IsAppointmentChanged(Controller.EditedAppointmentCopy) OrElse Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment Then Controller.ApplyChanges()
            If closeAfterSave Then
                _suppressCancelCore = True
                DialogResult = DialogResult.OK
            End If
        End Sub

        Private Function ValidateDateAndTime() As Boolean
            edtEndDate.DoValidate()
            edtEndTime.DoValidate()
            edtStartDate.DoValidate()
            edtStartTime.DoValidate()
            Return String.IsNullOrEmpty(edtEndTime.ErrorText) AndAlso String.IsNullOrEmpty(edtEndDate.ErrorText) AndAlso String.IsNullOrEmpty(edtStartDate.ErrorText) AndAlso String.IsNullOrEmpty(edtStartTime.ErrorText)
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
            Dim exporter As iCalendarExporter = New iCalendarExporter(Storage, aptsToExport)
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
            Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
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
            If DialogResult <> DialogResult.Abort AndAlso Controller IsNot Nothing AndAlso Controller.IsAppointmentChanged() AndAlso Not _suppressCancelCore Then
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

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            If OpenRecurrenceForm Then
                OpenRecurrenceForm = False
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
                _suppressCancelCore = True
                Dim command As OpenNextAppointmentCommand = New OpenNextAppointmentCommand(Control)
                command.Execute()
                Close()
            End If
        End Sub

        Protected Friend Overridable Sub OnPreviousButton()
            If CancelCore() Then
                _suppressCancelCore = True
                Dim command As OpenPrevAppointmentCommand = New OpenPrevAppointmentCommand(Control)
                command.Execute()
                Close()
            End If
        End Sub

        Protected Friend Overridable Sub OnTimeZonesButton()
            Controller.TimeZoneVisible = Not Controller.TimeZoneVisible
        End Sub

        Protected Overridable Sub OnApplicationButtonClick()
            dvInfo.Document = Control.GetPrintPreviewDocument(New RibbonFormPreviewMemoPrintStyle(Controller.EditedAppointmentCopy))
            dvInfo.ExecCommand(XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
        End Sub

        Protected Overridable Sub OnPrintButton()
            dvInfo.ExecCommand(XtraPrinting.PrintingSystemCommand.PrintDirect)
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

        Private Sub bvbSave_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            OnSaveButton()
        End Sub

        Private Sub bvbSaveAs_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            OnSaveAsButton()
        End Sub

        Private Sub bvbClose_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            OnCloseButton()
        End Sub

        Private Sub btnSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            OnSaveButton()
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            e.Cancel = Not CancelCore()
            MyBase.OnFormClosing(e)
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

        Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
            OnPrintButton()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If

                If LookAndFeel IsNot Nothing Then LookAndFeel.ParentLookAndFeel = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub OnBtnIsPrivateItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Controller.IsPrivate = btnIsPrivate.Down
        End Sub

        Private Sub OnBtnHightImportanceItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Controller.IsHighPriority = btnHighImportance.Down
        End Sub

        Private Sub OnBtnLowImportanceItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Controller.IsLowPriority = btnLowImportance.Down
        End Sub

        Private Class LabelsSubMenuController

            Private popupMenu As PopupMenu

            Private controller As MyAppointmentFormController

            Public Sub New(ByVal popupMenu As PopupMenu, ByVal controller As MyAppointmentFormController)
                Me.popupMenu = popupMenu
                Me.controller = controller
            End Sub

            Public Sub PopulateFrom(ByVal labels As IAppointmentLabelStorage)
                For Each label As IAppointmentLabel In labels
                    Dim item As LabelBarItem = New LabelBarItem(label, controller.Control.LookAndFeel)
                    popupMenu.AddItem(item)
                    item.Checked = controller.LabelKey.Equals(item.Label.Id)
                    AddHandler item.ItemClick, AddressOf OnLabelBarItemClicker
                Next
            End Sub

            Private Sub OnLabelBarItemClicker(ByVal sender As Object, ByVal e As ItemClickEventArgs)
                Dim item As LabelBarItem = CType(e.Item, LabelBarItem)
                controller.LabelKey = item.Label.Id
                UpdatePopupMenu()
            End Sub

            Private Sub UpdatePopupMenu()
                For Each barItemLink As BarCheckItemLink In popupMenu.ItemLinks
                    Dim item As LabelBarItem = CType(barItemLink.Item, LabelBarItem)
                    item.Checked = controller.LabelKey.Equals(item.Label.Id)
                Next
            End Sub
        End Class
    End Class

    Public Class MyAppointmentFormController
        Inherits AppointmentFormController

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
        End Sub

        Public Property IsPrivate As Boolean
            Get
                Return EditedAppointmentCopy.GetIsPrivate()
            End Get

            Set(ByVal value As Boolean)
                EditedAppointmentCopy.SetIsPrivate(value)
            End Set
        End Property

        Public Property Priority As EventPriority
            Get
                Return EditedAppointmentCopy.GetPriority()
            End Get

            Set(ByVal value As EventPriority)
                EditedAppointmentCopy.SetPriority(value)
            End Set
        End Property

        Public Property IsHighPriority As Boolean
            Get
                Return EditedAppointmentCopy.GetPriority() = EventPriority.Important
            End Get

            Set(ByVal value As Boolean)
                If IsHighPriority = value Then Return
                EditedAppointmentCopy.SetPriority(If(value, EventPriority.Important, EventPriority.None))
                NotifyPropertyChanged("IsHighPriority")
                NotifyPropertyChanged("IsLowPriority")
            End Set
        End Property

        Public Property IsLowPriority As Boolean
            Get
                Return EditedAppointmentCopy.GetPriority() = EventPriority.NotImportant
            End Get

            Set(ByVal value As Boolean)
                If IsLowPriority = value Then Return
                EditedAppointmentCopy.SetPriority(If(value, EventPriority.NotImportant, EventPriority.None))
                NotifyPropertyChanged("IsHighPriority")
                NotifyPropertyChanged("IsLowPriority")
            End Set
        End Property

        Public Function GetLocations() As List(Of String)
            Return SchedulerDataHelper.GetLocations(Control).[Select](Function(x) x.Caption).ToList()
        End Function

        Public Overrides Sub ApplyChanges()
            If IsAppointmentChanged() Then SchedulerDataHelper.AddLocation(Control, Location)
            MyBase.ApplyChanges()
        End Sub

        Public Overrides Function IsAppointmentChanged() As Boolean
            Dim isAppointmentWasChanged As Boolean = MyBase.IsAppointmentChanged()
            If IsPrivate <> SourceAppointment.GetIsPrivate() Then isAppointmentWasChanged = True
            If Priority <> SourceAppointment.GetPriority() Then isAppointmentWasChanged = True
            Return isAppointmentWasChanged
        End Function

        Public Overloads ReadOnly Property Control As SchedulerControl
            Get
                Return MyBase.Control
            End Get
        End Property
    End Class

    Public Class LabelBarItem
        Inherits BarCheckItem

        Private _Label As IAppointmentLabel

        Private image As Image

        Private largeImage As Image

        Public Sub New(ByVal label As IAppointmentLabel, ByVal lookAndFeel As UserLookAndFeel)
            Dim color As Color = label.GetColor()
            Dim appointmentLabel As AppointmentLabel = Nothing
            If CSharpImpl.__Assign(appointmentLabel, TryCast(label, AppointmentLabel)) IsNot Nothing AndAlso lookAndFeel IsNot Nothing AndAlso appointmentLabel.ColorId <> SchedulerColorId.Nothing Then
                color = AppointmentLabel.GetDefaultColorByStringId(appointmentLabel.ColorId, lookAndFeel)
                Dim colorId As SchedulerColorId = appointmentLabel.ColorId
                If color = Color.Empty Then
                    color = label.GetColor()
                End If
            End If

            image = CreateBitmap(color, 16, 16)
            largeImage = CreateBitmap(color, 32, 32)
            Caption = label.DisplayName
            Me.Label = label
        End Sub

        Friend Shared Function CreateBitmap(ByVal color As Color, ByVal width As Integer, ByVal height As Integer) As Bitmap
            Dim rectangle As Rectangle = New Rectangle(0, 0, width, height)
            Dim bitmap As Bitmap = New Bitmap(rectangle.Width, rectangle.Height)
            Using brush As Brush = New SolidBrush(color)
                Using graphics As Graphics = Graphics.FromImage(bitmap)
                    If brush IsNot Nothing Then
                        graphics.FillRectangle(brush, rectangle)
                    End If

                    graphics.FillRectangle(Brushes.Black, RectUtils.GetTopSideRect(rectangle, 1))
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetLeftSideRect(rectangle, 1))
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetRightSideRect(rectangle, 1))
                    graphics.FillRectangle(Brushes.Black, RectUtils.GetBottomSideRect(rectangle, 1))
                End Using
            End Using

            Return bitmap
        End Function

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Label As IAppointmentLabel
            Get
                Return _Label
            End Get

            Private Set(ByVal value As IAppointmentLabel)
                _Label = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property LargeGlyph As Image
            Get
                Return largeImage
            End Get

            Set(ByVal value As Image)
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides Property Glyph As Image
            Get
                Return image
            End Get

            Set(ByVal value As Image)
            End Set
        End Property

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
