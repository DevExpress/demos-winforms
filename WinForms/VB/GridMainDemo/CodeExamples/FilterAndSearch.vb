Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Filter and search", "FilterAndSearch.cs")>
    Public Module FilterAndSearch

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Filtering and Searching"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter data using ActiveFilterString"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterString")>
        Public Sub FilterGridViewInCodeUsingActiveFilterString(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.ActiveFilterString = "Contains([Name], 'Blue')"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter data using ActiveFilter"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterCriteria", "ActiveFilter")>
        Public Sub FilterGridViewInCode(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim btnAddFilter As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Add additional filter", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The ActiveFilter property returns an object which represents the filter criteria for the current View
            AddHandler btnAddFilter.Click, Sub(s, e) gridView.ActiveFilter.Add(gridView.Columns("ID"), New DevExpress.XtraGrid.Columns.ColumnFilterInfo(String.Format("[{0}] > '3'", "ID"), ""))
            Dim bthApplyFilter As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Apply new filter", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler bthApplyFilter.Click, Sub(s, e)
                Dim expr1 As DevExpress.Data.Filtering.CriteriaOperator = New DevExpress.Data.Filtering.BinaryOperator("ID", 2, DevExpress.Data.Filtering.BinaryOperatorType.GreaterOrEqual)
                Dim expr2 As DevExpress.Data.Filtering.CriteriaOperator = New DevExpress.Data.Filtering.BinaryOperator("Length", 25, DevExpress.Data.Filtering.BinaryOperatorType.Greater)
                ' Use the ActiveFilterCriteria property to specify the filter criteria 
                ' by using the DevExpress.Data.Filtering.CriteriaOperator object
                gridView.ActiveFilterCriteria = DevExpress.Data.Filtering.GroupOperator.[Or](New DevExpress.Data.Filtering.CriteriaOperator() {expr1, expr2})
            End Sub
            Dim chkFilterEnabled As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit With {.Parent = gridControl.Parent, .Text = "ActiveFilterEnabled ", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The filter can be temporarily disabled by using the GridView.ActiveFilterEnabled property
            chkFilterEnabled.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", gridView, "ActiveFilterEnabled", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Search using the Find Panel"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ApplyFindFilter")>
        Public Sub SetFindPanelTextInCode(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The AlwaysVisible property is used to determine whether the Find Panel is always visible
            gridView.OptionsFind.AlwaysVisible = True
            ' The ApplyFindFilter method searches for the specified string, using the search functionality provided by the Find Panel
            ' You can call this method in code, to manually invoke the search.
            gridView.ApplyFindFilter("Blue")
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Display a custom filter dialog"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomFilterDialog", "ShowFilterEditor")>
        Public Sub CustomFilterDialog(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridView.Columns
                col.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List
            Next

            ' The CustomFilterDialog event allows replacing the default CustomFilterDialog with custom filtering facilities.
            AddHandler gridView.CustomFilterDialog, Sub(s, e)
                gridView.GridControl.BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() gridView.ShowFilterEditor(e.Column)))
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show the Filter Editor"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowFilterEditor")>
        Public Sub ShowFilterEditor(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Show Filter Editor", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Display the Filter Editor
            AddHandler b.Click, Sub(s, e) gridView.ShowFilterEditor(gridView.FocusedColumn)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter rows dynamically"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomRowFilter", "Visible")>
        Public Sub CustomRowFilter(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The CustomRowFilter event allows you to hide rows or make them visible regardless of the active filter.
            AddHandler gridView.CustomRowFilter, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim lst As System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = TryCast(view.DataSource, System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData))
                Dim current As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = lst(e.ListSourceRow)
                If current.ID > 2 Then
                    e.Visible = True
                Else
                    e.Visible = False
                End If

                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize the Filter Editor when it is displayed"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowFilterEditor", "FilterEditorCreated", "BeforeShowValueEditor")>
        Public Sub FilterEditorCreated(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Show Filter Editor", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ShowFilterEditor(gridView.Columns("ID"))
            Dim handler As DevExpress.XtraEditors.Filtering.ShowValueEditorEventHandler = Sub(s, e)
                If Not Equals(e.CurrentNode.FirstOperand.PropertyName, "ID") Then Return
                e.CustomRepositoryItem = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            End Sub
            ' Handle this event to customize the FilterEditor or prevent it from being displayed
            AddHandler gridView.FilterEditorCreated, Sub(s, e)
                RemoveHandler e.FilterControl.BeforeShowValueEditor, handler
                AddHandler e.FilterControl.BeforeShowValueEditor, handler
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Replace a filter when it is applied"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterCriteria", "SubstituteFilter", "Filter")>
        Public Sub SubstituteFilter(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Apply Filter", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e) gridView.ActiveFilterCriteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("{0} > 0", "ID"))
            'Handle the SubstituteFilter event to replace a filter applied with another filter.
            'Do not modify the existing filter object assigned to the Filter event parameter. 
            'To replace this filter, assign a new filter criterion to this parameter.     
            'Display records with ID <5 
            AddHandler gridView.SubstituteFilter, Sub(s, e) e.Filter = e.Filter And DevExpress.Data.Filtering.CriteriaOperator.Parse(String.Format("{0} < 5", "ID"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Obtain filtered rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterString")>
        Public Sub GetFilteredRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.ActiveFilterString = "Contains([Name], 'Blue')"
            Dim btnObtainFilteredRows As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Obtain filtered rows", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler btnObtainFilteredRows.Click, Sub(s, e)
                Dim filteredRows As System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = New System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)()
                For i As Integer = 0 To gridView.RowCount - 1 ' traverse through all currently visible rows within GridView
                    Dim row As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = CType(gridView.GetRow(i), DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) ' obtain an object that represents the processed row in a grid data source
                    filteredRows.Add(row)
                Next

                Call DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Filtered rows: {0}", filteredRows.Count))
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hide duplicate values"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomRowFilter")>
        Public Sub HideDuplicateValues(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to hide particular rows based on your own rules
            AddHandler gridView.CustomRowFilter, Sub(s, e)
                Dim dataSource As System.Collections.Generic.IList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = TryCast(gridControl.DataSource, System.Collections.Generic.IList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData))
                Dim currentRow As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = dataSource(e.ListSourceRow)
                Dim processedRow As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData
                For i As Integer = e.ListSourceRow - 1 To -1 + 1 Step -1
                    processedRow = dataSource(i)
                    If currentRow.Mark = processedRow.Mark Then
                        e.Visible = False
                        e.Handled = True
                        Exit For
                    End If
                Next
            End Sub
        End Sub
#End Region
    End Module
End Namespace
