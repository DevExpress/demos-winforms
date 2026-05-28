using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraEditors.Demos {
    /// <summary>
    /// Summary description for MultiEditors.
    /// </summary>
    public partial class MultiEditors : TutorialControl {
        public MultiEditors() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            //TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MultiEditors.cs";
            //TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.MultiEditors.xml";
            gridControl1.ForceInitialize();
            InitData();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        #region Init

        private byte[] ImageToByteArray(Image image) {
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ret = mStream.ToArray();
            mStream.Close();
            return ret;
        }
        private void InitData() {
            RecordOrder[] records = new RecordOrder[10];
            records[0] = new RecordOrder(Properties.Resources.ProductName, "Mishi Kobe Niku", "Teatime Chocolate Biscuits", "Ipoh Coffee");
            records[1] = new RecordOrder(Properties.Resources.Category, 6, 3, 1);
            records[2] = new RecordOrder(Properties.Resources.Supplier, "Tokyo Traders", "Specialty Biscuits, Ltd.", "Leka Trading");
            records[3] = new RecordOrder(Properties.Resources.QuantityPerUnit, "18 - 500 g pkgs.", "10 boxes x 12 pieces", "16 - 500 g tins");
            records[4] = new RecordOrder(Properties.Resources.UnitPrice, 97.00, 9.20, 46.00);
            records[5] = new RecordOrder(Properties.Resources.UnitsInStock, 29, 25, 17);
            records[6] = new RecordOrder(Properties.Resources.Discontinued, false, true, true);
            records[7] = new RecordOrder(Properties.Resources.LastOrder, new DateTime(2001, 12, 14), new DateTime(2003, 7, 20), new DateTime(2002, 1, 7));
            records[8] = new RecordOrder(Properties.Resources.Picture, Properties.Resources.product1, Properties.Resources.product2, Properties.Resources.product3);
            records[9] = new RecordOrder(Properties.Resources.Relevance, 70, 90, 50);

            gridControl1.DataSource = records;
        }
        #endregion
        #region Grid events
        //<gridControl1>
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if (e.Column.FieldName != "Category") {
                RecordOrder rec = gridView1.GetRow(e.RowHandle) as RecordOrder;
                if (rec.Category == Properties.Resources.Category) e.RepositoryItem = repositoryItemImageComboBox1;
                if (rec.Category == Properties.Resources.Supplier) e.RepositoryItem = repositoryItemComboBox1;
                if (rec.Category == Properties.Resources.UnitPrice) e.RepositoryItem = repositoryItemCalcEdit1;
                if (rec.Category == Properties.Resources.UnitsInStock) e.RepositoryItem = repositoryItemSpinEdit1;
                if (rec.Category == Properties.Resources.Discontinued) e.RepositoryItem = repositoryItemCheckEdit1;
                if (rec.Category == Properties.Resources.Discontinued) e.RepositoryItem = repositoryItemCheckEdit1;
                if (rec.Category == Properties.Resources.LastOrder) e.RepositoryItem = repositoryItemDateEdit1;
                if (rec.Category == Properties.Resources.Picture) e.RepositoryItem = repositoryItemPictureEdit1;
                if (rec.Category == Properties.Resources.Relevance) e.RepositoryItem = repositoryItemProgressBar1;
            }
        }
        //</gridControl1>

        private void gridView1_RowCellDefaultAlignment(object sender, DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs e) {
            if (e.Column.FieldName != "Category") {
                if (e.RowHandle == 4 || e.RowHandle == 5)
                    e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far;
                if (e.RowHandle == 9)
                    e.HorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        //<gridControl1>
        /* 
         ~Set custom height for row 8:
         */
        private void gridView1_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e) {
            if (e.RowHandle == 8) e.RowHeight = 150;
        }
        //</gridControl1>

        #endregion
        #region RepositoryItems events
        private void repositoryItemProgressBar1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            int i = 0;
            if (gridView1.ActiveEditor == null) return;

            if (e.KeyChar == '+') {
                i = (int)gridView1.ActiveEditor.EditValue;
                if (i < 100)
                    gridView1.ActiveEditor.EditValue = i + 1;
            }
            if (e.KeyChar == '-') {
                i = (int)gridView1.ActiveEditor.EditValue;
                if (i > 0)
                    gridView1.ActiveEditor.EditValue = i - 1;
            }
        }
        #endregion
    }
}
