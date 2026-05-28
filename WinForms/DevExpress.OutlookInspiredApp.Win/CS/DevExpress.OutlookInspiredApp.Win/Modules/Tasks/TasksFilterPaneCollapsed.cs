namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class TasksFilterPaneCollapsed : BaseModuleControl, ISupportCompactLayout {
        TasksFilterPanePresenter presenterCore;
        public TasksFilterPaneCollapsed(TaskCollectionViewModel collectionViewModel)
            : base(typeof(TasksFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            presenterCore = CreatePresenter();
            BindCommands();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public TasksFilterTreeViewModel ViewModel {
            get { return GetViewModel<TasksFilterTreeViewModel>(); }
        }
        public TasksFilterPanePresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual TasksFilterPanePresenter CreatePresenter() {
            return new TasksFilterPanePresenter(navigationBar, ViewModel);
        }
        protected virtual void BindCommands() {
            btnNew.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNewLayoutControlItem.Visibility = compactLayout ? LayoutVisibility.Never : LayoutVisibility.Always;
        }
        #endregion
    }
}
