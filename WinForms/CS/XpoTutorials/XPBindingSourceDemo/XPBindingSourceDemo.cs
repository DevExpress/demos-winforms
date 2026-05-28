using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using DevExpress.Internal;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class XPBindingSourceDemo : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        public XPBindingSourceDemo() {
            InitializeComponent();
            CreateConnectionString();
        }

        private void XPBindingSourceDemo_Load(object sender, System.EventArgs e) {
            cbDataSource.SelectedIndex = 0;
        }

        //<cbDataSource>
        void CreateConnectionString() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.mdb");
            if(DBFileName != "")
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;

            // A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
        }

        private void cbDataSource_SelectedIndexChanged(object sender, System.EventArgs e) {
            groupControl1.Text = cbDataSource.Text;
            switch(cbDataSource.SelectedIndex) {
                case 0:
                    xpBindingSource1.DataSource = xpCollection1;
                    break;
                case 1:
                    List<Customers> listOfObjects = session1.Query<Customers>().ToList();
                    xpBindingSource1.DataSource = listOfObjects;
                    break;
                case 2:
                    Customers singleObject = session1.Query<Customers>().First();
                    xpBindingSource1.DataSource = singleObject;
                    break;
                case 3:
                    xpBindingSource1.DataSource = null;
                    xpBindingSource1.ObjectClassInfo = session1.GetClassInfo(typeof(Customers));
                    break;
            }
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
        }
        //</cbDataSource>
    }
}
