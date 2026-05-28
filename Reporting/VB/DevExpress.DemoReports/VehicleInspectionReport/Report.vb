Namespace XtraReportsDemos.VehicleInspectionReport

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.VehicleInspectionReportName
            DisplayName = ReportNames.VehicleInspectionReport
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim language As String = TryCast(parameterLanguage.Value, String)
            ApplyLocalization(language)
        End Sub
    End Class
End Namespace
