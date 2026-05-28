Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.MailClient.Win.Controls
Imports System.IO
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraEditors

Namespace DevExpress.MailClient.Win
    Partial Public Class Calendar
        Inherits BaseModule

        Private ribbon As RibbonControl
        Private calendarControls As ucCalendar
        Private appointmentCategory As RibbonPageCategory = Nothing
        Private lastSelectedPage As RibbonPage = Nothing
        Public Overrides ReadOnly Property ModuleName() As String
            Get
                Return My.Resources.CalendarName
            End Get
        End Property
        Public Sub New()
            InitializeComponent()

            DatabindScheduler()
            schedulerControl1.Start = New Date(2011, 04, 04)
        End Sub
        Public Overrides ReadOnly Property PrintableComponent() As DevExpress.XtraPrinting.IPrintable
            Get
                Return schedulerControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property SaveCalendarVisible() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Sub DatabindScheduler()
            schedulerStorage1.Resources.DataSource = DataHelper.CalendarResources
            schedulerStorage1.Appointments.DataSource = DataHelper.CalendarAppointments
        End Sub
        Friend Overrides Sub InitModule(ByVal manager As DevExpress.Utils.Menu.IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            schedulerControl1.MenuManager = manager
            Me.ribbon = TryCast(manager, RibbonControl)
            Me.appointmentCategory = FindAppointmentPage(Me.ribbon)

            If calendarControls Is Nothing Then
                Me.calendarControls = TryCast(data, ucCalendar)
                Me.calendarControls.InitDateNavigator(Me.schedulerControl1)
                Me.calendarControls.InitResourcesTree(Me.schedulerStorage1)
                Me.calendarControls.InitBarController(Me.schedulerControl1)
            End If
        End Sub
        Private Function FindAppointmentPage(ByVal ribbonControl As RibbonControl) As RibbonPageCategory
            For Each category As RibbonPageCategory In ribbonControl.PageCategories
                If category.Tag IsNot Nothing AndAlso category.Tag.ToString() = "CalendarTools" Then
                    Return category
                End If
            Next category
            Return Nothing
        End Function
        Protected Friend Overrides Sub ButtonClick(ByVal tag As String)
            Select Case tag
                Case TagResources.OpenCalendar
                    LoadCalendar()
                Case TagResources.MenuSaveCalendar
                    SaveCalendar()
            End Select
        End Sub
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            SubscribeSchedulerEvents()
            UpdateAppointmentCategory()
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
            Dim apt As Appointment = CType(e.Object, Appointment)
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
        Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles schedulerControl1.InitNewAppointment
            Dim selectedIds As List(Of Integer) = Me.calendarControls.GetSelectedResourceIds()
            If selectedIds.Count > 0 Then
                e.Appointment.ResourceId = selectedIds(0)
            End If
        End Sub

        Private Sub SaveCalendar()
            Dim fileDialog As New SaveFileDialog()
            fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
            fileDialog.FilterIndex = 1
            If fileDialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            Try
                Using stream As Stream = fileDialog.OpenFile()
                    ExportAppointments(stream)
                End Using
            Catch
                XtraMessageBox.Show(My.Resources.AppointmentError, My.Resources._Error)
            End Try
        End Sub

        Private Sub LoadCalendar()
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "iCalendar files (*.ics)|*.ics"
            dialog.FilterIndex = 1
            If dialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            Using stream As Stream = dialog.OpenFile()
                ImportAppointments(stream)
            End Using
        End Sub

        Private Sub ExportAppointments(ByVal stream As Stream)
            If stream Is Nothing Then
                Return
            End If
            Dim exporter As New iCalendarExporter(schedulerStorage1)
            exporter.ProductIdentifier = "-//Developer Express Inc.//XtraScheduler iCalendarExportDemo//EN"
            AddHandler exporter.AppointmentExporting, AddressOf exporter_AppointmentExporting
            exporter.Export(stream)
        End Sub

        Private Sub ImportAppointments(ByVal stream As Stream)
            If stream Is Nothing Then
                Return
            End If
            Dim importer As New iCalendarImporter(schedulerStorage1)
            AddHandler importer.AppointmentImporting, AddressOf importer_AppointmentImporting
            importer.Import(stream)
        End Sub

        Private Sub exporter_AppointmentExporting(ByVal sender As Object, ByVal e As AppointmentExportingEventArgs)
        End Sub

        Private Sub importer_AppointmentImporting(ByVal sender As Object, ByVal e As AppointmentImportingEventArgs)
        End Sub
        Private Sub ShowAppointmentCategory()
            If Me.appointmentCategory Is Nothing Then
                Return
            End If
            If Me.lastSelectedPage Is Nothing Then
                Me.lastSelectedPage = Me.ribbon.SelectedPage
            End If
            Me.appointmentCategory.Visible = True
            Me.ribbon.SelectedPage = GetFirstVisiblePage(Me.appointmentCategory)
        End Sub
        Private Sub HideAppointmentCategory()
            If Me.appointmentCategory Is Nothing Then
                Return
            End If
            Me.appointmentCategory.Visible = False
            If Me.lastSelectedPage IsNot Nothing Then
                Me.ribbon.SelectedPage = Me.lastSelectedPage
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

    End Class
End Namespace
