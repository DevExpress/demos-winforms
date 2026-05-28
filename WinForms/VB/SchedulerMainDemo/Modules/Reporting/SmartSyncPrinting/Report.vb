Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraSchedulerReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub resourceInfo1_CustomizeText(ByVal sender As Object, ByVal e As TextCustomizingEventArgs)
            Dim args As ResourceTextCustomizingEventArgs = CType(e, ResourceTextCustomizingEventArgs)
            If args.Resources.Count = 1 AndAlso (args.Resources(0).Id.Equals(EmptyResourceId.Id)) Then args.Text = "Total Report"
        End Sub
    End Class
End Namespace
