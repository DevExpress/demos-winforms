Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Properties
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class CustomersFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As CustomerCollectionViewModel) As CustomersFilterTreeViewModel
            Return ViewModelSource.Create(Function() New CustomersFilterTreeViewModel(collectionViewModel))
        End Function

        Protected Sub New(ByVal collectionViewModel As CustomerCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of Settings)(Settings.Default, FilterTreeViewModel(Of Global.DevExpress.DevAV.Customer, Global.System.Int64, Global.DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork).StaticFiltersName, Function(x) x.CustomersStaticFilters, Function(x) x.CustomersCustomFilters, Function(x) x.CustomersGroupFilters))
        End Sub

        Protected Overloads ReadOnly Property CollectionViewModel As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, CustomerCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
