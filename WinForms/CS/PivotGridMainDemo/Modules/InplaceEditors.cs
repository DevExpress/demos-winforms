using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class InplaceEditors : TutorialControl {
		object[,] cells;
		List<Point> difference;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object[,] LastCells {
			get { return cells; }
			set {
				cells = value;
			}
		}

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Point> PointDifference { get { return difference; } set { difference = value; } }

		public InplaceEditors() {
			CreateWaitDialog();
			InitializeComponent();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            pivotGridControl.BeginUpdate();
            pivotGridControl.DataSource = GetNWindData("SalesPerson");
            pivotGridControl.HeaderImages = HeadersImageList;
            pivotGridControl.ValueImages = CategoryImageList;
            fieldSalesPerson.ImageIndex = 0;
            fieldExtendedPrice.ImageIndex = 3;
            fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            fieldExtendedPrice.CellFormat.FormatString = "c2";
            pivotGridControl.EndUpdate();
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;
            pivotGridControl.OptionsCustomization.AllowSortBySummary = false;
        }

        void progressBar_KeyPress(object sender, KeyPressEventArgs e) {
			int value = Convert.ToInt32(pivotGridControl.ActiveEditor.EditValue);
			if(e.KeyChar == '+')
				pivotGridControl.ActiveEditor.EditValue = Math.Min(value + 1, 99);
			if(e.KeyChar == '-')
				pivotGridControl.ActiveEditor.EditValue = Math.Max(value - 1, 0);
			e.Handled = true;
		}

        //<pivotGridControl>
		private void pivotGridControl_CustomEditValue(object sender, CustomEditValueEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldPercents))
				e.Value = Convert.ToDouble(e.Value) * 100f;
		}

		private void pivotGridControl_EditorValueChanged(object sender, EditValueChangedEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldExtendedPrice)) {
				ChangeCellValue(e, Convert.ToDecimal(e.Value), Convert.ToDecimal(e.Editor.EditValue));
			}
			if(Comparer.ReferenceEquals(e.DataField, fieldPercents)) {
				decimal c0 = Convert.ToDecimal(e.GetCellValue(fieldExtendedPrice));
				decimal p0 = Convert.ToDecimal(e.Value);
				decimal p1 = Convert.ToDecimal(e.Editor.EditValue);
				decimal newValue = (p0 == 0m || p1 == 0m) ? 0m : c0 * (100m / p0 - 1m) / (100m / p1 - 1m);

				ChangeCellValue(e, c0, newValue);
			}
		}
		void ChangeCellValue(EditValueChangedEventArgs e, decimal oldValue, decimal newValue) {
			PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
			if(ds.RowCount == 0)
				return;
			decimal difference = newValue - oldValue;
			decimal factor = (difference == newValue) ? (difference / ds.RowCount) : (difference / oldValue);
			for(int i = 0; i < ds.RowCount; i++) {
				decimal value = Convert.ToDecimal(ds[i][fieldExtendedPrice]);
                ds[i][fieldExtendedPrice] = (value == 0m) ? factor : value * (1m + factor);
			}
		}
        //</pivotGridControl>

		object[,] GetCellsState(PivotGridControl pivot) {
			object[,] result = new object[pivot.Cells.ColumnCount, pivot.Cells.RowCount];
			for(int i = 0; i < pivot.Cells.ColumnCount; i++)
				for(int j = 0; j < pivot.Cells.RowCount; j++)
					result[i, j] = pivot.Cells.GetCellInfo(i, j).Value;
			return result;
		}
		List<Point> CalculatePointDifference(object[,] lastCells, object[,] currentState) {
			if(lastCells == null || lastCells.Length == 0 || lastCells.Length != currentState.Length)
				return null;
			List<Point> difference = new List<Point>();
				for(int i = lastCells.GetLowerBound(0); i <= lastCells.GetUpperBound(0); i++)
					for(int j = lastCells.GetLowerBound(1); j <= lastCells.GetUpperBound(1); j++)
						if(!object.Equals(lastCells[i, j], currentState[i, j]))
							difference.Add(new Point(i, j));
			return difference;
        }

		Color highlightColor = Color.Red;
        List<Point> currentDifferences = new List<Point>();
		void pivotGridControl_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e) {
            if (PointDifference == null) return;
            if (PointDifference.Count != 0)
                currentDifferences = new List<Point>(PointDifference);
            bool highlight = currentDifferences.Contains(new Point(e.ColumnIndex, e.RowIndex));
			if(highlight) {
				e.Appearance.FontStyleDelta = FontStyle.Bold;
				e.Appearance.ForeColor = highlightColor;
			}
        }
		PivotCellEventArgs GetFocusedCellInfo(PivotGridControl pivot) {
			Point focusedCell = pivot.Cells.FocusedCell;
			return pivot.Cells.GetCellInfo(focusedCell.X, focusedCell.Y);
		}
        private void pivotGridControl_ShowingEditor(object sender, CancelPivotCellEditEventArgs e) {
			PivotCellEventArgs cellInfo = GetFocusedCellInfo(pivotGridControl);
			if(cellInfo.RowValueType == PivotGridValueType.GrandTotal || cellInfo.ColumnValueType == PivotGridValueType.GrandTotal)
				e.Cancel = true;
		}

		private void pivotGridControl_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}

		private void pivotGridControl_GridLayout(object sender, EventArgs e) {
			object[,] currentCells = GetCellsState(pivotGridControl);
    		PointDifference = CalculatePointDifference(LastCells, currentCells);
			LastCells = currentCells;
		}
	}
}
