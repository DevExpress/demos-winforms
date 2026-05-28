Imports System
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for SortingBySummary.
    ''' </summary>
    Public Partial Class SortingBySummary
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1)
        ' TODO: Add any initialization after the InitForm call
        '<gridControl1>
        ' 
        ' ~Note: the following properties are set at design time and listed here only for demonstration purposes.
        ' gridView1.GroupSummary.AddRange(new GridSummaryItem[] {
        ' new GridGroupSummaryItem(SummaryItemType.Count, "Product Name", null, "(Product: Count {0})"),
        ' new GridGroupSummaryItem(SummaryItemType.Sum, "Order Sum", null, "(Orders: Sum {0:c})"),
        ' new GridGroupSummaryItem(SummaryItemType.Average, "Unit Price", null, "(Price: Avg {0:c})")});
        ' 
        '</gridControl1>
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"SortingBySummary"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "SortingBySummary"
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As Views.Base.BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private Sub SortingBySummary_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(500, False)
            cbeSorting.SelectedIndex = 4
        End Sub

        '<cbeSorting>
        Private ReadOnly Property GroupColumn As GridColumn
            Get
                Return gridColumn5
            End Get
        End Property

        Private ReadOnly Property CurrentSummaryItemIndex As Integer
            Get
                Return CInt(cbeSorting.SelectedIndex) \ 2 - 1
            End Get
        End Property

        Private ReadOnly Property CurrentSortOrder As ColumnSortOrder
            Get
                Return If(cbeSorting.SelectedIndex Mod 2 = 0, ColumnSortOrder.Ascending, ColumnSortOrder.Descending)
            End Get
        End Property

        Private Sub cbeSorting_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.BeginSort()
            Try
                gridView1.GroupSummarySortInfo.Clear()
                GroupColumn.SortOrder = CurrentSortOrder
                If CurrentSummaryItemIndex >= 0 Then gridView1.GroupSummarySortInfo.Add(gridView1.GroupSummary(CurrentSummaryItemIndex), CurrentSortOrder, GroupColumn)
            Finally
                gridView1.EndSort()
            End Try
        End Sub

        '</cbeSorting>
        Private columns As String() = New String() {"Empty", "Product", "Order", "Price"}

        Private Sub gridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As GridMenuItemClickEventArgs)
            If e.MenuType <> GridMenuType.Column OrElse e.SummaryItem Is Nothing Then Return
            cbeSorting.SelectedIndex = -1
            Dim index As Integer = -1
            For i As Integer = 1 To columns.Length - 1
                If e.DXMenuItem.Caption.IndexOf(columns(i), StringComparison.OrdinalIgnoreCase) > -1 Then index = i * 2
            Next

            If e.SummaryFormat.Equals($"{SortOrder.Descending}") Then index += 1
            cbeSorting.SelectedIndex = index
            e.Handled = True
        End Sub

#Region "GenerateReport"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
