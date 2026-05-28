Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.CompilerServices

Namespace DevExpress.DevAV.ViewModels

    Public Enum SalesReportType
        None
        <Display(Name:="Sales Report")>
        SalesReport
        <Display(Name:="Sales by store")>
        SalesByStore
        <Display(Name:="Follow Up")>
        OrderFollowUp
        <Display(Name:="Invoice")>
        Invoice
    End Enum

    Public Module SalesReportTypeExtension

        <Extension()>
        Public Function ToFileName(ByVal reportTemplate As SalesReportType) As String
            Select Case reportTemplate
                Case SalesReportType.SalesReport
                    Return "Sales Order Summary Report"
                Case SalesReportType.SalesByStore
                    Return "Sales Analysys Report"
                Case SalesReportType.OrderFollowUp
                    Return "SalesOrderFollowUp"
                Case Else
                    Return "Sales Invoice"
            End Select
        End Function
    End Module
End Namespace
