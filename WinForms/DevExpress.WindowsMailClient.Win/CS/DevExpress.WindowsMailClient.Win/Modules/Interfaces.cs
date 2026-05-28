namespace DevExpress.WindowsMailClient.Win.Modules {
    public interface ISupportViewModel {
        object ViewModel { get; }
        void ParentViewModelAttached();
    }
}
