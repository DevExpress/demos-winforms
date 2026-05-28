using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeTaskCollectionViewModel : IFilterTreeViewModelContainer<EmployeeTask> {
        public void Print() {
            this.Print<DevAVDbViewModel>(DevAVDbViewModel.PrintableControlPrintPreviewDocumentType);
        }

        public virtual FilterViewModel<EmployeeTask, EmployeeTask> FilterViewModel { get; set; }
    }
}
