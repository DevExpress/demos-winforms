using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.DevAV.Properties;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {

    public class TasksFilterTreeViewModel : FilterTreeViewModel<EmployeeTask, long, IDevAVDbUnitOfWork> {
        public static TasksFilterTreeViewModel Create(TaskCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new TasksFilterTreeViewModel(collectionViewModel));
        }
        protected TasksFilterTreeViewModel(TaskCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.TasksStaticFilters, x => x.TasksCustomFilters, x => x.TasksGroupFilters)) {
        }
        protected new TaskCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as TaskCollectionViewModel; }
        }
    }
}
