using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Appearance customization", "AppearanceCustomization.cs")]
    public static class AppearanceCustomization {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var gridControl = new DevExpress.XtraGrid.GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(10);
            gridView.PopulateColumns();
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        #region Appearance customization
        [CodeExampleCase("Appearance of column cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AppearanceCell")]
        public static void AppearanceOfColumnCells(GridControl gridControl, GridView gridView) {
            GridColumn colID = gridView.Columns["ID"];
            colID.AppearanceCell.BackColor2 = Color.DarkGreen;
            colID.AppearanceCell.BackColor = Color.LightGreen;
            colID.AppearanceCell.ForeColor = Color.White;

            GridColumn colName = gridView.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.Brown;
            colName.AppearanceCell.ForeColor = Color.Yellow;

            GridColumn colRecordDate = gridView.Columns["RecordDate"];
            colRecordDate.AppearanceCell.ForeColor = Color.Red;
        }
        [CodeExampleCase("Appearance of column cells (dynamically)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RowCellStyle", "Appearance")]
        public static void AppearanceOfColumnCellsDynamically(GridControl gridControl, GridView gridView) {
            //Changing the appearance settings of column cells dynamically
            gridView.RowCellStyle += (sender, e) => {
                GridView view = sender as GridView;
                bool _mark = (bool)view.GetRowCellValue(e.RowHandle, "Mark");
                if(e.Column.FieldName == "Name") {
                    e.Appearance.BackColor = _mark ? Color.LightGreen : Color.LightSalmon;
                    e.Appearance.TextOptions.HAlignment = _mark ? HorzAlignment.Far : HorzAlignment.Near;
                }
                if(e.Column.FieldName == "Length") {
                    double _length = (double)e.CellValue;
                    if(_length > 25)
                        e.Appearance.ForeColor = Color.Red;
                }
            };
        }
        [CodeExampleCase("Appearance of rows (dynamically)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RowStyle", "Appearance", "HighPriority")]
        public static void AppearanceOfRowsDynamically(GridControl gridControl, GridView gridView) {
            GridColumn colName = gridView.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.Salmon;
            colName.AppearanceCell.Options.UseBackColor = true;
            gridView.OptionsBehavior.Editable = false;
            Color foreColor = Color.LightCoral;
            Color backColor = Color.LightGreen;
            //Changing the appearance settings of row cells dynamically
            gridView.RowStyle += (sender, e) => {
                GridView view = sender as GridView;
                //Change selected rows' fore and back colors
                if(view.IsRowSelected(e.RowHandle)) {
                    e.Appearance.ForeColor = foreColor;
                    e.Appearance.BackColor = backColor;
                    // This property controls whether settings provided by the RowStyle event have a higher priority 
                    e.HighPriority = true;
                }
            };
        }
        [CodeExampleCase("Active editor’s background color"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShownEditor", "ActiveEditor")]
        public static void ActiveEditorBackColor(GridControl gridControl, GridView gridView) {
            // ShownEditor event is designed to perform specific actions after a cell editor has been invoked.
            gridView.ShownEditor += (s, e) => {
                GridView view = s as GridView;
                // The editor can be accessed using the ActiveEditor property.
                gridView.ActiveEditor.BackColor = Color.DodgerBlue;
            };
        }
        [CodeExampleCase("Appearance of group levels"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GroupLevelStyle", "LevelAppearance")]
        public static void AppearanceOfGroupLevels(GridControl gridControl, GridView gridView) {
            gridView.Columns["ID"].Group();
            gridView.Columns["Mark"].Group();
            gridView.ExpandAllGroups();

            gridView.GroupLevelStyle += (s, e) => {
                if(e.Level == 0) {
                    e.LevelAppearance.ForeColor = Color.WhiteSmoke;
                    e.LevelAppearance.BackColor = Color.Salmon;
                } else {
                    e.LevelAppearance.ForeColor = Color.FromArgb(50, 50, 50);
                    e.LevelAppearance.BackColor = Color.LightSalmon;
                }
            };
        }
        [CodeExampleCase("Cell content alignment"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RowCellDefaultAlignment", "HorzAlignment")]
        public static void CellContentAlignment(GridControl gridControl, GridView gridView) {
            gridView.RowCellDefaultAlignment += (s, e) => {
                HorzAlignment alignment = HorzAlignment.Default;
                switch(e.RowHandle % 3) {
                    case 0:
                        alignment = HorzAlignment.Center;
                        break;
                    case 1:
                        alignment = HorzAlignment.Far;
                        break;
                    case 2:
                        alignment = HorzAlignment.Near;
                        break;
                }
                e.HorzAlignment = alignment;
            };
        }
        [CodeExampleCase("Prioritize cell selection appearances"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RowCellStyle", "IsCellSelected")]
        public static void CellSelectionPriority(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;

            GridColumn colName = gridView.Columns["Name"];
            colName.AppearanceCell.BackColor = Color.Salmon;
            colName.AppearanceCell.Options.UseBackColor = true;

            gridView.RowCellStyle += (s, e) => {
                GridView view = s as GridView;
                if(view.IsCellSelected(e.RowHandle, e.Column))
                    e.Appearance.BackColor = view.PaintAppearance.SelectedRow.BackColor;
            };
        }
        [CodeExampleCase("Disable focused cell highlight"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("EnableAppearanceFocusedCell")]
        public static void DisableFocusedCellAppearance(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
        }
        [CodeExampleCase("Prioritize conditional formatting appearances"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RowCellStyle", "FormatConditionRuleValue", "IsRowSelected", "GridFormatRule", "FormatConditionRuleAppearanceBase")]
        public static void ConditionalFormattingPriority(GridControl gridControl, GridView gridView) {
            FormatConditionRuleValue lengthRuleCondition = new FormatConditionRuleValue();
            lengthRuleCondition.Condition = FormatCondition.GreaterOrEqual;
            lengthRuleCondition.Value1 = 25;
            lengthRuleCondition.Appearance.BackColor = Color.MediumSeaGreen;
            lengthRuleCondition.Appearance.Options.UseBackColor = true;
            GridFormatRule lengthRule = new GridFormatRule() { Column = gridView.Columns["Length"], Rule = lengthRuleCondition };
            gridView.FormatRules.Add(lengthRule);

            gridView.RowCellStyle += (s, e) => {
                GridView view = s as GridView;
                if(view.IsRowSelected(e.RowHandle) &&
                    e.Column.FieldName == "Length" &&
                    lengthRule.IsFit(e.CellValue, view.GetDataSourceRowIndex(e.RowHandle))) {
                    AppearanceObject ruleAppearance = (lengthRule.Rule as FormatConditionRuleAppearanceBase).Appearance;
                    e.Appearance.BackColor = ruleAppearance.BackColor;
                }
            };
        }
        #endregion
    }
}
