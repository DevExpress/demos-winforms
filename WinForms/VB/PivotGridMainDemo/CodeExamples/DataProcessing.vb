Imports DevExpress.Internal
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Data Processing", "DataProcessing.cs")>
    Public Module DataProcessing

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldOrderYear.Caption = "Order Year"
            fieldOrderYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            fieldOrderYear.Name = "fieldOrderYear"
            Dim fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldOrderDate.Caption = "Order Quarter"
            fieldOrderDate.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter)
            fieldOrderDate.Name = "fieldOrderQuarter"
            Dim fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldProductAmount.Caption = "Product Sales"
            fieldProductAmount.CellFormat.FormatString = "c"
            fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldProductAmount.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductAmount")
            fieldProductAmount.Name = "fieldProductAmount"
            Dim fieldProductName As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldProductName.Caption = "Product"
            fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            fieldProductName.Name = "fieldProductName"
            pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {fieldProductAmount, fieldProductName, fieldOrderYear, fieldOrderDate})
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            pivotGridGroup1.Fields.Add(fieldOrderYear)
            pivotGridGroup1.Fields.Add(fieldOrderDate)
            pivotGridControl.Groups.Add(pivotGridGroup1)
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsView.ShowColumnTotals = False
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
            Dim tableName As String = "CustomerReports"
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Cross Group Summary")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DataBinding", "RunningTotalBinding")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub CrossGroupSummary(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.Fields(CStr(("fieldProductAmount"))).DataBinding = New DevExpress.XtraPivotGrid.RunningTotalBinding(New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductAmount"), DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.RowValue, DevExpress.Data.PivotGrid.PivotSummaryType.Sum)
        End Sub
    End Module
End Namespace
