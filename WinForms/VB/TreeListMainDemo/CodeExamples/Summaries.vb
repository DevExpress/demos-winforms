Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Summaries", "Summaries.cs")>
    Public Module Summaries

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            AddHandler treeList.Load, Sub(s, e)
                treeList.ExpandAll()
                treeList.Columns(CStr(("Name"))).BestFit()
            End Sub
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
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create total summaries")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowSummaryFooter", "SummaryFooter", "SummaryFooterStrFormat")>
        Public Sub CreateTotalSummaries(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Enable summary footer UI element for the entire TreeList
            treeList.OptionsView.ShowSummaryFooter = True
            ' Setup total summaries for the specific columns
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.AllNodesSummary = True
            colName.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count
            colName.SummaryFooterStrFormat = "Total Count = {0}"
            Dim colMeanRadiusInKM As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusInKM")
            colMeanRadiusInKM.AllNodesSummary = True
            colMeanRadiusInKM.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Max
            Dim colMeanRadiusByEarth As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusByEarth")
            colMeanRadiusByEarth.AllNodesSummary = True
            colMeanRadiusByEarth.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Min
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Create row summaries")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowRowFooterSummary", "RowFooterSummary", "RowFooterSummaryStrFormat", "SummaryItemType")>
        Public Sub CreateRowSummaries(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Enable summary footer UI element for rows
            treeList.OptionsView.ShowRowFooterSummary = True
            ' Setup row-summaries for the specific columns
            Dim colName As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Name")
            colName.AllNodesSummary = True
            colName.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count
            colName.RowFooterSummaryStrFormat = "Row Count = {0}"
            Dim colMeanRadiusInKM As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusInKM")
            colMeanRadiusInKM.AllNodesSummary = True
            colMeanRadiusInKM.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Max
            colMeanRadiusInKM.RowFooterSummaryStrFormat = "Row Max: {0}"
            Dim colMeanRadiusByEarth As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("MeanRadiusByEarth")
            colMeanRadiusByEarth.AllNodesSummary = True
            colMeanRadiusByEarth.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Min
        End Sub
    End Module
End Namespace
