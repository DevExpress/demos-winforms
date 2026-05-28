Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.Charts

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(2, 1)
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
