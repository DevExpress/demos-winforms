using System;
using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Common.DataModel.EntityFramework;
using DevExpress.MVVM.Demos.DataBase;
using DevExpress.MVVM.Demos.Model;

namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel {
    /// <summary>
    /// A ExpensesDbContextUnitOfWork instance that represents the run-time implementation of the IExpensesDbContextUnitOfWork interface.
    /// </summary>
    public class ExpensesDbContextUnitOfWork : DbUnitOfWork<ExpensesDbContext>, IExpensesDbContextUnitOfWork {
        public ExpensesDbContextUnitOfWork(Func<ExpensesDbContext> contextFactory)
            : base(contextFactory) {
        }
        IRepository<Account, long> IExpensesDbContextUnitOfWork.Accounts {
            get { return GetRepository(x => x.Set<Account>(), x => x.ID); }
        }
        IRepository<Category, long> IExpensesDbContextUnitOfWork.Categories {
            get { return GetRepository(x => x.Set<Category>(), x => x.ID); }
        }
        IRepository<Transaction, long> IExpensesDbContextUnitOfWork.Transactions {
            get { return GetRepository(x => x.Set<Transaction>(), x => x.ID); }
        }
    }
}
