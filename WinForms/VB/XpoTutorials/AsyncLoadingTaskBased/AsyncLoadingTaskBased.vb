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
Imports System.Threading.Tasks

Namespace DevExpress.Xpo.Demos
    Partial Public Class AsyncLoadingTaskBased
        Inherits DevExpress.Xpo.Demos.TutorialControl
        Private session As UnitOfWork
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
            <Key(True)>
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
            <Key(True)>
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

        '<sbLoadData>
        Private Async Sub sbLoadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbLoadData.Click
            sbLoadData.Enabled = False
            sbCommit.Enabled = False
            lbLoadingPersons.Visible = True
            gclPersons.Enabled = False
            lbLoadingProducts.Visible = True
            gclProducts.Enabled = False

            Try
                Dim personQuery = New XPQuery(Of Person)(session)
                gclPersons.DataSource = Await personQuery.ToListAsync()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try

            lbLoadingPersons.Visible = False
            gclPersons.Enabled = True

            Try
                Dim productQuery = New XPQuery(Of Product)(session)
                gclProducts.DataSource = Await productQuery.ToListAsync()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try

            lbLoadingProducts.Visible = False
            gclProducts.Enabled = True
            sbLoadData.Enabled = True
            sbCommit.Enabled = True
        End Sub
        '</sbLoadData>

        Private Sub splitContainerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles splitContainerControl1.Resize
            splitContainerControl1.SplitterPosition = panelControl3.Width \ 2
        End Sub

        '<sbCommit>
        Private Async Sub sbCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCommit.Click
            sbLoadData.Enabled = False
            sbCommit.Enabled = False
            gclPersons.Enabled = False
            gclProducts.Enabled = False
            lbCommit.Visible = True
            Try
                Await session.CommitChangesAsync()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
            sbLoadData.Enabled = True
            sbCommit.Enabled = True
            gclPersons.Enabled = True
            gclProducts.Enabled = True
            lbCommit.Visible = False
        End Sub
        '</sbCommit>

        Private Sub AsyncLoading_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            lbCommit.Left = (Me.Width - lbCommit.Width) \ 2
            lbCommit.Top = (Me.Height - lbCommit.Height) \ 2
        End Sub
    End Class
End Namespace

