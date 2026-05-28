using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Internal;

namespace DevExpress.Xpo.Demos {
    public partial class XPViewDemo : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        public XPViewDemo() {
            InitializeComponent();
            CreateConnectionString();
        }

        private void XPViewDemo_Load(object sender, System.EventArgs e) {
            cbViews.SelectedIndex = 0;
        }

        //<cbViews>
        void CreateConnectionString() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.mdb");
            if(DBFileName != "")
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;

            // A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
        }

        private void cbViews_SelectedIndexChanged(object sender, System.EventArgs e) {
            groupControl1.Text = cbViews.Text;
            switch(cbViews.SelectedIndex) {
                case 0:
                    gridControl1.DataSource = xpviewProducts;
                    break;
                case 1:
                    gridControl1.DataSource = xpviewSuppliersProduct;
                    break;
                case 2:
                    gridControl1.DataSource = xpviewOrders;
                    break;
            }
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
        }
        //</cbViews>
    }
}
