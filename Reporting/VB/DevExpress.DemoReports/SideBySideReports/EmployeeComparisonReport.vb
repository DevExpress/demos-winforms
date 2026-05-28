Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.SideBySideReports

    Public Partial Class EmployeeComparisonReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SideBySideReportsName
            DisplayName = ReportNames.SideBySideReports
        End Sub

        Protected Overrides Sub OnDisposing()
            DisposeReportSource(xrSubreport1)
            DisposeReportSource(xrSubreport2)
            MyBase.OnDisposing()
        End Sub

        Private Sub DisposeReportSource(ByVal subreport As XRSubreport)
            Dim report As XtraReport = subreport.ReportSource
            If report IsNot Nothing AndAlso Not report.IsDisposed Then report.Dispose()
        End Sub
    End Class
End Namespace
