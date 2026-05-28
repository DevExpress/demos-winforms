Imports DevExpress.Internal
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports System.Linq

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Editing", "Editing.cs")>
    Public Module Editing

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Dim fieldCategory As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldCategory.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("CategoryName")
            fieldCategory.Name = "fieldCategory"
            Dim fieldProductName As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            fieldProductName.Name = "fieldProductName"
            Dim fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            fieldSalesPerson.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Sales Person")
            fieldSalesPerson.Name = "fieldSalePerson"
            Dim fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
            fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            fieldQuantity.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Quantity")
            fieldQuantity.Name = "fieldQuantity"
            fieldQuantity.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum
            pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {fieldQuantity, fieldCategory, fieldProductName, fieldSalesPerson})
            pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            pivotGridControl.OptionsView.ShowRowTotals = False
            pivotGridControl.OptionsView.ShowRowGrandTotals = False
            Dim tableName As String = "SalesPerson"
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Validation")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditValueChanged", "ValidatingEditor", "FieldEdit")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub Validation(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim minValue As Integer = 0
            Dim maxValue As Integer = 100
            Dim dataField = pivotGridControl.Fields("Quantity")
            AddHandler pivotGridControl.CustomAppearance, Sub(s, e)
                If Not System.[Object].ReferenceEquals(e.DataField, dataField) Then Return
                Dim val As Integer = System.Convert.ToInt32(e.Value)
                If System.[Object].ReferenceEquals(e.DataField, dataField) AndAlso (val < minValue OrElse val > maxValue) Then e.Appearance.BackColor = System.Drawing.Color.Red
            End Sub
            dataField.FieldEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            AddHandler pivotGridControl.ValidatingEditor, Sub(s, e)
                Dim val As Integer = System.Convert.ToInt32(e.Value)
                If val < minValue OrElse val > maxValue Then
                    e.ErrorText = "Value must be greater than " & minValue.ToString() & " and less than " & maxValue.ToString()
                    e.Valid = False
                End If
            End Sub
            AddHandler pivotGridControl.EditValueChanged, Sub(s, e)
                Dim drillDown As DevExpress.XtraPivotGrid.PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim newValue As Decimal = CDec(e.Editor.EditValue)
                If drillDown.RowCount > 0 Then
                    Dim newCellValue As Integer = CInt(System.Math.Floor(newValue / drillDown.RowCount)), extra As Integer = CInt(newValue) Mod drillDown.RowCount
                    For i As Integer = 0 To drillDown.RowCount - 1
                        drillDown(i)(dataField) = CShort((If((i = drillDown.RowCount - 1), (newCellValue + extra), newCellValue)))
                    Next
                Else
                    Dim table As System.Data.DataTable = TryCast(pivotGridControl.DataSource, System.Data.DataView).Table
                    Dim row As Object() = New Object(table.Columns.Count - 1) {}
                    Dim fields = pivotGridControl.Fields.Cast(Of DevExpress.XtraPivotGrid.PivotGridField)().Where(Function(f) f.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea OrElse f.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea).ToArray()
                    For i As Integer = 0 To fields.Length - 1
                        Dim fieldValue As Object = e.GetFieldValue(fields(i))
                        row(table.Columns.IndexOf(CType(fields(CInt((i))).DataBinding, DevExpress.XtraPivotGrid.DataSourceColumnBinding).ColumnName)) = fieldValue
                    Next

                    row(table.Columns.IndexOf(CType(dataField.DataBinding, DevExpress.XtraPivotGrid.DataSourceColumnBinding).ColumnName)) = newValue
                    table.Rows.Add(row)
                    table.AcceptChanges()
                    pivotGridControl.RefreshData()
                End If
            End Sub
            pivotGridControl.BestFit()
        End Sub
    End Module
End Namespace
