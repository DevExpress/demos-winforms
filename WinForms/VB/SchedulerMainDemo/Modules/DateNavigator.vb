Imports System
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class DateNavigatorModule
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

        Private Sub MonthViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            chkBoldAppointmentDates.Checked = dateNavigator1.BoldAppointmentDates
            chkShowTodayButton.Checked = dateNavigator1.ShowTodayButton
            chkShowWeekNumbers.Checked = dateNavigator1.ShowWeekNumbers
            cbWeekNumberRule.EditValue = dateNavigator1.WeekNumberRule
            cbNavigationMode.EditValue = dateNavigator1.NavigationMode
            FillData(schedulerControl, schedulerDataStorage)
        End Sub

        Private Sub chkBoldAppointmentDates_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateNavigator1.BoldAppointmentDates = chkBoldAppointmentDates.Checked
        End Sub

        Private Sub chkShowTodayButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateNavigator1.ShowTodayButton = chkShowTodayButton.Checked
        End Sub

        Private Sub chkShowWeekNumbers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateNavigator1.ShowWeekNumbers = chkShowWeekNumbers.Checked
        End Sub

        Private Sub cbWeekNumberRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateNavigator1.WeekNumberRule = CType(cbWeekNumberRule.EditValue, WeekNumberRule)
        End Sub

        Private Sub cbNavigationMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            dateNavigator1.NavigationMode = CType(cbNavigationMode.EditValue, DateNavigationMode)
        End Sub
    End Class
End Namespace
