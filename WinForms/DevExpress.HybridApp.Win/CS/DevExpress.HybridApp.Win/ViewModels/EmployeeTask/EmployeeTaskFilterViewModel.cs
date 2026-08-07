using System;
using DevExpress.DevAV.Properties;

namespace DevExpress.DevAV.ViewModels {
    public class EmployeeTaskFilterViewModel : FilterViewModel<EmployeeTask> {
        public EmployeeTaskFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, x => x.EmployeeTaskStaticFilters, null),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<EmployeeTask, long>)) {
        }
    }
}
