Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.DevAV.ViewModels

    Public Enum ProductReportType
        None
        <Display(Name:="Order Detail")>
        OrderDetail
        <Display(Name:="Sales Summary Report")>
        SalesSummary
        <Display(Name:="Specification Summary Report")>
        SpecificationSummary
        <Display(Name:="Top Salesperson Report")>
        TopSalesperson
    End Enum
End Namespace
