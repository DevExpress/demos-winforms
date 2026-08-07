using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.UI;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.ProductCollectionViewDocumentType)]
    public partial class ProductCollectionView : FilterCollectionViewBase {
        public ProductCollectionView() {
            InitializeComponent();
            gridView.SetupCollectionGrid();
            searchControl.SetupSearchControl(windowsUIButtonPanel);
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            mvvmContext.BindCollectionGrid<ProductCollectionViewModel, Product, ProductInfoWithSales>(gridView, productBindingSource);

            var fluentAPI = mvvmContext.OfType<ProductCollectionViewModel>();
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.New());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[1], (x, e) => x.Edit(e), x => x.SelectedEntity);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], x => x.CustomFilter(), "CustomFilter");
        }
        protected override void DocumentShownMessageReceived(DocumentShownMessage msg) {
            if(msg.DocumentType != DevAVDbViewModel.ProductCollectionViewDocumentType) {
                return;
            }
            var fluentAPI = mvvmContext.OfType<ProductCollectionViewModel>();
            productFilterView.SetViewModel(fluentAPI.ViewModel.FilterViewModel);
        }
    }
}
