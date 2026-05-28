using DevExpress.XtraWaitForm;

namespace DevExpress.MailClient.Win.Forms {
    public partial class wfMain : DemoWaitForm {
        public wfMain() {
            InitializeComponent();
            ProgressPanel.Caption = DevExpress.MailClient.Win.Properties.Resources.ProgressPanelCaption;
            ProgressPanel.Description = DevExpress.MailClient.Win.Properties.Resources.ProgressPanelDescription;
        }
    }
}
