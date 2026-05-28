Imports System
Imports System.Collections.Generic
Imports System.Reflection
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DXperience.Demos

Namespace DevExpress.DevAV.Services

    Public Interface IModuleActivator

        Function CreateModule(ByVal moduleTypeName As String) As Object

        Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object

    End Interface

    Friend NotInheritable Class ModuleActivator
        Implements IModuleActivator

        Private ReadOnly moduleAssembly As Assembly

        Private rootNamespace As String

        Public Sub New(ByVal moduleAssembly As Assembly, ByVal rootNamespace As String)
            Me.moduleAssembly = moduleAssembly
            Me.rootNamespace = rootNamespace
        End Sub

        Public Function CreateModule(ByVal moduleTypeName As String) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace & "."c & moduleTypeName)
            Dim [module] = Activator.CreateInstance(moduleType)
            Call MainFormHelper.UpdateTakeScreenSettings([module])
            Return [module]
        End Function

        Public Function CreateModule(ByVal moduleTypeName As String, ByVal viewModel As Object) As Object Implements IModuleActivator.CreateModule
            Dim moduleType As Type = Data.Internal.SafeTypeResolver.GetKnownType(moduleAssembly, rootNamespace & "."c & moduleTypeName)
            Return Activator.CreateInstance(moduleType, New Object() {viewModel})
        End Function
    End Class

    Public Interface IReportActivator

        Function CreateReport(ByVal reportKey As Object) As Object

    End Interface

    Friend NotInheritable Class ReportActivator
        Implements IReportActivator

        Private ReadOnly reportTypes As Dictionary(Of Object, Type)

        Public Sub New()
            reportTypes = New Dictionary(Of Object, Type)()
            reportTypes.Add(EmployeeReportType.Directory, GetType(Reports.EmployeeDirectory))
            reportTypes.Add(EmployeeReportType.Profile, GetType(Reports.EmployeeProfile))
            reportTypes.Add(EmployeeReportType.Summary, GetType(Reports.EmployeeSummary))
            reportTypes.Add(EmployeeReportType.TaskList, GetType(Reports.EmployeeTaskList))
            reportTypes.Add(CustomerReportType.Profile, GetType(Reports.CustomerProfile))
            reportTypes.Add(CustomerReportType.SelectedContactDirectory, GetType(Reports.CustomerContactsDirectory))
            reportTypes.Add(CustomerReportType.ContactDirectory, GetType(Reports.CustomerContactsDirectory))
            reportTypes.Add(CustomerReportType.LocationsDirectory, GetType(Reports.CustomerLocationsDirectory))
            reportTypes.Add(CustomerReportType.SalesSummary, GetType(Reports.CustomerSalesSummaryReport))
            reportTypes.Add(CustomerReportType.SalesDetail, GetType(Reports.CustomerSalesDetailReport))
            reportTypes.Add(ProductReportType.SpecificationSummary, GetType(Reports.ProductProfile))
            reportTypes.Add(ProductReportType.OrderDetail, GetType(Reports.ProductOrders))
            reportTypes.Add(ProductReportType.SalesSummary, GetType(Reports.ProductSalesSummary))
            reportTypes.Add(ProductReportType.TopSalesperson, GetType(Reports.ProductTopSalesperson))
            reportTypes.Add(SalesReportType.Invoice, GetType(Reports.SalesInvoice))
            reportTypes.Add(SalesReportType.SalesReport, GetType(Reports.SalesOrdersSummaryReport))
            reportTypes.Add(SalesReportType.SalesByStore, GetType(Reports.SalesAnalysisReport))
        End Sub

        Public Function CreateReport(ByVal reportKey As Object) As Object Implements IReportActivator.CreateReport
            Dim reportType As Type = Nothing
            If reportTypes.TryGetValue(reportKey, reportType) Then Return Activator.CreateInstance(reportType)
            Throw New ArgumentException("reportKey")
        End Function
    End Class
End Namespace
