Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraMap

Namespace DevExpress.DevAV.Presenters

    Public Class EmployeeRouteMapPresenter
        Inherits RouteMapPresenter(Of Employee, EmployeeMapViewModel)

        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As EmployeeMapViewModel, ByVal updateUIAction As Action(Of Employee), ByVal updateRouteList As Action(Of List(Of RoutePoint)))
            MyBase.New(mapControl, viewModel, updateUIAction, updateRouteList)
        End Sub

        Protected Overrides Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            MyBase.UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Function GetViewModelEntity() As Employee
            Return ViewModel.Entity
        End Function
    End Class

    Public Class OrderRouteMapPresenter
        Inherits RouteMapPresenter(Of Order, OrderMapViewModel)

        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As OrderMapViewModel, ByVal updateUIAction As Action(Of Order))
            MyBase.New(mapControl, viewModel, updateUIAction, Nothing)
        End Sub

        Protected Overrides Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            MyBase.UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Function GetViewModelEntity() As Order
            Return ViewModel.Entity
        End Function
    End Class

    Public Class CustomerSalesMapPresenter
        Inherits SalesMapPresenter(Of Customer, CustomerMapViewModel)

        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As CustomerMapViewModel, ByVal updateUIAction As Action(Of Customer), ByVal updateChartAction As Action(Of MapItem))
            MyBase.New(mapControl, viewModel, updateUIAction, updateChartAction)
        End Sub

        Protected Overrides Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            MyBase.UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Function GetViewModelEntity() As Customer
            Return ViewModel.Entity
        End Function

        Protected Overrides Sub UpdateSales()
            ZoomService.ZoomTo(ViewModel.GetSalesStores(ViewModel.Period).[Select](Function(s) s.Address))
            PieChartDataAdapter.DataSource = ViewModel.GetSales(ViewModel.Period).ToList()
        End Sub
    End Class

    Public Class ProductSalesMapPresenter
        Inherits SalesMapPresenter(Of Product, ProductMapViewModel)

        Public Sub New(ByVal mapControl As MapControl, ByVal viewModel As ProductMapViewModel, ByVal updateUIAction As Action(Of Product), ByVal updateChartAction As Action(Of MapItem))
            MyBase.New(mapControl, viewModel, updateUIAction, updateChartAction)
        End Sub

        Protected Overrides Sub SubscribeViewModelEvents()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub UnsubscribeViewModelEvents()
            MyBase.UnsubscribeViewModelEvents()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
        End Sub

        Protected Overrides Function GetViewModelEntity() As Product
            Return ViewModel.Entity
        End Function

        Protected Overrides Sub UpdateSales()
            ZoomService.ZoomTo(ViewModel.GetSalesStores(ViewModel.Period).[Select](Function(s) s.Address))
            PieChartDataAdapter.DataSource = ViewModel.GetSales(ViewModel.Period).ToList()
        End Sub
    End Class
End Namespace
