namespace DevExpress.DevAV.ViewModels {
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class TaskCollectionViewModel : ISupportCustomFilters, ISupportNewParent {
        public override void Refresh() {
            base.Refresh();
            RaiseReload();
        }
        public bool CanNew() {
            IDocumentManagerService service = GetDocumentManagerService();
            if(service == null)
                return false;
            foreach(var doc in service.Documents) {
                var newTaskViewModel = doc.Content as TaskViewModel;
                if(newTaskViewModel != null && newTaskViewModel.IsNew())
                    return false;
            }
            return true;
        }
        IDocumentManagerService GetDocumentManagerService() {
            var service = (UnitOfWorkPolicy == Mvvm.ViewModel.UnitOfWorkPolicy.Shared) ?
                WindowedDocumentManagerService : DocumentManagerService;
            return service ?? DocumentManagerService;
        }
        public virtual IEnumerable<EmployeeTask> Selection { get; set; }
        protected virtual void OnSelectionChanged() {
            this.RaiseCanExecuteChanged(x => x.GroupSelection());
        }
        public event EventHandler Reload;
        public event EventHandler CustomFilter;
        public event EventHandler CustomFiltersReset;
        public event EventHandler CustomGroup;
        public event EventHandler<GroupEventArgs<EmployeeTask>> CustomGroupFromSelection;

        [Command]
        public void ShowViewSettings() {
            var dms = this.GetService<IDocumentManagerService>("View Settings");
            if (dms != null) {
                var document = dms.Documents.FirstOrDefault(d => d.Content is ViewSettingsViewModel);
                if (document == null)
                    document = dms.CreateDocument("View Settings", null, null, this);
                document.Show();
            }
        }
        [Command]
        public void NewGroup() {
            RaiseCustomGroup();
        }
        [Command]
        public void GroupSelection() {
            RaiseCustomGroupFromSelection();
        }
        public bool CanGroupSelection() {
            return (Selection != null) && Selection.Any();
        }
        [Command]
        public void NewCustomFilter() {
            RaiseCustomFilter();
        }
        [Command]
        public void ResetCustomFilters() {
            RaiseCustomFiltersReset();
        }
        [Command]
        public void ShowAllFolders() {
            RaiseShowAllFolders();
        }
        void RaiseShowAllFolders() {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if (mainViewModel != null)
                mainViewModel.RaiseShowAllFolders();
        }
        void RaiseCustomGroupFromSelection() {
            EventHandler<GroupEventArgs<EmployeeTask>> handler = CustomGroupFromSelection;
            if (handler != null)
                handler(this, new GroupEventArgs<EmployeeTask>(Selection));
        }
        void RaiseReload() {
            EventHandler handler = Reload;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFilter() {
            EventHandler handler = CustomFilter;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFiltersReset() {
            EventHandler handler = CustomFiltersReset;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomGroup() {
            EventHandler handler = CustomGroup;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}
