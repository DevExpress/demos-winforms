Imports System
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Filter and search", "FilterAndSearch.cs")>
    Public Module FilterAndSearch

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            AddHandler treeList.Load, Sub(s, e) treeList.ExpandAll()
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Search using the Find Panel")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ApplyFindFilter")>
        Public Sub SetFindPanelTextInCode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            'The AlwaysVisible property is used to determine whether the Find Panel is always visible.
            treeList.OptionsFind.AlwaysVisible = True
            'The ApplyFindFilter method searches for the specified string, using the search functionality provided by the Find Panel
            '    You can call this method in code, to manually invoke the search.
            treeList.ApplyFindFilter("Sa 5")
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Search by specific columns using the Find Panel")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ApplyFindFilter")>
        Public Sub ColumnFindPanelSearch(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            'The AlwaysVisible property is used to determine whether the Find Panel is always visible.
            treeList.OptionsFind.AlwaysVisible = True
            ' Perform search by the for the specific column
            treeList.ApplyFindFilter("Name:Sa")
        'You can also specify the columns which will be used for searching
        '   using the OptionsFind.FindFilterColumns property
        'treeList.OptionsFind.FindFilterColumns = "Name";
        'treeList.ApplyFindFilter("Sa"); 
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter data"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilterString")>
        Public Sub ActiveFilterString(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Set filter string.
            treeList.ActiveFilterString = "Contains(Name, 'Sa') OR MeanRadiusByEarth > 5"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter by the specific column"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ActiveFilter")>
        Public Sub ActiveFilter(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' The ActiveFilter property returns an object which represents the filter criteria for the TreeList.
            treeList.ActiveFilter.Add(treeList.Columns("Name"), New DevExpress.XtraTreeList.Columns.TreeListColumnFilterInfo("Contains(Name, 'Sa')"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter using AutoFilterRow"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AutoFilter", "SetAutoFilterValue")>
        Public Sub AutoFilterRow(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            treeList.OptionsView.ShowAutoFilterRow = True
            ' Set auto-filter for the specific column.
            treeList.SetAutoFilterValue(treeList.Columns("Name"), "Sa", DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter nodes dynamically"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomRowFilter", "Handled")>
        Public Sub CustomNodeFilter(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            'The CustomRowFilter event allows you to hide nodes or make them visible regardless of the active filter.
            AddHandler treeList.CustomRowFilter, Sub(s, e)
                e.Visible = CDbl(e.Node("MeanRadiusByEarth")) > 5.0
                e.Handled = True
            End Sub
        End Sub
    End Module
End Namespace
