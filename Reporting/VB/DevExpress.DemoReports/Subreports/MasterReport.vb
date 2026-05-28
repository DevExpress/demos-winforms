Namespace XtraReportsDemos.Subreports

    Public Partial Class MasterReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SubreportsName
            DisplayName = ReportNames.Subreports
        End Sub

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If subreport1.ReportSource IsNot Nothing Then
                subreport1.ApplyParameterBindings()
                subreport1.ReportSource.ApplyFiltering()
                e.Cancel = subreport1.ReportSource.RowCount = 0
            End If
        End Sub

        Private Sub MasterReport_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            If subreport1.ReportSource IsNot Nothing Then subreport1.ReportSource.FillDataSource()
        End Sub
    End Class
End Namespace
