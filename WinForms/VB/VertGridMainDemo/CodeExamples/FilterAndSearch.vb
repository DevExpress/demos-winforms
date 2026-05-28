Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.Utils

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Filter and search", "FilterAndSearch.cs")>
    Public Module FilterAndSearch

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Filtering and Searching"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter data using ActiveFilterString"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterString")>
        Public Sub FilterGridViewInCodeUsingActiveFilterString(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            vGridControl.ActiveFilterString = "Contains([Name], 'Blue')"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter data using ActiveFilter"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterCriteria", "ActiveFilter")>
        Public Sub FilterGridViewInCode(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            Dim btnAddFilter As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Apply the ActiveFilter-based filtering", .Dock = System.Windows.Forms.DockStyle.Top}
            ' The ActiveFilter property allows you to build filter expressions manually
            AddHandler btnAddFilter.Click, Sub(s, e) vGridControl.ActiveFilter.Add(vGridControl.GetRowByFieldName(CStr(("ID"))).Properties, New DevExpress.XtraVerticalGrid.Rows.VGridRowFilterInfo(String.Format("[{0}] > '3'", "ID"), ""))
            Dim bthApplyFilter As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Apply the ActiveFilterCriteria-based filtering", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler bthApplyFilter.Click, Sub(s, e)
                Dim expr1 As DevExpress.Data.Filtering.CriteriaOperator = New DevExpress.Data.Filtering.BinaryOperator("ID", 2, DevExpress.Data.Filtering.BinaryOperatorType.GreaterOrEqual)
                Dim expr2 As DevExpress.Data.Filtering.CriteriaOperator = New DevExpress.Data.Filtering.BinaryOperator("Length", 25, DevExpress.Data.Filtering.BinaryOperatorType.Greater)
                'The ActiveFilterCriteria property accepts one or multiple DevExpress.Data.Filtering.CriteriaOperator
                'type objects, each representing a single filtering expression
                vGridControl.ActiveFilterCriteria = DevExpress.Data.Filtering.GroupOperator.[Or](New DevExpress.Data.Filtering.CriteriaOperator() {expr1, expr2})
            End Sub
            Dim chkFilterEnabled As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit With {.Parent = vGridControl.Parent, .Text = "ActiveFilterEnabled ", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Disable the ActiveFilterEnabled property to temporarily deactivate all filters
            chkFilterEnabled.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", vGridControl, "ActiveFilterEnabled", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Search using the Find Panel"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsFind", "FindFilterText")>
        Public Sub SetFindPanelTextInCode(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' The find panel visibility.
            vGridControl.OptionsFind.Visibility = DevExpress.XtraVerticalGrid.FindPanelVisibility.Always
            ' Call this method in code to invoke the Find Panel and manually search for the required string
            vGridControl.FindFilterText = "Blue"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show the Filter Editor"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowFilterEditor")>
        Public Sub ShowFilterEditor(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Show Filter Editor", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Invoke the Filter Editor
            AddHandler b.Click, Sub(s, e) vGridControl.ShowFilterEditor(vGridControl.FocusedRow.Properties)
        End Sub
#End Region
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Comparison", "FilterAndSearch.cs")>
    Public Module Comparison

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(15)
            vGridControl.OptionsView.ShowRecordHeaders = True
            vGridControl.RecordHeaderFormat = "{Name}"
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add and remove records to/from comparison"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddToComparison", "RemoveFromComparison", "ShowComparison", "IsInComparison", "HideComparison", "ClearComparison")>
        Public Sub AddingRecordsToComparison(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Add the specific record/records to comparison
            vGridControl.AddToComparison(13)
            vGridControl.AddToComparison(New Integer() {1, 5, 11, 7, 8})
            ' Remove the specific record/records from comparison
            vGridControl.RemoveFromComparison(5)
            vGridControl.RemoveFromComparison(New Integer() {7, 8})
            ' Show only records added to comparison
            vGridControl.ShowComparison()
            ' Whether or not record added to comparison
            If vGridControl.IsInComparison(5) Then
                ' To clear the comparison and show all records use the ClearComparison method
                vGridControl.ClearComparison()
                ' To show all records use the HideComparison method
                vGridControl.HideComparison()
            End If
        End Sub
    End Module
End Namespace
