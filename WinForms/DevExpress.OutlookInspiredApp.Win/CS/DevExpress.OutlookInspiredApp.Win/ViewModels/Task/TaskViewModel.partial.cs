namespace DevExpress.DevAV.ViewModels {
    using System;

    partial class TaskViewModel : ISupportNewChid {
        public new bool IsNew() { return base.IsNew(); }
        protected override string GetTitle() {
            return Entity.Subject;
        }
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler EntityChanged;
    }
    public partial class SynchronizedTaskViewModel : TaskViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}
