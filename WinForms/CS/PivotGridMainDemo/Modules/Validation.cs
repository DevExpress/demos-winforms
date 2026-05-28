using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class Validation : TutorialControl {
        private Validator commonValidation;
        private Validator totalValidation;

        //private Validator totalValidation;
        public Validation() {
			CreateWaitDialog();
			InitializeComponent();

			pivotGridControl.DataSource = GetNWindData("SalesPerson");

            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.Greater.ToString()));
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.GreaterOrEqual.ToString()));
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.Less.ToString()));
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.LessOrEqual.ToString()));
            svgImageCollection1.Add(FilterControl.GetClauseSvgImageByType(ClauseType.DoesNotEqual.ToString()));

            commonValidation = new Validator(layoutControlItem5, layoutControlItem1, layoutControlItem6, layoutControlItem7);
            commonValidation.ValidateCondition += validationControl_ValidateCondition;
            totalValidation = new Validator(layoutControlItem2, layoutControlItem8, layoutControlItem9, layoutControlItem10);
            totalValidation.ValidateCondition += validationControl_ValidateCondition;
        }
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			InitValidationControls();
			pivotGridControl.HeaderImages = HeadersImageList;
			pivotGridControl.ValueImages = CategoryImageList;
			fieldSalesPerson.ImageIndex = 0;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;
		}

		private void pivotGridControl_EditorValueChanged(object sender, EditValueChangedEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldQuantity)) {
				PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                int editValue = Convert.ToInt32(e.Editor.EditValue);
                if(ds.RowCount > 0) {                    
                    int newCellValue = (int)Math.Floor((decimal)editValue / ds.RowCount),
                        extra = editValue % ds.RowCount;
                    for(int i = 0; i < ds.RowCount; i++) {
                        if(i == ds.RowCount - 1)
                            ds[i][fieldQuantity] = (short)(newCellValue + extra);
                        else
                            ds[i][fieldQuantity] = (short)newCellValue;
                    }
                } else {
                    DataTable table = ((DataView)pivotGridControl.DataSource).Table;
                    object[] row = new object[table.Columns.Count];
                    SetRowValues(PivotArea.ColumnArea, e, table, row);
                    SetRowValues(PivotArea.RowArea, e, table, row);
                    int columnIndex = table.Columns.IndexOf(fieldQuantity.FieldName);
                    row[columnIndex] = editValue;
                    table.Rows.Add(row);
                    table.AcceptChanges();
                    pivotGridControl.RefreshData();
                }
			}
		}
        private void SetRowValues(PivotArea area, EditValueChangedEventArgs e, DataTable table, object[] row) {
            List<PivotGridField> fields = pivotGridControl.GetFieldsByArea(area);
            for(int i = 0; i < fields.Count; i++) {
                object value = e.GetFieldValue(fields[i]);
                int columnIndex = table.Columns.IndexOf(fields[i].FieldName);
                row[columnIndex] = value;
            }            
        }
        //<layoutControl1>
        private void pivotGridControl_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			PivotCellEventArgs focusedCell = GetFocusedCellInfo(pivotGridControl);
			if(Comparer.ReferenceEquals(focusedCell.DataField, fieldQuantity)) {
				int convertedValue = 0;
				int oldValue = Convert.ToInt32(focusedCell.Value);
				try {
					if(IsTotalOrGrandTotal(focusedCell)) {
						convertedValue = Convert.ToInt32(e.Value);
						double factor = (double)convertedValue / (double)oldValue;
						double newMaxValue = factor * Convert.ToDouble(focusedCell.SummaryValue.Max);
						try {
							Convert.ToInt16(newMaxValue);
						} catch {
							e.Valid = false;
							e.ErrorText = "Value cann't be decomposed to the components of type Int16";
						}
						ApplyValidation(totalValidation, convertedValue, e);
					} else {
						convertedValue = (int)Convert.ToInt16(e.Value);
						ApplyValidation(commonValidation, convertedValue, e);
					}
				} catch(Exception ex) {
					e.Valid = false;
					e.ErrorText = ex.Message;
				}
				e.Value = convertedValue;
			}
		}
        //</layoutControl1>
        private void InitValidationControls() {
			commonValidation.SpinEdit1.EditValue = 0;
			commonValidation.ImageComboBoxEdit1.SelectedIndex = 1;
			commonValidation.ImageComboBoxEdit2.SelectedIndex = 2;
			commonValidation.SpinEdit2.EditValue = 150;
			totalValidation.SpinEdit1.EditValue = 0;
			totalValidation.ImageComboBoxEdit1.SelectedIndex = 1;
			totalValidation.ImageComboBoxEdit2.SelectedIndex = 2;
			totalValidation.SpinEdit2.EditValue = 1500;
		}
        //<layoutControl1>
        void ApplyValidation(Validator validation, int value, BaseContainerValidateEditorEventArgs e) {
			object[] reply = validation.IsTrueCondition(value);
			if(reply != null && !(bool)reply[0]) {
				e.ErrorText = reply[1].ToString();
				e.Valid = false;
			}
		}
        //</layoutControl1>
        PivotCellEventArgs GetFocusedCellInfo(PivotGridControl pivot) {
			Point focusedCell = pivot.Cells.FocusedCell;
			return pivot.Cells.GetCellInfo(focusedCell.X, focusedCell.Y);
		}

		private void pivotGridControl_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e) {
			if(!Comparer.ReferenceEquals(e.DataField, fieldQuantity))
				return;
			if(IsTotalOrGrandTotal(e)) {
				if(!(bool)totalValidation.IsTrueCondition(e.Value)[0]) {
					e.Appearance.BackColor = Color.Pink;
                    e.Appearance.BackColor2 = Color.Pink;
				}
			} else {
				if(!(bool)commonValidation.IsTrueCondition(e.Value)[0]) {
					e.Appearance.BackColor = Red;
                    e.Appearance.BackColor2 = Red;
				}
			}
		}
		bool IsTotalOrGrandTotal(PivotCellEventArgs e) {
			return e.ColumnValueType == PivotGridValueType.Total || e.RowValueType == PivotGridValueType.Total || e.ColumnValueType == PivotGridValueType.GrandTotal || e.RowValueType == PivotGridValueType.GrandTotal;
		}

		private void validationControl_ValidateCondition(object sender, EventArgs e) {
			pivotGridControl.LayoutChanged();
		}

		private void pivotGridControl_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}

        protected override void DoHide() {
            base.DoHide();
            pivotGridControl.CloseEditor();
        }
    }

    class Validator {
        public Validator(LayoutControlItem imageComboBoxEdit1item, LayoutControlItem spinEdit1Item, LayoutControlItem imageComboBoxEdit2item, LayoutControlItem spinEdit2Item) {
            this.SpinEdit1Item = spinEdit1Item;
            this.SpinEdit2Item = spinEdit2Item;
            this.ImageComboBoxEdit1Item = imageComboBoxEdit1item;
            this.ImageComboBoxEdit2Item = imageComboBoxEdit2item;
            ImageComboBoxEdit1.SelectedIndexChanged += imageComboBoxEdit1_SelectedIndexChanged;
            ImageComboBoxEdit2.SelectedIndexChanged += imageComboBoxEdit2_SelectedIndexChanged;
            SpinEdit1.ValueChanged += spinEdit_EditValueChanged;
            SpinEdit2.ValueChanged += spinEdit_EditValueChanged;
        }

        
        LayoutControlItem ImageComboBoxEdit1Item { get; set; }
        LayoutControlItem ImageComboBoxEdit2Item { get; set; }
        LayoutControlItem SpinEdit1Item { get; set; }
        LayoutControlItem SpinEdit2Item { get; set; }
        public ImageComboBoxEdit ImageComboBoxEdit1 { get { return (ImageComboBoxEdit)ImageComboBoxEdit1Item.Control; } }
        public ImageComboBoxEdit ImageComboBoxEdit2 { get { return (ImageComboBoxEdit)ImageComboBoxEdit2Item.Control; } }
        public SpinEdit SpinEdit1 { get { return (SpinEdit)SpinEdit1Item.Control; } }
        public SpinEdit SpinEdit2 { get { return (SpinEdit)SpinEdit2Item.Control; } }

        public event EventHandler ValidateCondition;

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, System.EventArgs e) {
            bool visibleNextCondition = (int)ImageComboBoxEdit1.EditValue < 2;
            ImageComboBoxEdit2Item.Visibility =  visibleNextCondition ?
                XtraLayout.Utils.LayoutVisibility.Always :
                XtraLayout.Utils.LayoutVisibility.Never;
            SetSpin2Visibility(visibleNextCondition && !ImageComboBoxEdit2.EditValue.Equals(0));
            //label2.Visible = imageComboBoxEdit2.Visible = spinEdit2.Visible = visibleNextCondition;
            RaiseValidateCondition();
        }

        private void SetSpin2Visibility(bool visibility) {
            SpinEdit2Item.Visibility = visibility ? XtraLayout.Utils.LayoutVisibility.Always :
                                                    XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void imageComboBoxEdit2_SelectedIndexChanged(object sender, System.EventArgs e) {
            //ImageComboBoxEdit2Item.Enabled = SpinEdit2Item.Enabled = !ImageComboBoxEdit2.EditValue.Equals(0);
            SetSpin2Visibility(!ImageComboBoxEdit2.EditValue.Equals(0));
            //spinEdit2.Visible = label2.Enabled = !imageComboBoxEdit2.EditValue.Equals(0);
            RaiseValidateCondition();
        }

        private void spinEdit_EditValueChanged(object sender, System.EventArgs e) {
            RaiseValidateCondition();
        }

        protected void RaiseValidateCondition() {
            if(ValidateCondition != null)
                ValidateCondition(this, new EventArgs());
        }
        public object[] IsTrueCondition(object val) {
            decimal dValue = Convert.ToDecimal(val);
            decimal value1 = Convert.ToDecimal(SpinEdit1.EditValue);
            decimal value2 = Convert.ToDecimal(SpinEdit2.EditValue);
            int condition1 = ImageComboBoxEdit1.SelectedIndex;
            int condition2 = ImageComboBoxEdit2.SelectedIndex;
            bool greater = false;
            string reply = "";
            if(condition1 == 2) {
                reply = "The value must be less than " + value1.ToString();
                return new object[] { (dValue < value1), reply };
            }
            if(condition1 == 3) {
                reply = "The value must be less than or equal to " + value1.ToString();
                return new object[] { (dValue <= value1), reply };
            }
            if(condition1 == 4) {
                reply = "The value must not equal " + value1.ToString();
                return new object[] { (dValue != value1), reply };
            }
            if(condition1 == 0) {
                reply = "The value must be greater than " + value1.ToString();
                greater = dValue > value1;
            }
            if(condition1 == 1) {
                reply = "The value must be greater than or equal to " + value1.ToString();
                greater = dValue >= value1;
            }
            if(condition2 == 0) return new object[] { greater, reply };
            if(greater) {
                if(condition2 == 1) {
                    reply = "The value must be less than " + value2.ToString();
                    return new object[] { (greater && dValue < value2), reply };
                }
                if(condition2 == 2) {
                    reply = "The value must be less than or equal to " + value2.ToString();
                    return new object[] { (greater && dValue <= value2), reply };
                }
            }
            return new object[] { false, reply };
        }
    }
}
