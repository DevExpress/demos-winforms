Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace DevExpress.Xpo.Demos
	Public Class Worker
		Inherits XPObject
		Private _FirstName As String
		Private _LastName As String
		Private _Age As Integer
		Private _Company As String

		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(LastName), _LastName, value)
            End Set
		End Property
		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(FirstName), _FirstName, value)
            End Set
		End Property
		Public Property Age() As Integer
			Get
				Return _Age
			End Get
			Set(ByVal value As Integer)
                SetPropertyValue(NameOf(Age), _Age, value)
            End Set
		End Property
		Public Property Company() As String
			Get
				Return _Company
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(Company), _Company, value)
            End Set
		End Property
		Public Sub New(ByVal s As Session, ByVal fName As String, ByVal lName As String, ByVal age As Integer, ByVal company As String)
			MyBase.New(s)
			_Age = age
			_FirstName = fName
			_LastName = lName
			_Company = company
		End Sub
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class Evangelist
		Inherits Worker
		Private _Technology As String

		Public Property Technology() As String
			Get
				Return _Technology
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(Technology), _Technology, value)
            End Set
		End Property
		Public Sub New(ByVal s As Session, ByVal fName As String, ByVal lName As String, ByVal age As Integer, ByVal company As String, ByVal technology As String)
			MyBase.New(s, fName, lName, age, company)
			_Technology = technology
		End Sub
		Public Sub New(ByVal s As Session)
			MyBase.New(s)
		End Sub
	End Class

	Public Class Manager
		Inherits Worker
		Private _Department As String
		Public Property Department() As String
			Get
				Return _Department
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(Department), _Department, value)
            End Set
		End Property
		Public Sub New(ByVal s As Session, ByVal fName As String, ByVal lName As String, ByVal age As Integer, ByVal company As String, ByVal department As String)
			MyBase.New(s, fName, lName, age, company)
			_Department = department
		End Sub
		Public Sub New(ByVal s As Session)
			MyBase.New(s)
		End Sub
	End Class

	Public Class ProductManager
		Inherits Manager
		Private _Product As String

		Public Property Product() As String
			Get
				Return _Product
			End Get
			Set(ByVal value As String)
                SetPropertyValue(NameOf(Product), _Product, value)
            End Set
		End Property
		Public Sub New(ByVal s As Session, ByVal fName As String, ByVal lName As String, ByVal age As Integer, ByVal company As String, ByVal departmen As String, ByVal product As String)
			MyBase.New(s, fName, lName, age, company, departmen)
			_Product = product
		End Sub
		Public Sub New(ByVal s As Session)
			MyBase.New(s)
		End Sub
	End Class

	Public NotInheritable Class ObjectHelper
		Private Sub New()
		End Sub
		Public Shared Function CreateDataLayer() As IDataLayer
            Dim dl As IDataLayer = New SimpleDataLayer(New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema))

            Using uow As New UnitOfWork(dl)
                Dim TempEvangelist As Evangelist
                TempEvangelist = New Evangelist(uow, "Maria", "Anders", 41, "Speedy Express", ".NET")
                TempEvangelist = New Evangelist(uow, "Ana", "Trujillo", 33, "United Package", ".NET")
                TempEvangelist = New Evangelist(uow, "Antonio", "Moreno", 46, "Federal Shipping", "VCL")
                TempEvangelist = New Evangelist(uow, "Thomas", "Hardy", 35, "Exotic Liquids", "VCL")
                TempEvangelist = New Evangelist(uow, "Christina", "Berglund", 45, "New Orleans Cajun Delights", ".NET")
                TempEvangelist = New Evangelist(uow, "Hanna", "Moos", 51, "United Package", "WPF")
                TempEvangelist = New Evangelist(uow, "Frédérique", "Citeaux", 59, "Tokyo Traders", ".NET")
                TempEvangelist = New Evangelist(uow, "Martín", "Sommer", 29, "Specialty Biscuits, Ltd.", "WPF")
                TempEvangelist = New Evangelist(uow, "Laurence", "Lebihan", 38, "Tokyo Traders", "HTML5 & JS")
                TempEvangelist = New Evangelist(uow, "Elizabeth", "Lincoln", 40, "Exotic Liquids", "WPF")
                TempEvangelist = New Evangelist(uow, "Victoria", "Ashworth", 53, "Pavlova, Ltd.", "HTML5 & JS")
                TempEvangelist = New Evangelist(uow, "Patricio", "Simpson", 37, "Specialty Biscuits, Ltd.", ".NET")
                Dim TempManager As Manager
                TempManager = New Manager(uow, "Nancy", "Davolio", 41, "Exotic Liquids", "Programming")
                TempManager = New Manager(uow, "Andrew", "Fuller", 33, "United Package", "Testing")
                TempManager = New Manager(uow, "Janet", "Leverling", 46, "New Orleans Cajun Delights", "Programming")
                TempManager = New Manager(uow, "Margaret", "Peacock", 35, "Refrescos Americanas LTDA", "Testing")
                TempManager = New Manager(uow, "Steven", "Buchanan", 45, "Tokyo Traders", "Programming")
                Dim TempProductManager As ProductManager
                TempProductManager = New ProductManager(uow, "Michael", "Suyama", 51, "Pavlova, Ltd.", "Programming", "Super One")
                TempProductManager = New ProductManager(uow, "Robert", "King", 59, "Refrescos Americanas LTDA", "Programming", "Super Two")
                TempProductManager = New ProductManager(uow, "Laura", "Callahan", 29, "Exotic Liquids", "Marketing", "Super One")
                TempProductManager = New ProductManager(uow, "Anne", "Dodsworth", 38, "United Package", "Marketing", "Super Two")
                uow.CommitChanges()
            End Using
			Return dl
		End Function
	End Class
End Namespace
