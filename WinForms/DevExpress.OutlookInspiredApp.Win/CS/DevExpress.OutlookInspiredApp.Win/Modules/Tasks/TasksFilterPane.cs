namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class TasksFilterPane : BaseModuleControl, ISupportCompactLayout {
        TaskFilterAccordionPresenter accordionPresenterCore;
        public TasksFilterPane(TaskCollectionViewModel collectionViewModel)
            : base(typeof(TasksFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreatePresenter();
            BindCommands();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public TasksFilterTreeViewModel ViewModel {
            get { return GetViewModel<TasksFilterTreeViewModel>(); }
        }
        public TaskFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual TaskFilterAccordionPresenter CreatePresenter() {
            return new TaskFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.TasksCustomFilter));
            mvvmContext.RegisterService("Group Filter", new FilterDialogDocumentManagerService(ModuleType.TasksGroupFilter));
        }
        protected virtual void BindCommands() {
            btnNewTask.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
        }
        #region ISupportCompactLayout Members
        bool compactLayout = true;
        bool ISupportCompactLayout.Compact {
            get { return compactLayout; }
            set {
                if(compactLayout == value) return;
                compactLayout = value;
                UpdateCompactLayout();
            }
        }
        void UpdateCompactLayout() {
            btnNewTaskLayoutControlItem.Visibility = compactLayout ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
        #endregion
    }
}
