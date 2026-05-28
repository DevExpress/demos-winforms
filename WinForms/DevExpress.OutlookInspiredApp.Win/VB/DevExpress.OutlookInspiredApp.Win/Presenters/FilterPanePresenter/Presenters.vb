Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeFilterPanePresenter
        Inherits FilterPanePresenter(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As EmployeesFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property
    End Class

    Public Class CustomerFilterPanePresenter
        Inherits FilterPanePresenter(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As CustomersFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, CustomerCollectionViewModel)
            End Get
        End Property
    End Class

    Public Class ProductFilterPanePresenter
        Inherits FilterPanePresenter(Of Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As ProductsFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, ProductCollectionViewModel)
            End Get
        End Property
    End Class

    Public Class OrderFilterPanePresenter
        Inherits FilterPanePresenter(Of Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As OrdersFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, OrderCollectionViewModel)
            End Get
        End Property
    End Class

    Public Class QuoteFilterPanePresenter
        Inherits FilterPanePresenter(Of Quote, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As QuotesFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As QuoteCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, QuoteCollectionViewModel)
            End Get
        End Property
    End Class

    Public Class TasksFilterPanePresenter
        Inherits FilterPanePresenter(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As TasksFilterTreeViewModel)
            MyBase.New(navigationBar, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As TaskCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, TaskCollectionViewModel)
            End Get
        End Property
    End Class
End Namespace
