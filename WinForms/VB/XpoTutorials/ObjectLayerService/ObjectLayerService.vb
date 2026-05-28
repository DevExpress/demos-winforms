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
Imports System.ServiceModel
Imports System.Threading
Imports DevExpress.Xpo.Metadata

Namespace DevExpress.Xpo.Demos
    Partial Public Class ObjectLayerServices
        Inherits TutorialControl
        '<sbStartService>
        Private Const auxPath As String = "net.tcp://localhost:59723/XPOTutorialObjectLayerService"
        '</sbStartService>
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
        End Sub

        Private mainDataStore As IDataStore

        '<sbStartService>
        Private session As UnitOfWork
        Private serviceHost As ServiceHost
        Private Sub CreateService(ByVal dataStore As IDataStore)
            Dim xpDictionary As XPDictionary = New ReflectionDictionary()
            xpDictionary.CollectClassInfos(GetType(Employees))
            Dim dataLayer As IDataLayer = New ThreadSafeDataLayer(xpDictionary, dataStore)
            Dim service As New SerializableObjectLayerServiceTutorial(dataLayer)
            serviceHost = New ServiceHost(service)
            Dim binding As New NetTcpBinding()
            binding.MaxReceivedMessageSize = Int32.MaxValue
            serviceHost.AddServiceEndpoint(GetType(ISerializableObjectLayerService), binding, auxPath)
            serviceHost.Open()
        End Sub
        Private Sub CloseService()
            If serviceHost Is Nothing Then
                Return
            End If
            If serviceHost.State <> CommunicationState.Opened Then
                Return
            End If
            serviceHost.Close()
            serviceHost = Nothing
        End Sub
        Private Sub CreateClient()
            Dim binding As New NetTcpBinding()
            binding.MaxReceivedMessageSize = Int32.MaxValue
            Dim endPoint As New EndpointAddress(auxPath)
            Dim serializableObjectLayer As ISerializableObjectLayer = New SerializableObjectLayerServiceClient(binding, endPoint)
            serializableObjectLayer.CanLoadCollectionObjects.ToString() 'Check connection
            Dim objectLayer As IObjectLayer = New SerializableObjectLayerClient(serializableObjectLayer)
            session = New UnitOfWork(objectLayer)
        End Sub
        '</sbStartService>

        Private Sub PrepareDataLayer()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                Dim inMemory As New InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists)
                inMemory.ReadXml(DBFileName)
                mainDataStore = inMemory
            End If
        End Sub

        '<sbEmployees>
        Private Sub LoadEmployees()
            Dim viewEmployee As New XPView(session, GetType(Employees))
            viewEmployee.AddProperty("FirstName", "FirstName")
            viewEmployee.AddProperty("LastName", "LastName")
            viewEmployee.AddProperty("City", "City")
            gclObjectLayerServicesMain.DataSource = viewEmployee
            gvlObjectLayerServices.PopulateColumns()
        End Sub
        '</sbEmployees>


        Private Sub sbEmployees_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEmployees.Click
            LoadEmployees()
        End Sub
        Private waitEvent As New AutoResetEvent(False)
        Private Sub sbStartService_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbStartService.Click
            waitEvent.Reset()
            If serviceHost Is Nothing Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf CreateServiceHandler), mainDataStore)
                waitEvent.WaitOne(5000, False)
                CreateClient()
                sbStartService.Text = "Stop Service"
                sbEmployees.Enabled = True
            Else
                sbStartService.Text = "Stopping Service... Please Wait"
                sbStartService.Update()
                Dim waitEvent As New AutoResetEvent(False)
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf CloseServiceHandler))
                waitEvent.WaitOne(5000, False)
                sbStartService.Text = "Start Service And Create Client"
                sbEmployees.Enabled = False
            End If
        End Sub

        Private Sub CreateServiceHandler(ByVal o As Object)
            CreateService(DirectCast(o, IDataStore))
            waitEvent.Set()
        End Sub
        Private Sub CloseServiceHandler(ByVal o As Object)
            CloseService()
            waitEvent.Set()
        End Sub
    End Class

    '<sbStartService>
    <ServiceBehaviorAttribute(InstanceContextMode:=InstanceContextMode.Single)> _
    Public Class SerializableObjectLayerServiceTutorial
        Inherits SerializableObjectLayerService
        Public Sub New(ByVal dataLayer As IDataLayer)
            MyBase.New(New SerializableObjectLayerProxy(dataLayer))
        End Sub
    End Class
    Public Class SerializableObjectLayerProxy
        Inherits SerializableObjectLayerProxyBase
        Private dataLayer As IDataLayer
        Public Sub New(ByVal dataLayer As IDataLayer)
            MyBase.New()
            Me.dataLayer = dataLayer
        End Sub
        Protected Overrides Function GetObjectLayer() As SerializableObjectLayer
            Return New SerializableObjectLayer(New UnitOfWork(dataLayer), True)
        End Function
    End Class
    '</sbStartService>
End Namespace

