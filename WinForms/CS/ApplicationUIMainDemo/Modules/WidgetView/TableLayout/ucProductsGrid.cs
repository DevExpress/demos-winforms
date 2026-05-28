using System;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucProductsGrid : XtraEditors.XtraUserControl {
        public ucProductsGrid() {
            InitializeComponent();
            SalesPerformanceDataGenerator.Current.UpdateDataSource += OnUpdateDataSource;
            if(SalesPerformanceDataGenerator.Current.FilterTotalSales.Any())
                totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales;
        }
        void OnUpdateDataSource(object sender, EventArgs e) {
            if(SalesPerformanceDataGenerator.Current.FilterTotalSales.Any())
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
    }
    public class ucProductsBorderlessGrid : ucProductsGrid {
        public ucProductsBorderlessGrid() : base() {
            gridView1.BorderStyle = XtraEditors.Controls.BorderStyles.Default;
        }
    }
}

