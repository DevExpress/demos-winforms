using DevExpress.VideoRent.Reports;
namespace DevExpress.VideoRent.Win.ModulesReports {
    public partial class TheMostProfitableGenresList : ReportModuleBase {
        public TheMostProfitableGenresList() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new TheMostProfitableGenresListReport();
        }
    }
}
