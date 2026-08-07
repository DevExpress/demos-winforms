using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraBars.Docking2010;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.EmployeeCollectionViewDocumentType)]
    public partial class EmployeeCollectionView : FilterCollectionViewBase {
        public EmployeeCollectionView() {
            InitializeComponent();
            gridControl.Visible = false;
            searchControl.SetupSearchControl(windowsUIButtonPanel);
            
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings() {
            mvvmContext.RegisterService("FlyoutDocumentManagerService", WindowedDocumentManagerService.CreateFlyoutFormService(this));
            mvvmContext.BindTileGrid<EmployeeCollectionViewModel, Employee>(tileView, employeeBindingSource);
            
            var fluentAPI = mvvmContext.OfType<EmployeeCollectionViewModel>();
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).ImageUri = ToolbarExtension.GetImageUri("SortAZ");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[0]).Click += (s, e) => SortEmployees(true);
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).ImageUri = ToolbarExtension.GetImageUri("SortZA");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[1]).Click += (s, e) => SortEmployees(false);
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[3], x => x.New());
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[4], (x, e) => x.Edit(e), x => x.SelectedEntity);
            
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[9], (x, e) => x.ShowTask(e), x => x.SelectedEntity, "Task");
            fluentAPI.BindCommandAndImage(windowsUIButtonPanel.Buttons[10], (x, e) => x.ShowNote(e), x => x.SelectedEntity, "Note");
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[6]).Tag = ToolbarExtension.CreateReportsGallery<EmployeeCollectionViewModel>(fluentAPI, (x, type) => x.ShowReportForSelectedEntity(type));
            ((WindowsUIButton)windowsUIButtonPanel.Buttons[6]).ImageUri = ToolbarExtension.GetImageUri("Print");
        }
        void SortEmployees(bool ascending) {
            var lastName = tileView.Columns["FullName"];
            if(lastName == null)
                return;
            tileView.SortInfo.Clear();
            tileView.SortInfo.Add(new XtraGrid.Columns.GridColumnSortInfo(lastName, ascending ? Data.ColumnSortOrder.Ascending : Data.ColumnSortOrder.Descending));
        }
        protected override void DocumentShownMessageReceived(DocumentShownMessage msg) {
            if(msg.DocumentType != DevAVDbViewModel.EmployeeCollectionViewDocumentType)
                return;
            var fluentAPI = mvvmContext.OfType<EmployeeCollectionViewModel>();
            employeesFilterView.SetViewModel(fluentAPI.ViewModel.FilterViewModel);
            BeginInvoke(new System.Action(() => gridControl.Visible = true));
        }
    }
}
