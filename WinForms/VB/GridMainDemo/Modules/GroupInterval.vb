Imports System
Imports System.Collections
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for GroupInterval.
    ''' </summary>
    Public Partial Class GroupInterval
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub GroupInterval_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(350)
            InitDrawMode()
            icbeDrawMode.EditValue = gridView1.OptionsView.GroupDrawMode
            icbeAllowFixedGroups.EditValue = gridView1.OptionsBehavior.AllowFixedGroups
            cbeInterval.SelectedIndex = 0
            gridView1.ExpandGroupRow(-1)
            gridView1.TopRowIndex = 2
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GroupInterval"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "GroupInterval"
            End Get
        End Property

        Private Sub InitDrawMode()
            For Each mode As GroupDrawMode In [Enum].GetValues(GetType(GroupDrawMode))
                icbeDrawMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of GroupDrawMode).GetTitle(mode), mode, -1))
            Next

            For Each mode As DefaultBoolean In [Enum].GetValues(GetType(DefaultBoolean))
                icbeAllowFixedGroups.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of DefaultBoolean).GetTitle(mode), mode, -1))
            Next
        End Sub

        '<icbeDrawMode>
        Private Sub icbeDrawMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsView.GroupDrawMode = CType(icbeDrawMode.EditValue, GroupDrawMode)
        End Sub

        '</icbeDrawMode>
        '<icbeAllowFixedGroups>
        Private Sub icbeAllowFixedGroups_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridView1.OptionsBehavior.AllowFixedGroups = CType(icbeAllowFixedGroups.EditValue, DefaultBoolean)
        End Sub

        '</icbeAllowFixedGroups>
        '<cbeInterval>
        Private Sub cbeInterval_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If cbeInterval.EditValue.ToString().IndexOf("----") >= 0 Then
                cbeInterval.SelectedIndex = cbeInterval.Properties.Items.Count - 1
            Else
                SetGroupInterval(cbeInterval.SelectedIndex)
            End If
        End Sub

        Private Sub SetInterval(ByVal column As GridColumn, ByVal interval As ColumnGroupInterval)
            column.GroupInterval = interval
            column.GroupIndex = 0
        End Sub

        Private Sub SetSortMode(ByVal column As GridColumn, ByVal sortMode As ColumnSortMode)
            column.SortMode = sortMode
            column.GroupIndex = 0
        End Sub

        Private Sub SetGroupInterval(ByVal index As Integer)
            gridView1.BeginSort()
            Try
                gridView1.ClearGrouping()
                For Each column As GridColumn In gridView1.Columns
                    column.GroupInterval = ColumnGroupInterval.Default
                    column.SortMode = ColumnSortMode.Default
                Next

                Select Case index
                    Case 0
                        SetInterval(gridColumn1, ColumnGroupInterval.Alphabetical)
                        gridColumn2.GroupInterval = ColumnGroupInterval.Alphabetical
                    Case 1
                        SetInterval(gridColumn5, ColumnGroupInterval.DateMonth)
                    Case 2
                        SetInterval(gridColumn5, ColumnGroupInterval.DateYear)
                    Case 3
                        SetInterval(gridColumn5, ColumnGroupInterval.DateRange)
                    Case 4
                        SetSortMode(gridColumn4, ColumnSortMode.Custom)
                    Case Else
                        SetInterval(gridColumn2, ColumnGroupInterval.Value)
                End Select
            Finally
                gridView1.EndSort()
                gridView1.CollapseAllGroups()
            End Try
        End Sub

        Private Sub gridView1_CustomColumnGroup(ByVal sender As Object, ByVal e As CustomColumnSortEventArgs)
            Dim x As Double = Math.Floor(Convert.ToDouble(e.Value1) / 100)
            Dim y As Double = Math.Floor(Convert.ToDouble(e.Value2) / 100)
            Dim res As Integer = Comparer.Default.Compare(x, y)
            If x > 14 AndAlso y > 14 Then res = 0
            e.Result = res
            e.Handled = True
        End Sub

        '</cbeInterval>
        Private Function IntervalByValue(ByVal val As Object) As String
            Dim d As Double = Math.Floor(Convert.ToDouble(val) / 100)
            Dim ret As String = String.Format("{0:c} - {1:c} ", d * 100, (d + 1) * 100)
            If d > 14 Then ret = String.Format(">= {0:c} ", d * 100)
            Return ret
        End Function

        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs)
            Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
            If info Is Nothing Then Return
            If info.Column.SortMode <> ColumnSortMode.Custom Then Return
            Dim interval As String = IntervalByValue(gridView1.GetGroupRowValue(info.RowHandle))
            Dim sumText As String = gridView1.GetGroupSummaryText(info.RowHandle)
            info.GroupText = String.Format("{2}: {0}{1}", interval, sumText, Properties.Resources.OrderSum)
        End Sub

        Private Sub gridView1_CellMerge(ByVal sender As Object, ByVal e As CellMergeEventArgs)
            If Equals(e.Column.FieldName, "Order Date") Then
                Dim view As GridView = TryCast(sender, GridView)
                Dim val1 As Object = view.GetRowCellValue(e.RowHandle1, e.Column)
                Dim val2 As Object = view.GetRowCellValue(e.RowHandle2, e.Column)
                Dim dt1 As Date = If(val1 IsNot DBNull.Value, Convert.ToDateTime(val1), Date.MinValue)
                Dim dt2 As Date = If(val2 IsNot DBNull.Value, Convert.ToDateTime(val2), Date.MinValue)
                e.Merge = dt1.Date = dt2.Date
                e.Handled = True
            End If
        End Sub

        Private Sub gridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As GridMenuItemClickEventArgs)
            If e.MenuType <> GridMenuType.Column Then Return
            If gridView1.GroupCount <> 1 Then Return
            Select Case e.SummaryFormat
                Case "DateMonth"
                    cbeInterval.SelectedIndex = 1
                Case "DateYear"
                    cbeInterval.SelectedIndex = 2
                Case "DateRange"
                    cbeInterval.SelectedIndex = 3
            End Select
        End Sub

        Private Sub gridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.MenuType <> GridMenuType.Column Then Return
            Dim menu As DXSubMenuItem = TryCast(e.Menu.Find(GridStringId.MenuColumnGroupIntervalMenu), DXSubMenuItem)
            If menu Is Nothing Then Return
            For i As Integer = menu.Items.Count - 1 To 0 Step -1
                If Equals(menu.Items(i).Caption, GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnGroupIntervalNone)) OrElse Equals(menu.Items(i).Caption, GridLocalizer.Active.GetLocalizedString(GridStringId.MenuColumnGroupIntervalDay)) Then menu.Items.RemoveAt(i)
            Next
        End Sub

#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides ReadOnly Property ExportView As BaseView
            Get
                Return gridView1
            End Get
        End Property
#End Region
    End Class
End Namespace
