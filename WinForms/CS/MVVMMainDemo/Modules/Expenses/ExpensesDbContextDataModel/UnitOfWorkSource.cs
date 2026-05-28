using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Common.DataModel.EntityFramework;
using DevExpress.MVVM.Demos.DataBase;

namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {
        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IExpensesDbContextUnitOfWork>(() => new ExpensesDbContextUnitOfWork(() => new ExpensesDbContext()));
        }
    }
}
