Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting

    Public Partial Class SingleReportPreviewControl
        Inherits ReportPreviewControlBase

        Private _report As XtraSchedulerReport

        Public Overridable ReadOnly Property Report As XtraSchedulerReport
            Get
                Return _report
            End Get
        End Property

        Protected Overridable Function CreateReportInstance() As XtraSchedulerReport
            Return Nothing
        End Function

        Protected Overrides Sub CreateReports()
            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = True
            If _report IsNot Nothing Then
                _report.Dispose()
            End If

            _report = CreateReportInstance()
        End Sub

        Protected Overrides Function GetActiveReport() As XtraSchedulerReport
            Return Report
        End Function
    End Class
End Namespace
