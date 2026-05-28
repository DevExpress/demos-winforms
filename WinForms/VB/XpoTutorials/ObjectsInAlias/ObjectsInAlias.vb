Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic

Namespace DevExpress.Xpo.Demos
	Partial Public Class ObjectsInAlias
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			CreateConnection()
			LoadData()
		End Sub
		Public Overrides Property SetNewWhatsThisPadding() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
				MyBase.SetNewWhatsThisPadding = value
			End Set
		End Property

		Private session As UnitOfWork
		Private Sub CreateConnection()
			Dim dataStore As New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema)
			Dim dataLayer As IDataLayer = New SimpleDataLayer(dataStore)
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
			If (Not String.IsNullOrEmpty(DBFileName)) Then
				Using saveSession As New UnitOfWork(dataLayer)
					Dim internalDataStore As New InMemoryDataStore(AutoCreateOption.None)
					internalDataStore.ReadXml(DBFileName)
					Dim persons As New List(Of Person)()
					Using loadSession As New UnitOfWork(New SimpleDataLayer(internalDataStore))
						Dim loadedPersons As ICollection = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(GetType(Employees)), Nothing, Nothing, 0, False, True)
						For Each empl As Employees In loadedPersons
							Dim person As New Person(saveSession)
							person.FirstName = empl.FirstName
							person.LastName = empl.LastName
							persons.Add(person)
						Next empl
					End Using
					Dim personCounter As Integer = 0
					For i As Integer = 0 To 39
						Dim order As New Order(saveSession)
						order.MainCustomerIsOne = i Mod 2 = 0
						Select Case i Mod 3
							Case 0
								order.CustomerOne = persons(personCounter)
								personCounter += 1
								If personCounter >= persons.Count Then
									personCounter = 0
								End If
								order.CustomerTwo = persons(personCounter)
								personCounter += 1
								If personCounter >= persons.Count Then
									personCounter = 0
								End If
							Case 1
								order.CustomerOne = persons(personCounter)
								personCounter += 1
								If personCounter >= persons.Count Then
									personCounter = 0
								End If
							Case 2
								order.CustomerTwo = persons(personCounter)
								personCounter += 1
								If personCounter >= persons.Count Then
									personCounter = 0
								End If
						End Select
					Next i
					saveSession.CommitChanges()
				End Using
			End If
			session = New UnitOfWork(dataLayer)
		End Sub
		'<gcMain>
		Private Sub LoadData()
			Dim view As New XPView(session, GetType(Order))
			view.AddProperty("CustomerOne", "CustomerOne.FullName")
			view.AddProperty("CustomerTwo", "CustomerTwo.FullName")
			view.AddProperty("MainCustomerIsOne", "MainCustomerIsOne")
			view.AddProperty("MainCustomer", "MainCustomer.FullName") 'Access to the FullName property of object in alias
			view.AddProperty("NotNullCustomer", "NotNullCustomer.FullName") 'Access to the FullName property of object in alias
			view.AddProperty("CustomerOneBySingle", "CustomerOneBySingle.FullName") 'Access to the FullName property of object in alias
			gcMain.DataSource = view
			gridView1.PopulateColumns()
			gridView1.BestFitColumns()
		End Sub
		Public Class Order
			Inherits XPObject
            Private _mainCustomerIsOne As Boolean
            Private customer1 As Person
            Private customer2 As Person
            Private _title As String
            Public Property Title() As String
                Get
                    Return _title
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(Title), _title, value)
                End Set
            End Property
            Public Property MainCustomerIsOne() As Boolean
                Get
                    Return _mainCustomerIsOne
                End Get
                Set(ByVal value As Boolean)
                    SetPropertyValue(NameOf(MainCustomerIsOne), _mainCustomerIsOne, value)
                End Set
            End Property
			Public Property CustomerOne() As Person
				Get
					Return customer1
				End Get
				Set(ByVal value As Person)
                    SetPropertyValue(NameOf(CustomerOne), customer1, value)
                End Set
			End Property
			Public Property CustomerTwo() As Person
				Get
					Return customer2
				End Get
				Set(ByVal value As Person)
                    SetPropertyValue(NameOf(CustomerTwo), customer2, value)
                End Set
			End Property

            <PersistentAlias("Iif(" + NameOf(MainCustomerIsOne) + ", " + NameOf(CustomerOne) + ", " + NameOf(CustomerTwo) + ")")>
            Public ReadOnly Property MainCustomer() As Person
				Get
                    Return CType(EvaluateAlias(NameOf(MainCustomer)), Person)
                End Get
			End Property
            <PersistentAlias("IsNull(" + NameOf(CustomerOne) + ", " + NameOf(CustomerTwo) + ")")>
            Public ReadOnly Property NotNullCustomer() As Person
				Get
                    Return CType(EvaluateAlias(NameOf(NotNullCustomer)), Person)
                End Get
			End Property
            <PersistentAlias("[<" + NameOf(Person) + ">][" + NameOf(Oid) + " = ^." + NameOf(CustomerOne) + "].Single()")>
            Public ReadOnly Property CustomerOneBySingle() As Person
				Get
                    Return CType(EvaluateAlias(NameOf(CustomerOneBySingle)), Person)
                End Get
			End Property

			Public Sub New(ByVal session As Session)
				MyBase.New(session)
			End Sub
		End Class
		Public Class Person
			Inherits XPObject
            Private _lastName As String
            Private _firstName As String
            Public Property FirstName() As String
                Get
                    Return _firstName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(FirstName), _firstName, value)
                End Set
            End Property
            Public Property LastName() As String
                Get
                    Return _lastName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(LastName), _lastName, value)
                End Set
            End Property
            <PersistentAlias(NameOf(FirstName) + " + ' ' + " + NameOf(LastName))>
            Public ReadOnly Property FullName() As String
				Get
                    Return CStr(EvaluateAlias(NameOf(FullName)))
                End Get
			End Property
			Public Sub New(ByVal session As Session)
				MyBase.New(session)
			End Sub
		End Class
		'</gcMain>
	End Class
End Namespace
