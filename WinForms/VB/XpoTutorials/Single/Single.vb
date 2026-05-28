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
	Partial Public Class [Single]
		Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property

		Private firstShow() As Boolean = { True, True }

		Public Sub New()
			InitializeComponent()
			CreateConnection()
			xtraTabControl1_SelectedPageChanged(Me, New DevExpress.XtraTab.TabPageChangedEventArgs(xtpSimple, xtpSimple))
		End Sub
		Private session As UnitOfWork
		Private Sub CreateConnection()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
			If (Not String.IsNullOrEmpty(DBFileName)) Then
				Dim dataStore As New InMemoryDataStore(AutoCreateOption.None)
				dataStore.ReadXml(DBFileName)
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
						LoadSingle()
					Case 1
						LoadSuppliersAssociation()
						LoadSuppliersSingle()
					Case Else
				End Select
			End If
		End Sub


		'<splitContainerControl1>
		Private Sub LoadSuppliersAssociation()
			Dim products As New XPCollection(Of Products)(session, CriteriaOperator.Parse("SupplierID.City = ?", "London"), New SortProperty("ProductName", SortingDirection.Ascending))
			gclReference.DataSource = products
		End Sub
		Private Sub LoadSuppliersSingle()
			Dim products As New XPCollection(Of Products)(session, CriteriaOperator.Parse("[<Suppliers>][SupplierID = ^.SupplierID].Single(City) = ?", "London"), New SortProperty("ProductName", SortingDirection.Ascending))
			gclSingle.DataSource = products
		End Sub
		'</splitContainerControl1>

		'<gclSingleMain>
		Private Sub LoadSingle()
			Dim view As New XPView(session, GetType(Employees))
            view.Criteria = CriteriaOperator.Parse("[<Orders>][^.EmployeeID = EmployeeID].Single() is not null")    '<-- Single
            view.AddProperty("Name", "LastName + ' ' + FirstName", False, True, SortDirection.Ascending)
            view.AddProperty("OrderDate", "[<Orders>][^.EmployeeID = EmployeeID].Single(OrderDate)")                '<-- Single
            view.AddProperty("OrderRequiredDate", "[<Orders>][^.EmployeeID = EmployeeID].Single(RequiredDate)")     '<-- Single
            view.AddProperty("OrderFreight", "[<Orders>][^.EmployeeID = EmployeeID].Single(Freight)")               '<-- Single
            view.AddProperty("City", "City")
            view.AddProperty("CustomersInTheCity", "[<Customers>][^.City = City].Count()")
            view.AddProperty("LastAlphabeticalCustomerInTheCity", "[<Customers>][^.City = City].Max(ContactName)")
			gclSingleMain.DataSource = view
			gviewSingleMain.Columns.ColumnByFieldName("Name").Group()
		End Sub
		'</gclSingleMain>
	End Class
End Namespace

