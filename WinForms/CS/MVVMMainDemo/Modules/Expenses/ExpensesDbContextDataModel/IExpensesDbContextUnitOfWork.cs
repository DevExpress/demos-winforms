using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Model;

namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel {
    /// <summary>
    /// IExpensesDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IExpensesDbContextUnitOfWork : IUnitOfWork {
        /// <summary>
        /// The Account entities repository.
        /// </summary>
        IRepository<Account, long> Accounts { get; }
        /// <summary>
        /// The Category entities repository.
        /// </summary>
        IRepository<Category, long> Categories { get; }
        /// <summary>
        /// The Transaction entities repository.
        /// </summary>
        IRepository<Transaction, long> Transactions { get; }
    }
}
