Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class GroupByDateModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub GroupByDateModule_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
        End Sub
    End Class
End Namespace
