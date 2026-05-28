Imports System
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class ResourcesTreeModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPane
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkShowResourceHeaders.Checked = False
                chkAutoHeightCells.Checked = False
                chkAutoFilterRow.Checked = True
                spinResourcesPerPage.EditValue = Math.Min(4, Scheduler.DataStorage.Resources.Count)
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub ResourcesTreeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(Scheduler, False)
            ResetOptions()
        End Sub

        Private Sub chkAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            resourcesTree1.OptionsView.ShowAutoFilterRow = chkAutoFilterRow.Checked
        End Sub

        Private Sub chkShowResourceHeaders_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            Scheduler.TimelineView.ShowResourceHeaders = chkShowResourceHeaders.Checked
        End Sub

        Private Sub chkAutoHeightCells_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)
            Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = If(chkAutoHeightCells.Checked, SchedulerCellAutoHeightMode.Full, SchedulerCellAutoHeightMode.None)
        End Sub

        Private Sub spinResourcesPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.ResourcesPerPage = Convert.ToInt32(spinResourcesPerPage.EditValue)
        End Sub

        Private Sub schedulerControl1_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim isEnabled As Boolean = Scheduler.ActiveViewType = SchedulerViewType.Timeline
            chkShowResourceHeaders.Enabled = isEnabled
            chkAutoHeightCells.Enabled = isEnabled
            spinResourcesPerPage.Enabled = isEnabled
        End Sub

        Private Sub resourcesTree1_LayoutUpdated(ByVal sender As Object, ByVal e As EventArgs)
            spinResourcesPerPage.EditValue = schedulerControl1.ActiveView.ResourcesPerPage
        End Sub
    End Class
End Namespace
