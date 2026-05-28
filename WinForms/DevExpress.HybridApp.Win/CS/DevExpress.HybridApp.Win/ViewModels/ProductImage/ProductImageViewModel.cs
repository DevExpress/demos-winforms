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
    /// Represents the single ProductImage object view model.
    /// </summary>
    public partial class ProductImageViewModel : SingleObjectViewModel<ProductImage, long, IDevAVDbUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ProductImageViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductImageViewModel Create(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ProductImageViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductImageViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductImageViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductImageViewModel(IUnitOfWorkFactory<IDevAVDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ProductImages, x => x.Id)
        {
        }

        /// <summary>
        /// The view model that contains a look-up collection of Pictures for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Picture> LookUpPictures
        {
            get { return GetLookUpEntitiesViewModel((ProductImageViewModel x) => x.LookUpPictures, x => x.Pictures); }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts
        {
            get { return GetLookUpEntitiesViewModel((ProductImageViewModel x) => x.LookUpProducts, x => x.Products); }
        }
    }
}
