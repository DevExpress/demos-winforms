Namespace XtraReportsDemos.IListDataSource

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            DisplayName = ReportNames.HiddenColumns
            Name = DisplayName
        End Sub
    End Class
End Namespace
