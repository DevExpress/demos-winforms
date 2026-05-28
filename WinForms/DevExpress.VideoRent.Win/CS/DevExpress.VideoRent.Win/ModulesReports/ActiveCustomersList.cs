using DevExpress.VideoRent.Reports;
namespace DevExpress.VideoRent.Win.ModulesReports {
    public partial class ActiveCustomersList : ReportModuleBase {
        public ActiveCustomersList() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new ActiveCustomersListReport();
        }
    }
}
