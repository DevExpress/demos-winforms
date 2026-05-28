Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors

Namespace DevExpress.VideoRent.Win.Forms

	Partial Public Class RentalDetailsForm
		Inherits XtraForm
		Private control As SchedulerControl
        Private apt As Appointment
		Private controller As RentAppointmentFormController
		Private suspendUpdateCount As Integer
		Private layoutManager As FormLayoutManager = Nothing

		Public Sub New()
		End Sub
        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal layoutManager As FormLayoutManager)
            Me.layoutManager = layoutManager
            If Object.Equals(control, Nothing) Then
                Dim TempArgumentNullException As ArgumentNullException = New ArgumentNullException("control")
            End If
            If Object.Equals(apt, Nothing) Then
                Dim TempArgumentNullException As ArgumentNullException = New ArgumentNullException("apt")
            End If
            Me.apt = apt
            Me.control = control
            Me.controller = New RentAppointmentFormController(control, apt)

            InitializeComponent()
            InitData()
            UpdateForm()
        End Sub

		Private Sub InitData()
			EditorHelper.CreateMovieItemFormatImageComboBox(txtFormat.Properties, Nothing)
		End Sub
        Protected ReadOnly Property Appointments() As IAppointmentStorageBase
            Get
                Return control.DataStorage.Appointments
            End Get
        End Property
		Protected Friend ReadOnly Property IsNewAppointment() As Boolean
			Get
                If Not Object.Equals(controller, Nothing) Then
                    Return (controller.IsNewAppointment)
                Else
                    Return (True)
                End If
			End Get
		End Property
		Protected ReadOnly Property IsUpdateSuspended() As Boolean
			Get
				Return suspendUpdateCount > 0
			End Get
		End Property

		Protected Sub SuspendUpdate()
			suspendUpdateCount += 1
		End Sub
		Protected Sub ResumeUpdate()
			If suspendUpdateCount > 0 Then
				suspendUpdateCount -= 1
			End If
		End Sub

		Protected Overridable Sub UpdateForm()
			UnsubscribeControlsEvents()
			Try
				UpdateFormCore()
			Finally
				SubscribeControlsEvents()
			End Try

		End Sub
		Protected Overridable Sub UnsubscribeControlsEvents()
		End Sub
		Protected Overridable Sub SubscribeControlsEvents()
		End Sub
		Protected Overridable Sub UpdateFormCore()
			SuspendUpdate()
			Try
				txSubject.Text = controller.Subject

				dtStart.DateTime = controller.DisplayStart.Date
				dtEnd.DateTime = controller.DisplayEnd.Date

				timeStart.Time = New DateTime(controller.DisplayStart.TimeOfDay.Ticks)
				timeEnd.Time = New DateTime(controller.DisplayEnd.TimeOfDay.Ticks)

				edtResource.SchedulerControl = control
                edtResource.Storage = control.DataStorage
                edtResource.ResourceId = controller.ResourceId

				txMovieLanguage.Text = controller.MovieLanguage
				edtDescription.Text = controller.Description


				If ((Not Object.Equals(controller.MoviePhoto, Nothing))) Then
					pePhoto.Image = controller.MoviePhoto
				Else
					pePhoto.Image = ReferenceImages.UnknownMovie
				End If
				txtFormat.EditValue = controller.MovieFormat

				txtPayment.EditValue = controller.Payment
				txtOverduePayment.EditValue = controller.OverduePayment
				chkRentOverdue.Checked = controller.IsRentOverdue

				chkActiveRental.Checked = controller.IsActiveRent
			Finally
				ResumeUpdate()
			End Try
		End Sub

		Private Sub CustomAppointmentForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			LoadFormLayout()
			If controller.IsActiveRent Then
				lciReturnedOn.Text = ConstStrings.ExpectedOn
			Else
				lciReturnedOn.Text = ConstStrings.ReturnedOn
			End If
		End Sub

		Private Sub CustomAppointmentForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			SaveFormLayout()
		End Sub
		Protected Overridable Sub LoadFormLayout()
			If Object.Equals(layoutManager, Nothing) Then
				Return
			End If
			layoutManager.RestoreFormLayout(New FormLayoutInfo(Me, lcMain))
		End Sub
		Protected Overridable Sub SaveFormLayout()
			If Object.Equals(layoutManager, Nothing) Then
				Return
			End If
			layoutManager.SaveFormLayout(New FormLayoutInfo(Me, lcMain))
		End Sub

		Private Sub dtStart_Properties_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles dtStart.Properties.QueryPopUp, dtEnd.QueryPopUp
			e.Cancel = True
		End Sub
	End Class

	Public Class RentAppointmentFormController
		Inherits AppointmentFormController
		Public ReadOnly Property Payment() As Decimal
			Get
				Return CDec(EditedAppointmentCopy.CustomFields("Payment"))
			End Get
		End Property
		Public ReadOnly Property OverduePayment() As Decimal
			Get
				Return CDec(EditedAppointmentCopy.CustomFields("OverduePayment"))
			End Get
		End Property

		Public ReadOnly Property ReceiptType() As ReceiptType
			Get
				Return CType(EditedAppointmentCopy.CustomFields("ReceiptType"), ReceiptType)
			End Get
		End Property

		Public ReadOnly Property MovieGenre() As MovieGenre
			Get
				Return CType(EditedAppointmentCopy.CustomFields("MovieGenre"), MovieGenre)
			End Get
		End Property
		Public ReadOnly Property MovieLanguage() As String
			Get
				Return CStr(EditedAppointmentCopy.CustomFields("MovieLanguage"))
			End Get
		End Property
		Public ReadOnly Property MoviePhoto() As Image
			Get
				Return TryCast(EditedAppointmentCopy.CustomFields("MoviePhoto"), Image)
			End Get
		End Property
		Public ReadOnly Property MovieFormat() As MovieItemFormat
			Get
				Return CType(EditedAppointmentCopy.CustomFields("ItemFormat"), MovieItemFormat)
			End Get
		End Property
		Public ReadOnly Property IsRentOverdue() As Boolean
			Get
				Return Not Object.Equals(EditedAppointmentCopy.CustomFields("ReceiptOverdue"), Nothing)
			End Get
		End Property
		Public ReadOnly Property IsActiveRent() As Boolean
			Get
				Return Object.Equals(EditedAppointmentCopy.CustomFields("ReturnedOn"), Nothing)
			End Get
		End Property

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
        End Sub
		Public Overrides Function IsAppointmentChanged() As Boolean
			Return False
		End Function
	End Class

End Namespace
