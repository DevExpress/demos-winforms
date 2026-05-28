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
    /// Represents the Accounts collection view model.
    /// </summary>
    public partial class AccountCollectionViewModel : CollectionViewModel<Account, long, IExpensesDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AccountCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountCollectionViewModel Create(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AccountCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountCollectionViewModel(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts) {
        }
    }
}
