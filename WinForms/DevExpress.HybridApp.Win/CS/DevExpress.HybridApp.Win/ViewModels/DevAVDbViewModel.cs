using System;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the DevAVDb data model.
    /// </summary>
    public partial class DevAVDbViewModel : DocumentsViewModel<DevAVDbModuleDescription, IDevAVDbUnitOfWork> {
        const string MyWorldGroup = "My World";
        const string OperationsGroup = "Operations";
        /// <summary>
        /// Creates a new instance of DevAVDbViewModel as a POCO view model.
        /// </summary>
        public static DevAVDbViewModel Create() {
            return ViewModelSource.Create(() => new DevAVDbViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the DevAVDbViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DevAVDbViewModel type without the POCO proxy factory.
        /// </summary>
        protected DevAVDbViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override DevAVDbModuleDescription[] CreateModules() {
            DevAVDbModuleDescription[] modules = new DevAVDbModuleDescription[] {
                new DevAVDbModuleDescription("Dashboard", DashboardViewDocumentType, MyWorldGroup, (FilterViewModelBase)null),
                new DevAVDbModuleDescription("Tasks", DevAVDbViewModel.EmployeeTaskCollectionViewDocumentType, MyWorldGroup, FiltersSettings.GetTaskFilter(this)),
                new DevAVDbModuleDescription("Employees", DevAVDbViewModel.EmployeeCollectionViewDocumentType, MyWorldGroup, FiltersSettings.GetEmployeeFilter(this)),
                new DevAVDbModuleDescription("Products", DevAVDbViewModel.ProductCollectionViewDocumentType, OperationsGroup, FiltersSettings.GetProductFilter(this)),
                new DevAVDbModuleDescription("Customers", CustomerCollectionViewDocumentType, OperationsGroup, FiltersSettings.GetCustomerFilter(this)),
                new DevAVDbModuleDescription("Sales", DevAVDbViewModel.OrderCollectionViewDocumentType, OperationsGroup, (FilterViewModelBase)null),
                new DevAVDbModuleDescription("Opportunities", DevAVDbViewModel.QuoteCollectionViewDocumentType, OperationsGroup, (FilterViewModelBase)null),
            };
            foreach(var module in modules) {
                if(module.FilterViewModel == null)
                    continue;
                DevAVDbModuleDescription moduleRef = module;
                module.FilterViewModel.NavigateAction = (() => {
                    if(ActiveModule != moduleRef)
                        Show(moduleRef);
                });
            }
            return modules;
        }
    }

    public partial class DevAVDbModuleDescription : ModuleDescription<DevAVDbModuleDescription> {
        public DevAVDbModuleDescription(string title, string documentType, string group, Func<DevAVDbModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }

        public DevAVDbModuleDescription(string title, string documentType, string group, FilterViewModelBase filterViewModel)
            : base(title, documentType, group) {
            FilterViewModel = filterViewModel;
        }

        public FilterViewModelBase FilterViewModel { get; private set; }
    }
}
