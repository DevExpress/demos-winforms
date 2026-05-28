Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class UnboundModeModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub UnboundModeModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerStorage)
        End Sub
    End Class
End Namespace
