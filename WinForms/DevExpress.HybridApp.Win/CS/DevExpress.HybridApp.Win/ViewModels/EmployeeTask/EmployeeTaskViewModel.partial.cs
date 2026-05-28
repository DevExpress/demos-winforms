using DevExpress.DevAV.Common;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.DevAV.DevAVDbDataModel1;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.ViewModels {
    public partial class EmployeeTaskViewModel : SingleObjectViewModel<EmployeeTask, long, IDevAVDbUnitOfWork> {
        public bool ShouldRemind {
            get { return (Entity != null) && Entity.Reminder; }
            set {
                if(Entity != null && Entity.Reminder != value) {
                    Entity.Reminder = value;
                    this.RaisePropertyChanged(p => p.ShouldRemind);
                }
            }
        }
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            this.RaisePropertyChanged(p => p.ShouldRemind);
        }
        protected override string GetTitle() {
            return (Entity.Owner != null) ? string.Format("Edit Task <color=#FF646464>{0}</color>", Entity.Owner.FullName) : string.Empty;
        }
        protected override string GetTitleForNewEntity() {
            return "Task " + CommonResources.Entity_New;
        }
    }
}
