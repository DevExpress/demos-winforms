Namespace XtraReportsDemos.NorthwindTraders

    Public Class ProductListPreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New ProductListReport()
        End Function
    End Class
End Namespace
