using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Picture object view model.
    /// </summary>
    public partial class PictureViewModel : SingleObjectViewModel<Picture, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PictureViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PictureViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PictureViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PictureViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PictureViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PictureViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Pictures, x => x.Id) {
        }
    }
}
