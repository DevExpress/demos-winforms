Namespace XtraReportsDemos.ProfitAndLossReport

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Sub OnSetViewer()
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth)
        End Sub

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
        End Function
    End Class
End Namespace
