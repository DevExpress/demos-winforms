using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, long, IDevAVDbUnitOfWork> {
        EmployeeCollectionViewModel ParentViewModel {
            get { return this.GetParentViewModel<EmployeeCollectionViewModel>(); }
        }
        public void ShowMailMerge() {
            ParentViewModel.ShowMailMerge(Entity);
        }
        public void ShowReport() {
            ParentViewModel.ShowReportForSelectedEntity(EmployeeReportType.Profile);
        }
        public void ShowMeetingDialog() {
            MessageBoxService.ShowMessage(string.Format("Schedule meeting with {0}?", Entity.FullName), string.Empty, MessageButton.YesNoCancel);
        }
    }
}
