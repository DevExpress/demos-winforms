Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ContextButtonsModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub ContextButtonsModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
            'this.schedulerControl.AppointmentContextButtons.Add(new DeleteAppointmentContextButton());
            'this.schedulerControl.AppointmentContextButtons.Add(new OpenAppointmentContextButton());
            'this.chEditKeepInView.Checked = this.schedulerControl.OptionsAppointmentContextButtons.KeepInView;
            cbContextButtonAlignment.EditValue = ContextItemAlignment.TopFar
            cbContextButtonVisibility.EditValue = ContextItemVisibility.Auto
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub

        Private Sub chEditKeepInView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        'this.schedulerControl.OptionsAppointmentContextButtons.KeepInView = this.chEditKeepInView.Checked;
        End Sub

        Private Sub cbOpenContextButtonVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'ContextItemVisibility visibility = (ContextItemVisibility)cbContextButtonVisibility.EditValue;
        'SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
        'foreach (ContextItem button in appointmentContextButtons)
        '    button.Visibility = visibility;
        End Sub

        Private Sub cbContextButtonAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'ContextItemAlignment alignment = (ContextItemAlignment)cbContextButtonAlignment.EditValue;
        'SchedulerContextItemCollection appointmentContextButtons = this.schedulerControl.AppointmentContextButtons;
        'foreach (ContextItem button in appointmentContextButtons)
        '    button.Alignment = alignment;
        End Sub
    End Class
End Namespace
