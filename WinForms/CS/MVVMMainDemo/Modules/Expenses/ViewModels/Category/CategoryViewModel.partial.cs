using DevExpress.MVVM.Demos.Common.ViewModel;
using DevExpress.MVVM.Demos.ExpensesDbContextDataModel;
using DevExpress.MVVM.Demos.Model;

namespace DevExpress.MVVM.Demos.ViewModels {
    public partial class CategoryViewModel {
        //The bindable property that returns all transactions of the current category
        public CollectionViewModel<Transaction, long, IExpensesDbContextUnitOfWork> CategoryTransactionDetails {
            get { return GetDetailsCollectionViewModel((CategoryViewModel x) => x.CategoryTransactionDetails, x => x.Transactions, x => x.CategoryID, (x, key) => x.CategoryID = key); }
        }
    }
}
