Imports DevExpress.DemoData.Models.Mapping
Imports DevExpress.Internal
Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports System.Data.SQLite
Imports System.IO
Imports System.Linq
Imports DevExpress.DemoData.Models

Namespace DevExpress.DemoData

    Public MustInherit Class DataLoaderBase

        Protected Sub LoadIfNeed(ByRef checkFlag As Boolean, ByVal target As System.Linq.IQueryable)
            If Not checkFlag Then
                target.Load()
                checkFlag = True
            End If
        End Sub
    End Class

    Public Class NWindDataLoader
        Inherits DevExpress.DemoData.DataLoaderBase

        Private context As DevExpress.DemoData.Models.NWindContext

        Public Sub New()
            If Not DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Me.context = DevExpress.DemoData.Models.NWindContext.Create()
        End Sub

        Public ReadOnly Property Invoices As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Invoice)()
                Return Me.context.Invoices.OrderBy(Function(i) i.OrderID).ToList()
            End Get
        End Property

        Public ReadOnly Property ObservableInvoices As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Invoice)()
                Return New System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DemoData.Models.Invoice)(Me.context.Invoices.OrderBy(Function(i) i.OrderID))
            End Get
        End Property

        Public ReadOnly Property ObservableInvoices200 As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Invoice)()
                Return New System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DemoData.Models.Invoice)(Me.context.Invoices.Take(200).OrderBy(Function(i) i.OrderID))
            End Get
        End Property

        Public ReadOnly Property Customers As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Customer)()
                Me.context.Customers.Load()
                Return Me.context.Customers.Local
            End Get
        End Property

        Public ReadOnly Property Employees As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Employee)()
                Me.context.Employees.Load()
                Return Me.context.Employees.Local
            End Get
        End Property

        Public ReadOnly Property SalesPersons As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.SalesPerson)()
                Me.context.SalesPersons.Load()
                Return Me.context.SalesPersons.Local
            End Get
        End Property

        Public ReadOnly Property EmployeesWithOrdersAndOrderDetails As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Employee)()
                System.Data.Entity.QueryableExtensions.Include(Of DevExpress.DemoData.Models.Employee, Global.System.Collections.Generic.IEnumerable(Of Global.System.Collections.Generic.ICollection(Of Global.DevExpress.DemoData.Models.OrderDetailsExtended)))(Me.context.Employees, CType((Function(x) CType((System.Linq.Enumerable.[Select](Of DevExpress.DemoData.Models.Order, Global.System.Collections.Generic.ICollection(Of Global.DevExpress.DemoData.Models.OrderDetailsExtended))(x.Orders, CType((Function(y) CType((y.OrderDetails), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))), System.Func(Of DevExpress.DemoData.Models.Order, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))))), System.Collections.Generic.IEnumerable(Of System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended)))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Collections.Generic.IEnumerable(Of System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended)))))).Load()
                Return Me.context.Employees.Local
            End Get
        End Property

        Public ReadOnly Property Products As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Product)()
                Me.context.Products.Load()
                Return Me.context.Products.Local
            End Get
        End Property

        Public ReadOnly Property Categories As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Category)()
                Me.context.Categories.Load()
                Return Me.context.Categories.Local
            End Get
        End Property

        Public ReadOnly Property OrderDetails As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.OrderDetail)()
                Me.context.OrderDetails.Load()
                Return Me.context.OrderDetails.Local
            End Get
        End Property

        Public ReadOnly Property OrderDetailsExtended As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.OrderDetailsExtended)()
                Me.context.OrderDetailsExtended.Load()
                Return Me.context.OrderDetailsExtended.Local
            End Get
        End Property

        Public ReadOnly Property Orders As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.Order)()
                Me.context.Orders.Load()
                Return Me.context.Orders.Local
            End Get
        End Property

        Public Shared ReadOnly Property Titles As List(Of String)
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of String)()
                Return DevExpress.DemoData.Models.NWindContext.Create().Employees.[Select](Function(e) e.Title).Distinct().ToList()
            End Get
        End Property

        Public Shared ReadOnly Property Countries As String()
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New String(-1) {}
                Return DevExpress.DemoData.Models.NWindContext.Create().CountriesArray
            End Get
        End Property

        Public ReadOnly Property ProductReports As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.ProductReport)()
                Me.context.ProductReports.Load()
                Return Me.context.ProductReports.Local
            End Get
        End Property

        Public ReadOnly Property OrderReports As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.OrderReport)()
                Me.context.OrderReports.Load()
                Return Me.context.OrderReports.Local
            End Get
        End Property

        Public ReadOnly Property CustomerReports As Object
            Get
                If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then Return New System.Collections.Generic.List(Of DevExpress.DemoData.Models.CustomerReport)()
                Me.context.CustomerReports.Load()
                Return Me.context.CustomerReports.Local
            End Get
        End Property
    End Class

    Public Module NWindDataProvider

        Public ReadOnly Property Employees As IList(Of DevExpress.DemoData.Models.Employee)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().Employees, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.Employee))
            End Get
        End Property

        Public ReadOnly Property Customers As IList(Of DevExpress.DemoData.Models.Customer)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().Customers, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.Customer))
            End Get
        End Property

        Public ReadOnly Property Invoices As IList(Of DevExpress.DemoData.Models.Invoice)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().Invoices, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.Invoice))
            End Get
        End Property

        Public ReadOnly Property InvoicesUpToDate As IList(Of DevExpress.DemoData.Models.Invoice)
            Get
                Dim invoices = DevExpress.DemoData.NWindDataProvider.Invoices
                Dim correction =(System.DateTime.Today - System.Linq.Enumerable.Max(Of System.Nullable(Of Global.System.DateTime))(System.Linq.Enumerable.[Select](Of DevExpress.DemoData.Models.Invoice, Global.System.Nullable(Of Global.System.DateTime))(invoices, CType((Function(x) CType((x.OrderDate), System.DateTime?)), System.Func(Of DevExpress.DemoData.Models.Invoice, System.DateTime?))))).Value.Days
                For Each invoice In invoices
                    invoice.OrderDate = invoice.OrderDate.Value.AddDays(correction)
                Next

                Return invoices
            End Get
        End Property

        Public ReadOnly Property Products As IList(Of DevExpress.DemoData.Models.Product)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().Products, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.Product))
            End Get
        End Property

        Public ReadOnly Property SalesPersons As IList(Of DevExpress.DemoData.Models.SalesPerson)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().SalesPersons, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.SalesPerson))
            End Get
        End Property

        Public ReadOnly Property ProductReports As IList(Of DevExpress.DemoData.Models.ProductReport)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().ProductReports, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.ProductReport))
            End Get
        End Property

        Public ReadOnly Property OrderReports As IList(Of DevExpress.DemoData.Models.OrderReport)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().OrderReports, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.OrderReport))
            End Get
        End Property

        Public ReadOnly Property CustomerReports As IList(Of DevExpress.DemoData.Models.CustomerReport)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().CustomerReports, System.Collections.Generic.IList(Of DevExpress.DemoData.Models.CustomerReport))
            End Get
        End Property

        Public ReadOnly Property ObservableInvoices200 As System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DemoData.Models.Invoice)
            Get
                Return CType(New DevExpress.DemoData.NWindDataLoader().ObservableInvoices200, System.Collections.ObjectModel.ObservableCollection(Of DevExpress.DemoData.Models.Invoice))
            End Get
        End Property
    End Module
End Namespace

' NWindContext.cs
Namespace DevExpress.DemoData.Models

    Friend NotInheritable Class DbContextPreloader(Of T As {System.Data.Entity.DbContext, New})

        Private Shared task As System.Threading.Tasks.Task

        Shared Sub New()
            Dim action As System.Action = Nothing
            If DevExpress.Mvvm.ViewModelBase.IsInDesignMode Then
                action = Sub()
                End Sub
            Else
                action = Sub()
                    Dim context = New T()
                    Dim prop = GetType(T).GetProperties().Where(Function(p) p.PropertyType.IsGenericType AndAlso p.PropertyType.GetGenericTypeDefinition() Is GetType(System.Data.Entity.DbSet(Of ))).FirstOrDefault()
                    If prop Is Nothing Then Return
                    Dim query = CType(prop.GetValue(context, Nothing), System.Linq.IQueryable(Of Object))
                    query.Count()
                End Sub
            End If

            DevExpress.DemoData.Models.DbContextPreloader(Of T).task = New System.Threading.Tasks.TaskFactory().StartNew(action)
        End Sub

        Public Shared Function Preload() As System.Threading.Tasks.Task
            Return DevExpress.DemoData.Models.DbContextPreloader(Of T).task
        End Function
    End Class

    Public Partial Class NWindContext
        Inherits System.Data.Entity.DbContext

        Public Sub New()
            MyBase.New(DevExpress.DemoData.Models.NWindContext.CreateConnection(), True)
        End Sub

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub

        Public Sub New(ByVal connection As System.Data.Common.DbConnection)
            MyBase.New(connection, True)
        End Sub

        Shared Sub New()
            Call System.Data.Entity.Database.SetInitializer(Of DevExpress.DemoData.Models.NWindContext)(Nothing)
        End Sub

        Private Shared filePath As String

        Private Shared Function CreateConnection() As DbConnection
            If Equals(DevExpress.DemoData.Models.NWindContext.filePath, Nothing) Then DevExpress.DemoData.Models.NWindContext.filePath = DevExpress.Internal.DataDirectoryHelper.GetFile("nwind.db", DevExpress.Internal.DataDirectoryHelper.DataFolderName)
            Try
                Dim attributes = System.IO.File.GetAttributes(DevExpress.DemoData.Models.NWindContext.filePath)
                If attributes.HasFlag(System.IO.FileAttributes.[ReadOnly]) Then
                    Call System.IO.File.SetAttributes(DevExpress.DemoData.Models.NWindContext.filePath, attributes And Not System.IO.FileAttributes.[ReadOnly])
                End If
            Catch
            End Try

            Dim connection = System.Data.Common.DbProviderFactories.GetFactory(CStr(("System.Data.SQLite.EF6"))).CreateConnection()
            connection.ConnectionString = New System.Data.SQLite.SQLiteConnectionStringBuilder With {.DataSource = DevExpress.DemoData.Models.NWindContext.filePath}.ConnectionString
            Return connection
        End Function

        Public Overrides Function SaveChanges() As Integer
            Throw New System.Exception("Readonly context")
        End Function

        Public Shared Function Preload() As System.Threading.Tasks.Task
            Return DevExpress.DemoData.Models.DbContextPreloader(Of DevExpress.DemoData.Models.NWindContext).Preload()
        End Function

        Public Shared Function Create() As NWindContext
            Call DevExpress.DemoData.Models.NWindContext.Preload().Wait()
            Return New DevExpress.DemoData.Models.NWindContext()
        End Function

        Public Property Categories As DbSet(Of DevExpress.DemoData.Models.Category)

        Public Property Customers As DbSet(Of DevExpress.DemoData.Models.Customer)

        Public Property Employees As DbSet(Of DevExpress.DemoData.Models.Employee)

        Public Property EmployeeTerritories As DbSet(Of DevExpress.DemoData.Models.EmployeeTerritory)

        Public Property OrderDetails As DbSet(Of DevExpress.DemoData.Models.OrderDetail)

        Public Property Orders As DbSet(Of DevExpress.DemoData.Models.Order)

        Public Property Products As DbSet(Of DevExpress.DemoData.Models.Product)

        Public Property Regions As DbSet(Of DevExpress.DemoData.Models.Region)

        Public Property Shippers As DbSet(Of DevExpress.DemoData.Models.Shipper)

        Public Property Suppliers As DbSet(Of DevExpress.DemoData.Models.Supplier)

        Public Property Territories As DbSet(Of DevExpress.DemoData.Models.Territory)

        Public Property AlphabeticalListOfProducts As DbSet(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct)

        Public Property CategoryProducts As DbSet(Of DevExpress.DemoData.Models.CategoryProduct)

        Public Property CurrentProductLists As DbSet(Of DevExpress.DemoData.Models.CurrentProductList)

        Public Property CustomerAndSuppliersByCities As DbSet(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity)

        Public Property CustomerReports As DbSet(Of DevExpress.DemoData.Models.CustomerReport)

        Public Property Invoices As DbSet(Of DevExpress.DemoData.Models.Invoice)

        Public Property OrderDetailsExtended As DbSet(Of DevExpress.DemoData.Models.OrderDetailsExtended)

        Public Property OrderReports As DbSet(Of DevExpress.DemoData.Models.OrderReport)

        Public Property OrdersQries As DbSet(Of DevExpress.DemoData.Models.OrdersQry)

        Public Property OrderSubtotals As DbSet(Of DevExpress.DemoData.Models.OrderSubtotal)

        Public Property ProductReports As DbSet(Of DevExpress.DemoData.Models.ProductReport)

        Public Property ProductsAboveAveragePrices As DbSet(Of DevExpress.DemoData.Models.ProductsAboveAveragePrice)

        Public Property ProductsByCategories As DbSet(Of DevExpress.DemoData.Models.ProductsByCategory)

        Public Property SalesByCategories As DbSet(Of DevExpress.DemoData.Models.SalesByCategory)

        Public Property SalesPersons As DbSet(Of DevExpress.DemoData.Models.SalesPerson)

        Public Property SalesTotalsByAmounts As DbSet(Of DevExpress.DemoData.Models.SalesTotalsByAmount)

        Public Property SummaryOfSalesByQuarters As DbSet(Of DevExpress.DemoData.Models.SummaryOfSalesByQuarter)

        Public Property SummaryOfSalesByYears As DbSet(Of DevExpress.DemoData.Models.SummaryOfSalesByYear)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As System.Data.Entity.DbModelBuilder)
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CategoryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CustomerMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.EmployeeMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.EmployeeTerritoryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrderDetailMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrderMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.ProductMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.RegionMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.ShipperMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SupplierMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.TerritoryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.AlphabeticalListOfProductMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CategoryProductMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CurrentProductListMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CustomerAndSuppliersByCityMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.CustomerReportMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.InvoiceMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrderDetailsExtendedMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrderReportMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrdersQryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.OrderSubtotalMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.ProductReportMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.ProductsAboveAveragePriceMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.ProductsByCategoryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SalesByCategoryMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SalesPersonMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SalesTotalsByAmountMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SummaryOfSalesByQuarterMap())
            modelBuilder.Configurations.Add(New DevExpress.DemoData.Models.Mapping.SummaryOfSalesByYearMap())
        End Sub

        Public CountriesArray As String() = {"United States", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands", "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Lucia", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis", "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)", "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"}
    End Class
End Namespace

' AlphabeticalListOfProduct.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class AlphabeticalListOfProduct

        Public Property ProductID As Long

        Public Property ProductName As String

        Public Property SupplierID As Nullable(Of Long)

        Public Property CategoryID As Nullable(Of Long)

        Public Property QuantityPerUnit As String

        Public Property UnitPrice As Nullable(Of Decimal)

        Public Property UnitsInStock As Nullable(Of Short)

        Public Property UnitsOnOrder As Nullable(Of Short)

        Public Property ReorderLevel As Nullable(Of Short)

        Public Property Discontinued As Boolean

        Public Property EAN13 As String

        Public Property CategoryName As String
    End Class
End Namespace

' Category.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Category

        Public Property CategoryID As Long

        Public Property CategoryName As String

        Public Property Description As String

        Public Property Picture As Byte()

        Public Property Icon25 As Byte()

        Public Property Icon17 As Byte()

        Public Overridable Property Products As ICollection(Of DevExpress.DemoData.Models.Product)
    End Class
End Namespace

' CategoryProduct.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class CategoryProduct

        Public Property ProductID As Long

        Public Property SupplierID As Nullable(Of Long)

        Public Property ProductName As String

        Public Property CategoryName As String

        Public Property Picture As Byte()

        Public Property Description As String
    End Class
End Namespace

' CurrentProductList.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class CurrentProductList

        Public Property ProductID As Long

        Public Property ProductName As String
    End Class
End Namespace

' Customer.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Customer

        Public Property CustomerID As String

        Public Property CompanyName As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property Phone As String

        Public Property Fax As String

        Public Overridable Property Employees As ICollection(Of DevExpress.DemoData.Models.Employee)

        Public Overridable Property Orders As ICollection(Of DevExpress.DemoData.Models.Order)
    End Class
End Namespace

' CustomerAndSuppliersByCity.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class CustomerAndSuppliersByCity

        Public Property City As String

        Public Property CompanyName As String

        Public Property ContactName As String
    End Class
End Namespace

' CustomerReport.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class CustomerReport

        Public Property ProductName As String

        Public Property CompanyName As String

        Public Property OrderDate As Nullable(Of System.DateTime)

        Public Property ProductAmount As Decimal
    End Class
End Namespace

' Employee.cs
Namespace DevExpress.DemoData.Models

    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Style", "DXCA003", Justification:="VB Convertion")>
    Public Partial Class Employee
        Inherits DevExpress.Mvvm.BindableBase

        Private _EmployeeID As Long

        Public Property EmployeeID As Long
            Get
                Return Me._EmployeeID
            End Get

            Set(ByVal value As Long)
                SetProperty(Me._EmployeeID, value, "EmployeeID")
            End Set
        End Property

        Private _LastName As String

        Public Property LastName As String
            Get
                Return Me._LastName
            End Get

            Set(ByVal value As String)
                SetProperty(Me._LastName, value, "LastName")
            End Set
        End Property

        Private _FirstName As String

        Public Property FirstName As String
            Get
                Return Me._FirstName
            End Get

            Set(ByVal value As String)
                SetProperty(Me._FirstName, value, "FirstName")
            End Set
        End Property

        Private _Title As String

        Public Property Title As String
            Get
                Return Me._Title
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Title, value, "Title")
            End Set
        End Property

        Private _TitleOfCourtesy As String

        Public Property TitleOfCourtesy As String
            Get
                Return Me._TitleOfCourtesy
            End Get

            Set(ByVal value As String)
                SetProperty(Me._TitleOfCourtesy, value, "TitleOfCourtesy")
            End Set
        End Property

        Private _BirthDate As System.Nullable(Of System.DateTime)

        Public Property BirthDate As Nullable(Of System.DateTime)
            Get
                Return Me._BirthDate
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                SetProperty(Me._BirthDate, value, "BirthDate")
            End Set
        End Property

        Private _HireDate As System.Nullable(Of System.DateTime)

        Public Property HireDate As Nullable(Of System.DateTime)
            Get
                Return Me._HireDate
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                SetProperty(Me._HireDate, value, "HireDate")
            End Set
        End Property

        Private _Address As String

        Public Property Address As String
            Get
                Return Me._Address
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Address, value, "Address")
            End Set
        End Property

        Private _City As String

        Public Property City As String
            Get
                Return Me._City
            End Get

            Set(ByVal value As String)
                SetProperty(Me._City, value, "City")
            End Set
        End Property

        Private _Region As String

        Public Property Region As String
            Get
                Return Me._Region
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Region, value, "Region")
            End Set
        End Property

        Private _PostalCode As String

        Public Property PostalCode As String
            Get
                Return Me._PostalCode
            End Get

            Set(ByVal value As String)
                SetProperty(Me._PostalCode, value, "PostalCode")
            End Set
        End Property

        Private _Country As String

        Public Property Country As String
            Get
                Return Me._Country
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Country, value, "Country")
            End Set
        End Property

        Private _HomePhone As String

        Public Property HomePhone As String
            Get
                Return Me._HomePhone
            End Get

            Set(ByVal value As String)
                SetProperty(Me._HomePhone, value, "HomePhone")
            End Set
        End Property

        Private _Extension As String

        Public Property Extension As String
            Get
                Return Me._Extension
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Extension, value, "Extension")
            End Set
        End Property

        Private _Photo As Byte()

        Public Property Photo As Byte()
            Get
                Return Me._Photo
            End Get

            Set(ByVal value As Byte())
                SetProperty(Me._Photo, value, "Photo")
            End Set
        End Property

        Private _Notes As String

        Public Property Notes As String
            Get
                Return Me._Notes
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Notes, value, "Notes")
            End Set
        End Property

        Private _ReportsTo As System.Nullable(Of Long)

        Public Property ReportsTo As Nullable(Of Long)
            Get
                Return Me._ReportsTo
            End Get

            Set(ByVal value As Nullable(Of Long))
                SetProperty(Me._ReportsTo, value, "ReportsTo")
            End Set
        End Property

        Private _Email As String

        Public Property Email As String
            Get
                Return Me._Email
            End Get

            Set(ByVal value As String)
                SetProperty(Me._Email, value, "Email")
            End Set
        End Property

        Private _GroupName As String

        Public Property GroupName As String
            Get
                Return Me._GroupName
            End Get

            Set(ByVal value As String)
                SetProperty(Me._GroupName, value, "GroupName")
            End Set
        End Property

        Private _FullName As String = Nothing

        Public ReadOnly Property FullName As String
            Get
                If Equals(Me._FullName, Nothing) Then Me._FullName = System.[String].Format("{0} {1}", Me.FirstName, Me.LastName)
                Return Me._FullName
            End Get
        End Property

        Public Overridable Property Customers As ICollection(Of DevExpress.DemoData.Models.Customer)

        Public Overridable Property Orders As ICollection(Of DevExpress.DemoData.Models.Order)

        Public Overridable Property Employees As ICollection(Of DevExpress.DemoData.Models.Employee)

        Public Overridable Property SubEmployee As Employee

        Public ReadOnly Property PageHeader As String
            Get
                Return(Me.FirstName & " " & Me.LastName).ToUpper()
            End Get
        End Property

        Public ReadOnly Property PageContent As String
            Get
                Return Me.FirstName & " " & Me.LastName & " was born on " & Me.DateToString(Me.BirthDate) & ". Now lives in " & Me.City & ", " & Me.Country & ". " & Me.TitleOfCourtesy & " " & Me.LastName & " holds a position of " & Me.Title & " our " & Me.Region & " deparment, (" & Me.City & " " & Me.Country & "). Joined our company on " & Me.DateToString(Me.HireDate) & "."
            End Get
        End Property

        Private Function DateToString(ByVal [date] As System.DateTime?) As String
            If [date] Is Nothing Then Return Nothing
            Dim Months As String() = {"January", "February", "Marth", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
            Return [date].Value.Day & "th of " & Months([date].Value.Month - 1) & " in " & [date].Value.Year
        End Function

        Private _ChartSource As System.Collections.Generic.IEnumerable(Of DevExpress.DemoData.Models.ChartPoint) = Nothing

        Public ReadOnly Property ChartSource As IEnumerable(Of DevExpress.DemoData.Models.ChartPoint)
            Get
                If Me._ChartSource Is Nothing Then Me.CreateChartSource()
                Return Me._ChartSource
            End Get
        End Property

        Private Sub CreateChartSource()
            Dim list As System.Collections.Generic.IEnumerable(Of DevExpress.DemoData.Models.ChartPoint) =(From o In Me.Orders Group o By __groupByKey1__ = o.OrderDate Into cp = Group Select New DevExpress.DemoData.Models.ChartPoint() With {.ArgumentMember = __groupByKey1__, .Orders = cp.ToList()}).ToList()
            For Each cp As DevExpress.DemoData.Models.ChartPoint In list
                Dim value As Decimal = 0
                For Each order As DevExpress.DemoData.Models.Order In cp.Orders
                    For Each inv As DevExpress.DemoData.Models.OrderDetailsExtended In order.OrderDetails
                        value += inv.Quantity * inv.UnitPrice
                    Next
                Next

                cp.ValueMember = CInt(value)
            Next

            Me._ChartSource = list
        End Sub
    End Class

    Public Class ChartPoint

        Private _ArgumentMember As System.DateTime?

        Public Property ArgumentMember As System.DateTime?
            Get
                Return _ArgumentMember
            End Get

            Friend Set(ByVal value As System.DateTime?)
                _ArgumentMember = value
            End Set
        End Property

        Public Property ValueMember As Integer

        Friend Property Orders As IList(Of DevExpress.DemoData.Models.Order)
    End Class
End Namespace

' EmployeeTerritory.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class EmployeeTerritory

        Public Property EmployeeID As Long

        Public Property TerritoryID As String
    End Class
End Namespace

' InternationalOrder.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class InternationalOrder

        Public Property OrderID As Long

        Public Property CustomsDescription As String

        Public Property ExciseTax As Decimal

        Public Overridable Property Order As Order
    End Class
End Namespace

' Invoice.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Invoice

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Property CustomerID As String

        Public Property CustomerName As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property OrderID As Long

        Public Property OrderDate As Nullable(Of System.DateTime)

        Public Property RequiredDate As Nullable(Of System.DateTime)

        Public Property ShippedDate As Nullable(Of System.DateTime)

        Public Property ShipperName As String

        Public Property ProductID As Long

        Public Property ProductName As String

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Double

        Public Property Freight As Nullable(Of Decimal)
    End Class
End Namespace

' Order.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Order

        Public Property OrderID As Long

        Public Property CustomerID As String

        Public Property EmployeeID As Nullable(Of Long)

        Public Property OrderDate As Nullable(Of System.DateTime)

        Public Property RequiredDate As Nullable(Of System.DateTime)

        Public Property ShippedDate As Nullable(Of System.DateTime)

        Public Property ShipVia As Nullable(Of Long)

        Public Property Freight As Nullable(Of Decimal)

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Overridable Property Employee As Employee

        Public Overridable Property Customer As Customer

        Public Overridable Property OrderDetails As ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended)
    End Class
End Namespace

' OrderDetail.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class OrderDetail

        Public Property OrderID As Long

        Public Property ProductID As Long

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Double
    End Class
End Namespace

' OrderDetailsExtended.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class OrderDetailsExtended

        Public Property OrderID As Long

        Public Property ProductID As Long

        Public Property ProductName As String

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Double

        Public Property ExtendedPrice As Decimal

        Public Overridable Property Order As Order

        Public Overridable Property Product As Product
    End Class
End Namespace

' OrderReport.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class OrderReport

        Public Property OrderID As Long

        Public Property ProductID As Long

        Public Property ProductName As String

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Double

        Public Property ExtendedPrice As Decimal
    End Class
End Namespace

' OrdersQry.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class OrdersQry

        Public Property OrderID As Long

        Public Property CustomerID As String

        Public Property EmployeeID As Nullable(Of Long)

        Public Property OrderDate As Nullable(Of System.DateTime)

        Public Property RequiredDate As Nullable(Of System.DateTime)

        Public Property ShippedDate As Nullable(Of System.DateTime)

        Public Property ShipVia As Nullable(Of Long)

        Public Property Freight As Nullable(Of Decimal)

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Property CompanyName As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String
    End Class
End Namespace

' OrderSubtotal.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class OrderSubtotal

        Public Property OrderID As Long
    End Class
End Namespace

' PreviousEmployee.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class PreviousEmployee

        Public Property EmployeeID As Long

        Public Property LastName As String

        Public Property FirstName As String

        Public Property Title As String

        Public Property TitleOfCourtesy As String

        Public Property BirthDate As Nullable(Of System.DateTime)

        Public Property HireDate As Nullable(Of System.DateTime)

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property HomePhone As String

        Public Property Extension As String

        Public Property Photo As Byte()

        Public Property Notes As String

        Public Property PhotoPath As String
    End Class
End Namespace

' Product.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Product

        Public Property ProductID As Long

        Public Property ProductName As String

        Public Property SupplierID As Nullable(Of Long)

        Public Property CategoryID As Nullable(Of Long)

        Public Property QuantityPerUnit As String

        Public Property UnitPrice As Nullable(Of Decimal)

        Public Property UnitsInStock As Nullable(Of Short)

        Public Property UnitsOnOrder As Nullable(Of Short)

        Public Property ReorderLevel As Nullable(Of Short)

        Public Property Discontinued As Boolean

        Public Property EAN13 As String

        Public Overridable Property Category As Category

        Public Overridable Property OrderDetails As ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended)
    End Class
End Namespace

' ProductReport.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class ProductReport

        Public Property CategoryName As String

        Public Property ProductName As String

        Public Property ProductSales As Decimal

        Public Property ShippedDate As Nullable(Of System.DateTime)
    End Class
End Namespace

' ProductsAboveAveragePrice.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class ProductsAboveAveragePrice

        Public Property ProductName As String

        Public Property UnitPrice As Nullable(Of Decimal)
    End Class
End Namespace

' ProductsByCategory.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class ProductsByCategory

        Public Property CategoryName As String

        Public Property ProductName As String

        Public Property QuantityPerUnit As String

        Public Property UnitsInStock As Nullable(Of Short)

        Public Property Discontinued As Boolean
    End Class
End Namespace

' Region.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Region

        Public Property RegionID As Long

        Public Property RegionDescription As String
    End Class
End Namespace

' SalesByCategory.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class SalesByCategory

        Public Property CategoryID As Long

        Public Property CategoryName As String

        Public Property ProductName As String
    End Class
End Namespace

' SalesPerson.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class SalesPerson

        Public Property OrderID As Long

        Public Property Country As String

        Public Property FirstName As String

        Public Property LastName As String

        Public Property ProductName As String

        Public Property CategoryName As String

        Public Property OrderDate As Nullable(Of System.DateTime)

        Public Property UnitPrice As Decimal

        Public Property Quantity As Short

        Public Property Discount As Double

        Public Property ExtendedPrice As Decimal

        Public Property FullName As String
    End Class
End Namespace

' SalesTotalsByAmount.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class SalesTotalsByAmount

        Public Property OrderID As Long

        Public Property CompanyName As String

        Public Property ShippedDate As Nullable(Of System.DateTime)
    End Class
End Namespace

' Shipper.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Shipper

        Public Property ShipperID As Long

        Public Property CompanyName As String

        Public Property Phone As String
    End Class
End Namespace

' SummaryOfSalesByQuarter.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class SummaryOfSalesByQuarter

        Public Property ShippedDate As Nullable(Of System.DateTime)

        Public Property OrderID As Long
    End Class
End Namespace

' SummaryOfSalesByYear.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class SummaryOfSalesByYear

        Public Property ShippedDate As Nullable(Of System.DateTime)

        Public Property OrderID As Long
    End Class
End Namespace

' Supplier.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Supplier

        Public Property SupplierID As Long

        Public Property CompanyName As String

        Public Property ContactName As String

        Public Property ContactTitle As String

        Public Property Address As String

        Public Property City As String

        Public Property Region As String

        Public Property PostalCode As String

        Public Property Country As String

        Public Property Phone As String

        Public Property Fax As String

        Public Property HomePage As String
    End Class
End Namespace

' Territory.cs
Namespace DevExpress.DemoData.Models

    Public Partial Class Territory

        Public Property TerritoryID As String

        Public Property TerritoryDescription As String

        Public Property RegionID As Long
    End Class
End Namespace

' AlphabeticalListOfProductMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class AlphabeticalListOfProductMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.EAN13))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasMaxLength(2147483647)
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).IsRequired().HasMaxLength(15)
            ' Table & Column Mappings
            Me.ToTable("AlphabeticalListOfProducts")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasColumnName("ProductName")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.SupplierID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int64?)))).HasColumnName("SupplierID")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.CategoryID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int64?)))).HasColumnName("CategoryID")
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasColumnName("QuantityPerUnit")
            Me.[Property](CType((Function(t) CType((t.UnitPrice), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[Decimal]?)))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.UnitsInStock), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int16?)))).HasColumnName("UnitsInStock")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.UnitsOnOrder), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int16?)))).HasColumnName("UnitsOnOrder")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.ReorderLevel), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.Int16?)))).HasColumnName("ReorderLevel")
            Me.[Property](Of System.[Boolean])(CType((Function(t) CBool((t.Discontinued))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[Boolean])))).HasColumnName("Discontinued")
            Me.[Property](CType((Function(t) CStr((t.EAN13))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasColumnName("EAN13")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.AlphabeticalListOfProduct, System.[String])))).HasColumnName("CategoryName")
        End Sub
    End Class
End Namespace

' CategoryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CategoryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Category)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CategoryID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.CategoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Description))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[String])))).HasMaxLength(1073741823)
            Me.[Property](CType((Function(t) CType((t.Picture), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[Byte]())))).HasMaxLength(2147483647)
            ' Table & Column Mappings
            Me.ToTable("Categories")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.CategoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.Int64)))).HasColumnName("CategoryID")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CStr((t.Description))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[String])))).HasColumnName("Description")
            Me.[Property](CType((Function(t) CType((t.Picture), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Category, System.[Byte]())))).HasColumnName("Picture")
        End Sub
    End Class
End Namespace

' CategoryProductMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CategoryProductMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.CategoryProduct)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CType((t.Picture), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[Byte]())))).HasMaxLength(2147483647)
            Me.[Property](CType((Function(t) CStr((t.Description))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).HasMaxLength(1073741823)
            ' Table & Column Mappings
            Me.ToTable("CategoryProducts")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.SupplierID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.Int64?)))).HasColumnName("SupplierID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CType((t.Picture), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[Byte]())))).HasColumnName("Picture")
            Me.[Property](CType((Function(t) CStr((t.Description))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CategoryProduct, System.[String])))).HasColumnName("Description")
        End Sub
    End Class
End Namespace

' CurrentProductListMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CurrentProductListMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.CurrentProductList)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CurrentProductList, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CurrentProductList, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("CurrentProductList")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CurrentProductList, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CurrentProductList, System.[String])))).HasColumnName("ProductName")
        End Sub
    End Class
End Namespace

' CustomerAndSuppliersByCityMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CustomerAndSuppliersByCityMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CompanyName)
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).HasMaxLength(30)
            ' Table & Column Mappings
            Me.ToTable("CustomerAndSuppliersByCity")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerAndSuppliersByCity, System.[String])))).HasColumnName("ContactName")
        End Sub
    End Class
End Namespace

' CustomerMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CustomerMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Customer)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CustomerID)
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).IsRequired().IsFixedLength().HasMaxLength(5)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.ContactTitle))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(24)
            Me.[Property](CType((Function(t) CStr((t.Fax))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasMaxLength(24)
            ' Table & Column Mappings
            Me.ToTable("Customers")
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("CustomerID")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("ContactName")
            Me.[Property](CType((Function(t) CStr((t.ContactTitle))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("ContactTitle")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("Country")
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("Phone")
            Me.[Property](CType((Function(t) CStr((t.Fax))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.[String])))).HasColumnName("Fax")
            Me.HasMany(Of DevExpress.DemoData.Models.Order)(CType((Function(x) CType((x.Orders), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Order))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Order))))).WithOptional(Function(x) x.Customer).HasForeignKey(Function(x) x.CustomerID)
        End Sub
    End Class
End Namespace

' CustomerReportMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class CustomerReportMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.CustomerReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.ProductName, t.CompanyName})
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerReport, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerReport, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("CustomerReports")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerReport, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerReport, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CType((t.OrderDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.CustomerReport, System.DateTime?)))).HasColumnName("OrderDate")
        End Sub
    End Class
End Namespace

' EmployeeMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class EmployeeMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Employee)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.EmployeeID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).IsRequired().HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).IsRequired().HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Title))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.TitleOfCourtesy))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(25)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.HomePhone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(24)
            Me.[Property](CType((Function(t) CStr((t.Extension))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(4)
            Me.[Property](CType((Function(t) CType((t.Photo), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[Byte]())))).HasMaxLength(2147483647)
            Me.[Property](CType((Function(t) CStr((t.Notes))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasMaxLength(1073741823)
            ' Table & Column Mappings
            Me.ToTable("Employees")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Int64)))).HasColumnName("EmployeeID")
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("LastName")
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("FirstName")
            Me.[Property](CType((Function(t) CStr((t.Title))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Title")
            Me.[Property](CType((Function(t) CStr((t.TitleOfCourtesy))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("TitleOfCourtesy")
            Me.[Property](CType((Function(t) CType((t.BirthDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.DateTime?)))).HasColumnName("BirthDate")
            Me.[Property](CType((Function(t) CType((t.HireDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.DateTime?)))).HasColumnName("HireDate")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Country")
            Me.[Property](CType((Function(t) CStr((t.HomePhone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("HomePhone")
            Me.[Property](CType((Function(t) CStr((t.Extension))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Extension")
            Me.[Property](CType((Function(t) CType((t.Photo), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[Byte]())))).HasColumnName("Photo")
            Me.[Property](CType((Function(t) CStr((t.Notes))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("Notes")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.ReportsTo), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Int64?)))).HasColumnName("ReportsTo")
            Me.[Property](CType((Function(t) CStr((t.GroupName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.[String])))).HasColumnName("GroupName")
            Me.HasMany(Of DevExpress.DemoData.Models.Customer)(CType((Function(x) CType((x.Customers), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Customer))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Customer))))).WithMany(CType((Function(x) CType((x.Employees), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Employee))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Customer, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Employee))))).Map(Sub(m)
                m.ToTable("EmployeeCustomers")
                m.MapLeftKey("EmployeeId")
                m.MapRightKey("CustomerId")
            End Sub)
            Me.HasMany(Of DevExpress.DemoData.Models.Employee)(CType((Function(x) CType((x.Employees), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Employee))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Employee))))).WithOptional(Function(x) x.SubEmployee).HasForeignKey(Function(x) x.ReportsTo)
            Me.HasMany(Of DevExpress.DemoData.Models.Order)(CType((Function(x) CType((x.Orders), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Order))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Employee, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.Order))))).WithOptional(Function(x) x.Employee).HasForeignKey(Function(x) x.EmployeeID)
        End Sub
    End Class
End Namespace

' EmployeeTerritoryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class EmployeeTerritoryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.EmployeeTerritory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.EmployeeID, t.TerritoryID})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.EmployeeTerritory, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.TerritoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.EmployeeTerritory, System.[String])))).IsRequired().HasMaxLength(20)
            ' Table & Column Mappings
            Me.ToTable("EmployeeTerritories")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.EmployeeTerritory, System.Int64)))).HasColumnName("EmployeeID")
            Me.[Property](CType((Function(t) CStr((t.TerritoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.EmployeeTerritory, System.[String])))).HasColumnName("TerritoryID")
        End Sub
    End Class
End Namespace

' InvoiceMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class InvoiceMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Invoice)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.CustomerName, t.OrderID, t.ShipperName, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount})
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).IsFixedLength().HasMaxLength(5)
            Me.[Property](CType((Function(t) CStr((t.CustomerName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasMaxLength(15)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ShipperName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[Decimal])))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int16)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("Invoices")
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipName")
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipAddress")
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipCity")
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipRegion")
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipPostalCode")
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipCountry")
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("CustomerID")
            Me.[Property](CType((Function(t) CStr((t.CustomerName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("CustomerName")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("Country")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](CType((Function(t) CType((t.OrderDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.DateTime?)))).HasColumnName("OrderDate")
            Me.[Property](CType((Function(t) CType((t.RequiredDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.DateTime?)))).HasColumnName("RequiredDate")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.DateTime?)))).HasColumnName("ShippedDate")
            Me.[Property](CType((Function(t) CStr((t.ShipperName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ShipperName")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[Decimal])))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.Int16)))).HasColumnName("Quantity")
            Me.[Property](Of System.[Double])(CType((Function(t) CDbl((t.Discount))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[Double])))).HasColumnName("Discount")
            Me.[Property](CType((Function(t) CType((t.Freight), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Invoice, System.[Decimal]?)))).HasColumnName("Freight")
        End Sub
    End Class
End Namespace

' OrderDetailMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrderDetailMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.OrderDetail)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.ProductID, t.UnitPrice, t.Quantity, t.Discount})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.[Decimal])))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int16)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("OrderDetails")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.[Decimal])))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.Int16)))).HasColumnName("Quantity")
            Me.[Property](Of System.[Double])(CType((Function(t) CDbl((t.Discount))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetail, System.[Double])))).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrderDetailsExtendedMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrderDetailsExtendedMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.OrderDetailsExtended)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.[Decimal])))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int16)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("OrderDetailsExtended")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.[Decimal])))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.Int16)))).HasColumnName("Quantity")
            Me.[Property](Of System.[Double])(CType((Function(t) CDbl((t.Discount))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderDetailsExtended, System.[Double])))).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrderMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrderMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Order)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).IsFixedLength().HasMaxLength(5)
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasMaxLength(15)
            ' Table & Column Mappings
            Me.ToTable("Orders")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("CustomerID")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.EmployeeID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.Int64?)))).HasColumnName("EmployeeID")
            Me.[Property](CType((Function(t) CType((t.OrderDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.DateTime?)))).HasColumnName("OrderDate")
            Me.[Property](CType((Function(t) CType((t.RequiredDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.DateTime?)))).HasColumnName("RequiredDate")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.DateTime?)))).HasColumnName("ShippedDate")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.ShipVia), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.Int64?)))).HasColumnName("ShipVia")
            Me.[Property](CType((Function(t) CType((t.Freight), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[Decimal]?)))).HasColumnName("Freight")
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipName")
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipAddress")
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipCity")
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipRegion")
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipPostalCode")
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.[String])))).HasColumnName("ShipCountry")
            Me.HasMany(Of DevExpress.DemoData.Models.OrderDetailsExtended)(CType((Function(x) CType((x.OrderDetails), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Order, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))))).WithRequired(Function(x) x.Order).HasForeignKey(Function(x) x.OrderID)
        End Sub
    End Class
End Namespace

' OrderReportMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrderReportMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.OrderReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.[Decimal])))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int16)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("OrderReports")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.[Decimal])))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.Int16)))).HasColumnName("Quantity")
            Me.[Property](Of System.[Double])(CType((Function(t) CDbl((t.Discount))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderReport, System.[Double])))).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrdersQryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrdersQryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.OrdersQry)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.CompanyName})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).IsFixedLength().HasMaxLength(5)
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasMaxLength(15)
            ' Table & Column Mappings
            Me.ToTable("OrdersQry")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](CType((Function(t) CStr((t.CustomerID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("CustomerID")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.EmployeeID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.Int64?)))).HasColumnName("EmployeeID")
            Me.[Property](CType((Function(t) CType((t.OrderDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.DateTime?)))).HasColumnName("OrderDate")
            Me.[Property](CType((Function(t) CType((t.RequiredDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.DateTime?)))).HasColumnName("RequiredDate")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.DateTime?)))).HasColumnName("ShippedDate")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.ShipVia), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.Int64?)))).HasColumnName("ShipVia")
            Me.[Property](CType((Function(t) CType((t.Freight), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[Decimal]?)))).HasColumnName("Freight")
            Me.[Property](CType((Function(t) CStr((t.ShipName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipName")
            Me.[Property](CType((Function(t) CStr((t.ShipAddress))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipAddress")
            Me.[Property](CType((Function(t) CStr((t.ShipCity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipCity")
            Me.[Property](CType((Function(t) CStr((t.ShipRegion))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipRegion")
            Me.[Property](CType((Function(t) CStr((t.ShipPostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipPostalCode")
            Me.[Property](CType((Function(t) CStr((t.ShipCountry))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("ShipCountry")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrdersQry, System.[String])))).HasColumnName("Country")
        End Sub
    End Class
End Namespace

' OrderSubtotalMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class OrderSubtotalMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.OrderSubtotal)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderSubtotal, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("OrderSubtotals")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.OrderSubtotal, System.Int64)))).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' PreviousEmployeeMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class PreviousEmployeeMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.PreviousEmployee)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.EmployeeID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).IsRequired().HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).IsRequired().HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Title))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.TitleOfCourtesy))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(25)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.HomePhone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(24)
            Me.[Property](CType((Function(t) CStr((t.Extension))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(4)
            Me.[Property](CType((Function(t) CType((t.Photo), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[Byte]())))).HasMaxLength(2147483647)
            Me.[Property](CType((Function(t) CStr((t.Notes))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(2147483647)
            Me.[Property](CType((Function(t) CStr((t.PhotoPath))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasMaxLength(255)
            ' Table & Column Mappings
            Me.ToTable("PreviousEmployees")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.EmployeeID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.Int64)))).HasColumnName("EmployeeID")
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("LastName")
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("FirstName")
            Me.[Property](CType((Function(t) CStr((t.Title))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Title")
            Me.[Property](CType((Function(t) CStr((t.TitleOfCourtesy))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("TitleOfCourtesy")
            Me.[Property](CType((Function(t) CType((t.BirthDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.DateTime?)))).HasColumnName("BirthDate")
            Me.[Property](CType((Function(t) CType((t.HireDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.DateTime?)))).HasColumnName("HireDate")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Country")
            Me.[Property](CType((Function(t) CStr((t.HomePhone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("HomePhone")
            Me.[Property](CType((Function(t) CStr((t.Extension))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Extension")
            Me.[Property](CType((Function(t) CType((t.Photo), System.[Byte]())), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[Byte]())))).HasColumnName("Photo")
            Me.[Property](CType((Function(t) CStr((t.Notes))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("Notes")
            Me.[Property](CType((Function(t) CStr((t.PhotoPath))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.PreviousEmployee, System.[String])))).HasColumnName("PhotoPath")
        End Sub
    End Class
End Namespace

' ProductMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class ProductMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Product)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.EAN13))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).HasMaxLength(2147483647)
            ' Table & Column Mappings
            Me.ToTable("Products")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ProductID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int64)))).HasColumnName("ProductID")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).HasColumnName("ProductName")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.SupplierID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int64?)))).HasColumnName("SupplierID")
            Me.[Property](Of System.Int64)(CType((Function(t) CType((t.CategoryID), System.Int64?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int64?)))).HasColumnName("CategoryID")
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).HasColumnName("QuantityPerUnit")
            Me.[Property](CType((Function(t) CType((t.UnitPrice), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[Decimal]?)))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.UnitsInStock), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int16?)))).HasColumnName("UnitsInStock")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.UnitsOnOrder), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int16?)))).HasColumnName("UnitsOnOrder")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.ReorderLevel), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Int16?)))).HasColumnName("ReorderLevel")
            Me.[Property](Of System.[Boolean])(CType((Function(t) CBool((t.Discontinued))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[Boolean])))).HasColumnName("Discontinued")
            Me.[Property](CType((Function(t) CStr((t.EAN13))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.[String])))).HasColumnName("EAN13")
            Me.HasOptional(Of DevExpress.DemoData.Models.Category)(CType((Function(p) CType((p.Category), DevExpress.DemoData.Models.Category)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, DevExpress.DemoData.Models.Category)))).WithMany(Function(c) c.Products).HasForeignKey(Function(p) p.CategoryID)
            Me.HasMany(Of DevExpress.DemoData.Models.OrderDetailsExtended)(CType((Function(x) CType((x.OrderDetails), System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Product, System.Collections.Generic.ICollection(Of DevExpress.DemoData.Models.OrderDetailsExtended))))).WithRequired(Function(x) x.Product).HasForeignKey(Function(x) x.ProductID)
        End Sub
    End Class
End Namespace

' ProductReportMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class ProductReportMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.ProductReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.CategoryName, t.ProductName, t.ShippedDate})
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("ProductReports")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CDec((t.ProductSales))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.[Decimal])))).HasColumnName("ProductSales")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductReport, System.DateTime?)))).HasColumnName("ShippedDate")
        End Sub
    End Class
End Namespace

' ProductsAboveAveragePriceMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class ProductsAboveAveragePriceMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.ProductsAboveAveragePrice)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductName)
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsAboveAveragePrice, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("ProductsAboveAveragePrice")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsAboveAveragePrice, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CType((t.UnitPrice), System.[Decimal]?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsAboveAveragePrice, System.[Decimal]?)))).HasColumnName("UnitPrice")
        End Sub
    End Class
End Namespace

' ProductsByCategoryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class ProductsByCategoryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.ProductsByCategory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.CategoryName, t.ProductName, t.Discontinued})
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).HasMaxLength(20)
            ' Table & Column Mappings
            Me.ToTable("ProductsByCategory")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CStr((t.QuantityPerUnit))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[String])))).HasColumnName("QuantityPerUnit")
            Me.[Property](Of System.Int16)(CType((Function(t) CType((t.UnitsInStock), System.Int16?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.Int16?)))).HasColumnName("UnitsInStock")
            Me.[Property](Of System.[Boolean])(CType((Function(t) CBool((t.Discontinued))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.ProductsByCategory, System.[Boolean])))).HasColumnName("Discontinued")
        End Sub
    End Class
End Namespace

' RegionMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class RegionMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Region)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.RegionID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.RegionID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Region, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.RegionDescription))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Region, System.[String])))).IsRequired().IsFixedLength().HasMaxLength(50)
            ' Table & Column Mappings
            Me.ToTable("Region")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.RegionID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Region, System.Int64)))).HasColumnName("RegionID")
            Me.[Property](CType((Function(t) CStr((t.RegionDescription))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Region, System.[String])))).HasColumnName("RegionDescription")
        End Sub
    End Class
End Namespace

' SalesByCategoryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SalesByCategoryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.SalesByCategory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CategoryID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.CategoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("SalesByCategory")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.CategoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.Int64)))).HasColumnName("CategoryID")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesByCategory, System.[String])))).HasColumnName("ProductName")
        End Sub
    End Class
End Namespace

' SalesPersonMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SalesPersonMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.SalesPerson)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.FirstName, t.LastName, t.ProductName, t.CategoryName, t.UnitPrice, t.Quantity, t.Discount})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).IsRequired().HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).IsRequired().HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).IsRequired().HasMaxLength(15)
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[Decimal])))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.Int16)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("SalesPerson")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasColumnName("Country")
            Me.[Property](CType((Function(t) CStr((t.FirstName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasColumnName("FirstName")
            Me.[Property](CType((Function(t) CStr((t.LastName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasColumnName("LastName")
            Me.[Property](CType((Function(t) CStr((t.ProductName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasColumnName("ProductName")
            Me.[Property](CType((Function(t) CStr((t.CategoryName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[String])))).HasColumnName("CategoryName")
            Me.[Property](CType((Function(t) CType((t.OrderDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.DateTime?)))).HasColumnName("OrderDate")
            Me.[Property](CType((Function(t) CDec((t.UnitPrice))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[Decimal])))).HasColumnName("UnitPrice")
            Me.[Property](Of System.Int16)(CType((Function(t) CShort((t.Quantity))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.Int16)))).HasColumnName("Quantity")
            Me.[Property](Of System.[Double])(CType((Function(t) CDbl((t.Discount))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesPerson, System.[Double])))).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' SalesTotalsByAmountMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SalesTotalsByAmountMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.SalesTotalsByAmount)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.OrderID, t.CompanyName})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesTotalsByAmount, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesTotalsByAmount, System.[String])))).IsRequired().HasMaxLength(40)
            ' Table & Column Mappings
            Me.ToTable("SalesTotalsByAmount")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesTotalsByAmount, System.Int64)))).HasColumnName("OrderID")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesTotalsByAmount, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SalesTotalsByAmount, System.DateTime?)))).HasColumnName("ShippedDate")
        End Sub
    End Class
End Namespace

' ShipperMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class ShipperMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Shipper)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {t.ShipperID, t.CompanyName})
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ShipperID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.[String])))).HasMaxLength(24)
            ' Table & Column Mappings
            Me.ToTable("Shippers")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.ShipperID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.Int64)))).HasColumnName("ShipperID")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Shipper, System.[String])))).HasColumnName("Phone")
        End Sub
    End Class
End Namespace

' SummaryOfSalesByQuarterMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SummaryOfSalesByQuarterMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.SummaryOfSalesByQuarter)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByQuarter, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("SummaryOfSalesByQuarter")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByQuarter, System.DateTime?)))).HasColumnName("ShippedDate")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByQuarter, System.Int64)))).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' SummaryOfSalesByYearMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SummaryOfSalesByYearMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.SummaryOfSalesByYear)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByYear, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("SummaryOfSalesByYear")
            Me.[Property](CType((Function(t) CType((t.ShippedDate), System.DateTime?)), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByYear, System.DateTime?)))).HasColumnName("ShippedDate")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.OrderID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.SummaryOfSalesByYear, System.Int64)))).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' SupplierMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class SupplierMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Supplier)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.SupplierID)
            ' Properties
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.SupplierID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).IsRequired().HasMaxLength(40)
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.ContactTitle))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(30)
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(60)
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(10)
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(15)
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(24)
            Me.[Property](CType((Function(t) CStr((t.Fax))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(24)
            Me.[Property](CType((Function(t) CStr((t.HomePage))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasMaxLength(1073741823)
            ' Table & Column Mappings
            Me.ToTable("Suppliers")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.SupplierID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.Int64)))).HasColumnName("SupplierID")
            Me.[Property](CType((Function(t) CStr((t.CompanyName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("CompanyName")
            Me.[Property](CType((Function(t) CStr((t.ContactName))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("ContactName")
            Me.[Property](CType((Function(t) CStr((t.ContactTitle))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("ContactTitle")
            Me.[Property](CType((Function(t) CStr((t.Address))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("Address")
            Me.[Property](CType((Function(t) CStr((t.City))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("City")
            Me.[Property](CType((Function(t) CStr((t.Region))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("Region")
            Me.[Property](CType((Function(t) CStr((t.PostalCode))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("PostalCode")
            Me.[Property](CType((Function(t) CStr((t.Country))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("Country")
            Me.[Property](CType((Function(t) CStr((t.Phone))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("Phone")
            Me.[Property](CType((Function(t) CStr((t.Fax))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("Fax")
            Me.[Property](CType((Function(t) CStr((t.HomePage))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Supplier, System.[String])))).HasColumnName("HomePage")
        End Sub
    End Class
End Namespace

' TerritoryMap.cs
Namespace DevExpress.DemoData.Models.Mapping

    Public Class TerritoryMap
        Inherits System.Data.Entity.ModelConfiguration.EntityTypeConfiguration(Of DevExpress.DemoData.Models.Territory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.TerritoryID)
            ' Properties
            Me.[Property](CType((Function(t) CStr((t.TerritoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.[String])))).IsRequired().HasMaxLength(20)
            Me.[Property](CType((Function(t) CStr((t.TerritoryDescription))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.[String])))).IsRequired().IsFixedLength().HasMaxLength(50)
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.RegionID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.Int64)))).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
            ' Table & Column Mappings
            Me.ToTable("Territories")
            Me.[Property](CType((Function(t) CStr((t.TerritoryID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.[String])))).HasColumnName("TerritoryID")
            Me.[Property](CType((Function(t) CStr((t.TerritoryDescription))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.[String])))).HasColumnName("TerritoryDescription")
            Me.[Property](Of System.Int64)(CType((Function(t) CLng((t.RegionID))), System.Linq.Expressions.Expression(Of System.Func(Of DevExpress.DemoData.Models.Territory, System.Int64)))).HasColumnName("RegionID")
        End Sub
    End Class
End Namespace
