Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.Xpo.Demos

Namespace DevExpress.Xpo.Demos
    Partial Public Class DataCaching
        Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            PrepareDataLayer()
            PrepareViews()
            LoadEmployees()
        End Sub

        '<gclDataCachingMain>
        Private session As UnitOfWork
        Private dataCacheRoot As DataCacheRoot
        Private Sub CreateCachedConnection(ByVal dataStore As IDataStore)
            If dataCacheRoot Is Nothing Then
                dataCacheRoot = New DataCacheRoot(dataStore)
                dataCacheRoot.Configure(New DataCacheConfiguration(DataCacheConfigurationCaching.InList, "Employees"))
            End If
            Dim cachedDataStore As New DataCacheNode(dataCacheRoot)
            cachedDataStore.MaxCacheLatency = TimeSpan.FromSeconds(2)

            Dim dataLayer As IDataLayer = New SimpleDataLayer(cachedDataStore)
            session = New UnitOfWork(dataLayer)
        End Sub
        Private viewEmployee As XPView
        Private viewOrder As XPView
        Private Sub PrepareViews()
            viewEmployee = New XPView(session, GetType(Employees))
            viewEmployee.AddProperty("FirstName", "FirstName")
            viewEmployee.AddProperty("LastName", "LastName")
            viewEmployee.AddProperty("City", "City")
            viewOrder = New XPView(session, GetType(Orders))
            viewOrder.AddProperty("ShipName", "ShipName")
            viewOrder.AddProperty("OrderDate", "OrderDate")
            viewOrder.AddProperty("Freight", "Freight")
        End Sub
        '</gclDataCachingMain>

        Private Sub PrepareDataLayer()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                Dim inMemory As New InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists)
                inMemory.ReadXml(DBFileName)
                CreateCachedConnection(New DataStoreCounter(inMemory))
                DataStoreCounter.ClearCounter()
            End If
        End Sub

        '<sbChangeAnyEmployee>
        Private Sub UpdateAnyEmployee()
            Dim cachedDataStore As New DataCacheNode(dataCacheRoot)
            cachedDataStore.MaxCacheLatency = TimeSpan.FromSeconds(2)
            Dim dataLayer As IDataLayer = New SimpleDataLayer(cachedDataStore)
            Using uow As New UnitOfWork(dataLayer)
                Dim employee As Employees = uow.FindObject(Of Employees)(Nothing)
                If employee Is Nothing Then
                    Return
                End If
                If employee.City = "New York" Then
                    employee.City = "Chicago"
                Else
                    employee.City = "New York"
                End If
                employee.Save()
                uow.CommitChanges()
                lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString()
            End Using
        End Sub
        '</sbChangeAnyEmployee>


        '<sbEmployees>
        Private Sub LoadEmployees()
            viewEmployee.Reload()
            If gclDataCachingMain.DataSource IsNot viewEmployee Then
                gclDataCachingMain.DataSource = viewEmployee
                gvlDataCaching.PopulateColumns()
                sbEmployees.Text = "Reload Employees"
                sbOrders.Text = "Load Orders"
            End If
            lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString()
        End Sub
        '</sbEmployees>
        '<sbOrders>
        Private Sub LoadOrders()
            viewOrder.Reload()
            If gclDataCachingMain.DataSource IsNot viewOrder Then
                gclDataCachingMain.DataSource = viewOrder
                gvlDataCaching.PopulateColumns()
                sbEmployees.Text = "Load Employees"
                sbOrders.Text = "Reload Orders"
            End If
            lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString()
        End Sub
        '</sbOrders>


        Private Sub sbEmployees_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEmployees.Click
            LoadEmployees()
        End Sub

        Private Sub sbOrders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOrders.Click
            LoadOrders()
        End Sub

        Private Sub changeAnyEmployee_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbChangeAnyEmployee.Click
            UpdateAnyEmployee()
        End Sub
    End Class
End Namespace

