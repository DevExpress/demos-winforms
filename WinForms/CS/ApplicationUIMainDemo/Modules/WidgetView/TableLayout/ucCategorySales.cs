using System;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucCategorySales : XtraEditors.XtraUserControl {
        public ucCategorySales() {
            InitializeComponent();
            SalesPerformanceDataGenerator.Current.UpdateDataSource += OnUpdateDataSource;
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                if(SalesPerformanceDataGenerator.IsCurrentDataGeneratorExist)
                    SalesPerformanceDataGenerator.Current.UpdateDataSource -= OnUpdateDataSource;
            }
            base.Dispose(disposing);
        }
        void OnUpdateDataSource(object sender, EventArgs e) {
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
    }
}
