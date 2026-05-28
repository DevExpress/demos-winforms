Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering

Namespace DevExpress.Xpo.Demos
    Partial Public Class AsyncLoading
        Inherits DevExpress.Xpo.Demos.TutorialControl
        Private session As UnitOfWork
        Private xpcPersons As XPCollection
        Private xpcProducts As XPCollection
        Private xpvPersons As XPView
        Private xpvProducts As XPView
        Private dataLayer As IDataLayer = New DelayedDataLayer(New SimpleDataLayer(New InMemoryDataStore()))
        Public Sub New()
            InitializeComponent()
            InitData()
        End Sub
        Public Sub InitData()
            Dim connectionString As String
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Using saveSession As New UnitOfWork(dataLayer)
                    Using loadSession As New UnitOfWork(New SimpleDataLayer(XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.None)))
                        Dim persons As ICollection = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(GetType(Employees)), CriteriaOperator.Parse("Len(FirstName) <= ?", 5), Nothing, 0, False, True)
                        For Each empl As Employees In persons
                            Dim person As New Person(saveSession)
                            person.FirstName = empl.FirstName
                            person.LastName = empl.LastName
                        Next empl
                        Dim products As ICollection = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(GetType(Products)), CriteriaOperator.Parse("UnitPrice <= ?", 10), Nothing, 0, False, True)
                        For Each prod As Products In products
                            Dim product As New Product(saveSession)
                            product.ProductName = prod.ProductName
                            product.Price = prod.UnitPrice
                        Next prod
                    End Using
                    saveSession.CommitChanges()
                End Using
                session = New UnitOfWork(dataLayer)
            End If
        End Sub
        Public Sub AddData()
            Dim connectionString As String
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Using saveSession As New UnitOfWork(dataLayer)
                    Using loadSession As New UnitOfWork(New SimpleDataLayer(XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.None)))
                        Dim persons As ICollection = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(GetType(Employees)), CriteriaOperator.Parse("Len(FirstName) > ?", 5), Nothing, 0, False, True)
                        For Each empl As Employees In persons
                            Dim person As New Person(saveSession)
                            person.FirstName = empl.FirstName
                            person.LastName = empl.LastName
                        Next empl
                        Dim products As ICollection = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(GetType(Products)), CriteriaOperator.Parse("UnitPrice > ?", 10), Nothing, 0, False, True)
                        For Each prod As Products In products
                            Dim product As New Product(saveSession)
                            product.ProductName = prod.ProductName
                            product.Price = prod.UnitPrice
                        Next prod
                    End Using
                    saveSession.CommitChanges()
                End Using
            End If
        End Sub

        Public Class Person
            Inherits XPBaseObject
            Private _oid As Integer
            <Key(True)> _
            Public Property Oid() As Integer
                Get
                    Return _oid
                End Get
                Set(ByVal value As Integer)
                    SetPropertyValue(NameOf(Oid), _oid, value)
                End Set
            End Property
            Private _firstName As String
            Public Property FirstName() As String
                Get
                    Return _firstName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(FirstName), _firstName, value)
                End Set
            End Property
            Private _lastName As String
            Public Property LastName() As String
                Get
                    Return _lastName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(LastName), _lastName, value)
                End Set
            End Property
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
        End Class

        Public Class Product
            Inherits XPBaseObject
            Private _oid As Integer
            <Key(True)> _
            Public Property Oid() As Integer
                Get
                    Return _oid
                End Get
                Set(ByVal value As Integer)
                    SetPropertyValue(NameOf(Oid), _oid, value)
                End Set
            End Property
            Private _productName As String
            Public Property ProductName() As String
                Get
                    Return _productName
                End Get
                Set(ByVal value As String)
                    SetPropertyValue(NameOf(ProductName), _productName, value)
                End Set
            End Property
            Private _price As Decimal
            Public Property Price() As Decimal
                Get
                    Return _price
                End Get
                Set(ByVal value As Decimal)
                    SetPropertyValue(NameOf(Price), _price, value)
                End Set
            End Property
            Public Sub New(ByVal session As Session)
                MyBase.New(session)
            End Sub
        End Class

        Private Sub gclPersons_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles gclPersons.Resize
            lbLoadingPersons.Left = (gclPersons.Width - lbLoadingPersons.Width) \ 2
            lbLoadingPersons.Top = (gclPersons.Height - lbLoadingPersons.Height) \ 2
        End Sub

        Private Sub gclProducts_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles gclProducts.Resize
            lbLoadingProducts.Left = (gclProducts.Width - lbLoadingProducts.Width) \ 2
            lbLoadingProducts.Top = (gclProducts.Height - lbLoadingProducts.Height) \ 2
        End Sub
        Private Sub sbLoadData_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles sbLoadData.Click
            If (cbXpView.Checked AndAlso xpvPersons Is Nothing) OrElse (cbXpView.Checked AndAlso xpcPersons Is Nothing) Then
                sbAddData.Enabled = True
            End If
            sbLoadData_Click(sender, e)
        End Sub
        Private Sub sbLoadDataXPView_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            If xpvPersons Is Nothing Then
                sbAddData.Enabled = True
            End If
            sbLoadData_Click(sender, e)
        End Sub
        '<sbLoadData>
        Private Sub sbLoadData_Click(ByVal sender As Object, ByVal e As EventArgs)
            If cbXpView.Checked Then
                If xpvPersons Is Nothing Then
                    xpvPersons = New XPView(session, GetType(Person))
                    xpvPersons.AddProperty("Oid", "Oid")
                    xpvPersons.AddProperty("FirstName", "FirstName")
                    xpvPersons.AddProperty("LastName", "LastName")
                    LoadAsyncPersonsXPView()
                Else
                    LoadAsyncPersonsXPView()
                End If
                If xpvProducts Is Nothing Then
                    xpvProducts = New XPView(session, GetType(Product))
                    xpvProducts.AddProperty("Oid", "Oid")
                    xpvProducts.AddProperty("ProductName", "ProductName")
                    xpvProducts.AddProperty("Price", "Price")
                    LoadAsyncProductsXPView()
                Else
                    LoadAsyncProductsXPView()
                End If
            Else
                If xpcPersons Is Nothing Then
                    xpcPersons = New XPCollection(session, GetType(Person))
                    LoadAsyncPersonsXPCollection()
                Else
                    LoadAsyncPersonsXPCollection()
                End If
                If xpcProducts Is Nothing Then
                    xpcProducts = New XPCollection(session, GetType(Product))
                    LoadAsyncProductsXPCollection()
                Else
                    LoadAsyncProductsXPCollection()
                End If
            End If
        End Sub
        Private Sub LoadAsyncPersonsCore()
            sbLoadData.Enabled = False
            sbCommit.Enabled = False
            lbLoadingPersons.Visible = True
            gclPersons.Enabled = False
            cbXpView.Enabled = False
        End Sub
        Private Sub LoadAsyncPersonsXPView()
            LoadAsyncPersonsCore()
            xpvPersons.LoadAsync(New DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(AddressOf CallBackPersons))
            If (Not ReferenceEquals(gclPersons.DataSource, xpvPersons)) Then
                gclPersons.DataSource = xpvPersons
            End If
        End Sub
        Private Sub LoadAsyncPersonsXPCollection()
            LoadAsyncPersonsCore()
            xpcPersons.LoadAsync(New DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(AddressOf CallBackPersons))
            If (Not ReferenceEquals(gclPersons.DataSource, xpcPersons)) Then
                gclPersons.DataSource = xpcPersons
            End If
        End Sub
        Private Sub LoadAsyncProductsXPView()
            lbLoadingProducts.Visible = True
            gclProducts.Enabled = False
            xpvProducts.LoadAsync(New DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(AddressOf CallBackProducts))
            If (Not ReferenceEquals(gclProducts.DataSource, xpvProducts)) Then
                gclProducts.DataSource = xpvProducts
            End If
        End Sub
        Private Sub LoadAsyncProductsXPCollection()
            lbLoadingProducts.Visible = True
            gclProducts.Enabled = False
            xpcProducts.LoadAsync(New DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(AddressOf CallBackProducts))
            If (Not ReferenceEquals(gclProducts.DataSource, xpcProducts)) Then
                gclProducts.DataSource = xpcProducts
            End If
        End Sub
        Private Sub CallBackPersons(ByVal result() As ICollection, ByVal ex As Exception)
            lbLoadingPersons.Visible = False
            gclPersons.Enabled = True
            If ex IsNot Nothing Then
                XtraMessageBox.Show(ex.Message)
            End If
        End Sub
        Private Sub CallBackProducts(ByVal result() As ICollection, ByVal ex As Exception)
            sbLoadData.Enabled = True
            sbCommit.Enabled = True
            lbLoadingProducts.Visible = False
            gclProducts.Enabled = True
            cbXpView.Enabled = True
            If ex Is Nothing Then
                Return
            End If
            XtraMessageBox.Show(ex.Message)
        End Sub
        '</sbLoadData>

        Private Sub sbAddData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAddData.Click
            AddData()
            sbAddData.Enabled = False
        End Sub

        Private Sub splitContainerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles splitContainerControl1.Resize
            splitContainerControl1.SplitterPosition = panelControl3.Width \ 2
        End Sub

        '<sbCommit>
        Private Sub sbCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCommit.Click
            sbLoadData.Enabled = False
            sbCommit.Enabled = False
            gclPersons.Enabled = False
            gclProducts.Enabled = False
            cbXpView.Enabled = False
            lbCommit.Visible = True
            session.CommitChangesAsync(New AsyncCommitCallback(AddressOf CallBackCommit))
        End Sub

        Private Sub CallBackCommit(ByVal ex As Exception)
            sbLoadData.Enabled = True
            sbCommit.Enabled = True
            gclPersons.Enabled = True
            gclProducts.Enabled = True
            cbXpView.Enabled = True
            lbCommit.Visible = False
            If ex Is Nothing Then
                Return
            End If
            XtraMessageBox.Show(ex.Message)
        End Sub
        '</sbCommit>
        Private Sub AsyncLoading_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            lbCommit.Left = (Me.Width - lbCommit.Width) \ 2
            lbCommit.Top = (Me.Height - lbCommit.Height) \ 2
        End Sub
    End Class
End Namespace

