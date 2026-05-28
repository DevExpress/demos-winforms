Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.SalesSummary

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
