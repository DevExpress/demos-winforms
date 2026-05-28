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
    /// Represents the single Crest object view model.
    /// </summary>
    public partial class CrestViewModel : SingleObjectViewModel<Crest, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CrestViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CrestViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CrestViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CrestViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CrestViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CrestViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Crests, x => x.CityName)
        {
        }
    }
}
