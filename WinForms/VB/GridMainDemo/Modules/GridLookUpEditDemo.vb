Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for GridLookUpEdit.
    ''' </summary>
    Public Partial Class GridLookUpEditDemo
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
        ' TODO: Add any initialization after the InitForm call
        '<gridLookUpEdit1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' 
        ' ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
        ' gridLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' gridLookUpEdit1.Properties.DisplayMember = "ProductName";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' gridLookUpEdit1.Properties.ValueMember = "ProductID";
        ' 
        ' ~Specify a GridView that will render data in the dropdown window:
        ' gridLookUpEdit1.Properties.View = gridLookUpEdit1View;
        ' 
        '</gridLookUpEdit1>
        '<dataNavigator1>
        ' 
        ' ~Note: the following property is set at design time and listed here only for demonstration purposes.
        ' 
        ' ~The DataNavigator will navigate through the Order_Details data source:
        ' dataNavigator1.DataSource = dsNWindProducts1.Order_Details;
        ' 
        '</dataNavigator1>
        '<gridControl1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' 
        ' ~Settings of the Customer column's GridLookUpEdit in-place editor:
        ' 
        ' ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
        ' repositoryItemGridLookUpEdit1.DataSource = dsNWindCustomers1.Customers;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' repositoryItemGridLookUpEdit1.DisplayMember = "CompanyName";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' repositoryItemGridLookUpEdit1.ValueMember = "CustomerID";
        ' 
        ' ~Specify a GridView that will render data in the dropdown window:
        ' repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
        ' 
        ' 
        ' ~Settings of the Employee column's GridLookUpEdit in-place editor:
        ' 
        ' ~Assign a data source containing data to be displayed in the GridLookUpEdit's dropdown window:
        ' repositoryItemGridLookUpEdit2.DataSource = dsNWindCustomers1.Employees;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' repositoryItemGridLookUpEdit2.DisplayMember = "Name";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' repositoryItemGridLookUpEdit2.ValueMember = "EmployeeID";
        ' 
        ' ~Specify an AdvBandedGridView that will render data in the dropdown window:
        ' repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
        ' 
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GridLookUpEditDemo", "LookUpProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GridLookUpEditDemo"
            End Get
        End Property

        Private Sub GridLookUpEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim lp As LookUpProperties = New LookUpProperties(gridLookUpEdit1)
            lp.Dock = DockStyle.Right
            lp.Parent = xtraScrollableControl1
            Dim lpTiles As LookUpProperties = New LookUpProperties(gridLookUpEdit2)
            lpTiles.Dock = DockStyle.Right
            lpTiles.Parent = tabPage3
            '<dataNavigator1>
            ' 
            ' ~Bind the GridLookUpEdit's EditValue to the ProductID field in the Order_Details table:
            ' 
            gridLookUpEdit1.DataBindings.Add(New Binding("EditValue", dsNWindProducts1.Order_Details, "ProductID"))
            '</dataNavigator1>
            gridLookUpEdit2.EditValue = dsNWindCustomers1.Employees(0).EmployeeID
            CreateTimer()
        End Sub

        Protected Overrides Sub OnTick()
            If DXperience.Demos.ModulesInfo.CurrentModule Is Me Then
                If tabPane1.SelectedPage Is tabPage1 Then gridLookUpEdit1.ShowPopup()
                If tabPane1.SelectedPage Is tabPage3 Then gridLookUpEdit2.ShowPopup()
            End If
        End Sub

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            dsNWindProducts1.ReadXml(dataFileName, XmlReadMode.InferSchema)
            dsNWindCustomers1.ReadXml(dataFileName, XmlReadMode.InferSchema)
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1)
            Return dsNWindCustomers1
        End Function

        Private Sub repositoryItemGridLookUpEdit1View_CalcPreviewText(ByVal sender As Object, ByVal e As CalcPreviewTextEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If view Is Nothing Then Return
            Dim row As DataRow = view.GetDataRow(e.RowHandle)
            If row Is Nothing Then Return
            Dim _region As String = If(row("Region") IsNot DBNull.Value, String.Format("{0}, ", row("Region")), "")
            e.PreviewText = String.Format("{0}{1}, {2}, {3}" & Microsoft.VisualBasic.Constants.vbCrLf & "{4}, {5}", _region, row("Country"), row("City"), row("PostalCode"), row("Address"), row("Phone"))
        End Sub

        Private Sub gridLookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.ProcessNewValueEventArgs)
            dsNWindProducts1.Products.Rows.Add(New Object() {0, False, Environment.TickCount, e.DisplayValue})
            e.Handled = True
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            If gridLookUpEdit1.IsPopupOpen Then gridLookUpEdit1.ClosePopup()
            If gridLookUpEdit2.IsPopupOpen Then gridLookUpEdit2.ClosePopup()
        End Sub
    End Class
End Namespace
