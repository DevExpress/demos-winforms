using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class HitInfo : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public HitInfo() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
		}

		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; }}
		public override PivotGridControl ExportControl { get { return pivotGridControl1; }}

		private void HitInfo_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.HeaderImages = HeadersImageList;
			pivotGridControl1.ValueImages = CategoryImageList;
			fieldSalesPerson.ImageIndex = 0;
			fieldCountry.CollapseValue("UK");
			ShowHitInfo(null);
		}


		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}

        //<pivotGridControl1>
		private void pivotGridControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			ShowHitInfo(pivotGridControl1.CalcHitInfo(new Point(e.X, e.Y)));
		}

		private void pivotGridControl1_MouseLeave(object sender, System.EventArgs e) {
			ShowHitInfo(pivotGridControl1.CalcHitInfo(new Point(-1, -1)));
		}

        //<panelControl1>
		void ShowHitInfo(PivotGridHitInfo info) {
            ShowCellInfo(info);
            ShowValueInfo(info);
            ShowHeaderInfo(info);
            bool hintVisible = lcgCell.Visibility != XtraLayout.Utils.LayoutVisibility.Always &&
                               lcgValue.Visibility != XtraLayout.Utils.LayoutVisibility.Always &&
                               lcgHeadersArea.Visibility != XtraLayout.Utils.LayoutVisibility.Always;
            lciHint.Visibility = hintVisible ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        //</panelControl1>
        //</pivotGridControl1>

        void ShowCellInfo(PivotGridHitInfo info) {
            if(info == null || info.CellInfo == null) {
                lcgCell.Visibility=XtraLayout.Utils.LayoutVisibility.Never;
                return;
            }
            lcgCell.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            textEdit1.Text = info.CellInfo.DisplayText;
            textEdit2.Text = string.Format("{0}, {1}", info.CellInfo.ColumnIndex, info.CellInfo.RowIndex);
            textEdit3.Text = string.Format("{0}", info.CellInfo.Value);
            textEdit4.Text = info.CellInfo.DataField != null ? info.CellInfo.DataField.ToString() : "";
        }
        void ShowValueInfo(PivotGridHitInfo info) {
            if(info == null || info.ValueInfo== null) {
                lcgValue.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                return;
            }
            lcgValue.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            textEdit5.Text = string.Format("{0}", info.ValueInfo.Value);
            textEdit6.Text = string.Format("{0}", info.ValueInfo.ValueType);
            textEdit7.Text = string.Format("{0}", info.ValueInfo.Field);
        }

        void ShowHeaderInfo(PivotGridHitInfo info) {
            if(info == null || info.HeadersAreaInfo == null) {
                lcgHeadersArea.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
                return;
            }
            lcgHeadersArea.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            textEdit8.Text = string.Format("{0}", info.HeadersAreaInfo.Area);
            textEdit9.Text = string.Format("{0}", info.HeadersAreaInfo.Field);
        }
            private void paddingPanel_Paint(object sender, PaintEventArgs e) {

        }
	}
}

