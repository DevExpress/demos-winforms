Imports System.Linq
Imports DevExpress.DevAV.DevAVDbDataModel
Imports System.Collections.Generic
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class OrdersReportViewModel
        Inherits ReportViewModelBaseType1(Of SalesReportType, Order, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As OrdersReportViewModel
            Return ViewModelSource.Create(Function() New OrdersReportViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public Function GetOrderItems() As IList(Of OrderItem)
            Return unitOfWork.OrderItems.ToList()
        End Function
    End Class
End Namespace
