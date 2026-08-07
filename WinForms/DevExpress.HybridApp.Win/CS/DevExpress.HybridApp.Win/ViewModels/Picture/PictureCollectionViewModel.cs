using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the Pictures collection view model.
    /// </summary>
    public partial class PictureCollectionViewModel : CollectionViewModel<Picture, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PictureCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PictureCollectionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PictureCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PictureCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PictureCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PictureCollectionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Pictures) {
        }
    }
}
