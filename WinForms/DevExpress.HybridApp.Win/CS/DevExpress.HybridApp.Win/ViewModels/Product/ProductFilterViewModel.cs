using System;
using DevExpress.DevAV.Properties;

namespace DevExpress.DevAV.ViewModels {
    public class ProductFilterViewModel : FilterViewModel<Product, ProductInfoWithSales> {
        public ProductFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, x => x.ProductStaticFilters, x => x.ProductCustomFilters),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<Product, long>)) {
        }
    }
}
