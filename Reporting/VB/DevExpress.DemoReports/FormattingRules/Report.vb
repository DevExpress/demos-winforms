Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.FormattingRules

    Public Partial Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.FormattingRulesName
            DisplayName = ReportNames.FormattingRules
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            UpdateFormattingRule()
        End Sub

        Private Sub UpdateFormattingRule()
            formattingRule1.Condition = CStr(ConditionParameter.Value)
            formattingRule1.ApplyStyle(StyleSheet(CStr(StyleParameter.Value)))
        End Sub
    End Class
End Namespace
