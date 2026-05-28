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
    /// Represents the single CustomerCommunication object view model.
    /// </summary>
    public partial class CustomerCommunicationViewModel : SingleObjectViewModel<CustomerCommunication, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CustomerCommunicationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerCommunicationViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CustomerCommunicationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerCommunicationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerCommunicationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerCommunicationViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Communications, x => x.Type)
        {
        }

        /// <summary>
        /// The view model that contains a look-up collection of CustomerEmployees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CustomerEmployee> LookUpCustomerEmployees
        {
            get { return GetLookUpEntitiesViewModel((CustomerCommunicationViewModel x) => x.LookUpCustomerEmployees, x => x.CustomerEmployees); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees
        {
            get { return GetLookUpEntitiesViewModel((CustomerCommunicationViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }
    }
}
