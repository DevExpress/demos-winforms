#If NET
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Extensions;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.AI.Demos {
    public static class GridControlAITools {
        [AIIntegrationTool]
        [Description("Retrieve information about the columns in the specified Grid. Always use this tool to retrieve column names for Grid operations.")]
        public static object[] RetrieveColumnsInfo(
            [AIIntegrationToolTarget("Target Grid from which to retrieve column information.")]
            GridView gridView) {

            return gridView.Columns.Select(c => new {
                Caption = c.Caption,
                FieldName = c.FieldName,
                Description = c.AccessibleDescription,
            }).ToArray();
        }

        [AIIntegrationTool]
        [Description("Sort the Grid by a specified column in ascending or descending order. Returns a confirmation message or an actionable error.")]
        public static string SortByColumn(
            [AIIntegrationToolTarget("Target Grid to sort.")]
            GridView gridView,
            [Description("The name of the column to sort by. Use the column caption or field name, retrieved from the grid.")]
            string columnName,
            [Description("Sort direction: true for ascending, false for descending.")]
            bool isAscending) {

            var column = FindColumn(gridView, columnName);
            if(column == null)
                return $"Error: Column '{columnName}' not found. Please check the column name and try again.";

            var sortInfo = gridView.SortInfo.FirstOrDefault(si => si.Column == column);
            if(sortInfo != null)
                gridView.SortInfo.Remove(sortInfo);

            gridView.SortInfo.Add(column, isAscending ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending);
            return $"Sorting applied to '{column.FieldName}' in {(isAscending ? "ascending" : "descending")} order.";
        }

        [AIIntegrationTool]
        [Description("Remove sorting from the specified Grid column. Returns a confirmation message or an actionable error.")]
        public static string RemoveColumnSorting(
            [AIIntegrationToolTarget("Target Grid to remove sorting from.")]
            GridView gridView,
            [Description("The name of the column to remove sorting from. Use the column caption or field name.")]
            string columnName) {

            var column = FindColumn(gridView, columnName);
            if(column == null)
                return $"Error: Column '{columnName}' not found. Please check the column name and try again.";

            gridView.SortInfo.Remove(column);
            return $"Sorting removed from column '{column.FieldName}'.";
        }

        [AIIntegrationTool]
        [Description("Groups the Grid data by the specified column. Optionally specify the grouping order. Example: 'Group the grid by Country.' Returns a confirmation or actionable error.")]
        public static string GroupByColumn(
            [AIIntegrationToolTarget("Target Grid to group.")]
            GridView gridView,
            [Description("The name of the column to group by. Use the column caption or field name.")]
            string columnName,
            [Description("The grouping order index (optional, default is 0). Lower index means higher grouping priority.")]
            int groupIndex = 0) {

            var column = FindColumn(gridView, columnName);
            if(column == null)
                return $"Error: Column '{columnName}' not found. Please check the column name and try again.";
            column.GroupIndex = groupIndex;
            return $"Grouping applied successfully on column '{columnName}' at index {groupIndex}.";
        }

        [AIIntegrationTool]
        [Description("Removes all grouping from the Grid. Returns a confirmation message.")]
        public static string ClearGrouping(
            [AIIntegrationToolTarget("Target Grid to clear grouping from.")]
            GridView gridView) {

            gridView.ClearGrouping();
            return "All grouping cleared from the grid view.";
        }

        [AIIntegrationTool]
        [Description("Create and apply a grid filter from a natural-language prompt. Converts the prompt to a filter expression and applies it. Returns a summary of the filter applied or actionable error.")]
        public static async Task<string> SetFilter(
            [AIIntegrationToolTarget("Target Grid to apply the filter to.")]
            GridView gridView,
            [Description("Natural-language description of the filter. Examples: \"Show orders from 2024\", \"price > 100 and status = 'Paid'\".")]
            string userPrompt) {

            if(string.IsNullOrWhiteSpace(userPrompt))
                return "Error: filter prompt is empty.";

            var functions = DataAccess.ExpressionEditor.ExpressionEditorContextHelper.GetFunctions().ToRequestFunctionInfo();
            var columns = gridView.Columns.Cast<GridColumn>()
                .Select(c => new PromptToFilterRequest.ColumnInfo(c.FieldName, c.Caption, c.AccessibleDescription ?? c.Caption, c.ColumnType, []))
                .ToList();

            var request = new PromptToFilterRequest(userPrompt, gridView.ActiveFilterString, columns, functions);
            var result = await AIExtensionsContainerDesktop.Default.PromptToExpressionAsync(request);
            if(string.IsNullOrEmpty(result.Response))
                return "Error: failed to generate a filter expression.";

            try {
                gridView.ActiveFilterCriteria = CriteriaOperator.Parse(result.Response);
                return $"Filter applied: {result.Response}";
            }
            catch(Exception ex) {
                return $"Error: generated filter expression '{result.Response}' is invalid. {ex.Message}";
            }            
        }

        [AIIntegrationTool]
        [Description("Clears all filters from the Grid. Returns a confirmation message.")]
        public static string ClearFilter(
            [AIIntegrationToolTarget("Target Grid to clear filters from.")]
            GridView gridView) {

            gridView.ActiveFilterString = string.Empty;
            return "All filters cleared from the grid view.";
        }

        static GridColumn FindColumn(GridView gridView, string column) {
            return gridView.Columns.Cast<GridColumn>()
                .FirstOrDefault(c => c.FieldName.Equals(column, StringComparison.OrdinalIgnoreCase) || c.Caption.Equals(column, StringComparison.OrdinalIgnoreCase));
        }
    }
}
#End If
