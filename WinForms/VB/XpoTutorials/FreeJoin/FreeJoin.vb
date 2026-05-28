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

Namespace DevExpress.Xpo.Demos
    Partial Public Class FreeJoin
        Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property

        Private firstShow() As Boolean = {True, True}

        Public Sub New()
            InitializeComponent()
            CreateConnection()
            xtraTabControl1_SelectedPageChanged(Me, New DevExpress.XtraTab.TabPageChangedEventArgs(xtpSimple, xtpSimple))
        End Sub
        Private session As UnitOfWork
        Private Sub CreateConnection()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName

                Dim dataStore As IDataStore = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.None)
                Dim dataLayer As IDataLayer = New SimpleDataLayer(dataStore)
                session = New UnitOfWork(dataLayer)
            End If
        End Sub

        Private Sub splitContainerControl1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles splitContainerControl1.Resize
            splitContainerControl1.SplitterPosition = xtraTabControl1.Width \ 2
        End Sub

        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            If firstShow(xtraTabControl1.SelectedTabPageIndex) Then
                firstShow(xtraTabControl1.SelectedTabPageIndex) = False
                Select Case xtraTabControl1.SelectedTabPageIndex
                    Case 0
                        LoadFreeJoin()
                    Case 1
                        LoadSuppliersAssociation()
                        LoadSuppliersFreeJoin()
                    Case Else
                End Select
            End If
        End Sub


        '<splitContainerControl1>
        Private Sub LoadSuppliersAssociation()
            Dim sups As New XPCollection(Of Suppliers)(session, CriteriaOperator.Parse("Products[].Count() > 2"))
            gclAssociation.DataSource = sups
        End Sub
        Private Sub LoadSuppliersFreeJoin()
            Dim sups As New XPCollection(Of Suppliers)(session, CriteriaOperator.Parse("[<Products>][^.SupplierID = SupplierID].Count() > 2"))
            gclFreeJoin.DataSource = sups
        End Sub
        '</splitContainerControl1>

        '<gclFreeJoinMain>
        Private Sub LoadFreeJoin()
            Dim view As New XPView(session, GetType(Employees))
            view.Criteria = CriteriaOperator.Parse("[<Orders>][^.EmployeeID = EmployeeID].Count() > 50")
            view.AddProperty("FirstName", "FirstName")
            view.AddProperty("LastName", "LastName")
            view.AddProperty("OrderCount", "[<Orders>][^.EmployeeID = EmployeeID].Count()")
            view.AddProperty("OrderCount2", New JoinOperand("Orders", New OperandProperty("^.EmployeeID") = New OperandProperty("EmployeeID"), Aggregate.Count, Nothing))
            view.AddProperty("City", "City")
            view.AddProperty("CustomersInTheCity", "[<Customers>][^.City = City].Count()")
            view.AddProperty("LastAlphabeticalCustomerInTheCity", "[<Customers>][^.City = City].Max(ContactName)")
            gclFreeJoinMain.DataSource = view
        End Sub
        '</gclFreeJoinMain>
    End Class
End Namespace

