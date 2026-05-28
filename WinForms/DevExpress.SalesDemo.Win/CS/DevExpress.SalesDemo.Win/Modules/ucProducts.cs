namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucProducts : BaseModule {
        public ucProducts() {
            InitializeComponent();
            InitializeData();
        }
        void InitializeData() {
            Model.IDataProvider dataProvider = Model.DataSource.GetDataProvider();
            dailySalesByProduct.SetSalesPerformanceProvider(new DailySalesByProduct(dataProvider));
            unitSalesByProduct.SetSalesPerformanceProvider(new UnitSalesByProduct(dataProvider));
            ucSalesByRange.SetSalesByRangeProvider(new ProductsSalesByRange(dataProvider));
        }
    }
}
