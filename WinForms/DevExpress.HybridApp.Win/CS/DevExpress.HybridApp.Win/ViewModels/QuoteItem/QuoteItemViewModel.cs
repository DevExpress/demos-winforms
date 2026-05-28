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
    /// Represents the single QuoteItem object view model.
    /// </summary>
    public partial class QuoteItemViewModel : SingleObjectViewModel<QuoteItem, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of QuoteItemViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static QuoteItemViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new QuoteItemViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the QuoteItemViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QuoteItemViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected QuoteItemViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.QuoteItems, x => x.ProductUnits)
        {
        }

        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts
        {
            get { return GetLookUpEntitiesViewModel((QuoteItemViewModel x) => x.LookUpProducts, x => x.Products); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Quotes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Quote> LookUpQuotes
        {
            get { return GetLookUpEntitiesViewModel((QuoteItemViewModel x) => x.LookUpQuotes, x => x.Quotes); }
        }
    }
}
