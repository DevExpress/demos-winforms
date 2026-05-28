Imports DevExpress.Internal
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Chart Integration", "ChartIntegration.cs")>
    Public Module ChartIntegration

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Preparing data")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("cellZeroValueThreshold", "CustomChartDataSourceData")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub ChartCustomData(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim chartControl As DevExpress.XtraCharts.ChartControl = New DevExpress.XtraCharts.ChartControl() With {.Parent = pivotGridControl.Parent, .Dock = System.Windows.Forms.DockStyle.Bottom, .Height = 150}
            chartControl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            chartControl.DataSource = pivotGridControl
            Dim cellZeroValueThreshold As Integer = 10000
            AddHandler pivotGridControl.CustomChartDataSourceData, Sub(s, e)
                If e.ItemType = DevExpress.XtraPivotGrid.PivotChartItemType.CellItem Then
                    If e.Value Is System.DBNull.Value OrElse CDec(e.Value) < System.Convert.ToDecimal(cellZeroValueThreshold) Then
                        e.Value = 0
                    End If
                End If
            End Sub
        End Sub
    End Module
End Namespace
