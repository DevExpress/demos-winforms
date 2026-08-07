using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM.UI;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.EmployeeTaskCollectionViewDocumentType)]
    public partial class EmployeeTaskCollectionView : FilterCollectionViewBase {
        public EmployeeTaskCollectionView() {

            InitializeComponent();
            gridView.SetupCollectionGrid();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            mvvmContext.BindCollectionGrid<EmployeeTaskCollectionViewModel, EmployeeTask>(gridView, employeeTaskBindingSource);

            var fluentAPI = mvvmContext.OfType<EmployeeTaskCollectionViewModel>();
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[0], x => x.New());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[1], (x, task) => x.Edit(task), x => x.SelectedEntity);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[2], (x, task) => x.Delete(task), x => x.SelectedEntity);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[4], x => x.Print());

            mvvmContext.RegisterService(PrintableControlPreviewService.Create(gridControl));
        }
        protected override void DocumentShownMessageReceived(DocumentShownMessage msg) {
            if(msg.DocumentType != DevAVDbViewModel.EmployeeTaskCollectionViewDocumentType)
                return;
            var fluentAPI = mvvmContext.OfType<EmployeeTaskCollectionViewModel>();
            employeeTaskFilterView.SetViewModel(fluentAPI.ViewModel.FilterViewModel);
        }
    }
}
