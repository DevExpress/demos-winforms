using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for ConditionsEditor.
	/// </summary>
	public partial class ConditionsEditor : DevExpress.XtraEditors.XtraForm {
		public ConditionsEditor(GridColumn column, Form parent) {
			//
			// Required for Windows Form Designer support
			//
			this.gridView = column.View as GridView;
			this.column = column;
			InitializeComponent();
			Left = parent.Left + (parent.Width - Width) / 2;
			Top = parent.Top + (parent.Height - Height) / 2;
            Text += string.Format(Properties.Resources.ForColumn, column.GetTextCaption());
			FillData();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        GridView gridView;
        GridColumn column;
		private void FillData() {
			FormatItemList.Items.Clear();
			if(gridView == null || column == null) return;
            foreach(GridFormatRule fRule in gridView.FormatRules)
                if(column.Equals(fRule.Column))
                    FormatItemList.Items.Add(new ItemFormatRule(fRule)); 
			if(FormatItemList.Items.Count > 0) FormatItemList.SelectedIndex = 0;
			else conditionsItem1.InitItem(null);
		}

		void SetRemoveEnabled() {
			sbRemove.Enabled = FormatItemList.SelectedIndex > -1;
		}

		private void FormatItemList_SelectedIndexChanged(object sender, System.EventArgs e) {
			SetRemoveEnabled();		
			if(FormatItemList.SelectedItem != null)
				conditionsItem1.InitItem(gridView.FormatRules[((ItemFormatRule)FormatItemList.SelectedItem).Index]);
			else conditionsItem1.InitItem(null);
		}

		private void conditionsItem1_RefreshValues(object sender, System.EventArgs e) {
			FormatItemList.Refresh();
		}

		private void sbAdd_Click(object sender, System.EventArgs e) {
			if(gridView == null) return;
			FormatItemList.Items.BeginUpdate();
            GridFormatRule item = new GridFormatRule();
            item.Rule = new FormatConditionRuleValue();
			item.Column = this.column;
			gridView.FormatRules.Add(item);
			ItemFormatRule iCondition = new ItemFormatRule(item);
			FormatItemList.Items.Add(iCondition);
			FormatItemList.SelectedItem = iCondition;
			FormatItemList.Items.EndUpdate();
		}

		private void sbRemove_Click(object sender, System.EventArgs e) {
			if(gridView == null) return;
			ItemFormatRule condition = FormatItemList.SelectedItem as ItemFormatRule;
			if(condition == null) return;
			gridView.FormatRules.RemoveAt(condition.Index);	
			FormatItemList.Items.Remove(condition);
		}

		private void ConditionsEditor_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode == Keys.Escape) this.Close();
		}
	}
}
