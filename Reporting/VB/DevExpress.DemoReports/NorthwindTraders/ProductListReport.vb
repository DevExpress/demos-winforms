Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.NorthwindTraders

    Public Partial Class ProductListReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.NorthwindTraders_ProductsName
            DisplayName = ReportNames.NorthwindTraders_Products
        End Sub
    End Class
End Namespace
