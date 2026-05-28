Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class TimeZonesModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            AddHandler schedulerControl.PopupMenuShowing, AddressOf schedulerControl_PopupMenuShowing
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPane
            End Get
        End Property

        Private Sub TimeZonesModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(schedulerControl)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            schedulerControl.DayView.TimeRulers(1).UseClientTimeZone = False
            schedulerControl.WorkWeekView.TimeRulers(1).UseClientTimeZone = False
            edtTimeZone.TimeZoneId = schedulerControl.OptionsBehavior.ClientTimeZoneId
        End Sub

        Private Sub edtTimeZone_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.OptionsBehavior.ClientTimeZoneId = edtTimeZone.TimeZoneId
            Dim caption As String = schedulerControl.OptionsBehavior.ClientTimeZoneId.ToString()
            schedulerControl.DayView.TimeRulers(2).Caption = caption
            schedulerControl.WorkWeekView.TimeRulers(2).Caption = caption
            schedulerControl.FullWeekView.TimeRulers(2).Caption = caption
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.AppointmentMenu Then
                Dim command As SplitAppointmentOperationCommand = New SplitAppointmentOperationCommand(schedulerControl)
                Dim menuItemCommandAdapter As SchedulerMenuItemCommandWinAdapter = New SchedulerMenuItemCommandWinAdapter(command)
                Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
                menuItem.BeginGroup = True
                e.Menu.Items.Add(menuItem)
            End If
        End Sub
    End Class
End Namespace
