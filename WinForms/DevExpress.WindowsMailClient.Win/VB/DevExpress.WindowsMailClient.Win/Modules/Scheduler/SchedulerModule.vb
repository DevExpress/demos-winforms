Imports System
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.WindowsMailClient.Win.ViewModels
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.WindowsMailClient.Win.Modules

    Public Partial Class SchedulerModule
        Inherits BaseModule

        Public Sub New()
            MyBase.New(GetType(SchedulerModuleViewModel))
            InitializeComponent()
            schedulerControl1.BeginUpdate()
            Try
                schedulerControl1.OptionsBehavior.UseAsyncMode = False
                schedulerControl1.MonthView.AllowScrollAnimation = False
            Finally
                schedulerControl1.EndUpdate()
            End Try
        End Sub

        Public ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl1
            End Get
        End Property

        Private Sub SchedulerModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(schedulerControl1)
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Windows.Forms.Message)
            If m.Msg = 528 OrElse m.Msg = MSG.WM_LBUTTONDBLCLK OrElse m.Msg = MSG.WM_LBUTTONDOWN OrElse m.Msg = MSG.WM_LBUTTONDOWN Then
                Me.GetParentViewModel(Of MainViewModel)().HideAllPanels()
            End If

            MyBase.WndProc(m)
        End Sub
    End Class
End Namespace
