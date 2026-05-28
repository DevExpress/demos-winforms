using DevExpress.DentalClinic.Services;
using DevExpress.DentalClinic.ViewModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Threading.Tasks;

namespace DevExpress.DentalClinic {
    public partial class MainForm : FluentDesignForm {
        static MainForm() {
            // Global setting for all dialogs UI
            MVVMContext.RegisterFlyoutDialogService();
            //MVVMContext.RegisterXtraMessageBoxService();
            ServiceContainer.Default.RegisterService(new LoginService());
            ServiceContainer.Default.RegisterService(new PrintReportService());
        }
        public MainForm() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode) {
                InitializeNavigation();
                InitializeBindings();
            }
        }
        public MainForm(Task rescheduleAppointments)
            : this() {
            this.rescheduleAppointments = rescheduleAppointments;
        }
        protected override FormShowMode ShowMode {
            get { return FormShowMode.AfterInitialization; }
        }
        void InitializeNavigation() {
            // Main Navigation Service for all child views
            var navigationService = NavigationService.Create(navigationFrame);
            mvvmContext.RegisterDefaultService(navigationService);
            // Flyout Service for all child views
            var flyoutService = WindowedDocumentManagerService.CreateFlyoutFormService();
            flyoutService.FormStyle = (form) => {
                var flyout = form as FlyoutDialog;
                flyout.Properties.Style = FlyoutStyle.Popup;
            };
            mvvmContext.RegisterDefaultService("Flyout", flyoutService);
        }
        void InitializeBindings() {
            var fluentApi = mvvmContext.OfType<NavigationViewModel>();
            //UI
            fluentApi.BindCommand(darkThemeBBI, x => x.ChangeTheme);
            // Navigation Items
            fluentApi.BindCommand(loginButtonItem, x => x.OpenLoginView);
            fluentApi.SetBinding(usersViewItem, x => x.Visible, x => x.ShowUserCollectionView);
            fluentApi.WithEvent<ElementClickEventArgs>(accordionControl, nameof(accordionControl.ElementClick))
                .EventToCommand(x => x.NavigateTo, args => CreateNavigateArgs(args));
            // BreadCrumb Navigation
            fluentApi.SetBinding(breadCrumbEdit1, x => x.SelectedNode, x => x.SelectedNode);
            fluentApi.SetBinding(breadCrumbEdit1, x => x.EditValue, x => x.NavigationPath);
            fluentApi.SetBinding(pnlNavigationBar, x => x.Visible, x => x.NavigationBarVisible);
            var navigationContext = new NavigationContext(breadCrumbEdit1.Properties.Nodes);
            fluentApi.WithEvent(this, nameof(Load))
                .EventToCommand(x => x.Load, (EventArgs args) => navigationContext);
            fluentApi.WithEvent<BreadCrumbNodeClickEventArgs>(breadCrumbEdit1.Properties, nameof(breadCrumbEdit1.Properties.NodeClick))
                .EventToCommand(x => x.NavigateTo, args => CreateNavigateArgs(args));
            // UI synchronization
            accordionControl.SelectedElement = patientsViewItem;
            fluentApi.SetTrigger(x => x.CurrentViewType, viewType => {
                if(viewType == nameof(View.PatientCollectionView)) {
                    accordionControl.SelectedElement = patientsViewItem;
                }
            });
            fluentApi.SetTrigger(x => x.OverlayFormTrigger, showOverlay => {
                if(showOverlay) {
                    overlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(mainPanel, new OverlayWindowOptions() {
                        Opacity = 1f,
                        BackColor = mainPanel.BackColor,
                        FadeIn = false,
                        FadeOut = true
                    });
                }
                else DisposeHelper.Dispose(ref overlaySplashScreenHandle);
            });
        }
        IOverlaySplashScreenHandle overlaySplashScreenHandle;
        Task rescheduleAppointments;
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            SplashScreenManager.CloseForm(false);
            var loginService = ServiceContainer.Default.GetRequiredService<ILoginService>();
            if(!loginService.Login(Properties.Settings.Default.UserName)) {
                Close();
                return;
            }
            if(rescheduleAppointments != null)
                rescheduleAppointments.Wait();
        }
        NavigateArgs CreateNavigateArgs(EventArgs eventArgs) {
            string path;
            Action cancelAction;
            if(eventArgs is ElementClickEventArgs) {
                var args = eventArgs as ElementClickEventArgs;
                path = args.Element.Tag as string;
                cancelAction = () => args.Handled = true;
            }
            else {
                var args = eventArgs as BreadCrumbNodeClickEventArgs;
                path = args.Node.Path;
                cancelAction = () => args.Handled = true;
            }
            bool showOverlay = (path == nameof(View.AnalyticsView)) 
                || (path == nameof(View.SchedulerView));
            return new NavigateArgs(path, cancelAction, showOverlay);
        }
    }
}
