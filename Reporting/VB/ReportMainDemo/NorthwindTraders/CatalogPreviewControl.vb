Namespace XtraReportsDemos.NorthwindTraders

    Public Class CatalogPreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New CatalogReport()
        End Function
    End Class
End Namespace
