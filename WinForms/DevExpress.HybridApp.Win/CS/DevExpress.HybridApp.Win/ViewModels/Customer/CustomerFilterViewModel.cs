using System;
using DevExpress.DevAV.Properties;

namespace DevExpress.DevAV.ViewModels {
    public class CustomerFilterViewModel : FilterViewModel<Customer, CustomerInfoWithSales> {
        public CustomerFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, null, x => x.CustomerCustomFilters),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<Customer, long>)) {
        }
    }
}
