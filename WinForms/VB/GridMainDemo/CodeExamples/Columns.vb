Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Columns", "Columns.cs")>
    Public Module Columns

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

#Region "Columns"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add columns manually"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddVisible", "AutoPopulateColumns")>
        Public Sub AddColumnsManually(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The AutoPopulateColumns property is used to determine
            ' whether columns should be created automatically for all fields in the underlying data source 
            ' when the View doesn't contain any columns
            gridView.OptionsBehavior.AutoPopulateColumns = False
            ' The AddVisible method adds a new column, binds it to the specified field and makes this column visible
            gridView.Columns.AddVisible("ID")
            gridView.Columns.AddVisible("Name")
        End Sub
#End Region
    End Module
End Namespace
