Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.MailClient.Win

Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class SchedulerModule
		Inherits BaseModule

		Private appointmentCategory As RibbonPageCategory = Nothing
		Private lastSelectedPage As RibbonPage = Nothing
		Public Sub New()
			InitializeComponent()
			DatabindScheduler()
			SetTopRowTime()
		End Sub

		Protected Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
				MyBase.AutoMergeRibbon = value
			End Set
		End Property

		Private Sub DatabindScheduler()
			schedulerStorage1.Resources.DataSource = DataHelper.CalendarResources
			schedulerStorage1.Appointments.DataSource = DataHelper.CalendarAppointments
		End Sub
		Friend Overrides Sub InitModule(ByVal manager As Utils.Menu.IDXMenuManager, ByVal data As Object)
			MyBase.InitModule(manager, data)
			Me.calendarControls.InitDateNavigator(Me.schedulerControl1)
			Me.calendarControls.InitResourcesTree(Me.schedulerStorage1)
		End Sub
		Private Function FindAppointmentPage(ByVal ribbonControl As RibbonControl) As RibbonPageCategory
			For Each category As RibbonPageCategory In ribbonControl.PageCategories
				If category.Name = "calendarToolsRibbonPageCategory1" Then
					Return category
				End If
			Next category
			Return Nothing
		End Function
		Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
			MyBase.ShowModule(firstShow)
			Me.appointmentCategory = FindAppointmentPage(Me.ribbonControl1)
			SubscribeSchedulerEvents()
			UpdateAppointmentCategory()
			MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(homeRibbonPage1.Name)
		End Sub
		Friend Overrides Sub HideModule()
			UnsubscribeSchedulerEvents()
			HideAppointmentCategory()
			MyBase.HideModule()
		End Sub
		Private Sub SubscribeSchedulerEvents()
			AddHandler schedulerStorage1.FilterAppointment, AddressOf schedulerStorage1_FilterAppointment
			AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsDeleted
			AddHandler schedulerStorage1.AppointmentDeleting, AddressOf schedulerStorage1_AppointmentDeleting
			AddHandler schedulerControl1.SelectionChanged, AddressOf schedulerControl1_SelectionChanged
		End Sub

		Private Sub schedulerStorage1_AppointmentDeleting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
			HideAppointmentCategory()
		End Sub
		Private Sub UnsubscribeSchedulerEvents()
			RemoveHandler schedulerStorage1.FilterAppointment, AddressOf schedulerStorage1_FilterAppointment
			RemoveHandler schedulerControl1.SelectionChanged, AddressOf schedulerControl1_SelectionChanged
			RemoveHandler schedulerStorage1.AppointmentsDeleted, AddressOf schedulerStorage1_AppointmentsDeleted
			RemoveHandler schedulerControl1.SelectionChanged, AddressOf schedulerControl1_SelectionChanged
		End Sub
		Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			If OwnerForm Is Nothing Then
				Return
			End If
			UpdateAppointmentCategory()
		End Sub
		Private Sub UpdateAppointmentCategory()
			If Me.schedulerControl1.SelectedAppointments.Count > 0 Then
				ShowAppointmentCategory()
			Else
				HideAppointmentCategory()
			End If
		End Sub
		Private Sub schedulerStorage1_FilterAppointment(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
			Dim apt As Appointment = DirectCast(e.Object, Appointment)
			If EmptyResourceId.Id.Equals(apt.ResourceId) Then
				Return
			End If
			Dim selectedIds As List(Of Integer) = Me.calendarControls.GetSelectedResourceIds()
			Dim resourceId As Integer = Convert.ToInt32(apt.ResourceId)
			e.Cancel = Not selectedIds.Contains(resourceId)
		End Sub
		Private Sub schedulerStorage1_AppointmentsDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
			HideAppointmentCategory()
		End Sub
		Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs)
			Dim selectedIds As List(Of Integer) = Me.calendarControls.GetSelectedResourceIds()
			If selectedIds.Count > 0 Then
				e.Appointment.ResourceId = selectedIds(0)
			End If
		End Sub
		Private Sub ShowAppointmentCategory()
			If Me.appointmentCategory Is Nothing Then
				Return
			End If
			If Me.lastSelectedPage Is Nothing Then
				Me.lastSelectedPage = MainRibbon.SelectedPage
			End If
			Me.appointmentCategory.Visible = True
			MainRibbon.SelectedPage = GetFirstVisiblePage(Me.appointmentCategory)
		End Sub
		Private Sub HideAppointmentCategory()
			If Me.appointmentCategory Is Nothing Then
				Return
			End If
			Me.appointmentCategory.Visible = False
			If Me.lastSelectedPage IsNot Nothing Then
				MainRibbon.SelectedPage = Me.lastSelectedPage
				Me.lastSelectedPage = Nothing
			End If
		End Sub
		Private Function GetFirstVisiblePage(ByVal ribbonPageCategory As RibbonPageCategory) As RibbonPage
			For Each page As RibbonPage In ribbonPageCategory.Pages
				If page.Visible Then
					Return page
				End If
			Next page
			Return Nothing
		End Function
		Private Sub SetTopRowTime()
			Me.schedulerControl1.DayView.TopRowTime = TimeSpan.FromHours(8)
		End Sub
	End Class
End Namespace
