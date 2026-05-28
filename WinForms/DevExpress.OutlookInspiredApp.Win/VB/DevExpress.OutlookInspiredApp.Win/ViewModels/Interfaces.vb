Imports System
Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.DevAV

    Public Enum ModuleType
        Unknown
        <Display(Name:="Employees")>
        Employees
        EmployeesFilterPane
        EmployeesFilterPaneCollapsed
        EmployeesPeek
        EmployeeView
        <Display(Name:="Edit Contact")>
        EmployeeEditView
        <Display(Name:="Contact Map")>
        EmployeeMapView
        EmployeesCustomFilter
        EmployeesGroupFilter
        EmployeesExport
        EmployeesPrint
        <Display(Name:="Contact Mail Merge")>
        EmployeeMailMerge
        <Display(Name:="Customers")>
        Customers
        CustomersFilterPane
        CustomersFilterPaneCollapsed
        CustomersPeek
        CustomerView
        CustomerEditView
        <Display(Name:="Sales Map")>
        CustomerMapView
        <Display(Name:="Sales Analysis")>
        CustomerAnalysis
        CustomersCustomFilter
        CustomersGroupFilter
        CustomersExport
        CustomersPrint
        <Display(Name:="Products")>
        Products
        ProductsFilterPane
        ProductsFilterPaneCollapsed
        ProductsPeek
        ProductView
        ProductEditView
        <Display(Name:="Sales Map")>
        ProductMapView
        <Display(Name:="Sales Analysis")>
        ProductAnalysis
        ProductsCustomFilter
        ProductsGroupFilter
        ProductsExport
        ProductsPrint
        <Display(Name:="Sales")>
        Orders
        OrdersFilterPane
        OrdersFilterPaneCollapsed
        OrdersCustomFilter
        OrdersPeek
        OrderView
        <Display(Name:="Edit Order")>
        OrderEditView
        <Display(Name:="Shipping Map")>
        OrderMapView
        OrdersExport
        OrdersPrint
        <Display(Name:="Sales Mail Merge")>
        OrderMailMerge
        <Display(Name:="Invoice (PDF)")>
        OrderPdfQuickReportView
        <Display(Name:="Invoice (DOC)")>
        OrderDocQuickReportView
        <Display(Name:="Invoice (XLS)")>
        OrderXlsQuickReportView
        <Display(Name:="Sales Report")>
        OrderRevenueView
        <Display(Name:="Opportunities")>
        Quotes
        QuotesFilterPane
        QuotesFilterPaneCollapsed
        QuotesCustomFilter
        QuotesPeek
        QuoteView
        QuoteEditView
        <Display(Name:="Opportunities Map")>
        QuoteMapView
        QuotesExport
        QuotesPrint
        <Display(Name:="Tasks")>
        Tasks
        TaskView
        TasksFilterPane
        TasksFilterPaneCollapsed
        TasksPeek
        TasksCustomFilter
        TasksGroupFilter
        TaskEditView
    End Enum

    Public Interface IMainModule
        Inherits IPeekModulesHost, ISupportModuleLayout, ISupportTransitions

    End Interface

    Public Interface ISupportCompactLayout

        Property Compact As Boolean

    End Interface

    Public Interface ISupportZoom

        Property ZoomLevel As Integer

        Event ZoomChanged As EventHandler

    End Interface

    Public Interface ISupportTransitions

        Sub StartTransition(ByVal forward As Boolean, ByVal waitParameter As Object)

        Sub EndTransition()

    End Interface

    Public Interface ISupportModuleLayout

        Sub SaveLayoutToStream(ByVal ms As IO.MemoryStream)

        Sub RestoreLayoutFromStream(ByVal ms As IO.MemoryStream)

    End Interface

    Public Interface IPeekModulesHost

        Function IsDocked(ByVal type As ModuleType) As Boolean

        Sub DockModule(ByVal moduleType As ModuleType)

        Sub UndockModule(ByVal moduleType As ModuleType)

        Sub ShowPeek(ByVal moduleType As ModuleType)

    End Interface

    Friend Interface ISupportNewChid
    End Interface

    Friend Interface ISupportNewParent
    End Interface

    Public Interface ISupportMap

        Sub ShowMap()

        Function CanShowMap() As Boolean

    End Interface

    Public Interface ISupportAnalysis

        Sub ShowAnalysis()

    End Interface

    Public Interface IZoomViewModel

        ReadOnly Property ZoomModule As Object

        Event ZoomModuleChanged As EventHandler

    End Interface

    Public Interface ISupportModifications

        ReadOnly Property Modified As Boolean

        Sub Save()

    End Interface

    Public Interface ISupportCustomFilters

        Sub ResetCustomFilters()

        Event CustomFiltersReset As EventHandler

    End Interface

    Public Interface IRouteMapViewModel

        Property TravelMode As XtraMap.AzureTravelMode

        Property PointA As Address

        Property PointB As Address

        Property RouteDistance As Double

        Property RouteTime As TimeSpan

        Event TravelModeChanged As EventHandler

        Event PointAChanged As EventHandler

        Event PointBChanged As EventHandler

        Event UpdateRoute As EventHandler

    End Interface

    Public Interface ISalesMapViewModel

        Property Period As Period

        Event PeriodChanged As EventHandler

    End Interface
End Namespace
