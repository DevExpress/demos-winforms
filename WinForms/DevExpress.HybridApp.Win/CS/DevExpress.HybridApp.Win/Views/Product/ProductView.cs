using System;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPdfViewer;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.ProductViewDocumentType)]
    public partial class ProductView : BaseViewWithWinUIButtons {
        public ProductView() {
            InitializeComponent();
            dataLayoutControl.SetupLayoutControl();
            PopulateEnums();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!mvvmContext.IsDesignMode) {
                var fluentAPI = mvvmContext.OfType<ProductViewModel>();
                UpdatePdfViewerAndLayoutItems(fluentAPI.ViewModel.Entity);
            }
        }
        void InitBindings() {
            var fluentAPI = mvvmContext.OfType<ProductViewModel>();
            fluentAPI.SetTrigger(x => x.Entity, product =>
                UpdatePdfViewerAndLayoutItems(product));
            fluentAPI.SetObjectDataSourceBinding(productBindingSource, x => x.Entity, x => x.Update());
            fluentAPI.BindCommand(backWindowsUIButtonPanel.Buttons[0] as WindowsUIButton, x => x.Close());
            fluentAPI.SetBinding(cbSupport.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(cbProductEngineer.Properties, r => r.DataSource, x => x.LookUpEmployees.Entities);
            fluentAPI.SetBinding(productNameLabelControl, l => l.Text, x => x.Entity.Name);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.SaveAndClose());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[1], x => x.Close(), "Cancel");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], (x, t) => x.ZoomIn(t), p => 10f, "ZoomIn");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[4], (x, t) => x.ZoomOut(t), p => 10f, "ZoomOut");
            fluentAPI.WithEvent<PdfViewer, PdfZoomChangedEventArgs>(pdfViewer, "ZoomChanged").
                SetBinding(x => x.ZoomFactor, args => args.ZoomFactor, (viewer, v) => viewer.ZoomFactor = v);
        }
        void UpdatePdfViewerAndLayoutItems(Product product) {
            if(product != null && product.Brochure != null)
                pdfViewer.LoadDocument(product.Brochure);
            var fluentAPI = mvvmContext.OfType<ProductViewModel>();
            bool isNew = fluentAPI.ViewModel.IsNew();
            productNameLayoutControlItem.Visibility =
                pdfLayoutControlItem.Visibility =
                productSimpleLabelItem.Visibility = isNew ? LayoutVisibility.Never : LayoutVisibility.Always;
            ItemForName.Visibility = isNew ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        void PopulateEnums() {
            CategoryImageComboBoxEdit.Properties.Items.AddEnum<ProductCategory>();
        }
    }
}
