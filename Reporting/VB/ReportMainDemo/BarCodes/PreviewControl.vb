Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.BarCodes

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New BarCodeTypesReport()
        End Function
    End Class
End Namespace
