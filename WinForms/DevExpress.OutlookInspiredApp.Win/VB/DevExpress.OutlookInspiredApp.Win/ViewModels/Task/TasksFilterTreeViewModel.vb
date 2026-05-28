Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Properties
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class TasksFilterTreeViewModel
        Inherits FilterTreeViewModel(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As TaskCollectionViewModel) As TasksFilterTreeViewModel
            Return ViewModelSource.Create(Function() New TasksFilterTreeViewModel(collectionViewModel))
        End Function

        Protected Sub New(ByVal collectionViewModel As TaskCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of Settings)(Settings.Default, FilterTreeViewModel(Of Global.DevExpress.DevAV.EmployeeTask, Global.System.Int64, Global.DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork).StaticFiltersName, Function(x) x.TasksStaticFilters, Function(x) x.TasksCustomFilters, Function(x) x.TasksGroupFilters))
        End Sub

        Protected Overloads ReadOnly Property CollectionViewModel As TaskCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, TaskCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
