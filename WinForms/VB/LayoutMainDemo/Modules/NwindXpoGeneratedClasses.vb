Imports DevExpress.Xpo

Namespace DevExpress.XtraLayout.Demos.DBObjects

    Public Class Employees
        Inherits XPLiteObject

        Private fAddress As String

        <Size(60)>
        Public Property Address As String
            Get
                Return fAddress
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property

        Private fBirthDate As Date

        Public Property BirthDate As Date
            Get
                Return fBirthDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("BirthDate", fBirthDate, value)
            End Set
        End Property

        Private fCity As String

        <Size(15)>
        Public Property City As String
            Get
                Return fCity
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property

        Private fCountry As String

        <Size(15)>
        Public Property Country As String
            Get
                Return fCountry
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Country", fCountry, value)
            End Set
        End Property

        Private fEmployeeID As Integer

        <Key(True)>
        Public Property EmployeeID As Integer
            Get
                Return fEmployeeID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("EmployeeID", fEmployeeID, value)
            End Set
        End Property

        Private fExtension As String

        <Size(4)>
        Public Property Extension As String
            Get
                Return fExtension
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Extension", fExtension, value)
            End Set
        End Property

        Private fFirstName As String

        <Size(10)>
        Public Property FirstName As String
            Get
                Return fFirstName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("FirstName", fFirstName, value)
            End Set
        End Property

        Private fHireDate As Date

        Public Property HireDate As Date
            Get
                Return fHireDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("HireDate", fHireDate, value)
            End Set
        End Property

        Private fHomePhone As String

        <Size(24)>
        Public Property HomePhone As String
            Get
                Return fHomePhone
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("HomePhone", fHomePhone, value)
            End Set
        End Property

        Private fLastName As String

        <Size(20)>
        Public Property LastName As String
            Get
                Return fLastName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("LastName", fLastName, value)
            End Set
        End Property

        Private fNotes As String

        <Size(SizeAttribute.Unlimited)>
        Public Property Notes As String
            Get
                Return fNotes
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Notes", fNotes, value)
            End Set
        End Property

        Private fPhoto As Byte()

        Public Property Photo As Byte()
            Get
                Return fPhoto
            End Get

            Set(ByVal value As Byte())
                SetPropertyValue("Photo", fPhoto, value)
            End Set
        End Property

        Private fPostalCode As String

        <Size(10)>
        Public Property PostalCode As String
            Get
                Return fPostalCode
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("PostalCode", fPostalCode, value)
            End Set
        End Property

        Private fRegion As String

        <Size(15)>
        Public Property Region As String
            Get
                Return fRegion
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Region", fRegion, value)
            End Set
        End Property

        Private fReportsTo As Integer

        Public Property ReportsTo As Integer
            Get
                Return fReportsTo
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReportsTo", fReportsTo, value)
            End Set
        End Property

        Private fTitle As String

        <Size(30)>
        Public Property Title As String
            Get
                Return fTitle
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Title", fTitle, value)
            End Set
        End Property

        Private fTitleOfCourtesy As String

        <Size(25)>
        Public Property TitleOfCourtesy As String
            Get
                Return fTitleOfCourtesy
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("TitleOfCourtesy", fTitleOfCourtesy, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Orders
        Inherits XPLiteObject

        Private fCustomerID As Customers

        <Size(5)>
        Public Property CustomerID As Customers
            Get
                Return fCustomerID
            End Get

            Set(ByVal value As Customers)
                Call SetPropertyValue(Of Customers)("CustomerID", fCustomerID, value)
            End Set
        End Property

        Private fEmployeeID As Employees

        Public Property EmployeeID As Employees
            Get
                Return fEmployeeID
            End Get

            Set(ByVal value As Employees)
                Call SetPropertyValue(Of Employees)("EmployeeID", fEmployeeID, value)
            End Set
        End Property

        Private fFreight As Decimal

        Public Property Freight As Decimal
            Get
                Return fFreight
            End Get

            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Freight", fFreight, value)
            End Set
        End Property

        Private fOrderDate As Date

        Public Property OrderDate As Date
            Get
                Return fOrderDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("OrderDate", fOrderDate, value)
            End Set
        End Property

        Private fOrderID As Integer

        <Key(True)>
        Public Property OrderID As Integer
            Get
                Return fOrderID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("OrderID", fOrderID, value)
            End Set
        End Property

        Private fRequiredDate As Date

        Public Property RequiredDate As Date
            Get
                Return fRequiredDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("RequiredDate", fRequiredDate, value)
            End Set
        End Property

        Private fShipAddress As String

        <Size(60)>
        Public Property ShipAddress As String
            Get
                Return fShipAddress
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipAddress", fShipAddress, value)
            End Set
        End Property

        Private fShipCity As String

        <Size(15)>
        Public Property ShipCity As String
            Get
                Return fShipCity
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipCity", fShipCity, value)
            End Set
        End Property

        Private fShipCountry As String

        <Size(15)>
        Public Property ShipCountry As String
            Get
                Return fShipCountry
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipCountry", fShipCountry, value)
            End Set
        End Property

        Private fShipName As String

        <Size(40)>
        Public Property ShipName As String
            Get
                Return fShipName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipName", fShipName, value)
            End Set
        End Property

        Private fShippedDate As Date

        Public Property ShippedDate As Date
            Get
                Return fShippedDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("ShippedDate", fShippedDate, value)
            End Set
        End Property

        Private fShipPostalCode As String

        <Size(10)>
        Public Property ShipPostalCode As String
            Get
                Return fShipPostalCode
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipPostalCode", fShipPostalCode, value)
            End Set
        End Property

        Private fShipRegion As String

        <Size(15)>
        Public Property ShipRegion As String
            Get
                Return fShipRegion
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipRegion", fShipRegion, value)
            End Set
        End Property

        Private fShipVia As Shippers

        Public Property ShipVia As Shippers
            Get
                Return fShipVia
            End Get

            Set(ByVal value As Shippers)
                Call SetPropertyValue(Of Shippers)("ShipVia", fShipVia, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Customers
        Inherits XPLiteObject

        Private fAddress As String

        <Size(60)>
        Public Property Address As String
            Get
                Return fAddress
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property

        Private fCity As String

        <Size(15)>
        Public Property City As String
            Get
                Return fCity
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property

        Private fCompanyName As String

        <Size(40)>
        Public Property CompanyName As String
            Get
                Return fCompanyName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CompanyName", fCompanyName, value)
            End Set
        End Property

        Private fContactName As String

        <Size(30)>
        Public Property ContactName As String
            Get
                Return fContactName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactName", fContactName, value)
            End Set
        End Property

        Private fContactTitle As String

        <Size(30)>
        Public Property ContactTitle As String
            Get
                Return fContactTitle
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactTitle", fContactTitle, value)
            End Set
        End Property

        Private fCountry As String

        <Size(15)>
        Public Property Country As String
            Get
                Return fCountry
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Country", fCountry, value)
            End Set
        End Property

        Private fCustomerID As String

        <Key>
        <Size(5)>
        Public Property CustomerID As String
            Get
                Return fCustomerID
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerID", fCustomerID, value)
            End Set
        End Property

        Private fFax As String

        <Size(24)>
        Public Property Fax As String
            Get
                Return fFax
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Fax", fFax, value)
            End Set
        End Property

        Private fPhone As String

        <Size(24)>
        Public Property Phone As String
            Get
                Return fPhone
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fPhone, value)
            End Set
        End Property

        Private fPostalCode As String

        <Size(10)>
        Public Property PostalCode As String
            Get
                Return fPostalCode
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("PostalCode", fPostalCode, value)
            End Set
        End Property

        Private fRegion As String

        <Size(15)>
        Public Property Region As String
            Get
                Return fRegion
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Region", fRegion, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Categories
        Inherits XPLiteObject

        Private fCategoryID As Integer

        <Key(True)>
        Public Property CategoryID As Integer
            Get
                Return fCategoryID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CategoryID", fCategoryID, value)
            End Set
        End Property

        Private fCategoryName As String

        <Size(15)>
        Public Property CategoryName As String
            Get
                Return fCategoryName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CategoryName", fCategoryName, value)
            End Set
        End Property

        Private fDescription As String

        <Size(SizeAttribute.Unlimited)>
        Public Property Description As String
            Get
                Return fDescription
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fDescription, value)
            End Set
        End Property

        Private fPicture As Byte()

        Public Property Picture As Byte()
            Get
                Return fPicture
            End Get

            Set(ByVal value As Byte())
                SetPropertyValue("Picture", fPicture, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Shippers
        Inherits XPLiteObject

        Private fCompanyName As String

        <Size(40)>
        Public Property CompanyName As String
            Get
                Return fCompanyName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CompanyName", fCompanyName, value)
            End Set
        End Property

        Private fPhone As String

        <Size(24)>
        Public Property Phone As String
            Get
                Return fPhone
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fPhone, value)
            End Set
        End Property

        Private fShipperID As Integer

        <Key(True)>
        Public Property ShipperID As Integer
            Get
                Return fShipperID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShipperID", fShipperID, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Products
        Inherits XPLiteObject

        Private fCategoryID As Categories

        Public Property CategoryID As Categories
            Get
                Return fCategoryID
            End Get

            Set(ByVal value As Categories)
                Call SetPropertyValue(Of Categories)("CategoryID", fCategoryID, value)
            End Set
        End Property

        Private fDiscontinued As Boolean

        Public Property Discontinued As Boolean
            Get
                Return fDiscontinued
            End Get

            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Discontinued", fDiscontinued, value)
            End Set
        End Property

        Private fEAN13 As String

        <Size(12)>
        Public Property EAN13 As String
            Get
                Return fEAN13
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("EAN13", fEAN13, value)
            End Set
        End Property

        Private fProductID As Integer

        <Key(True)>
        Public Property ProductID As Integer
            Get
                Return fProductID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ProductID", fProductID, value)
            End Set
        End Property

        Private fProductName As String

        <Size(40)>
        Public Property ProductName As String
            Get
                Return fProductName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ProductName", fProductName, value)
            End Set
        End Property

        Private fQuantityPerUnit As String

        <Size(20)>
        Public Property QuantityPerUnit As String
            Get
                Return fQuantityPerUnit
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("QuantityPerUnit", fQuantityPerUnit, value)
            End Set
        End Property

        Private fReorderLevel As Short

        Public Property ReorderLevel As Short
            Get
                Return fReorderLevel
            End Get

            Set(ByVal value As Short)
                SetPropertyValue("ReorderLevel", fReorderLevel, value)
            End Set
        End Property

        Private fSupplierID As Suppliers

        Public Property SupplierID As Suppliers
            Get
                Return fSupplierID
            End Get

            Set(ByVal value As Suppliers)
                Call SetPropertyValue(Of Suppliers)("SupplierID", fSupplierID, value)
            End Set
        End Property

        Private fUnitPrice As Decimal

        Public Property UnitPrice As Decimal
            Get
                Return fUnitPrice
            End Get

            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, value)
            End Set
        End Property

        Private fUnitsInStock As Short

        Public Property UnitsInStock As Short
            Get
                Return fUnitsInStock
            End Get

            Set(ByVal value As Short)
                SetPropertyValue("UnitsInStock", fUnitsInStock, value)
            End Set
        End Property

        Private fUnitsOnOrder As Short

        Public Property UnitsOnOrder As Short
            Get
                Return fUnitsOnOrder
            End Get

            Set(ByVal value As Short)
                SetPropertyValue("UnitsOnOrder", fUnitsOnOrder, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

    Public Class Suppliers
        Inherits XPLiteObject

        Private fAddress As String

        <Size(60)>
        Public Property Address As String
            Get
                Return fAddress
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property

        Private fCity As String

        <Size(15)>
        Public Property City As String
            Get
                Return fCity
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property

        Private fCompanyName As String

        <Size(40)>
        Public Property CompanyName As String
            Get
                Return fCompanyName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("CompanyName", fCompanyName, value)
            End Set
        End Property

        Private fContactName As String

        <Size(30)>
        Public Property ContactName As String
            Get
                Return fContactName
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactName", fContactName, value)
            End Set
        End Property

        Private fContactTitle As String

        <Size(30)>
        Public Property ContactTitle As String
            Get
                Return fContactTitle
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactTitle", fContactTitle, value)
            End Set
        End Property

        Private fCountry As String

        <Size(15)>
        Public Property Country As String
            Get
                Return fCountry
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Country", fCountry, value)
            End Set
        End Property

        Private fFax As String

        <Size(24)>
        Public Property Fax As String
            Get
                Return fFax
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Fax", fFax, value)
            End Set
        End Property

        Private fHomePage As String

        <Size(SizeAttribute.Unlimited)>
        Public Property HomePage As String
            Get
                Return fHomePage
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("HomePage", fHomePage, value)
            End Set
        End Property

        Private fPhone As String

        <Size(24)>
        Public Property Phone As String
            Get
                Return fPhone
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fPhone, value)
            End Set
        End Property

        Private fPostalCode As String

        <Size(10)>
        Public Property PostalCode As String
            Get
                Return fPostalCode
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("PostalCode", fPostalCode, value)
            End Set
        End Property

        Private fRegion As String

        <Size(15)>
        Public Property Region As String
            Get
                Return fRegion
            End Get

            Set(ByVal value As String)
                SetPropertyValue(Of String)("Region", fRegion, value)
            End Set
        End Property

        Private fSupplierID As Integer

        <Key(True)>
        Public Property SupplierID As Integer
            Get
                Return fSupplierID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("SupplierID", fSupplierID, value)
            End Set
        End Property

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class
End Namespace
