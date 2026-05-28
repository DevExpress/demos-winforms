using DevExpress.Data.Filtering;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ExpressionEditor;
using DevExpress.XtraEditors.ListControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Internal;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos {
    public partial class ExpressionConditionsEditor : XtraUserControl {
        bool _init = false;
        GridView view = null;
        public ExpressionConditionsEditor() {
            InitializeComponent();
        }
        FilterPanel panel;
        public void Init(GridView view) {
            this.view = view;
            this.panel = new FilterPanel(view);
            InitConditions();
            InitColumns();
            if(FormatItemList.Items.Count > 0)
                FormatItemList.SelectedIndex = 0;
            FormatItemList.MeasureItem += FormatItemList_MeasureItem;
            FormatItemList.DrawItem += FormatItemList_DrawItem;
        }
        void FormatItemList_DrawItem(object sender, ListBoxDrawItemEventArgs e) {
            var exprItem = e.Item as ItemExpressionFormatRule;
            var criteria = CriteriaOperator.TryParse(exprItem.Rule.Expression);
            Padding padding = GetPadding(e.Cache);
            var content = new Rectangle(
                e.Bounds.X + padding.Left, e.Bounds.Y + padding.Top,
                e.Bounds.Width - padding.Horizontal, e.Bounds.Height - padding.Vertical);
            e.DrawItemBackground();
            panel.DrawItem(e, criteria, content);
            e.Handled = true;
        }
        void FormatItemList_MeasureItem(object sender, MeasureItemEventArgs e) {
            var args = e as ListBoxMeasureItemEventArgs;
            var exprItem = FormatItemList.Items[args.Index] as ItemExpressionFormatRule;
            var criteria = CriteriaOperator.TryParse(exprItem.Rule.Expression);
            var itemSize = panel.MeasureItem(args.Cache, criteria);
            Padding padding = GetPadding(args.Cache);
            e.ItemHeight = itemSize.Height + padding.Vertical;
            e.ItemWidth = itemSize.Width + padding.Horizontal;
        }
        Padding GetPadding(GraphicsCache cache) {
            return cache.ScaleDPI.ScalePadding(new Padding(4, 1, 4, 1));
        }
        void InitColumns() {
            if(view == null) return;
            foreach(GridColumn col in view.Columns)
                imageComboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(col.GetTextCaption(), col, -1));
        }
        void InitConditions() {
            if(view == null) return;
            FormatItemList.BeginUpdate();
            try {
                FormatItemList.Items.Clear();
                foreach(GridFormatRule condition in view.FormatRules) {
                    ItemExpressionFormatRule eCondition = new ItemExpressionFormatRule(condition);
                    if(eCondition.IsExpressionCondition) {
                        FormatItemList.Items.Add(eCondition);
                    }
                }
            }
            finally { FormatItemList.EndUpdate(); }
        }
        GridFormatRule CurrentCondition {
            get {
                if(FormatItemList.SelectedItem != null)
                    return ((ItemExpressionFormatRule)FormatItemList.SelectedItem).GridFormatRule;
                return null;
            }
        }
        void ShowEditor(GridFormatRule condition) {
            FormatConditionRuleExpression rule = condition.Rule as FormatConditionRuleExpression;
            if(rule == null)
                return;
            var context = new GridColumnIDataColumnInfoWrapper(view.Columns[0], GridColumnIDataColumnInfoWrapperEnum.ExpressionEditor);
            string expressionString = rule.Expression;
            if(ExpressionEditorHelper.RunExpressionEditor(ref expressionString, context, LookAndFeel, view.GridControl.MenuManager, true))
                rule.Expression = expressionString;
        }
        void ShowEditor() {
            if(CurrentCondition == null)
                return;
            ShowEditor(CurrentCondition);
            ((Utils.IContextItemCollectionOwner)FormatItemList).OnCollectionChanged();
        }
        void FormatItemList_MouseDoubleClick(object sender, MouseEventArgs e) {
            ShowEditor();
        }
        void SelectObjectUpdate() {
            if(_updating)
                return;
            EnableButtons();
            _init = true;
            if(CurrentCondition == null) {
                propertyGrid1.Enabled = false;
                propertyGrid1.SelectedObject = null;
            }
            else {
                propertyGrid1.Enabled = true;
                propertyGrid1.SelectedObject = ((FormatConditionRuleExpression)CurrentCondition.Rule).Appearance;
                checkEdit1.Checked = CurrentCondition.ApplyToRow;
                imageComboBoxEdit1.EditValue = CurrentCondition.Column;
            }
            _init = false;
        }
        void FormatItemList_SelectedIndexChanged(object sender, EventArgs e) {
            SelectObjectUpdate();
        }
        void EnableButtons() {
            btnDelete.Enabled = CurrentCondition != null;
            btnEdit.Enabled = CurrentCondition != null;
        }
        bool _updating = false;
        //<checkEdit1>
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            if(CurrentCondition == null || _init)
                return;
            CurrentCondition.ApplyToRow = checkEdit1.Checked;
        }
        //</checkEdit1>
        void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if(CurrentCondition == null || _init)
                return;
            GridColumn col = imageComboBoxEdit1.EditValue as GridColumn;
            CurrentCondition.Column = col;
        }
        void propertyGrid1_CustomRecordCellEdit(object sender, XtraVerticalGrid.Events.GetCustomRowCellEditEventArgs e) {
            if(e.Row.Properties.RowType.Equals(typeof(Color))) {
                e.RepositoryItem = repositoryItemColorPickEdit1;
            }
        }
        //<FormatItemList>
        void btnAdd_Click(object sender, EventArgs e) {
            GridFormatRule condition = new GridFormatRule();
            condition.Rule = new FormatConditionRuleExpression();
            view.FormatRules.Add(condition);
            int index = FormatItemList.Items.Count;
            InitConditions();
            FormatItemList.SelectedIndex = index;
            ShowEditor();
        }
        void btnDelete_Click(object sender, EventArgs e) {
            _updating = true;
            if(CurrentCondition == null) return;
            view.FormatRules.Remove(CurrentCondition);
            FormatItemList.Items.RemoveAt(FormatItemList.SelectedIndex);
            _updating = false;
            SelectObjectUpdate();
        }
        void btnEdit_Click(object sender, EventArgs e) {
            ShowEditor();
        }
        //</FormatItemList>
    }
}
