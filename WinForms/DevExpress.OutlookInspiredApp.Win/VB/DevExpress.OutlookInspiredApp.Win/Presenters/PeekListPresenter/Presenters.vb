Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeePeekListPresenter
        Inherits PeekListPresenter(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridView As GridView, ByVal viewModel As EmployeeCollectionViewModel)
            MyBase.New(gridView, viewModel)
        End Sub

        Protected Overrides Function GetMainModuleType() As ModuleType
            Return ModuleType.Employees
        End Function
    End Class

    Public Class CustomerPeekListPresenter
        Inherits PeekListPresenter(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridView As GridView, ByVal viewModel As CustomerCollectionViewModel)
            MyBase.New(gridView, viewModel)
        End Sub

        Protected Overrides Function GetMainModuleType() As ModuleType
            Return ModuleType.Customers
        End Function
    End Class

    Public Class ProductPeekListPresenter
        Inherits PeekListPresenter(Of Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal gridView As GridView, ByVal viewModel As ProductCollectionViewModel)
            MyBase.New(gridView, viewModel)
        End Sub

        Protected Overrides Function GetMainModuleType() As ModuleType
            Return ModuleType.Products
        End Function
    End Class
End Namespace
