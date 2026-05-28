using DevExpress.VideoRent.Reports;
namespace DevExpress.VideoRent.Win.ModulesReports {
    public partial class CustomerInfoCard : ReportModuleBase {
        public CustomerInfoCard() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new CustomerInfoCardReport();
        }
    }
}
