using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single CustomerEmployee object view model.
    /// </summary>
    public partial class CustomerEmployeeViewModel : SingleObjectViewModel<CustomerEmployee, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerEmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerEmployeeViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerEmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerEmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerEmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerEmployeeViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomerEmployees, x => x.FullName) {
        }

        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get { return GetLookUpEntitiesViewModel((CustomerEmployeeViewModel x) => x.LookUpCustomers, x => x.Customers); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of CustomerStores for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerStore> LookUpCustomerStores {
            get { return GetLookUpEntitiesViewModel((CustomerEmployeeViewModel x) => x.LookUpCustomerStores, x => x.CustomerStores); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Pictures for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Picture> LookUpPictures {
            get { return GetLookUpEntitiesViewModel((CustomerEmployeeViewModel x) => x.LookUpPictures, x => x.Pictures); }
        }
    }
}
