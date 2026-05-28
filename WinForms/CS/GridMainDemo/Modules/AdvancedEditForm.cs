using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class AdvancedEditForm : EditFormUserControl {
        public AdvancedEditForm() {
            InitializeComponent();
        }
        public void InitData(DataSet ds) {
            string tblCategory = "Category", tblTrademark = "Trademark", tblBodyStyle = "BodyStyle", tblTransmissionType = "TransmissionType";
            lookUpEdit1.Properties.DataSource = ds.Tables[tblCategory];
            lookUpEdit1.Properties.DropDownRows = ds.Tables[tblCategory].Rows.Count;
            lookUpEdit2.Properties.DataSource = ds.Tables[tblBodyStyle];
            lookUpEdit2.Properties.DropDownRows = ds.Tables[tblBodyStyle].Rows.Count;
            lookUpEdit3.Properties.DataSource = ds.Tables[tblTransmissionType];
            lookUpEdit3.Properties.DropDownRows = ds.Tables[tblTransmissionType].Rows.Count;
            gridLookUpEdit1.Properties.DataSource = ds.Tables[tblTrademark];
            ((RepositoryItemGridLookUpEditWithGlyph)gridLookUpEdit1.Properties).GetImageByValueEvent += new DevExpress.XtraGrid.Demos.ImageByValueEventHandler(repositoryItemGridLookUpEdit1_GetImageByValue);
        }
        protected override void SetMenuManager(Utils.Menu.IDXMenuManager menuManager) {
            base.SetMenuManager(menuManager);
            foreach(Control ctrl in layoutControl1.Controls) {
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) edit.MenuManager = menuManager;
            }
        }
        void repositoryItemGridLookUpEdit1_GetImageByValue(object sender, ImageByValueEventArgs e) {
            DataHelper.LogoGridLookupGetImageByValue(sender, e);
        }
    }
}
