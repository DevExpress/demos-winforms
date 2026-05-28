namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class OrdersFilterPaneCollapsed : BaseModuleControl, ISupportCompactLayout {
        OrderFilterPanePresenter presenterCore;
        public OrdersFilterPaneCollapsed(OrderCollectionViewModel collectionViewModel)
            : base(typeof(OrdersFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            presenterCore = CreatePresenter();
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
        public OrderFilterPanePresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual OrderFilterPanePresenter CreatePresenter() {
            return new OrderFilterPanePresenter(navigationBar, ViewModel);
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
            btnNew.Visible = !compactLayout;
        }
        #endregion
    }
}
