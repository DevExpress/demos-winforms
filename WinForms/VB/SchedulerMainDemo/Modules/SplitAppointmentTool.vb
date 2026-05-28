Imports System
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SplitAppointmentToolModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SplitAppointmentToolModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
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
