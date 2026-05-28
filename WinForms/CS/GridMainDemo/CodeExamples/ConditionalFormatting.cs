using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Conditional formatting", "ConditionalFormatting.cs")]
    public static class ConditionalFormatting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(10);

            var tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            tileView.OptionsTiles.Orientation = Orientation.Vertical;
            tileView.OptionsTiles.ColumnCount = 1;
            tileView.OptionsTiles.ItemSize = new Size(350, 150);
            tileView.AnimateArrival = false;

            var row1 = new TableRowDefinition() { AutoHeight = true, PaddingBottom = 6 };
            var row2 = new TableRowDefinition() { AutoHeight = true, PaddingBottom = 6 };
            var row3 = new TableRowDefinition();
            row3.Length.Type = TableDefinitionLengthType.Pixel;
            row3.Length.Value = 30D;
            tileView.TileRows.Add(row1);
            tileView.TileRows.Add(row2);
            tileView.TileRows.Add(row3);

            var column1 = new TableColumnDefinition();
            var column2 = new TableColumnDefinition();
            column2.Length.Type = TableDefinitionLengthType.Pixel;
            column2.Length.Value = 35D;
            tileView.TileColumns.Add(column1);
            tileView.TileColumns.Add(column2);

            tileView.TileSpans.Add(new TableSpan() { ColumnSpan = 2, RowIndex = 1 });
            tileView.TileSpans.Add(new TableSpan() { ColumnSpan = 2, RowIndex = 2 });

            TileViewColumn colTask = new TileViewColumn() { FieldName = "Name", Visible = true };
            TileViewColumn colEmployee = new TileViewColumn() { FieldName = "Employee", Visible = true };
            TileViewColumn colDueDate = new TileViewColumn() { FieldName = "DueDate", Visible = true };
            TileViewColumn colPriority = new TileViewColumn() { FieldName = "Priority", Visible = true };
            TileViewColumn colDescription = new TileViewColumn() { FieldName = "Description", Visible = true };
            TileViewColumn colStatus = new TileViewColumn() { FieldName = "Status", Visible = true };
            colStatus.DisplayFormat.FormatString = "{0}%";
            colStatus.DisplayFormat.FormatType = FormatType.Custom;
            tileView.Columns.AddRange(new[] { colTask, colEmployee, colDueDate, colPriority, colDescription, colStatus });

            TileViewItemElement elTask = new TileViewItemElement();
            elTask.Appearance.Normal.FontSizeDelta = 2;
            elTask.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
            elTask.Appearance.Normal.Options.UseFont = true;
            elTask.TextAlignment = TileItemContentAlignment.TopLeft;
            elTask.Column = colTask;

            TileViewItemElement elPriorityFlag = new TileViewItemElement();
            elPriorityFlag.Column = colPriority;
            elPriorityFlag.ColumnIndex = 1;
            elPriorityFlag.ImageOptions.ImageAlignment = TileItemContentAlignment.TopRight;
            elPriorityFlag.TextVisible = false;

            TileViewItemElement elDescription = new TileViewItemElement();
            elDescription.TextAlignment = TileItemContentAlignment.TopLeft;
            elDescription.Column = colDescription;
            elDescription.MaxLineCount = 3;
            elDescription.RowIndex = 1;

            TileViewItemElement elStatus = new TileViewItemElement();
            elStatus.Appearance.Normal.FontSizeDelta = 4;
            elStatus.Column = colStatus;
            elStatus.RowIndex = 2;
            elStatus.TextAlignment = TileItemContentAlignment.BottomRight;

            TileViewItemElement elDueDateLabel = new TileViewItemElement();
            elDueDateLabel.RowIndex = 2;
            elDueDateLabel.Text = "Due Date:";
            elDueDateLabel.TextAlignment = TileItemContentAlignment.BottomLeft;

            TileViewItemElement elDueDate = new TileViewItemElement();
            elDueDate.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            elDueDate.AnchorElementIndex = 4;
            elDueDate.AnchorIndent = 3;
            elDueDate.Column = colDueDate;
            elDueDate.RowIndex = 2;

            TileViewItemElement elEmployeeLabel = new TileViewItemElement();
            elEmployeeLabel.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Top;
            elEmployeeLabel.AnchorElementIndex = 4;
            elEmployeeLabel.AnchorIndent = 0;
            elEmployeeLabel.RowIndex = 2;
            elEmployeeLabel.Text = "Employee:";

            TileViewItemElement elEmployee = new TileViewItemElement();
            elEmployee.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            elEmployee.AnchorElementIndex = 6;
            elEmployee.AnchorIndent = 3;
            elEmployee.Column = colEmployee;
            elEmployee.RowIndex = 2;
            elEmployee.Text = "colEmployee";

            tileView.TileTemplate.Add(elTask);
            tileView.TileTemplate.Add(elPriorityFlag);
            tileView.TileTemplate.Add(elDescription);
            tileView.TileTemplate.Add(elStatus);
            tileView.TileTemplate.Add(elDueDateLabel);
            tileView.TileTemplate.Add(elDueDate);
            tileView.TileTemplate.Add(elEmployeeLabel);
            tileView.TileTemplate.Add(elEmployee);

            return new object[] { gridControl, gridView, tileView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        

        #region Conditional formatting
        [CodeExampleCase("Apply conditional formatting"), SampleDataSourceFile]
        public static void AddColumnsManually(GridControl gridControl, GridView gridView, DevExpress.XtraGrid.Views.Tile.TileView tileView) {
            GridColumn colMark = gridView.Columns["Mark"];
            FormatConditionRuleValue markRule = new FormatConditionRuleValue();
            markRule.Condition = FormatCondition.Expression;
            markRule.Expression = string.Format("[{0}] == false", "Mark");
            markRule.Appearance.BackColor = Color.LightGreen;
            gridView.FormatRules.Add(colMark, markRule);

            GridColumn colLength = gridView.Columns["Length"];
            GridColumn colName = gridView.Columns["Name"];
            GridFormatRule typeOfObjectRule = new GridFormatRule();
            FormatConditionRule2ColorScale colorScaleRule = new FormatConditionRule2ColorScale();
            typeOfObjectRule.Column = colLength;
            typeOfObjectRule.ColumnApplyTo = colName;
            colorScaleRule.PredefinedName = "White, Red";
            typeOfObjectRule.Rule = colorScaleRule;
            gridView.FormatRules.Add(typeOfObjectRule);
        }

        [CodeExampleCase("Apply conditional formatting (TileView)")]
        public static void ConditionalFormattingTileView(GridControl gridControl, GridView gridView, DevExpress.XtraGrid.Views.Tile.TileView tileView) {
            gridControl.MainView = tileView;
            gridControl.DataSource = DevExpress.Demos.TaskGenerator.Default.GenerateSource(200);

            FormatConditionIconSet flagsIconSet = new FormatConditionIconSet();
            flagsIconSet.ValueType = FormatConditionValueType.Number;
            flagsIconSet.Icons.Add(new FormatConditionIconSetIcon() { PredefinedName = "Flags3_1.png", Value = -1, ValueComparison = FormatConditionComparisonType.GreaterOrEqual });
            flagsIconSet.Icons.Add(new FormatConditionIconSetIcon() { PredefinedName = "Flags3_2.png", Value = 0, ValueComparison = FormatConditionComparisonType.GreaterOrEqual });
            flagsIconSet.Icons.Add(new FormatConditionIconSetIcon() { PredefinedName = "Flags3_3.png", Value = 1, ValueComparison = FormatConditionComparisonType.GreaterOrEqual });
            tileView.FormatRules.Add(tileView.Columns["Priority"], new FormatConditionRuleIconSet() { IconSet = flagsIconSet });

            FormatConditionRuleValue overdueRowRule = new FormatConditionRuleValue();
            overdueRowRule.Condition = FormatCondition.Expression;
            overdueRowRule.Expression = "[DueDate] < Today() And [Status] < 100";
            overdueRowRule.PredefinedName = "Red Fill";

            TileViewColumn columnDueDate = tileView.Columns["DueDate"] as TileViewColumn;
            GridFormatRule overdueRowFormatRule = new GridFormatRule();
            overdueRowFormatRule.ApplyToRow = true;
            overdueRowFormatRule.Column = columnDueDate;
            overdueRowFormatRule.Rule = overdueRowRule;
            tileView.FormatRules.Add(overdueRowFormatRule);

            FormatConditionRuleValue overdueTextRule = new FormatConditionRuleValue();
            overdueTextRule.Assign(overdueRowRule);
            overdueTextRule.PredefinedName = "Red Bold Text";
            tileView.FormatRules.Add(columnDueDate, overdueTextRule);

            FormatConditionRuleValue completedRowRule = new FormatConditionRuleValue();
            completedRowRule.Condition = FormatCondition.Equal;
            completedRowRule.Value1 = 100;
            completedRowRule.PredefinedName = "Green Fill";

            TileViewColumn colStatus = tileView.Columns["Status"] as TileViewColumn;
            GridFormatRule completedRowFormatRule = new GridFormatRule();
            completedRowFormatRule.Column = colStatus;
            completedRowFormatRule.Rule = completedRowRule;
            completedRowFormatRule.ApplyToRow = true;
            tileView.FormatRules.Add(completedRowFormatRule);

            FormatConditionRuleValue completedTextRule = new FormatConditionRuleValue();
            completedTextRule.Assign(completedRowRule);
            completedTextRule.PredefinedName = null;
            completedTextRule.Appearance.FontSizeDelta = 2;
            completedTextRule.Appearance.FontStyleDelta = FontStyle.Strikeout | FontStyle.Bold;

            TileViewColumn colName = tileView.Columns["Name"] as TileViewColumn;
            GridFormatRule completedTextFormatRule = new GridFormatRule();
            completedTextFormatRule.Column = colStatus;
            completedTextFormatRule.ColumnApplyTo = colName;
            completedTextFormatRule.Rule = completedTextRule;
            tileView.FormatRules.Add(completedTextFormatRule);
        }
        #endregion
    }
}
