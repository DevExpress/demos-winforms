namespace TodoApp {
    using DevExpress.Utils.MVVM.Services;
    using DevExpress.XtraEditors;
    using TodoApp.ViewModels;

    public partial class MainView : XtraForm {
        public MainView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        void InitializeNavigation() {
            // explicit type resolution (to avoid conflicts with runtime code-examples)
            var navigationServiceInstance = NavigationService.Create(navigationFrame);
            navigationServiceInstance.UseDeferredLoading = DevExpress.Utils.DefaultBoolean.False;
            navigationFrame.QueryControl += (s, e) => {
                if(e.ControlName == "AppLogo")
                    e.Control = new global::TodoApp.Views.AppLogo();
                if(e.ControlName == "ItemsView")
                    e.Control = new global::TodoApp.Views.ItemsView();
                if(e.ControlName == "ItemView")
                    e.Control = new global::TodoApp.Views.ItemView();
            };
            mvvmContext.RegisterService(navigationServiceInstance);
        }
        void InitializeBindings() {
            var fluent = mvvmContext.OfType<AppViewModel>();
            fluent.SetBinding(this, f => f.Text, x => x.Title);
            fluent.WithEvent(this, "Shown")
                .EventToCommand(x => x.OnShown);
        }
    }
}
