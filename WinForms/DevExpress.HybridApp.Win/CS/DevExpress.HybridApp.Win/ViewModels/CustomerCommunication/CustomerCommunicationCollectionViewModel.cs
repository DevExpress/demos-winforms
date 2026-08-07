using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the Communications collection view model.
    /// </summary>
    public partial class CustomerCommunicationCollectionViewModel : CollectionViewModel<CustomerCommunication, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerCommunicationCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerCommunicationCollectionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerCommunicationCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerCommunicationCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerCommunicationCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerCommunicationCollectionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Communications) {
        }
    }
}
