Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.Subreports

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New MasterReport()
        End Function
    End Class
End Namespace
