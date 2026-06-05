using System.Linq;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public static class TopTradingPartners {
        const string defaultTableName = "Table";

        public static void ApplyTopImportsConditionalFormatting(Worksheet sheet) {
            CellRange importsColumnRange = GetTableColumnRange(sheet, "Imports");
            if(importsColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Create the rule to identify the top five values in the Imports column.
            RankConditionalFormatting cfRule2 = conditionalFormattings.AddRankConditionalFormatting(importsColumnRange, ConditionalFormattingRankCondition.TopByRank, 5);
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule2.Formatting.Fill.BackgroundColor = Color.FromArgb(250, 191, 143);
        }
        public static void ApplyImportsYearlyChangeConditionalFormatting(Worksheet sheet) {
            CellRange imports1YChgColumnRange = GetTableColumnRange(sheet, "Imports 1Y Chg");
            if(imports1YChgColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule =
            conditionalFormattings.AddExpressionConditionalFormatting(imports1YChgColumnRange, ConditionalFormattingExpressionCondition.GreaterThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151);

            // Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule2 =
            conditionalFormattings.AddExpressionConditionalFormatting(imports1YChgColumnRange, ConditionalFormattingExpressionCondition.LessThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9);
        }
        public static void ApplyTopExportsConditionalFormatting(Worksheet sheet) {
            CellRange exportsColumnRange = GetTableColumnRange(sheet, "Exports");
            if(exportsColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify the top five values in the Exports column.
            RankConditionalFormatting cfRule1 = conditionalFormattings.AddRankConditionalFormatting(exportsColumnRange, ConditionalFormattingRankCondition.TopByRank, 5);
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule1.Formatting.Fill.BackgroundColor = Color.FromArgb(141, 215, 217);
        }
        public static void ApplyExportsYearlyChangeConditionalFormatting(Worksheet sheet) {
            CellRange exports1YChgColumnRange = GetTableColumnRange(sheet, "Exports 1Y Chg");
            if(exports1YChgColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;

            // Create the rule to identify positive values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule =
            conditionalFormattings.AddExpressionConditionalFormatting(exports1YChgColumnRange, ConditionalFormattingExpressionCondition.GreaterThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule.Formatting.Font.Color = Color.FromArgb(52, 150, 151);

            // Create the rule to identify negative values in the Exports 1Y Chg and Imports 1Y Chg columns.
            ExpressionConditionalFormatting cfRule2 =
            conditionalFormattings.AddExpressionConditionalFormatting(exports1YChgColumnRange, ConditionalFormattingExpressionCondition.LessThan, "0");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the font color.
            cfRule2.Formatting.Font.Color = Color.FromArgb(227, 108, 9);
        }


        public static void ApplyAsiaCountriesConditionalFormatting(Worksheet sheet) {
            CellRange countryColumnRange = GetTableColumnRange(sheet, "Country");
            if(countryColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Create the rule to highlight Asian countries.
            FormulaExpressionConditionalFormatting cfRule = conditionalFormattings.AddFormulaExpressionConditionalFormatting(countryColumnRange, "=$B6=\"Asia\"");
            // Specify formatting options to be applied to cells if the condition is true.
            // Set the background color.
            cfRule.Formatting.Fill.BackgroundColor = Color.FromArgb(255, 94, 202, 199);
        }

        public static void ApplyBalanceChangeConditionalFormatting(Worksheet sheet) {
            CellRange balance1YChgColumnRange = GetTableColumnRange(sheet, "Balance 1Y Chg");
            if(balance1YChgColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the value corresponding to the shortest bar to the lowest value, which is evaluated automatically.
            ConditionalFormattingValue lowBound1 = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Set the value corresponding to the longest bar to the highest value, which is evaluated automatically.
            ConditionalFormattingValue highBound1 = sheet.ConditionalFormattings.CreateValue(ConditionalFormattingValueType.Auto);
            // Create the rule to compare values in the Balance 1Y Chg column using data bars. 
            DataBarConditionalFormatting cfRule1 = conditionalFormattings.AddDataBarConditionalFormatting(balance1YChgColumnRange, lowBound1, highBound1, Color.FromArgb(87, 200, 197));
            cfRule1.GradientFill = false;
            // Set the negative bar color.
            cfRule1.NegativeBarColor = Color.FromArgb(247, 150, 70);
            // Set the axis position to display the axis in the middle of the cell.
            cfRule1.AxisPosition = ConditionalFormattingDataBarAxisPosition.Middle;
            // Set the axis color to black.
            cfRule1.AxisColor = Color.Black;
        }
        public static void ApplyBalanceTrendConditionalFormatting(Worksheet sheet) {
            CellRange balanceColumnRange = GetTableColumnRange(sheet, "Balance");
            if(balanceColumnRange == null)
                return;

            ConditionalFormattingCollection conditionalFormattings = sheet.ConditionalFormattings;
            // Set the first threshold to the lowest value in the range of cells using the MIN() formula.
            ConditionalFormattingIconSetValue minPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Formula, "=MIN($F$6:$F$22)", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the second threshold to 0.
            ConditionalFormattingIconSetValue midPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Set the third threshold to 0.0001.
            ConditionalFormattingIconSetValue maxPoint = sheet.ConditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0.0001", ConditionalFormattingValueOperator.GreaterOrEqual);
            // Create the rule to apply the specific icon from the 3 arrows icon set to each cell in the Balance column based on its value.  
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(balanceColumnRange, IconSetType.ArrowsGray3, new ConditionalFormattingIconSetValue[] { minPoint, midPoint, maxPoint });
        }
        static CellRange GetTableColumnRange(Worksheet sheet, string columnName) {
            Table table = sheet.Tables.FirstOrDefault(t => t.Name == defaultTableName);
            if(table == null)
                return null;
            TableColumn column = table.Columns.FirstOrDefault(c => c.Name == columnName);
            if(column == null)
                return null;
            return column.DataRange;
        }
    }
}
