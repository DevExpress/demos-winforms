Imports System.Collections.Generic
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel

Namespace DevExpress.DevAV.ViewModels

    Public Class CustomerAnalysisViewModel
        Inherits DocumentContentViewModelBase

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As CustomerAnalysisViewModel
            Return ViewModelSource.Create(Function() New CustomerAnalysisViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public Function GetSalesReport() As IEnumerable(Of CustomersAnalysis.Item)
            Return unitOfWork.GetSalesReport
        End Function

        Public Function GetSalesData() As IEnumerable(Of CustomersAnalysis.Item)
            Return unitOfWork.GetSalesData
        End Function

        Public Function GetStates(ByVal states As IEnumerable(Of StateEnum)) As IEnumerable(Of String)
            Return QueriesHelper.GetStateNames(unitOfWork.States, states)
        End Function
    End Class
End Namespace
