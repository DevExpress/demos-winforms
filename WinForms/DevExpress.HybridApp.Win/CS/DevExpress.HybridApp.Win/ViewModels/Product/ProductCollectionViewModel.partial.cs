using System.Collections.Generic;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.ViewModels {
    public partial class ProductCollectionViewModel : IFilterTreeViewModelContainer<Product, ProductInfoWithSales> {
        protected override void OnEntitiesLoaded(IDevAVDbUnitOfWork unitOfWork, IEnumerable<ProductInfoWithSales> entities) {
            base.OnEntitiesLoaded(unitOfWork, entities);
            DevAV.QueriesHelper.UpdateMonthlySales(unitOfWork.OrderItems, entities);
        }

        public void CustomFilter() {
            Messenger.Default.Send(new CreateCustomFilterMessage<Product>());
        }

        public virtual FilterViewModel<Product, ProductInfoWithSales> FilterViewModel { get; set; }
    }
}
