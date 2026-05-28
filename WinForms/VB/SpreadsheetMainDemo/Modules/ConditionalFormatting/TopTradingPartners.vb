Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Module TopTradingPartners

        Public Sub ApplyTopImportsConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify the top five values in the Imports column.
            Dim cfRule2 As RankConditionalFormatting = conditionalFormattings.AddRankConditionalFormatting(sheet("Table[Imports]"), ConditionalFormattingRankCondition.TopByRank, 5)
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule2.Formatting.Fill.BackgroundColor = Color.FromArgb(250, 191, 143)
        End Sub

        Public Sub ApplyImportsYearlyChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet("Table[Imports 1Y Chg]"), ConditionalFormattingExpressionCondition.GreaterThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151)
            ' Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule2 As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet("Table[Imports 1Y Chg]"), ConditionalFormattingExpressionCondition.LessThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9)
        End Sub

        Public Sub ApplyTopExportsConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify the top five values in the Exports column.
            Dim cfRule1 As RankConditionalFormatting = conditionalFormattings.AddRankConditionalFormatting(sheet("Table[Exports]"), ConditionalFormattingRankCondition.TopByRank, 5)
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule1.Formatting.Fill.BackgroundColor = Color.FromArgb(141, 215, 217)
        End Sub

        Public Sub ApplyExportsYearlyChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet("Table[Exports 1Y Chg]"), ConditionalFormattingExpressionCondition.GreaterThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151)
            ' Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            Dim cfRule2 As ExpressionConditionalFormatting = conditionalFormattings.AddExpressionConditionalFormatting(sheet("Table[Exports 1Y Chg]"), ConditionalFormattingExpressionCondition.LessThan, "0")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9)
        End Sub

        Public Sub ApplyAsiaCountriesConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Create the rule to highlight Asian countries.
            Dim cfRule As FormulaExpressionConditionalFormatting = conditionalFormattings.AddFormulaExpressionConditionalFormatting(sheet("Table[Country]"), "=$B6=""Asia""")
            ' Specify formatting options to be applied to cells if the condition is true.
            ' Set the background color.
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, 94, 202, 199)
        End Sub

        Public Sub ApplyBalanceChangeConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
            Dim lowBound1 As ConditionalFormattingValue = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            ' Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
            Dim highBound1 As ConditionalFormattingValue = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto)
            ' Create the rule to compare values in the Balance 1Y Chg column using data bars. 
            Dim cfRule1 As DataBarConditionalFormatting = conditionalFormattings.AddDataBarConditionalFormatting(sheet("Table[Balance 1Y Chg]"), lowBound1, highBound1, Color.FromArgb(87, 200, 197))
            cfRule1.GradientFill = False
            ' Set the negative bar color.
            cfRule1.NegativeBarColor = Color.FromArgb(247, 150, 70)
            ' Set the axis position to display the axis in the middle of the cell.
            cfRule1.AxisPosition = ConditionalFormattingDataBarAxisPosition.Middle
            ' Set the axis color to black.
            cfRule1.AxisColor = Color.Black
        End Sub

        Public Sub ApplyBalanceTrendConditionalFormatting(ByVal sheet As Worksheet)
            Dim conditionalFormattings As ConditionalFormattingCollection = sheet.ConditionalFormattings
            ' Set the first threshold to the lowest value in the range of cells using the MIN() formula.
            Dim minPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Formula, "=MIN($F$6:$F$22)", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Set the second threshold to 0.
            Dim midPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Set the third threshold to 0.0001.
            Dim maxPoint As ConditionalFormattingIconSetValue = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0.0001", ConditionalFormattingValueOperator.GreaterOrEqual)
            ' Create the rule to apply the specific icon from the 3 arrows icon set to each cell in the Balance column based on its value.  
            Dim cfRule As IconSetConditionalFormatting = conditionalFormattings.AddIconSetConditionalFormatting(sheet("Table[Balance]"), IconSetType.ArrowsGray3, New ConditionalFormattingIconSetValue() {minPoint, midPoint, maxPoint})
        End Sub
    End Module
End Namespace
