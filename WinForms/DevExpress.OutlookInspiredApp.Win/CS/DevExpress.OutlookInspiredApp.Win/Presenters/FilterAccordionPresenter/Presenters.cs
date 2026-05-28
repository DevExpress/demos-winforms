namespace DevExpress.DevAV.Presenters {
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Navigation;

    public class EmployeeFilterAccordionPresenter : FilterAccordionPresenter<DevAV.Employee, long, IDevAVDbUnitOfWork> {
        public EmployeeFilterAccordionPresenter(AccordionControl accordionControl, EmployeesFilterTreeViewModel viewModel)
            : base(accordionControl, viewModel) {
        }
        public new EmployeeCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as EmployeeCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup += CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection += CollectionViewModel_CustomGroupFromSelection;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup -= CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection -= CollectionViewModel_CustomGroupFromSelection;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }
    
    public class CustomerFilterAccordionPresenter : FilterAccordionPresenter<DevAV.Customer, long, IDevAVDbUnitOfWork> {
        public CustomerFilterAccordionPresenter(AccordionControl accordion, CustomersFilterTreeViewModel viewModel)
            : base(accordion, viewModel) {
        }
        public new CustomerCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as CustomerCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup += CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection += CollectionViewModel_CustomGroupFromSelection;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup -= CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection -= CollectionViewModel_CustomGroupFromSelection;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }
    
    public class ProductFilterAccordionPresenter : FilterAccordionPresenter<DevAV.Product, long, IDevAVDbUnitOfWork> {
        public ProductFilterAccordionPresenter(AccordionControl accordion, ProductsFilterTreeViewModel viewModel)
            : base(accordion, viewModel) {
        }
        public new ProductCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as ProductCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup += CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection += CollectionViewModel_CustomGroupFromSelection;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup -= CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection -= CollectionViewModel_CustomGroupFromSelection;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }
    
    public class OrderFilterAccordionPresenter : FilterAccordionPresenter<DevAV.Order, long, IDevAVDbUnitOfWork> {
        public OrderFilterAccordionPresenter(AccordionControl accordion, OrdersFilterTreeViewModel viewModel)
            : base(accordion, viewModel) {
        }
        public new OrderCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as OrderCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }
    
    public class QuoteFilterAccordionPresenter : FilterAccordionPresenter<DevAV.Quote, long, IDevAVDbUnitOfWork> {
        public QuoteFilterAccordionPresenter(AccordionControl accordion, QuotesFilterTreeViewModel viewModel)
            : base(accordion, viewModel) {
        }
        public new QuoteCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as QuoteCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }

    public class TaskFilterAccordionPresenter : FilterAccordionPresenter<EmployeeTask, long, IDevAVDbUnitOfWork> {
        public TaskFilterAccordionPresenter(AccordionControl accordion, TasksFilterTreeViewModel viewModel)
            : base(accordion, viewModel) {
        }
        public new TaskCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as TaskCollectionViewModel; }
        }
        protected override void SubscribeCollectionViewModelEvents() {
            base.SubscribeCollectionViewModelEvents();
            CollectionViewModel.CustomFilter += CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup += CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection += CollectionViewModel_CustomGroupFromSelection;
        }
        protected override void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.CustomFilter -= CollectionViewModel_CustomFilter;
            CollectionViewModel.CustomGroup -= CollectionViewModel_CustomGroup;
            CollectionViewModel.CustomGroupFromSelection -= CollectionViewModel_CustomGroupFromSelection;
            base.UnsubscribeCollectionViewModelEvents();
        }
    }
}
