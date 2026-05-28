using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Common.ViewModel;
using DevExpress.MVVM.Demos.ExpensesDbContextDataModel;
using DevExpress.MVVM.Demos.DataBase;
using DevExpress.MVVM.Demos.Model;

namespace DevExpress.MVVM.Demos.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the ExpensesDbContext data model.
    /// </summary>
    public partial class ExpensesDbContextViewModel : DocumentsViewModel<ExpensesDbContextModuleDescription, IExpensesDbContextUnitOfWork> {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";
        /// <summary>
        /// Creates a new instance of ExpensesDbContextViewModel as a POCO view model.
        /// </summary>
        public static ExpensesDbContextViewModel Create() {
            return ViewModelSource.Create(() => new ExpensesDbContextViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the ExpensesDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExpensesDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected ExpensesDbContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override ExpensesDbContextModuleDescription[] CreateModules() {
            return new ExpensesDbContextModuleDescription[] {
                new ExpensesDbContextModuleDescription("Accounts", "AccountCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Accounts)),
                new ExpensesDbContextModuleDescription("Categories", "CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Categories)),
                new ExpensesDbContextModuleDescription("Transactions", "TransactionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Transactions)),
			};
        }
    }

    public partial class ExpensesDbContextModuleDescription : ModuleDescription<ExpensesDbContextModuleDescription> {
        public ExpensesDbContextModuleDescription(string title, string documentType, string group, Func<ExpensesDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}
