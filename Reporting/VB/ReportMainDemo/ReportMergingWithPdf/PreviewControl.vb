Namespace XtraReportsDemos.ReportMergingWithPdf

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(2, 1)
        End Sub

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
