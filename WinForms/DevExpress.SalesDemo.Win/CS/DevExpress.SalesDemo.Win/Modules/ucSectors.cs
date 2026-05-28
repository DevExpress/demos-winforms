namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucSectors : BaseModule {
        public ucSectors() {
            InitializeComponent();
            InitializeData();
        }
        void InitializeData() {
            Model.IDataProvider dataProvider = Model.DataSource.GetDataProvider();
            dailySalesBySector.SetSalesPerformanceProvider(new DailySalesBySector(dataProvider));
            unitSalesBySector.SetSalesPerformanceProvider(new UnitSalesBySector(dataProvider));
            ucSalesByRange.SetSalesByRangeProvider(new SectorSalesByRange(dataProvider));
        }
    }
}
