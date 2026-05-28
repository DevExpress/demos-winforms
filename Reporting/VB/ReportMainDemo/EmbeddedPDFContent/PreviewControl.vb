Namespace XtraReportsDemos.EmbeddedPDFContent

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Invoice()
        End Function
    End Class
End Namespace
