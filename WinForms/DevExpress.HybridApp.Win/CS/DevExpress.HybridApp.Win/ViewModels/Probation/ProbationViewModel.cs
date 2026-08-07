using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Probation object view model.
    /// </summary>
    public partial class ProbationViewModel : SingleObjectViewModel<Probation, long, IDevAVDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProbationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProbationViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProbationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProbationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProbationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProbationViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Probations, x => x.Reason) {
        }
    }
}
