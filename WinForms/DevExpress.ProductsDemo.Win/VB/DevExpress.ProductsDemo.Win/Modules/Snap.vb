Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.Internal
Imports DevExpress.ProductsDemo.Win.nwindDataSetTableAdapters
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Options

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class SnapModule
        Inherits BaseModule
        Public Sub New()
            InitializeComponent()
            LoadDocument()
            SetDataSource()
            SubscribeEvents()
        End Sub
        Private Sub LoadDocument()
            Dim path As String = DataDirectoryHelper.GetDataFile("MailMergeReports.snx")
            If File.Exists(path) Then
                Me.snapControl.LoadDocument(path, SnapDocumentFormat.Snap)
            End If
        End Sub
        Private Sub SetDataSource()
            Dim dataSource As Object = (New MailMergeReportsDataProvider()).GetDataSource()
            Me.snapControl.DataSource = dataSource
        End Sub
        Private Sub SubscribeEvents()
            AddHandler Me.snapControl.MailMergeExportFormShowing, AddressOf OnMailMergeExportFormShowing
        End Sub
        Private Sub OnMailMergeExportFormShowing(ByVal sender As Object, ByVal e As MailMergeExportFormShowingEventArgs)
            e.Options.HeaderFooterLinkToPrevious = False
            e.Options.RecordSeparator = RecordSeparator.SectionNextPage
        End Sub
        Protected Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
    End Class
    Public Interface ISnapDataProvider
        Function GetDataSource() As Object
    End Interface
    Public MustInherit Class NorthwindDataProvider
        Implements ISnapDataProvider
        Protected Overridable ReadOnly Property DataMember() As String
            Get
                Return String.Empty
            End Get
        End Property
        Public Function GetDataSource() As Object Implements ISnapDataProvider.GetDataSource
            Dim path As String = DataDirectoryHelper.GetDataFile("nwind.mdb")
            Dim dataSource = New nwindDataSet()
            Dim connection = New OleDbConnection()
            connection.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", path)
            FillDataSource(connection, dataSource)
            Dim bindingSource = New BindingSource()
            bindingSource.DataSource = dataSource
            bindingSource.DataMember = DataMember
            Return bindingSource
        End Function
        Protected MustOverride Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
    End Class
    Public Class MailMergeReportsDataProvider
        Inherits NorthwindDataProvider
        Protected Overrides ReadOnly Property DataMember() As String
            Get
                Return "CustomerOrders"
            End Get
        End Property
        Protected Overrides Sub FillDataSource(ByVal connection As OleDbConnection, ByVal dataSource As nwindDataSet)
            Dim customerOrdersTableAdapter = New CustomerOrdersTableAdapter()
            customerOrdersTableAdapter.Connection = connection
            customerOrdersTableAdapter.Fill(dataSource.CustomerOrders)

            Dim orderReportsTableAdapter = New OrderReportsTableAdapter()
            orderReportsTableAdapter.Connection = connection
            orderReportsTableAdapter.Fill(dataSource.OrderReports)
        End Sub
    End Class
End Namespace
