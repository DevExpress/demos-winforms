using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.MVVM.Demos.Common.Utils;
using DevExpress.MVVM.Demos.ExpensesDbContextDataModel;
using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Model;
using DevExpress.MVVM.Demos.DataBase;
using DevExpress.MVVM.Demos.Common.ViewModel;

namespace DevExpress.MVVM.Demos.ViewModels {
    /// <summary>
    /// Represents the Transactions collection view model.
    /// </summary>
    public partial class TransactionCollectionViewModel : CollectionViewModel<Transaction, long, IExpensesDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TransactionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TransactionCollectionViewModel Create(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TransactionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TransactionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TransactionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TransactionCollectionViewModel(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Transactions, null, NewEntityInitializer) {
        }
    }
}
