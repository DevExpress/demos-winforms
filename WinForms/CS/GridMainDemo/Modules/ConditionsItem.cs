using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for ConditionsItem.
	/// </summary>
	public partial class ConditionsItem : XtraUserControl {
		public ConditionsItem() {
			// This call is required by the Windows.Forms Form Designer.
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			InitializeComponent();
			propertyGrid1.ShowButtons = propertyGrid1.ShowCategories = propertyGrid1.ShowDescription = false;
			this.BackColor = Color.Transparent;
			InitConditions();
			// TODO: Add any initialization after the InitForm call

		}
        BaseEdit be1 = null;
        BaseEdit be2 = null;
        GridFormatRule item = null;
        bool init = false;
		public event EventHandler RefreshValues;

        FormatConditionRuleValue Rule {
            get {
                if(item == null) return null;
                return item.Rule as FormatConditionRuleValue;
            }
        }
		void InitConditions() {
            foreach(FormatCondition mode in Enum.GetValues(typeof(FormatCondition))) {
                if(mode == FormatCondition.Expression) continue;
                icbCondition.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FormatCondition>.GetTitle(mode), mode, -1));
            }
		}

		void SetCheckEditStyle(BaseEdit be, string s) {
			CheckEdit ce = (CheckEdit)be;
			ce.Properties.AllowGrayed = true;
			ce.Text = s;
		}

		void SetSpinStyle(BaseEdit be, Type type) {
			SpinEdit se = (SpinEdit)be;
			if("System.Int16System.Int32System.Int64System.Byte".IndexOf(type.ToString()) > -1)
				se.Properties.IsFloatValue = false;
		}

		void CreateValues(Type type) {
			if(type.Equals(typeof(Boolean))) {
				be1 = new CheckEdit();
				be2 = new CheckEdit();
				SetCheckEditStyle(be1, string.Format("{0}1", Properties.Resources.Value));
                SetCheckEditStyle(be2, string.Format("{0}2", Properties.Resources.Value));
				lbVal1.Visible = lbVal2.Visible = false;
			}
			else if(type.IsValueType) {
				be1 = new SpinEdit();
				be2 = new SpinEdit();
				SetSpinStyle(be1, type);
				SetSpinStyle(be2, type);
			} else {
				be1 = new TextEdit();
				be2 = new TextEdit();
			}
			be1.Size = be2.Size = new Size(icbCondition.Width, icbCondition.Height);
			if(type.Equals(typeof(Boolean))) {
				be1.Location = lbVal1.Location;
				be2.Location = lbVal2.Location;
			} else {
				be1.Location = new Point(icbCondition.Location.X, lbVal1.Location.Y);
				be2.Location = new Point(icbCondition.Location.X, lbVal2.Location.Y);
			}
			be1.Validated += new EventHandler(val1_Validate);
			be2.Validated += new EventHandler(val2_Validate);
			be1.TabIndex = 2;
			be2.TabIndex = 3;
			this.Controls.Add(be1);
			this.Controls.Add(be2);
		}

        public void InitItem(GridFormatRule item) {
			this.item = item;
			init = true;
			bool IsNull = item == null;
			if(!IsNull) {
				if(be1 == null) CreateValues(item.Column.ColumnType);
				ceRow.Checked = item.ApplyToRow;
				propertyGrid1.PropertyGrid.SelectedObject = Rule.Appearance;
				icbCondition.EditValue = Rule.Condition;
				be1.EditValue = Rule.Value1;
				be2.EditValue = Rule.Value2;
			}
			ceRow.Enabled = icbCondition.Enabled = !IsNull;
			if(be1 != null) { be1.Visible = be2.Visible = !IsNull; }
			if(IsNull) propertyGrid1.PropertyGrid.SelectedObject = null;
			init = false;
		}

		void RaiseRefreshValues() {
			if(RefreshValues != null) RefreshValues(this, EventArgs.Empty);
		}

		private void icbCondition_SelectedIndexChanged(object sender, System.EventArgs e) {
			if(init || item == null) return;
			Rule.Condition = (FormatCondition)icbCondition.EditValue;
			RaiseRefreshValues();
		}

		private void ceRow_CheckedChanged(object sender, System.EventArgs e) {
			if(init || item == null) return;
			item.ApplyToRow = ceRow.Checked;
		}

        void SetValue(bool value1, object val) {
			try {
				if(val != null)
					val = Convert.ChangeType(val, item.Column.ColumnType);
				if(value1) Rule.Value1 = val;
				else Rule.Value2 = val;
			} catch {
			}
			init = true;
			if(value1) be1.EditValue = Rule.Value1;
			else be2.EditValue = Rule.Value2;
			init = false;
			RaiseRefreshValues();
		}

		void val1_Validate(object sender, EventArgs e) {
			if(init || item == null) return;
			SetValue(true, be1.EditValue);
		}

		void val2_Validate(object sender, EventArgs e) {
			if(init || item == null) return;
			SetValue(false, be2.EditValue);
		}
	}
}
