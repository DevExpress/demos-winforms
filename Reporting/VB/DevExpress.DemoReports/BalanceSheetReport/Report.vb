Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.BalanceSheetReport

    Public Partial Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.BalanceSheetReportName
            DisplayName = ReportNames.BalanceSheetReport
        End Sub
    End Class
End Namespace
