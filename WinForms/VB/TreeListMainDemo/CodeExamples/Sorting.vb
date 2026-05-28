Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Sorting", "Sorting.cs")>
    Public Module Sorting

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sorting by the specific column")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortOrder")>
        Public Sub ColumnSort(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Set sorting for the specific column
            treeList.Columns(CStr(("MeanRadiusByEarth"))).SortOrder = System.Windows.Forms.SortOrder.Ascending
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sorting by multiple columns")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortOrder", "BeginSort", "EndSort")>
        Public Sub MultiColumnSort(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Set sorting for multiple columns
            treeList.BeginSort()
            treeList.Columns(CStr(("MeanRadiusByEarth"))).SortOrder = System.Windows.Forms.SortOrder.Ascending
            treeList.Columns(CStr(("MeanRadiusInKM"))).SortOrder = System.Windows.Forms.SortOrder.Descending
            treeList.EndSort()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sorting by the related column"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortOrder", "FieldNameSort", "FilterBySortField")>
        Public Sub AnotherColumnSort(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' set sorting for the specific column (FilterBySortField should be enabled)
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.[True]
            colName.FieldNameSort = "MeanRadiusByEarth"
            colName.SortOrder = System.Windows.Forms.SortOrder.Ascending
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom sorting"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomColumnSort", "SortMode")>
        Public Sub CustomColumnSort(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Setup custom column sorting
            Dim column As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusInKM")
            column.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
            column.SortOrder = System.Windows.Forms.SortOrder.Ascending
            ' Handle the CustomColumnSort event
            AddHandler treeList.CustomColumnSort, Sub(sender, e)
                If Equals(e.Column.FieldName, "MeanRadiusInKM") Then
                    Dim spaceObject1 = CType(e.RowObject1, DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject)
                    Dim spaceObject2 = CType(e.RowObject2, DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject)
                    ' default comparison
                    e.Result = If((e.SortOrder = System.Windows.Forms.SortOrder.Ascending), spaceObject1.MeanRadiusInKM.CompareTo(spaceObject2.MeanRadiusInKM), spaceObject2.MeanRadiusInKM.CompareTo(spaceObject1.MeanRadiusInKM))
                    'Always show Asteroids at the bottom
                    Const Asteroid As String = "Asteroid"
                    If Equals(spaceObject1.TypeOfObject, Asteroid) AndAlso Not Equals(spaceObject2.TypeOfObject, Asteroid) Then e.Result = If((e.SortOrder = System.Windows.Forms.SortOrder.Ascending), 1, -1)
                    If Equals(spaceObject2.TypeOfObject, Asteroid) AndAlso Not Equals(spaceObject1.TypeOfObject, Asteroid) Then e.Result = If((e.SortOrder = System.Windows.Forms.SortOrder.Ascending), -1, 1)
                End If
            End Sub
        End Sub
    End Module
End Namespace
