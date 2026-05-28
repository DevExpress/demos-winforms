Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class GroupByResourceModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub GroupByResourceModule_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
        End Sub
    End Class
End Namespace
