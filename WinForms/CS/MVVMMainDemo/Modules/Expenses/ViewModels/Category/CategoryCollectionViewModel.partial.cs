namespace DevExpress.MVVM.Demos.ViewModels {
    partial class CategoryCollectionViewModel {
        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            DevExpress.Mvvm.Messenger.Default.Register<AddNewMessage>(this, this, false, m => New());
        }
    }
}
