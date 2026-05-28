namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class CustomersFilterPane : BaseModuleControl, ISupportCompactLayout {
        CustomerFilterAccordionPresenter accordionPresenterCore;
        public CustomersFilterPane(CustomerCollectionViewModel collectionViewModel)
            : base(typeof(CustomersFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreateAccordionPresenter();
            BindCommands();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public CustomersFilterTreeViewModel ViewModel {
            get { return GetViewModel<CustomersFilterTreeViewModel>(); }
        }
        public CustomerFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual CustomerFilterAccordionPresenter CreateAccordionPresenter() {
            return new CustomerFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.CustomersCustomFilter));
            mvvmContext.RegisterService("Group Filter", new FilterDialogDocumentManagerService(ModuleType.CustomersGroupFilter));
        }
        protected virtual void BindCommands() {
            btnNewCustomer.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNavigationContainer.Visible = !compactLayout;
        }
        #endregion
    }
}
