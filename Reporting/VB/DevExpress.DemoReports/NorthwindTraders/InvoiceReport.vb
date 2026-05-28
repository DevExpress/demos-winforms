Namespace XtraReportsDemos.NorthwindTraders

    Public Partial Class InvoiceReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.NorthwindTraders_InvoiceName
            DisplayName = ReportNames.NorthwindTraders_Invoice
        End Sub
    End Class
End Namespace
