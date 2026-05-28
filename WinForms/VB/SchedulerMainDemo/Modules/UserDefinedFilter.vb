Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Demos.Forms
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class UserDefinedFilterModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub FilterControlModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            AddCustomFieldsMapping()
            FillData(schedulerControl, schedulerStorage1)
            ' load filter criteria string from scheduler storage
            ResetFilterControl()
            AddHandler filterControlForAppointments.FilterChanged, New FilterChangedEventHandler(AddressOf filterControlForAppointments_FilterChanged)
        End Sub

        Private Sub AddCustomFieldsMapping()
            Dim customPriceMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping("CustomFieldPrice", "Price", FieldValueType.Decimal)
            schedulerStorage1.Appointments.CustomFieldMappings.Add(customPriceMapping)
        End Sub

        Private Sub ResetFilterControl()
            filterControlForAppointments.FilterString = schedulerStorage1.Appointments.Filter
            Dim temp As String = filterControlForAppointments.FilterString
            schedulerStorage1.Appointments.Filter = String.Empty
            schedulerStorage1.Appointments.Filter = temp
            filterControlForAppointments.MenuManager = schedulerControl.MenuManager
        End Sub

        Private Sub OnBtnApplyClick(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DataStorage.Appointments.Filter = filterControlForAppointments.FilterString
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim controller As ToolTipController = TryCast(sender, ToolTipController)
            Dim aptViewInfo As AppointmentViewInfo = TryCast(controller.ActiveObject, AppointmentViewInfo)
            If aptViewInfo Is Nothing Then Return
            Dim apt As Appointment = aptViewInfo.Appointment
            If apt Is Nothing Then Return
            e.IconType = ToolTipIconType.Information
            e.Title = e.ToolTip
            e.ToolTip = GetCustomDescription(apt)
        End Sub

        Private Function GetCustomDescription(ByVal apt As Appointment) As String
            Dim description As String = apt.Description
            If apt.IsRecurring Then description = String.Format("{0}" & Microsoft.VisualBasic.Constants.vbCrLf & "Occurs on {1}", description, RecurrenceInfo.GetDescription(apt, schedulerControl.FirstDayOfWeek))
            Dim price As String = String.Format("{0}Price: {1}$", Environment.NewLine, apt.CustomFields("CustomFieldPrice"))
            Return description & price
        End Function

        Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            e.Handled = True
            Dim form As UserDefinedFilterAppointmentForm = New UserDefinedFilterAppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
            form.ShowDialog(Me)
        End Sub

        Private Sub schedulerControl_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs)
            e.Appointment.CustomFields("CustomFieldPrice") = New [Decimal](15)
        End Sub

        Private Sub filterControlForAppointments_FilterChanged(ByVal sender As Object, ByVal e As FilterChangedEventArgs)
            If e.Action = FilterChangedAction.FieldNameChange Then
                Dim node As ClauseNode = TryCast(e.CurrentNode, ClauseNode)
                If node Is Nothing Then Return
                Dim count As Integer = node.AdditionalOperands.Count
                For i As Integer = 0 To count - 1
                    node.AdditionalOperands(i) = New OperandValue(Nothing)
                Next
            End If
        End Sub
    End Class
End Namespace
