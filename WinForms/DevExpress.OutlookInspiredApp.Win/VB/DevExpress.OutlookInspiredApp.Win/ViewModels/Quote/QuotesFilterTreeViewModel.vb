Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Properties
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class QuotesFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Quote, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As QuoteCollectionViewModel) As QuotesFilterTreeViewModel
            Return ViewModelSource.Create(Function() New QuotesFilterTreeViewModel(collectionViewModel))
        End Function

        Protected Sub New(ByVal collectionViewModel As QuoteCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of Settings)(Settings.Default, FilterTreeViewModel(Of Global.DevExpress.DevAV.Quote, Global.System.Int64, Global.DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork).StaticFiltersName, Function(x) x.QuotesStaticFilters, Function(x) x.QuotesCustomFilters, Function(x) x.QuotesGroupFilters))
        End Sub

        Protected Overloads ReadOnly Property CollectionViewModel As QuoteCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, QuoteCollectionViewModel)
            End Get
        End Property

        Protected Overrides ReadOnly Property EnableGroups As Boolean
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
