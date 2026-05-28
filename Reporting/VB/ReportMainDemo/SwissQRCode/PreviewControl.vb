Namespace XtraReportsDemos.SwissQRCode

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New SwissQRBill()
        End Function
    End Class
End Namespace
