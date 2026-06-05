Imports System.Linq
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Module TopTradingPartners

        Const defaultTableName As String = "Table"

        Public Sub ApplyTopImportsConditionalFormatting(ByVal sheet As Worksheet)
            Dim importsColumnRange As CellRange = GetTableColumnRange(sheet, "Imports")
            If importsColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify the top five values in the Imports column.
            Dim cfRule2 As RankConditionalFormatting = conditionalFormattings.AddRankConditionalFormatting(importsColumnRange, ConditionalFormattingRankCondition.TopByRank, 5)
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule2.Formatting.Fill.BackgroundColor = Color.FromArgb(250, 191, 143)
        End Sub

        Public Sub ApplyImportsYearlyChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim imports1YChgColumnRange As CellRange = GetTableColumnRange(sheet, "Imports 1Y Chg")
            If imports1YChgColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(imports1YChgColumnRange, ConditionalFormattingExpressionCondition.GreaterThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151)
            ' Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule2 As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(imports1YChgColumnRange, ConditionalFormattingExpressionCondition.LessThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9)
        End Sub

        Public Sub ApplyTopExportsConditionalFormatting(ByVal sheet As Worksheet)
            Dim exportsColumnRange As CellRange = GetTableColumnRange(sheet, "Exports")
            If exportsColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify the top five values in the Exports column.
            Dim cfRule1 As RankConditionalFormatting = conditionalFormattings.AddRankConditionalFormatting(exportsColumnRange, ConditionalFormattingRankCondition.TopByRank, 5)
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule1.Formatting.Fill.BackgroundColor = Color.FromArgb(141, 215, 217)
        End Sub

        Public Sub ApplyExportsYearlyChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim exports1YChgColumnRange As CellRange = GetTableColumnRange(sheet, "Exports 1Y Chg")
            If exports1YChgColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(exports1YChgColumnRange, ConditionalFormattingExpressionCondition.GreaterThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151)
            ' Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule2 As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(exports1YChgColumnRange, ConditionalFormattingExpressionCondition.LessThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9)
        End Sub

        Public Sub ApplyAsiaCountriesConditionalFormatting(ByVal sheet As Worksheet)
            Dim countryColumnRange As CellRange = GetTableColumnRange(sheet, "Country")
            If countryColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to highlight Asian countries.
            Dim cfRule As FormulaExpressionConditionalFormatting = conditionalFormattings.AddFormulaExpressionConditionalFormatting(countryColumnRange, "=$B6=""Asia""")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, 94, 202, 199)
        End Sub

        Public Sub ApplyBalanceChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim balance1YChgColumnRange As CellRange = GetTableColumnRange(sheet, "Balance 1Y Chg")
            If balance1YChgColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
            Dim lowBound1 As ConditionalFormattingValue = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            ' Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
            Dim highBound1 As ConditionalFormattingValue = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            ' Create the rule to compare values in the Balance 1Y Chg column using data bars. 
            Dim cfRule1 As DataBarConditionalFormatting = conditionalFormattings.AddDataBarConditionalFormatting(balance1YChgColumnRange, lowBound1, highBound1, Color.FromArgb(87, 200, 197))
            cfRule1.GradientFill = False
            ' Set the negative bar color.
            cfRule1.NegativeBarColor = Color.FromArgb(247, 150, 70)
            ' Set the axis position to display the axis in the middle of the cell.
            cfRule1.AxisPosition = ConditionalFormattingDataBarAxisPosition.Middle
            ' Set the axis color to black.
            cfRule1.AxisColor = Color.Black
        End Sub

        Public Sub ApplyBalanceTrendConditionalFormatting(ByVal sheet As Worksheet)
            Dim balanceColumnRange As CellRange = GetTableColumnRange(sheet, "Balance")
            If balanceColumnRange Is Nothing Then Return
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Set the first threshold to the lowest value in the range of cells using the MIN() formula.
            Dim minPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Formula, "=MIN($F$6:$F$22)", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Set the second threshold to 0.
            Dim midPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Set the third threshold to 0.0001.
            Dim maxPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0.0001", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Create the rule to apply the specific icon from the 3 arrows icon set to each cell in the Balance column based on its value.  
            Dim cfRule As IconSetConditionalFormatting = conditionalFormattings.AddIconSetConditionalFormatting(balanceColumnRange, IconSetType.ArrowsGray3, New ConditionalFormattingIconSetValue() {minPoint, midPoint, maxPoint})
        End Sub

        Private Function GetTableColumnRange(ByVal sheet As Worksheet, ByVal columnName As String) As CellRange
            Dim table As Table = sheet.Tables.FirstOrDefault(Function(t) Equals(t.Name, defaultTableName))
            If table Is Nothing Then Return Nothing
            Dim column As TableColumn = table.Columns.FirstOrDefault(Function(c) Equals(c.Name, columnName))
            If column Is Nothing Then Return Nothing
            Return column.DataRange
        End Function
    End Module
End Namespace
