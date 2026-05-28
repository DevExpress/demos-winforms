using DevExpress.DevAV.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.ViewModels {
    public class EmployeeTaskFilterViewModel : FilterViewModel<EmployeeTask> {
        public EmployeeTaskFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, x => x.EmployeeTaskStaticFilters, null),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<EmployeeTask, long>)) {
        }
    }
}
