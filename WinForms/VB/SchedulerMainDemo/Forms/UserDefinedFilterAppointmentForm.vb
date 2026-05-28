Imports System
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos.Forms

    Public Partial Class UserDefinedFilterAppointmentForm
        Inherits AppointmentForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
            MyBase.New(control, apt, openRecurrenceForm)
            InitializeComponent()
            BindToController()
        End Sub

        Protected Friend Overloads ReadOnly Property Controller As UserDefinedFilterAppointmentFormController
            Get
                Return CType(MyBase.Controller, UserDefinedFilterAppointmentFormController)
            End Get
        End Property

        Protected Overrides Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
            Return New UserDefinedFilterAppointmentFormController(control, apt)
        End Function

        Private Sub BindToController()
            edtPrice.DataBindings.Add("EditValue", Controller, "Price")
            edtPrice.DataBindings.Add("ReadOnly", Controller, "ReadOnly")
        End Sub

        Public Overrides Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
            If MyBase.IsAppointmentChanged(appointment) Then Return True
            Return Controller.IsPriceChanged
        End Function
    End Class

    Public Class UserDefinedFilterAppointmentFormController
        Inherits AppointmentFormController

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
        End Sub

        Public Property Price As Decimal
            Get
                Return ObtainPrice(EditedAppointmentCopy)
            End Get

            Set(ByVal value As Decimal)
                EditedAppointmentCopy.CustomFields("CustomFieldPrice") = value
            End Set
        End Property

        Public ReadOnly Property IsPriceChanged As Boolean
            Get
                Return Price <> ObtainPrice(SourceAppointment)
            End Get
        End Property

        Protected Overrides Sub ApplyCustomFieldsValues()
            MyBase.ApplyCustomFieldsValues()
            SourceAppointment.CustomFields("CustomFieldPrice") = Price
        End Sub

        Private Function ObtainPrice(ByVal apt As Appointment) As Decimal
            Dim value As Object = apt.CustomFields("CustomFieldPrice")
            Try
                Return Convert.ToDecimal(value)
            Catch
                Return 0
            End Try
        End Function
    End Class
End Namespace
