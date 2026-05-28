namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class ProductsFilterPane : BaseModuleControl, ISupportCompactLayout {
        ProductFilterAccordionPresenter accordionPresenterCore;
        public ProductsFilterPane(ProductCollectionViewModel collectionViewModel)
            : base(typeof(ProductsFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreatePresenter();
            BindCommands();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public ProductsFilterTreeViewModel ViewModel {
            get { return GetViewModel<ProductsFilterTreeViewModel>(); }
        }
        public ProductFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual ProductFilterAccordionPresenter CreatePresenter() {
            return new ProductFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.ProductsCustomFilter));
            mvvmContext.RegisterService("Group Filter", new FilterDialogDocumentManagerService(ModuleType.ProductsGroupFilter));
        }
        protected virtual void BindCommands() {
            btnNewProduct.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNewProduct.Visible = !compactLayout;
        }
        #endregion
    }
}
