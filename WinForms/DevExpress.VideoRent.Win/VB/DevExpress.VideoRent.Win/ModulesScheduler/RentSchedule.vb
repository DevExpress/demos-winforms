Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.Data.Filtering
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraScheduler.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.VideoRent.Resources

Namespace DevExpress.VideoRent.Win.ModulesScheduler
	Partial Public Class RentalCalendar
		Inherits TutorialControl
		Private currentCursor As Cursor
		Private tooltip As CustomerToolTipController
		Public Sub New()
			SchedulerLocalizer.Active = New CustomSchedulerLocalizer()

			InitializeComponent()
			Me.tooltip = New CustomerToolTipController(resourcesCheckedListBoxControl1)
			SetupApointmentSearchInterval()
		End Sub
		Protected Overrides ReadOnly Property MainLayoutControl() As DevExpress.XtraLayout.LayoutControl
			Get
				Return lcMain
			End Get
		End Property
		Protected Overrides Sub DoParentChanged()
			MyBase.DoParentChanged()

            Me.schedulerControl1.Start = DateTime.Today.AddDays(-10)

            AddHandler schedulerStorage1.ResourceCollectionLoaded, AddressOf schedulerStorage1_ResourceCollectionLoaded
            If ParentFormMain IsNot Nothing Then
                ParentFormMain.UpdateSchedulerRibbonController(Me.schedulerControl1)
            End If
            BindScheduler()
            For Each group As RibbonPageGroup In Me.ActiveRibbonPage.Groups
                group.ShowCaptionButton = False
            Next group


        End Sub
        Private initialization As Boolean
        Private Sub schedulerStorage1_ResourceCollectionLoaded(ByVal sender As Object, ByVal e As EventArgs)
            If (Not initialization) Then
                Dim count As Integer = schedulerStorage1.Resources.Count
                For i As Integer = 0 To count - 1
                    schedulerStorage1.Resources(i).Visible = i >= 0 AndAlso i < 8
                Next i
                initialization = True
            End If

        End Sub

        Private Sub BindScheduler()
            Me.schedulerStorage1.BeginUpdate()
            Try
                Me.schedulerStorage1.Resources.DataSource = xpcCustomers
                xpcCustomers.LoadingEnabled = True

                Me.schedulerStorage1.Appointments.DataSource = xpcRents
                SubscribeFetchAppointmentEvent()

            Finally
                Me.schedulerStorage1.EndUpdate()
            End Try
        End Sub
        Private Sub SetupApointmentSearchInterval()
            Me.schedulerControl1.OptionsView.NavigationButtons.AppointmentSearchInterval = TimeSpan.FromDays(100)
        End Sub
        Private Sub xpcRents_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpcRents.ResolveSession
            e.Session = Session
        End Sub
        Private Sub xpcCustomers_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpcCustomers.ResolveSession
            e.Session = Session
        End Sub

        Private Sub schedulerStorage1_FilterAppointment(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles schedulerStorage1.FilterAppointment
            Dim apt As Appointment = CType(e.Object, Appointment)
            Dim receiptType As ReceiptType = CType(apt.CustomFields("ReceiptType"), ReceiptType)
            If receiptType.Equals(receiptType.Purchases) Then
                e.Cancel = True
            End If
        End Sub
        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
            Using form As New RentalDetailsForm(schedulerControl1, e.Appointment, LayoutManager)
                form.ShowDialog()
                e.Handled = True
            End Using
        End Sub

        Private Sub SubscribeAppointmentChangingEvent()
            AddHandler schedulerStorage1.AppointmentChanging, AddressOf schedulerStorage1_AppointmentChanging
        End Sub
        Private Sub UnsubscribeAppointmentChangingEvent()
            RemoveHandler schedulerStorage1.AppointmentChanging, AddressOf schedulerStorage1_AppointmentChanging
        End Sub
        Private Sub schedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.AppointmentChanging
            e.Cancel = True
        End Sub
        Private Sub schedulerControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles schedulerControl1.PopupMenuShowing
            Dim labelMenu As SchedulerPopupMenu = e.Menu.GetPopupMenuById(SchedulerMenuItemId.LabelSubMenu)
            If labelMenu IsNot Nothing Then
                labelMenu.Caption = ConstStrings.MovieRating
            End If
            Dim statusMenu As SchedulerPopupMenu = e.Menu.GetPopupMenuById(SchedulerMenuItemId.StatusSubMenu)
            If statusMenu IsNot Nothing Then
                statusMenu.Caption = ConstStrings.RentType
            End If
        End Sub
        Private Sub SubscribeFetchAppointmentEvent()
            AddHandler schedulerStorage1.FetchAppointments, AddressOf schedulerStorage1_FetchAppointments
        End Sub

        Private lastFetchedInterval As New TimeInterval()
        Private Sub schedulerStorage1_FetchAppointments(ByVal sender As Object, ByVal e As FetchAppointmentsEventArgs)
            Dim start As DateTime = e.Interval.Start
            Dim [end] As DateTime = e.Interval.End
            If Start <= Me.lastFetchedInterval.Start OrElse [end] >= Me.lastFetchedInterval.End Then
                Me.lastFetchedInterval = New TimeInterval(start - TimeSpan.FromDays(35), [end] + TimeSpan.FromDays(35))
                xpcRents.Filter = CriteriaOperator.Parse("RentedOn >= ? and ExpectedOn <= ?", lastFetchedInterval.Start, lastFetchedInterval.End)
                xpcRents.LoadingEnabled = True

                currentCursor = Cursor.Current
                Cursor.Current = Cursors.WaitCursor
            End If
        End Sub

		Private Sub schedulerControl1_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs) Handles schedulerControl1.InitAppointmentImages
            Dim apt As Appointment = e.Appointment
            Dim rentType As ActiveRentType = CType(apt.StatusKey, ActiveRentType)
			Dim index As Integer = CalculateRentTypeImageIndex(rentType)
			If index >= 0 Then
				Dim imageInfo As New AppointmentImageInfo()
				imageInfo.Image = ElementHelper.ActiveRentTypeImages.Images(index)
				e.ImageInfoList.Add(imageInfo)
			End If
		End Sub
		Protected Function CalculateRentTypeImageIndex(ByVal type As ActiveRentType) As Integer
			Select Case type
				Case ActiveRentType.Overdue
					Return 0
				Case ActiveRentType.Today
					Return 1
				Case ActiveRentType.Active
					Return 2
				Case Else
					Return -1
			End Select
		End Function
		Private Sub xpcRents_CollectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpo.XPCollectionChangedEventArgs) Handles xpcRents.CollectionChanged
			Cursor.Current = currentCursor
		End Sub
		Private Sub resourcesCheckedListBoxControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles resourcesCheckedListBoxControl1.MouseMove
			Dim index As Integer = resourcesCheckedListBoxControl1.IndexFromPoint(e.Location)
			If index >= 0 Then
				Dim customer As Customer = TryCast(xpcCustomers(index), Customer)
				If customer IsNot Nothing Then
					Dim pt As Point = e.Location
					pt.Offset(20, 20)
					Me.tooltip.ShowHint(customer, pt)
				End If
			Else
				Me.tooltip.HideHint(True)
			End If
		End Sub
	End Class
	Public Class CustomSchedulerLocalizer
        Inherits SchedulerResLocalizer
		Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
			Select Case id
				Case SchedulerStringId.Caption_PrevAppointment
					Return "Previous Rentals"
				Case SchedulerStringId.Caption_NextAppointment
					Return "Next Rentals"
				Case SchedulerStringId.Caption_DayViewDescription
					 Return "View a single day’s rentals within the calendar"
				 Case SchedulerStringId.Caption_WorkWeekViewDescription
					 Return "View rentals across a work week"
				 Case SchedulerStringId.Caption_WeekViewDescription
					 Return "View rentals across an entire week"
				 Case SchedulerStringId.Caption_MonthViewDescription
					 Return "View rentals across an entire month"
				 Case SchedulerStringId.Caption_TimelineViewDescription
					 Return "View rentals within a timeline"
				Case SchedulerStringId.DescCmd_NavigateBackward
					 Return "Move back to an earlier time frame"
				Case SchedulerStringId.DescCmd_NavigateForward
					Return "Move forward to a later time frame"
				Case SchedulerStringId.DescCmd_GotoToday
					 Return "Navigate to today’s date"
				 Case SchedulerStringId.DescCmd_ViewZoomIn
					 Return "Zoom in and view more detailed information within the calendar"
				 Case SchedulerStringId.DescCmd_ViewZoomOut
					 Return "Zoom out and view expanded information within the calendar"
			End Select
			Return MyBase.GetLocalizedString(id)
		End Function
	End Class

End Namespace
