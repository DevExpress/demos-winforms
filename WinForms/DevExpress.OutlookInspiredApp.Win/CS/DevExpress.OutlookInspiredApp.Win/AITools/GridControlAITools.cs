using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Extensions;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.DevAV.AITools {
    public static class GridControlAITools {
        [AIIntegrationTool]
        [Description("Retrieves information about columns in the specified GridControl. Always use this tool to retrieve column names for Grid operations.")]
        public static object GetColumnInfo(
            [AIIntegrationToolTarget("The GridControl instance from which the method retrieves column information.")]
            GridControl gridControl) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            return view.Columns.Cast<GridColumn>().Select(col => new {
                name = col.Name,
                fieldName = col.FieldName,
                caption = col.Caption,
                description = col.AccessibleDescription,
            }).ToList<object>();
        }
        [AIIntegrationTool()]
        [Description("Sorts the grid by the specified column. Example: 'Sort the grid by Country in ascending order.'. Returns a confirmation message or an actionable error.")]
        public static string SortByColumn(
            [AIIntegrationToolTarget("The GridControl instance to be sorted.")]
            GridControl gridControl,
            [Description("The name of the column to sort by. Use the column caption or field name, retrieved from the grid.")]
            string colName,
            [Description("True for ascending order. False for descending order.")]
            bool ascending) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            view.ClearSorting();
            var column = FindColumn(view, colName);
            if(column == null)
                throw new Exception($"Column '{colName}' not found. Use the {nameof(GetColumnInfo)} tool to get columns names.");
            column.SortOrder = ascending ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending;
            return $"Sorting applied to '{colName}' in {(ascending ? "ascending" : "descending")} order.";
        }
        [AIIntegrationTool()]
        [Description("Groups grid data by the specified column. Optionally, the method specifies the grouping order. Example: 'Group the grid by Country.' Returns a confirmation or actionable error.\"")]
        public static string GroupByColumn(
            [AIIntegrationToolTarget("The GridControl instance to be grouped.")]
            GridControl gridControl,
            [Description("The name of the column to group by. Use the column caption or field name, retrieved from the grid.")]
            string colName,
            [Description("The grouping order index (optional, default is 0). Lower index corresponds to higher grouping priority.")]
            int groupIndex = 0) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            var column = FindColumn(view, colName);
            if(column == null)
                throw new Exception($"Column '{colName}' not found. Use the {nameof(GetColumnInfo)} tool to get columns names.");
            column.GroupIndex = groupIndex;
            return $"Grouping applied to '{colName}' with index {groupIndex}.";
        }
        [AIIntegrationTool]
        [Description("Removes all grouping from the grid view. Returns a confirmation message.")]
        public static string ClearGrouping(
            [AIIntegrationToolTarget("The GridControl instance in which the grouping from to be cleared.")]
            GridControl gridControl) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            view.ClearGrouping();
            return "Grouping cleared.";
        }
        [AIIntegrationTool]
        [Description("Finds rows that contain query text strings in the specified or all columns.")]
        public static string SearchRows(
            [AIIntegrationToolTarget("The GridControl instance to which the search rules to be applied to.")]
            GridControl gridControl,
            [Description("Text strings to be searched for (case-insensitive).")]
            string query) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            view.ApplyFindFilter(query);
            return "Search applied.";
        }
        [AIIntegrationTool]
        [Description("Applies a filter to the specified GridControl using a DevExpress Criteria Language filter string.")]
        public static async Task<object> SetFilter(
            [AIIntegrationToolTarget("The GridControl to apply the filter to.")]
            GridControl gridControl,
            [Description("Natural-language description of the filter. Examples: \"Show orders from 2024\", \"price > 100 and status = 'Paid'\".")]
            string userPrompt) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            if(string.IsNullOrWhiteSpace(userPrompt))
                throw new Exception("Filter prompt is empty.");

            var functions = DataAccess.ExpressionEditor.ExpressionEditorContextHelper.GetFunctions().ToRequestFunctionInfo();
            var columns = view.Columns.Cast<GridColumn>()
                .Select(c => new PromptToFilterRequest.ColumnInfo(c.FieldName, c.Caption, c.AccessibleDescription ?? c.Caption, c.ColumnType, []))
                .ToList();

            var request = new PromptToFilterRequest(userPrompt, view.ActiveFilterString, columns, functions);
            var result = await AIExtensionsContainerDesktop.Default.PromptToExpressionAsync(request);
            if(string.IsNullOrEmpty(result.Response))
                throw new Exception("Failed to generate a filter expression.");

            try {
                view.ActiveFilterCriteria = Data.Filtering.CriteriaOperator.Parse(result.Response);
                return $"Filter applied: {result.Response}";
            }
            catch(Exception ex) {
                throw new Exception($"Generated filter expression '{result.Response}' is invalid. {ex.Message}");
            }
        }
        [AIIntegrationTool]
        [Description("Clears all filters from the Grid. Returns a confirmation message.")]
        public static string ClearFilter(
            [AIIntegrationToolTarget("Target Grid to clear filters from.")]
            GridControl gridControl) {
            if(gridControl.MainView is not GridView view)
                throw new Exception("The GridControl's main view type is not supported.");
            view.ActiveFilterString = string.Empty;
            return "All filters cleared from the grid view.";
        }
        static GridColumn FindColumn(GridView gridView, string column) {
            return gridView.Columns.Cast<GridColumn>()
                .FirstOrDefault(c => c.Name.Equals(column, StringComparison.OrdinalIgnoreCase) || c.FieldName.Equals(column, StringComparison.OrdinalIgnoreCase) || c.Caption.Equals(column, StringComparison.OrdinalIgnoreCase));
        }
    }
}
