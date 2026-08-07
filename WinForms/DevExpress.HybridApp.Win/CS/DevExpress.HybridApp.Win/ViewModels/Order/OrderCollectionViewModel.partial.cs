using System.Collections.Generic;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;

namespace DevExpress.DevAV.ViewModels {
    public partial class OrderCollectionViewModel : CollectionViewModel<Order, long, IDevAVDbUnitOfWork> {
        List<SalesInfo> sales;
        public void Print() {
            this.Print<DevAVDbViewModel>(DevAVDbViewModel.PrintableControlPrintPreviewDocumentType);
        }
        protected override void OnInitializeInRuntime() {
            if(Sales.Count > 0)
                SelectedListProductInfo = Sales[0].ListProductInfo;
        }
        public List<SalesInfo> Sales {
            get {
                if(sales == null)
                    sales = QueriesHelper.GetSales(CreateUnitOfWork().OrderItems);
                return sales;
            }
        }
        public virtual List<SalesProductInfo> SelectedListProductInfo {
            get;
            set;
        }
        public virtual DateRange DateRange {
            get;
            set;
        }
    }
}
