Namespace XtraReportsDemos.Shape

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
