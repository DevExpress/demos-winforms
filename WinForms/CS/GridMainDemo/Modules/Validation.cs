using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for Validation.
	/// </summary>
	public partial class Validation : TutorialControl {
		public Validation() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			gridControl1.ForceInitialize();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "Validation" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Validation"; }
        }

        AppearanceDefault appError = new AppearanceDefault(Color.White, Color.LightCoral, Color.Empty, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
		protected override PaintView[] PaintViews { 
			get { 
				return new PaintView[] {
										   new PaintView(gridView1, "Winter"), 
				};
			}
		} 
		#region Init
		private void Validation_Load(object sender, System.EventArgs e) {
			InitNWindData();
			InitValidateControls();
		}

        string tblGrid = "Order Details";
        string tblLookUp = "Products";
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            return ds;
        }

		private void InitValidateControls() {
			validationControl1.spinEdit1.EditValue = 10;
			validationControl2.imageComboBoxEdit1.SelectedIndex = 4;
			validationControl2.spinEdit1.EditValue = 40;
			validationControl3.imageComboBoxEdit1.SelectedIndex = 1;
			validationControl3.imageComboBoxEdit2.SelectedIndex = 2;
			validationControl3.spinEdit2.EditValue = 0.2;
		}
		#endregion
		#region Validation rule
        //<gridControl1>
		private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
			object[] reply = null;
			if(gridView1.FocusedColumn.FieldName == "UnitPrice") reply = validationControl1.IsTrueCondition(e.Value);
			if(gridView1.FocusedColumn.FieldName == "Quantity") reply = validationControl2.IsTrueCondition(e.Value);
			if(gridView1.FocusedColumn.FieldName == "Discount") reply = validationControl3.IsTrueCondition(e.Value);
			if(reply != null && !(bool)reply[0]) {
				e.ErrorText = reply[1].ToString();
				e.Valid = false;
			}
		}

		/* ~Customize the appearance of invalid cells */
		private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            if(e.RowHandle == GridControl.AutoFilterRowHandle) return;
			object val = gridView1.GetRowCellValue(e.RowHandle, e.Column);
			if((e.Column.FieldName == "UnitPrice" && !(bool)validationControl1.IsTrueCondition(val)[0]) 
				|| (e.Column.FieldName == "Quantity" && !(bool)validationControl2.IsTrueCondition(val)[0]) 
				|| (e.Column.FieldName == "Discount" && !(bool)validationControl3.IsTrueCondition(val)[0])) {
					AppearanceHelper.Apply(e.Appearance, appError);
			}
		}
		
		private void validationControl_ValidateCondition(object sender, System.EventArgs e) {
			gridView1.LayoutChanged();
		}

		private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
			float val = Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn3)) * 
				Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, gridColumn4)) *
				(1 - Convert.ToSingle(gridView1.GetRowCellValue(e.RowHandle, gridColumn5))); //Total Sum
			if(val < 0) {
				e.ErrorText = string.Format("{0}\r\n", Properties.Resources.SubTotalGreaterEqual);
				e.Valid = false;
			}
		}
        //</gridControl1>
		#endregion
		#region Edit errorValue style
        private void simpleButton1_Click(object sender, System.EventArgs e) {
            using(DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm()) {
                frm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Text = Properties.Resources.EditStyle;
                frm.Location = this.PointToScreen(new Point(simpleButton1.Left + simpleButton1.Width / 2, simpleButton1.Top + simpleButton1.Height / 2));
                DevExpress.DXperience.Demos.XtraPropertyGrid grid = new DevExpress.DXperience.Demos.XtraPropertyGrid();
                grid.ShowDescription = false;
                grid.ShowCategories = false;
                grid.PropertyGrid.SelectedObject = appError;
                grid.PropertyGrid.CellValueChanged += new DevExpress.XtraVerticalGrid.Events.CellValueChangedEventHandler(propertyValueChanged);
                grid.Dock = DockStyle.Fill;
                frm.Controls.Add(grid);
                frm.ShowDialog();
            }
		}

		void propertyValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e) {
			gridView1.LayoutChanged();
		}
		#endregion
		protected override void OnVisibleChanged(object sender, EventArgs e) {
			if(!this.Visible) {
				gridView1.HideEditor();
				gridView1.CancelUpdateCurrentRow();
			}
			base.OnVisibleChanged(sender, e);
		}
	}
}
