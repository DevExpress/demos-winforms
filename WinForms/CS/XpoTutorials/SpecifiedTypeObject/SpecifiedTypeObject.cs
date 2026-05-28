using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;

namespace DevExpress.Xpo.Demos {
    public partial class SpecifiedTypeObject : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }
        public static IDisposable[] objectsToDispose;
        IDataLayer currentDataLayer;
        XPCollection xpCollection;

        public SpecifiedTypeObject() {
            InitializeComponent();
            currentDataLayer = ObjectHelper.CreateDataLayer();
            session1.Connect(currentDataLayer);
            xpCollection = new XPCollection(session1, typeof(Worker));
            cbViews.SelectedIndex = 0;
        }

        //<cbViews>
        private void cbViews_SelectedIndexChanged(object sender, System.EventArgs e) {
            groupControl1.Text = cbViews.Text;
            switch(cbViews.SelectedIndex) {
                case 0:
                    xpCollection.Criteria = null;
                    break;
                case 1:
                    xpCollection.Criteria = CriteriaOperator.Parse("IsExactType(This,'Evangelist')", null);
                    break;
                case 2:
                    xpCollection.Criteria = CriteriaOperator.Parse("IsInstanceOfType(This,'Manager')", null);
                    break;
                case 3:
                    xpCollection.Criteria = CriteriaOperator.Parse("IsInstanceOfType(This,'ProductManager')", null);
                    break;
                case 4:
                    xpCollection.Criteria = CriteriaOperator.Parse("IsExactType(This,'Manager')", null);
                    break;
            }
            xpCollection.Reload();
            gridControl1.DataSource = xpCollection;
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
        }
        //</cbViews>
    }
}
