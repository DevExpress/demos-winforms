using DevExpress.DentalClinic.ViewModel;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class AnalyticsView : XtraUserControl {
        public AnalyticsView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
            }
        }
        void InitializeNavigation() {
            var navigationService = DocumentManagerService.Create(tabPane);
            navigationService.UseDeferredLoading = Utils.DefaultBoolean.True;
            mvvmContext.RegisterService(navigationService);
            var fluentApi = mvvmContext.OfType<AnalyticsViewModel>();
            fluentApi.ViewModel.Load();
        }
    }
}
