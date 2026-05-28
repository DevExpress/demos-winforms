Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.Mvvm.ViewModel

Namespace DevExpress.DevAV.ViewModels

    ''' <summary>
    ''' Represents the single Order object view model.
    ''' </summary>
    Public Partial Class OrderViewModel
        Inherits SingleObjectViewModel(Of Order, Long, IDevAVDbUnitOfWork)

        ''' <summary>
        ''' Creates a new instance of OrderViewModel as a POCO view model.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Public Shared Function Create(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing) As OrderViewModel
            Return ViewModelSource.Create(Function() New OrderViewModel(unitOfWorkFactory))
        End Function

        ''' <summary>
        ''' Initializes a new instance of the OrderViewModel class.
        ''' This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        ''' </summary>
        ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        Protected Sub New(ByVal Optional unitOfWorkFactory As IUnitOfWorkFactory(Of IDevAVDbUnitOfWork) = Nothing)
            MyBase.New(If(unitOfWorkFactory, GetUnitOfWorkFactory()), Function(x) x.Orders, Function(x) x.InvoiceNumber)
        End Sub

        ''' <summary>
        ''' The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCustomers As IEntitiesViewModel(Of Customer)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpCustomers, Function(x) x.Customers)
            End Get
        End Property

        ''' <summary>
        ''' The view model that contains a look-up collection of CustomerStores for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpCustomerStores As IEntitiesViewModel(Of CustomerStore)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpCustomerStores, Function(x) x.CustomerStores)
            End Get
        End Property

        ''' <summary>
        ''' The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        ''' </summary>
        Public ReadOnly Property LookUpEmployees As IEntitiesViewModel(Of Employee)
            Get
                Return GetLookUpEntitiesViewModel(Function(ByVal x As OrderViewModel) x.LookUpEmployees, Function(x) x.Employees)
            End Get
        End Property
    End Class
End Namespace
