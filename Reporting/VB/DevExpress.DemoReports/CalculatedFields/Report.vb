Imports System.Linq
Imports DevExpress.XtraReports.Parameters

Namespace XtraReportsDemos.CalculatedFieldsReport

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.CalculatedFieldsName
            DisplayName = ReportNames.CalculatedFields
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            UpdateReportCalculatedField()
        End Sub

        Private Sub UpdateReportCalculatedField()
            Dim columnDescription As String = GetDescription(CType(ExpressionParameter.LookUpSettings, StaticListLookUpSettings), CStr(ExpressionParameter.Value))
            Dim expressionValue As String = CStr(ExpressionParameter.Value)
            SetReportParameters(columnDescription, expressionValue)
        End Sub

        Private Sub SetReportParameters(ByVal columnDescription As String, ByVal expression As String)
            calculatedField1.Expression = expression
            xrTableCell12.Text = columnDescription
            xrLabel3.TextFormatString = "Total " & columnDescription & " - {0:c}"
            xrLabel3.XlsxFormatString = """Total " & columnDescription & " - ""$0.00"
        End Sub

        Private Shared Function GetDescription(ByVal lookupSettings As StaticListLookUpSettings, ByVal value As String) As String
            Dim lookup As LookUpValue = lookupSettings.LookUpValues.FirstOrDefault(Function(x) Equals(CStr(x.Value), value))
            Return If(lookup IsNot Nothing, lookup.Description, "")
        End Function
    End Class
End Namespace
