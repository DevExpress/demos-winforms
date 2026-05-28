using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for Preview.
    /// </summary>
    public partial class Preview : TutorialControl {
        public Preview() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "Preview" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Preview"; }
        }

        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        private void Preview_Load(object sender, System.EventArgs e) {
            InitNWindData();
            InitGrid();
        }

        string tblName = "Employees";
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            ds.ReadXml(dataFileName);
            gridControl1.DataSource = ds.Tables[tblName];
            return ds;
        }
        private void InitGrid() {
            ceAuto.Checked = true;
            ceCustom.Checked = true;
            string separator = "------------------------";
            foreach(DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
                if(!column.FieldName.Equals("Photo"))
                    cbName.Properties.Items.Add(new ImageComboBoxItem(column.GetCaption(), column.FieldName, -1));
            cbName.Properties.Items.Add(new ImageComboBoxItem(separator, separator));
            cbName.Properties.Items.Add(new ImageComboBoxItem(Properties.Resources.CustomTextName, Properties.Resources.CustomTextName, -1));
            cbName.EditValue = "Notes";
        }

        //<ceAuto>
        private void ceAuto_CheckedChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.CheckEdit checkEdit = sender as DevExpress.XtraEditors.CheckEdit;
            gridView1.OptionsView.AutoCalcPreviewLineCount = checkEdit.Checked;
        }
        //</ceAuto>

        //<ceCustom>
        private void ceCustom_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.Invalidate();
        }

        private void gridView1_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            if(ceCustom.Checked) {
                int dx = 5;
                Rectangle r = e.Bounds;
                r.X += e.Bounds.Height + dx * 2;
                r.Width -= (e.Bounds.Height + dx * 3);
                e.Cache.DrawImage((Image)gridView1.GetDataRow(e.RowHandle)["Photo"],
                    e.Bounds.X + dx, e.Bounds.Y, (int)(e.Bounds.Height / 1.2), e.Bounds.Height);
                e.Appearance.DrawString(e.Cache, gridView1.GetRowPreviewDisplayText(e.RowHandle), r);
                e.Handled = true;
            }
        }
        //</ceCustom>

        //<cbName>
        private void cbName_SelectedIndexChanged(object sender, System.EventArgs e) {
            DevExpress.XtraEditors.ImageComboBoxEdit comboBox = sender as DevExpress.XtraEditors.ImageComboBoxEdit;
            if(comboBox.EditValue.ToString().IndexOf("----") >= 0)
                comboBox.SelectedIndex = comboBox.Properties.Items.Count - 1;
            else
                gridView1.PreviewFieldName = comboBox.EditValue.ToString();
        }

        private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            if(cbName.SelectedIndex >= cbName.Properties.Items.Count - 1) {
                DataRow row = gridView1.GetDataRow(e.RowHandle);
                e.PreviewText = string.Format("{0} {1}\r\n{2}", row["FirstName"], row["LastName"], row["Title"]);
            }
        }
        //</cbName>


        //<ceUseMeasurePreviewHeight>
        private void ceUseMeasurePreviewHeight_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.LayoutChanged();
            ceAuto.Enabled = !ceUseMeasurePreviewHeight.Checked;
        }

        private void gridView1_MeasurePreviewHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e) {
            if(ceUseMeasurePreviewHeight.Checked)
                e.RowHeight = 80;
        }
        //</ceUseMeasurePreviewHeight>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
