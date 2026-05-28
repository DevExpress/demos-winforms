using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.POCO;
using System.Linq;

namespace DevExpress.DevAV.ViewModels {
    public partial class TaskCollectionViewModel : CollectionViewModel<EmployeeTask, long, IDevAVDbUnitOfWork> {
        /// <summary>
        /// Creates a new instance of GanttCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TaskCollectionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TaskCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GanttCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GanttCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TaskCollectionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Tasks, q => q.OrderBy(t => t.StartDate)) {
        }
    }
}
