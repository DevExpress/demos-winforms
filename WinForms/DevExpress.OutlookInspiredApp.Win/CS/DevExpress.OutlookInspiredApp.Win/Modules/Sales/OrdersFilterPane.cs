namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class OrdersFilterPane : BaseModuleControl, ISupportCompactLayout {
        OrderFilterAccordionPresenter accordionPresenterCore;
        public OrdersFilterPane(OrderCollectionViewModel collectionViewModel)
            : base(typeof(OrdersFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreatePresenter();
            BindCommands();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public OrdersFilterTreeViewModel ViewModel {
            get { return GetViewModel<OrdersFilterTreeViewModel>(); }
        }
        public OrderFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual OrderFilterAccordionPresenter CreatePresenter() {
            return new OrderFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.OrdersCustomFilter));
        }
        protected virtual void BindCommands() {
            btnNewOrder.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNewOrder.Visible = !compactLayout;
        }
        #endregion
    }
}
