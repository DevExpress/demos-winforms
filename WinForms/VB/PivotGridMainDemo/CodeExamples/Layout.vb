Imports DevExpress.Internal
Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.PivotGrid
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace DevExpress.XtraPivotGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Layout", "Layout.cs")>
    Public Module Layout

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            AddHandler pivotGridControl.DataSourceChanged, Sub(s, e) pivotGridControl.BestFit()
            pivotGridControl.BeginInit()
            pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("Country", DevExpress.XtraPivotGrid.PivotArea.RowArea) With {.TopValueCount = 3})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("City", DevExpress.XtraPivotGrid.PivotArea.RowArea))
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("Quantity", DevExpress.XtraPivotGrid.PivotArea.DataArea))
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField("ExtendedPrice", DevExpress.XtraPivotGrid.PivotArea.DataArea) With {.Caption = "Price"})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Name = "fieldYear", .Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear), .Caption = "Year", .TopValueCount = 2})
            pivotGridControl.Fields.Add(New DevExpress.XtraPivotGrid.PivotGridField() With {.Name = "fieldQuarter", .Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea, .DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter), .Caption = "Quarter"})
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Totals Location")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "RowTotalsLocation", "ColumnTotalsLocation")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub TotalsLocation(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
            pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Totals Visibility")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "ShowRowTotals", "ShowColumnTotals", "ShowColumnGrandTotals", "ShowRowGrandTotals", "ShowTotalsForSingleValues")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub TotalsVisibility(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim ceShowTotalsForSingleValues As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Totals For Single Values", .Checked = False, .Dock = System.Windows.Forms.DockStyle.Top}
            ' Specify whether to display totals for the field values which contain a single nested field value.
            AddHandler ceShowTotalsForSingleValues.CheckedChanged, Sub(s, e) pivotGridControl.OptionsView.ShowTotalsForSingleValues = ceShowTotalsForSingleValues.Checked
            Dim ceShowTotals As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Totals", .Checked = True, .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler ceShowTotals.CheckedChanged, Sub(s, e)
                ' Specify whether to display Row and Column totals.
                pivotGridControl.OptionsView.ShowColumnTotals = ceShowTotals.Checked
                pivotGridControl.OptionsView.ShowRowTotals = ceShowTotals.Checked
                ' Disable the Show Totals For Single Values check edit control if the Show Totals check edit control is unchecked.
                ceShowTotalsForSingleValues.Enabled = ceShowTotals.Checked
            End Sub
            Dim ceShowGrandTotals As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Grand Totals", .Checked = True, .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler ceShowGrandTotals.CheckedChanged, Sub(s, e)
                ' Sets whether to display Grand Totals.
                pivotGridControl.OptionsView.ShowColumnGrandTotals = ceShowGrandTotals.Checked
                pivotGridControl.OptionsView.ShowRowGrandTotals = ceShowGrandTotals.Checked
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Row Field Totals")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TotalsVisibility", "AutomaticTotals", "CustomTotals", "None")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub RowFieldTotals(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Create a custom total object and specify a custom format string to display its data.
            Dim averageTotal As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal(DevExpress.Data.PivotGrid.PivotSummaryType.Average)
            averageTotal.Format.FormatType = DevExpress.Utils.FormatType.Custom
            averageTotal.Format.FormatString = "Custom Average of {0}"
            ' Add custom totals to the field. The totals use different aggregate functions.
            pivotGridControl.Fields(CStr(("Country"))).CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {New DevExpress.XtraPivotGrid.PivotGridCustomTotal(DevExpress.Data.PivotGrid.PivotSummaryType.Min), New DevExpress.XtraPivotGrid.PivotGridCustomTotal(DevExpress.Data.PivotGrid.PivotSummaryType.Max), averageTotal})
            Dim cbeCountryTotals As DevExpress.XtraEditors.ComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Data Fields in Rows", .Dock = System.Windows.Forms.DockStyle.Top}
            cbeCountryTotals.Properties.Items.AddRange(New String() {"Automatic Totals", "Custom Totals", "None"})
            cbeCountryTotals.SelectedIndex = 0
            AddHandler cbeCountryTotals.SelectedIndexChanged, Sub(s, e)
                ' Specify a kind of totals to display depending on the value selected in the Country Totals combo box.
                Select Case CStr(cbeCountryTotals.SelectedItem)
                    Case "Automatic Totals"
                        pivotGridControl.Fields(CStr(("Country"))).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals
                    Case "Custom Totals"
                        pivotGridControl.Fields(CStr(("Country"))).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
                    Case "None"
                        pivotGridControl.Fields(CStr(("Country"))).TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
                End Select
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Data Fields Position")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsDataField", "Area", "AreaIndex")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub DataFieldsPosition(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            pivotGridControl.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
            Dim ceDataFieldArea As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Data Fields in Rows", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Move Data Fields to the Row or Column area.
            AddHandler ceDataFieldArea.CheckedChanged, Sub(s, e) pivotGridControl.OptionsDataField.Area = If(ceDataFieldArea.Checked, DevExpress.XtraPivotGrid.PivotDataArea.RowArea, DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea)
            Dim ceDataFieldAreaIndex As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Data Fields Before Other Fields", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Position data fields inside the area.
            AddHandler ceDataFieldAreaIndex.CheckedChanged, Sub(s, e) pivotGridControl.OptionsDataField.AreaIndex = If(ceDataFieldAreaIndex.Checked, 0, -1)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Data Cells Visibility")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Options", "ShowValues", "ShowTotals", "ShowGrandTotal")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub DataCellsVisibility(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' The layout is changed to show totals at the grid's left side.
            pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Dim ceShowValues As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Values", .Checked = True, .Dock = System.Windows.Forms.DockStyle.Top}
            ' Show or hide data cells.
            AddHandler ceShowValues.CheckedChanged, Sub(s, e) pivotGridControl.Fields(CStr(("Quantity"))).Options.ShowValues = ceShowValues.Checked
            Dim ceShowTotals As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Totals", .Checked = True, .Dock = System.Windows.Forms.DockStyle.Top}
            ' Show or hide cells with totals.
            AddHandler ceShowTotals.CheckedChanged, Sub(s, e) pivotGridControl.Fields(CStr(("Quantity"))).Options.ShowTotals = ceShowTotals.Checked
            Dim ceShowGrandTotals As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Show Grand Totals", .Checked = True, .Dock = System.Windows.Forms.DockStyle.Top}
            ' Show or hide cells with grand totals.
            AddHandler ceShowGrandTotals.CheckedChanged, Sub(s, e) pivotGridControl.Fields(CStr(("Quantity"))).Options.ShowGrandTotal = ceShowGrandTotals.Checked
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hiding certain rows and columns")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomFieldValueCells", "GetCellCount", "GetCell", "Remove")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub HidingCertainFieldValues(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Handle this event to hide specific column and row field values.
            AddHandler pivotGridControl.CustomFieldValueCells, Sub(s, e)
                If Not Equals(System.Convert.ToString(pivotGridControl.Tag), "HideFieldValues") Then Return
                Dim isColumn As Boolean = False
                ' Iterates through all row headers.
                For i As Integer = e.GetCellCount(isColumn) - 1 To 0 Step -1
                    Dim cell As DevExpress.XtraPivotGrid.FieldValueCell = e.GetCell(isColumn, i)
                    If cell Is Nothing Then Continue For
                    ' If the current header relates to the "Salzburg" field value,
                    ' and it is not the Total Row header,
                    ' the header and all related rows are removed.
                    If Object.Equals(cell.Value, "Salzburg") AndAlso cell.ValueType <> DevExpress.XtraPivotGrid.PivotGridValueType.Total Then e.Remove(cell)
                Next
            End Sub
            Dim ceHideFieldValues As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Hide the 'Salzburg' field values", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler ceHideFieldValues.CheckedChanged, Sub(s, e)
                ' Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = If(ceHideFieldValues.Checked, "HideFieldValues", "")
                pivotGridControl.LayoutChanged()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hiding certain data cells")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomFieldValueCells", "FindAllCells", "Remove")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub HidingCertainDataCells(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Handle this event to hide columns and rows where all cells meet certain criteria.
            AddHandler pivotGridControl.CustomFieldValueCells, Sub(s, e)
                If Not Equals(System.Convert.ToString(pivotGridControl.Tag), "HideDataCells") Then
                    Return
                Else
                    Dim isColumn As Boolean = True
                    ' Find columns where all cells match a certain condition.
                    For Each cell As DevExpress.XtraPivotGrid.FieldValueCell In e.FindAllCells(isColumn, Function(dataCellValues) If(dataCellValues.Any(Function(c) System.Convert.ToDecimal(c) > 400), False, True))
                        e.Remove(cell)
                    Next
                End If
            End Sub
            Dim ceHideDataCells As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Hide all columns where cells have values less then 500", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler ceHideDataCells.CheckedChanged, Sub(s, e)
                ' Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = If(ceHideDataCells.Checked, "HideDataCells", "")
                pivotGridControl.LayoutChanged()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Split Field Values")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomFieldValueCells", "FieldValueSplitData", "FieldValueCell", "Split")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub SplitFieldValues(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            ' Adjust the pivot grid layout.
            pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Dim fieldAveragePrice = New DevExpress.XtraPivotGrid.PivotGridField("ExtendedPrice", DevExpress.XtraPivotGrid.PivotArea.DataArea) With {.Name = "fieldAveragePrice", .SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average, .Caption = "Price Avg"}
            fieldAveragePrice.Options.ShowValues = False
            fieldAveragePrice.Options.ShowTotals = False
            pivotGridControl.Fields.Add(fieldAveragePrice)
            ' Handle this event to hide columns and rows where all cells match certain criteria.
            AddHandler pivotGridControl.CustomFieldValueCells, Sub(s, e)
                If Not Equals(System.Convert.ToString(pivotGridControl.Tag), "SplitFieldValue") Then Return
                Dim isColumn As Boolean = True
                ' Define a predicate that returns true if the cell is a Grand Total header.
                Dim condition As System.Predicate(Of DevExpress.XtraPivotGrid.FieldValueCell) = New System.Predicate(Of DevExpress.XtraPivotGrid.FieldValueCell)(Function(ByVal matchCell As DevExpress.XtraPivotGrid.FieldValueCell) matchCell.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal AndAlso matchCell.Field Is Nothing)
                ' Create a cell definition list containing the newly created cells.
                Dim cells = New DevExpress.XtraPivotGrid.Data.FieldValueSplitData() {New DevExpress.XtraPivotGrid.Data.FieldValueSplitData("Quantity", 1), New DevExpress.XtraPivotGrid.Data.FieldValueSplitData("Prices", 2)}
                ' Split the Grand Total cells.
                e.Split(isColumn, condition, cells)
            End Sub
            Dim ceSplitFieldValues As DevExpress.XtraEditors.CheckEdit = New DevExpress.XtraEditors.CheckEdit() With {.Parent = pivotGridControl.Parent, .Text = "Split the Grand Total field value", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler ceSplitFieldValues.CheckedChanged, Sub(s, e)
                ' Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = If(ceSplitFieldValues.Checked, "SplitFieldValue", "")
                pivotGridControl.LayoutChanged()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hit cell info")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcHitInfo", "CellInfo")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub HitCellInfo(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim hitInfoText As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Parent = pivotGridControl.Parent, .[ReadOnly] = True, .Dock = System.Windows.Forms.DockStyle.Top, .Height = 50}
            hitInfoText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            AddHandler pivotGridControl.MouseMove, Sub(s, e)
                Dim info = pivotGridControl.CalcHitInfo(New System.Drawing.Point(e.X, e.Y))
                If info Is Nothing OrElse info.CellInfo Is Nothing Then
                    hitInfoText.Text = ""
                    Return
                End If

                Dim cellInfo = info.CellInfo
                hitInfoText.Text = String.Format("Value: {0}" & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "Cell indexis: [{1},{2}]" & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "Data field: {3}", If(System.[Object].Equals(cellInfo.Value, Nothing), "empty", cellInfo.Value), cellInfo.ColumnIndex, cellInfo.RowIndex, If(cellInfo.DataField IsNot Nothing, cellInfo.DataField.ToString(), ""))
                Dim rowFields = cellInfo.GetRowFields()
                If rowFields.Length > 0 Then
                    hitInfoText.Text += System.Environment.NewLine & "Row fields" & Global.Microsoft.VisualBasic.Constants.vbTab
                    hitInfoText.Text += rowFields.Aggregate("", Function(text, f) text & String.Format(Global.Microsoft.VisualBasic.Constants.vbTab & "'{0}' : {1}", f.ToString(), f.GetDisplayText(cellInfo.GetFieldValue(f))))
                End If

                Dim colFields = cellInfo.GetColumnFields()
                If colFields.Length > 0 Then
                    hitInfoText.Text += System.Environment.NewLine & "Column fields" & Global.Microsoft.VisualBasic.Constants.vbTab
                    hitInfoText.Text += colFields.Aggregate("", Function(text, f) text & String.Format(Global.Microsoft.VisualBasic.Constants.vbTab & "'{0}' : {1}", f.ToString(), f.GetDisplayText(cellInfo.GetFieldValue(f))))
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hit value info")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcHitInfo", "ValueInfo")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub HitValueInfo(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim hitInfoText As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Parent = pivotGridControl.Parent, .[ReadOnly] = True, .Dock = System.Windows.Forms.DockStyle.Top, .Height = 40}
            hitInfoText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            AddHandler pivotGridControl.MouseMove, Sub(s, e)
                Dim info = pivotGridControl.CalcHitInfo(New System.Drawing.Point(e.X, e.Y))
                If info Is Nothing OrElse info.ValueInfo Is Nothing Then
                    hitInfoText.Text = ""
                    Return
                End If

                Dim valueInfo = info.ValueInfo
                hitInfoText.Text = String.Format("Field: {0}", valueInfo.Field)
                hitInfoText.Text += If(valueInfo.Value Is Nothing, "", String.Format(Global.Microsoft.VisualBasic.Constants.vbTab & "Value: {0}", valueInfo.Value))
                If valueInfo.Field Is Nothing Then
                    hitInfoText.Text += System.Environment.NewLine & "grand total"
                ElseIf valueInfo.Field.AreaIndex > 0 AndAlso valueInfo.Field.Area <> DevExpress.XtraPivotGrid.PivotArea.DataArea Then
                    hitInfoText.Text += System.Environment.NewLine & "Parent fields   "
                    For i As Integer = 0 To valueInfo.Field.AreaIndex - 1
                        Dim parentField = pivotGridControl.GetFieldByArea(valueInfo.Field.Area, i)
                        hitInfoText.Text += String.Format(Global.Microsoft.VisualBasic.Constants.vbTab & "'{0}' : {1}", parentField.ToString(), parentField.GetDisplayText(valueInfo.GetHigherLevelFieldValue(parentField)))
                    Next
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hit headers info")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CalcHitInfo", "HeadersAreaInfo")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleDataFile("nwind.xml")>
        Public Sub HitHeadersInfo(ByVal pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl)
            Dim hitInfoText As DevExpress.XtraEditors.MemoEdit = New DevExpress.XtraEditors.MemoEdit() With {.Parent = pivotGridControl.Parent, .[ReadOnly] = True, .Dock = System.Windows.Forms.DockStyle.Top, .Height = 30}
            hitInfoText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            AddHandler pivotGridControl.MouseMove, Sub(s, e)
                Dim info = pivotGridControl.CalcHitInfo(New System.Drawing.Point(e.X, e.Y))
                If info Is Nothing OrElse info.HeadersAreaInfo Is Nothing Then
                    hitInfoText.Text = ""
                    Return
                End If

                hitInfoText.Text = String.Format("Area: {0}", info.HeadersAreaInfo.Area)
                hitInfoText.Text += If(info.HeadersAreaInfo.Field Is Nothing, "", String.Format(Global.Microsoft.VisualBasic.Constants.vbTab & "Field: {0}", info.HeadersAreaInfo.Field))
            End Sub
        End Sub
    End Module
End Namespace
