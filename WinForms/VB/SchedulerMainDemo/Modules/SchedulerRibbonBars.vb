Imports System
Imports DevExpress.XtraScheduler.Commands

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class SchedulerRibbonBarsModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            schedulerControl.DayView.ShowWorkTimeOnly = True
            schedulerControl.WorkWeekView.ShowWorkTimeOnly = True
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides Property AutoMergeRibbon As Boolean
            Get
                Return False
            End Get

            Set(ByVal value As Boolean)
            End Set
        End Property

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub SchedulerBarsModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
        End Sub

        Private Sub ribbonControl1_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            Dim command As CommitAndCloseInplaceEditorCommand = New CommitAndCloseInplaceEditorCommand(schedulerControl)
            command.Execute()
        End Sub
    End Class
End Namespace
