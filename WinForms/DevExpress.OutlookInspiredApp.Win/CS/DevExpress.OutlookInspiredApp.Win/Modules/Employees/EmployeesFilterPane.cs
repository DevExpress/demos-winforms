namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class EmployeesFilterPane : BaseModuleControl, ISupportCompactLayout {
        EmployeeFilterAccordionPresenter accordionPresenterCore;
        public EmployeesFilterPane(EmployeeCollectionViewModel collectionViewModel)
            : base(typeof(EmployeesFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreateAccordionPresenter();
            BindCommands();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public EmployeesFilterTreeViewModel ViewModel {
            get { return GetViewModel<EmployeesFilterTreeViewModel>(); }
        }
        public EmployeeFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual EmployeeFilterAccordionPresenter CreateAccordionPresenter() {
            return new EmployeeFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.EmployeesCustomFilter));
            mvvmContext.RegisterService("Group Filter", new FilterDialogDocumentManagerService(ModuleType.EmployeesGroupFilter));
        }
        protected virtual void BindCommands() {
            btnNewEmployee.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNewEmployee.Visible = !compactLayout;
        }
        #endregion
    }
}
