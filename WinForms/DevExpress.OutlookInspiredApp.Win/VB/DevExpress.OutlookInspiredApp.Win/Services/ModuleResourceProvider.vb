Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Services

    Public Interface IModuleResourceProvider

        Function GetCaption(ByVal moduleType As ModuleType) As String

        Function GetModuleImageUri(ByVal moduleType As ModuleType, ByVal Optional smallImage As Boolean = False) As String

    End Interface

    Public Class ModuleResourceProvider
        Implements IModuleResourceProvider

        Public Function GetCaption(ByVal moduleType As ModuleType) As String Implements IModuleResourceProvider.GetCaption
            Select Case moduleType
                Case ModuleType.Unknown
                    Return Nothing
                Case ModuleType.EmployeesPeek, ModuleType.EmployeesFilterPane
                    Return "Employees"
                Case ModuleType.CustomersPeek, ModuleType.CustomersFilterPane
                    Return "Customers"
                Case ModuleType.ProductsPeek, ModuleType.ProductsFilterPane
                    Return "Products"
                Case ModuleType.Orders, ModuleType.OrdersFilterPane
                    Return "Sales"
                Case ModuleType.Quotes, ModuleType.QuotesFilterPane
                    Return "Opportunities"
                Case ModuleType.Tasks, ModuleType.TasksFilterPane
                    Return "Tasks"
                Case Else
                    Return moduleType.ToString()
            End Select
        End Function

        Public Overridable Function GetModuleImageUri(ByVal moduleType As ModuleType, ByVal Optional smallImage As Boolean = False) As String Implements IModuleResourceProvider.GetModuleImageUri
            Select Case moduleType
                Case ModuleType.Employees, ModuleType.EmployeesFilterPane
                    Return If(smallImage, GetFluentIconName("business%20objects/bo_position;Size16x16"), GetFluentIconName("business%20objects/bo_position"))
                Case ModuleType.Customers, ModuleType.CustomersFilterPane
                    Return If(smallImage, GetFluentIconName("business%20objects/bo_customer;Size16x16"), GetFluentIconName("business%20objects/bo_customer"))
                Case ModuleType.Products, ModuleType.ProductsFilterPane
                    Return If(smallImage, GetFluentIconName("business%20objects/bo_product;Size16x16"), GetFluentIconName("business%20objects/bo_product"))
                Case ModuleType.Orders, ModuleType.OrdersFilterPane
                    Return If(smallImage, GetFluentIconName("business%20objects/bo_sale;Size16x16"), GetFluentIconName("business%20objects/bo_sale"))
                Case ModuleType.Quotes, ModuleType.QuotesFilterPane
                    Return If(smallImage, GetFluentIconName("business%20objects/bo_opportunity;Size16x16"), GetFluentIconName("business%20objects/bo_opportunity"))
                Case ModuleType.Tasks, ModuleType.TasksFilterPane
                    Return If(smallImage, GetFluentIconName("resource://DevExpress.DevAV.Resources.Modules.Tasks.svg?Size=16x16"), GetFluentIconName("resource://DevExpress.DevAV.Resources.Modules.Tasks.svg"))
                Case ModuleType.Unknown
                    Return Nothing
                Case Else
                    Return Nothing
            End Select
        End Function
    End Class
End Namespace
