using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for PopupForm.
    /// </summary>
    public partial class PopupForm : DevExpress.XtraEditors.XtraForm {
		public PopupForm() {
			InitializeComponent();
		}
		public DataRow Row {
			get { return cardView1.GetDataRow(0); }
		}
		void InitLocation(Form frm) {
			this.Top = frm.Top + (frm.Height - this.Height) / 2;
			this.Left = frm.Left + (frm.Width - this.Width) / 2;
		}
		public void InitData(Form frm, GridControl grid, GridView view, DataRow row) {
			InitLocation(frm);
			cardView1.CardCaptionFormat = string.Format("Record {0} of {1}", grid.EmbeddedNavigator.NavigatableControl.Position + 1, grid.EmbeddedNavigator.NavigatableControl.RecordCount);
			foreach(GridColumn col in view.Columns) {
				GridColumn column = cardView1.Columns.Add();
                column.Caption = col.GetTextCaption();
				column.FieldName = col.FieldName;
				column.ColumnEdit = col.ColumnEdit;
				column.DisplayFormat.Assign(col.DisplayFormat);
				column.VisibleIndex = col.VisibleIndex;
			}
			var table = grid.DataSource as DataTable;
			if(table == null && grid.DataSource is DataView)
				table = ((DataView)grid.DataSource).Table;
			if(table != null) {
				var tbl = table.Clone();
				tbl.Rows.Add(row.ItemArray);
				gridControl1.DataSource = tbl;
				cardView1.FocusedColumn = cardView1.Columns[0];
			}
		}
		void simpleButton1_Click(object sender, System.EventArgs e) {
			Row.EndEdit();
		}
	}
}
