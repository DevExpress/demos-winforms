using DevExpress.MVVM.Demos.Common.ViewModel;
using DevExpress.MVVM.Demos.ExpensesDbContextDataModel;
using DevExpress.MVVM.Demos.Model;

namespace DevExpress.MVVM.Demos.ViewModels {
    public partial class AccountViewModel {
        //The bindable property that returns all transactions wired to a specific account
        public CollectionViewModel<Transaction, long, IExpensesDbContextUnitOfWork> AccountTransactionDetails {
            get { return GetDetailsCollectionViewModel((AccountViewModel x) => x.AccountTransactionDetails, x => x.Transactions, x => x.AccountID, (x, key) => x.AccountID = key); }
        }
    }
}
