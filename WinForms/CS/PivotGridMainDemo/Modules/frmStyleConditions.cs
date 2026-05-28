using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for frmStyleConditions.
    /// </summary>
    public partial class frmStyleConditions : DevExpress.XtraEditors.XtraForm {
        public frmStyleConditions(Point location, PivotGridField field) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.Location = location;
            this.field = field;
            FillData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private DevExpress.XtraPivotGrid.Demos.ConditionItem conditionItem1;
        PivotGridField field;
        private void FillData() {
            FormatItemList.Items.Clear();
            if(field == null) return;
            for(int i = 0; i < field.PivotGrid.FormatConditions.Count; i++) {
                if(field.Equals(field.PivotGrid.FormatConditions[i].Field))
                    FormatItemList.Items.Add(new DemoFormatCondition(field.PivotGrid.FormatConditions[i]));
            }
            if(FormatItemList.Items.Count > 0) FormatItemList.SelectedIndex = 0;
            else conditionItem1.InitItem(null);
        }

        void SetRemoveEnabled() {
            sbRemove.Enabled = FormatItemList.SelectedIndex > -1;
        }

        private void FormatItemList_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetRemoveEnabled();
            if(FormatItemList.SelectedItem != null)
                conditionItem1.InitItem(field.PivotGrid.FormatConditions[((DemoFormatCondition)FormatItemList.SelectedItem).Index]);
            else
                conditionItem1.InitItem(null);
        }

        private void sbAdd_Click(object sender, System.EventArgs e) {
            FormatItemList.Items.BeginUpdate();
            PivotGridStyleFormatCondition item = new PivotGridStyleFormatCondition();
            item.Field = this.field;
            field.PivotGrid.FormatConditions.Add(item);
            DemoFormatCondition demoCondition = new DemoFormatCondition(item);
            FormatItemList.Items.Add(demoCondition);
            FormatItemList.SelectedItem = demoCondition;
            FormatItemList.Items.EndUpdate();
        }

        private void sbRemove_Click(object sender, System.EventArgs e) {
            DemoFormatCondition condition = FormatItemList.SelectedItem as DemoFormatCondition;
            if(condition == null) return;
            field.PivotGrid.FormatConditions.Remove(condition.StyleCondition);
            FormatItemList.Items.Remove(condition);
        }

        private void frmStyleConditions_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) this.Close();
        }

        private void conditionItem1_RefreshValues(object sender, System.EventArgs e) {
            FormatItemList.Refresh();
        }
    }
}
