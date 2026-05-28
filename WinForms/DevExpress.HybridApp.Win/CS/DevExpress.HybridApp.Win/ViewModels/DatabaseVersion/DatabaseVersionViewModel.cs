using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV;
using DevExpress.DevAV.Common.ViewModel;

namespace DevExpress.DevAV.ViewModels
{
    /// <summary>
    /// Represents the single DatabaseVersion object view model.
    /// </summary>
    public partial class DatabaseVersionViewModel : SingleObjectViewModel<DatabaseVersion, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of DatabaseVersionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DatabaseVersionViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new DatabaseVersionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseVersionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DatabaseVersionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DatabaseVersionViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Version, x => x.Date)
        {
        }
    }
}
