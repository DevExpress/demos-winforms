Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.EmployeePerformanceReview

    Public Class PreviewControl
        Inherits ReportModule

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function

        Protected Overrides Sub OnAfterReportPrint()
            If Viewer IsNot Nothing Then Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, New Object() {True})
        End Sub
    End Class
End Namespace
