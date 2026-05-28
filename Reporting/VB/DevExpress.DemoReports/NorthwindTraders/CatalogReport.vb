Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.NorthwindTraders

    Public Partial Class CatalogReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.NorthwindTraders_CatalogName
            DisplayName = ReportNames.NorthwindTraders_Catalog
            parameterSortGroupsType.Type = GetType(SortGroupsType)
            parameterSortGroupsType.Value = SortGroupsType.Count
            parameterSortGroupsOrder.Type = GetType(XRColumnSortOrder)
            parameterSortGroupsOrder.Value = XRColumnSortOrder.Ascending
            UpdateGroupSortingSummary()
        End Sub

        Private Sub UpdateGroupSortingSummary()
            GroupHeader1.SortingSummary.Enabled = True
            GroupHeader1.SortingSummary.FieldName = "UnitPrice"
            If TypeOf parameterSortGroupsOrder.Value Is XRColumnSortOrder Then GroupHeader1.SortingSummary.SortOrder = CType(parameterSortGroupsOrder.Value, XRColumnSortOrder)
            GroupHeader1.SortingSummary.IgnoreNullValues = True
            Dim sortGroupsType As SortGroupsType = If(TypeOf parameterSortGroupsType.Value Is SortGroupsType, CType(parameterSortGroupsType.Value, SortGroupsType), SortGroupsType.Count)
            Select Case sortGroupsType
                Case SortGroupsType.None
                    GroupHeader1.SortingSummary.Enabled = False
                Case SortGroupsType.Count
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Count
                Case SortGroupsType.TotalSales
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Sum
                    GroupHeader1.SortingSummary.FieldName = "ProductSales"
                Case SortGroupsType.LowestPrice
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Min
                Case SortGroupsType.HighestPrice
                    GroupHeader1.SortingSummary.Function = SortingSummaryFunction.Max
            End Select
        End Sub

        Protected Overrides Sub OnBeforePrint(ByVal e As System.ComponentModel.CancelEventArgs)
            MyBase.OnBeforePrint(e)
            UpdateGroupSortingSummary()
        End Sub
    End Class
End Namespace
