Namespace XtraReportsDemos.SwissQRCode

    Public Partial Class SwissQRBill
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.SwissQRBillName
            DisplayName = ReportNames.SwissQRBill
        End Sub

        Private Sub SwissQRBill_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim languageString As String = TryCast(Language.Value, String)
            ApplyLocalization(languageString)
        End Sub
    End Class
End Namespace
