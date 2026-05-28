using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;

namespace DevExpress.XtraPivotGrid.Demos {
    public partial class ConditionItem : DevExpress.XtraEditors.XtraUserControl {
        public ConditionItem() {
            InitializeComponent();
            InitConditions();
        }

        bool init = false;
        PivotGridStyleFormatCondition item = null;
        public event EventHandler RefreshValues;
        void InitConditions() {
            icbCondition.Properties.Items.AddEnum(typeof(FormatConditionEnum));
        }

        public void InitItem(PivotGridStyleFormatCondition item) {
            this.item = item;
            init = true;
            bool IsNull = item == null;
            if(!IsNull) {
                propertyGrid1.PropertyGrid.SelectedObject = item.Appearance;
                icbCondition.EditValue = item.Condition;
                seValue1.EditValue = item.Value1;
                seValue2.EditValue = item.Value2;
                ceCell.Checked = item.ApplyToCell;
                ceTotalCell.Checked = item.ApplyToTotalCell;
                ceGrandTotalCell.Checked = item.ApplyToGrandTotalCell;
                ceCustomSummaryCell.Checked = item.ApplyToCustomTotalCell;
            }
            else {
                propertyGrid1.PropertyGrid.SelectedObject = null;
                icbCondition.EditValue = null;
                seValue1.EditValue = seValue2.EditValue = 0;
                ceCell.Checked = ceTotalCell.Checked = ceGrandTotalCell.Checked = ceCustomSummaryCell.Checked = false;
            }
            icbCondition.Enabled = seValue1.Enabled = seValue2.Enabled = ceCell.Enabled =
                ceTotalCell.Enabled = ceGrandTotalCell.Enabled = ceCustomSummaryCell.Enabled = !IsNull;
            init = false;
        }

        void RaiseRefreshValues() {
            if(RefreshValues != null) RefreshValues(this, EventArgs.Empty);
        }

        private void icbCondition_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.Condition = (FormatConditionEnum)icbCondition.EditValue;
            RaiseRefreshValues();
        }

        private void seValue1_EditValueChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.Value1 = seValue1.Value;
            RaiseRefreshValues();
        }

        private void seValue2_EditValueChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.Value2 = seValue2.Value;
            RaiseRefreshValues();
        }

        private void ceCell_CheckedChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.ApplyToCell = ceCell.Checked;
        }

        private void ceTotalCell_CheckedChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.ApplyToTotalCell = ceTotalCell.Checked;
        }

        private void ceGrandTotalCell_CheckedChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.ApplyToGrandTotalCell = ceGrandTotalCell.Checked;
        }

        private void ceCustomSummaryCell_CheckedChanged(object sender, System.EventArgs e) {
            if(init || item == null) return;
            item.ApplyToCustomTotalCell = ceCustomSummaryCell.Checked;
        }
    }
}
