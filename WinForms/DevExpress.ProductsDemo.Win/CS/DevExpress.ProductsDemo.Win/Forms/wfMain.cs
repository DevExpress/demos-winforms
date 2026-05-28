using DevExpress.XtraWaitForm;

namespace DevExpress.ProductsDemo.Win.Forms {
    public partial class wfMain : DemoWaitForm {
        public wfMain() {
            InitializeComponent();
            ProgressPanel.Caption = DevExpress.ProductsDemo.Win.Properties.Resources.ProgressPanelCaption;
            ProgressPanel.Description = DevExpress.ProductsDemo.Win.Properties.Resources.ProgressPanelDescription;
        }
    }
}
