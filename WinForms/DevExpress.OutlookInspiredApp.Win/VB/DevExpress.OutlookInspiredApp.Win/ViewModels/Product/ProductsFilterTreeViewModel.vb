Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Properties
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class ProductsFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Product, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As ProductCollectionViewModel) As ProductsFilterTreeViewModel
            Return ViewModelSource.Create(Function() New ProductsFilterTreeViewModel(collectionViewModel))
        End Function

        Protected Sub New(ByVal collectionViewModel As ProductCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of Settings)(Settings.Default, FilterTreeViewModel(Of Global.DevExpress.DevAV.Product, Global.System.Int64, Global.DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork).StaticFiltersName, Function(x) x.ProductsStaticFilters, Function(x) x.ProductsCustomFilters, Function(x) x.ProductsGroupFilters))
        End Sub

        Protected Overloads ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, ProductCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
