Imports System
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
'<icbNewItemRow>
Imports DevExpress.XtraGrid.Views.Grid
'</icbNewItemRow>
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for TableView.
    ''' </summary>
    Public Partial Class TableView
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TableView"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "TableView"
            End Get
        End Property

        Private updateLayout As Boolean = False

        Private firstSearch As Boolean = True

        '<sbStart>
        Private searshString As String() = New String() {"c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}"}

        Private searchKeyIndex As Integer = 0

        '</sbStart>
#Region "Init"
        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property

        Private Sub TableView_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitNWindData()
            InitEditing()
            SetButtonEnabled()
            gridView1_Layout(gridView1, EventArgs.Empty)
        End Sub

        Public Overrides ReadOnly Property ShowViewOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Private tblGrid As String = "Order Details"

        Private tblLookUp As String = "Products"

        Private ds As DataSet = New DataSet()

        Protected Overrides Function InitNWindXMLData(ByVal dataFileName As String) As DataSet
            SetWaitDialogCaption(Properties.Resources.LoadingTables)
            ds.ReadXml(dataFileName)
            gridControl1.DataSource = ds.Tables(tblGrid)
            repositoryItemLookUpEdit1.DataSource = ds.Tables(tblLookUp)
            Return ds
        End Function

        Private Sub InitEditing()
            icbNewItemRow.Properties.Items.Add(Properties.Resources.None, NewItemRowPosition.None, -1)
            icbNewItemRow.Properties.Items.Add(Properties.Resources.Top, NewItemRowPosition.Top, -1)
            icbNewItemRow.Properties.Items.Add(Properties.Resources.Bottom, NewItemRowPosition.Bottom, -1)
            icbButtons.Properties.Items.Add(Properties.Resources.DefaultString, ShowButtonModeEnum.Default, -1)
            icbButtons.Properties.Items.Add(Properties.Resources.ShowAlways, ShowButtonModeEnum.ShowAlways, -1)
            icbButtons.Properties.Items.Add(Properties.Resources.ShowForFocusedCell, ShowButtonModeEnum.ShowForFocusedCell, -1)
            icbButtons.Properties.Items.Add(Properties.Resources.ShowForFocusedRow, ShowButtonModeEnum.ShowForFocusedRow, -1)
            icbButtons.Properties.Items.Add(Properties.Resources.ShowOnlyInEditor, ShowButtonModeEnum.ShowOnlyInEditor, -1)
            icbButtons.EditValue = gridView1.OptionsView.ShowButtonMode
            icbSelectMode.Properties.Items.Add(Properties.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1)
            icbSelectMode.Properties.Items.Add(Properties.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1)
            icbSelectMode.Properties.Items.Add(Properties.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1)
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode
            chEdit.Checked = gridView1.OptionsBehavior.Editable
            ceHotTrackRow.Checked = gridView1.OptionsSelection.EnableAppearanceHotTrackedRow = DefaultBoolean.True
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeDisabled, GridInHeaderSearchMode.Disabled, -1)
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeTextFilter, GridInHeaderSearchMode.TextFilter, -1)
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeTextSearch, GridInHeaderSearchMode.TextSearch, -1)
            icbInHeaderFilterMode.EditValue = gridView1.OptionsFilter.InHeaderSearchMode
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeNone, ShowInHeaderSearchResultsMode.None, -1)
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeText, ShowInHeaderSearchResultsMode.Text, -1)
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeTextAndPosition, ShowInHeaderSearchResultsMode.TextAndPosition, -1)
            icbShowSearchResults.EditValue = gridView1.OptionsFilter.ShowInHeaderSearchResults
            gridControl1.UseEmbeddedNavigator = True
            UpdateShowSearchResultsVisible()
        End Sub

#End Region
#Region "Editing"
        Private Sub gridView1_Layout(ByVal sender As Object, ByVal e As EventArgs)
            updateLayout = True
            icbNewItemRow.EditValue = gridView1.OptionsView.NewItemRowPosition
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect
            SetPosition()
            updateLayout = False
        End Sub

        Private Sub navigationPane1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs)
            If e.Page Is navigationPage2 Then
                gridView1.OptionsBehavior.AllowIncrementalSearch = True
                If firstSearch Then StartSearch()
                firstSearch = False
            Else
                gridView1.OptionsBehavior.AllowIncrementalSearch = False
                If Not firstSearch Then StopSearch()
            End If
        End Sub

#End Region
#Region "NewItemRow"
        '<icbNewItemRow>
        Private Sub icbNewItemRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            '<skip>
            If updateLayout Then Return
            '</skip>
            gridView1.OptionsView.NewItemRowPosition = CType(icbNewItemRow.EditValue, NewItemRowPosition)
            SetPosition()
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1)
        '</skip>
        End Sub

        Private Sub SetPosition()
            If gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom AndAlso gridView1.SortInfo.GroupCount = 0 Then
                gridView1.FocusedRowHandle = gridView1.RowCount - 2
                gridView1.MakeRowVisible(gridView1.FocusedRowHandle, False)
            End If
        End Sub

        '</icbNewItemRow>
        Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs)
            Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
            Dim orderId As Integer = 99999
            row("Quantity") = 1
            row("UnitPrice") = 0
            row("Discount") = 0
            row("OrderID") = orderId
            AddOrderParentRow(orderId)
        End Sub

        Private Sub AddOrderParentRow(ByVal id As Integer)
            For Each row As DataRow In ds.Tables("Orders").Rows
                If id.Equals(row("OrderID")) Then Return
            Next

            ds.Tables("Orders").Rows.Add(New Object() {id})
        End Sub

#End Region
#Region "Incremental Search"
        '<sbStart>
        Private Sub StartSearch()
            sbStart.Enabled = False
            searchKeyIndex = 0
            lbEvent.Text = Properties.Resources.TableView_AutoSearch
            gridView1.FocusedColumn = gridColumn2
            timer1.Start()
        End Sub

        Private Sub StopSearch()
            sbStart.Enabled = True
            timer1.Stop()
            lbEvent.Text = Properties.Resources.TableView_IncrementalSearch
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Form.ActiveForm Is Nothing OrElse Not Visible Then Return
            gridControl1.Focus()
            If searchKeyIndex > searshString.Length - 1 Then
                searchKeyIndex = 0
            Else
                SendKeys.Send(searshString(searchKeyIndex))
                searchKeyIndex += 1
            End If
        End Sub

        Private Sub gridControl1_ProcessGridKey(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Escape Then StopSearch()
        End Sub

        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            StopSearch()
        End Sub

        Private Sub sbStart_Click(ByVal sender As Object, ByVal e As EventArgs)
            StartSearch()
        End Sub

        '</sbStart>
#End Region
#Region "Editing And Navigation"
        '<icbButtons>
        Private Sub icbButtons_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsView.ShowButtonMode = CType(icbButtons.EditValue, ShowButtonModeEnum)
        End Sub

        '</icbButtons>
        '<chEdit>
        Private Sub chEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsBehavior.Editable = chEdit.Checked
        End Sub

        '</chEdit>
        Private Function EditRecord() As Boolean
            Dim row As DataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle)
            If row Is Nothing Then Return False
            StopSearch()
            Using frm As PopupForm = New PopupForm()
                frm.InitData(FindForm(), gridControl1, gridView1, row)
                Dim ret As Boolean = frm.ShowDialog() = DialogResult.OK
                If ret Then
                    row.ItemArray = frm.Row.ItemArray
                    row.EndEdit()
                End If

                Return ret
            End Using
        End Function

        Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
            If e.Button.ButtonType = NavigatorButtonType.Edit Then
                EditRecord()
                e.Handled = True
            End If

            If e.Button.ButtonType = NavigatorButtonType.Append Then
                gridView1.AddNewRow()
                If EditRecord() Then
                    gridView1.UpdateCurrentRow()
                Else
                    gridView1.CancelUpdateCurrentRow()
                End If

                e.Handled = True
            End If
        End Sub

#End Region
#Region "MultiSelect"
        Private Sub UpdateSelection()
            Dim updateCells As Boolean = gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect
            If ceMultiSelect.Checked Then
                If Not updateCells Then
                    gridView1.SelectRange(4, 20)
                    sbRecords.Text = Properties.Resources.ShowSelectedRecords
                Else
                    gridView1.ClearSelection()
                    gridView1.SelectCells(5, gridView1.Columns("ProductID"), 15, gridView1.Columns("Quantity"))
                    sbRecords.Text = Properties.Resources.ShowSelectedValues
                End If
            End If
        End Sub

        '<ceMultiSelect>
        Private Sub ceMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            '<skip>
            SetButtonEnabled()
            If updateLayout Then Return
            '</skip>
            gridView1.OptionsSelection.MultiSelect = ce.Checked
            UpdateSelection()
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1)
        '</skip>
        End Sub

        '</ceMultiSelect>
        Private Sub SetButtonEnabled()
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 AndAlso ceMultiSelect.Checked
            icbSelectMode.Enabled = ceMultiSelect.Checked
        End Sub

        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs)
            SetButtonEnabled()
        End Sub

        '<sbRecords>
        Private Sub sbRecords_Click(ByVal sender As Object, ByVal e As EventArgs)
            DemosHelper.ShowDescriptionForm(MousePosition, GetSelectedRows(gridView1), If(gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect, Properties.Resources.SelectedCells, Properties.Resources.SelectedRows))
        End Sub

        Private Function GetSelectedRows(ByVal view As GridView) As String
            Dim ret As String = ""
            Dim rowIndex As Integer = -1
            If view.OptionsSelection.MultiSelectMode <> GridMultiSelectMode.CellSelect Then
                For Each i As Integer In gridView1.GetSelectedRows()
                    Dim row As DataRow = gridView1.GetDataRow(i)
                    If Not Equals(ret, "") Then ret += Microsoft.VisualBasic.Constants.vbCrLf
                    ret += String.Format("{2}: #{0} {1}", row("OrderID"), gridView1.GetRowCellDisplayText(i, gridColumn2), Properties.Resources.Order)
                Next
            Else
                For Each cell As GridCell In view.GetSelectedCells()
                    If rowIndex <> cell.RowHandle Then
                        If Not Equals(ret, "") Then ret += Microsoft.VisualBasic.Constants.vbCrLf
                        ret += String.Format("{1}: #{0}", cell.RowHandle, Properties.Resources.Row)
                    End If

                    ret += Microsoft.VisualBasic.Constants.vbCrLf & "    " & view.GetRowCellDisplayText(cell.RowHandle, cell.Column)
                    rowIndex = cell.RowHandle
                Next
            End If

            Return ret
        End Function

        '</sbRecords>
        '<icbSelectMode>
        Private Sub icbSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsSelection.MultiSelectMode = CType(icbSelectMode.EditValue, GridMultiSelectMode)
            UpdateSelection()
        End Sub

        '</icbSelectMode>
#End Region
        '<ceHotTrackRow>
        Private Sub ceHotTrackRow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            gridView1.OptionsSelection.EnableAppearanceHotTrackedRow = If(ce.Checked, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        '</ceHotTrackRow>
        Private Sub icbInHeaderFilterMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim icb As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.ClearInHeaderSearchText()
            gridView1.OptionsFilter.InHeaderSearchMode = CType(icb.EditValue, GridInHeaderSearchMode)
            UpdateShowSearchResultsVisible()
        End Sub

        Private Sub UpdateShowSearchResultsVisible()
            lciShowSearchResults.Visibility = If(gridView1.OptionsFilter.InHeaderSearchMode = GridInHeaderSearchMode.TextSearch, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        Private Sub icbShowSearchResults_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim icb As ImageComboBoxEdit = TryCast(sender, ImageComboBoxEdit)
            gridView1.OptionsFilter.ShowInHeaderSearchResults = CType(icb.EditValue, ShowInHeaderSearchResultsMode)
        End Sub
    End Class
End Namespace
