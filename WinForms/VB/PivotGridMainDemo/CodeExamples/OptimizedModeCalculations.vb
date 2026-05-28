Imports DevExpress.Internal
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Optimized Mode", "OptimizedModeCalculations.cs")>
    Public Module OptimizedModeCalculations

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldOrderYear.Caption = "Order Year"
            fieldOrderYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            fieldOrderYear.Name = "fOrderYear"
            Dim fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldOrderMonth.Caption = "Order Month"
            fieldOrderMonth.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)
            fieldOrderMonth.Name = "fOrderQuarter"
            Dim fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmount.Caption = "Product Sales"
            fieldProductAmount.Name = "fExtendedPrice"
            Dim fieldProductAmountRunningTotal As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmountRunningTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmountRunningTotal.Caption = "Running Total"
            fieldProductAmountRunningTotal.Name = "fRunningTotal"
            Dim fieldProductAmountMoving As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmountMoving.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmountMoving.Caption = "Moving Average"
            fieldProductAmountMoving.Name = "fMovingAverage"
            Dim fieldProductAmountDifference As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmountDifference.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmountDifference.Caption = "Difference"
            fieldProductAmountDifference.Name = "fDifference"
            Dim fieldProductAmountRank As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmountRank.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmountRank.Caption = "Rank"
            fieldProductAmountRank.Name = "fRank"
            Dim fieldProductAmountPercentOfTotal As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmountPercentOfTotal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmountPercentOfTotal.Caption = "Percent Of Total"
            fieldProductAmountPercentOfTotal.Name = "fPercentOfTotal"
            fieldProductAmountPercentOfTotal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldProductAmountPercentOfTotal.CellFormat.FormatString = "P1"
            pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {fieldProductAmount, fieldProductAmountRunningTotal, fieldProductAmountMoving, fieldProductAmountDifference, fieldProductAmountRank, fieldProductAmountPercentOfTotal, fieldOrderYear, fieldOrderMonth})
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsView.ShowColumnGrandTotalHeader = False
            pivotGridControl.OptionsView.ShowDataHeaders = False
            pivotGridControl.OptionsView.ShowFilterHeaders = False
            pivotGridControl.OptionsView.ShowColumnHeaders = False
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Field Calculation Bindings")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RunningTotalBinding", "MovingCalculationBinding", "DifferenceBinding", "RankBinding", "PercentOfTotalBinding")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub PivotCalculations(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim productAmountBinding As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ExtendedPrice")
            'Bind a field to a column in the data source.
            pivotGridControl.Fields(CStr(("fExtendedPrice"))).DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ExtendedPrice")
            'Calculate a running summary on the column.
            pivotGridControl.Fields(CStr(("fRunningTotal"))).DataBinding = New DevExpress.XtraPivotGrid.RunningTotalBinding(productAmountBinding, DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValue, DevExpress.Data.PivotGrid.PivotSummaryType.Sum)
            'Calculate the average of the preceding, current and following values in the column.
            pivotGridControl.Fields(CStr(("fMovingAverage"))).DataBinding = New DevExpress.XtraPivotGrid.MovingCalculationBinding(productAmountBinding, DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValue, DevExpress.Data.PivotGrid.PivotSummaryType.Average, 1, 1)
            'Calculate a difference between the preceding and current value in the column.
            pivotGridControl.Fields(CStr(("fDifference"))).DataBinding = New DevExpress.XtraPivotGrid.DifferenceBinding(productAmountBinding, DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValue, DevExpress.XtraPivotGrid.DifferenceTarget.Previous, DevExpress.XtraPivotGrid.DifferenceType.Absolute)
            'Calculate a rank for each value in the column in a pivot field group.
            pivotGridControl.Fields(CStr(("fRank"))).DataBinding = New DevExpress.XtraPivotGrid.RankBinding(productAmountBinding, DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValueAndRowParentValue, DevExpress.XtraPivotGrid.RankType.Unique, DevExpress.XtraPivotGrid.PivotSortOrder.Descending)
            'Calculate the percentage of each value in the column out of the sum of the values in a pivot field group.
            pivotGridControl.Fields(CStr(("fPercentOfTotal"))).DataBinding = New DevExpress.XtraPivotGrid.PercentOfTotalBinding(productAmountBinding, DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.ColumnValueAndRowParentValue)
            pivotGridControl.BestFit()
        End Sub
    End Module
End Namespace
