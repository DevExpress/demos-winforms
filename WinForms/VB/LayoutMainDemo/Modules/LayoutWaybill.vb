Imports System
Imports System.Data
Imports DevExpress.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class LayoutWaybill
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not Equals(DBFileName, "") Then
                dsOrder.ReadXml(DBFileName, XmlReadMode.InferSchema)
                rilProduct.DataSource = dsOrder.Products
            End If
        End Sub

        Private Sub ChangeData()
            dnNavigationCustomer.Position = CInt(dsOrder.Orders(dnNavigationOrders.Position)(dsOrder.Orders.Columns(2)))
            Dim str As String = CStr(dsOrder.Orders(dnNavigationOrders.Position)(dsOrder.Orders.Columns(1)))
            dnNavigationEmployee.Position = dsOrder.Customers.FindByCustomerID(str).Table.Rows.IndexOf(dsOrder.Customers.FindByCustomerID(str))
            ChangeFilter()
        End Sub

        Private Sub ChangeFilter()
            gridViewOrders.ActiveFilter.Clear()
            gridViewOrders.ActiveFilter.Add(gridViewOrders.Columns("OrderID"), New ColumnFilterInfo(String.Format("OrderID == '{0}'", dsOrder.Orders(dnNavigationOrders.Position).OrderID)))
        End Sub

        Private Sub dataNavigator1_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChangeData()
        End Sub

        Private Sub LayoutWaybill_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not DesignMode Then
                InitData()
                ChangeData()
            End If
        End Sub
    End Class
End Namespace
