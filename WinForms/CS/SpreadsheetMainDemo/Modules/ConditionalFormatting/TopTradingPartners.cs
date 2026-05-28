using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public static class TopTradingPartners {
        public static void ApplyTopImportsConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Create the rule to identify the top five values in the Imports column.
            RankConditionalFormatting cfRule2 = conditionalFormattings.AddRankConditionalFormatting(sheet["Table[Imports]"], ConditionalFormattingRankCondition.TopByRank, 5);
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule2.Formatting.Fill.BackgroundColor = Color.FromArgb(250, 191, 143);
        }
        public static void ApplyImportsYearlyChangeConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule =
            conditionalFormattings.AddExpressionConditionalFormatting(sheet["Table[Imports 1Y Chg]"], ConditionalFormattingExpressionCondition.GreaterThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151);

            // Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule2 =
            conditionalFormattings.AddExpressionConditionalFormatting(sheet["Table[Imports 1Y Chg]"], ConditionalFormattingExpressionCondition.LessThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9);
        }
        public static void ApplyTopExportsConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify the top five values in the Exports column.
            RankConditionalFormatting cfRule1 = conditionalFormattings.AddRankConditionalFormatting(sheet["Table[Exports]"], ConditionalFormattingRankCondition.TopByRank, 5);
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule1.Formatting.Fill.BackgroundColor = Color.FromArgb(141, 215, 217);
        }
        public static void ApplyExportsYearlyChangeConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule =
            conditionalFormattings.AddExpressionConditionalFormatting(sheet["Table[Exports 1Y Chg]"], ConditionalFormattingExpressionCondition.GreaterThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151);

            // Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule2 =
            conditionalFormattings.AddExpressionConditionalFormatting(sheet["Table[Exports 1Y Chg]"], ConditionalFormattingExpressionCondition.LessThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9);
        }


        public static void ApplyAsiaCountriesConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Create the rule to highlight Asian countries.
            FormulaExpressionConditionalFormatting cfRule = conditionalFormattings.AddFormulaExpressionConditionalFormatting(sheet["Table[Country]"], "=$B6=\"Asia\"");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, 94, 202, 199);
        }

        public static void ApplyBalanceChangeConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
            ConditionalFormattingValue lowBound1 = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
            ConditionalFormattingValue highBound1 = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Create the rule to compare values in the Balance 1Y Chg column using data bars. 
            DataBarConditionalFormatting cfRule1 = conditionalFormattings.AddDataBarConditionalFormatting(sheet["Table[Balance 1Y Chg]"], lowBound1, highBound1, Color.FromArgb(87, 200, 197));
            cfRule1.GradientFill = false;
            // Set the negative bar color.
            cfRule1.NegativeBarColor = Color.FromArgb(247, 150, 70);
            // Set the axis position to display the axis in the middle of the cell.
            cfRule1.AxisPosition = ConditionalFormattingDataBarAxisPosition.Middle;
            // Set the axis color to black.
            cfRule1.AxisColor = Color.Black;
        }
        public static void ApplyBalanceTrendConditionalFormatting(Worksheet sheet) {
            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the first threshold to the lowest value in the range of cells using the MIN() formula.
            ConditionalFormattingIconSetValue minPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Formula, "=MIN($F$6:$F$22)", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the second threshold to 0.
            ConditionalFormattingIconSetValue midPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the third threshold to 0.0001.
            ConditionalFormattingIconSetValue maxPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0.0001", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Create the rule to apply the specific icon from the 3 arrows icon set to each cell in the Balance column based on its value.  
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(sheet["Table[Balance]"], IconSetType.ArrowsGray3, new ConditionalFormattingIconSetValue[] { minPoint, midPoint, maxPoint });
        }
    }
}
