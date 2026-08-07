Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml
Imports DevExpress.Data.Utils.Security
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

#If WPF
using DevExpress.Xpf.Core;
using PivotGridDemo.Controls;
using System.Windows;
using System.Windows.Input;
#End If
#If WPF
namespace PivotGridDemo.PivotGrid.Helpers {
#Else
Namespace DevExpress.XtraPivotGrid.Demos.Helpers

#End If
    Public Delegate Sub UpdateProgressCallback(ByVal percents As Integer)

    Public Delegate Sub DatabaseGeneratedCallback()

    Public Delegate Sub DataSetFilledCallback(ByVal dataSet As DataSet)

    '
    Public Module DatabaseHelper

        Private ReadOnly worker As BackgroundWorker = New BackgroundWorker()

        Private ReadOnly FirstNames As String() = {"Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice"}

        Private ReadOnly LastNames As String() = {"Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson"}

        Private ReadOnly Adjectives As String() = {"Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy"}

        Private ReadOnly ProductNames As String() = {"Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin", "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain"}

        Private ReadOnly CategoryNames As String() = {"Business", "Presents", "Accessories", "Home", "Hobby"}

        '
        Sub New()
            AddHandler worker.DoWork, AddressOf Demos.Helpers.DatabaseHelper.GenerateDatabaseAsyncCore
            worker.WorkerReportsProgress = True
            worker.WorkerSupportsCancellation = True
        End Sub

        Public ReadOnly Property IsGenerating As Boolean
            Get
                Return worker.IsBusy
            End Get
        End Property

        Public Sub GenerateDatabaseAsync(ByVal rowsCount As Integer, ByVal updateProgressCallback As UpdateProgressCallback, ByVal databaseGeneratedCallback As DatabaseGeneratedCallback)
            AddHandler worker.ProgressChanged, Sub(s, e) updateProgressCallback(e.ProgressPercentage)
            AddHandler worker.RunWorkerCompleted, Sub(s, e) databaseGeneratedCallback()
            Call worker.RunWorkerAsync(rowsCount)
        End Sub

        Public Sub CancelDatabaseGenerationAsync()
            Call worker.CancelAsync()
        End Sub

        Private Sub GenerateDatabaseAsyncCore(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Call worker.ReportProgress(0)
            Dim rowsCount As Integer = CInt(e.Argument)
            Dim rowsRemaining As Integer = rowsCount
            Using uow As UnitOfWork = New UnitOfWork()
                Try
                    uow.ClearDatabase()
                Catch
                End Try

                Dim salesPersonCount As Integer = TutorialConstants.Random.Next(40, 50)
                Dim customersCount As Integer = TutorialConstants.Random.Next(40, 50)
                Dim productsCount As Integer = TutorialConstants.Random.Next(80, 100)
                Dim peopleNames As List(Of String) = GeneratePeopleNames(salesPersonCount + customersCount)
                Dim fullProductNames As List(Of String) = GenerateProductNames(productsCount)
                Dim indexPersonName As Integer = 0
                Dim salesPeople As XPCollection(Of SalesPerson) = New XPCollection(Of SalesPerson)(uow)
                For i As Integer = 0 To salesPersonCount - 1
                    salesPeople.Add(New SalesPerson(uow, peopleNames(indexPersonName)))
                    indexPersonName += 1
                Next

                Dim customers As XPCollection(Of Customer) = New XPCollection(Of Customer)(uow)
                For i As Integer = 0 To customersCount - 1
                    customers.Add(New Customer(uow, peopleNames(indexPersonName)))
                    indexPersonName += 1
                Next

                Dim categories As XPCollection(Of Category) = New XPCollection(Of Category)(uow)
                For i As Integer = 0 To CategoryNames.Length - 1
                    categories.Add(New Category(uow, CategoryNames(i)))
                Next

                Dim products As XPCollection(Of Product) = New XPCollection(Of Product)(uow)
                For i As Integer = 0 To productsCount - 1
                    products.Add(New Product(uow, fullProductNames(i), categories(TutorialConstants.Random.Next(categories.Count)), TutorialConstants.Random.Next(500)))
                Next

                Do
                    For k As Integer = 0 To 300 - 1
                        Dim order As Order = New Order(uow, salesPeople(TutorialConstants.Random.Next(salesPeople.Count)), customers(TutorialConstants.Random.Next(customers.Count)), GetDate())
                        Dim salesCount As Integer = If(rowsRemaining >= 5, TutorialConstants.Random.Next(1, 6), rowsRemaining)
                        For j As Integer = 0 To salesCount - 1
                            Dim product As Product = products(TutorialConstants.Random.Next(products.Count))
                            Dim tmp_Sale = New Sale(uow, order, product, TutorialConstants.Random.Next(1, 100), GetProductPrice(product))
                            rowsRemaining -= 1
                        Next
                    Next

                    uow.CommitChanges()
                    Call worker.ReportProgress(rowsCount - rowsRemaining)
                Loop While Not worker.CancellationPending AndAlso rowsRemaining > 0

                uow.FlushChanges()
            End Using
        End Sub

        Private Function GeneratePeopleNames(ByVal count As Integer) As List(Of String)
            Dim names As HashSet(Of String) = New HashSet(Of String)(count)
            While names.Count < count
                names.Add(GeneratePeopleName())
            End While

            Return names.ToList()
        End Function

        Private Function GenerateProductNames(ByVal count As Integer) As List(Of String)
            Dim names As HashSet(Of String) = New HashSet(Of String)(count)
            While names.Count < count
                names.Add(GenerateProductName())
            End While

            Return names.ToList()
        End Function

        Private Function GeneratePeopleName() As String
            Return FirstNames(TutorialConstants.Random.Next(FirstNames.Length)) & " " & LastNames(TutorialConstants.Random.Next(LastNames.Length))
        End Function

        Private Function GenerateProductName() As String
            Return Adjectives(TutorialConstants.Random.Next(Adjectives.Length)) & " " & ProductNames(TutorialConstants.Random.Next(ProductNames.Length))
        End Function

        Private Function GetProductPrice(ByVal product As Product) As Decimal
            Return product.Price * CDec((0.5 + TutorialConstants.Random.NextDouble()))
        End Function

        Private Function GetDate() As Date
            Return New DateTime(TutorialConstants.Random.Next(2007, 2015), TutorialConstants.Random.Next(1, 13), TutorialConstants.Random.Next(1, 28))
        End Function

        Public Function GetContext() As PivotGridDemoDBEntities
            Dim context As PivotGridDemoDBEntities = New PivotGridDemoDBEntities(ServerParameters.GetDBConnectionString())
            Dim databaseOK As Boolean = False
            Try
                databaseOK = context.Database.Exists()
            Finally
                If Not databaseOK Then
                    If context IsNot Nothing Then context.Dispose()
                    context = Nothing
                End If
            End Try

            Return context
        End Function

        Public Function CalculateRecordCount() As Integer
            Dim isConnectionFailed As Boolean = False
            Using connection As SqlConnection = SQLConnectionHelper.GetConnection(ServerParameters.GetDBConnectionString())
                If connection Is Nothing Then
                    isConnectionFailed = True
                Else
                    Using command As SqlCommand = New SqlCommand("select count(OID) as count from [dbo].[Sales]", connection)
                        Return CInt(command.ExecuteScalar())
                    End Using
                End If
            End Using

            If isConnectionFailed Then
                If SQLConnectionHelper.IsConnectionCorrect(ServerParameters.GetServerConnectionString()) Then Return 0
            End If

            Return -1
        End Function

        Public Function CreateDataLayer() As Boolean
            If Not SQLConnectionHelper.IsConnectionCorrect(ServerParameters.GetServerConnectionString()) Then Return False
            Dim store As IDataStore
            Try
                store = XpoDefault.GetConnectionProvider(ServerParameters.GetDBConnectionString(), AutoCreateOption.DatabaseAndSchema)
            Catch
                Return False
            End Try

            XpoDefault.DataLayer = New SimpleDataLayer(store)
            Return True
        End Function
    End Module

    Public Class ServerParameters

#Region "Singleton"
#If WPF
        public //enables binding to static properties
#End If
        Private Sub New()
        End Sub

        Private Shared fInstance As ServerParameters

        Private Shared ReadOnly Property Instance As ServerParameters
            Get
                If fInstance Is Nothing Then fInstance = New ServerParameters()
                Return fInstance
            End Get
        End Property

#End Region
        Const ServerParametersFileName As String = "PivotGridSQLParameters.xml"

        Private fServer As String = DbEngineDetector.GetSqlServerInstanceName()

        Private fLogin As String = "sa"

        Private ReadOnly passwordData As SensitiveData = SensitiveData.CreateForCurrentUser()

        Private fUseWindowsAuthentication As Boolean = True

        Public Shared ReadOnly Property DBName As String
            Get
                Return "PivotGridDemoDB"
            End Get
        End Property

        Public Shared Property Server As String
            Get
                Return Instance.fServer
            End Get

            Set(ByVal value As String)
                Instance.fServer = value
            End Set
        End Property

        Public Shared Property Login As String
            Get
                Return Instance.fLogin
            End Get

            Set(ByVal value As String)
                Instance.fLogin = value
            End Set
        End Property

        Public Shared Property Password As String
            Get
                Return Instance.passwordData.Text
            End Get

            Set(ByVal value As String)
                Instance.passwordData.Text = value
            End Set
        End Property

        Public Shared Property UseWindowsAuthentication As Boolean
            Get
                Return Instance.fUseWindowsAuthentication
            End Get

            Set(ByVal value As Boolean)
                Instance.fUseWindowsAuthentication = value
            End Set
        End Property

        Public Shared Sub LoadParameters()
            If Not File.Exists(ServerParametersFileName) Then Return
            Try
                Dim xmlContent As String = File.ReadAllText(ServerParametersFileName)
                Dim doc As XmlDocument = SafeXml.CreateDocument(xmlContent)
                If Equals(doc.DocumentElement.Name, "Parameters") Then
                    Dim parameters As String() = doc.DocumentElement.InnerText.Split(New Char() {";"c})
                    Server = parameters(0)
                    UseWindowsAuthentication = Convert.ToBoolean(parameters(1))
                    Login = parameters(2)
                End If
            Catch
            End Try
        End Sub

        Public Shared Sub SaveParameters()
            Try
                Using writer As XmlTextWriter = New XmlTextWriter(ServerParametersFileName, Encoding.UTF8)
                    writer.WriteElementString("Parameters", String.Format("{0};{1};{2}", Server, UseWindowsAuthentication, Login))
                End Using
            Catch
            End Try
        End Sub

        Public Shared Function GetServerConnectionString() As String
            If UseWindowsAuthentication Then Return String.Format("data source={0};integrated security=SSPI;connect timeout=10", Server)
            Return String.Format("data source={0};user id={1};password={2};connect timeout=10", Server, Login, Password)
        End Function

        Public Shared Function GetDBConnectionString() As String
            Return String.Format("{0};initial catalog={1}", GetServerConnectionString(), DBName)
        End Function
    End Class

#Region "XPOs"
    <Persistent("SalesPeople")>
    Public Class SalesPerson
        Inherits XPObject

        Private fName As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub

        <Persistent("SalesPersonName")>
        Public Property Name As String
            Get
                Return fName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property

        <Association("SalesPeople-Orders")>
        Public ReadOnly Property Orders As XPCollection(Of Order)
            Get
                Return GetCollection(Of Order)("Orders")
            End Get
        End Property
    End Class

    <Persistent("Customers")>
    Public Class Customer
        Inherits XPObject

        Private fName As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub

        <Persistent("CustomerName")>
        Public Property Name As String
            Get
                Return fName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property

        <Association("Customers-Orders")>
        Public ReadOnly Property Orders As XPCollection(Of Order)
            Get
                Return GetCollection(Of Order)("Orders")
            End Get
        End Property
    End Class

    <Persistent("Orders")>
    Public Class Order
        Inherits XPObject

        Private fSalesPerson As SalesPerson

        Private fCustomer As Customer

        Private fDate As Date

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal salesPerson As SalesPerson, ByVal customer As Customer, ByVal [date] As Date)
            Me.New(session)
            Me.SalesPerson = salesPerson
            Me.Customer = customer
            Me.Date = [date]
            salesPerson.Orders.Add(Me)
            customer.Orders.Add(Me)
        End Sub

        <Association("SalesPeople-Orders")>
        Public Property SalesPerson As SalesPerson
            Get
                Return fSalesPerson
            End Get

            Set(ByVal value As SalesPerson)
                SetPropertyValue("SalesPerson", fSalesPerson, value)
            End Set
        End Property

        <Association("Customers-Orders")>
        Public Property Customer As Customer
            Get
                Return fCustomer
            End Get

            Set(ByVal value As Customer)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property

        <Association("Orders-Sales")>
        Public ReadOnly Property Sales As XPCollection(Of Sale)
            Get
                Return GetCollection(Of Sale)("Sales")
            End Get
        End Property

        <Persistent("OrderDate"), Indexed>
        Public Property [Date] As Date
            Get
                Return fDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("Date", fDate, value)
            End Set
        End Property
    End Class

    <Persistent("Categories")>
    Public Class Category
        Inherits XPObject

        Private fName As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub

        <Persistent("CategoryName")>
        Public Property Name As String
            Get
                Return fName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property

        <Association("Category-Products")>
        Public ReadOnly Property Products As XPCollection(Of Product)
            Get
                Return GetCollection(Of Product)("Products")
            End Get
        End Property
    End Class

    <Persistent("Products")>
    Public Class Product
        Inherits XPObject

        Private fName As String

        Private fCategory As Category

        Private fPrice As Decimal

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal name As String, ByVal category As Category, ByVal price As Decimal)
            Me.New(session)
            Me.Name = name
            Me.Category = category
            Me.Category.Products.Add(Me)
            Me.Price = price
        End Sub

        <Persistent("ProductName")>
        Public Property Name As String
            Get
                Return fName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property

        <Association("Category-Products")>
        Public Property Category As Category
            Get
                Return fCategory
            End Get

            Set(ByVal value As Category)
                SetPropertyValue("Category", fCategory, value)
            End Set
        End Property

        <Association("Product-Sales")>
        Public ReadOnly Property Sales As XPCollection(Of Sale)
            Get
                Return GetCollection(Of Sale)("Sales")
            End Get
        End Property

        <NonPersistent>
        Public Property Price As Decimal
            Get
                Return fPrice
            End Get

            Set(ByVal value As Decimal)
                fPrice = value
            End Set
        End Property
    End Class

    <Persistent("Sales")>
    Public Class Sale
        Inherits XPObject

        Private fOrder As Order

        Private fProduct As Product

        Private fQuantity As Integer

        Private fUnitPrice As Decimal

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Sub New(ByVal session As Session, ByVal order As Order, ByVal product As Product, ByVal quantity As Integer, ByVal unitPrice As Decimal)
            Me.New(session)
            Me.Order = order
            Me.Product = product
            Me.Quantity = quantity
            Me.UnitPrice = unitPrice
            order.Sales.Add(Me)
            product.Sales.Add(Me)
        End Sub

        <Association("Orders-Sales")>
        Public Property Order As Order
            Get
                Return fOrder
            End Get

            Set(ByVal value As Order)
                SetPropertyValue("Order", fOrder, value)
            End Set
        End Property

        <Association("Product-Sales")>
        Public Property Product As Product
            Get
                Return fProduct
            End Get

            Set(ByVal value As Product)
                SetPropertyValue("Product", fProduct, value)
            End Set
        End Property

        <Persistent("Quantity")>
        Public Property Quantity As Integer
            Get
                Return fQuantity
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue("Quantity", fQuantity, value)
            End Set
        End Property

        <Persistent("UnitPrice")>
        Public Property UnitPrice As Decimal
            Get
                Return fUnitPrice
            End Get

            Set(ByVal value As Decimal)
                SetPropertyValue("UnitPrice", fUnitPrice, value)
            End Set
        End Property
    End Class
#End Region
End Namespace
