Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for GridLookUpEdit.
    ''' </summary>
    Public Partial Class SearchLookUpEditDemo
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            InitNWindData()
            ' TODO: Add any initialization after the InitForm call
            searchLookUpEdit1.Properties.ShowClearButton = False
            AddHandler repositoryItemSearchLookUpEdit2.GetImageByValue, AddressOf repositoryItemSearchLookUpEdit2_GetImageByValue
        '<searchLookUpEdit1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' 
        ' ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
        ' searchLookUpEdit1.Properties.DataSource = dsNWindProducts1.Products;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' searchLookUpEdit1.Properties.DisplayMember = "ProductName";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' searchLookUpEdit1.Properties.ValueMember = "ProductID";
        ' 
        ' ~Specify a GridView that will render data in the dropdown window:
        ' searchLookUpEdit1.Properties.View = gridLookUpEdit1View;
        ' 
        '</searchLookUpEdit1>
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
        ' ~Settings of the Customer column's SearchLookUpEdit in-place editor:
        ' 
        ' ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
        ' repositoryItemSearchLookUpEdit1.DataSource = dsNWindCustomers1.Customers;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' repositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' repositoryItemSearchLookUpEdit1.ValueMember = "CustomerID";
        ' 
        ' ~Specify a GridView that will render data in the dropdown window:
        ' repositoryItemSearchLookUpEdit1.View = repositoryItemSearchLookUpEdit1View;
        ' 
        ' 
        ' ~Settings of the Employee column's SearchLookUpEdit in-place editor:
        ' 
        ' ~Assign a data source containing data to be displayed in the SearchLookUpEdit's dropdown window:
        ' repositoryItemSearchLookUpEdit2.DataSource = dsNWindCustomers1.Employees;
        ' 
        ' ~Specify the field whose values are displayed in the edit box:
        ' repositoryItemSearchLookUpEdit2.DisplayMember = "Name";
        ' 
        ' ~Specify the key field whose values identify dropdown rows:
        ' repositoryItemSearchLookUpEdit2.ValueMember = "EmployeeID";
        ' 
        ' ~Specify an AdvBandedGridView that will render data in the dropdown window:
        ' repositoryItemSearchLookUpEdit2.View = repositoryItemSearchLookUpEdit2View;
        ' 
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"SearchLookUpEditDemo", "SearchLookUpProperties"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "SearchLookUpEditDemo"
            End Get
        End Property

        Private Sub repositoryItemSearchLookUpEdit2_GetImageByValue(ByVal sender As Object, ByVal e As ImageByValueEventArgs)
            Dim repository As RepositoryItemSearchLookUpEditWithGlyph = TryCast(sender, RepositoryItemSearchLookUpEditWithGlyph)
            Dim dt As DataTable = TryCast(repository.DataSource, DataTable)
            Dim row As DataRow = Nothing
            Try
                row = dt.Rows.Find(e.Value)
            Catch
            End Try

            If row IsNot Nothing Then
                e.Image = row("Photo")
            End If
        End Sub

        Private Sub GridLookUpEdit_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim lp As SearchLookUpProperties = New SearchLookUpProperties(searchLookUpEdit1)
            lp.Dock = DockStyle.Right
            lp.Parent = xtraScrollableControl1
            '<dataNavigator1>
            ' 
            ' ~Bind the SearchLookUpEdit's EditValue to the ProductID field in the Order_Details table:
            ' 
            searchLookUpEdit1.DataBindings.Add(New Binding("EditValue", dsNWindProducts1.Order_Details, "ProductID"))
        '</dataNavigator1>
        End Sub

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            filterConditionEdit.Properties.AddEnum(Of Data.Filtering.FilterCondition)()
            filterConditionEdit.EditValue = Data.Filtering.FilterCondition.Default
            parserKindEdit.Properties.AddEnum(Of Data.Filtering.FindPanelParserKind)()
            parserKindEdit.Properties.Items.Remove(Data.Filtering.FindPanelParserKind.Custom)
            parserKindEdit.EditValue = Data.Filtering.FindPanelParserKind.Default
            '<autoSearchLookUpEdit>
            autoSearchLookUpEdit.Properties.DataSource = All
            autoSearchLookUpEdit.Properties.DisplayMember = "Text"
            autoSearchLookUpEdit.Properties.SearchMode = XtraEditors.Repository.GridLookUpSearchMode.AutoSearch
            '</autoSearchLookUpEdit>
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

        Private Sub searchLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As SearchLookUpEditWithGlyph = TryCast(sender, SearchLookUpEditWithGlyph)
            If edit Is Nothing Then Return
            If edit.EditValue Is Nothing Then
                edit.Image = Nothing
            Else
                Dim dt As DataTable = TryCast(edit.Properties.DataSource, DataTable)
                If dt Is Nothing Then Return
                Dim row As DataRow = dt.Rows.Find(edit.EditValue)
                edit.Image = DemoHelper.CategorySvgImages.GetImage(Convert.ToInt32(row("CategoryID")) - 1, DemoHelper.CategorySvgImages.ScaledImageSize)
            End If
        End Sub

        Private Sub searchLookUpEdit1_AddNewValue(ByVal sender As Object, ByVal e As AddNewValueEventArgs)
            Dim edit As SearchLookUpEditWithGlyph = TryCast(sender, SearchLookUpEditWithGlyph)
            Dim dt As DataTable = TryCast(edit.Properties.DataSource, DataTable)
            Using frm As frmProduct = New frmProduct()
                If frm.ShowDialog(FindForm()) = DialogResult.OK Then
                    Dim dr As DataRow = dt.Rows.Add(frm.CategoryID, frm.Discontinued, Nothing, frm.NewProductName, frm.QuantityPerUnit, 0, 0, frm.UnitPrice, 1, 1)
                    dr.AcceptChanges()
                    e.NewValue = dr("ProductID")
                Else
                    e.Cancel = True
                End If
            End Using
        End Sub

        '<autoSearchLookUpEdit>
        Private Sub LookUpEdit_AutoSearch(ByVal sender As Object, ByVal e As LookUpEditAutoSearchEventArgs)
            Dim parseKind = CType(parserKindEdit.EditValue, Data.Filtering.FindPanelParserKind)
            Dim filterCondition = CType(filterConditionEdit.EditValue, Data.Filtering.FilterCondition)
            e.SetParameters(parseKind, filterCondition)
        End Sub
    '</autoSearchLookUpEdit>
    End Class
End Namespace
