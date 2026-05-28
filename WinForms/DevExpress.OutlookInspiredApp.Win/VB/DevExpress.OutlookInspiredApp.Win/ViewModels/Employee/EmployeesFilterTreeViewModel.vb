Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.Properties
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeesFilterTreeViewModel
        Inherits FilterTreeViewModel(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Shared Function Create(ByVal collectionViewModel As EmployeeCollectionViewModel) As EmployeesFilterTreeViewModel
            Return ViewModelSource.Create(Function() New EmployeesFilterTreeViewModel(collectionViewModel))
        End Function

        Protected Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(collectionViewModel, New FilterTreeModelPageSpecificSettings(Of Settings)(Settings.Default, FilterTreeViewModel(Of Global.DevExpress.DevAV.Employee, Global.System.Int64, Global.DevExpress.DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork).StaticFiltersName, Function(x) x.EmployeesStaticFilters, Function(x) x.EmployeesCustomFilters, Function(x) x.EmployeesGroupFilters))
        End Sub

        Protected Overloads ReadOnly Property CollectionViewModel As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
