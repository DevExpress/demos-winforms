namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Common.Utils;
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraLayout.Utils;

    public partial class QuotesFilterPane : BaseModuleControl, ISupportCompactLayout {
        QuoteFilterAccordionPresenter accordionPresenterCore;
        public QuotesFilterPane(QuoteCollectionViewModel collectionViewModel)
            : base(typeof(QuotesFilterTreeViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            this.accordionPresenterCore = CreatePresenter();
            BindCommands();
            FluentIconHelper.SwapFluentIcons(this);
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            base.OnDisposing();
        }
        public QuotesFilterTreeViewModel ViewModel {
            get { return GetViewModel<QuotesFilterTreeViewModel>(); }
        }
        public QuoteFilterAccordionPresenter Presenter {
            get { return accordionPresenterCore; }
        }
        protected virtual QuoteFilterAccordionPresenter CreatePresenter() {
            return new QuoteFilterAccordionPresenter(accordionControl, ViewModel);
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService("Custom Filter", new FilterDialogDocumentManagerService(ModuleType.QuotesCustomFilter));
        }
        protected virtual void BindCommands() {
            btnNewQuote.BindCommand(() => Presenter.CollectionViewModel.New(), Presenter.CollectionViewModel);
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
            btnNewQuote.Visible = !compactLayout;
        }
        #endregion
    }
}
