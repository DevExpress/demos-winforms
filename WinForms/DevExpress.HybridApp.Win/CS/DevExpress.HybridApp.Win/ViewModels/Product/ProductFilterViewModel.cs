using DevExpress.DevAV.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.ViewModels {
    public class ProductFilterViewModel : FilterViewModel<Product, ProductInfoWithSales> {
        public ProductFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, x => x.ProductStaticFilters, x => x.ProductCustomFilters),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<Product, long>)) {
        }
    }
}
