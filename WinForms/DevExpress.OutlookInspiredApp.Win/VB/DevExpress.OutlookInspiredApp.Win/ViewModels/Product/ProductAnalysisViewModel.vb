Imports System.Collections.Generic
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class ProductAnalysisViewModel
        Inherits DocumentContentViewModelBase

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As ProductAnalysisViewModel
            Return ViewModelSource.Create(Function() New ProductAnalysisViewModel())
        End Function

        Protected Sub New()
            unitOfWork = GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub

        Public Function GetFinancialReport(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ProductsAnalysis.Item)
            Return unitOfWork.GetFinancialReport(startDate, endDate)
        End Function

        Public Function GetFinancialData(ByVal startDate As Date, ByVal endDate As Date) As IEnumerable(Of ProductsAnalysis.Item)
            Return unitOfWork.GetFinancialData(startDate, endDate)
        End Function

        Public Function GetMaxOrdersDate() As Date
            Return unitOfWork.GetMaxOrdersDate
        End Function
    End Class
End Namespace
