using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class frmProduct : XtraForm {
        public frmProduct() {
            InitializeComponent();
        }
        public string NewProductName { get { return teProductName.Text; } }
        public int CategoryID { get { return (int)icbCategory.EditValue; } }
        public string QuantityPerUnit { get { return teQuantityPerUnit.Text; } }
        public decimal UnitPrice { get { return seUnitPrice.Value; } }
        public bool Discontinued { get { return ceDiscontinued.Checked; } }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !dxValidationProvider1.Validate() && DialogResult == DialogResult.OK;
        }
    }
}
