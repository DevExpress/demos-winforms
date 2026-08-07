namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeTaskCollectionViewModel : IFilterTreeViewModelContainer<EmployeeTask> {
        public void Print() {
            this.Print<DevAVDbViewModel>(DevAVDbViewModel.PrintableControlPrintPreviewDocumentType);
        }

        public virtual FilterViewModel<EmployeeTask, EmployeeTask> FilterViewModel { get; set; }
    }
}
