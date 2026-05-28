Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.DrillDownReport

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New DrillDownReport()
        End Function
    End Class
End Namespace
