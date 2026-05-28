using DevExpress.Internal;

namespace DevExpress.XtraGauges.Demos {
    public partial class Databinding : TutorialControl {
        public Databinding() {
            InitializeComponent();
            InitData();
        }
        protected void InitData() {
            string dbFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                SetWaitDialogCaption("Loading Products...");
                var ds = new System.Data.DataSet();
                ds.ReadXml(dbFileName);
                // datasource for runtime
                productsBindingSource.DataSource = ds.Tables["Products"];
            }
        }
    }
}
