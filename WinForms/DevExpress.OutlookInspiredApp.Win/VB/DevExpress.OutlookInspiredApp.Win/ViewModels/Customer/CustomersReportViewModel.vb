Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class CustomersReportViewModel
        Inherits ReportViewModelBaseType1(Of CustomerReportType, Customer, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As CustomersReportViewModel
            Return ViewModelSource.Create(Function() New CustomersReportViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public ReadOnly Property CustomerEmployees As IList(Of CustomerEmployee)
            Get
                Return unitOfWork.CustomerEmployees.ToList()
            End Get
        End Property

        Public ReadOnly Property CustomerStores As IList(Of CustomerStore)
            Get
                Return unitOfWork.CustomerStores.ToList()
            End Get
        End Property
    End Class
End Namespace
