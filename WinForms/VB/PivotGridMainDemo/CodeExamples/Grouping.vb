Imports DevExpress.Internal
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Grouping", "Grouping.cs")>
    Public Module Grouping

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim fieldProductName As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldProductName.Caption = "Product"
            fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            fieldProductName.Name = "fieldProductName"
            Dim fieldSales As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldSales.Caption = "Product Sales"
            fieldSales.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductSales")
            fieldSales.Name = "fieldProductSales"
            Dim fieldShippedDate As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldShippedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldShippedDate.Caption = "Shipped Date"
            fieldShippedDate.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            fieldShippedDate.Name = "fieldShippedDate"
            pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {fieldProductName, fieldSales, fieldShippedDate})
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsData.AutoExpandGroups = DevExpress.Utils.DefaultBoolean.[False]
            Dim tableName As String = "ProductReports"
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Alphabetical Grouping")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DataBinding", "ExpressionDataBinding")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub AlphabeticalGrouping(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim fieldProductGroup As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductGroup.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldProductGroup.Caption = "Product Group"
            fieldProductGroup.AreaIndex = 0
            fieldProductGroup.DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("iif(Substring([ProductName], 0, 1) < 'F', 'A-E', Substring([ProductName], 0, 1) < 'T', 'F-S', 'T-Z')")
            pivotGridControl.Fields.Add(fieldProductGroup)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Date-Time Grouping")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DataBinding", "ExpressionDataBinding")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub DateTimeGrouping(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsMenu.ShowDateTimeGroupIntervalItems = DevExpress.XtraPivotGrid.DateTimeGroupIntervals.None
            Dim fieldYearQuarter As DevExpress.XtraPivotGrid.PivotGridField = pivotGridControl.GetFieldByArea(DevExpress.XtraPivotGrid.PivotArea.ColumnArea, 0)
            fieldYearQuarter.Caption = "Year - Quarter"
            fieldYearQuarter.DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("Concat(GetYear([ShippedDate]), ' - ', GetQuarter([ShippedDate]))")
        End Sub
    End Module
End Namespace
