namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucRegions : BaseModule {
        public ucRegions() {
            InitializeComponent();
            InitializeData();
        }
        void InitializeData() {
            Model.IDataProvider dataProvider = Model.DataSource.GetDataProvider();
            dailySalesByRegion.SetSalesPerformanceProvider(new DailySalesByRegion(dataProvider));
            unitSalesByRegion.SetSalesPerformanceProvider(new UnitSalesByRegion(dataProvider));
            ucSalesByRange.SetSalesByRangeProvider(new RegionSalesByRange(dataProvider));
        }
    }
}
