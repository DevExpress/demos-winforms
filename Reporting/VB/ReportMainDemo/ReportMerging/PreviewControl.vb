Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.ReportMerging

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(3, 2)
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Return New MergedReport()
        End Function
    End Class
End Namespace
