Imports System
Imports DevExpress.XtraScheduler.Commands

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SchedulerBarsModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            schedulerControl.DayView.ShowWorkTimeOnly = True
            schedulerControl.WorkWeekView.ShowWorkTimeOnly = True
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub SchedulerBarsModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
        End Sub

        Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Dim command As CommitAndCloseInplaceEditorCommand = New CommitAndCloseInplaceEditorCommand(schedulerControl)
            command.Execute()
        End Sub
    End Class
End Namespace
