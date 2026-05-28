Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraGrid.Views.WinExplorer

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeesGroupFilterPresenter
        Inherits GroupFilterPresenter(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal winExplorerView As WinExplorerView, ByVal viewModel As GroupFilterViewModel)
            MyBase.New(winExplorerView, viewModel)
        End Sub

        Protected Overrides Function GetEntityKey(ByVal entity As Employee) As Long
            Return entity.Id
        End Function
    End Class

    Public Class CustomersGroupFilterPresenter
        Inherits GroupFilterPresenter(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal winExplorerView As WinExplorerView, ByVal viewModel As GroupFilterViewModel)
            MyBase.New(winExplorerView, viewModel)
        End Sub

        Protected Overrides Function GetEntityKey(ByVal entity As Customer) As Long
            Return entity.Id
        End Function
    End Class

    Public Class ProductsGroupFilterPresenter
        Inherits GroupFilterPresenter(Of Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal winExplorerView As WinExplorerView, ByVal viewModel As GroupFilterViewModel)
            MyBase.New(winExplorerView, viewModel)
        End Sub

        Protected Overrides Function GetEntityKey(ByVal entity As Product) As Long
            Return entity.Id
        End Function
    End Class
End Namespace
