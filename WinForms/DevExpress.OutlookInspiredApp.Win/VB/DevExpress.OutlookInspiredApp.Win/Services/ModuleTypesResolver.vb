Namespace DevExpress.DevAV.Services

    Public Interface IModuleTypesResolver

        Function GetName(ByVal moduleType As ModuleType) As String

        Function GetTypeName(ByVal moduleType As ModuleType) As String

        Function GetId(ByVal moduleType As ModuleType) As System.Guid

        Function GetMainModuleType(ByVal type As ModuleType) As ModuleType

        Function GetMapModuleType(ByVal type As ModuleType) As ModuleType

        Function GetMailMergeModuleType(ByVal type As ModuleType) As ModuleType

        Function GetAnalysisModuleType(ByVal type As ModuleType) As ModuleType

        Function GetPeekModuleType(ByVal type As ModuleType) As ModuleType

        Function GetNavPaneModuleType(ByVal type As ModuleType) As ModuleType

        Function GetNavPaneHeaderModuleType(ByVal type As ModuleType) As ModuleType

        Function GetExportModuleType(ByVal type As ModuleType) As ModuleType

        Function GetPrintModuleType(ByVal type As ModuleType) As ModuleType

    End Interface

    Friend Class ModuleTypesResolver
        Implements IModuleTypesResolver

        Public Function GetName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetName
            If moduleType = ModuleType.Unknown Then Return Nothing
            Return moduleType.ToString()
        End Function

        Public Function GetTypeName(ByVal moduleType As ModuleType) As String Implements IModuleTypesResolver.GetTypeName
            If moduleType = ModuleType.Unknown Then Return Nothing
            Return moduleType.ToString()
        End Function

        Public Function GetId(ByVal moduleType As ModuleType) As System.Guid Implements IModuleTypesResolver.GetId
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesPeek, ModuleType.EmployeesFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a2")
                Case ModuleType.Customers, ModuleType.CustomersPeek, ModuleType.CustomersFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a3")
                Case ModuleType.Products, ModuleType.ProductsPeek, ModuleType.ProductsFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a4")
                Case ModuleType.Orders, ModuleType.OrdersPeek, ModuleType.OrdersFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a5")
                Case ModuleType.Quotes, ModuleType.QuotesPeek, ModuleType.QuotesFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a6")
                Case ModuleType.Tasks, ModuleType.TasksPeek, ModuleType.TasksFilterPane
                    Return New System.Guid("f4e3551d-6679-4db6-a103-1e25d7bc83a7")
                Case Else
                    Return System.Guid.Empty
            End Select
        End Function

        Public Function GetMainModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMainModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesPeek, ModuleType.EmployeesFilterPane
                    Return ModuleType.Employees
                Case ModuleType.Customers, ModuleType.CustomersPeek, ModuleType.CustomersFilterPane
                    Return ModuleType.Customers
                Case ModuleType.Products, ModuleType.ProductsPeek, ModuleType.ProductsFilterPane
                    Return ModuleType.Products
                Case ModuleType.Orders, ModuleType.OrdersPeek, ModuleType.OrdersFilterPane
                    Return ModuleType.Orders
                Case ModuleType.Quotes, ModuleType.QuotesPeek, ModuleType.QuotesFilterPane
                    Return ModuleType.Quotes
                Case ModuleType.Tasks, ModuleType.TasksPeek, ModuleType.TasksFilterPane
                    Return ModuleType.Tasks
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetMapModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMapModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeeEditView
                    Return ModuleType.EmployeeMapView
                Case ModuleType.Customers, ModuleType.CustomerEditView
                    Return ModuleType.CustomerMapView
                Case ModuleType.Products, ModuleType.ProductEditView
                    Return ModuleType.ProductMapView
                Case ModuleType.Orders, ModuleType.OrderEditView
                    Return ModuleType.OrderMapView
                Case ModuleType.Quotes, ModuleType.QuoteEditView
                    Return ModuleType.QuoteMapView
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetMailMergeModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetMailMergeModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeeEditView
                    Return ModuleType.EmployeeMailMerge
                Case ModuleType.Orders, ModuleType.OrderEditView
                    Return ModuleType.OrderMailMerge
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetAnalysisModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetAnalysisModuleType
            Select Case moduleType
                Case ModuleType.Customers, ModuleType.CustomerEditView
                    Return ModuleType.CustomerAnalysis
                Case ModuleType.Products, ModuleType.ProductEditView
                    Return ModuleType.ProductAnalysis
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetPeekModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetPeekModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesPeek, ModuleType.EmployeesFilterPane
                    Return ModuleType.EmployeesPeek
                Case ModuleType.Customers, ModuleType.CustomersPeek, ModuleType.CustomersFilterPane
                    Return ModuleType.CustomersPeek
                Case ModuleType.Products, ModuleType.ProductsPeek, ModuleType.ProductsFilterPane
                    Return ModuleType.ProductsPeek
                Case ModuleType.Orders, ModuleType.OrdersPeek, ModuleType.OrdersFilterPane
                    Return ModuleType.OrdersPeek
                Case ModuleType.Quotes, ModuleType.QuotesPeek, ModuleType.QuotesFilterPane
                    Return ModuleType.QuotesPeek
                Case ModuleType.Tasks, ModuleType.TasksPeek, ModuleType.TasksFilterPane
                    Return ModuleType.TasksPeek
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetNavPaneModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetNavPaneModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesPeek, ModuleType.EmployeesFilterPane
                    Return ModuleType.EmployeesFilterPane
                Case ModuleType.Customers, ModuleType.CustomersPeek, ModuleType.CustomersFilterPane
                    Return ModuleType.CustomersFilterPane
                Case ModuleType.Products, ModuleType.ProductsPeek, ModuleType.ProductsFilterPane
                    Return ModuleType.ProductsFilterPane
                Case ModuleType.Orders, ModuleType.OrdersPeek, ModuleType.OrdersFilterPane
                    Return ModuleType.OrdersFilterPane
                Case ModuleType.Quotes, ModuleType.QuotesPeek, ModuleType.QuotesFilterPane
                    Return ModuleType.QuotesFilterPane
                Case ModuleType.Tasks, ModuleType.TasksPeek, ModuleType.TasksFilterPane
                    Return ModuleType.TasksFilterPane
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetNavPaneHeaderModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetNavPaneHeaderModuleType
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesFilterPane
                    Return ModuleType.EmployeesFilterPaneCollapsed
                Case ModuleType.Customers, ModuleType.CustomersFilterPane
                    Return ModuleType.CustomersFilterPaneCollapsed
                Case ModuleType.Products, ModuleType.ProductsFilterPane
                    Return ModuleType.ProductsFilterPaneCollapsed
                Case ModuleType.Orders, ModuleType.OrdersFilterPane
                    Return ModuleType.OrdersFilterPaneCollapsed
                Case ModuleType.Quotes, ModuleType.QuotesFilterPane
                    Return ModuleType.QuotesFilterPaneCollapsed
                Case ModuleType.Tasks, ModuleType.TasksFilterPane
                    Return ModuleType.TasksFilterPaneCollapsed
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetExportModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetExportModuleType
            Select Case moduleType
                Case ModuleType.Employees
                    Return ModuleType.EmployeesExport
                Case ModuleType.Customers
                    Return ModuleType.CustomersExport
                Case ModuleType.Products
                    Return ModuleType.ProductsExport
                Case ModuleType.Orders
                    Return ModuleType.OrdersExport
                Case ModuleType.Quotes
                    Return ModuleType.QuotesExport
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function

        Public Function GetPrintModuleType(ByVal moduleType As ModuleType) As ModuleType Implements IModuleTypesResolver.GetPrintModuleType
            Select Case moduleType
                Case ModuleType.Employees
                    Return ModuleType.EmployeesPrint
                Case ModuleType.Customers
                    Return ModuleType.CustomersPrint
                Case ModuleType.Products
                    Return ModuleType.ProductsPrint
                Case ModuleType.Orders
                    Return ModuleType.OrdersPrint
                Case ModuleType.Quotes
                    Return ModuleType.QuotesPrint
                Case Else
                    Return ModuleType.Unknown
            End Select
        End Function
    End Class
End Namespace
