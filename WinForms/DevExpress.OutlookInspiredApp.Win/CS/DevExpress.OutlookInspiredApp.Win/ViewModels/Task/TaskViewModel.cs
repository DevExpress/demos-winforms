using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm.DataModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    /// <summary>
    /// Represents the single Gant object view model.
    /// </summary>
    public partial class TaskViewModel : SingleObjectViewModel<EmployeeTask, long, IDevAVDbUnitOfWork> {
        /// <summary>
        /// Creates a new instance of GantViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TaskViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TaskViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GantViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GantViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TaskViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Tasks, x => x.Id) {
        }

        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((TaskViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }
    }
}
