Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace DevExpress.Xpo.Demos
    <OptimisticLocking(False)> _
    Public Class Shippers
        Inherits XPBaseObject
        Public CompanyName As String
        Public Phone As String
        <Key()> _
        Public ShipperID As Integer
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Suppliers
        Inherits XPBaseObject
        Public Address As String
        Public City As String
        Public CompanyName As String
        Public ContactName As String
        Public ContactTitle As String
        Public Country As String
        Public Fax As String
        Public HomePage As String
        Public Phone As String
        Public PostalCode As String
        Public Region As String
        <Association("Product_Supplier", GetType(Products))> _
        Public ReadOnly Property Products() As XPCollection
            Get
                Return GetCollection(NameOf(Products))
            End Get
        End Property
        <Key()> _
        Public SupplierID As Integer
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    Public Structure OrderDetailsKey
        <Association("Order_OrderDetail"), Persistent("OrderID")> _
        Public OrderID As Orders
        <Persistent("ProductID")> _
        Public ProductID As Products
    End Structure

    <OptimisticLocking(False), Persistent("Order Details")> _
    Public Class OrderDetails
        Inherits XPBaseObject
        Public Discount As System.Single
        <Key(), Persistent()> _
        Public Key As OrderDetailsKey
        Public Quantity As Short
        Public UnitPrice As Decimal
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Employees
        Inherits XPBaseObject
        Public Address As String
        Public BirthDate As DateTime
        Public City As String
        Public Country As String
        <Key()> _
        Public EmployeeID As Integer
        Public Extension As String
        Public FirstName As String
        Public HireDate As DateTime
        Public HomePhone As String
        Public LastName As String
        Public Notes As String
        Public Photo As Byte()
        Public PostalCode As String
        Public Region As String
        Public ReportsTo As Integer
        Public Title As String
        Public TitleOfCourtesy As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Orders
        Inherits XPBaseObject
        Public CustomerID As Customers
        Public EmployeeID As Employees
        Public Freight As Decimal
        Public OrderDate As DateTime
        <Key()> _
        Public OrderID As Integer
        Public RequiredDate As DateTime
        Public ShipAddress As String
        Public ShipCity As String
        Public ShipCountry As String
        Public ShipName As String
        Public ShippedDate As DateTime
        Public ShipPostalCode As String
        Public ShipRegion As String
        Public ShipVia As Shippers
        <Association("Order_OrderDetail", GetType(OrderDetails))> _
        Public ReadOnly Property OrderDetails() As XPCollection
            Get
                Return GetCollection(NameOf(OrderDetails))
            End Get
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Categories
        Inherits XPBaseObject
        <Key()> _
        Public CategoryID As Integer
        Public CategoryName As String
        Public Description As String
        Public Picture As Byte()
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Products
        Inherits XPBaseObject
        Public CategoryID As Categories
        Public Discontinued As Boolean
        Public EAN13 As String
        <Key()> _
        Public ProductID As Integer
        Public ProductName As String
        Public QuantityPerUnit As String
        Public ReorderLevel As Short
        <Association("Product_Supplier")> _
        Public SupplierID As Suppliers
        Public UnitPrice As Decimal
        Public UnitsInStock As Short
        Public UnitsOnOrder As Short
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class

    <OptimisticLocking(False)> _
    Public Class Customers
        Inherits XPBaseObject
        Public Address As String
        Public City As String
        Public CompanyName As String
        Public ContactName As String
        Public ContactTitle As String
        Public Country As String
        <Key()> _
        Public CustomerID As String
        Public Fax As String
        Public Phone As String
        Public PostalCode As String
        Public Region As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
    End Class
End Namespace
