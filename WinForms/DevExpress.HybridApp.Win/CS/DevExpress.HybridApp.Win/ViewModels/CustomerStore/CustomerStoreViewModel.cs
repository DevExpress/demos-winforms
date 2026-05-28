using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;

namespace DevExpress.DevAV.ViewModels
{
    /// <summary>
    /// Represents the single CustomerStore object view model.
    /// </summary>
    public partial class CustomerStoreViewModel : SingleObjectViewModel<CustomerStore, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CustomerStoreViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerStoreViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CustomerStoreViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerStoreViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerStoreViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerStoreViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomerStores, x => x.CustomerName)
        {
        }

        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers
        {
            get { return GetLookUpEntitiesViewModel((CustomerStoreViewModel x) => x.LookUpCustomers, x => x.Customers); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Crests for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Crest> LookUpCrests
        {
            get { return GetLookUpEntitiesViewModel((CustomerStoreViewModel x) => x.LookUpCrests, x => x.Crests); }
        }
    }
}
