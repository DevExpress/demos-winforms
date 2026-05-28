Imports DevExpress.Internal
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Data

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Intermediate Level Aggregations (Optimized Mode)", "Aggr.cs")>
    Public Module Aggr

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            AddHandler pivotGridControl.DataSourceChanged, Sub(s, e) pivotGridControl.BestFit()
            pivotGridControl.BeginInit()
            Dim f1 = New DevExpress.XtraPivotGrid.PivotGridField("Country", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            f1.Name = "f1"
            pivotGridControl.Fields.Add(f1)
            Dim f2 = New DevExpress.XtraPivotGrid.PivotGridField() With {.Caption = "Year", .Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)}
            f2.Name = "f2"
            pivotGridControl.Fields.Add(f2)
            Dim f3 = New DevExpress.XtraPivotGrid.PivotGridField("ExtendedPrice", DevExpress.XtraPivotGrid.PivotArea.DataArea) With {.Caption = "Extended price"}
            f3.Name = "f3"
            pivotGridControl.Fields.Add(f3)
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Filter Sales by Year and Country")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Aggr", "OrderDate", "Country")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub FilterCountryBySumOfPriceInYear(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim field As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField With {.Name = "SalesByYearByCountry", .Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea, .DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("Aggr(Sum([ExtendedPrice]), GetYear([OrderDate]), [Country])")}
            pivotGridControl.Fields.Add(field)
            pivotGridControl.ActiveFilter.CriteriaString = "[SalesByYearByCountry] > 30000"
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Average sales by Year")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Aggr", "OrderDate", "Country")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub AverageInTotals(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim salesByYearByCountry As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea, .Caption = "Average sales by year", .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average, .Name = "SalesByYearByCountry"}
            salesByYearByCountry.DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("aggr(Sum([ExtendedPrice]), GetYear([OrderDate]), [Country])")
            salesByYearByCountry.Options.ShowValues = False
            salesByYearByCountry.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            salesByYearByCountry.CellFormat.FormatString = "c2"
            Dim percentOfMaxSalesByYear As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.Name = "PercentOfMaxSalesByYear", .Caption = "Percent of Max Sales by Year", .Area = DevExpress.XtraPivotGrid.PivotArea.DataArea}
            percentOfMaxSalesByYear.DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("Sum([ExtendedPrice]) / Max(aggr( Max([SalesByYearByCountry]), GetYear([OrderDate])))")
            percentOfMaxSalesByYear.Options.ShowGrandTotal = False
            percentOfMaxSalesByYear.Options.ShowExpressionEditorMenu = True
            percentOfMaxSalesByYear.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            percentOfMaxSalesByYear.CellFormat.FormatString = "p"
            pivotGridControl.Fields.Add(salesByYearByCountry)
            pivotGridControl.Fields.Add(percentOfMaxSalesByYear)
            pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            pivotGridControl.Appearance.FieldValue.Options.UseTextOptions = True
            pivotGridControl.Appearance.FieldValue.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
            pivotGridControl.Appearance.FieldValue.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            pivotGridControl.OptionsDataField.ColumnValueLineCount = 2
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Grouping by Year of first sale")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Aggr", "Min", "Country", "OrderDate")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub GroupByFirstYear(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim yearOfFirstSale As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField() With {.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea, .AreaIndex = 0, .Caption = "Year of first sale"}
            yearOfFirstSale.DataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding("Aggr(Min(GetYear([OrderDate])), [Country])")
            yearOfFirstSale.Options.ShowTotals = False
            pivotGridControl.Fields.Add(yearOfFirstSale)
        End Sub
    End Module
End Namespace
