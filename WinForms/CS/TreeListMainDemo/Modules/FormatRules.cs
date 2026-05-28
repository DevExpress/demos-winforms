using System;

namespace DevExpress.XtraTreeList.Demos {
    public partial class FormatRules : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public FormatRules() {
            InitializeComponent();
            treeList1.DataSource = SalesDataGenerator.CreateData();
            treeList1.ExpandAll();
        }
        void treeList1_Load(object sender, EventArgs e) {
            treeList1.BestFitColumns();
        }
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
    }
}
