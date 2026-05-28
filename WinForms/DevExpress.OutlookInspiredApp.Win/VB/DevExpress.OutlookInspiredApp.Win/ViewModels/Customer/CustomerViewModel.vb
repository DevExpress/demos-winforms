Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the single Customer object view model.
    ''' </summary>
    Public Partial Class CustomerViewModel
        Inherits SingleObjectViewModel(Of Customer, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of CustomerViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As CustomerViewModel
            Return ViewModelSource.Create(Function() New CustomerViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the CustomerViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Customers, Function(x) x.Name)
        End Sub

        ''' <summary>
        ''' The view model for the CustomerEmployees detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerEmployeesDetails As CollectionViewModelBase(Of CustomerEmployee, CustomerEmployee, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerEmployeesDetails, Function(x) x.CustomerEmployees, Function(x) x.CustomerId, Sub(x, key) x.CustomerId = key)
            End Get
        End Property

        ''' <summary>
        ''' The view model for the CustomerOrders detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerOrdersDetails As CollectionViewModelBase(Of Order, Order, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerOrdersDetails, Function(x) x.Orders, Function(x) x.CustomerId, Sub(x, key) x.CustomerId = key, Function(query) query.ActualOrders())
            End Get
        End Property

        ''' <summary>
        ''' The view model for the CustomerQuotes detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerQuotesDetails As CollectionViewModelBase(Of Quote, Quote, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerQuotesDetails, Function(x) x.Quotes, Function(x) x.CustomerId, Sub(x, key) x.CustomerId = key, Function(query) query.ActualQuotes())
            End Get
        End Property

        ''' <summary>
        ''' The view model for the CustomerCustomerStores detail collection.
        ''' </summary>
        Public ReadOnly Property CustomerCustomerStoresDetails As CollectionViewModelBase(Of CustomerStore, CustomerStore, Long, IDevAVDbUnitOfWork)
            Get
                Return GetDetailsCollectionViewModel(Function(ByVal x As CustomerViewModel) x.CustomerCustomerStoresDetails, Function(x) x.CustomerStores, Function(x) x.CustomerId, Sub(x, key) x.CustomerId = key)
            End Get
        End Property
    End Class
End Namespace
