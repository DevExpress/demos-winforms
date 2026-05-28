using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.MVVM.Demos.Common.Utils;
using DevExpress.MVVM.Demos.ExpensesDbContextDataModel;
using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Model;
using DevExpress.MVVM.Demos.DataBase;
using DevExpress.MVVM.Demos.Common.ViewModel;

namespace DevExpress.MVVM.Demos.ViewModels {
    /// <summary>
    /// Represents the single Account object view model.
    /// </summary>
    public partial class AccountViewModel : SingleObjectViewModel<Account, long, IExpensesDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AccountViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountViewModel Create(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AccountViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountViewModel(IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts, x => x.Name) {
        }
    }
}
