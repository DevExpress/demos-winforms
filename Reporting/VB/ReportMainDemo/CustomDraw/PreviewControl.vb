Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CustomDraw

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Dim rep As Report = New Report()
            ReportDesignExtension.AssociateReportWithExtension(rep, ReportNames.CustomDraw)
            Return rep
        End Function
    End Class
End Namespace
