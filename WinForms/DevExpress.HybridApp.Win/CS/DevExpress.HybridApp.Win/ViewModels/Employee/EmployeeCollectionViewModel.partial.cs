using System.ComponentModel;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.DevAV.Services;
using System;
using System.Linq;

namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeCollectionViewModel : IFilterTreeViewModelContainer<Employee> {
        public virtual FilterViewModel<Employee, Employee> FilterViewModel { get; set; }

        public IDocumentManagerService FlyoutDocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("FlyoutDocumentManagerService"); }
        }
        protected override void OnSelectedEntityChanged() {
            base.OnSelectedEntityChanged();
            this.RaiseCanExecuteChanged(x => x.ShowReportForSelectedEntity(EmployeeReportType.None));
            this.RaiseCanExecuteChanged(x => x.ShowMailMerge(null));
            this.RaiseCanExecuteChanged(x => x.ShowTask(null));
            this.RaiseCanExecuteChanged(x => x.ShowNote(null));
        }

        public bool CanShowReportForSelectedEntity(EmployeeReportType employeeReportType) {
            return (employeeReportType != EmployeeReportType.Profile) || (SelectedEntity != null);
        }
        public void ShowReportForSelectedEntity(EmployeeReportType employeeReportType) {
            DocumentManagerService.CreateDocument(DevAVDbViewModel.EmployeeReportViewDocumentType, 
                    new object[] { GetReport(employeeReportType), employeeReportType }
                , this).Show();
        }
        IReportInfo GetReport(EmployeeReportType reportType) {
            switch (reportType) {
                case EmployeeReportType.TaskList:
                    return ReportInfoFactory.EmployeeTaskList(unitOfWorkFactory.CreateUnitOfWork().Tasks.ToList());
                case EmployeeReportType.Profile:
                    return ReportInfoFactory.EmployeeProfile(SelectedEntity, EmployeeEvaluationsPrintMode.IncludeEvaluations);
                case EmployeeReportType.Summary:
                    return ReportInfoFactory.EmployeeSummary(Entities);
                case EmployeeReportType.Directory:
                    return ReportInfoFactory.EmployeeDirectory(Entities);
            }
            throw new ArgumentException("GetReport", "reportType");
        }
        public bool CanShowMailMerge(Employee employee) {
            return employee != null;
        }
        public void ShowMailMerge(Employee employee) {
            var mailMergeViewModel = EmployeeMailMergeViewModel.Create(unitOfWorkFactory, x => x.Employees, employee == null ? null as long? : employee.Id);
            DocumentManagerService.CreateDocument(DevAVDbViewModel.EmployeeMailMergeViewDocumentType, mailMergeViewModel, null, this).Show();
        }
        public bool CanShowTask(Employee employee) {
            return employee != null;
        }
        public void ShowTask(Employee employee) {
            FlyoutDocumentManagerService.ShowNewEntityDocument<EmployeeTask>(this, task => task.OwnerId = employee.Id);
        }
        public bool CanShowNote(Employee employee) {
            return employee != null;
        }
        public void ShowNote(Employee employee) {
            FlyoutDocumentManagerService.ShowNewEntityDocument<Evaluation>(this, note => note.EmployeeId = employee.Id);
        }
    }
}
