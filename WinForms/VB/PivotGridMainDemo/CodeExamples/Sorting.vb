Imports DevExpress.Internal
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Sorting", "Sorting.cs")>
    Public Module Sorting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            AddHandler pivotGridControl.DataSourceChanged, Sub(s, e) pivotGridControl.BestFit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            pivotGridControl.BeginInit()
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("Country", DevExpress.XtraPivotGrid.PivotArea.RowArea))
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("ExtendedPrice", DevExpress.XtraPivotGrid.PivotArea.DataArea) With {.Caption = "Price"})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Name = "fieldMonth", .Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea, .Caption = "Month", .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)})
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Dim tableName As String = "Invoices"
            Dim dbFileName As String = DevExpress.Internal.DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not String.IsNullOrEmpty(dbFileName) Then
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.ReadXml(dbFileName)
                pivotGridControl.DataSource = dataSet.Tables(CStr((tableName))).DefaultView
            End If

            pivotGridControl.EndInit()
            pivotGridControl.Parent = sampleHost
            Return New Object() {pivotGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraPivotGrid.PivotGridControl).Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sort Order")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortOrder")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub SortOrder(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Specify the field sort order: Ascending or Descending.
            pivotGridControl.Fields(CStr(("Country"))).SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sort Mode")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortMode")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub SortMode(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Specify whether the field's data is sorted based on Value or DisplayText.
            pivotGridControl.Fields(CStr(("OrderDate"))).SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Top N")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TopValueCount", "TopValueShowOthers", "TopValueType")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub TopN(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim fieldCountry = pivotGridControl.Fields("Country")
            ' Specify the number of field values to display for the Country field (top N).
            fieldCountry.TopValueCount = 5
            ' Specify whether to display the "Others" item.
            fieldCountry.TopValueShowOthers = True
            ' Specify whether the TopValueCount value is the absolute number of field values or a percentage ratio.
            fieldCountry.TopValueType = DevExpress.XtraPivotGrid.PivotTopValueType.Absolute
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sorting By Summary")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortBySummaryInfo", "Field", "Conditions", "PivotGridFieldSortCondition")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub SortingBySummary(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim fieldCountry = pivotGridControl.Fields("Country")
            ' Specify a field whose summary values define the sort order. The Pivot Grid sorts field values by a Grand Total column/row of the specified field.
            fieldCountry.SortBySummaryInfo.Field = pivotGridControl.Fields("ExtendedPrice")
            ' A field may relate to several pivot columns. Specify conditions that identify a column or row by which the field is sorted.
            fieldCountry.SortBySummaryInfo.Conditions.Add(New DevExpress.XtraPivotGrid.PivotGridFieldSortCondition(pivotGridControl.Fields("OrderDate"), 3))
            ' Specify the sort order.
            fieldCountry.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        End Sub
    End Module
End Namespace
