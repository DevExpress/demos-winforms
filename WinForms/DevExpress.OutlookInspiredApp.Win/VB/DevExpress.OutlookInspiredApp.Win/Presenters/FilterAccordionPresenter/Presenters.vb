Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraBars.Navigation

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of Employee, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordionControl As AccordionControl, ByVal viewModel As EmployeesFilterTreeViewModel)
            MyBase.New(accordionControl, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As EmployeeCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, EmployeeCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class

    Public Class CustomerFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of Customer, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordion As AccordionControl, ByVal viewModel As CustomersFilterTreeViewModel)
            MyBase.New(accordion, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As CustomerCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, CustomerCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class

    Public Class ProductFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of Product, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordion As AccordionControl, ByVal viewModel As ProductsFilterTreeViewModel)
            MyBase.New(accordion, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As ProductCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, ProductCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class

    Public Class OrderFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of Order, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordion As AccordionControl, ByVal viewModel As OrdersFilterTreeViewModel)
            MyBase.New(accordion, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As OrderCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, OrderCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class

    Public Class QuoteFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of Quote, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordion As AccordionControl, ByVal viewModel As QuotesFilterTreeViewModel)
            MyBase.New(accordion, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As QuoteCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, QuoteCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class

    Public Class TaskFilterAccordionPresenter
        Inherits FilterAccordionPresenter(Of EmployeeTask, Long, IDevAVDbUnitOfWork)

        Public Sub New(ByVal accordion As AccordionControl, ByVal viewModel As TasksFilterTreeViewModel)
            MyBase.New(accordion, viewModel)
        End Sub

        Public Overloads ReadOnly Property CollectionViewModel As TaskCollectionViewModel
            Get
                Return TryCast(MyBase.CollectionViewModel, TaskCollectionViewModel)
            End Get
        End Property

        Protected Overrides Sub SubscribeCollectionViewModelEvents()
            MyBase.SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            AddHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            AddHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
        End Sub

        Protected Overrides Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.CustomFilter, AddressOf CollectionViewModel_CustomFilter
            RemoveHandler CollectionViewModel.CustomGroup, AddressOf CollectionViewModel_CustomGroup
            RemoveHandler CollectionViewModel.CustomGroupFromSelection, AddressOf CollectionViewModel_CustomGroupFromSelection
            MyBase.UnsubscribeCollectionViewModelEvents()
        End Sub
    End Class
End Namespace
