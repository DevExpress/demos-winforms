Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PollingReport

    Public Class PreviewControl
        Inherits ReportModule

        Private showResults As Boolean = False

        Private pollCount As Integer = 3

        Private ReadOnly data As IList(Of ResultingData) = New List(Of ResultingData)()

        Protected Overrides Function CreateReport() As XtraReport
            If showResults Then
                Dim resultingReport As ResultingReport = New ResultingReport()
                AddHandler resultingReport.PollingLink.PreviewClick, AddressOf Link_PreviewClick
                resultingReport.ResultingReportDS.DataSource = data
                resultingReport.Parameters("paramPollCount").Value = System.Threading.Interlocked.Increment(pollCount)
                Return resultingReport
            Else
                Dim pollingReport As PollingReport = New PollingReport()
                AddHandler pollingReport.ResultingLink.PreviewClick, AddressOf Link_PreviewClick
                Return pollingReport
            End If
        End Function

        Private Sub Link_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            showResults = Not showResults
            If TypeOf Report Is PollingReport Then CType(Report, PollingReport).UpdateData(data)
            DisposeReport()
            Activate()
        End Sub
    End Class
End Namespace
