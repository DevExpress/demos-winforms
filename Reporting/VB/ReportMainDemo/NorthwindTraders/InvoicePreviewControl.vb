Namespace XtraReportsDemos.NorthwindTraders

    Public Class InvoicePreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New InvoiceReport()
        End Function
    End Class
End Namespace
