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

        Public Function GetFinancialReport() As IEnumerable(Of ProductsAnalysis.Item)
            Return unitOfWork.GetFinancialReport
        End Function

        Public Function GetFinancialData() As IEnumerable(Of ProductsAnalysis.Item)
            Return unitOfWork.GetFinancialData
        End Function
    End Class
End Namespace
