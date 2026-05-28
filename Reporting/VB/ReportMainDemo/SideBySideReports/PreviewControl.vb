Namespace XtraReportsDemos.SideBySideReports

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New EmployeeComparisonReport()
        End Function
    End Class
End Namespace
