using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos {
    public class DemosHelper {
        public static void ShowDescriptionForm(System.Drawing.Point location, string description, string caption) {
            using(DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm()) {
                TextBox tb = new TextBox();
                tb.Multiline = true;
                tb.Dock = DockStyle.Fill;
                tb.ScrollBars = ScrollBars.Vertical;
                tb.Text = description;
                tb.SelectionLength = 0;

                frm.Controls.Add(tb);
                frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                frm.Text = caption;
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size);
                frm.ShowDialog();
            }
        }
    }
    public class MyGridView : GridView {
        public static bool IsCondition(GridColumn column) {
            if(column == null) 
                return false;
            foreach(StyleFormatCondition c in column.View.FormatConditions)
                if(c.Column.Equals(column)) return true;
            return false;
        }
        public void SetIcons() {
            foreach(GridColumn column in this.Columns) 
                column.ImageIndex = IsCondition(column) ? 0 : -1;
        }
        protected override void ApplyColumnFilter(DevExpress.XtraGrid.Columns.GridColumn column, FilterItem listBoxItem) {
            if(listBoxItem == null) 
                return;
            if(listBoxItem.Text == Properties.Resources.ConditionsName) {
                ConditionsEditor editor = new ConditionsEditor(column, column.View.GridControl.FindForm());
                editor.ShowDialog();
                SetIcons();
            }
            else base.ApplyColumnFilter(column, listBoxItem);
        }
    }

    public class ItemFormatRule {
        GridFormatRule gridFormatRule;
        public ItemFormatRule(GridFormatRule gridFormatRule) {
            this.gridFormatRule = gridFormatRule;
        }
        public FormatConditionRuleValue Rule {
            get { return gridFormatRule.Rule as FormatConditionRuleValue; }
        }
        public override string ToString() {
            if(Rule.Condition != FormatCondition.None)
                if(Rule.Condition == FormatCondition.Between || Rule.Condition == FormatCondition.NotBetween) {
                    return string.Format("{0} {1}, {2}", Rule.Condition, Rule.Value1, Rule.Value2);
                }
                else return string.Format("{0} {1}", Rule.Condition, Rule.Value1);
            return string.Format(Properties.Resources.ConditionItemCaption, Index);
        }
        public int Index {
            get { return gridFormatRule.Column.View.FormatRules.IndexOf(gridFormatRule); }
        }
        public GridFormatRule Condition {
            get { return gridFormatRule; }
        }
    }

    public class ItemExpressionFormatRule {
        GridFormatRule gridFormatRuleCore;
        public ItemExpressionFormatRule(GridFormatRule gridFormatRule) {
            this.gridFormatRuleCore = gridFormatRule;
        }
        public FormatConditionRuleExpression Rule {
            get { return gridFormatRuleCore.Rule as FormatConditionRuleExpression; }
        }
        public bool IsExpressionCondition {
            get { return (Rule != null); }
        }
        public override string ToString() {
            if(!IsExpressionCondition)
                return base.ToString();
            if(string.IsNullOrEmpty(Rule.Expression))
                return string.Format(Properties.Resources.EmptyConditionCaption, Index);
            return Rule.Expression;
        }
        public int Index {
            get { return gridFormatRuleCore.Collection.IndexOf(gridFormatRuleCore); }
        }
        public GridFormatRule GridFormatRule {
            get { return gridFormatRuleCore; }
        }
    }
}
